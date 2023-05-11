using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Build
{
    public partial class Form1 : Form
    {
        private readonly string IP_ADDRESS = "127.0.0.1"; // Change this to the IP address of the server
        private readonly int PORT = 4444; // Change this to the port of the server
        private TcpClient client;
        private NetworkStream stream;
        private string username;
        private Thread receiveThread;
        private bool receiving;

        List<GroupChat> groupChats = new List<GroupChat>();
        public class GroupChat
        {
            public string GroupName { get; set; }
            public List<string> Members { get; set; }

            public GroupChat(string groupName)
            {
                GroupName = groupName;
                Members = new List<string>();
            }

            public void AddMember(string member)
            {
                Members.Add(member);
            }
        }
        public Form1()
        {
            InitializeComponent();
            receiving = false;
            btn_create_groupchat.Click += btn_create_groupchat_Click;
            comboBoxGroupChat.SelectedIndexChanged += comboBoxGroupChat_SelectedIndexChanged;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseConnection();
        }
        private async void btn_send_message_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                MessageBox.Show("You are not connected to the server.");
                return;
            }
            if (string.IsNullOrEmpty(txt_message.Text))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }
            if (comboBoxClientsOnline.SelectedItem == null)
            {
                MessageBox.Show("Please select a recipient.");
                return;
            }

            try
            {
                string recipient = comboBoxClientsOnline.SelectedItem.ToString();
                string messageToSend = "To:" + recipient + " Message:" + txt_message.Text;
                Send(messageToSend, MessageType.Private);
                txt_message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
        }

        private void btn_connect_to_server_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(IP_ADDRESS, PORT);

                stream = client.GetStream();
                AddMessage("Connected to server.");

                // Send client IP address and port number to the server
                string clientInfo = String.Format("ClientInfo:{0}:{1}", ((IPEndPoint)client.Client.LocalEndPoint).Address.ToString(), ((IPEndPoint)client.Client.LocalEndPoint).Port.ToString());
                Send(clientInfo, MessageType.Private);

                // Start the receive thread
                receiving = true;
                receiveThread = new Thread(new ThreadStart(Receive));
                receiveThread.Start();
                btn_connect_to_server.Enabled = false;
                btn_disconnect.Enabled = true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Could not connect to server. Please make sure the server is online.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Send(string message, MessageType messageType)
        {
            string prefixedMessage = messageType == MessageType.Private ? "Private:" + message : "Group:" + message;
            byte[] buffer = Encoding.UTF8.GetBytes(prefixedMessage);
            stream.Write(buffer, 0, buffer.Length);
        }

        private void Receive()
        {
            while (receiving)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        if (message.StartsWith("Private:"))
                        {
                            ControlInvoke(rch_txt_messages, () => rch_txt_messages.AppendText(message.Substring("Private:".Length) + Environment.NewLine));
                        }
                        else if (message.StartsWith("Group:"))
                        {
                            ControlInvoke(rch_groupchat, () => rch_groupchat.AppendText(message.Substring("Group:".Length) + Environment.NewLine));
                        }
                        else if (message.StartsWith("ConnectedClients:"))
                        {
                            string[] clients = message.Substring("ConnectedClients:".Length).Split(',');
                            ControlInvoke(comboBoxClientsOnline, () => UpdateConnectedClientsComboBox(clients));
                        }
                        else
                        {
                            // Handle other message types or display them in a different TextBox
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (!client.Connected)
                    {
                        MessageBox.Show("Connection lost.");
                        receiving = false;
                    }
                    else
                    {
                        ControlInvoke(rch_txt_messages, () => rch_txt_messages.AppendText("Error receiving data: " + ex.Message + Environment.NewLine));
                    }
                }
            }
        }
        private void UpdateConnectedClientsComboBox(string[] clients)
        {
            comboBoxClientsOnline.Items.Clear();
            comboBoxgroupOnlineMembers.Items.Clear(); // new line
            comboBoxClientsOnline.Items.Add($"{IP_ADDRESS}:{PORT}");
            foreach (string client in clients)
            {
                if (!string.IsNullOrEmpty(client))
                {
                    comboBoxClientsOnline.Items.Add(client);
                    comboBoxgroupOnlineMembers.Items.Add(client); // new line
                }
            }
        }

        private void AddMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => AddMessage(message)));
            }
            else
            {
                rch_txt_messages.AppendText(message + Environment.NewLine);
            }
        }
        delegate void UniversalVoidDelegate();

        public static void ControlInvoke(Control control, Action function)
        {

            if (control.IsDisposed || control.Disposing)
            {
                return;
            }
            if (control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }
        private void CloseConnection()
        {
            if (client != null && client.Connected)
            {
                receiving = false;
                receiveThread.Join();
                stream.Close();
                client.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_connect_to_server.Enabled = true;
            btn_disconnect.Enabled = false;
            comboBoxgroupOnlineMembers.Enabled = false;
            btnAddToGroupChat.Enabled = false;
        }

        private async void btn_disconnect_Click(object sender, EventArgs e)
        {
            btn_connect_to_server.Enabled = true;
            btn_disconnect.Enabled = false;

            try
            {
                // Send a disconnect message
                string disconnectMessage = "Disconnecting";
                byte[] messageBytes = Encoding.UTF8.GetBytes(disconnectMessage);
                await stream.WriteAsync(messageBytes, 0, messageBytes.Length);

                // Close the connection
                client.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error disconnecting: " + ex.Message);
            }
        }

        private async void btn_group_send_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                MessageBox.Show("You are not connected to the server.");
                return;
            }

            if (string.IsNullOrEmpty(txt_groupchat.Text))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            if (comboBoxGroupChat.Items.Count == 0)
            {
                MessageBox.Show("Please add clients to the group chat.");
                return;
            }

            try
            {
                foreach (var recipient in comboBoxGroupChat.Items)
                {
                    string messageToSend = "To:" + recipient.ToString() + " Message:" + txt_groupchat.Text;
                    Send(messageToSend, MessageType.Group);
                }
                txt_groupchat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending group message: " + ex.Message);
            }
        }


        private void btnAddToGroupChat_Click(object sender, EventArgs e)
        {
            if (comboBoxgroupOnlineMembers.SelectedItem == null)
            {
                MessageBox.Show("Please select a client to add to the group chat.");
                return;
            }

            string selectedClient = comboBoxgroupOnlineMembers.SelectedItem.ToString();
            if (comboBoxGroupChat.SelectedItem == null)
            {
                MessageBox.Show("Please select a group chat to add the client.");
                return;
            }

            string selectedGroup = comboBoxGroupChat.SelectedItem.ToString();
            GroupChat group = groupChats.FirstOrDefault(gc => gc.GroupName == selectedGroup);
            if (group == null)
            {
                MessageBox.Show("Selected group chat not found.");
                return;
            }

            if (!group.Members.Contains(selectedClient))
            {
                group.AddMember(selectedClient);
                MessageBox.Show($"Client '{selectedClient}' added to the group chat '{selectedGroup}'.");
            }
            else
            {
                MessageBox.Show($"Client '{selectedClient}' is already a member of the group chat '{selectedGroup}'.");
            }
        }


        private void btn_create_groupchat_Click(object sender, EventArgs e)
        {
            string groupName = txt_groupname.Text;
            if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Please enter a group name.");
                return;
            }

            GroupChat group = groupChats.FirstOrDefault(gc => gc.GroupName == groupName);
            if (group == null)
            {
                group = new GroupChat(groupName);
                groupChats.Add(group);
                comboBoxGroupChat.Items.Add(groupName);
                MessageBox.Show($"Group '{groupName}' created.");
            }
            else
            {
                MessageBox.Show($"Group '{groupName}' already exists.");
            }

            // Clear the group name textbox
            txt_groupname.Text = "";
            comboBoxgroupOnlineMembers.Enabled = true;
            btnAddToGroupChat.Enabled = true;
        }
        private void comboBoxGroupChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string groupName = comboBoxGroupChat.SelectedItem.ToString();
            GroupChat selectedGroup = groupChats.FirstOrDefault(gc => gc.GroupName == groupName);
            if (selectedGroup != null)
            {
                // You can display the members of the selected group somewhere in your form.
                lbl_group_participants.Text = "Group Participants: " + string.Join(", ", selectedGroup.Members);
            }
        }

        public enum MessageType
        {
            Private,
            Group
        }
    }
}

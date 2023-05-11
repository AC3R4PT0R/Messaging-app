namespace Client_Build
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rch_txt_messages = new System.Windows.Forms.RichTextBox();
            this.btn_connect_to_server = new System.Windows.Forms.Button();
            this.btn_send_message = new System.Windows.Forms.Button();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.comboBoxClientsOnline = new System.Windows.Forms.ComboBox();
            this.lbl_view_clients = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_create_groupchat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_groupname = new System.Windows.Forms.TextBox();
            this.comboBoxgroupOnlineMembers = new System.Windows.Forms.ComboBox();
            this.lbl_group_participants = new System.Windows.Forms.Label();
            this.btnAddToGroupChat = new System.Windows.Forms.Button();
            this.comboBoxGroupChat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_groupchat = new System.Windows.Forms.TextBox();
            this.btn_group_send = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.Label();
            this.rch_groupchat = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client_Build_Main";
            // 
            // rch_txt_messages
            // 
            this.rch_txt_messages.Location = new System.Drawing.Point(26, 28);
            this.rch_txt_messages.Name = "rch_txt_messages";
            this.rch_txt_messages.Size = new System.Drawing.Size(364, 334);
            this.rch_txt_messages.TabIndex = 1;
            this.rch_txt_messages.Text = "";
            // 
            // btn_connect_to_server
            // 
            this.btn_connect_to_server.Location = new System.Drawing.Point(846, 23);
            this.btn_connect_to_server.Name = "btn_connect_to_server";
            this.btn_connect_to_server.Size = new System.Drawing.Size(127, 23);
            this.btn_connect_to_server.TabIndex = 2;
            this.btn_connect_to_server.Text = "Connect to Server";
            this.btn_connect_to_server.UseVisualStyleBackColor = true;
            this.btn_connect_to_server.Click += new System.EventHandler(this.btn_connect_to_server_Click);
            // 
            // btn_send_message
            // 
            this.btn_send_message.Location = new System.Drawing.Point(449, 394);
            this.btn_send_message.Name = "btn_send_message";
            this.btn_send_message.Size = new System.Drawing.Size(89, 23);
            this.btn_send_message.TabIndex = 3;
            this.btn_send_message.Text = "Send Message";
            this.btn_send_message.UseVisualStyleBackColor = true;
            this.btn_send_message.Click += new System.EventHandler(this.btn_send_message_Click);
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(26, 394);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(364, 20);
            this.txt_message.TabIndex = 4;
            // 
            // comboBoxClientsOnline
            // 
            this.comboBoxClientsOnline.FormattingEnabled = true;
            this.comboBoxClientsOnline.Location = new System.Drawing.Point(470, 90);
            this.comboBoxClientsOnline.Name = "comboBoxClientsOnline";
            this.comboBoxClientsOnline.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientsOnline.TabIndex = 5;
            // 
            // lbl_view_clients
            // 
            this.lbl_view_clients.AutoSize = true;
            this.lbl_view_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_clients.Location = new System.Drawing.Point(467, 51);
            this.lbl_view_clients.Name = "lbl_view_clients";
            this.lbl_view_clients.Size = new System.Drawing.Size(71, 13);
            this.lbl_view_clients.TabIndex = 6;
            this.lbl_view_clients.Text = "Clients Online";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(846, 62);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(127, 23);
            this.btn_disconnect.TabIndex = 7;
            this.btn_disconnect.Text = "Disconnect from Server";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_create_groupchat
            // 
            this.btn_create_groupchat.Location = new System.Drawing.Point(822, 86);
            this.btn_create_groupchat.Name = "btn_create_groupchat";
            this.btn_create_groupchat.Size = new System.Drawing.Size(127, 23);
            this.btn_create_groupchat.TabIndex = 8;
            this.btn_create_groupchat.Text = "Create group chat";
            this.btn_create_groupchat.UseVisualStyleBackColor = true;
            this.btn_create_groupchat.Click += new System.EventHandler(this.btn_create_groupchat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(113, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 577);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rch_txt_messages);
            this.tabPage1.Controls.Add(this.txt_message);
            this.tabPage1.Controls.Add(this.lbl_view_clients);
            this.tabPage1.Controls.Add(this.btn_send_message);
            this.tabPage1.Controls.Add(this.comboBoxClientsOnline);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Private Chats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Private Chats";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_groupname);
            this.tabPage2.Controls.Add(this.comboBoxgroupOnlineMembers);
            this.tabPage2.Controls.Add(this.lbl_group_participants);
            this.tabPage2.Controls.Add(this.btn_create_groupchat);
            this.tabPage2.Controls.Add(this.btnAddToGroupChat);
            this.tabPage2.Controls.Add(this.comboBoxGroupChat);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_groupchat);
            this.tabPage2.Controls.Add(this.btn_group_send);
            this.tabPage2.Controls.Add(this.txtGroupName);
            this.tabPage2.Controls.Add(this.rch_groupchat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group Chats";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Select Members";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(754, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name of Group";
            // 
            // txt_groupname
            // 
            this.txt_groupname.Location = new System.Drawing.Point(840, 60);
            this.txt_groupname.Name = "txt_groupname";
            this.txt_groupname.Size = new System.Drawing.Size(100, 20);
            this.txt_groupname.TabIndex = 17;
            // 
            // comboBoxgroupOnlineMembers
            // 
            this.comboBoxgroupOnlineMembers.FormattingEnabled = true;
            this.comboBoxgroupOnlineMembers.Location = new System.Drawing.Point(840, 164);
            this.comboBoxgroupOnlineMembers.Name = "comboBoxgroupOnlineMembers";
            this.comboBoxgroupOnlineMembers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxgroupOnlineMembers.TabIndex = 16;
            // 
            // lbl_group_participants
            // 
            this.lbl_group_participants.AutoSize = true;
            this.lbl_group_participants.Location = new System.Drawing.Point(493, 76);
            this.lbl_group_participants.Name = "lbl_group_participants";
            this.lbl_group_participants.Size = new System.Drawing.Size(94, 13);
            this.lbl_group_participants.TabIndex = 15;
            this.lbl_group_participants.Text = "Group Participants";
            // 
            // btnAddToGroupChat
            // 
            this.btnAddToGroupChat.Location = new System.Drawing.Point(832, 201);
            this.btnAddToGroupChat.Name = "btnAddToGroupChat";
            this.btnAddToGroupChat.Size = new System.Drawing.Size(92, 23);
            this.btnAddToGroupChat.TabIndex = 14;
            this.btnAddToGroupChat.Text = "Add member";
            this.btnAddToGroupChat.UseVisualStyleBackColor = true;
            this.btnAddToGroupChat.Click += new System.EventHandler(this.btnAddToGroupChat_Click);
            // 
            // comboBoxGroupChat
            // 
            this.comboBoxGroupChat.FormattingEnabled = true;
            this.comboBoxGroupChat.Location = new System.Drawing.Point(478, 35);
            this.comboBoxGroupChat.Name = "comboBoxGroupChat";
            this.comboBoxGroupChat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroupChat.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Group Chats";
            // 
            // txt_groupchat
            // 
            this.txt_groupchat.Location = new System.Drawing.Point(37, 500);
            this.txt_groupchat.Name = "txt_groupchat";
            this.txt_groupchat.Size = new System.Drawing.Size(399, 20);
            this.txt_groupchat.TabIndex = 10;
            // 
            // btn_group_send
            // 
            this.btn_group_send.Location = new System.Drawing.Point(496, 500);
            this.btn_group_send.Name = "btn_group_send";
            this.btn_group_send.Size = new System.Drawing.Size(75, 23);
            this.btn_group_send.TabIndex = 12;
            this.btn_group_send.Text = "Send Message";
            this.btn_group_send.UseVisualStyleBackColor = true;
            this.btn_group_send.Click += new System.EventHandler(this.btn_group_send_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.AutoSize = true;
            this.txtGroupName.Location = new System.Drawing.Point(203, 10);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(66, 13);
            this.txtGroupName.TabIndex = 11;
            this.txtGroupName.Text = "Group Chats";
            // 
            // rch_groupchat
            // 
            this.rch_groupchat.Location = new System.Drawing.Point(37, 35);
            this.rch_groupchat.Name = "rch_groupchat";
            this.rch_groupchat.Size = new System.Drawing.Size(399, 446);
            this.rch_groupchat.TabIndex = 10;
            this.rch_groupchat.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 726);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect_to_server);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rch_txt_messages;
        private System.Windows.Forms.Button btn_connect_to_server;
        private System.Windows.Forms.Button btn_send_message;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.ComboBox comboBoxClientsOnline;
        private System.Windows.Forms.Label lbl_view_clients;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_create_groupchat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_group_send;
        private System.Windows.Forms.Label txtGroupName;
        private System.Windows.Forms.RichTextBox rch_groupchat;
        private System.Windows.Forms.TextBox txt_groupchat;
        private System.Windows.Forms.Label lbl_group_participants;
        private System.Windows.Forms.Button btnAddToGroupChat;
        private System.Windows.Forms.ComboBox comboBoxGroupChat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_groupname;
        private System.Windows.Forms.ComboBox comboBoxgroupOnlineMembers;
    }
}


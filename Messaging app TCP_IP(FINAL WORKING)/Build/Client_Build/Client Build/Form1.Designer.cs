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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client_Build";
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
            this.btn_connect_to_server.Location = new System.Drawing.Point(548, 109);
            this.btn_connect_to_server.Name = "btn_connect_to_server";
            this.btn_connect_to_server.Size = new System.Drawing.Size(127, 23);
            this.btn_connect_to_server.TabIndex = 2;
            this.btn_connect_to_server.Text = "Connect to Server";
            this.btn_connect_to_server.UseVisualStyleBackColor = true;
            this.btn_connect_to_server.Click += new System.EventHandler(this.btn_connect_to_server_Click);
            // 
            // btn_send_message
            // 
            this.btn_send_message.Location = new System.Drawing.Point(643, 538);
            this.btn_send_message.Name = "btn_send_message";
            this.btn_send_message.Size = new System.Drawing.Size(89, 23);
            this.btn_send_message.TabIndex = 3;
            this.btn_send_message.Text = "Send Message";
            this.btn_send_message.UseVisualStyleBackColor = true;
            this.btn_send_message.Click += new System.EventHandler(this.btn_send_message_Click);
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(167, 540);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(364, 20);
            this.txt_message.TabIndex = 4;
            // 
            // comboBoxClientsOnline
            // 
            this.comboBoxClientsOnline.FormattingEnabled = true;
            this.comboBoxClientsOnline.Location = new System.Drawing.Point(611, 217);
            this.comboBoxClientsOnline.Name = "comboBoxClientsOnline";
            this.comboBoxClientsOnline.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientsOnline.TabIndex = 5;
            // 
            // lbl_view_clients
            // 
            this.lbl_view_clients.AutoSize = true;
            this.lbl_view_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_clients.Location = new System.Drawing.Point(629, 201);
            this.lbl_view_clients.Name = "lbl_view_clients";
            this.lbl_view_clients.Size = new System.Drawing.Size(71, 13);
            this.lbl_view_clients.TabIndex = 6;
            this.lbl_view_clients.Text = "Clients Online";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(681, 109);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(127, 23);
            this.btn_disconnect.TabIndex = 7;
            this.btn_disconnect.Text = "Disconnect from Server";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_create_groupchat
            // 
            this.btn_create_groupchat.Location = new System.Drawing.Point(611, 159);
            this.btn_create_groupchat.Name = "btn_create_groupchat";
            this.btn_create_groupchat.Size = new System.Drawing.Size(127, 23);
            this.btn_create_groupchat.TabIndex = 8;
            this.btn_create_groupchat.Text = "Create group chat";
            this.btn_create_groupchat.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(113, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 429);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rch_txt_messages);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Private Chats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group Chats";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(153, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(224, 334);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Group Chats";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 605);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_create_groupchat);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.lbl_view_clients);
            this.Controls.Add(this.comboBoxClientsOnline);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.btn_send_message);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


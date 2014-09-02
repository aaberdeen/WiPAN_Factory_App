namespace WiPANFactory
{
    partial class WiPANfactory
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
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_sendMac = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.textBox_MAC = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MacArp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_Gateway = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Mask = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.comboBox_use = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Inv = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button_sendStatIP = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(163, 5);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(81, 20);
            this.textBox_IP.TabIndex = 1;
            this.textBox_IP.Text = "10.1.0.147";
            this.textBox_IP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_IP_PreviewKeyDown);
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(282, 5);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(36, 20);
            this.textBox_Port.TabIndex = 1;
            this.textBox_Port.Text = "40";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(3, 3);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(97, 23);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(324, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 470);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(476, 138);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server";
            // 
            // button_sendMac
            // 
            this.button_sendMac.Location = new System.Drawing.Point(3, 117);
            this.button_sendMac.Name = "button_sendMac";
            this.button_sendMac.Size = new System.Drawing.Size(100, 23);
            this.button_sendMac.TabIndex = 7;
            this.button_sendMac.Text = "Send MAC";
            this.button_sendMac.UseVisualStyleBackColor = true;
            this.button_sendMac.Click += new System.EventHandler(this.sendMac_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(3, 27);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(97, 23);
            this.button_Disconnect.TabIndex = 2;
            this.button_Disconnect.Text = "DisConnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.disConnect_Click);
            // 
            // textBox_MAC
            // 
            this.textBox_MAC.Location = new System.Drawing.Point(128, 119);
            this.textBox_MAC.Name = "textBox_MAC";
            this.textBox_MAC.Size = new System.Drawing.Size(100, 20);
            this.textBox_MAC.TabIndex = 6;
            this.textBox_MAC.Text = "40D85510A000";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 407);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(470, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Reset Board";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.resetBoard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "New MAC";
            // 
            // textBox_MacArp
            // 
            this.textBox_MacArp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_MacArp.Location = new System.Drawing.Point(234, 120);
            this.textBox_MacArp.Name = "textBox_MacArp";
            this.textBox_MacArp.Size = new System.Drawing.Size(100, 20);
            this.textBox_MacArp.TabIndex = 7;
            this.textBox_MacArp.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "ARP MAC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox_Password);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox_Gateway);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox_Mask);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox_product);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_SN);
            this.panel1.Controls.Add(this.comboBox_use);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_Disconnect);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_MacArp);
            this.panel1.Controls.Add(this.textBox_Inv);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.button_sendStatIP);
            this.panel1.Controls.Add(this.button_Connect);
            this.panel1.Controls.Add(this.textBox_IP);
            this.panel1.Controls.Add(this.textBox_Port);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_sendMac);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.textBox_MAC);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 437);
            this.panel1.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 23);
            this.button6.TabIndex = 52;
            this.button6.Text = "Close UDP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Open UDP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(106, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "=";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 320);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 23);
            this.button7.TabIndex = 49;
            this.button7.Text = "Send Date";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "=";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 47;
            this.button5.Text = "Send Time";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(106, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "=";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Send Password";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.sendPassword_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(128, 265);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 44;
            this.textBox_Password.Text = "44447777";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(106, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "=";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Send Gateway";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.sendGateway_Click);
            // 
            // textBox_Gateway
            // 
            this.textBox_Gateway.Location = new System.Drawing.Point(128, 236);
            this.textBox_Gateway.Name = "textBox_Gateway";
            this.textBox_Gateway.Size = new System.Drawing.Size(100, 20);
            this.textBox_Gateway.TabIndex = 41;
            this.textBox_Gateway.Text = "0.0.0.0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Send Sub Mask";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sendSubnet_Click);
            // 
            // textBox_Mask
            // 
            this.textBox_Mask.Location = new System.Drawing.Point(128, 207);
            this.textBox_Mask.Name = "textBox_Mask";
            this.textBox_Mask.Size = new System.Drawing.Size(100, 20);
            this.textBox_Mask.TabIndex = 38;
            this.textBox_Mask.Text = "255.255.255.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Unallocated MACS =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Product";
            // 
            // comboBox_product
            // 
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Items.AddRange(new object[] {
            "WiPAN Coord",
            "Flex Display",
            "NC5"});
            this.comboBox_product.Location = new System.Drawing.Point(234, 73);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(121, 21);
            this.comboBox_product.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Serial Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Use";
            // 
            // textBox_SN
            // 
            this.textBox_SN.Location = new System.Drawing.Point(361, 74);
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(100, 20);
            this.textBox_SN.TabIndex = 5;
            // 
            // comboBox_use
            // 
            this.comboBox_use.FormattingEnabled = true;
            this.comboBox_use.Items.AddRange(new object[] {
            "Production",
            "Development"});
            this.comboBox_use.Location = new System.Drawing.Point(128, 73);
            this.comboBox_use.Name = "comboBox_use";
            this.comboBox_use.Size = new System.Drawing.Size(100, 21);
            this.comboBox_use.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "UID";
            // 
            // textBox_Inv
            // 
            this.textBox_Inv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Inv.Location = new System.Drawing.Point(163, 34);
            this.textBox_Inv.Name = "textBox_Inv";
            this.textBox_Inv.Size = new System.Drawing.Size(261, 20);
            this.textBox_Inv.TabIndex = 3;
            this.textBox_Inv.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(128, 175);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(29, 20);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "=";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 175);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(97, 23);
            this.button11.TabIndex = 22;
            this.button11.Text = "Send DHCP bit";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.sendDHCP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "=";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(128, 144);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "192.168.0.201";
            // 
            // button_sendStatIP
            // 
            this.button_sendStatIP.Location = new System.Drawing.Point(3, 146);
            this.button_sendStatIP.Name = "button_sendStatIP";
            this.button_sendStatIP.Size = new System.Drawing.Size(100, 23);
            this.button_sendStatIP.TabIndex = 19;
            this.button_sendStatIP.Text = "Send Static IP";
            this.button_sendStatIP.UseVisualStyleBackColor = true;
            this.button_sendStatIP.Click += new System.EventHandler(this.sendStatIP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.readDBToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // readDBToolStripMenuItem
            // 
            this.readDBToolStripMenuItem.Name = "readDBToolStripMenuItem";
            this.readDBToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.readDBToolStripMenuItem.Text = "Read DB";
            this.readDBToolStripMenuItem.Click += new System.EventHandler(this.readDB_Click);
            // 
            // WiPANfactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WiPANfactory";
            this.Text = "WiPAN Factory Programming Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_sendMac;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.TextBox textBox_MAC;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MacArp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button_sendStatIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox_Inv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.ComboBox comboBox_use;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem readDBToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Mask;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_Gateway;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
    }
}


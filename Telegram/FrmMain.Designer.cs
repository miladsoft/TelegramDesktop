namespace Telegram
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.gbNewAccount = new System.Windows.Forms.GroupBox();
            this.lblVerficationCode = new System.Windows.Forms.Label();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbVerficationCode = new System.Windows.Forms.TextBox();
            this.btnLoginNew = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.LoadContact = new System.Windows.Forms.TabPage();
            this.tbSerch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MobileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadContact = new System.Windows.Forms.Button();
            this.gb_SendMessage = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnSendFileNumber = new System.Windows.Forms.Button();
            this.btnSendTextNumber = new System.Windows.Forms.Button();
            this.ReceiveMessage = new System.Windows.Forms.TabPage();
            this.TxtHistory = new System.Windows.Forms.TextBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetHistory = new System.Windows.Forms.Button();
            this.SendMessageToPublicChannel = new System.Windows.Forms.TabPage();
            this.tbChannelMessage = new System.Windows.Forms.TextBox();
            this.lbl_at = new System.Windows.Forms.Label();
            this.tbChannelId = new System.Windows.Forms.TextBox();
            this.btnChannelSend = new System.Windows.Forms.Button();
            this.pbSelfPicture = new System.Windows.Forms.PictureBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblSendCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.gb_Top = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.JoinToChannelorGroup = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroupHash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSendTobot = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBotUser = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txt_MessageBot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcMain.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.gbNewAccount.SuspendLayout();
            this.LoadContact.SuspendLayout();
            this.gb_SendMessage.SuspendLayout();
            this.ReceiveMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SendMessageToPublicChannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelfPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gb_Top.SuspendLayout();
            this.JoinToChannelorGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpLogin);
            this.tcMain.Controls.Add(this.LoadContact);
            this.tcMain.Controls.Add(this.ReceiveMessage);
            this.tcMain.Controls.Add(this.SendMessageToPublicChannel);
            this.tcMain.Controls.Add(this.JoinToChannelorGroup);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Location = new System.Drawing.Point(4, 95);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(822, 418);
            this.tcMain.TabIndex = 0;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.gbNewAccount);
            this.tpLogin.Location = new System.Drawing.Point(4, 22);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(814, 392);
            this.tpLogin.TabIndex = 0;
            this.tpLogin.Text = "Login To Telegram";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // gbNewAccount
            // 
            this.gbNewAccount.Controls.Add(this.label3);
            this.gbNewAccount.Controls.Add(this.TxtPassword);
            this.gbNewAccount.Controls.Add(this.label2);
            this.gbNewAccount.Controls.Add(this.lblVerficationCode);
            this.gbNewAccount.Controls.Add(this.btnSendCode);
            this.gbNewAccount.Controls.Add(this.tbPhoneNumber);
            this.gbNewAccount.Controls.Add(this.tbVerficationCode);
            this.gbNewAccount.Controls.Add(this.btnLoginNew);
            this.gbNewAccount.Controls.Add(this.lblPhoneNumber);
            this.gbNewAccount.Location = new System.Drawing.Point(194, 115);
            this.gbNewAccount.Name = "gbNewAccount";
            this.gbNewAccount.Size = new System.Drawing.Size(425, 142);
            this.gbNewAccount.TabIndex = 4;
            this.gbNewAccount.TabStop = false;
            this.gbNewAccount.Text = "New Account";
            // 
            // lblVerficationCode
            // 
            this.lblVerficationCode.AutoSize = true;
            this.lblVerficationCode.Location = new System.Drawing.Point(31, 109);
            this.lblVerficationCode.Name = "lblVerficationCode";
            this.lblVerficationCode.Size = new System.Drawing.Size(86, 13);
            this.lblVerficationCode.TabIndex = 5;
            this.lblVerficationCode.Text = "Verfication Code";
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(316, 43);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(75, 23);
            this.btnSendCode.TabIndex = 4;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(126, 45);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPhoneNumber.Size = new System.Drawing.Size(174, 21);
            this.tbPhoneNumber.TabIndex = 0;
            // 
            // tbVerficationCode
            // 
            this.tbVerficationCode.Enabled = false;
            this.tbVerficationCode.Location = new System.Drawing.Point(126, 106);
            this.tbVerficationCode.Name = "tbVerficationCode";
            this.tbVerficationCode.PasswordChar = '*';
            this.tbVerficationCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVerficationCode.Size = new System.Drawing.Size(174, 21);
            this.tbVerficationCode.TabIndex = 1;
            // 
            // btnLoginNew
            // 
            this.btnLoginNew.Enabled = false;
            this.btnLoginNew.Location = new System.Drawing.Point(316, 104);
            this.btnLoginNew.Name = "btnLoginNew";
            this.btnLoginNew.Size = new System.Drawing.Size(75, 23);
            this.btnLoginNew.TabIndex = 3;
            this.btnLoginNew.Text = "Login";
            this.btnLoginNew.UseVisualStyleBackColor = true;
            this.btnLoginNew.Click += new System.EventHandler(this.btnLoginNew_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(31, 48);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(77, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // LoadContact
            // 
            this.LoadContact.Controls.Add(this.tbSerch);
            this.LoadContact.Controls.Add(this.btnSearch);
            this.LoadContact.Controls.Add(this.lvList);
            this.LoadContact.Controls.Add(this.btnLoadContact);
            this.LoadContact.Controls.Add(this.gb_SendMessage);
            this.LoadContact.Location = new System.Drawing.Point(4, 22);
            this.LoadContact.Name = "LoadContact";
            this.LoadContact.Padding = new System.Windows.Forms.Padding(3);
            this.LoadContact.Size = new System.Drawing.Size(814, 392);
            this.LoadContact.TabIndex = 1;
            this.LoadContact.Text = "Load Contact & Send Message";
            this.LoadContact.UseVisualStyleBackColor = true;
            // 
            // tbSerch
            // 
            this.tbSerch.Location = new System.Drawing.Point(448, 17);
            this.tbSerch.Name = "tbSerch";
            this.tbSerch.Size = new System.Drawing.Size(137, 21);
            this.tbSerch.TabIndex = 41;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(591, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvList
            // 
            this.lvList.AllowDrop = true;
            this.lvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvList.CheckBoxes = true;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.MobileNumber,
            this.FirstName,
            this.LastName});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(8, 45);
            this.lvList.Name = "lvList";
            this.lvList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvList.Size = new System.Drawing.Size(798, 234);
            this.lvList.TabIndex = 37;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.SelectedIndexChanged += new System.EventHandler(this.lvList_SelectedIndexChanged);
            // 
            // Username
            // 
            this.Username.Text = "ID";
            this.Username.Width = 103;
            // 
            // MobileNumber
            // 
            this.MobileNumber.Text = "MobileNumber";
            this.MobileNumber.Width = 184;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 175;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 187;
            // 
            // btnLoadContact
            // 
            this.btnLoadContact.Location = new System.Drawing.Point(8, 17);
            this.btnLoadContact.Name = "btnLoadContact";
            this.btnLoadContact.Size = new System.Drawing.Size(115, 23);
            this.btnLoadContact.TabIndex = 36;
            this.btnLoadContact.Text = "Load Contact";
            this.btnLoadContact.UseVisualStyleBackColor = true;
            this.btnLoadContact.Click += new System.EventHandler(this.btnLoadContact_Click);
            // 
            // gb_SendMessage
            // 
            this.gb_SendMessage.Controls.Add(this.tbMessage);
            this.gb_SendMessage.Controls.Add(this.btnSendFileNumber);
            this.gb_SendMessage.Controls.Add(this.btnSendTextNumber);
            this.gb_SendMessage.Location = new System.Drawing.Point(8, 290);
            this.gb_SendMessage.Name = "gb_SendMessage";
            this.gb_SendMessage.Size = new System.Drawing.Size(798, 92);
            this.gb_SendMessage.TabIndex = 6;
            this.gb_SendMessage.TabStop = false;
            this.gb_SendMessage.Text = "Send Message";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(7, 21);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(678, 63);
            this.tbMessage.TabIndex = 16;
            // 
            // btnSendFileNumber
            // 
            this.btnSendFileNumber.Location = new System.Drawing.Point(691, 56);
            this.btnSendFileNumber.Name = "btnSendFileNumber";
            this.btnSendFileNumber.Size = new System.Drawing.Size(102, 29);
            this.btnSendFileNumber.TabIndex = 9;
            this.btnSendFileNumber.Text = "send pic";
            this.btnSendFileNumber.UseVisualStyleBackColor = true;
            this.btnSendFileNumber.Click += new System.EventHandler(this.SendFileNumber_Click);
            // 
            // btnSendTextNumber
            // 
            this.btnSendTextNumber.Location = new System.Drawing.Point(691, 21);
            this.btnSendTextNumber.Name = "btnSendTextNumber";
            this.btnSendTextNumber.Size = new System.Drawing.Size(101, 29);
            this.btnSendTextNumber.TabIndex = 15;
            this.btnSendTextNumber.Text = "send text";
            this.btnSendTextNumber.UseVisualStyleBackColor = true;
            this.btnSendTextNumber.Click += new System.EventHandler(this.SendTextNumber_Click);
            // 
            // ReceiveMessage
            // 
            this.ReceiveMessage.Controls.Add(this.TxtHistory);
            this.ReceiveMessage.Controls.Add(this.nudCount);
            this.ReceiveMessage.Controls.Add(this.label1);
            this.ReceiveMessage.Controls.Add(this.btnGetHistory);
            this.ReceiveMessage.Location = new System.Drawing.Point(4, 22);
            this.ReceiveMessage.Name = "ReceiveMessage";
            this.ReceiveMessage.Size = new System.Drawing.Size(814, 392);
            this.ReceiveMessage.TabIndex = 2;
            this.ReceiveMessage.Text = "Receive Message All Type";
            this.ReceiveMessage.UseVisualStyleBackColor = true;
            // 
            // TxtHistory
            // 
            this.TxtHistory.Location = new System.Drawing.Point(8, 46);
            this.TxtHistory.Multiline = true;
            this.TxtHistory.Name = "TxtHistory";
            this.TxtHistory.Size = new System.Drawing.Size(802, 332);
            this.TxtHistory.TabIndex = 22;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(171, 17);
            this.nudCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(65, 21);
            this.nudCount.TabIndex = 21;
            this.nudCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Count :";
            // 
            // btnGetHistory
            // 
            this.btnGetHistory.Location = new System.Drawing.Point(8, 17);
            this.btnGetHistory.Name = "btnGetHistory";
            this.btnGetHistory.Size = new System.Drawing.Size(108, 23);
            this.btnGetHistory.TabIndex = 15;
            this.btnGetHistory.Text = "Load History";
            this.btnGetHistory.UseVisualStyleBackColor = true;
            this.btnGetHistory.Click += new System.EventHandler(this.GetHistory_Click);
            // 
            // SendMessageToPublicChannel
            // 
            this.SendMessageToPublicChannel.Controls.Add(this.pictureBox1);
            this.SendMessageToPublicChannel.Controls.Add(this.tbChannelMessage);
            this.SendMessageToPublicChannel.Controls.Add(this.lbl_at);
            this.SendMessageToPublicChannel.Controls.Add(this.tbChannelId);
            this.SendMessageToPublicChannel.Controls.Add(this.btnChannelSend);
            this.SendMessageToPublicChannel.Location = new System.Drawing.Point(4, 22);
            this.SendMessageToPublicChannel.Name = "SendMessageToPublicChannel";
            this.SendMessageToPublicChannel.Padding = new System.Windows.Forms.Padding(3);
            this.SendMessageToPublicChannel.Size = new System.Drawing.Size(814, 392);
            this.SendMessageToPublicChannel.TabIndex = 3;
            this.SendMessageToPublicChannel.Text = "Send Message To Public Channel";
            this.SendMessageToPublicChannel.UseVisualStyleBackColor = true;
            // 
            // tbChannelMessage
            // 
            this.tbChannelMessage.Location = new System.Drawing.Point(31, 313);
            this.tbChannelMessage.Multiline = true;
            this.tbChannelMessage.Name = "tbChannelMessage";
            this.tbChannelMessage.Size = new System.Drawing.Size(708, 58);
            this.tbChannelMessage.TabIndex = 20;
            // 
            // lbl_at
            // 
            this.lbl_at.AutoSize = true;
            this.lbl_at.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_at.Location = new System.Drawing.Point(7, 274);
            this.lbl_at.Name = "lbl_at";
            this.lbl_at.Size = new System.Drawing.Size(20, 16);
            this.lbl_at.TabIndex = 17;
            this.lbl_at.Text = "@";
            // 
            // tbChannelId
            // 
            this.tbChannelId.Location = new System.Drawing.Point(31, 272);
            this.tbChannelId.Name = "tbChannelId";
            this.tbChannelId.Size = new System.Drawing.Size(200, 21);
            this.tbChannelId.TabIndex = 16;
            // 
            // btnChannelSend
            // 
            this.btnChannelSend.Location = new System.Drawing.Point(745, 313);
            this.btnChannelSend.Name = "btnChannelSend";
            this.btnChannelSend.Size = new System.Drawing.Size(63, 58);
            this.btnChannelSend.TabIndex = 15;
            this.btnChannelSend.Text = "Send";
            this.btnChannelSend.UseVisualStyleBackColor = true;
            this.btnChannelSend.Click += new System.EventHandler(this.btnChannelSend_Click);
            // 
            // pbSelfPicture
            // 
            this.pbSelfPicture.BackColor = System.Drawing.Color.Silver;
            this.pbSelfPicture.Location = new System.Drawing.Point(6, 12);
            this.pbSelfPicture.Name = "pbSelfPicture";
            this.pbSelfPicture.Size = new System.Drawing.Size(58, 58);
            this.pbSelfPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelfPicture.TabIndex = 36;
            this.pbSelfPicture.TabStop = false;
            // 
            // tbNumber
            // 
            this.tbNumber.Enabled = false;
            this.tbNumber.Location = new System.Drawing.Point(642, 49);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumber.Size = new System.Drawing.Size(110, 21);
            this.tbNumber.TabIndex = 14;
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUserPicture.BackColor = System.Drawing.Color.Silver;
            this.pbUserPicture.Location = new System.Drawing.Point(758, 12);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.Size = new System.Drawing.Size(58, 58);
            this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPicture.TabIndex = 39;
            this.pbUserPicture.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblSendCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblSendCount
            // 
            this.tslblSendCount.Name = "tslblSendCount";
            this.tslblSendCount.Size = new System.Drawing.Size(302, 17);
            this.tslblSendCount.Text = "Developer : Milad Raeisi ... Telegram ID : @miladsoft_net";
            // 
            // gb_Top
            // 
            this.gb_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Top.Controls.Add(this.lblID);
            this.gb_Top.Controls.Add(this.tbNumber);
            this.gb_Top.Controls.Add(this.pbSelfPicture);
            this.gb_Top.Controls.Add(this.pbUserPicture);
            this.gb_Top.Location = new System.Drawing.Point(4, 13);
            this.gb_Top.Name = "gb_Top";
            this.gb_Top.Size = new System.Drawing.Size(822, 76);
            this.gb_Top.TabIndex = 2;
            this.gb_Top.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(642, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 13);
            this.lblID.TabIndex = 40;
            this.lblID.Text = "ID :";
            // 
            // JoinToChannelorGroup
            // 
            this.JoinToChannelorGroup.Controls.Add(this.label6);
            this.JoinToChannelorGroup.Controls.Add(this.button1);
            this.JoinToChannelorGroup.Controls.Add(this.label4);
            this.JoinToChannelorGroup.Controls.Add(this.txtGroupHash);
            this.JoinToChannelorGroup.Location = new System.Drawing.Point(4, 22);
            this.JoinToChannelorGroup.Name = "JoinToChannelorGroup";
            this.JoinToChannelorGroup.Padding = new System.Windows.Forms.Padding(3);
            this.JoinToChannelorGroup.Size = new System.Drawing.Size(814, 392);
            this.JoinToChannelorGroup.TabIndex = 4;
            this.JoinToChannelorGroup.Text = "Join To Channel or Group ";
            this.JoinToChannelorGroup.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_MessageBot);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtBotUser);
            this.tabPage2.Controls.Add(this.BtnSendTobot);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 392);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Send Message to Bot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(126, 72);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPassword.Size = new System.Drawing.Size(174, 21);
            this.TxtPassword.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(313, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "( If Use Password )";
            // 
            // txtGroupHash
            // 
            this.txtGroupHash.Location = new System.Drawing.Point(194, 283);
            this.txtGroupHash.Name = "txtGroupHash";
            this.txtGroupHash.Size = new System.Drawing.Size(485, 21);
            this.txtGroupHash.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Join Group or Join Channel  Link : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "btn_Join";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSendTobot
            // 
            this.BtnSendTobot.Location = new System.Drawing.Point(625, 303);
            this.BtnSendTobot.Name = "BtnSendTobot";
            this.BtnSendTobot.Size = new System.Drawing.Size(75, 23);
            this.BtnSendTobot.TabIndex = 0;
            this.BtnSendTobot.Text = "Send";
            this.BtnSendTobot.UseVisualStyleBackColor = true;
            this.BtnSendTobot.Click += new System.EventHandler(this.BtnSendTobot_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bot UserName :     @";
            // 
            // txtBotUser
            // 
            this.txtBotUser.Location = new System.Drawing.Point(173, 262);
            this.txtBotUser.Name = "txtBotUser";
            this.txtBotUser.Size = new System.Drawing.Size(444, 21);
            this.txtBotUser.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(625, 261);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Bot ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txt_MessageBot
            // 
            this.txt_MessageBot.Location = new System.Drawing.Point(173, 289);
            this.txt_MessageBot.Multiline = true;
            this.txt_MessageBot.Name = "txt_MessageBot";
            this.txt_MessageBot.Size = new System.Drawing.Size(444, 37);
            this.txt_MessageBot.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ex :  https://t.me/joinchat/ASSSJHGJHGKLJHDKU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 538);
            this.Controls.Add(this.gb_Top);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.gbNewAccount.ResumeLayout(false);
            this.gbNewAccount.PerformLayout();
            this.LoadContact.ResumeLayout(false);
            this.LoadContact.PerformLayout();
            this.gb_SendMessage.ResumeLayout(false);
            this.gb_SendMessage.PerformLayout();
            this.ReceiveMessage.ResumeLayout(false);
            this.ReceiveMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.SendMessageToPublicChannel.ResumeLayout(false);
            this.SendMessageToPublicChannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelfPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb_Top.ResumeLayout(false);
            this.gb_Top.PerformLayout();
            this.JoinToChannelorGroup.ResumeLayout(false);
            this.JoinToChannelorGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.GroupBox gbNewAccount;
        private System.Windows.Forms.Button btnLoginNew;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbVerficationCode;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label lblVerficationCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblSendCount;
        private System.Windows.Forms.PictureBox pbSelfPicture;
        private System.Windows.Forms.TabPage LoadContact;
        private System.Windows.Forms.Button btnSendTextNumber;
        private System.Windows.Forms.Button btnSendFileNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.GroupBox gb_SendMessage;
        private System.Windows.Forms.TabPage ReceiveMessage;
        private System.Windows.Forms.Button btnGetHistory;
        private System.Windows.Forms.PictureBox pbUserPicture;
        private System.Windows.Forms.TabPage SendMessageToPublicChannel;
        private System.Windows.Forms.TextBox tbChannelId;
        private System.Windows.Forms.Button btnChannelSend;
        private System.Windows.Forms.Label lbl_at;
        private System.Windows.Forms.GroupBox gb_Top;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader MobileNumber;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.Button btnLoadContact;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSerch;
        private System.Windows.Forms.TextBox tbChannelMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox TxtHistory;
        private System.Windows.Forms.TabPage JoinToChannelorGroup;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupHash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSendTobot;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBotUser;
        private System.Windows.Forms.TextBox txt_MessageBot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


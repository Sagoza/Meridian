namespace Meridian
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.world = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.ListBox();
            this.isLoggedIn = new System.Windows.Forms.CheckBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopBot = new System.Windows.Forms.Button();
            this.startBot = new System.Windows.Forms.Button();
            this.autoLogin = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tribalDomain = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timePicker0 = new System.Windows.Forms.DateTimePicker();
            this.villagers = new System.Windows.Forms.Label();
            this.storage = new System.Windows.Forms.Label();
            this.stone = new System.Windows.Forms.Label();
            this.iron = new System.Windows.Forms.Label();
            this.wood = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.world)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.gameTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(910, 547);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://www.tribalwars.com.pt/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebInstance_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebInstance_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebInstance_Navigating);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // world
            // 
            this.world.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.world.Location = new System.Drawing.Point(580, 19);
            this.world.Maximum = new decimal(new int[] {
            62,
            0,
            0,
            0});
            this.world.Minimum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.world.Name = "world";
            this.world.Size = new System.Drawing.Size(88, 20);
            this.world.TabIndex = 4;
            this.world.Value = new decimal(new int[] {
            62,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Set Current World";
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(0, 641);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(1145, 108);
            this.logBox.TabIndex = 6;
            // 
            // isLoggedIn
            // 
            this.isLoggedIn.AutoSize = true;
            this.isLoggedIn.Location = new System.Drawing.Point(6, 247);
            this.isLoggedIn.Name = "isLoggedIn";
            this.isLoggedIn.Size = new System.Drawing.Size(69, 17);
            this.isLoggedIn.TabIndex = 7;
            this.isLoggedIn.Text = "isLogged";
            this.isLoggedIn.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Location = new System.Drawing.Point(370, 19);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 8;
            this.username.Text = "mangozy";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(476, 19);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 9;
            this.password.Text = "amelia619";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopBot);
            this.groupBox1.Controls.Add(this.startBot);
            this.groupBox1.Controls.Add(this.autoLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.world);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tribalDomain);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 48);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MainPanel";
            // 
            // stopBot
            // 
            this.stopBot.Location = new System.Drawing.Point(768, 17);
            this.stopBot.Name = "stopBot";
            this.stopBot.Size = new System.Drawing.Size(76, 23);
            this.stopBot.TabIndex = 15;
            this.stopBot.Text = "Stop";
            this.stopBot.UseVisualStyleBackColor = true;
            // 
            // startBot
            // 
            this.startBot.Location = new System.Drawing.Point(686, 17);
            this.startBot.Name = "startBot";
            this.startBot.Size = new System.Drawing.Size(76, 23);
            this.startBot.TabIndex = 13;
            this.startBot.Text = "Start";
            this.startBot.UseVisualStyleBackColor = true;
            // 
            // autoLogin
            // 
            this.autoLogin.AutoSize = true;
            this.autoLogin.Location = new System.Drawing.Point(196, 21);
            this.autoLogin.Name = "autoLogin";
            this.autoLogin.Size = new System.Drawing.Size(155, 17);
            this.autoLogin.TabIndex = 13;
            this.autoLogin.Text = "Login when session expires";
            this.autoLogin.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "pt"});
            this.comboBox2.Location = new System.Drawing.Point(133, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // tribalDomain
            // 
            this.tribalDomain.FormattingEnabled = true;
            this.tribalDomain.Items.AddRange(new object[] {
            "tribalwars.com.pt"});
            this.tribalDomain.Location = new System.Drawing.Point(6, 19);
            this.tribalDomain.Name = "tribalDomain";
            this.tribalDomain.Size = new System.Drawing.Size(121, 21);
            this.tribalDomain.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.gameTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 579);
            this.tabControl1.TabIndex = 13;
            // 
            // gameTab
            // 
            this.gameTab.Controls.Add(this.webBrowser1);
            this.gameTab.Location = new System.Drawing.Point(4, 22);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(916, 553);
            this.gameTab.TabIndex = 0;
            this.gameTab.Text = "Game Tab";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dataGridView1.DataSource = this.accountBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 595);
            this.dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(Meridian.Account);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.timePicker0);
            this.groupBox2.Controls.Add(this.villagers);
            this.groupBox2.Controls.Add(this.storage);
            this.groupBox2.Controls.Add(this.stone);
            this.groupBox2.Controls.Add(this.iron);
            this.groupBox2.Controls.Add(this.wood);
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.isLoggedIn);
            this.groupBox2.Location = new System.Drawing.Point(936, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 579);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug";
            // 
            // timePicker0
            // 
            this.timePicker0.CustomFormat = "dd/MM/yy - HH:mm:ss";
            this.timePicker0.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker0.Location = new System.Drawing.Point(6, 221);
            this.timePicker0.Name = "timePicker0";
            this.timePicker0.Size = new System.Drawing.Size(188, 20);
            this.timePicker0.TabIndex = 2;
            // 
            // villagers
            // 
            this.villagers.AutoSize = true;
            this.villagers.Location = new System.Drawing.Point(7, 152);
            this.villagers.Name = "villagers";
            this.villagers.Size = new System.Drawing.Size(49, 13);
            this.villagers.TabIndex = 13;
            this.villagers.Text = "Villagers:";
            // 
            // storage
            // 
            this.storage.AutoSize = true;
            this.storage.Location = new System.Drawing.Point(6, 126);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(47, 13);
            this.storage.TabIndex = 12;
            this.storage.Text = "Storage:";
            // 
            // stone
            // 
            this.stone.AutoSize = true;
            this.stone.Location = new System.Drawing.Point(6, 85);
            this.stone.Name = "stone";
            this.stone.Size = new System.Drawing.Size(33, 13);
            this.stone.TabIndex = 11;
            this.stone.Text = "Argila";
            // 
            // iron
            // 
            this.iron.AutoSize = true;
            this.iron.Location = new System.Drawing.Point(6, 101);
            this.iron.Name = "iron";
            this.iron.Size = new System.Drawing.Size(34, 13);
            this.iron.TabIndex = 10;
            this.iron.Text = "Ferro:";
            // 
            // wood
            // 
            this.wood.AutoSize = true;
            this.wood.Location = new System.Drawing.Point(6, 69);
            this.wood.Name = "wood";
            this.wood.Size = new System.Drawing.Size(48, 13);
            this.wood.TabIndex = 9;
            this.wood.Text = "Madeira:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(6, 22);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 13);
            this.time.TabIndex = 8;
            this.time.Text = "Time:";
            this.time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logBox);
            this.Name = "Form1";
            this.Text = "Tribal Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.world)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.gameTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown world;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.CheckBox isLoggedIn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox tribalDomain;
        private System.Windows.Forms.Button stopBot;
        private System.Windows.Forms.Button startBot;
        private System.Windows.Forms.CheckBox autoLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label wood;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label stone;
        private System.Windows.Forms.Label iron;
        private System.Windows.Forms.Label storage;
        private System.Windows.Forms.Label villagers;
        private System.Windows.Forms.DateTimePicker timePicker0;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.BindingSource accountBindingSource;
    }
}


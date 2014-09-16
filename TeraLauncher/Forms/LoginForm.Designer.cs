namespace TeraLauncher
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this._titleLabel = new System.Windows.Forms.Label();
            this._welcomeLabel = new System.Windows.Forms.Label();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._coinsLabel = new System.Windows.Forms.Label();
            this._passwordInputBox = new System.Windows.Forms.TextBox();
            this._usernameInputBox = new System.Windows.Forms.TextBox();
            this._btnExit = new System.Windows.Forms.Button();
            this._btnMinimize = new System.Windows.Forms.Button();
            this._btnCreate = new System.Windows.Forms.Button();
            this._btnLogin = new System.Windows.Forms.Button();
            this._btnPlay = new System.Windows.Forms.Button();
            this._btnLogout = new System.Windows.Forms.Button();
            this._loggedPanel = new System.Windows.Forms.Panel();
            this._notloggedPanel = new System.Windows.Forms.Panel();
            this._languageBox = new System.Windows.Forms.ComboBox();
            this._serverlistInputBox = new System.Windows.Forms.TextBox();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._downloadStatus = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this._mpatchVer = new System.Windows.Forms.Label();
            this._bar = new System.Windows.Forms.ProgressBar();
            this._loggedPanel.SuspendLayout();
            this._notloggedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.BackColor = System.Drawing.Color.Transparent;
            this._titleLabel.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLabel.ForeColor = System.Drawing.Color.White;
            this._titleLabel.Location = new System.Drawing.Point(10, 12);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(26, 13);
            this._titleLabel.TabIndex = 0;
            this._titleLabel.Text = "title";
            // 
            // _welcomeLabel
            // 
            this._welcomeLabel.AutoSize = true;
            this._welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this._welcomeLabel.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._welcomeLabel.ForeColor = System.Drawing.Color.White;
            this._welcomeLabel.Location = new System.Drawing.Point(3, 9);
            this._welcomeLabel.Name = "_welcomeLabel";
            this._welcomeLabel.Size = new System.Drawing.Size(55, 13);
            this._welcomeLabel.TabIndex = 4;
            this._welcomeLabel.Text = "Welcome,";
            // 
            // _usernameLabel
            // 
            this._usernameLabel.AutoSize = true;
            this._usernameLabel.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._usernameLabel.ForeColor = System.Drawing.Color.Transparent;
            this._usernameLabel.Location = new System.Drawing.Point(4, 4);
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Size = new System.Drawing.Size(56, 13);
            this._usernameLabel.TabIndex = 0;
            this._usernameLabel.Text = "Username";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.ForeColor = System.Drawing.Color.White;
            this._passwordLabel.Location = new System.Drawing.Point(4, 45);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(53, 13);
            this._passwordLabel.TabIndex = 2;
            this._passwordLabel.Text = "Password";
            // 
            // _coinsLabel
            // 
            this._coinsLabel.AutoSize = true;
            this._coinsLabel.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._coinsLabel.ForeColor = System.Drawing.Color.White;
            this._coinsLabel.Location = new System.Drawing.Point(4, 43);
            this._coinsLabel.Name = "_coinsLabel";
            this._coinsLabel.Size = new System.Drawing.Size(33, 13);
            this._coinsLabel.TabIndex = 4;
            this._coinsLabel.Text = "Coins";
            // 
            // _passwordInputBox
            // 
            this._passwordInputBox.Location = new System.Drawing.Point(7, 60);
            this._passwordInputBox.Name = "_passwordInputBox";
            this._passwordInputBox.Size = new System.Drawing.Size(208, 20);
            this._passwordInputBox.TabIndex = 3;
            this._passwordInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            // 
            // _usernameInputBox
            // 
            this._usernameInputBox.Location = new System.Drawing.Point(7, 19);
            this._usernameInputBox.Name = "_usernameInputBox";
            this._usernameInputBox.Size = new System.Drawing.Size(208, 20);
            this._usernameInputBox.TabIndex = 1;
            this._usernameInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(687, 5);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(25, 25);
            this._btnExit.TabIndex = 1;
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // _btnMinimize
            // 
            this._btnMinimize.Location = new System.Drawing.Point(660, 5);
            this._btnMinimize.Name = "_btnMinimize";
            this._btnMinimize.Size = new System.Drawing.Size(25, 25);
            this._btnMinimize.TabIndex = 2;
            this._btnMinimize.UseVisualStyleBackColor = true;
            this._btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // _btnCreate
            // 
            this._btnCreate.Location = new System.Drawing.Point(7, 83);
            this._btnCreate.Name = "_btnCreate";
            this._btnCreate.Size = new System.Drawing.Size(70, 25);
            this._btnCreate.TabIndex = 5;
            this._btnCreate.UseVisualStyleBackColor = true;
            this._btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(145, 83);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(70, 25);
            this._btnLogin.TabIndex = 4;
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // _btnPlay
            // 
            this._btnPlay.Location = new System.Drawing.Point(538, 302);
            this._btnPlay.Name = "_btnPlay";
            this._btnPlay.Size = new System.Drawing.Size(171, 40);
            this._btnPlay.TabIndex = 10;
            this._btnPlay.UseVisualStyleBackColor = true;
            this._btnPlay.Visible = false;
            this._btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // _btnLogout
            // 
            this._btnLogout.Location = new System.Drawing.Point(147, 4);
            this._btnLogout.Name = "_btnLogout";
            this._btnLogout.Size = new System.Drawing.Size(75, 23);
            this._btnLogout.TabIndex = 1;
            this._btnLogout.UseVisualStyleBackColor = true;
            this._btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // _loggedPanel
            // 
            this._loggedPanel.BackColor = System.Drawing.Color.Transparent;
            this._loggedPanel.Controls.Add(this._coinsLabel);
            this._loggedPanel.Controls.Add(this._btnLogout);
            this._loggedPanel.Controls.Add(this._welcomeLabel);
            this._loggedPanel.Location = new System.Drawing.Point(490, 62);
            this._loggedPanel.Name = "_loggedPanel";
            this._loggedPanel.Size = new System.Drawing.Size(222, 158);
            this._loggedPanel.TabIndex = 9;
            // 
            // _notloggedPanel
            // 
            this._notloggedPanel.BackColor = System.Drawing.Color.Transparent;
            this._notloggedPanel.Controls.Add(this._btnCreate);
            this._notloggedPanel.Controls.Add(this._btnLogin);
            this._notloggedPanel.Controls.Add(this._passwordInputBox);
            this._notloggedPanel.Controls.Add(this._passwordLabel);
            this._notloggedPanel.Controls.Add(this._usernameInputBox);
            this._notloggedPanel.Controls.Add(this._usernameLabel);
            this._notloggedPanel.Location = new System.Drawing.Point(490, 62);
            this._notloggedPanel.Name = "_notloggedPanel";
            this._notloggedPanel.Size = new System.Drawing.Size(222, 119);
            this._notloggedPanel.TabIndex = 8;
            this._notloggedPanel.Visible = false;
            // 
            // _languageBox
            // 
            this._languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._languageBox.Enabled = false;
            this._languageBox.FormattingEnabled = true;
            this._languageBox.Location = new System.Drawing.Point(311, 7);
            this._languageBox.Margin = new System.Windows.Forms.Padding(4);
            this._languageBox.Name = "_languageBox";
            this._languageBox.Size = new System.Drawing.Size(99, 21);
            this._languageBox.TabIndex = 18;
            this._languageBox.Visible = false;
            this._languageBox.SelectedIndexChanged += new System.EventHandler(this._languageBox_SelectedIndexChanged);
            // 
            // _serverlistInputBox
            // 
            this._serverlistInputBox.BackColor = System.Drawing.Color.White;
            this._serverlistInputBox.Location = new System.Drawing.Point(42, 8);
            this._serverlistInputBox.Name = "_serverlistInputBox";
            this._serverlistInputBox.Size = new System.Drawing.Size(262, 20);
            this._serverlistInputBox.TabIndex = 19;
            this._serverlistInputBox.Visible = false;
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Location = new System.Drawing.Point(360, 302);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(171, 40);
            this._btnUpdate.TabIndex = 20;
            this._btnUpdate.UseVisualStyleBackColor = true;
            this._btnUpdate.Visible = false;
            this._btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // _downloadStatus
            // 
            this._downloadStatus.AutoSize = true;
            this._downloadStatus.BackColor = System.Drawing.Color.Transparent;
            this._downloadStatus.ForeColor = System.Drawing.Color.White;
            this._downloadStatus.Location = new System.Drawing.Point(15, 314);
            this._downloadStatus.Name = "_downloadStatus";
            this._downloadStatus.Size = new System.Drawing.Size(73, 13);
            this._downloadStatus.TabIndex = 22;
            this._downloadStatus.Text = "Please login...";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 61);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(465, 216);
            this.webBrowser1.TabIndex = 23;
            this.webBrowser1.Url = new System.Uri("http://patches.perfectworld.com.my/introtera.htm", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // _mpatchVer
            // 
            this._mpatchVer.AutoSize = true;
            this._mpatchVer.BackColor = System.Drawing.Color.Transparent;
            this._mpatchVer.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mpatchVer.ForeColor = System.Drawing.Color.White;
            this._mpatchVer.Location = new System.Drawing.Point(243, 314);
            this._mpatchVer.Name = "_mpatchVer";
            this._mpatchVer.Size = new System.Drawing.Size(76, 13);
            this._mpatchVer.TabIndex = 24;
            this._mpatchVer.Text = "Patch Version :";
            // 
            // _bar
            // 
            this._bar.Location = new System.Drawing.Point(13, 330);
            this._bar.Name = "_bar";
            this._bar.Size = new System.Drawing.Size(336, 10);
            this._bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._bar.TabIndex = 25;
            this._bar.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(721, 354);
            this.ControlBox = false;
            this.Controls.Add(this._bar);
            this.Controls.Add(this._mpatchVer);
            this.Controls.Add(this._downloadStatus);
            this.Controls.Add(this._btnUpdate);
            this.Controls.Add(this._serverlistInputBox);
            this.Controls.Add(this._languageBox);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this._btnPlay);
            this.Controls.Add(this._btnMinimize);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._notloggedPanel);
            this.Controls.Add(this._loggedPanel);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tera-Patcher";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this._loggedPanel.ResumeLayout(false);
            this._loggedPanel.PerformLayout();
            this._notloggedPanel.ResumeLayout(false);
            this._notloggedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.Label _welcomeLabel;
        private System.Windows.Forms.Label _coinsLabel;
        private System.Windows.Forms.Label _usernameLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.TextBox _usernameInputBox;
        private System.Windows.Forms.TextBox _passwordInputBox;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.Button _btnPlay;
        private System.Windows.Forms.Button _btnCreate;
        private System.Windows.Forms.Button _btnLogout;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnMinimize;
        private System.Windows.Forms.Panel _notloggedPanel;
        private System.Windows.Forms.Panel _loggedPanel;
        private System.Windows.Forms.ComboBox _languageBox;
        private System.Windows.Forms.TextBox _serverlistInputBox;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.Label _downloadStatus;
        private System.Windows.Forms.Label _mpatchVer;
        private System.Windows.Forms.ProgressBar _bar;
    }
}


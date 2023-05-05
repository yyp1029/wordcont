namespace Form_QQ_2._0_Test4
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtPsaaword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkAutoLogin = new System.Windows.Forms.CheckBox();
            this.chkRememberPassword = new System.Windows.Forms.CheckBox();
            this.linkLabel_Enroll = new System.Windows.Forms.LinkLabel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.pictMinnimize = new System.Windows.Forms.PictureBox();
            this.picHeadshot = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel_Recover = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinnimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadshot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPsaaword
            // 
            this.txtPsaaword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPsaaword.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPsaaword.Location = new System.Drawing.Point(273, 260);
            this.txtPsaaword.Name = "txtPsaaword";
            this.txtPsaaword.Size = new System.Drawing.Size(280, 35);
            this.txtPsaaword.TabIndex = 1;
            this.txtPsaaword.UseSystemPasswordChar = true;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.Black;
            this.panelPassword.Location = new System.Drawing.Point(228, 306);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(325, 1);
            this.panelPassword.TabIndex = 2;
            // 
            // txtAccount
            // 
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccount.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccount.Location = new System.Drawing.Point(273, 175);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(280, 35);
            this.txtAccount.TabIndex = 1;
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.Black;
            this.panelAccount.Location = new System.Drawing.Point(228, 221);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(325, 1);
            this.panelAccount.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(188)))), ((int)(((byte)(252)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(345, 372);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.Location = new System.Drawing.Point(222, 325);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(89, 19);
            this.chkAutoLogin.TabIndex = 5;
            this.chkAutoLogin.Text = "自动登录";
            this.chkAutoLogin.UseVisualStyleBackColor = true;
            // 
            // chkRememberPassword
            // 
            this.chkRememberPassword.AutoSize = true;
            this.chkRememberPassword.Location = new System.Drawing.Point(359, 325);
            this.chkRememberPassword.Name = "chkRememberPassword";
            this.chkRememberPassword.Size = new System.Drawing.Size(89, 19);
            this.chkRememberPassword.TabIndex = 6;
            this.chkRememberPassword.Text = "记住密码";
            this.chkRememberPassword.UseVisualStyleBackColor = true;
            // 
            // linkLabel_Enroll
            // 
            this.linkLabel_Enroll.AutoSize = true;
            this.linkLabel_Enroll.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel_Enroll.Location = new System.Drawing.Point(46, 390);
            this.linkLabel_Enroll.Name = "linkLabel_Enroll";
            this.linkLabel_Enroll.Size = new System.Drawing.Size(67, 15);
            this.linkLabel_Enroll.TabIndex = 9;
            this.linkLabel_Enroll.TabStop = true;
            this.linkLabel_Enroll.Text = "注册账号";
            this.linkLabel_Enroll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Enroll_LinkClicked);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::Form_QQ_2._0_Test4.Properties.Resources.close;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picClose.Location = new System.Drawing.Point(710, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(38, 37);
            this.picClose.TabIndex = 10;
            this.picClose.TabStop = false;
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // picAccount
            // 
            this.picAccount.BackgroundImage = global::Form_QQ_2._0_Test4.Properties.Resources.Account;
            this.picAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAccount.Location = new System.Drawing.Point(228, 171);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(39, 39);
            this.picAccount.TabIndex = 3;
            this.picAccount.TabStop = false;
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.White;
            this.picPassword.BackgroundImage = global::Form_QQ_2._0_Test4.Properties.Resources.Password;
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPassword.Location = new System.Drawing.Point(228, 260);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(39, 39);
            this.picPassword.TabIndex = 3;
            this.picPassword.TabStop = false;
            // 
            // picAdd
            // 
            this.picAdd.BackColor = System.Drawing.Color.Transparent;
            this.picAdd.BackgroundImage = global::Form_QQ_2._0_Test4.Properties.Resources.addition;
            this.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdd.Location = new System.Drawing.Point(373, 115);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(55, 54);
            this.picAdd.TabIndex = 0;
            this.picAdd.TabStop = false;
            // 
            // pictMinnimize
            // 
            this.pictMinnimize.BackColor = System.Drawing.Color.Transparent;
            this.pictMinnimize.BackgroundImage = global::Form_QQ_2._0_Test4.Properties.Resources.minus;
            this.pictMinnimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictMinnimize.Location = new System.Drawing.Point(627, 12);
            this.pictMinnimize.Name = "pictMinnimize";
            this.pictMinnimize.Size = new System.Drawing.Size(35, 37);
            this.pictMinnimize.TabIndex = 11;
            this.pictMinnimize.TabStop = false;
            // 
            // picHeadshot
            // 
            this.picHeadshot.BackColor = System.Drawing.Color.Transparent;
            this.picHeadshot.BackgroundImage = global::Form_QQ_2._0_Test4.Properties.Resources.headqq;
            this.picHeadshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHeadshot.Location = new System.Drawing.Point(359, 92);
            this.picHeadshot.Name = "picHeadshot";
            this.picHeadshot.Size = new System.Drawing.Size(73, 77);
            this.picHeadshot.TabIndex = 0;
            this.picHeadshot.TabStop = false;
            this.picHeadshot.MouseEnter += new System.EventHandler(this.picHeadshot_MouseEnter);
            this.picHeadshot.MouseLeave += new System.EventHandler(this.picHeadshot_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel_Recover
            // 
            this.linkLabel_Recover.AutoSize = true;
            this.linkLabel_Recover.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel_Recover.Location = new System.Drawing.Point(502, 326);
            this.linkLabel_Recover.Name = "linkLabel_Recover";
            this.linkLabel_Recover.Size = new System.Drawing.Size(67, 15);
            this.linkLabel_Recover.TabIndex = 12;
            this.linkLabel_Recover.TabStop = true;
            this.linkLabel_Recover.Text = "找回密码";
            this.linkLabel_Recover.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Recover_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Form_QQ_2._0_Test4.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 435);
            this.Controls.Add(this.linkLabel_Recover);
            this.Controls.Add(this.pictMinnimize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.linkLabel_Enroll);
            this.Controls.Add(this.chkRememberPassword);
            this.Controls.Add(this.chkAutoLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picAccount);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtPsaaword);
            this.Controls.Add(this.picHeadshot);
            this.Controls.Add(this.picAdd);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinnimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.TextBox txtPsaaword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.PictureBox picAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkAutoLogin;
        private System.Windows.Forms.CheckBox chkRememberPassword;
        private System.Windows.Forms.LinkLabel linkLabel_Enroll;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictMinnimize;
        private System.Windows.Forms.PictureBox picHeadshot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel_Recover;
    }
}


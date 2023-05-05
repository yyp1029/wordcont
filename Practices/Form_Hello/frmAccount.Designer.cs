namespace From_QQ_Test1
{
    partial class frmGetAccount
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
            this.lblGetAccount = new System.Windows.Forms.Label();
            this.lblGetPassword = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGetAccount
            // 
            this.lblGetAccount.AutoSize = true;
            this.lblGetAccount.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGetAccount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGetAccount.Location = new System.Drawing.Point(183, 84);
            this.lblGetAccount.Name = "lblGetAccount";
            this.lblGetAccount.Size = new System.Drawing.Size(371, 40);
            this.lblGetAccount.TabIndex = 0;
            this.lblGetAccount.Text = "统一管理员账号：123456";
            // 
            // lblGetPassword
            // 
            this.lblGetPassword.AutoSize = true;
            this.lblGetPassword.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGetPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGetPassword.Location = new System.Drawing.Point(183, 244);
            this.lblGetPassword.Name = "lblGetPassword";
            this.lblGetPassword.Size = new System.Drawing.Size(389, 40);
            this.lblGetPassword.TabIndex = 2;
            this.lblGetPassword.Text = "  统一管理员密码：654321";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Location = new System.Drawing.Point(338, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmGetAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGetPassword);
            this.Controls.Add(this.lblGetAccount);
            this.Name = "frmGetAccount";
            this.Text = "获取账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGetAccount;
        private Label lblGetPassword;
        private Button btnBack;
    }
}
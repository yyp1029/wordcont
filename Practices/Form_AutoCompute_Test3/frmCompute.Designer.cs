namespace Form_AutoCompute_Test3
{
    partial class frmCompute
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
            this.lblRandomNumber1 = new System.Windows.Forms.Label();
            this.lblRandomNumber2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnJudge = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblRandomNumber1
            // 
            this.lblRandomNumber1.AutoSize = true;
            this.lblRandomNumber1.Location = new System.Drawing.Point(135, 49);
            this.lblRandomNumber1.Name = "lblRandomNumber1";
            this.lblRandomNumber1.Size = new System.Drawing.Size(15, 15);
            this.lblRandomNumber1.TabIndex = 0;
            this.lblRandomNumber1.Text = "1";
            // 
            // lblRandomNumber2
            // 
            this.lblRandomNumber2.AutoSize = true;
            this.lblRandomNumber2.Location = new System.Drawing.Point(283, 49);
            this.lblRandomNumber2.Name = "lblRandomNumber2";
            this.lblRandomNumber2.Size = new System.Drawing.Size(15, 15);
            this.lblRandomNumber2.TabIndex = 1;
            this.lblRandomNumber2.Text = "2";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(203, 49);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(15, 15);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "+";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(367, 49);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(15, 15);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(501, 49);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 25);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(465, 156);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(75, 23);
            this.btnJudge.TabIndex = 5;
            this.btnJudge.Text = "判分";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(167, 156);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion.TabIndex = 6;
            this.btnQuestion.Text = "出题";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(182, 242);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 154);
            this.listBox1.TabIndex = 7;
            // 
            // frmCompute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblRandomNumber2);
            this.Controls.Add(this.lblRandomNumber1);
            this.Name = "frmCompute";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandomNumber1;
        private System.Windows.Forms.Label lblRandomNumber2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.ListBox listBox1;
    }
}


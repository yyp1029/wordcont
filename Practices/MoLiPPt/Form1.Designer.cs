namespace MoNiPPt
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDiamond = new System.Windows.Forms.RadioButton();
            this.rbtnArrow = new System.Windows.Forms.RadioButton();
            this.rbtnPentagon = new System.Windows.Forms.RadioButton();
            this.rbtnTriangle = new System.Windows.Forms.RadioButton();
            this.rbtnEllipse = new System.Windows.Forms.RadioButton();
            this.rbtnFreeLine = new System.Windows.Forms.RadioButton();
            this.rbtnRect = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDiamond);
            this.groupBox1.Controls.Add(this.rbtnArrow);
            this.groupBox1.Controls.Add(this.rbtnPentagon);
            this.groupBox1.Controls.Add(this.rbtnTriangle);
            this.groupBox1.Controls.Add(this.rbtnEllipse);
            this.groupBox1.Controls.Add(this.rbtnFreeLine);
            this.groupBox1.Controls.Add(this.rbtnRect);
            this.groupBox1.Location = new System.Drawing.Point(37, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图形选择";
            // 
            // rbtnDiamond
            // 
            this.rbtnDiamond.AutoSize = true;
            this.rbtnDiamond.Location = new System.Drawing.Point(148, 143);
            this.rbtnDiamond.Name = "rbtnDiamond";
            this.rbtnDiamond.Size = new System.Drawing.Size(58, 19);
            this.rbtnDiamond.TabIndex = 7;
            this.rbtnDiamond.TabStop = true;
            this.rbtnDiamond.Text = "菱形";
            this.rbtnDiamond.UseVisualStyleBackColor = true;
            // 
            // rbtnArrow
            // 
            this.rbtnArrow.AutoSize = true;
            this.rbtnArrow.Location = new System.Drawing.Point(148, 100);
            this.rbtnArrow.Name = "rbtnArrow";
            this.rbtnArrow.Size = new System.Drawing.Size(58, 19);
            this.rbtnArrow.TabIndex = 6;
            this.rbtnArrow.TabStop = true;
            this.rbtnArrow.Text = "箭头";
            this.rbtnArrow.UseVisualStyleBackColor = true;
            this.rbtnArrow.CheckedChanged += new System.EventHandler(this.rbtnArrow_CheckedChanged);
            // 
            // rbtnPentagon
            // 
            this.rbtnPentagon.AutoSize = true;
            this.rbtnPentagon.Location = new System.Drawing.Point(148, 50);
            this.rbtnPentagon.Name = "rbtnPentagon";
            this.rbtnPentagon.Size = new System.Drawing.Size(73, 19);
            this.rbtnPentagon.TabIndex = 5;
            this.rbtnPentagon.TabStop = true;
            this.rbtnPentagon.Text = "五角星";
            this.rbtnPentagon.UseVisualStyleBackColor = true;
            // 
            // rbtnTriangle
            // 
            this.rbtnTriangle.AutoSize = true;
            this.rbtnTriangle.Location = new System.Drawing.Point(41, 190);
            this.rbtnTriangle.Name = "rbtnTriangle";
            this.rbtnTriangle.Size = new System.Drawing.Size(73, 19);
            this.rbtnTriangle.TabIndex = 3;
            this.rbtnTriangle.TabStop = true;
            this.rbtnTriangle.Text = "三角形";
            this.rbtnTriangle.UseVisualStyleBackColor = true;
            // 
            // rbtnEllipse
            // 
            this.rbtnEllipse.AutoSize = true;
            this.rbtnEllipse.Location = new System.Drawing.Point(41, 143);
            this.rbtnEllipse.Name = "rbtnEllipse";
            this.rbtnEllipse.Size = new System.Drawing.Size(58, 19);
            this.rbtnEllipse.TabIndex = 2;
            this.rbtnEllipse.TabStop = true;
            this.rbtnEllipse.Text = "椭圆";
            this.rbtnEllipse.UseVisualStyleBackColor = true;
            // 
            // rbtnFreeLine
            // 
            this.rbtnFreeLine.AutoSize = true;
            this.rbtnFreeLine.Location = new System.Drawing.Point(41, 100);
            this.rbtnFreeLine.Name = "rbtnFreeLine";
            this.rbtnFreeLine.Size = new System.Drawing.Size(58, 19);
            this.rbtnFreeLine.TabIndex = 1;
            this.rbtnFreeLine.TabStop = true;
            this.rbtnFreeLine.Text = "曲线";
            this.rbtnFreeLine.UseVisualStyleBackColor = true;
            // 
            // rbtnRect
            // 
            this.rbtnRect.AutoSize = true;
            this.rbtnRect.Location = new System.Drawing.Point(41, 50);
            this.rbtnRect.Name = "rbtnRect";
            this.rbtnRect.Size = new System.Drawing.Size(58, 19);
            this.rbtnRect.TabIndex = 0;
            this.rbtnRect.TabStop = true;
            this.rbtnRect.Text = "矩形";
            this.rbtnRect.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(58, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "撤销";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(58, 356);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(103, 34);
            this.btnRetry.TabIndex = 1;
            this.btnRetry.Text = "重做";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFreeLine;
        private System.Windows.Forms.RadioButton rbtnRect;
        private System.Windows.Forms.RadioButton rbtnEllipse;
        private System.Windows.Forms.RadioButton rbtnTriangle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.RadioButton rbtnDiamond;
        private System.Windows.Forms.RadioButton rbtnArrow;
        private System.Windows.Forms.RadioButton rbtnPentagon;
    }
}


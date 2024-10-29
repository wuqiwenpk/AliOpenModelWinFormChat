namespace AliChat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRes = new System.Windows.Forms.RichTextBox();
            this.textAsk = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "你好，我是文心一言";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(180, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "作为你的智能伙伴，我既能写文案、想点子，又能陪你聊天、答疑解惑。";
            // 
            // textRes
            // 
            this.textRes.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textRes.Location = new System.Drawing.Point(12, 77);
            this.textRes.Name = "textRes";
            this.textRes.Size = new System.Drawing.Size(774, 384);
            this.textRes.TabIndex = 2;
            this.textRes.Text = "";
            // 
            // textAsk
            // 
            this.textAsk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAsk.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textAsk.Location = new System.Drawing.Point(77, 496);
            this.textAsk.Name = "textAsk";
            this.textAsk.Size = new System.Drawing.Size(558, 89);
            this.textAsk.TabIndex = 3;
            this.textAsk.Text = "请输入提问内容...";
            this.textAsk.Click += new System.EventHandler(this.textAsk_Click);
            this.textAsk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAsk_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "提问";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.Font = new System.Drawing.Font("宋体", 10F);
            this.labTip.ForeColor = System.Drawing.Color.Red;
            this.labTip.Location = new System.Drawing.Point(293, 588);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(98, 14);
            this.labTip.TabIndex = 5;
            this.labTip.Text = "网络请求中...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 657);
            this.Controls.Add(this.labTip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAsk);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AliChat Open Model 1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textRes;
        private System.Windows.Forms.RichTextBox textAsk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labTip;
    }
}


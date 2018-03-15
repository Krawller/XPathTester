namespace XPathTester
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
			this.tbxURL = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxExpression = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblNodeCount = new System.Windows.Forms.Label();
			this.btnGo = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tbxValue = new System.Windows.Forms.TextBox();
			this.tbxUserAgent = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbxCookie = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL:";
			// 
			// tbxURL
			// 
			this.tbxURL.Location = new System.Drawing.Point(51, 10);
			this.tbxURL.Name = "tbxURL";
			this.tbxURL.Size = new System.Drawing.Size(479, 20);
			this.tbxURL.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Xpath:";
			// 
			// tbxExpression
			// 
			this.tbxExpression.Location = new System.Drawing.Point(51, 36);
			this.tbxExpression.Name = "tbxExpression";
			this.tbxExpression.Size = new System.Drawing.Size(479, 20);
			this.tbxExpression.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Node Counts:";
			// 
			// lblNodeCount
			// 
			this.lblNodeCount.AutoSize = true;
			this.lblNodeCount.Location = new System.Drawing.Point(91, 150);
			this.lblNodeCount.Name = "lblNodeCount";
			this.lblNodeCount.Size = new System.Drawing.Size(13, 13);
			this.lblNodeCount.TabIndex = 5;
			this.lblNodeCount.Text = "0";
			// 
			// btnGo
			// 
			this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGo.Location = new System.Drawing.Point(455, 154);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 8;
			this.btnGo.Text = "Get Content";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Value:";
			// 
			// tbxValue
			// 
			this.tbxValue.Location = new System.Drawing.Point(12, 183);
			this.tbxValue.Multiline = true;
			this.tbxValue.Name = "tbxValue";
			this.tbxValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxValue.Size = new System.Drawing.Size(518, 120);
			this.tbxValue.TabIndex = 10;
			// 
			// tbxUserAgent
			// 
			this.tbxUserAgent.Location = new System.Drawing.Point(82, 62);
			this.tbxUserAgent.Name = "tbxUserAgent";
			this.tbxUserAgent.Size = new System.Drawing.Size(448, 20);
			this.tbxUserAgent.TabIndex = 12;
			this.tbxUserAgent.Text = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome" +
    "/61.0.3163.49 Safari/537.36 OPR/48.0.2685.7 (Edition beta)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "User Agent:";
			// 
			// tbxCookie
			// 
			this.tbxCookie.Location = new System.Drawing.Point(62, 88);
			this.tbxCookie.Name = "tbxCookie";
			this.tbxCookie.Size = new System.Drawing.Size(468, 20);
			this.tbxCookie.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Cookie:";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnGo;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 312);
			this.Controls.Add(this.tbxCookie);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbxUserAgent);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbxValue);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.lblNodeCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxExpression);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxURL);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "XPathTester";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxExpression;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNodeCount;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxValue;
		private System.Windows.Forms.TextBox tbxUserAgent;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbxCookie;
		private System.Windows.Forms.Label label6;
	}
}


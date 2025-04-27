namespace Ch02_p29_GUI_EX
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_InputName = new System.Windows.Forms.TextBox();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_InputName
            // 
            this.tb_InputName.Location = new System.Drawing.Point(121, 184);
            this.tb_InputName.Name = "tb_InputName";
            this.tb_InputName.Size = new System.Drawing.Size(100, 22);
            this.tb_InputName.TabIndex = 0;
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Location = new System.Drawing.Point(147, 152);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(32, 12);
            this.lb_Welcome.TabIndex = 1;
            this.lb_Welcome.Text = "歡迎:";
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(260, 184);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 2;
            this.bt_Login.Text = "登入";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.tb_InputName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_InputName;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Button bt_Login;
    }
}


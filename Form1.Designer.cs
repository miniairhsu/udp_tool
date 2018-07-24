namespace udp_tool
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
            this.recvBox = new System.Windows.Forms.TextBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.addrLabel = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recvBox
            // 
            this.recvBox.Location = new System.Drawing.Point(13, 120);
            this.recvBox.Multiline = true;
            this.recvBox.Name = "recvBox";
            this.recvBox.Size = new System.Drawing.Size(529, 167);
            this.recvBox.TabIndex = 0;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(10, 12);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(52, 18);
            this.msgLabel.TabIndex = 1;
            this.msgLabel.Text = "ASCII";
            this.msgLabel.UseMnemonic = false;
            // 
            // addrLabel
            // 
            this.addrLabel.AutoSize = true;
            this.addrLabel.Location = new System.Drawing.Point(10, 63);
            this.addrLabel.Name = "addrLabel";
            this.addrLabel.Size = new System.Drawing.Size(64, 18);
            this.addrLabel.TabIndex = 2;
            this.addrLabel.Text = "Address";
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(68, 9);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(474, 29);
            this.msgBox.TabIndex = 3;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(80, 60);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(177, 29);
            this.addressBox.TabIndex = 4;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(275, 63);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(36, 18);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Port";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(317, 60);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 29);
            this.portBox.TabIndex = 6;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(467, 60);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 36);
            this.sendBtn.TabIndex = 7;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sendBtn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 310);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.addrLabel);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.recvBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.sendClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recvBox;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Label addrLabel;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Button sendBtn;
    }
}


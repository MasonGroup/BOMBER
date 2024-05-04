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
    public partial class about_window : MetroForm
    {
        public about_window()
        {
            InitializeComponent();
            var styleManager = new MetroStyleManager();
            styleManager.Theme = MetroThemeStyle.Dark;
            styleManager.Style = MetroFramework.MetroColorStyle.Silver;
            styleManager.Owner = this;
        }

        private void about_Load(object sender, EventArgs e)
        {
            this.Resizable = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

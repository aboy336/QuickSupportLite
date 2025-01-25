using Microsoft.Win32;
using QuickSupportLite.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSupportLite
{
    public partial class QuickSupportLite : Form
    {
        private ServiceController volvoTechService;
        private ServiceController clupService;
        private ServiceController fidoService;

        private BackgroundWorker backgroundWorker1;

        public QuickSupportLite()
        {
            InitializeComponent();

            serviceStatusTimer.Interval = 500;
            serviceStatusTimer.Enabled = true;

            clupStatusTimer.Interval = 2000;
            clupStatusTimer.Enabled = true;

            fidoStatusTimer.Interval = 2000;
            fidoStatusTimer.Enabled = true;

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            volvoTechService = new ServiceController("VolvoTechToolServiceController");
            backgroundWorker1.WorkerSupportsCancellation = true;

            clupService = new ServiceController("VolvoIt.CLUP.Agent.Host.exe");
            fidoService = new ServiceController("VolvoIt.Fido.Agent.Service.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // QuickSupport Lite Version
            //var version = Assembly.GetExecutingAssembly().GetName().Version;
            //quickSupportLiteVersion.Text = $"QuickSupprt Lite Version: {version}";

            // TechTool Version
            string programName = "Tech Tool"; // Tech Tool Name Indicated on PC
            string techToolVersion = GetProgramVersion(programName);
            if (!string.IsNullOrEmpty(techToolVersion))
            {
                techToolVersionLabel.Text = $"{programName} Version: {techToolVersion}";
            }
            else
            {
                techToolVersionLabel.Text = $"{programName} is not installed.";
            }
        }


        // Form1 Load "Get Tech Tool Version"
        private string GetProgramVersion(string programName)
        {
            try
            {
                string registryKey = @"SOFTWARE\WOW6432Node\Volvo Information Technology\";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey))
                {
                    if (key != null)
                    {
                        foreach (string subkeyName in key.GetSubKeyNames())
                        {
                            using (RegistryKey subkey = key.OpenSubKey(subkeyName))
                            {
                                if (subkey != null)
                                {
                                    string displayName = subkey.GetValue("TechToolVersion") as string;
                                    if (!string.IsNullOrEmpty(displayName))
                                    {
                                        return subkey.GetValue("TechToolVersion") as string;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the program version: {ex.Message}");
            }
            return string.Empty;
        }



        // Services, Timer & Background Processes
        void CheckServiceStatus(string serviceName, PictureBox icon)
        {
            try
            {
                ServiceController[] services = ServiceController.GetServices();
                var serviceNames = services.FirstOrDefault(s => s.ServiceName == serviceName);

                if (serviceNames != null)
                {
                    serviceNames.Refresh();
                    switch (serviceNames.Status)
                    {
                        case ServiceControllerStatus.Running:
                            icon.BackgroundImage = Resources.green;
                            break;
                        case ServiceControllerStatus.Stopped:
                            icon.BackgroundImage = Resources.red;
                            break;
                        case ServiceControllerStatus.StartPending:
                        case ServiceControllerStatus.StopPending:
                            icon.BackgroundImage = Resources.yellow;
                            break;

                        default:
                            icon.BackgroundImage = Resources.gray;
                            break;
                    }
                }
                else
                {
                    icon.BackgroundImage = Resources.gray; // Service not found
                }
            }
            catch (Exception ex)
            {
                icon.BackgroundImage = Resources.gray;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            ServiceController[] services = ServiceController.GetServices();
            var volvoTechService = services.FirstOrDefault(s => s.ServiceName == "VolvoTechToolServiceController");

            if (volvoTechService == null)
            {
                MessageBox.Show("Service Not Installed");
                return;
            }

            if (volvoTechService.Status == ServiceControllerStatus.Running)
            {
                volvoTechService.Stop();
                volvoTechService.WaitForStatus(ServiceControllerStatus.Stopped);
            }
            else
            {
                volvoTechService.Start();
                volvoTechService.WaitForStatus(ServiceControllerStatus.Running);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CheckServiceStatus("VolvoTechToolServiceController", serviceStatusIcon);
        }

        private void serviceStatusTimer_Tick(object sender, EventArgs e)
        {
            CheckServiceStatus("VolvoTechToolServiceController", serviceStatusIcon);
        }

        private void clupStatusTimer_Tick(object sender, EventArgs e)
        {
            CheckServiceStatus("VolvoIt.CLUP.Agent.Host.exe", clupStatusIcon);
        }

        private void fidoStatusTimer_Tick(object sender, EventArgs e)
        {
            CheckServiceStatus("VolvoIt.Fido.Agent.Service.exe", fidoStatusIcon);
        }




        // TechTool Services

        private void bafButton_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void clupButton_Click(object sender, EventArgs e)
        {
            try
            {
                clupService.Refresh();
                if (clupService.Status == ServiceControllerStatus.Running)
                {
                    clupService.Stop();
                    clupService.WaitForStatus(ServiceControllerStatus.Stopped);
                }
                else if (clupService.Status == ServiceControllerStatus.Stopped)
                {
                    clupService.Start();
                    clupService.WaitForStatus(ServiceControllerStatus.Running);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
        }

        private void fidoButton_Click(object sender, EventArgs e)
        {
            try
            {
                fidoService.Refresh();
                if (fidoService.Status == ServiceControllerStatus.Running)
                {
                    fidoService.Stop();
                    fidoService.WaitForStatus(ServiceControllerStatus.Stopped);
                }
                else if (fidoService.Status == ServiceControllerStatus.Stopped)
                {
                    fidoService.Start();
                    fidoService.WaitForStatus(ServiceControllerStatus.Running);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
        }


        // TechTool Repair Functions

        private void apciFixButton_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\ProgramData\Tech Tool\Waf\DtR\ApciPlusData.db7.cache";

            try
            {
                if (Directory.Exists(folderPath))
                {
                    SetAttributesNormal(new DirectoryInfo(folderPath));

                    Directory.Delete(folderPath, true);
                    MessageBox.Show("APCI Cache Has Been Reset .");
                }
                else
                {
                    MessageBox.Show("Folder does not exist.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private static void SetAttributesNormal(DirectoryInfo dir)
        {
            foreach (var subDir in dir.GetDirectories())
                SetAttributesNormal(subDir);
            foreach (var file in dir.GetFiles())
            {
                file.Attributes = FileAttributes.Normal;
            }
        }

        private void wafButton_Click(object sender, EventArgs e)
        {
            try
            {
                string serviceName = "VolvoTechToolServiceController";
                ServiceController sc = new ServiceController(serviceName);

                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    string[] filePaths = new string[]
                    {
                @"C:\ProgramData\Tech Tool\Waf\*.sdf",
                @"C:\ProgramData\Tech Tool\Waf\*.dat",
                @"C:\ProgramData\Tech Tool\Waf\*Product*",
                @"C:\ProgramData\Tech Tool\Waf\*ESWM*",
                    };

                    foreach (string filePath in filePaths)
                    {
                        string[] matchingFiles = Directory.GetFiles(Path.GetDirectoryName(filePath), Path.GetFileName(filePath));
                        foreach (string file in matchingFiles)
                        {
                            File.Delete(file);
                        }
                    }

                    MessageBox.Show("Files Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Service Has Not Stopped. WAF Repair Not Complete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting WAF Files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rootElementButton_Click(object sender, EventArgs e)
        {
            string volvoFolderPath = Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%\Volvo_Information_Technol");

            try
            {
                if (Directory.Exists(volvoFolderPath))
                {
                    Directory.Delete(volvoFolderPath, true); // 'true' for recursive deletion
                    MessageBox.Show("Root Element Fix Completed");
                }
                else
                {
                    MessageBox.Show("Folder Not Found. Root Element Fix Not Needed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Root Fix Failed. Error: " + ex.Message);
            }
        }

        private void baldoLocalButton_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            process.StartInfo = startInfo;
            Process.Start("cmd.exe", @"/c net stop volvotechtoolservicecontroller");
            Process.Start("cmd.exe", "/c del \"C:\\ProgramData\\Tech Tool\\baldolocal.db\"");
            Process.Start("cmd.exe", "/c pause");
        }


        // TechTool Folder Locations

        private void logFolderButton_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\ProgramData\Tech Tool\Logs";
            Process.Start("explorer.exe", folderPath);
        }

        private void apciFolderButton_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\ProgramData\Tech Tool\Waf\DtR";
            Process.Start("explorer.exe", folderPath);
        }


        // System Components

        private void appwizButton_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = startInfo;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c appwiz.cpl";
            process.Start();
        }
        private void servicesButton_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = startInfo;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c services.msc";
            process.Start();
        }
        private void systemInfoButton_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = "cmd.exe";
            Process.Start("cmd.exe", "/k systeminfo");
        }
    }
}

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace EngineNumber_checker
{
    public partial class DuplicateDetected : Form
    {
        Process_handler process_Handler;
        Logger logger;
        Main main;

        public DuplicateDetected(Main main, Process_handler process_Handler, Logger logger)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.main = main;
            this.process_Handler = process_Handler;
            this.logger = logger;

            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationProperties_FormClosing);
        }

        public void RefreshData()
        {
            this.lb_RepeatedEngNumValue.Text = main.CurrentEngine;
            this.lb_BlockLinkedValue.Text = main.queryResultQualityData;
            this.lb_BlockLinkedDate.Text = "(" + main.queryResultREG_DT + " " + main.queryResultREG_TM + ")";
        }

        private void ApplicationProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; // hides the form, cancels closing event
        }

        private void btn_ContinueAfterTrigger_Click(object sender, EventArgs e)
        {
            process_Handler.ResumeProcess(process_Handler.GetProcessID("PlcStationClient"));
            logger.Log("PLC_Client Adapter process resumed! CONTINUE WAS HITTED");
            main.Tb_Console.Text = "PLC_Client Adapter process resumed!" + main.Tb_Console.Text;
            main.Timer2.Start();
            this.Hide();
        }

        private void btn_StopAfterTrigger_Click(object sender, EventArgs e)
        {
            process_Handler.KillProcess("PlcStationClient");
            logger.Log("PLC_Client Adapter process killed! STOP WAS HITTED");
            main.Tb_Console.Text = "PLC_Client Adapter process killed!" + main.Tb_Console.Text;
            main.Timer2.Start();
            this.Hide();

            // Use the desktop shortcut to find the target executable
            string shortcutPath = @"C:\Users\YourUser\Desktop\PlcStationClient.lnk"; // Update with actual path
            string targetPath = ShortcutHelper.GetShortcutTarget(shortcutPath);

            if (!string.IsNullOrEmpty(targetPath) && File.Exists(targetPath))
            {
                Process yourProcess = new Process();
                yourProcess.StartInfo.FileName = targetPath;
                yourProcess.Start();
            }
            else
            {
                logger.Log("Shortcut target not found or invalid. The PLC Station Client will not restart");
            }
        }

        // Helper class to retrieve shortcut target path
        private static class ShortcutHelper
        {
            [DllImport("shell32.dll", CharSet = CharSet.Auto)]
            private static extern uint SHGetPathFromIDList(IntPtr pidl, StringBuilder pszPath);

            [DllImport("shell32.dll", CharSet = CharSet.Auto)]
            private static extern int SHGetDesktopFolder(out IntPtr ppshf);

            public static string GetShortcutTarget(string shortcutPath)
            {
                if (string.IsNullOrEmpty(shortcutPath) || !File.Exists(shortcutPath))
                    return null;

                StringBuilder path = new StringBuilder(260); // MAX_PATH
                IntPtr pidl = IntPtr.Zero;

                try
                {
                    // Checking for success (0 means success)
                    if (SHGetDesktopFolder(out pidl) == 0)
                    {
                        if (SHGetPathFromIDList(pidl, path) != 0) // Check if SHGetPathFromIDList is successful
                        {
                            return path.ToString();
                        }
                    }
                }
                finally
                {
                    if (pidl != IntPtr.Zero)
                    {
                        Marshal.FreeCoTaskMem(pidl);
                    }
                }

                return null;
            }

        }
    }
}

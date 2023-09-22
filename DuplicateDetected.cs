using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineNumber_checker
{
    public partial class DuplicateDetected : Form
    {
        Process_handler process_Handler;
        Logger logger;

        Main main;
        Form4 form4 = new Form4();

        string date = "";
        string time = "";

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
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }

        private void btn_ContinueAfterTrigger_Click(object sender, EventArgs e)
        {
            process_Handler.ResumeProcess(process_Handler.GetProcessID("PlcStationClient"));
            logger.Log("PLC_Client Adapter process resumed! CONTINUE WAS HITTED");
            main.tb_Console.Text = "PLC_Client Adapter process resumed!" + main.tb_Console.Text;
            main.Timer2.Start();
            this.Hide();
        }

        private void btn_StopAfterTrigger_Click(object sender, EventArgs e)
        {
            process_Handler.KillProcess("PlcStationClient");
            logger.Log("PLC_Client Adapter process killed! STOP WAS HITTED");
            main.tb_Console.Text = "PLC_Client Adapter process killed!" + main.tb_Console.Text;
            main.Timer2.Start();
            this.Hide();
            //form4.Show();

            Process yourProcess = new Process();
            yourProcess.StartInfo.FileName = @"C:\SW\SQS Client\ACA\App\PlcStationClient.exe";

            yourProcess.Start();

        }
    }
}

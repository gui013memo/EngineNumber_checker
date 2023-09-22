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
    public partial class Blinking_form : Form
    {
        Process_handler process_Handler = new Process_handler();

        Form1 form1;
        Form4 form4 = new Form4();

        string date = "";
        string time = "";

        public Blinking_form(Form1 f)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            form1 = f;

            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationProperties_FormClosing);
        }

        public void RefreshDataForF3()
        {
            this.lb_RepeatedEngNumValue.Text = form1.CurrentEngine;
            this.lb_BlockLinkedValue.Text = form1.queryResultQualityData;
            this.lb_BlockLinkedDate.Text = "(" + form1.queryResultREG_DT + " " + form1.queryResultREG_TM + ")";
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
            process_Handler.ResumeProcess(form1.GetProcessID("PlcStationClient"));
            form1.Log("PLC_Client Adapter process resumed! CONTINUE WAS HITTED");
            form1.tb_Console.Text = "PLC_Client Adapter process resumed!" + form1.tb_Console.Text;
            form1.Timer2.Start();
            this.Hide();
        }

        private void btn_StopAfterTrigger_Click(object sender, EventArgs e)
        {
            process_Handler.KillProcess("PlcStationClient");
            form1.Log("PLC_Client Adapter process killed! STOP WAS HITTED");
            form1.tb_Console.Text = "PLC_Client Adapter process killed!" + form1.tb_Console.Text;
            form1.Timer2.Start();
            this.Hide();
            //form4.Show();

            Process yourProcess = new Process();
            yourProcess.StartInfo.FileName = @"C:\SW\SQS Client\ACA\App\PlcStationClient.exe";

            yourProcess.Start();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        string date = "";
        string time = "";
        public Blinking_form(Form1 f)
        {
            date = form1.queryResultREG_DT;
            time = form1.queryResultREG_TM;

            date = date.Insert(4, "-");
            date = date.Insert(7, "-");

            time = time.Insert(2, "-");
            time = time.Insert(5, "-");

            InitializeComponent();
            form1 = f;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationProperties_FormClosing);
            this.lb_RepeatedEngNumValue.Text = form1.CurrentEngine;
            this.lb_BlockLinkedValue.Text = form1.queryResultQualityData;
            this.lb_BlockLinkedDate.Text = date + " " + time;

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
            form1.Log("PLC_Client Adapter process resumed!");
            form1.tb_Console.Text = "PLC_Client Adapter process resumed!" + form1.tb_Console.Text;
            form1.Timer2.Start();
        }

        private void btn_StopAfterTrigger_Click(object sender, EventArgs e)
        {
            process_Handler.KillProcess("PlcStationClient");
            form1.Log("PLC_Client Adapter process killed!");
            form1.tb_Console.Text = "PLC_Client Adapter process killed!" + form1.tb_Console.Text;
            form1.Timer2.Start();
        }
    }
}

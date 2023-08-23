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

        public Blinking_form(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationProperties_FormClosing);
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
            Form1 form1 = new Form1();
            process_Handler.ResumeProcess(form1.GetProcessID("PlcStationClient"));
            form1.Log("PLC_Client Adapter process resumed!");
            form1.tb_Console.Text = "PLC_Client Adapter process resumed!" + form1.tb_Console.Text;
            form1.Timer2.Start();
        }

        private void btn_StopAfterTrigger_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            process_Handler.KillProcess("PlcStationClient");
            form1.Log("PLC_Client Adapter process killed!");
            form1.tb_Console.Text = "PLC_Client Adapter process killed!" + form1.tb_Console.Text;
            form1.Timer2.Start();
        }
    }
}

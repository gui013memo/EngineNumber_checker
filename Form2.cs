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
    public partial class IntervalForm : Form
    {

        int timerTickMsValue = 1000;
        int timerTickMsValueSaved = 0;

        int engineLifeTimeMsValue = 3;
        int engineLifeTimeSaved = 0;

        Form1 form1;
        public IntervalForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationProperties_FormClosing);
        }

        private Form1 mainForm = null;

        private void ApplicationProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }

        private void btn_UpTimeTick_Click(object sender, EventArgs e)
        {
            if (timerTickMsValue < 4000)
            {
                timerTickMsValue += 100;
                tb_TimerTickValue.Text = timerTickMsValue.ToString() + "ms";
            }

        }

        private void btn_DownTimerTick_Click(object sender, EventArgs e)
        {
            if (timerTickMsValue > 300)
            {
                timerTickMsValue -= 100;
                tb_TimerTickValue.Text = timerTickMsValue.ToString() + "ms";
            }

        }

        public void btn_Save_Click(object sender, EventArgs e)
        {

            form1.SaveParameters();

            this.Hide();
        }

        private void btn_UpEngineLifeTime_Click(object sender, EventArgs e)
        {
            if (engineLifeTimeMsValue < 15)
            {
                engineLifeTimeMsValue += 1;
                tb_EngineLifeTimeValue.Text = engineLifeTimeMsValue.ToString() + " Sec";
            }
        }

        private void btn_DownEngineLifeTime_Click(object sender, EventArgs e)
        {
            if (engineLifeTimeMsValue > 1)
            {
                engineLifeTimeMsValue -= 1;
                tb_EngineLifeTimeValue.Text = engineLifeTimeMsValue.ToString() + " Sec";
            }
        }

        public int getTimerTickMsValue
        {
            get { return timerTickMsValue; }
        }
        public string getEngineLifeTimeMsValue
        {
            get { return engineLifeTimeMsValue.ToString(); }
        }

        public int getEngineLifeTimeMsValueInt
        {
            get { return engineLifeTimeMsValue; }
        }

        public string getConnectionString
        {
            get { return tb_ConnectionString.Text; }
        }
    }
}

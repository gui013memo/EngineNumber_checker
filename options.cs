using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineNumber_checker
{
    public partial class Options : Form
    {

        Main main;

        int timerTickMsValue = 1000;
        int timerTickMsValueSaved = 1000;

        int engineLifeTimeMsValue = 3;
        int engineLifeTimeSaved = 3;
        string connectionString = "172.16.0.1";
        string connectionStringSaved = string.Empty;

        public Options(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIsClosing);
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            tb_TimerTickValue.Text = timerTickMsValueSaved.ToString() + "ms";
            tb_EngineLifeTimeValue.Text = engineLifeTimeSaved.ToString() + " Sec";
            timerTickMsValue = timerTickMsValueSaved;
            engineLifeTimeMsValue = engineLifeTimeSaved;

            tb_ConnectionString.Text = connectionString;

            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }

        private void btn_UpTimerTick_Click(object sender, EventArgs e)
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
            timerTickMsValueSaved = timerTickMsValue;
            engineLifeTimeSaved = engineLifeTimeMsValue;
            tb_ConnectionString.Text = connectionStringSaved;
            connectionString = connectionStringSaved;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["test"].Value = "blah";
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            main.SaveParameters();

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

        private void tb_ConnectionString_TextChanged(object sender, EventArgs e)
        {
            connectionStringSaved = tb_ConnectionString.Text;
        }

        public int GetTimerTickMsValue
        {
            get { return timerTickMsValue; }
        }
        public string GetEngineLifeTimeMsValue
        {
            get { return engineLifeTimeMsValue.ToString(); }
        }

        public int GetEngineLifeTimeMsValueInt
        {
            get { return engineLifeTimeMsValue; }
        }

        public string GetConnectionString
        {
            get { return tb_ConnectionString.Text; }
        }
    }
}

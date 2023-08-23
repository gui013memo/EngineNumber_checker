//using EngineNum_match_validator;
using S7.Net;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace EngineNumber_checker
{
    public partial class Form1 : Form
    {
        Logger my_logger = new Logger();
        Process_handler process_Handler = new Process_handler();

        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader reader;
        string connetionString;
        string timeOffSetForSQL = "3";
        public string CurrentEngine = "";

        bool startBtn = false;

        Plc PLC_M1 = new Plc(CpuType.S7300, "140.100.101.1", 0, 2); //MY PC IP ADDRESS: 140.100.101.9 

        Blinking_form blinking_Form;

        int engineLifeTime = 3;
        IntervalForm form2;


        public Form1()
        {
            blinking_Form = new Blinking_form(this);
            form2 = new IntervalForm(this);
            InitializeComponent();
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIsClosing);
            my_logger.Log("EngineNumber-Checker app Opened!");
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            my_logger.Log("EngineNumber-Checker app Closed!");
        }

        public void Log(string msg)
        {
            my_logger.Log(msg);
        }

        public void EngineDuplicate()
        {
            blinking_Form.Show();
        }

        public int GetProcessID(string processName)
        {
            int id = 0;

            var processes = Process.GetProcessesByName(processName);
            foreach (var p in processes)
            {
                id = p.Id;
            }
            return id;
        }

        public string GetCurrentEngineBySQL()
        {
            string output = "";

            string query = " SELECT TOP (1) " +
                          " [ENG_SN]" +
                          " FROM [HMB].[SQS].[ENG_BUILD_DATA]" + " WHERE " +
                          " ( REG_TM > REPLACE(convert(time(0), getdate()), ':', '') - " + form2.getEngineLifeTimeMsValue +
                          " AND " + "REG_TM < REPLACE(convert(time(0), getdate()), ':', '') )" + " AND " +
                          "( BLK_NO = ' ' AND REG_DT = REPLACE(convert(date, getdate()), '-', '') )" +
                          " ORDER by ID desc ";

            connetionString = @"Data Source=localhost;Initial Catalog=HMB;User ID=sa;Password=T00lsNetPwd;Trusted_Connection=true";
            //connetionString = @"Data Source=" + form2.getConnectionString + ";Initial Catalog=HMB;User ID=EngineNumber-APP;Password=sqs";

            cnn = new SqlConnection(connetionString);
            cnn.Open();

            command = new SqlCommand(query, cnn);
            reader = command.ExecuteReader();

            if (reader.Read())
                output = reader.GetString(0);

            reader.Close();
            command.Dispose();
            cnn.Close();

            return output;
        }

        public void EngineValidate()
        {
            CurrentEngine = GetCurrentEngineBySQL();

            if (CurrentEngine != "")
            {
                tb_Console.Text = "New engine detected: " + CurrentEngine + "\r\n" + tb_Console.Text;
                my_logger.Log("New engine detected: " + CurrentEngine);

                string query = "SELECT TOP (1)" +
                "[ENG_NO]" +
                ",[QUALITY_DATA]" +
                "FROM [HMB].[MES].[Q_QUALITY_SEND_IF]" +
                "WHERE " +
                "ENG_NO = " + "'" + CurrentEngine + "'" +
                "and (QM_CD = 'BKA00-100-01-M1' and QUALITY_DATA LIKE '%Block%')";

                connetionString = @"Data Source=localhost;Initial Catalog=HMB;User ID=sa;Password=T00lsNetPwd;Trusted_Connection=true";
                //connetionString = @"Data Source=" + form2.getConnectionString + ";Initial Catalog=HMB;User ID=EngineNumber-APP;Password=sqs";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                command = new SqlCommand(query, cnn);
                reader = command.ExecuteReader();

                object[] results = new object[2];
                while (reader.Read())
                {
                    reader.GetValues(results);
                }

                if (results[0] != null)
                {
                    string queryResultEngine = results[0].ToString();
                    string queryResultQualityData = results[1].ToString().Substring(41);

                    if (queryResultEngine != null)
                    {
                        tb_Console.Text = "Process Suspended" + tb_Console.Text;
                        process_Handler.SuspendProcess(GetProcessID("PlcStationClient"));
                        my_logger.Log("PLC process suspended!");

                        Timer2.Stop();

                        my_logger.Log("=========\r\nREPEATED ENGINE DETECTED: " + CurrentEngine + "\r\n" +
                            "Block linked: " + queryResultQualityData + "\r\n=========\r\n");

                        tb_Console.Text = "=========\r\nREPEATED ENGINE DETECTED: " + CurrentEngine + "\r\n" +
                            "Block linked: " + queryResultQualityData + "\r\n=========\r\n" + tb_Console.Text;

                        EngineDuplicate();
                    }

                }
                else tb_Console.Text = "=====\r\nResult: OK.\r\n=====" + tb_Console.Text;
                my_logger.Log("Result: OK.");

                reader.Close();
                command.Dispose();
                cnn.Close();
            }
            else
            {
                tb_Console.Text = "SQL: No recent EngineNumber available \r\n" + tb_Console.Text;
                my_logger.Log("SQL: No recent EngineNumber available");
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (startBtn)
            {
                if (tb_Console.Text == null)
                    pn_AtlasLogo.Show();

                btn_Start.BackColor = Color.Green;
                btn_Start.Text = "Start";
                startBtn = false;
                lb_Timer_Tick.BackColor = Color.LightSlateGray;
                pn_StopRunning.BackColor = Color.LightSlateGray;
                lb_Timer_Tick.Text = "Stopped";

                Timer2.Stop();
                my_logger.Log("EngineNumber-Checker Stopped!");
            }
            else
            {
                pn_AtlasLogo.Hide();

                Timer2_Tick(sender, e);

                btn_Start.BackColor = Color.Crimson;
                btn_Start.Text = "Stop";
                startBtn = true;
                lb_Timer_Tick.Text = "Running";

                Timer2.Start();
                my_logger.Log("EngineNumber-Checker Started!");
            }


        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Timer2.Interval = form2.getTimerTickMsValue;

            EngineValidate();

            if (lb_Timer_Tick.BackColor == Color.LightSlateGray)
            {
                lb_Timer_Tick.BackColor = Color.Gold;
                pn_StopRunning.BackColor = Color.Gold;
            }
            else
            {
                lb_Timer_Tick.BackColor = Color.LightSlateGray;
                pn_StopRunning.BackColor = Color.LightSlateGray;
            }
        }

        public void SaveParameters()
        {
            Timer2.Interval = form2.getTimerTickMsValue;
            engineLifeTime = form2.getEngineLifeTimeMsValueInt;
            tb_Console.Text = "\r\nPARAMETERS SAVED\r\n" + tb_Console.Text;
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
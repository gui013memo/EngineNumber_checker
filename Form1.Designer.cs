namespace EngineNumber_checker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_Start = new Button();
            Timer2 = new System.Windows.Forms.Timer(components);
            lb_Timer_Tick = new Label();
            pn_StopRunning = new Panel();
            btn_Options = new Button();
            tb_Console = new TextBox();
            pn_AtlasLogo = new Panel();
            pn_StopRunning.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.BackColor = Color.Green;
            btn_Start.Dock = DockStyle.Bottom;
            btn_Start.FlatStyle = FlatStyle.Flat;
            btn_Start.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Start.ForeColor = SystemColors.Control;
            btn_Start.Location = new Point(0, 248);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(556, 78);
            btn_Start.TabIndex = 1;
            btn_Start.Text = "Start ";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Click += btn_Start_Click;
            // 
            // Timer2
            // 
            Timer2.Interval = 1000;
            Timer2.Tick += Timer2_Tick;
            // 
            // lb_Timer_Tick
            // 
            lb_Timer_Tick.AutoSize = true;
            lb_Timer_Tick.BackColor = Color.LightSlateGray;
            lb_Timer_Tick.FlatStyle = FlatStyle.Popup;
            lb_Timer_Tick.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Timer_Tick.ForeColor = SystemColors.ButtonHighlight;
            lb_Timer_Tick.Location = new Point(221, 10);
            lb_Timer_Tick.Name = "lb_Timer_Tick";
            lb_Timer_Tick.Size = new Size(114, 35);
            lb_Timer_Tick.TabIndex = 3;
            lb_Timer_Tick.Text = "Stopped";
            // 
            // pn_StopRunning
            // 
            pn_StopRunning.BackColor = Color.LightSlateGray;
            pn_StopRunning.Controls.Add(btn_Options);
            pn_StopRunning.Controls.Add(lb_Timer_Tick);
            pn_StopRunning.Dock = DockStyle.Top;
            pn_StopRunning.Location = new Point(0, 0);
            pn_StopRunning.Name = "pn_StopRunning";
            pn_StopRunning.Size = new Size(556, 66);
            pn_StopRunning.TabIndex = 5;
            // 
            // btn_Options
            // 
            btn_Options.BackColor = Color.SlateGray;
            btn_Options.FlatAppearance.BorderSize = 0;
            btn_Options.FlatStyle = FlatStyle.Flat;
            btn_Options.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Options.ForeColor = Color.White;
            btn_Options.Location = new Point(452, 0);
            btn_Options.Name = "btn_Options";
            btn_Options.Size = new Size(104, 63);
            btn_Options.TabIndex = 7;
            btn_Options.Text = "Options";
            btn_Options.UseVisualStyleBackColor = false;
            btn_Options.Click += btn_Options_Click;
            // 
            // tb_Console
            // 
            tb_Console.BackColor = Color.White;
            tb_Console.Location = new Point(0, 62);
            tb_Console.Margin = new Padding(3, 4, 3, 4);
            tb_Console.Multiline = true;
            tb_Console.Name = "tb_Console";
            tb_Console.ReadOnly = true;
            tb_Console.ScrollBars = ScrollBars.Vertical;
            tb_Console.Size = new Size(563, 194);
            tb_Console.TabIndex = 0;
            // 
            // pn_AtlasLogo
            // 
            pn_AtlasLogo.BackgroundImage = Properties.Resources._4_bmp_mono_png6;
            pn_AtlasLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pn_AtlasLogo.Location = new Point(145, 92);
            pn_AtlasLogo.Name = "pn_AtlasLogo";
            pn_AtlasLogo.Size = new Size(267, 128);
            pn_AtlasLogo.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(556, 326);
            Controls.Add(pn_AtlasLogo);
            Controls.Add(tb_Console);
            Controls.Add(pn_StopRunning);
            Controls.Add(btn_Start);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "EngineNumber Checker";
            TopMost = true;
            pn_StopRunning.ResumeLayout(false);
            pn_StopRunning.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Timer_Tick;
        private Panel pn_StopRunning;
        private Panel pn_AtlasLogo;
        private Button btn_Options;
        public TextBox tb_Console;
        public System.Windows.Forms.Timer Timer2;
        public Button btn_Start;
    }
}
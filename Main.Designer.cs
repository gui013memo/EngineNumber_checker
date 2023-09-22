namespace EngineNumber_checker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Btn_Start = new Button();
            Timer2 = new System.Windows.Forms.Timer(components);
            lb_Timer_Tick = new Label();
            Pn_StopRunning = new Panel();
            Btn_Options = new Button();
            Pn_AtlasLogo = new Panel();
            Tb_Console = new TextBox();
            Pn_StopRunning.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Start
            // 
            Btn_Start.BackColor = Color.Green;
            Btn_Start.Dock = DockStyle.Bottom;
            Btn_Start.FlatStyle = FlatStyle.Flat;
            Btn_Start.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Start.ForeColor = SystemColors.Control;
            Btn_Start.Location = new Point(0, 248);
            Btn_Start.Name = "Btn_Start";
            Btn_Start.Size = new Size(587, 78);
            Btn_Start.TabIndex = 1;
            Btn_Start.Text = "Start ";
            Btn_Start.UseVisualStyleBackColor = false;
            Btn_Start.Click += Btn_Start_Click;
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
            lb_Timer_Tick.Location = new Point(230, 12);
            lb_Timer_Tick.Name = "lb_Timer_Tick";
            lb_Timer_Tick.Size = new Size(114, 35);
            lb_Timer_Tick.TabIndex = 3;
            lb_Timer_Tick.Text = "Stopped";
            // 
            // Pn_StopRunning
            // 
            Pn_StopRunning.BackColor = Color.LightSlateGray;
            Pn_StopRunning.Controls.Add(Btn_Options);
            Pn_StopRunning.Controls.Add(lb_Timer_Tick);
            Pn_StopRunning.Dock = DockStyle.Top;
            Pn_StopRunning.Location = new Point(0, 0);
            Pn_StopRunning.Name = "Pn_StopRunning";
            Pn_StopRunning.Size = new Size(587, 66);
            Pn_StopRunning.TabIndex = 5;
            // 
            // Btn_Options
            // 
            Btn_Options.BackColor = Color.SlateGray;
            Btn_Options.FlatAppearance.BorderSize = 0;
            Btn_Options.FlatStyle = FlatStyle.Flat;
            Btn_Options.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Options.ForeColor = Color.White;
            Btn_Options.Location = new Point(483, 0);
            Btn_Options.Name = "Btn_Options";
            Btn_Options.Size = new Size(104, 63);
            Btn_Options.TabIndex = 7;
            Btn_Options.Text = "Options";
            Btn_Options.UseVisualStyleBackColor = false;
            Btn_Options.Click += btn_Options_Click;
            // 
            // Pn_AtlasLogo
            // 
            Pn_AtlasLogo.BackgroundImage = Properties.Resources._4_bmp_mono_png6;
            Pn_AtlasLogo.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_AtlasLogo.Location = new Point(160, 90);
            Pn_AtlasLogo.Name = "Pn_AtlasLogo";
            Pn_AtlasLogo.Size = new Size(267, 128);
            Pn_AtlasLogo.TabIndex = 6;
            // 
            // Tb_Console
            // 
            Tb_Console.BackColor = Color.White;
            Tb_Console.Location = new Point(0, 62);
            Tb_Console.Margin = new Padding(3, 4, 3, 4);
            Tb_Console.Multiline = true;
            Tb_Console.Name = "Tb_Console";
            Tb_Console.ReadOnly = true;
            Tb_Console.ScrollBars = ScrollBars.Vertical;
            Tb_Console.Size = new Size(587, 194);
            Tb_Console.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(587, 326);
            Controls.Add(Pn_AtlasLogo);
            Controls.Add(Tb_Console);
            Controls.Add(Pn_StopRunning);
            Controls.Add(Btn_Start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            StartPosition = FormStartPosition.Manual;
            Text = "Atlas Copco - EngineNumber checker";
            Pn_StopRunning.ResumeLayout(false);
            Pn_StopRunning.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Timer_Tick;
        private Panel Pn_StopRunning;
        private Panel Pn_AtlasLogo;
        private Button Btn_Options;
        public System.Windows.Forms.Timer Timer2;
        public Button Btn_Start;
        public TextBox Tb_Console;
    }
}
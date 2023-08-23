namespace EngineNumber_checker
{
    partial class IntervalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_UpTimeTick = new Button();
            btn_DownTimerTick = new Button();
            btn_Save = new Button();
            btn_DownEngineLifeTime = new Button();
            btn_UpEngineLifeTime = new Button();
            tb_TimerTickValue = new TextBox();
            tb_EngineLifeTimeValue = new TextBox();
            tb_ConnectionString = new TextBox();
            label1 = new Label();
            lb_TimerTick = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_UpTimeTick
            // 
            btn_UpTimeTick.FlatAppearance.BorderSize = 0;
            btn_UpTimeTick.FlatStyle = FlatStyle.Flat;
            btn_UpTimeTick.Image = Properties.Resources.Arrow2_btn_up;
            btn_UpTimeTick.Location = new Point(0, 0);
            btn_UpTimeTick.Name = "btn_UpTimeTick";
            btn_UpTimeTick.Size = new Size(243, 101);
            btn_UpTimeTick.TabIndex = 1;
            btn_UpTimeTick.UseVisualStyleBackColor = true;
            btn_UpTimeTick.Click += btn_UpTimeTick_Click;
            // 
            // btn_DownTimerTick
            // 
            btn_DownTimerTick.FlatAppearance.BorderSize = 0;
            btn_DownTimerTick.FlatStyle = FlatStyle.Flat;
            btn_DownTimerTick.Image = Properties.Resources.Arrow2_btn_down;
            btn_DownTimerTick.Location = new Point(0, 161);
            btn_DownTimerTick.Name = "btn_DownTimerTick";
            btn_DownTimerTick.Size = new Size(250, 101);
            btn_DownTimerTick.TabIndex = 2;
            btn_DownTimerTick.UseVisualStyleBackColor = true;
            btn_DownTimerTick.Click += btn_DownTimerTick_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Green;
            btn_Save.Dock = DockStyle.Bottom;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(0, 388);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(562, 65);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "SAVE";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_DownEngineLifeTime
            // 
            btn_DownEngineLifeTime.FlatAppearance.BorderSize = 0;
            btn_DownEngineLifeTime.FlatStyle = FlatStyle.Flat;
            btn_DownEngineLifeTime.Image = Properties.Resources.Arrow2_btn_down;
            btn_DownEngineLifeTime.Location = new Point(300, 161);
            btn_DownEngineLifeTime.Name = "btn_DownEngineLifeTime";
            btn_DownEngineLifeTime.Size = new Size(250, 101);
            btn_DownEngineLifeTime.TabIndex = 6;
            btn_DownEngineLifeTime.UseVisualStyleBackColor = true;
            btn_DownEngineLifeTime.Click += btn_DownEngineLifeTime_Click;
            // 
            // btn_UpEngineLifeTime
            // 
            btn_UpEngineLifeTime.FlatAppearance.BorderSize = 0;
            btn_UpEngineLifeTime.FlatStyle = FlatStyle.Flat;
            btn_UpEngineLifeTime.Image = Properties.Resources.Arrow2_btn_up;
            btn_UpEngineLifeTime.Location = new Point(300, 0);
            btn_UpEngineLifeTime.Name = "btn_UpEngineLifeTime";
            btn_UpEngineLifeTime.Size = new Size(243, 101);
            btn_UpEngineLifeTime.TabIndex = 5;
            btn_UpEngineLifeTime.UseVisualStyleBackColor = true;
            btn_UpEngineLifeTime.Click += btn_UpEngineLifeTime_Click;
            // 
            // tb_TimerTickValue
            // 
            tb_TimerTickValue.BackColor = Color.White;
            tb_TimerTickValue.BorderStyle = BorderStyle.None;
            tb_TimerTickValue.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tb_TimerTickValue.Location = new Point(12, 132);
            tb_TimerTickValue.Name = "tb_TimerTickValue";
            tb_TimerTickValue.ReadOnly = true;
            tb_TimerTickValue.Size = new Size(223, 36);
            tb_TimerTickValue.TabIndex = 7;
            tb_TimerTickValue.Text = "1000 ms";
            tb_TimerTickValue.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_EngineLifeTimeValue
            // 
            tb_EngineLifeTimeValue.BackColor = Color.White;
            tb_EngineLifeTimeValue.BorderStyle = BorderStyle.None;
            tb_EngineLifeTimeValue.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tb_EngineLifeTimeValue.Location = new Point(295, 132);
            tb_EngineLifeTimeValue.Name = "tb_EngineLifeTimeValue";
            tb_EngineLifeTimeValue.ReadOnly = true;
            tb_EngineLifeTimeValue.Size = new Size(255, 36);
            tb_EngineLifeTimeValue.TabIndex = 8;
            tb_EngineLifeTimeValue.Text = "3 sec";
            tb_EngineLifeTimeValue.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_ConnectionString
            // 
            tb_ConnectionString.BackColor = SystemColors.InactiveCaption;
            tb_ConnectionString.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ConnectionString.Location = new Point(143, 318);
            tb_ConnectionString.Name = "tb_ConnectionString";
            tb_ConnectionString.Size = new Size(272, 56);
            tb_ConnectionString.TabIndex = 10;
            tb_ConnectionString.Text = "172.16.0.1";
            tb_ConnectionString.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 274);
            label1.Name = "label1";
            label1.Size = new Size(272, 41);
            label1.TabIndex = 11;
            label1.Text = "Connection String";
            // 
            // lb_TimerTick
            // 
            lb_TimerTick.AutoSize = true;
            lb_TimerTick.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TimerTick.Location = new Point(49, 92);
            lb_TimerTick.Name = "lb_TimerTick";
            lb_TimerTick.Size = new Size(151, 37);
            lb_TimerTick.TabIndex = 12;
            lb_TimerTick.Text = "Timer Tick";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(320, 92);
            label2.Name = "label2";
            label2.Size = new Size(216, 37);
            label2.TabIndex = 13;
            label2.Text = "Engine Lifetime";
            // 
            // IntervalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(562, 453);
            Controls.Add(label2);
            Controls.Add(lb_TimerTick);
            Controls.Add(label1);
            Controls.Add(tb_ConnectionString);
            Controls.Add(tb_EngineLifeTimeValue);
            Controls.Add(tb_TimerTickValue);
            Controls.Add(btn_DownEngineLifeTime);
            Controls.Add(btn_UpEngineLifeTime);
            Controls.Add(btn_Save);
            Controls.Add(btn_DownTimerTick);
            Controls.Add(btn_UpTimeTick);
            Name = "IntervalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interval";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_UpTimeTick;
        private Button btn_DownTimerTick;
        private Button btn_Save;
        private Button btn_DownEngineLifeTime;
        private Button btn_UpEngineLifeTime;
        private TextBox tb_TimerTickValue;
        private TextBox tb_EngineLifeTimeValue;
        private TextBox tb_ConnectionString;
        private Label label1;
        private Label lb_TimerTick;
        private Label label2;
    }
}
namespace EngineNumber_checker
{
    partial class Blinking_form
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
            btn_StopAfterTrigger = new Button();
            btn_ContinueAfterTrigger = new Button();
            lb_EngineRepeated = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_StopAfterTrigger
            // 
            btn_StopAfterTrigger.BackColor = Color.Red;
            btn_StopAfterTrigger.FlatStyle = FlatStyle.Flat;
            btn_StopAfterTrigger.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn_StopAfterTrigger.ForeColor = Color.White;
            btn_StopAfterTrigger.Location = new Point(-4, 817);
            btn_StopAfterTrigger.Name = "btn_StopAfterTrigger";
            btn_StopAfterTrigger.Size = new Size(960, 227);
            btn_StopAfterTrigger.TabIndex = 0;
            btn_StopAfterTrigger.Text = "STOP";
            btn_StopAfterTrigger.UseVisualStyleBackColor = false;
            // 
            // btn_ContinueAfterTrigger
            // 
            btn_ContinueAfterTrigger.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ContinueAfterTrigger.BackColor = Color.Green;
            btn_ContinueAfterTrigger.FlatStyle = FlatStyle.Flat;
            btn_ContinueAfterTrigger.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ContinueAfterTrigger.ForeColor = Color.White;
            btn_ContinueAfterTrigger.Location = new Point(949, 817);
            btn_ContinueAfterTrigger.Name = "btn_ContinueAfterTrigger";
            btn_ContinueAfterTrigger.Size = new Size(980, 227);
            btn_ContinueAfterTrigger.TabIndex = 1;
            btn_ContinueAfterTrigger.Text = "CONTINUE";
            btn_ContinueAfterTrigger.UseVisualStyleBackColor = false;
            // 
            // lb_EngineRepeated
            // 
            lb_EngineRepeated.Anchor = AnchorStyles.Top;
            lb_EngineRepeated.AutoSize = true;
            lb_EngineRepeated.Font = new Font("Calibri", 68F, FontStyle.Bold, GraphicsUnit.Point);
            lb_EngineRepeated.Location = new Point(506, -11);
            lb_EngineRepeated.Name = "lb_EngineRepeated";
            lb_EngineRepeated.Size = new Size(961, 140);
            lb_EngineRepeated.TabIndex = 2;
            lb_EngineRepeated.Text = "ENGINE REPEATED:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 68F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(762, 103);
            label1.Name = "label1";
            label1.Size = new Size(407, 140);
            label1.TabIndex = 3;
            label1.Text = "070123";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 68F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(357, 225);
            label2.Name = "label2";
            label2.Size = new Size(1227, 140);
            label2.TabIndex = 4;
            label2.Text = "BLOCK ALREADY LINKED:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(549, 342);
            label3.Name = "label3";
            label3.Size = new Size(845, 133);
            label3.TabIndex = 5;
            label3.Text = "B1B1DB2209211";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Calibri", 64F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(320, 459);
            label4.Name = "label4";
            label4.Size = new Size(1285, 131);
            label4.TabIndex = 6;
            label4.Text = "(19/06/2023 - 11:23:00 PM)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Calibri", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(153, 668);
            label5.Name = "label5";
            label5.Size = new Size(1580, 146);
            label5.TabIndex = 7;
            label5.Text = "DO YOU WANT TO CONTINUE?";
            // 
            // Blinking_form
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Yellow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(lb_EngineRepeated);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ContinueAfterTrigger);
            Controls.Add(btn_StopAfterTrigger);
            Name = "Blinking_form";
            Text = "/deny";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_StopAfterTrigger;
        private Button btn_ContinueAfterTrigger;
        private Label lb_EngineRepeated;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
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
            lb_RepeatedEngNumValue = new Label();
            lb_BlockAlreadyLinked = new Label();
            lb_BlockLinkedValue = new Label();
            lb_BlockLinkedDate = new Label();
            lb_DoYouWantToContinue = new Label();
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
            btn_StopAfterTrigger.Click += btn_StopAfterTrigger_Click;
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
            btn_ContinueAfterTrigger.Click += btn_ContinueAfterTrigger_Click;
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
            // lb_RepeatedEngNumValue
            // 
            lb_RepeatedEngNumValue.AutoSize = true;
            lb_RepeatedEngNumValue.BackColor = Color.White;
            lb_RepeatedEngNumValue.Font = new Font("Calibri", 68F, FontStyle.Bold, GraphicsUnit.Point);
            lb_RepeatedEngNumValue.ForeColor = Color.Black;
            lb_RepeatedEngNumValue.Location = new Point(762, 103);
            lb_RepeatedEngNumValue.Name = "lb_RepeatedEngNumValue";
            lb_RepeatedEngNumValue.Size = new Size(407, 140);
            lb_RepeatedEngNumValue.TabIndex = 3;
            lb_RepeatedEngNumValue.Text = "070123";
            // 
            // lb_BlockAlreadyLinked
            // 
            lb_BlockAlreadyLinked.AutoSize = true;
            lb_BlockAlreadyLinked.Font = new Font("Calibri", 68F, FontStyle.Bold, GraphicsUnit.Point);
            lb_BlockAlreadyLinked.Location = new Point(357, 225);
            lb_BlockAlreadyLinked.Name = "lb_BlockAlreadyLinked";
            lb_BlockAlreadyLinked.Size = new Size(1227, 140);
            lb_BlockAlreadyLinked.TabIndex = 4;
            lb_BlockAlreadyLinked.Text = "BLOCK ALREADY LINKED:";
            // 
            // lb_BlockLinkedValue
            // 
            lb_BlockLinkedValue.AutoSize = true;
            lb_BlockLinkedValue.BackColor = Color.White;
            lb_BlockLinkedValue.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point);
            lb_BlockLinkedValue.ForeColor = Color.Black;
            lb_BlockLinkedValue.Location = new Point(549, 342);
            lb_BlockLinkedValue.Name = "lb_BlockLinkedValue";
            lb_BlockLinkedValue.Size = new Size(845, 133);
            lb_BlockLinkedValue.TabIndex = 5;
            lb_BlockLinkedValue.Text = "B1B1DB2209211";
            // 
            // lb_BlockLinkedDate
            // 
            lb_BlockLinkedDate.AutoSize = true;
            lb_BlockLinkedDate.BackColor = Color.White;
            lb_BlockLinkedDate.Font = new Font("Calibri", 64F, FontStyle.Bold, GraphicsUnit.Point);
            lb_BlockLinkedDate.ForeColor = Color.Black;
            lb_BlockLinkedDate.Location = new Point(413, 486);
            lb_BlockLinkedDate.Name = "lb_BlockLinkedDate";
            lb_BlockLinkedDate.Size = new Size(1110, 131);
            lb_BlockLinkedDate.TabIndex = 6;
            lb_BlockLinkedDate.Text = "(19/06/2023 - 11:23:00)";
            // 
            // lb_DoYouWantToContinue
            // 
            lb_DoYouWantToContinue.AutoSize = true;
            lb_DoYouWantToContinue.BackColor = Color.Blue;
            lb_DoYouWantToContinue.Font = new Font("Calibri", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lb_DoYouWantToContinue.ForeColor = Color.White;
            lb_DoYouWantToContinue.Location = new Point(153, 668);
            lb_DoYouWantToContinue.Name = "lb_DoYouWantToContinue";
            lb_DoYouWantToContinue.Size = new Size(1580, 146);
            lb_DoYouWantToContinue.TabIndex = 7;
            lb_DoYouWantToContinue.Text = "DO YOU WANT TO CONTINUE?";
            // 
            // Blinking_form
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Yellow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(lb_EngineRepeated);
            Controls.Add(lb_DoYouWantToContinue);
            Controls.Add(lb_BlockLinkedDate);
            Controls.Add(lb_BlockLinkedValue);
            Controls.Add(lb_BlockAlreadyLinked);
            Controls.Add(lb_RepeatedEngNumValue);
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
        private Label lb_RepeatedEngNumValue;
        private Label lb_BlockAlreadyLinked;
        private Label lb_BlockLinkedValue;
        private Label lb_BlockLinkedDate;
        private Label lb_DoYouWantToContinue;
    }
}
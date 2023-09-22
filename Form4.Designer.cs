namespace EngineNumber_checker
{
    partial class Form4
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
            lb_EngineRepeated = new Label();
            label1 = new Label();
            btn_Save = new Button();
            SuspendLayout();
            // 
            // lb_EngineRepeated
            // 
            lb_EngineRepeated.Anchor = AnchorStyles.Top;
            lb_EngineRepeated.AutoSize = true;
            lb_EngineRepeated.Font = new Font("Calibri", 68F, FontStyle.Bold, GraphicsUnit.Point);
            lb_EngineRepeated.Location = new Point(764, -3);
            lb_EngineRepeated.Name = "lb_EngineRepeated";
            lb_EngineRepeated.Size = new Size(367, 140);
            lb_EngineRepeated.TabIndex = 3;
            lb_EngineRepeated.Text = "CHECK";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 68F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 112);
            label1.Name = "label1";
            label1.Size = new Size(1532, 140);
            label1.TabIndex = 4;
            label1.Text = "the PLC_Station_Client adapter";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Green;
            btn_Save.Dock = DockStyle.Bottom;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(0, 850);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(1902, 183);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "OK";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Sem_título;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btn_Save);
            Controls.Add(label1);
            Controls.Add(lb_EngineRepeated);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_EngineRepeated;
        private Label label1;
        private Button btn_Save;
    }
}
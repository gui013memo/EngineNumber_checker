namespace EngineNumber_checker
{
    partial class CheckAdapter
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
            btn_OK = new Button();
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
            // btn_OK
            // 
            btn_OK.BackColor = Color.Green;
            btn_OK.Dock = DockStyle.Bottom;
            btn_OK.FlatStyle = FlatStyle.Flat;
            btn_OK.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OK.ForeColor = Color.White;
            btn_OK.Location = new Point(0, 850);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(1902, 183);
            btn_OK.TabIndex = 5;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = false;
            btn_OK.Click += btn_OK_Click;
            // 
            // CheckAdapter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CheckAdapter;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btn_OK);
            Controls.Add(label1);
            Controls.Add(lb_EngineRepeated);
            Name = "CheckAdapter";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_EngineRepeated;
        private Label label1;
        private Button btn_OK;
    }
}
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
            SuspendLayout();
            // 
            // lb_EngineRepeated
            // 
            lb_EngineRepeated.Anchor = AnchorStyles.Top;
            lb_EngineRepeated.AutoSize = true;
            lb_EngineRepeated.Font = new Font("Calibri", 68F, FontStyle.Bold, GraphicsUnit.Point);
            lb_EngineRepeated.Location = new Point(251, 170);
            lb_EngineRepeated.Name = "lb_EngineRepeated";
            lb_EngineRepeated.Size = new Size(961, 140);
            lb_EngineRepeated.TabIndex = 3;
            lb_EngineRepeated.Text = "ENGINE REPEATED:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(lb_EngineRepeated);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_EngineRepeated;
    }
}
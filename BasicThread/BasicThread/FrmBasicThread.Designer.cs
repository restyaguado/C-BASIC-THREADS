namespace BasicThread
{
    partial class FrmBasicThread
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBasicThread));
            lblStatus = new Label();
            btnRun = new Button();
            lstOutput = new ListBox();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.FloralWhite;
            lblStatus.Font = new Font("Segoe UI", 15F);
            lblStatus.Location = new Point(44, 65);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(218, 28);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "-Before starting thread-";
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 15F);
            btnRun.ForeColor = SystemColors.Highlight;
            btnRun.Location = new Point(107, 124);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(83, 54);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(12, 195);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(275, 259);
            lstOutput.TabIndex = 2;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.grabient_kW5w4_aAu_NcRvzgjcB7ghAQ;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(299, 470);
            Controls.Add(lstOutput);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBasicThread";
            Text = "BasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
        private ListBox lstOutput;
    }
}
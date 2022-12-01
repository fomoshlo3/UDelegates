namespace UDelegates
{
    partial class MainForm
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
            this.CmdOpenChildForm = new System.Windows.Forms.Button();
            this.LblCountTimesSec = new System.Windows.Forms.Label();
            this.TbSpan = new System.Windows.Forms.TextBox();
            this.LblSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdOpenChildForm
            // 
            this.CmdOpenChildForm.Location = new System.Drawing.Point(16, 22);
            this.CmdOpenChildForm.Name = "CmdOpenChildForm";
            this.CmdOpenChildForm.Size = new System.Drawing.Size(75, 23);
            this.CmdOpenChildForm.TabIndex = 0;
            this.CmdOpenChildForm.Text = "Open";
            this.CmdOpenChildForm.UseVisualStyleBackColor = true;
            this.CmdOpenChildForm.Click += new System.EventHandler(this.CmdOpenChildForm_Click);
            // 
            // LblCountTimesSec
            // 
            this.LblCountTimesSec.AutoSize = true;
            this.LblCountTimesSec.Location = new System.Drawing.Point(12, 89);
            this.LblCountTimesSec.Name = "LblCountTimesSec";
            this.LblCountTimesSec.Size = new System.Drawing.Size(51, 15);
            this.LblCountTimesSec.TabIndex = 1;
            this.LblCountTimesSec.Text = "0 x 1 sec";
            // 
            // TbSpan
            // 
            this.TbSpan.Location = new System.Drawing.Point(12, 63);
            this.TbSpan.Name = "TbSpan";
            this.TbSpan.Size = new System.Drawing.Size(100, 23);
            this.TbSpan.TabIndex = 2;
            // 
            // LblSeconds
            // 
            this.LblSeconds.AutoSize = true;
            this.LblSeconds.Location = new System.Drawing.Point(12, 113);
            this.LblSeconds.Name = "LblSeconds";
            this.LblSeconds.Size = new System.Drawing.Size(62, 15);
            this.LblSeconds.TabIndex = 3;
            this.LblSeconds.Text = "0 seconds.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 306);
            this.Controls.Add(this.LblSeconds);
            this.Controls.Add(this.TbSpan);
            this.Controls.Add(this.LblCountTimesSec);
            this.Controls.Add(this.CmdOpenChildForm);
            this.Name = "MainForm";
            this.Text = " MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdOpenChildForm;
        private Label LblCountTimesSec;
        private TextBox TbSpan;
        private Label LblSeconds;
    }
}
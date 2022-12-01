namespace UDelegates
{
    partial class ChildForm
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
            this.CmdCloseChildForm = new System.Windows.Forms.Button();
            this.LblCounterSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdCloseChildForm
            // 
            this.CmdCloseChildForm.Location = new System.Drawing.Point(395, 281);
            this.CmdCloseChildForm.Name = "CmdCloseChildForm";
            this.CmdCloseChildForm.Size = new System.Drawing.Size(75, 23);
            this.CmdCloseChildForm.TabIndex = 0;
            this.CmdCloseChildForm.Text = "Close";
            this.CmdCloseChildForm.UseVisualStyleBackColor = true;
            this.CmdCloseChildForm.Click += new System.EventHandler(this.CmdCloseChildForm_Click);
            // 
            // LblCounterSec
            // 
            this.LblCounterSec.AutoSize = true;
            this.LblCounterSec.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCounterSec.Location = new System.Drawing.Point(12, 9);
            this.LblCounterSec.Name = "LblCounterSec";
            this.LblCounterSec.Size = new System.Drawing.Size(68, 32);
            this.LblCounterSec.TabIndex = 1;
            this.LblCounterSec.Text = "0 sec";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 316);
            this.Controls.Add(this.LblCounterSec);
            this.Controls.Add(this.CmdCloseChildForm);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdCloseChildForm;
        private Label LblCounterSec;
    }
}
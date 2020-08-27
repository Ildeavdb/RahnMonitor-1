namespace RahnMonitor
{
    partial class rahnMatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rahnMatchForm));
            this.copyRightLabel2 = new System.Windows.Forms.Label();
            this.viewMoreInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.viewMoreInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // copyRightLabel2
            // 
            this.copyRightLabel2.AutoSize = true;
            this.copyRightLabel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.copyRightLabel2.Location = new System.Drawing.Point(377, 661);
            this.copyRightLabel2.Name = "copyRightLabel2";
            this.copyRightLabel2.Size = new System.Drawing.Size(231, 19);
            this.copyRightLabel2.TabIndex = 14;
            this.copyRightLabel2.Text = "© 2020 Rahn Consolidated (PTY) ltd";
            // 
            // viewMoreInfoTextBox
            // 
            this.viewMoreInfoTextBox.BackColor = System.Drawing.Color.White;
            this.viewMoreInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewMoreInfoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewMoreInfoTextBox.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMoreInfoTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.viewMoreInfoTextBox.Location = new System.Drawing.Point(45, 68);
            this.viewMoreInfoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewMoreInfoTextBox.Name = "viewMoreInfoTextBox";
            this.viewMoreInfoTextBox.ReadOnly = true;
            this.viewMoreInfoTextBox.Size = new System.Drawing.Size(908, 564);
            this.viewMoreInfoTextBox.TabIndex = 15;
            this.viewMoreInfoTextBox.Text = "";
            // 
            // viewMoreInfoLabel
            // 
            this.viewMoreInfoLabel.AutoSize = true;
            this.viewMoreInfoLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMoreInfoLabel.ForeColor = System.Drawing.Color.Maroon;
            this.viewMoreInfoLabel.Location = new System.Drawing.Point(32, 15);
            this.viewMoreInfoLabel.Name = "viewMoreInfoLabel";
            this.viewMoreInfoLabel.Size = new System.Drawing.Size(257, 38);
            this.viewMoreInfoLabel.TabIndex = 16;
            this.viewMoreInfoLabel.Text = "More Information : ";
            // 
            // rahnMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 688);
            this.Controls.Add(this.viewMoreInfoLabel);
            this.Controls.Add(this.viewMoreInfoTextBox);
            this.Controls.Add(this.copyRightLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "rahnMatchForm";
            this.Text = "Rahn Match";
            this.Deactivate += new System.EventHandler(this.rahnMatchForm_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label copyRightLabel2;
        public System.Windows.Forms.RichTextBox viewMoreInfoTextBox;
        private System.Windows.Forms.Label viewMoreInfoLabel;
    }
}
namespace formulaInfo
{
    partial class calendar
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.textBoxCalendar = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DimGray;
            this.mainPanel.Controls.Add(this.textBoxCalendar);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // textBoxCalendar
            // 
            this.textBoxCalendar.BackColor = System.Drawing.Color.DimGray;
            this.textBoxCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCalendar.Location = new System.Drawing.Point(0, 0);
            this.textBoxCalendar.Multiline = true;
            this.textBoxCalendar.Name = "textBoxCalendar";
            this.textBoxCalendar.ReadOnly = true;
            this.textBoxCalendar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCalendar.Size = new System.Drawing.Size(800, 450);
            this.textBoxCalendar.TabIndex = 0;
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "calendar";
            this.Text = "calendar";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox textBoxCalendar;
    }
}
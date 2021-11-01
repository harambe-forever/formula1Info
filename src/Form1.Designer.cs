namespace FormulaAddict
{
    partial class Form1
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.Button();
            this.drivers = new System.Windows.Forms.Button();
            this.teams = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.infoCenter = new System.Windows.Forms.TextBox();
            this.calendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitBtn.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(1134, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(66, 66);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // web
            // 
            this.web.BackgroundImage = global::FormulaAddict.Properties.Resources.f1logo;
            this.web.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.web.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(200, 100);
            this.web.TabIndex = 3;
            this.web.Text = "Web";
            this.web.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.web.UseVisualStyleBackColor = true;
            this.web.Click += new System.EventHandler(this.web_Click);
            // 
            // drivers
            // 
            this.drivers.BackColor = System.Drawing.Color.Transparent;
            this.drivers.BackgroundImage = global::FormulaAddict.Properties.Resources.vettel;
            this.drivers.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.drivers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.drivers.Location = new System.Drawing.Point(200, 100);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(150, 100);
            this.drivers.TabIndex = 9;
            this.drivers.Text = "Drivers";
            this.drivers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drivers.UseVisualStyleBackColor = false;
            this.drivers.Click += new System.EventHandler(this.drivers_Click);
            // 
            // teams
            // 
            this.teams.BackColor = System.Drawing.Color.Transparent;
            this.teams.BackgroundImage = global::FormulaAddict.Properties.Resources.redbull;
            this.teams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.teams.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.teams.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.teams.Location = new System.Drawing.Point(350, 200);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(150, 100);
            this.teams.TabIndex = 10;
            this.teams.Text = "Teams";
            this.teams.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.teams.UseVisualStyleBackColor = false;
            this.teams.Click += new System.EventHandler(this.teams_Click);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.history.ForeColor = System.Drawing.Color.Cornsilk;
            this.history.Image = global::FormulaAddict.Properties.Resources.michi;
            this.history.Location = new System.Drawing.Point(350, 300);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(150, 100);
            this.history.TabIndex = 11;
            this.history.Text = "Previous Champions";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // infoCenter
            // 
            this.infoCenter.BackColor = System.Drawing.Color.Cornsilk;
            this.infoCenter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoCenter.Location = new System.Drawing.Point(506, 0);
            this.infoCenter.Multiline = true;
            this.infoCenter.Name = "infoCenter";
            this.infoCenter.ReadOnly = true;
            this.infoCenter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoCenter.Size = new System.Drawing.Size(622, 800);
            this.infoCenter.TabIndex = 13;
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.Transparent;
            this.calendar.BackgroundImage = global::FormulaAddict.Properties.Resources.form3Bg;
            this.calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.calendar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.calendar.Location = new System.Drawing.Point(200, 400);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(150, 100);
            this.calendar.TabIndex = 14;
            this.calendar.Text = "Calendar";
            this.calendar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calendar.UseVisualStyleBackColor = false;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormulaAddict.Properties.Resources.angryimg;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.infoCenter);
            this.Controls.Add(this.history);
            this.Controls.Add(this.teams);
            this.Controls.Add(this.drivers);
            this.Controls.Add(this.web);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Formula Addict";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button web;
        private System.Windows.Forms.Button drivers;
        private System.Windows.Forms.Button teams;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.TextBox infoCenter;
        private System.Windows.Forms.Button calendar;
    }
}

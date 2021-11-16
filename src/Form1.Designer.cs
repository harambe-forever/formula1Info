namespace formulaInfo
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.calendarButton = new System.Windows.Forms.Button();
            this.standingsButton = new System.Windows.Forms.Button();
            this.teamsButton = new System.Windows.Forms.Button();
            this.driversButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.webButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.homeButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Controls.Add(this.calendarButton);
            this.menuPanel.Controls.Add(this.standingsButton);
            this.menuPanel.Controls.Add(this.teamsButton);
            this.menuPanel.Controls.Add(this.driversButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(150, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // calendarButton
            // 
            this.calendarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarButton.FlatAppearance.BorderSize = 0;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendarButton.Location = new System.Drawing.Point(0, 300);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(150, 75);
            this.calendarButton.TabIndex = 4;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calendarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calendarButton.UseVisualStyleBackColor = true;
            // 
            // standingsButton
            // 
            this.standingsButton.BackgroundImage = global::formulaInfo.Properties.Resources.michi;
            this.standingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.standingsButton.FlatAppearance.BorderSize = 0;
            this.standingsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standingsButton.ForeColor = System.Drawing.Color.Transparent;
            this.standingsButton.Location = new System.Drawing.Point(0, 225);
            this.standingsButton.Name = "standingsButton";
            this.standingsButton.Size = new System.Drawing.Size(150, 75);
            this.standingsButton.TabIndex = 3;
            this.standingsButton.Text = "Standings";
            this.standingsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.standingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.standingsButton.UseVisualStyleBackColor = true;
            this.standingsButton.Click += new System.EventHandler(this.standingsButton_Click);
            // 
            // teamsButton
            // 
            this.teamsButton.BackgroundImage = global::formulaInfo.Properties.Resources.redbull;
            this.teamsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamsButton.FlatAppearance.BorderSize = 0;
            this.teamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teamsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teamsButton.Location = new System.Drawing.Point(0, 150);
            this.teamsButton.Name = "teamsButton";
            this.teamsButton.Size = new System.Drawing.Size(150, 75);
            this.teamsButton.TabIndex = 2;
            this.teamsButton.Text = "Teams";
            this.teamsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.teamsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.teamsButton.UseVisualStyleBackColor = true;
            this.teamsButton.Click += new System.EventHandler(this.teamsButton_Click);
            // 
            // driversButton
            // 
            this.driversButton.BackgroundImage = global::formulaInfo.Properties.Resources.vettel;
            this.driversButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.driversButton.FlatAppearance.BorderSize = 0;
            this.driversButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.driversButton.Location = new System.Drawing.Point(0, 75);
            this.driversButton.Name = "driversButton";
            this.driversButton.Size = new System.Drawing.Size(150, 75);
            this.driversButton.TabIndex = 1;
            this.driversButton.Text = "Drivers";
            this.driversButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.driversButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.driversButton.UseVisualStyleBackColor = true;
            this.driversButton.Click += new System.EventHandler(this.driversButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = global::formulaInfo.Properties.Resources.angryimg;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPanel.Controls.Add(this.webButton);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(150, 75);
            this.logoPanel.TabIndex = 0;
            // 
            // webButton
            // 
            this.webButton.BackColor = System.Drawing.Color.Transparent;
            this.webButton.BackgroundImage = global::formulaInfo.Properties.Resources.f1logo;
            this.webButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.webButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webButton.FlatAppearance.BorderSize = 0;
            this.webButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.webButton.Location = new System.Drawing.Point(0, 0);
            this.webButton.Name = "webButton";
            this.webButton.Size = new System.Drawing.Size(150, 75);
            this.webButton.TabIndex = 0;
            this.webButton.UseVisualStyleBackColor = false;
            this.webButton.Click += new System.EventHandler(this.webButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::formulaInfo.Properties.Resources.angryimg;
            this.mainPanel.Controls.Add(this.labelTime);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(150, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(650, 450);
            this.mainPanel.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(82, 100);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(480, 200);
            this.labelTime.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.Location = new System.Drawing.Point(0, 375);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(150, 50);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "Main";
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button webButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button driversButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button standingsButton;
        private System.Windows.Forms.Button teamsButton;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1_Tick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button homeButton;
    }
}


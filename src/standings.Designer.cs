namespace formulaInfo
{
    partial class standings
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
            this.datePanel = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.header = new System.Windows.Forms.TextBox();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePanel
            // 
            this.datePanel.Controls.Add(this.listBox);
            this.datePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.datePanel.Location = new System.Drawing.Point(695, 0);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(105, 450);
            this.datePanel.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950"});
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(105, 450);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DimGray;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header.ForeColor = System.Drawing.SystemColors.Info;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Multiline = true;
            this.header.Name = "header";
            this.header.ReadOnly = true;
            this.header.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.header.Size = new System.Drawing.Size(695, 450);
            this.header.TabIndex = 1;
            // 
            // standings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulaInfo.Properties.Resources.angryimg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.header);
            this.Controls.Add(this.datePanel);
            this.Name = "standings";
            this.Text = "standings";
            this.datePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox header;
    }
}
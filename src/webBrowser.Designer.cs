namespace formulaInfo
{
    partial class webBrowser
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
            this.webBrowserr = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserr
            // 
            this.webBrowserr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserr.Location = new System.Drawing.Point(0, 0);
            this.webBrowserr.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserr.Name = "webBrowserr";
            this.webBrowserr.Size = new System.Drawing.Size(800, 450);
            this.webBrowserr.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserr);
            this.Name = "webBrowser";
            this.Text = "webBrowserGecko";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserr;
    }
}
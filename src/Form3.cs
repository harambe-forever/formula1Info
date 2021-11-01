using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormulaAddict
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exitForm3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void getTeamData(String link)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(link);
            string newLine = Environment.NewLine;
            foreach (var item in doc.DocumentNode.SelectNodes("//span[@class='text']"))
            {
                keys.AppendText(item.InnerText + newLine);
            }
            foreach (var item in doc.DocumentNode.SelectNodes("//td[@class='stat-value']"))
            {
                values.AppendText(item.InnerText + newLine);
            }
        }
        private void alfaRomeo_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/Alfa-Romeo-Racing.html");
        }

        private void tauri_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/AlphaTauri.html");
        }

        private void alpine_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/Alpine.html");
        }

        private void aston_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/Aston-Martin.html");
        }

        private void sf_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/Ferrari.html");
        }

        private void haas_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/Haas-F1-Team.html");
        }

        private void mclaren_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/McLaren.html");
        }

        private void mercedes_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/Mercedes.html");
        }

        private void rb_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/Red-Bull-Racing.html");
        }

        private void williams_Click(object sender, EventArgs e)
        {
            getTeamData("https://www.formula1.com/en/teams/Williams.html");
        }
    }
}

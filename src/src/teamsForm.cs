using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulaInfo
{
    public partial class teamsForm : Form
    {
        public teamsForm()
        {
            InitializeComponent();
        }
        private void getTeamData(String link)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(link);
            string newLine = Environment.NewLine;
            foreach (var item in doc.DocumentNode.SelectNodes("//span[@class='text']"))
            {
                keysTextBox.AppendText(item.InnerText + newLine);
            }
            foreach (var item in doc.DocumentNode.SelectNodes("//td[@class='stat-value']"))
            {
                valuesTextBox.AppendText(item.InnerText + newLine);
            }
        }

        private void alfaRomeo_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.alfaRomeo;
            getTeamData("https://www.formula1.com/en/teams/Alfa-Romeo-Racing.html");
        }

        private void alphaTauri_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.tauri;
            getTeamData("https://www.formula1.com/en/teams/AlphaTauri.html");
        }

        private void alpine_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.alpine;
            getTeamData("https://www.formula1.com/en/teams/Alpine.html");
        }

        private void astonMartin_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.aston;
            getTeamData("https://www.formula1.com/en/teams/Aston-Martin.html");
        }

        private void ferrari_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.ferrari;
            getTeamData("https://www.formula1.com/en/teams/Ferrari.html");
        }

        private void haas_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.haas;
            getTeamData("https://www.formula1.com/en/teams/Haas-F1-Team.html");
        }

        private void mclaren_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.mclaren;
            getTeamData("https://www.formula1.com/en/teams/McLaren.html");
        }

        private void mercedes_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.merc;
            getTeamData("https://www.formula1.com/en/teams/Mercedes.html");
        }

        private void redBull_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.redbull;
            getTeamData("https://www.formula1.com/en/teams/Red-Bull-Racing.html");
        }

        private void williams_Click(object sender, EventArgs e)
        {
            carPictureBox.Image = formulaInfo.Properties.Resources.williams;
            getTeamData("https://www.formula1.com/en/teams/Williams.html");
        }
    }
}

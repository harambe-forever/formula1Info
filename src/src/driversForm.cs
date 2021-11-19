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
    public partial class driversForm : Form
    {
        public driversForm()
        {
            InitializeComponent();
        }

        private void getData(String link)
        {
            keysTextBox.Clear();
            valuesTextBox.Clear();
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

        private void maxBtn_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.max;
            getData("https://www.formula1.com/en/drivers/max-verstappen.html");
        }

        private void perezBtn_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.perez;
            getData("https://www.formula1.com/en/drivers/sergio-perez.html");
        }

        private void riccButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.ricc;
            getData("https://www.formula1.com/en/drivers/daniel-ricciardo.html");
        }

        private void landoButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.lando;
            getData("https://www.formula1.com/en/drivers/lando-norris.html");
        }

        private void sebButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.seb;
            getData("https://www.formula1.com/en/drivers/sebastian-vettel.html");
        }

        private void strollButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.lance;
            getData("https://www.formula1.com/en/drivers/lance-stroll.html");
        }

        private void alonsoButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.alonso;
            getData("https://www.formula1.com/en/drivers/fernando-alonso.html");
        }

        private void oconButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.ocon;
            getData("https://www.formula1.com/en/drivers/esteban-ocon.html");
        }

        private void kimiButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.kimi;
            getData("https://www.formula1.com/en/drivers/kimi-raikkonen.html");
        }

        private void gioButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.gio;
            getData("https://www.formula1.com/en/drivers/antonio-giovinazzi.html");
        }

        private void charlesButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.stupid;
            getData("https://www.formula1.com/en/drivers/charles-leclerc.html");
        }

        private void sainzButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.sainz;
            getData("https://www.formula1.com/en/drivers/carlos-sainz.html");
        }

        private void gaslyButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.pierre;
            getData("https://www.formula1.com/en/drivers/pierre-gasly.html");
        }

        private void yukiButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.yuki;
            getData("https://www.formula1.com/en/drivers/yuki-tsunoda.html");
        }

        private void russelButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.russel;
            getData("https://www.formula1.com/en/drivers/george-russell.html");
        }

        private void latifiButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.goatifi;
            getData("https://www.formula1.com/en/drivers/nicholas-latifi.html");
        }

        private void valtteriButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.bottas;
            getData("https://www.formula1.com/en/drivers/valtteri-bottas.html");
        }

        private void hamButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.None;
            pictureBox.Image = formulaInfo.Properties.Resources.luis;
            getData("https://www.formula1.com/en/drivers/lewis-hamilton.html");
        }

        private void mickButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.Both;
            pictureBox.Image = formulaInfo.Properties.Resources.mick;
            getData("https://www.formula1.com/en/drivers/mick-schumacher.html");
        }

        private void nikitaButton_Click(object sender, EventArgs e)
        {
            valuesTextBox.ScrollBars = ScrollBars.Both;
            pictureBox.Image = formulaInfo.Properties.Resources.spin;
            getData("https://www.formula1.com/en/drivers/nikita-mazepin.html");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormulaAddict
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getData(String link)
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

        private void maxVerstappen_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.max;
            getData("https://www.formula1.com/en/drivers/max-verstappen.html");
        }

        private void checo_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.perez;
            getData("https://www.formula1.com/en/drivers/sergio-perez.html");
        }

        private void ricciardo_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.ricc;
            getData("https://www.formula1.com/en/drivers/daniel-ricciardo.html");
        }

        private void lando_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.lando;
            getData("https://www.formula1.com/en/drivers/lando-norris.html");
        }

        private void vettel_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.seb;
            getData("https://www.formula1.com/en/drivers/sebastian-vettel.html");
        }

        private void stroll_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.lance;
            getData("https://www.formula1.com/en/drivers/lance-stroll.html");
        }

        private void alonso_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.alonso;
            getData("https://www.formula1.com/en/drivers/fernando-alonso.html");
        }

        private void ocon_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.ocon;
            getData("https://www.formula1.com/en/drivers/esteban-ocon.html");
        }

        private void kimi_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.kimi;
            getData("https://www.formula1.com/en/drivers/kimi-raikkonen.html");
        }

        private void giovinazzi_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.gio;
            getData("https://www.formula1.com/en/drivers/antonio-giovinazzi.html");
        }

        private void charles_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.stupid;
            getData("https://www.formula1.com/en/drivers/charles-leclerc.html");
        }

        private void sainz_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.sainz;
            getData("https://www.formula1.com/en/drivers/carlos-sainz.html");
        }

        private void gasly_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.pierre;
            getData("https://www.formula1.com/en/drivers/pierre-gasly.html");
        }

        private void curse_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.yuki;
            getData("https://www.formula1.com/en/drivers/yuki-tsunoda.html");
        }

        private void russel_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.russel;
            getData("https://www.formula1.com/en/drivers/george-russell.html");
        }

        private void latifi_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.goatifi;
            getData("https://www.formula1.com/en/drivers/nicholas-latifi.html");
        }

        private void memur_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.bottas;
            getData("https://www.formula1.com/en/drivers/valtteri-bottas.html");
        }

        private void luis_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.luis;
            getData("https://www.formula1.com/en/drivers/lewis-hamilton.html");
        }

        private void mick_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.mick;
            getData("https://www.formula1.com/en/drivers/mick-schumacher.html");
        }

        private void sbinalla_CheckedChanged(object sender, EventArgs e)
        {
            pictures.Image = FormulaAddict.Properties.Resources.spin;
            getData("https://www.formula1.com/en/drivers/nikita-mazepin.html");
        }

        
    }
}

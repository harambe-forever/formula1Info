using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace FormulaAddict
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void web_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://www.formula1.com/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();            
        }

        private void teams_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void getData(String link, String html)
        {
            
        }

        /*private List<String> addList(String link, List<String> liste)
        {
            string newLine = Environment.NewLine;
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.f1-fansite.com/f1-results/f1-champions/");
            List<String> year = new List<string>();
            foreach (var item in doc.DocumentNode.SelectNodes(link))
            {
                liste.Add(item.InnerText);
            }
            return liste;
        }*/
        private void history_Click(object sender, EventArgs e)
        {
            infoCenter.Clear();
            string newLine = Environment.NewLine;
            /*List<String> year = new List<string>();   //takes a longer time to load.
            addList("//th[@class='msr_col1']", year);
            List<String> driver = new List<string>();
            addList("//td[@class='msr_col2']", driver);
            List<String> team = new List<string>();
            addList("//td[@class='msr_col3']", team);
            List<String> constr = new List<string>();
            addList("//td[@class='msr_col4']", constr);
            List<String> engine = new List<string>();
            addList("//td[@class='msr_col5']", engine);*/
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.f1-fansite.com/f1-results/f1-champions/");
            List<String> year = new List<string>(); 
            foreach (var item in doc.DocumentNode.SelectNodes("//th[@class='msr_col1']"))
            {
                year.Add(item.InnerText);
            }
            List<String> driver = new List<string>();
            driver.Add("");
            foreach (var item in doc.DocumentNode.SelectNodes("//td[@class='msr_col2']"))
            {
                driver.Add(item.InnerText);
            }
            List<String> team = new List<string>();
            team.Add("");
            foreach (var item in doc.DocumentNode.SelectNodes("//td[@class='msr_col3']"))
            {
                team.Add(item.InnerText);
            }
            List<String> constr = new List<string>();
            constr.Add("");
            foreach (var item in doc.DocumentNode.SelectNodes("//td[@class='msr_col4']"))
            {
                constr.Add(item.InnerText);
            }
            List<String> engine = new List<string>();
            engine.Add("");
            foreach (var item in doc.DocumentNode.SelectNodes("//td[@class='msr_col5']"))
            {
                engine.Add(item.InnerText);
            }
            infoCenter.AppendText("Year\tDriver\t\tTeam\tConst\tEngine" + newLine);
            for(int i = 0; i < driver.Count; i++)
            {
                infoCenter.AppendText(year[i] + "  " + driver[i] +
                                      "\t" + team[i] + "\t" + constr[i] + "\t" +
                                      engine[i] + newLine);
            }
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            infoCenter.Clear();
            string newLine = Environment.NewLine;
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.f1-fansite.com/f1-calendar/f1-2021-calendar/");
            List<String> nr = new List<string>();
            foreach (var item2 in doc.DocumentNode.SelectNodes("//td[@height='20']"))
            {
                nr.Add(item2.InnerText);
            }
            for (int i = 0; i < nr.Count; i++)
            {
                infoCenter.AppendText(nr[i] + newLine);
            }
        }
    }
}

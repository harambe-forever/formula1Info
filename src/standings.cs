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
    public partial class standings : Form
    {
        public standings()
        {
            InitializeComponent();
            getStandings("2021");
        }

        private void getStandings(String year)
        {
            string newLine = Environment.NewLine;
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.formula1.com/en/results.html/" + year + "/drivers.html");
            List<String> standings = new List<string>();
            foreach (var item2 in doc.DocumentNode.SelectNodes("//tr"))
            {
                standings.Add(item2.InnerText);
            }
            int whiteSpace = 0;
            for(int i = 0; i < standings.Count; i++)
            {
                for (int j = 0; j < standings[i].Count(); j++)
                {
                    char atm = standings[i][j];
                    if (char.IsLetterOrDigit(atm) || char.IsPunctuation(atm))
                    {       
                        if(whiteSpace > 5)
                        {
                            header.AppendText("  ");
                            whiteSpace = 0;
                        }
                        header.AppendText(atm + "");
                    }
                    else
                    {
                        whiteSpace++;
                        continue;
                    }
                }
                header.AppendText(newLine);
            }
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Clear();
            getStandings(listBox.SelectedItem.ToString());
        }
    }
}

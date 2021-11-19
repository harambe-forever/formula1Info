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
    public partial class calendar : Form
    {
        public calendar()
        {
            InitializeComponent();
            calendarUpdate();
        }

        private void calendarUpdate()
        {
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
                textBoxCalendar.AppendText(nr[i] + newLine);
            }
        }
    }
}

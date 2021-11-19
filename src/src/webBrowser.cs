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
    public partial class webBrowser : Form
    {
        private String url = "https://www.formula1.com/";
        public webBrowser()
        {
            InitializeComponent();
            webBrowserr.Navigate(url);
            webBrowserr.ScriptErrorsSuppressed = true;
        }
    }
}

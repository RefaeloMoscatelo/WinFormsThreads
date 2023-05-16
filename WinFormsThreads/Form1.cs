using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Report;
namespace WinFormsThreads
{
    public partial class Form1 : Form
    {
        Primer r = new Primer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            int num1 = int.Parse(txt1.Text);
            int num2 = int.Parse(txt2.Text);
            r.PrimerCheckHandler += r_PrimerCheckHandler;
            progressBar1.Style = ProgressBarStyle.Marquee;
            r.CheckAsync(num1, num2);
        }

        void r_PrimerCheckHandler(int x)
        {
            lstParams.Items.Add(x);
        }
    }
}

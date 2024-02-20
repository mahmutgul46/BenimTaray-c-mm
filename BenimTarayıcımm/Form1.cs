using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenimTarayıcımm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtAdres.Text);
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            if (panel2.Visible) panel2.Visible = false;
            else 
            
                panel2.Visible =true;
            

        }
    }
}

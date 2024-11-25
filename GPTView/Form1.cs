using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPTView
{
    public partial class Form1 : Form
    {
        private WebView2 webView;

        public Form1()
        {
            InitializeComponent();
            webView = new WebView2
            {
                Dock = DockStyle.Fill // Automatically resize with the form
            };
            this.Controls.Add(webView);
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            webView.Source = new Uri("https://chatgpt.com"); // Load ChatGPT
            webView.EnsureCoreWebView2Async();
        }
    }
}

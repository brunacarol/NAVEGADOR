﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ir(object sender, EventArgs e)
        {
            //this.webBrowser1.Url = new System.Uri("http://www."+ textacessar.Text, System.UriKind.Absolute);
            webBrowser1.Navigate(textacessar.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

       

       
       

       
       
    }
}

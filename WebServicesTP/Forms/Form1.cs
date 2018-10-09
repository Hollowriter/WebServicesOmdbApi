﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestClientClass rClient = new RestClientClass();
            rClient.title = null;
            rClient.type = null;
            rClient.year = null;
            if (textTitle.Text != null && textType.Text == null && textYear.Text == null)
            {
                rClient.title = "t=" + textTitle.Text;
                rClient.endPoint = rClient.key + rClient.title;
            }
            if (textTitle.Text != null && textType.Text != null && textYear.Text == null)
            {
                rClient.title = "t=" + textTitle.Text;
                rClient.type = "&type=" + textType.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.type;
            }
            if (textTitle.Text != null && textType.Text == null && textYear.Text != null)
            {
                rClient.title = "t=" + textTitle.Text;
                rClient.year = "&y=" + textYear.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.year;
            }
            if (textTitle.Text != null && textType.Text != null && textYear.Text != null)
            {
                rClient.title = "t=" + textTitle.Text;
                rClient.type = "&type=" + textType.Text;
                rClient.year = "&y=" + textYear.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.type + rClient.year;
            }
            /*if (textTitle.Text == null && textType.Text != null && textYear.Text != null)
            {
                rClient.title = "type=" + textType.Text;
                rClient.year = "&y=" + textYear.Text;
                rClient.endPoint = rClient.key + rClient.type + rClient.year;
            }
            if (textTitle.Text == null && textType.Text != null && textYear.Text == null)
            {
                rClient.title = "type=" + textType.Text;
                rClient.endPoint = rClient.key + rClient.type;
            }
            if (textTitle.Text == null && textType.Text == null && textYear.Text != null)
            {
                rClient.title = "y=" + textYear.Text;
                rClient.endPoint = rClient.key + rClient.year;
            }*/ // Segun el sitio de Ombdapi, tener la ID de Imdb o el titulo al menos es necesario
            string theResponse = string.Empty;
            theResponse = rClient.makeRequest();
            debugOutput(theResponse);
        }

        private void debugOutput(string theOutputText)
        {
            try
            {
                System.Diagnostics.Debug.Write(theOutputText + Environment.NewLine);
                textResponse.Text = textResponse.Text + theOutputText + Environment.NewLine;
                textResponse.SelectionStart = textResponse.TextLength;
                textResponse.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

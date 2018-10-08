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
            if (textType.Text == null && textYear.Text == null)
            {
                rClient.title = "t=" + textTitle.Text;
                rClient.endPoint = rClient.key + rClient.title;
            }
            if (textType.Text != null && textYear.Text == null)
            {
                rClient.title = "t=" + textTitle.Text;
                rClient.type = "&type=" + textType.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.type;
            }
            if (textType.Text == null && textYear.Text != null)
            {
                rClient.title = "t=" + textTitle.Text;
                rClient.year = "&y=" + textYear.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.year;
            }
            if (textType.Text != null && textYear.Text != null)
            {
                rClient.title = "t=" + textTitle.Text;
                rClient.type = "&type=" + textType.Text;
                rClient.year = "&y=" + textYear.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.type + rClient.year;
            }
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
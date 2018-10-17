using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
                rClient.title = "s=" + textTitle.Text;
                rClient.endPoint = rClient.key + rClient.title;
            }
            if (textTitle.Text != null && textType.Text != null && textYear.Text == null)
            {
                rClient.title = "s=" + textTitle.Text;
                rClient.type = "&type=" + textType.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.type;
            }
            if (textTitle.Text != null && textType.Text == null && textYear.Text != null)
            {
                rClient.title = "s=" + textTitle.Text;
                rClient.year = "&y=" + textYear.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.year;
            }
            if (textTitle.Text != null && textType.Text != null && textYear.Text != null)
            {
                rClient.title = "s=" + textTitle.Text;
                rClient.type = "&type=" + textType.Text;
                rClient.year = "&y=" + textYear.Text;
                rClient.endPoint = rClient.key + rClient.title + rClient.type + rClient.year;
            }
            //Movie theResponse = new Movie();
            Movie theResponse = rClient.makeRequest();
            for (int i = 0; i < theResponse.Search.Length; i++)
            {
                debugOutput("Title: " + theResponse.Search[i].Title + '\n');
                debugOutput("Type: " + theResponse.Search[i].Type + '\n');
                debugOutput("Year: " + theResponse.Search[i].Year + '\n');
                debugOutput(" " + '\n');
            }
        }

        private void debugOutput(string theOutputText)
        {
            textResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; 
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

        private void textTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

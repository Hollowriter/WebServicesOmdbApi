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
        Movie theResponse;
        bool showing;
        public Form1()
        {
            InitializeComponent();
            theResponse = null;
            showing = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestClientClass rClient = new RestClientClass();
            theResponse = null;
            listResponse.Items.Clear();
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
            theResponse = rClient.makeRequest();
            // textResponse.Clear();
           for (int i = 0; i < theResponse.Search.Length; i++)
            {
                listResponse.Items.Add(theResponse.Search[i].Title);
                listType.Items.Add(theResponse.Search[i].Type);
                listYear.Items.Add(theResponse.Search[i].Year);
                /*debugOutput("Title: " + theResponse.Search[i].Title + '\n');
                debugOutput("Type: " + theResponse.Search[i].Type + '\n');
                debugOutput("Year: " + theResponse.Search[i].Year + '\n');
                debugOutput(" " + '\n');*/
            }
        }

        /*private void debugOutput(string theOutputText)
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
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void listResponse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showing == false)
            {
                showing = true;
                Form2 cosito = new Form2();
                listType.SelectedIndex = listResponse.SelectedIndex;
                listYear.SelectedIndex = listResponse.SelectedIndex;
                cosito.ShowSelection(theResponse.Search[listResponse.SelectedIndex].Title.ToString());
                cosito.ShowDialog();
                showing = false;
            }
            else
            {
                listType.SelectedIndex = listResponse.SelectedIndex;
                listYear.SelectedIndex = listResponse.SelectedIndex;
            }
        }

        /*private void listType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 cosito = new Form2();
            listResponse.SelectedIndex = listType.SelectedIndex;
            listYear.SelectedIndex = listType.SelectedIndex;
            cosito.ShowSelection(theResponse.Search[listType.SelectedIndex].Title.ToString());
            cosito.ShowDialog();
        }
        private void listYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 cosito = new Form2();
            listType.SelectedIndex = listYear.SelectedIndex;
            listResponse.SelectedIndex = listYear.SelectedIndex;
            cosito.ShowSelection(theResponse.Search[listYear.SelectedIndex].Title.ToString());
            cosito.ShowDialog();
        }*/

        private void listType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (showing == false)
            {
                showing = true;
                Form2 cosito = new Form2();
                listResponse.SelectedIndex = listType.SelectedIndex;
                listYear.SelectedIndex = listType.SelectedIndex;
                cosito.ShowSelection(theResponse.Search[listType.SelectedIndex].Title.ToString());
                cosito.ShowDialog();
                showing = false;
            }
            else
            {
                listResponse.SelectedIndex = listType.SelectedIndex;
                listYear.SelectedIndex = listType.SelectedIndex;
            }
        }

        private void listYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (showing == false)
            {
                showing = true;
                Form2 cosito = new Form2();
                listType.SelectedIndex = listYear.SelectedIndex;
                listResponse.SelectedIndex = listYear.SelectedIndex;
                cosito.ShowSelection(theResponse.Search[listYear.SelectedIndex].Title.ToString());
                cosito.ShowDialog();
                showing = false;
            }
            else
            {
                listType.SelectedIndex = listYear.SelectedIndex;
                listResponse.SelectedIndex = listYear.SelectedIndex;
            }
        }
    }
}

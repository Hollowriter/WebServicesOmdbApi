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
        int page;
        int maximumPage;
        string firstCall;
        RestClientClass rClient = new RestClientClass();
        public Form1()
        {
            InitializeComponent();
            theResponse = null;
            firstCall = null;
            showing = false;
            page = 0;
            maximumPage = 0;
            GoRight.Enabled = false;
            GoLeft.Enabled = false;
            GoToFirstPage.Enabled = false;
            GoToLastPage.Enabled = false;
            comboBox1.Items.AddRange(new object[] { "short", "full" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maximumPage = 0;
            //RestClientClass rClient = new RestClientClass();
            theResponse = null;
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
            firstCall = rClient.endPoint;
            PageIndicator.Clear();
            listResponse.Items.Clear();
            listType.Items.Clear();
            listYear.Items.Clear();
            int totalResults = Convert.ToInt32(theResponse.totalResults);
            maximumPage = (int)Math.Ceiling((double) totalResults / theResponse.Search.Length);
           page = 1;
           if (page != maximumPage)
           {
               GoRight.Enabled = true;
               GoToLastPage.Enabled = true;
           }
           for (int i = 0; i < theResponse.Search.Length; i++)
           {
                listResponse.Items.Add(theResponse.Search[i].Title);
                listType.Items.Add(theResponse.Search[i].Type);
                listYear.Items.Add(theResponse.Search[i].Year);
           }
            debugOutput("1");
        }

        private void debugOutput(string theOutputText)
        {
            try
            {
                System.Diagnostics.Debug.Write(theOutputText + Environment.NewLine);
                PageIndicator.Text = PageIndicator.Text + theOutputText + Environment.NewLine;
                PageIndicator.SelectionStart = PageIndicator.TextLength;
                PageIndicator.ScrollToCaret();
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

        private void listResponse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showing == false)
            {
                showing = true;
                Form2 cosito = new Form2();
                listType.SelectedIndex = listResponse.SelectedIndex;
                listYear.SelectedIndex = listResponse.SelectedIndex;
                if (comboBox1.SelectedItem == null)
                {
                    cosito.ShowSelection(theResponse.Search[listResponse.SelectedIndex].Title.ToString());
                }
                else
                {
                    cosito.ShowSelection(theResponse.Search[listResponse.SelectedIndex].Title.ToString() + "&plot=" + comboBox1.SelectedItem.ToString());
                }
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
                if (comboBox1.SelectedItem == null)
                {
                    cosito.ShowSelection(theResponse.Search[listType.SelectedIndex].Title.ToString());
                }
                else
                {
                    cosito.ShowSelection(theResponse.Search[listType.SelectedIndex].Title.ToString() + "&plot=" + comboBox1.SelectedItem.ToString());
                }
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
                if (comboBox1.SelectedItem == null)
                {
                    cosito.ShowSelection(theResponse.Search[listYear.SelectedIndex].Title.ToString());
                }
                else
                {
                    cosito.ShowSelection(theResponse.Search[listYear.SelectedIndex].Title.ToString() + "&plot=" + comboBox1.SelectedItem.ToString());
                }
                cosito.ShowDialog();
                showing = false;
            }
            else
            {
                listType.SelectedIndex = listYear.SelectedIndex;
                listResponse.SelectedIndex = listYear.SelectedIndex;
            }
        }

        private void GoRight_Click(object sender, EventArgs e)
        {
            if (page != maximumPage)
            {
                page++;
                PageIndicator.Clear();
                listResponse.Items.Clear();
                listType.Items.Clear();
                listYear.Items.Clear();
                rClient.endPoint = firstCall + "&page=" + page;
                theResponse = rClient.makeRequest();
                for (int i = 0; i < theResponse.Search.Length; i++)
                {
                    listResponse.Items.Add(theResponse.Search[i].Title);
                    listType.Items.Add(theResponse.Search[i].Type);
                    listYear.Items.Add(theResponse.Search[i].Year);
                }
                debugOutput(page.ToString());
            }
            if (page == maximumPage)
            {
                GoRight.Enabled = false;
                GoToLastPage.Enabled = false;
            }
            else
            {
                GoRight.Enabled = true;
                GoToLastPage.Enabled = true;
            }
            if (page == 1)
            {
                GoLeft.Enabled = false;
                GoToFirstPage.Enabled = false;
            }
            else
            {
                GoLeft.Enabled = true;
                GoToFirstPage.Enabled = true;
            }
        }

        private void GoLeft_Click(object sender, EventArgs e)
        {
            if (page != 1)
            {
                page--;
                PageIndicator.Clear();
                listResponse.Items.Clear();
                listType.Items.Clear();
                listYear.Items.Clear();
                rClient.endPoint = firstCall + "&page=" + page;
                theResponse = rClient.makeRequest();
                for (int i = 0; i < theResponse.Search.Length; i++)
                {
                    listResponse.Items.Add(theResponse.Search[i].Title);
                    listType.Items.Add(theResponse.Search[i].Type);
                    listYear.Items.Add(theResponse.Search[i].Year);
                }
                debugOutput(page.ToString());
            }
            if (page == 1)
            {
                GoLeft.Enabled = false;
                GoToFirstPage.Enabled = false;
            }
            else
            {
                GoLeft.Enabled = true;
                GoToFirstPage.Enabled = true;
            }
            if (page == maximumPage)
            {
                GoRight.Enabled = false;
                GoToLastPage.Enabled = false;
            }
            else
            {
                GoRight.Enabled = true;
                GoToLastPage.Enabled = true;
            }
        }

        private void GoToLastPage_Click(object sender, EventArgs e)
        {
            if (page != maximumPage)
            {
                page = maximumPage;
                PageIndicator.Clear();
                listResponse.Items.Clear();
                listType.Items.Clear();
                listYear.Items.Clear();
                rClient.endPoint = firstCall + "&page=" + page;
                theResponse = rClient.makeRequest();
                for (int i = 0; i < theResponse.Search.Length; i++)
                {
                    listResponse.Items.Add(theResponse.Search[i].Title);
                    listType.Items.Add(theResponse.Search[i].Type);
                    listYear.Items.Add(theResponse.Search[i].Year);
                }
                debugOutput(page.ToString());
            }
            if (page == maximumPage)
            {
                GoRight.Enabled = false;
                GoToLastPage.Enabled = false;
            }
            else
            {
                GoRight.Enabled = true;
                GoToLastPage.Enabled = true;
            }
            if (page == 1)
            {
                GoLeft.Enabled = false;
                GoToFirstPage.Enabled = false;
            }
            else
            {
                GoLeft.Enabled = true;
                GoToFirstPage.Enabled = true;
            }
        }

        private void GoToFirstPage_Click(object sender, EventArgs e)
        {
            if (page != 1)
            {
                page = 1;
                PageIndicator.Clear();
                listResponse.Items.Clear();
                listType.Items.Clear();
                listYear.Items.Clear();
                rClient.endPoint = firstCall + "&page=" + page;
                theResponse = rClient.makeRequest();
                for (int i = 0; i < theResponse.Search.Length; i++)
                {
                    listResponse.Items.Add(theResponse.Search[i].Title);
                    listType.Items.Add(theResponse.Search[i].Type);
                    listYear.Items.Add(theResponse.Search[i].Year);
                }
                debugOutput(page.ToString());
            }
            if (page == 1)
            {
                GoLeft.Enabled = false;
                GoToFirstPage.Enabled = false;
            }
            else
            {
                GoLeft.Enabled = true;
                GoToFirstPage.Enabled = true;
            }
            if (page == maximumPage)
            {
                GoRight.Enabled = false;
                GoToLastPage.Enabled = false;
            }
            else
            {
                GoRight.Enabled = true;
                GoToLastPage.Enabled = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

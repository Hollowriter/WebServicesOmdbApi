using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void ShowSelection(string sender2)
        {
            RestClientClass secondCall = new RestClientClass();
            secondCall.title = "t=" + sender2;
            secondCall.endPoint = secondCall.key + secondCall.title;
            MovieDetail theSecondResponse = secondCall.secondRequest();
            debugOutput("Title: " + theSecondResponse.Title + "\n");
            debugOutput("Year: " + theSecondResponse.Year + "\n");
            debugOutput("Rated: " + theSecondResponse.Rated + "\n");
        }
        private void debugOutput(string theOutputText)
        {
            secondResponseBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            try
            {
                System.Diagnostics.Debug.Write(theOutputText + Environment.NewLine);
                secondResponseBox.Text = secondResponseBox.Text + theOutputText + Environment.NewLine;
                secondResponseBox.SelectionStart = secondResponseBox.TextLength;
                secondResponseBox.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}

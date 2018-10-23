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
            debugOutput("Type: " + theSecondResponse.Type + "\n");
            debugOutput("Seasons: " + theSecondResponse.totalSeasons + "\n");
            debugOutput("Rated: " + theSecondResponse.Rated + "\n");
            debugOutput("Released: " + theSecondResponse.Released + "\n");
            debugOutput("Runtime: " + theSecondResponse.Runtime + "\n");
            debugOutput("Genre: " + theSecondResponse.Genre + "\n");
            debugOutput("Director: " + theSecondResponse.Director + "\n");
            debugOutput("Writer: " + theSecondResponse.Writer + "\n");
            debugOutput("Actors: " + theSecondResponse.Actors + "\n");
            debugOutput("Plot: " + theSecondResponse.Plot + "\n");
            debugOutput("Language: " + theSecondResponse.Language + "\n");
            debugOutput("Country: " + theSecondResponse.Country + "\n");
            debugOutput("Awards: " + theSecondResponse.Awards + "\n");
            debugOutput("Ratings:\n");
            /*for (int i = 0; i < theSecondResponse.Rateos.Length; i++)
            {
                debugOutput(" Value:" + theSecondResponse.Rateos[i].Value + "\n Source: " + theSecondResponse.Rateos[i].Value);
            }*/ // Esto tira null
            debugOutput("\n");
            debugOutput("ImdbRating: " + theSecondResponse.imdbRating + "\n");
            debugOutput("ImdbVotes: " + theSecondResponse.imdbVotes + "\n");
            outputImage(theSecondResponse.Poster);
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

        private void outputImage(string theUrl)
        {
            posterBox.ImageLocation = theUrl;
        }
    }
}

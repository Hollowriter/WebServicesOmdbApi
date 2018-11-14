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
            RestClientImage theImageDetail = new RestClientImage(); // Continuar
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
            debugOutput("\n");
            debugOutput("ImdbRating: " + theSecondResponse.imdbRating + "\n");
            debugOutput("ImdbVotes: " + theSecondResponse.imdbVotes + "\n");
            outputImage(theSecondResponse.Poster);
            theImageDetail.theUrl = System.Net.WebUtility.UrlEncode(theSecondResponse.Poster);
            theImageDetail.endPoint = theImageDetail.key + theImageDetail.theUrl + theImageDetail.responseType;
            ImageDetail imageResponse = theImageDetail.makeRequest();
            outputImageInformation("File Type: " + imageResponse.FileType + "\n");
            outputImageInformation("File Type Extension: " + imageResponse.FileTypeExtension + "\n");
            outputImageInformation("MIME Type: " + imageResponse.MIMEType + "\n");
            outputImageInformation("JFIF Version: " + imageResponse.JFIFVersion + "\n");
            outputImageInformation("Image Resolution: " + imageResponse.XResolution + "x" + imageResponse.YResolution + "\n");
            outputImageInformation("Resolution Unit: " + imageResponse.ResolutionUnit + "\n");
            outputImageInformation("Profile CMM Type: " + imageResponse.ProfileCMMType + "\n");
            outputImageInformation("Profile Version: " + imageResponse.ProfileVersion + "\n");
            outputImageInformation("Profile Class: " + imageResponse.ProfileClass + "\n");
            outputImageInformation("Color Space Data: " + imageResponse.ColorSpaceData + "\n");
            outputImageInformation("Profile Connection Space: " + imageResponse.ProfileConnectionSpace + "\n");
            outputImageInformation("Profile Date Time: " + imageResponse.ProfileDateTime + "\n");
            outputImageInformation("Profile File Signature" + imageResponse.ProfileFileSignature + "\n");
            outputImageInformation("Primary Platform" + imageResponse.PrimaryPlatform + "\n");
            outputImageInformation("CMMFlags: " + imageResponse.CMMFlags + "\n");
            outputImageInformation("Device Manufacturer: " + imageResponse.DeviceManufacturer + "\n");
            outputImageInformation("Device Model: " + imageResponse.DeviceModel + "\n");
            outputImageInformation("Device Attributes: " + imageResponse.DeviceAttributes + "\n");
            outputImageInformation("Rendering Intent: " + imageResponse.RenderingIntent + "\n");
            outputImageInformation("Connection Space Illuminant: " + imageResponse.ConnectionSpaceIlluminant + "\n");
            outputImageInformation("Profile Creator: " + imageResponse.ProfileCreator + "\n");
            outputImageInformation("Profile ID: " + imageResponse.ProfileID + "\n");
            outputImageInformation("Profile Copyright: " + imageResponse.ProfileCopyright + "\n");
            outputImageInformation("Profile Description: " + imageResponse.ProfileDescription + "\n");
            outputImageInformation("Media White Point: " + imageResponse.MediaWhitePoint + "\n");
            outputImageInformation("Media Black Point: " + imageResponse.MediaBlackPoint + "\n");
            outputImageInformation("Red Matrix Column: " + imageResponse.RedMatrixColumn + "\n");
            outputImageInformation("Green Matrix Column: " + imageResponse.GreenMatrixColumn + "\n");
            outputImageInformation("Blue Matrix Column: " + imageResponse.BlueMatrixColumn + "\n");
            outputImageInformation("Image Width: " + imageResponse.ImageWidth + "\n");
            outputImageInformation("Image Height: " + imageResponse.ImageHeight + "\n");
            outputImageInformation("Image Size: " + imageResponse.ImageSize + "\n");
            outputImageInformation("Megapixels: " + imageResponse.Megapixels + "\n");
            outputImageInformation("Encoding Process: " + imageResponse.EncodingProcess + "\n");
            outputImageInformation("Bits Per Sample: " + imageResponse.BitsPerSample + "\n");
            outputImageInformation("Color components: " + imageResponse.ColorComponents + "\n");
            outputImageInformation("YCbCrSubSampling: " + imageResponse.YCbCrSubSampling + "\n");
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

        private void outputImageInformation(string theOutputText)
        {
            posterBoxDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            try
            {
                System.Diagnostics.Debug.Write(theOutputText + Environment.NewLine);
                posterBoxDetail.Text = posterBoxDetail.Text + theOutputText + Environment.NewLine;
                posterBoxDetail.SelectionStart = posterBoxDetail.TextLength;
                posterBoxDetail.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void secondResponseBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

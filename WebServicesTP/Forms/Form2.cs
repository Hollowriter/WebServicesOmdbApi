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
            if (theSecondResponse.Poster != null && theSecondResponse.Poster != "N/A")
            {
                outputImage(theSecondResponse.Poster);
                theImageDetail.theUrl = System.Net.WebUtility.UrlEncode(theSecondResponse.Poster);
                theImageDetail.endPoint = theImageDetail.key + theImageDetail.theUrl + theImageDetail.responseType;
                ImageDetail imageResponse = theImageDetail.makeRequest();
                if (imageResponse.FileType != null)
                    outputImageInformation("File Type: " + imageResponse.FileType + "\n");
                if (imageResponse.FileTypeExtension != null)
                    outputImageInformation("File Type Extension: " + imageResponse.FileTypeExtension + "\n");
                if (imageResponse.MIMEType != null)
                    outputImageInformation("MIME Type: " + imageResponse.MIMEType + "\n");
                outputImageInformation("JFIF Version: " + imageResponse.JFIFVersion + "\n");
                outputImageInformation("Image Resolution: " + imageResponse.XResolution + "x" + imageResponse.YResolution + "\n");
                outputImageInformation("Resolution Unit: " + imageResponse.ResolutionUnit + "\n");
                if (imageResponse.ProfileCMMType != null)
                    outputImageInformation("Profile CMM Type: " + imageResponse.ProfileCMMType + "\n");
                if (imageResponse.ProfileVersion != null)
                    outputImageInformation("Profile Version: " + imageResponse.ProfileVersion + "\n");
                if (imageResponse.ProfileClass != null)
                    outputImageInformation("Profile Class: " + imageResponse.ProfileClass + "\n");
                if (imageResponse.ColorSpaceData != null)
                    outputImageInformation("Color Space Data: " + imageResponse.ColorSpaceData + "\n");
                if (imageResponse.ProfileConnectionSpace != null)
                    outputImageInformation("Profile Connection Space: " + imageResponse.ProfileConnectionSpace + "\n");
                if (imageResponse.ProfileDateTime != null)
                    outputImageInformation("Profile Date Time: " + imageResponse.ProfileDateTime + "\n");
                if (imageResponse.ProfileFileSignature != null)
                    outputImageInformation("Profile File Signature" + imageResponse.ProfileFileSignature + "\n");
                if (imageResponse.PrimaryPlatform != null)
                    outputImageInformation("Primary Platform" + imageResponse.PrimaryPlatform + "\n");
                if (imageResponse.CMMFlags != null)
                    outputImageInformation("CMMFlags: " + imageResponse.CMMFlags + "\n");
                if (imageResponse.DeviceManufacturer != null)
                    outputImageInformation("Device Manufacturer: " + imageResponse.DeviceManufacturer + "\n");
                if (imageResponse.DeviceModel != null)
                    outputImageInformation("Device Model: " + imageResponse.DeviceModel + "\n");
                if (imageResponse.DeviceAttributes != null)
                    outputImageInformation("Device Attributes: " + imageResponse.DeviceAttributes + "\n");
                if (imageResponse.RenderingIntent != null)
                    outputImageInformation("Rendering Intent: " + imageResponse.RenderingIntent + "\n");
                if (imageResponse.ConnectionSpaceIlluminant != null)
                    outputImageInformation("Connection Space Illuminant: " + imageResponse.ConnectionSpaceIlluminant + "\n");
                if (imageResponse.ProfileCreator != null)
                    outputImageInformation("Profile Creator: " + imageResponse.ProfileCreator + "\n");
                outputImageInformation("Profile ID: " + imageResponse.ProfileID + "\n");
                if (imageResponse.ProfileCopyright != null)
                    outputImageInformation("Profile Copyright: " + imageResponse.ProfileCopyright + "\n");
                if (imageResponse.ProfileDescription != null)
                    outputImageInformation("Profile Description: " + imageResponse.ProfileDescription + "\n");
                if (imageResponse.MediaWhitePoint != null)
                    outputImageInformation("Media White Point: " + imageResponse.MediaWhitePoint + "\n");
                if (imageResponse.MediaBlackPoint != null)
                    outputImageInformation("Media Black Point: " + imageResponse.MediaBlackPoint + "\n");
                if (imageResponse.RedMatrixColumn != null)
                    outputImageInformation("Red Matrix Column: " + imageResponse.RedMatrixColumn + "\n");
                if (imageResponse.GreenMatrixColumn != null)
                    outputImageInformation("Green Matrix Column: " + imageResponse.GreenMatrixColumn + "\n");
                if (imageResponse.BlueMatrixColumn != null)
                    outputImageInformation("Blue Matrix Column: " + imageResponse.BlueMatrixColumn + "\n");
                outputImageInformation("Image Width: " + imageResponse.ImageWidth + "\n");
                outputImageInformation("Image Height: " + imageResponse.ImageHeight + "\n");
                outputImageInformation("Image Size: " + imageResponse.ImageSize + "\n");
                outputImageInformation("Megapixels: " + imageResponse.Megapixels + "\n");
                if (imageResponse.EncodingProcess != null)
                    outputImageInformation("Encoding Process: " + imageResponse.EncodingProcess + "\n");
                outputImageInformation("Bits Per Sample: " + imageResponse.BitsPerSample + "\n");
                outputImageInformation("Color components: " + imageResponse.ColorComponents + "\n");
                if (imageResponse.YCbCrSubSampling != null)
                    outputImageInformation("YCbCrSubSampling: " + imageResponse.YCbCrSubSampling + "\n");
            }
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

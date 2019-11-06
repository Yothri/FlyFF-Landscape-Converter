using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FlyFF_Landscape_Converter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var dr = fbd.ShowDialog();

                if(dr == DialogResult.OK)
                {
                    txtInput.Text = fbd.SelectedPath;
                }
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            statusProgress.Style = ProgressBarStyle.Marquee;
            txtInput.Enabled = false;
            btnConvert.Enabled = false;
            btnBrowseInput.Enabled = false;
            txtOutput.Enabled = false;
            btnBrowseOutput.Enabled = false;
            btnExport.Enabled = false;

            var landscapes = await LandscapeConverter.LoadLandscapes(txtInput.Text);
            var bitmap = await LandscapeConverter.GetBitmapFromLandscapes(landscapes);

            resultImage.Image = bitmap;

            statusProgress.Style = ProgressBarStyle.Blocks;
            txtInput.Enabled = true;
            btnConvert.Enabled = true;
            btnBrowseInput.Enabled = true;
            txtOutput.Enabled = true;
            btnBrowseOutput.Enabled = true;
            btnExport.Enabled = true;
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG|*.png";

                var dr = sfd.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    resultImage.Image.Save(sfd.FileName, ImageFormat.Png);
                    MessageBox.Show("Done exporting!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

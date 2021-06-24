using Amazon.Rekognition.Model;
using Amazon.S3.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextInImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AwsAuthentication.SetCredentials();
            InitializeComponent();
            LoadBuckets();
        }

        private void LoadBuckets()
        {
            cbBuckets.Items.Clear();
            foreach (var item in ListBuckets())
            {
                cbBuckets.Items.Add(item.BucketName);
            }
        }

        List<TextDetection> listaPalavras;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<S3Bucket> ListBuckets()
        {
            return new S3Service().GetListBuckets();
        }

        private async Task<bool> IdentificarTexto(string file, string bucket)
        {
            try
            {
                S3Service s3Service = new S3Service();
                await s3Service.UploadToS3(file, bucket);

                RekognitionUtils rekognition = new RekognitionUtils();
                var textDetected = await rekognition.DetectTextInImage(file, bucket);
                listaPalavras = textDetected.TextDetections;

                Graphics g = pictureBoxTextImage.CreateGraphics();
                foreach (TextDetection item in textDetected.TextDetections)
                {
                    if (item.Type == "WORD")
                    {
                        rtbTextDetected.AppendText($"{item.DetectedText} ");
                        g.DrawRectangle(new Pen(Color.Red),
                            item.Geometry.BoundingBox.Left * pictureBoxTextImage.Width,
                            item.Geometry.BoundingBox.Top * pictureBoxTextImage.Height,
                            item.Geometry.BoundingBox.Width * pictureBoxTextImage.Width,
                            item.Geometry.BoundingBox.Height * pictureBoxTextImage.Height);
                    }
                }
                rtbInfoPalavra.AppendText("Clique nos retângulos vermelhos para ter a informação de cada palavra");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private async void btnFileImg_Click(object sender, EventArgs e)
        {
            if (cbBuckets.SelectedItem == null)
            {
                MessageBox.Show("Selecione o bucket", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtbInfoPalavra.Clear();
                    rtbTextDetected.Clear();
                    pictureBoxTextImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxTextImage.Load(openFileDialog1.FileName);
                    await IdentificarTexto(openFileDialog1.FileName, cbBuckets.SelectedItem.ToString());
                }
            }
        }

        private void pictureBoxTextImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (listaPalavras != null)
            {
                foreach (var item in listaPalavras)
                {
                    {
                        float x = item.Geometry.BoundingBox.Left * pictureBoxTextImage.Width;
                        float y = item.Geometry.BoundingBox.Top * pictureBoxTextImage.Height;
                        float width = item.Geometry.BoundingBox.Width * pictureBoxTextImage.Width;
                        float height = item.Geometry.BoundingBox.Height * pictureBoxTextImage.Height;

                        if ((e.X >= x && e.X <= x + width) && (e.Y >= y && e.Y <= y + height))
                        {
                            rtbInfoPalavra.Clear();
                            rtbInfoPalavra.AppendText(JsonConvert.SerializeObject(item, Formatting.Indented));
                        }
                    }
                }
            }
        }

        private void btnReloadBuckets_Click(object sender, EventArgs e)
        {
            LoadBuckets();
        }
    }
}

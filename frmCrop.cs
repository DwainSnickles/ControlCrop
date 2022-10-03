using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCrop
{
    public partial class frmCrop : Form
    {
        //Create instance of class
        ControlCrop ControlrectPicturebox;
        ControlCrop ControlrectPanel;

        public frmCrop()
        {
            InitializeComponent();

            //Set crop control for each cotrol

            //Set the Control in this case panel to add crop rectangle
            ControlrectPanel = new ControlCrop(pnlCrop);
            ControlrectPanel.SetControl(this.pnlCrop);

            //Set the Control in this case label to add crop rectangle
            ControlrectPicturebox = new ControlCrop(picCrop);
            ControlrectPicturebox.SetControl(this.picCrop);

        }
        public string GetImageFilter()
        {
            StringBuilder allImageExtensions = new StringBuilder();
            string separator = "";
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            Dictionary<string, string> images = new Dictionary<string, string>();
            foreach (ImageCodecInfo codec in codecs)
            {
                allImageExtensions.Append(separator);
                allImageExtensions.Append(codec.FilenameExtension);
                separator = ";";
                images.Add(string.Format("{0} Files: ({1})", codec.FormatDescription, codec.FilenameExtension),
                           codec.FilenameExtension);
            }
            StringBuilder sb = new StringBuilder();
            if (allImageExtensions.Length > 0)
            {
                sb.AppendFormat("{0}|{1}", "All Images", allImageExtensions.ToString());
            }
            images.Add("All Files", "*.*");
            foreach (KeyValuePair<string, string> image in images)
            {
                sb.AppendFormat("|{0}|{1}", image.Key, image.Value);
            }
            return sb.ToString();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            try
            {
                OpenFileDialog Dlg = new OpenFileDialog();
                Dlg.Filter = GetImageFilter();
                Dlg.Title = "Select image";
                if (Dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    picCrop.Image = Image.FromFile(Dlg.FileName);
                    pnlCrop.BackgroundImage = Image.FromFile(Dlg.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            try
            {
                //Process Panel
                Rectangle rectPanel = new Rectangle(ControlrectPanel.rect.X, ControlrectPanel.rect.Y, ControlrectPanel.rect.Width, ControlrectPanel.rect.Height);

                //set cropped image size and creat new bitmap
                Bitmap _pnlimg = new Bitmap(ControlrectPanel.rect.Width, ControlrectPanel.rect.Height);

                //Create the original image to be cropped
                Bitmap OriginalPanelImage = new Bitmap(pnlCrop.BackgroundImage, pnlCrop.Width, pnlCrop.Height);

                //create graphic with using statement to auto close grahics
                using (Graphics g = Graphics.FromImage(_pnlimg))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    ////set image attributes
                    g.DrawImage(OriginalPanelImage, 0, 0, rectPanel, GraphicsUnit.Pixel);
                    picCroppedPanel.Image = _pnlimg;
                }

                //Process Picturebox
                Rectangle rectPicturebox = new Rectangle(ControlrectPicturebox.rect.X, ControlrectPicturebox.rect.Y, ControlrectPicturebox.rect.Width, ControlrectPicturebox.rect.Height);

                //set cropped image size and creat new bitmap
                Bitmap _pboximg = new Bitmap(ControlrectPicturebox.rect.Width, ControlrectPicturebox.rect.Height);

                //Create the original image to be cropped
                Bitmap OriginalPictureboxImage = new Bitmap(picCrop.Image, picCrop.Width, picCrop.Height);

                //create graphic with using statement to auto close grahics
                using (Graphics gr = Graphics.FromImage(_pboximg))
                {
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    ////set image attributes
                    gr.DrawImage(OriginalPictureboxImage, 0, 0, rectPicturebox, GraphicsUnit.Pixel);
                    picCropped.Image = _pboximg;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnChangeCropColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlRectangleColor.BackColor = colorDialog1.Color;
            ControlrectPicturebox.RectangleColor = colorDialog1.Color;
            pnlRectangleColor.Invalidate();
            this.picCrop.Invalidate();
        }
    }
}

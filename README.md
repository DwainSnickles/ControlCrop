# C# Universal Control Cropping Class
Add Cropping to any control with image or backgroundimage

I love programing especially in graphics. 

I ran into a situation where I need to crop a simple picturebox wasnt as easy as anticipated.

Then I wanted to crop a panel background image started rewritting the code for that.

Brainstorm how about a class that could be universal to any control that has some kind of image.

WALA! This class was born.

![CropForm](https://user-images.githubusercontent.com/26853477/193463038-440cbe0c-2259-4d9f-8b62-81929865720e.png)

Note:

The whole crop rectangle can be dragged using right mouse down and drag crop rectangle to desired are inside the control.

Use the drag by left mouse down on any of the drag handles drag the crop rectangle in different diretions.

Usage is fairly simple

1) Create an instance of the crop class in form

        ControlCrop ControlrectPanel;

        public frmCrop()
        {
            InitializeComponent();

            //Set crop control for each cotrol

            //Set the Control in this case panel to add crop rectangle
            ControlrectPanel = new ControlCrop(pnlCrop);
            ControlrectPanel.SetControl(this.pnlCrop);

            //Set the Control in this case Picturebox to add crop rectangle
            ControlrectPicturebox = new ControlCrop(picCrop);
            ControlrectPicturebox.SetControl(this.picCrop);

        }
    
2) The crop button code:
 
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
                Rectangle rectPicturebox = new Rectangle(ControlrectPicturebox.rect.X, ControlrectPicturebox.rect.Y, ControlrectPicturebox.rect.Width,          
                ControlrectPicturebox.rect.Height);
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
 
    
 

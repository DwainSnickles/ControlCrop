
namespace ControlCrop
{
    partial class frmCrop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picCropped = new System.Windows.Forms.PictureBox();
            this.picCroppedPanel = new System.Windows.Forms.PictureBox();
            this.pnlCrop = new System.Windows.Forms.Panel();
            this.picCrop = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnChangeCropColor = new System.Windows.Forms.Button();
            this.pnlRectangleColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picCropped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCroppedPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Crop Control to any form control";
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(481, 358);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(119, 23);
            this.btnCrop.TabIndex = 0;
            this.btnCrop.Text = "Crop All";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Panel Crop background image";
            // 
            // picCropped
            // 
            this.picCropped.Location = new System.Drawing.Point(232, 257);
            this.picCropped.Name = "picCropped";
            this.picCropped.Size = new System.Drawing.Size(50, 50);
            this.picCropped.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCropped.TabIndex = 6;
            this.picCropped.TabStop = false;
            // 
            // picCroppedPanel
            // 
            this.picCroppedPanel.Location = new System.Drawing.Point(332, 69);
            this.picCroppedPanel.Name = "picCroppedPanel";
            this.picCroppedPanel.Size = new System.Drawing.Size(50, 50);
            this.picCroppedPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCroppedPanel.TabIndex = 5;
            this.picCroppedPanel.TabStop = false;
            // 
            // pnlCrop
            // 
            this.pnlCrop.BackgroundImage = global::ControlCrop.Properties.Resources.Lion;
            this.pnlCrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCrop.Location = new System.Drawing.Point(16, 69);
            this.pnlCrop.Name = "pnlCrop";
            this.pnlCrop.Size = new System.Drawing.Size(298, 145);
            this.pnlCrop.TabIndex = 2;
            // 
            // picCrop
            // 
            this.picCrop.Image = global::ControlCrop.Properties.Resources.Lion1;
            this.picCrop.Location = new System.Drawing.Point(16, 257);
            this.picCrop.Name = "picCrop";
            this.picCrop.Size = new System.Drawing.Size(199, 124);
            this.picCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCrop.TabIndex = 0;
            this.picCrop.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Picturebox Crop  image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Picturebox After Crop  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Display cropped Image from panel in picturebox";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "1)  Move crop handles to desired crop area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "2)  Click the crop button and see results";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Universal Cropping Class\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Adds Cropping ability to control that \r\nhas a image or background image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(363, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Note: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(363, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Right mouse down to drag crop retangle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(363, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Left click and hold to drag rectangle handles";
            // 
            // btnChangeCropColor
            // 
            this.btnChangeCropColor.Location = new System.Drawing.Point(406, 18);
            this.btnChangeCropColor.Name = "btnChangeCropColor";
            this.btnChangeCropColor.Size = new System.Drawing.Size(111, 23);
            this.btnChangeCropColor.TabIndex = 18;
            this.btnChangeCropColor.Text = "Change Crop Color";
            this.btnChangeCropColor.UseVisualStyleBackColor = true;
            this.btnChangeCropColor.Click += new System.EventHandler(this.btnChangeCropColor_Click);
            // 
            // pnlRectangleColor
            // 
            this.pnlRectangleColor.BackColor = System.Drawing.Color.Black;
            this.pnlRectangleColor.Location = new System.Drawing.Point(516, 20);
            this.pnlRectangleColor.Name = "pnlRectangleColor";
            this.pnlRectangleColor.Size = new System.Drawing.Size(34, 20);
            this.pnlRectangleColor.TabIndex = 19;
            // 
            // frmCrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 397);
            this.Controls.Add(this.btnChangeCropColor);
            this.Controls.Add(this.pnlRectangleColor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCropped);
            this.Controls.Add(this.picCroppedPanel);
            this.Controls.Add(this.btnCrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlCrop);
            this.Controls.Add(this.picCrop);
            this.DoubleBuffered = true;
            this.Name = "frmCrop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easily add cropping to any control";
            ((System.ComponentModel.ISupportInitialize)(this.picCropped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCroppedPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCrop;
        private System.Windows.Forms.Panel pnlCrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.PictureBox picCroppedPanel;
        private System.Windows.Forms.PictureBox picCropped;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnChangeCropColor;
        private System.Windows.Forms.Panel pnlRectangleColor;
    }
}


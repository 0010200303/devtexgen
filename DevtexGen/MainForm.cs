using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevtexGen
{
    public partial class mainForm : Form
    {
        #region "Fonts"
        private Font titleFont = null;
        private Font subtitleFont = null;
        #endregion

        #region "Events"
        private void titleInputBox_TextChanged(object sender, EventArgs e) => finalTexture.Refresh();
        private void subtitleInputBox_TextChanged(object sender, EventArgs e) => finalTexture.Refresh();
        private void saveAsPngLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => saveDialog.ShowDialog();
        #endregion
        
        // Compile-time settings
        public const string FONT_FAMILY = "Bahnschrift SemiBold";

        // This method initializes the font in the different sizes.
        public mainForm()
        {
            titleFont = new Font(FONT_FAMILY, 24);
            subtitleFont = new Font(FONT_FAMILY, 14);

            InitializeComponent();
        }

        // This overload just draws the chosen text.
        private void drawText(Graphics gr)
        {
            gr.DrawString(titleInputBox.Text, titleFont, Brushes.White, new Point(6, 11));
            gr.DrawString(subtitleInputBox.Text, subtitleFont, Brushes.White, new Point(8, 44));
        }
        
        // This overload applies a rotation and translation matrix before drawing the chosen text.
        private void drawText(Graphics gr, float angle, float dx, float dy)
        {
            gr.RotateTransform(angle);
            gr.TranslateTransform(dx, dy, MatrixOrder.Append);
            drawText(gr);
            gr.ResetTransform();
        }

        // This draws the background and calls the drawText overloads.
        private void finalTexture_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.template, new Point(0, 0));
            
            drawText(e.Graphics);
            drawText(e.Graphics, 90, 512, 0);
            drawText(e.Graphics, 180, 512, 512);
            drawText(e.Graphics, 270, 0, 512);
        }

        // This method is called upon a save request, it also does error handling.
        private void saveDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(512, 512);
                finalTexture.DrawToBitmap(bitmap, new Rectangle(0, 0, 512, 512));
                bitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                bitmap.Dispose();
            } catch (Exception)
            {
                MessageBox.Show("Unexpected error while saving.\nA corrupted version of the image could have been saved though.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This method disposes the loaded fonts upon a quit event.
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            titleFont.Dispose();
            subtitleFont.Dispose();
        }
    }
}
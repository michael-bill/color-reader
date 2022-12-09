using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorReader
{
    public partial class ColorReader : Form
    {
        public ColorReader()
        {
            InitializeComponent();
        }

        bool stop;
        int area = 3;
        Bitmap bitmap;
        Graphics graphics;

        private void ColorReader_Load(object sender, EventArgs e)
        {
            StyleController.Stylizer(this);
            lblLogo.Font = new Font("Consolas", 16.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            graphics = picPreviewColor.CreateGraphics();
            labelArea.Text = "Size: " + area + " px";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            stop = true;
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(*.txt)|*.txt";
            sfd.FileName = "Color";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                string path = sfd.FileName;
                using (FileStream file = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter stream = new StreamWriter(file))
                    {
                        stream.WriteLine("Color: ");
                        stream.WriteLine(txtRGB.Text);
                        stream.WriteLine(txtHEX.Text);
                        stream.WriteLine(txtDEC.Text);
                    }
                }
            }
        }

        private void btnSelectNewColor_Click(object sender, EventArgs e)
        {
            CursorPositionListner();
            btnSelectNewColor.Enabled = false;
            btnSaveToFile.Enabled = false;
            picCurrentColor.Select();
        }

        async private void CursorPositionListner()
        {
            stop = false;
            while (!stop)
            {
                int x = Cursor.Position.X, y = Cursor.Position.Y;
                bitmap = new Bitmap(picPreviewColor.Width, picPreviewColor.Height);
                graphics = Graphics.FromImage(bitmap);
                int bitmapX = x - (picPreviewColor.Width / 2), bitmapY = y - (picPreviewColor.Height / 2);
                graphics.CopyFromScreen(new Point(bitmapX, bitmapY), Point.Empty, picPreviewColor.Size);
                Color color;
                if (area == 1)
                {
                    color = bitmap.GetPixel(
                            (picPreviewColor.Width / 2) - (area / 2),
                            (picPreviewColor.Height / 2) - (area / 2));
                }
                else
                {
                    double[] averageColor = new double[] { 0, 0, 0 };
                    for (int i = 0; i < area; i++)
                    {
                        for (int j = 0; j < area; j++)
                        {
                            Color c = bitmap.GetPixel(
                                (picPreviewColor.Width / 2) - (area / 2) + i,
                                (picPreviewColor.Height / 2) - (area / 2) + j);
                            averageColor[0] += c.R;
                            averageColor[1] += c.G;
                            averageColor[2] += c.B;
                        }
                    }
                    for (int i = 0; i < 3; i++)
                        averageColor[i] /= area * area;
                    color = Color.FromArgb(
                        (int)averageColor[0],
                        (int)averageColor[1],
                        (int)averageColor[2]);
                }

                graphics.DrawRectangle(
                        new Pen(Color.Red, 1f),
                        (picPreviewColor.Width / 2) - (area / 2) - 1,
                        (picPreviewColor.Height / 2) - (area / 2) - 1,
                        area + 1,
                        area + 1);

                picPreviewColor.Image = bitmap;

                byte[] rgb = new byte[] { color.R, color.G, color.B };
                picCurrentColor.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
                txtRGB.Text = "RGB: " + MainController.GetRGBText(rgb);
                txtHEX.Text = "HEX: " + MainController.GetHEXText(rgb);
                txtDEC.Text = "DEC: " + int.Parse(MainController.GetHEXText(rgb), System.Globalization.NumberStyles.HexNumber);

                if (MainController.GetAsyncKeyState((int)Keys.Enter) != 0)
                {
                    stop = true;
                    btnSelectNewColor.Enabled = true;
                    btnSaveToFile.Enabled = true;
                }
                await Task.Delay(20);
            }
        }


        private void pictureBoxSizeDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (area > 1 && !stop)
            {
                area -= 2;
                labelArea.Text = "Size: " + area + " px";
            }
        }

        private void pictureBoxSizeUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (area < 49 && !stop)
            {
                area += 2;
                labelArea.Text = "Size: " + area + " px";
            }
        }
    }
}

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorReader
{
    class StyleController
    {
        public static void Stylizer(Form form)
        {
            form.Controls["picCurrentColor"].Select();
            form.FormBorderStyle = FormBorderStyle.None;
            form.BackColor = Color.White;
            foreach (Control control in form.Controls)
            {
                control.Font = new Font("Consolas", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                if (control is Button)
                {
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                    ((Button)control).Cursor = Cursors.Hand;
                }
                else if (control is TextBox)
                {
                    //((TextBox)control).BorderStyle = BorderStyle.None;
                    ((TextBox)control).ReadOnly = true;
                    ((TextBox)control).BackColor = form.BackColor;
                }
            }
            GraphicsPath RoundedRect(Rectangle baseRect, int radius)
            {
                var diameter = radius * 2;
                var sz = new Size(diameter, diameter);
                var arc = new Rectangle(baseRect.Location, sz);
                var path = new GraphicsPath();
                path.AddArc(arc, 180, 90);
                arc.X = baseRect.Right - diameter;
                path.AddArc(arc, 270, 90);
                arc.Y = baseRect.Bottom - diameter;
                path.AddArc(arc, 0, 90);
                arc.X = baseRect.Left;
                path.AddArc(arc, 90, 90);
                path.CloseFigure();
                return path;
            }
            form.Region = new Region(RoundedRect(new Rectangle(0, 0, form.Width, form.Height), 10));
            bool mouseDown = false;
            int xOff = 0, yOff = 0;
            form.MouseDown += (sender, e) => {
                form.Controls["picCurrentColor"].Select();
                mouseDown = true;
                xOff = e.Location.X;
                yOff = e.Location.Y;
            };
            form.MouseMove += (sender, e) =>
            {
                if (mouseDown)
                {
                    form.Location = new Point(Cursor.Position.X - xOff, Cursor.Position.Y - yOff);
                }
            };
            form.MouseUp += (sender, e) =>
            {
                mouseDown = false;
            };
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Youtube_Desktop_Downloader
{
    public class CustomProgressBar : ProgressBar
    {
        public Color BarColor { get; set; } = Color.Blue;
        public int CornerRadius { get; set; } = 10;

        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle fullRect = this.ClientRectangle;
            fullRect.Inflate(-1, -1); // dla ramki

            // Tło (obrys)
            using (GraphicsPath backgroundPath = RoundedRect(fullRect, CornerRadius))
            using (Pen borderPen = new Pen(Color.Gray, 1))
            {
                g.DrawPath(borderPen, backgroundPath);
            }

            // Pasek postępu
            if (this.Value > 0)
            {
                double scale = (double)this.Value / this.Maximum;
                Rectangle progressRect = new Rectangle(
                    fullRect.X,
                    fullRect.Y,
                    (int)(fullRect.Width * scale),
                    fullRect.Height);

                using (GraphicsPath progressPath = RoundedRect(progressRect, CornerRadius))
                using (SolidBrush brush = new SolidBrush(BarColor))
                {
                    g.FillPath(brush, progressPath);
                }
            }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }


}
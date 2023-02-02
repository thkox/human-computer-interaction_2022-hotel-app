using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Custom_Toolbox
{
    public partial class ChatRichTextBox : UserControl
    {

        public ChatRichTextBox()
        {
            InitializeComponent();
        }
        
        private int _radius = 5;
        private Color _shadeColor = Color.White;

        public System.Drawing.Size RichTextBoxSize
        {
            get => richTextBox1.Size;
            set => richTextBox1.Size = value;
        }
        public Point RichTextBoxLocation
        {
            get => richTextBox1.Location;
            set
            {
                richTextBox1.Location = value;
            }
        }

        public string Text
        {
            get => richTextBox1.Text;
            set => richTextBox1.Text = value;
        }

        public int Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                Invalidate();
            }
        }

        public Color ShadeColor
        {
            get => _shadeColor;
            set
            {
                _shadeColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (SolidBrush brush = new SolidBrush(ShadeColor))
            {
                Rectangle r = new Rectangle(0, 0, Width - 1, Height - 1);
                g.FillPath(brush, GetRoundedRectangle(r, Radius));
            }

            using (Pen pen = new Pen(Color.Black))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                Rectangle r = new Rectangle(0, 0, Width - 1, Height - 1);
                g.DrawPath(pen, GetRoundedRectangle(r, Radius));
            }

            base.OnPaint(e);
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            // top left arc
            path.AddArc(arc, 180, 90);

            // top right arc
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}

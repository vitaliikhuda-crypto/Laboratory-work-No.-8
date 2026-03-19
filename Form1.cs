using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory-work-No.-8
    
{
    public partial class Form1 : Form
    {
        bool dragging = false;
        Point dragCursorPoint;
        Point dragLabelPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragLabelPoint = label1.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                label1.Location = Point.Add(dragLabelPoint, new Size(diff));
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

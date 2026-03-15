using System;
using System.Drawing;
using System.Windows.Forms;

namespace dz
{
    public partial class Form1 : Form
    {
        bool dragging = false;
        Point offset;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                label1.Left = label1.Left + e.X - offset.X;
                label1.Top = label1.Top + e.Y - offset.Y;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

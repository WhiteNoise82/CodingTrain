using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 800;
            this.BackColor = Color.Black;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // draw in the form
            Draw(e.Graphics, 100); // a cube of 100 pixs wide
        }
        public void Draw(Graphics G, int width)
        {
            int height = 100; // height of the cube (y-axis)
            int skew = 50;
            Point Org = new Point(100, 100);
            Pen pencil = new Pen(Color.White, 1f);
            Rectangle R = new Rectangle(Org.X, Org.Y, width, height);
            G.DrawRectangle(pencil, R);
            G.DrawLine(pencil, Org.X, Org.Y, Org.X + skew, Org.Y - skew);
            G.DrawLine(pencil, Org.X + skew, Org.Y - skew, Org.X + width + skew, Org.Y - skew);
            // continue with DrawLine here to finish it
        }
    }
}

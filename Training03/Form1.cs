using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Training03
{
    public partial class Form1 : Form
    {
        Bitmap DrawArea;
        int[] X;
        int[] Y;
        int Radius;
        int Frequence = 255;
        int MaxRadius;
        int MinRadius;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 800;
            DrawArea = new Bitmap(picBox.Width, picBox.Height);
            this.picBox.BackColor = Color.Black;
            timer1.Enabled = false;
            
        }

        public void Circle()
        {
            X = new int[Frequence];
            Y = new int[Frequence];

            for (int i = 0; i < X.Length; i++)
            {
                Radius = rand.Next(150,200);
                X[i] = (int)(Radius * Math.Cos(i * 2 * Math.PI / Frequence) + picBox.Width / 2);
                Y[i] = (int)(Radius * Math.Sin(i * 2 * Math.PI / Frequence) + picBox.Height / 2);

            }

            
        }

        public void Line(Graphics graphics)
        {
            Pen pen = new Pen(Color.White);

            for(int i = 0; i < X.Length; i++)
            {
                if (i == 0)
                    graphics.DrawLine(pen, X[X.Length - 1], Y[Y.Length - 1], X[i], Y[i]);                
                else
                    graphics.DrawLine(pen, X[i - 1], Y[i - 1], X[i], Y[i]);
            }
            picBox.Image = DrawArea;
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Circle();
            Graphics graphics = Graphics.FromImage(DrawArea);
            graphics.Clear(Color.Black);
            Line(graphics);
            graphics.Dispose();
        }
    }
}

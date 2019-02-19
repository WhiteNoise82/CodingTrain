using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training01Answer
{
    public partial class Form1 : Form
    {
        Star[] stars = new Star[400];

        public Form1()
        {
            InitializeComponent();
            this.Width = 600;
            this.Height = 600;
            this.BackColor = Color.Black;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length; i++)
                stars[i] = new Star();

        }

        void Draw()
        {
            Graphics graphics = CreateGraphics();
            graphics.Clear(Color.Black);
            SolidBrush brush = new SolidBrush(Color.White);
            graphics.FillEllipse(brush, 0, 0, 20, 20);

            // Draw all stars wrt center of screen
            translate(0.5 * width, 0.5 * height);

            // Update and draw all stars
            for (int i = 0; i < stars.length; i++)
            {
                stars[i].update();
                stars[i].draw();
            }

        }

        public void draw()
        {
            // Project star only viewport
            float offsetX = 100.0f * (x / z);
            float offsetY = 100.0f * (y / z);
            float scaleZ = 0.0001f * (2000.0f - z);

            // Draw this star


            pushMatrix();
            translate(offsetX, offsetY);
            scale(scaleZ);
            ellipse(0, 0, 20, 20);
            popMatrix();
        }


    }

    class Star
    {
        // Star coordinates in 3D
        float x;
        float y;
        float z;

        static Random rand = new Random();

        public Star()
        {
            this.x = rand.Next(-5000, 5000);
            this.y = rand.Next(-5000, 5000);
            this.z = rand.Next(0, 2000);
        }

        public void update()
        {
            z -= 10;        // Move star closer to viewport
            if (z <= 0.0) // Reset star if it passes viewport
                reset();
        }

        public void reset()
        {
            // Reset star to a position far away
            this.x = rand.Next(-5000, 5000);
            this.y = rand.Next(-5000, 5000);
            this.z = 2000.0f;
        }

    }
}

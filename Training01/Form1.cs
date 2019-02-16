using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Training01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(415, 440);
            this.BackColor = Color.Black;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ArrayList stars = new ArrayList();
            Graphics graphics = CreateGraphics();

            for(int i = 0; i < 10; i++)
            {
                Star star = new Star(400, 400);
                SolidBrush brush = new SolidBrush(Color.White);
                graphics.FillEllipse(brush, star.starX, star.starY, star.starWidth, star.starHeight);

                //stars.Add(star);
            }
            graphics.Dispose();

            


        }

        public void MakeStars()
        {
        }

    }
}

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

using System.Threading;

namespace Training01
{
    public partial class Form1 : Form
    {
        Bitmap DrawArea;
        List<Rectangle> stars = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(picBox.Size.Width, picBox.Size.Height);
            picBox.Image = DrawArea;
        }
        //화면의 중심을 기준으로 방사형으로 움직임

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(DrawArea);

            for (int i = 0; i < 100; i++)
            {
                Star star = new Star(picBox.Width, picBox.Height, i);

                stars.Add(star.starRect);
                SolidBrush brush = new SolidBrush(Color.White);
                graphics.FillEllipse(brush, star.starRect);
                picBox.Image = DrawArea;
            }
            graphics.Dispose();
        }

        private void MenuStart_Click(object sender, EventArgs e)
        {
            foreach (Rectangle i in stars)
            {

            }
        }
    }
}

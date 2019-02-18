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
        bool Start = false;
        bool Stop = true;
        int NumberOfStars = 5;
        Bitmap DrawArea;
        Star star;
        //List<Rectangle> stars = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(picBox.Size.Width, picBox.Size.Height);
            picBox.Image = DrawArea;
            
        }
        //화면의 중심을 기준으로 방사형으로 움직임

        private void Form1_Shown(object sender, EventArgs e)
        {
            star = new Star(picBox.Width, picBox.Height, NumberOfStars);
            //Graphics graphics = Graphics.FromImage(DrawArea);
            //SolidBrush brush = new SolidBrush(Color.White);

            //for (int i = 0; i < NumberOfStars; i++)
            //{

            //    //stars.Add(star.starRect);
            //    graphics.FillEllipse(brush, star.starRect[i]);
            //    picBox.Image = DrawArea;
            //}
            //graphics.Dispose();
        }

        private void MenuStart_Click(object sender, EventArgs e)
        {
            Start = true;
            Stop = false;
            StarsMove(Stop);
        }

        private void MenuStop_Click(object sender, EventArgs e)
        {
            Start = false;
            Stop = true;
        }

        private void StarsMove(bool stop)
        {
            picBox.Image = null;
            
            for (int i = 0; i < NumberOfStars; i++)
            {
                star.starX[i] = star.starX[i] / 2 + 1;
                star.starY[i] += star.starY[i] / 2 + 1;
            }

            Graphics graphics = Graphics.FromImage(DrawArea);
            SolidBrush brush = new SolidBrush(Color.White);

            for (int i = 0; i < NumberOfStars; i++)
            {

                //stars.Add(star.starRect);
                graphics.FillEllipse(brush, star.starX[i], star.starY[i], star.starWidth[i], star.starHeight[i]);
                picBox.Image = DrawArea;
            }
            graphics.Dispose();

            Thread.Sleep(10);

            
        }
    }
}

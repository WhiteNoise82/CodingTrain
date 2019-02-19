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
        
        int NumberOfStars = 1000;
        Bitmap DrawArea;
        Star star;
        //List<Rectangle> stars = new List<Rectangle>();
        int picWidth;
        int picHeight;
        static Random rand = new Random();
        int starMinSize = 0;
        int starMaxSize = 5;
        int Speed = 100;



        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(picBox.Size.Width, picBox.Size.Height);
            picBox.Image = DrawArea;
            
        }

        

        //화면의 중심을 기준으로 방사형으로 움직임

        private void Form1_Shown(object sender, EventArgs e)
        {
            star = new Star(starMinSize, starMaxSize, picBox.Width, picBox.Height, picBox.Width / 2, NumberOfStars);
            picWidth = picBox.Width;
            picHeight = picBox.Height;

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
            
            timer1.Enabled = true;
                
        }

        private void MenuStop_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = false;
        }

        private void StarsMove()
        {
            Graphics graphics = Graphics.FromImage(DrawArea);
            graphics.Clear(Color.Black);
            SolidBrush brush = new SolidBrush(Color.White);
            
            for (int i = 0; i < NumberOfStars; i++)
            {
                
                double Scale = 0.0003 * ((picBox.Width / 4) - star.starZ[i]);

                star.starWidth[i] += Scale; /*(Math.Abs(star.starX[i]) * Math.Abs(star.starY[i]) / picWidth / picWidth);*/
                star.starHeight[i] = star.starWidth[i];
                double absStarX = Math.Abs(star.starX[i]);
                double absStarY = Math.Abs(star.starY[i]);

                //if (star.starX[i] >= 0) { star.starX[i] = star.starX[i] + (Square(star.starX[i]) / Square(picWidth)) * Speed; }
                //else { star.starX[i] = star.starX[i] - (Square(star.starX[i]) / Square(picWidth)) * Speed; }

                //if (star.starY[i] >= 0) { star.starY[i] = star.starY[i] + (Square(star.starY[i]) / Square(picHeight)) * Speed; }
                //else { star.starY[i] = star.starY[i] - (Square(star.starY[i]) / Square(picHeight)) * Speed; }


                if (star.starX[i] >= 0) { star.starX[i] = star.starX[i] + (100*star.starX[i] / star.starZ[i]) / Speed; }
                else { star.starX[i] = star.starX[i] + (100 * star.starX[i] / star.starZ[i]) / Speed; }

                if (star.starY[i] >= 0) { star.starY[i] = star.starY[i] + (100 * star.starY[i] / star.starZ[i]) / Speed; }
                else { star.starY[i] = star.starY[i] + (100 * star.starY[i] / star.starZ[i]) / Speed; }


                //star.starX[i] = star.starX[i] * Speed * star.starX[i] / star.starZ[i];
                //star.starY[i] = star.starY[i] * Speed * star.starY[i] / star.starZ[i];
                //star.starZ[i] *= Scale;

                if (((star.starX[i] <= -picWidth / 2) || (star.starX[i]) >= picWidth / 2)
                    || ((star.starY[i] <= -picHeight / 2) || (star.starY[i]) >= picHeight / 2) || star.starZ[i] <= 0)
                {
                    star.starX[i] = rand.Next(-picWidth / 2, picWidth / 2);
                    star.starY[i] = rand.Next(-picHeight / 2, picHeight / 2);
                    star.starWidth[i] = 0/*rand.Next(starMinSize, starMaxSize)*/;
                    star.starHeight[i] = star.starWidth[i];
                    star.starZ[i] = rand.Next(0, picBox.Width / 4);
                }

                star.starRect[i].X = (int)star.starX[i] + (picWidth / 2);
                star.starRect[i].Y = (int)star.starY[i] + (picHeight / 2);
                star.starRect[i].Width = (int)star.starWidth[i];
                star.starRect[i].Height = (int)star.starHeight[i];
                star.starZ[i] -= 1;

                graphics.FillEllipse(brush, star.starRect[i]);
            }
            picBox.Image = DrawArea;
            graphics.Dispose();
            Thread.Sleep(Speed);

                


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StarsMove();
        }

        private double Qubic(double nums)
        {
            return  nums * nums * nums;
        }

        private double Square(double nums)
        {
            return nums * nums;
        }

        private double Translate(double nums)
        {
            return nums - (picBox.Width / 2);
        }

        private void SpeedUp_Click(object sender, EventArgs e)
        {
            Speed -= 10;
            //NumberOfStars += 1000;
            //star = new Star(starMinSize, starMaxSize, picBox.Width, picBox.Height, picBox.Width / 2, NumberOfStars);

        }

        private void SpeedDown_Click(object sender, EventArgs e)
        {
            Speed += 10;
            //NumberOfStars -= 1000;
            //star = new Star(starMinSize, starMaxSize, picBox.Width, picBox.Height, picBox.Width / 2, NumberOfStars);

        }
    }
}

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
        int Speed = 3;



        public Form1()
        {
            InitializeComponent();
            this.picBox.Image = DrawArea;
            this.Width = 1200;
            this.Height = 1200;
            this.picWidth = picBox.Width;
            this.picHeight = picBox.Height;
            DrawArea = new Bitmap(picBox.Size.Width, picBox.Size.Height);
            
        }

        

        //화면의 중심을 기준으로 방사형으로 움직임

        private void Form1_Shown(object sender, EventArgs e)
        {
            star = new Star(starMinSize, starMaxSize, picBox.Width, picBox.Height, picBox.Width / 4 - 100, NumberOfStars);
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

        private void StarsMove(Graphics graphics)
        {
            float colerGain = 1.3f;
            float scaleGain = 0.0001f;
            int initialStarZ = picWidth / 4 - 100;
            int halfPicWidth = picWidth / 2;
            int halfPicHeight = picHeight / 2;



            for (int i = 0; i < NumberOfStars; i++)
            {
                int colorBit = (int)(255 * colerGain * (1 - star.StarZ[i] / initialStarZ));
                if (colorBit > 255) colorBit = 255;
                else if(colorBit < 0) colorBit = 0;
                
                SolidBrush brush = new SolidBrush(Color.FromArgb(colorBit, Color.White));

                float Scale = scaleGain * ((halfPicWidth) - star.StarZ[i]);

                star.StarWidth[i] += Scale; 
                star.StarHeight[i] += Scale;

                if (((star.StarX[i] <= -halfPicWidth) || (star.StarX[i]) >= halfPicWidth)
                    || ((star.StarY[i] <= -halfPicHeight) || (star.StarY[i]) >= halfPicHeight) || star.StarZ[i] <= 0)
                {
                    star.StarX[i] = rand.Next(-halfPicWidth, halfPicWidth);
                    star.StarY[i] = rand.Next(-halfPicHeight, halfPicHeight);
                    star.StarWidth[i] = 0;
                    star.StarHeight[i] = star.StarWidth[i];
                    star.StarZ[i] = initialStarZ;
                }

                star.StarX[i] += StarOffsetX(i, Scale, Speed);
                star.StarY[i] += StarOffsetY(i, Scale, Speed);



                star.StarRect[i].X = (int)(star.StarX[i] + (halfPicWidth));
                star.StarRect[i].Y = (int)(star.StarY[i] + (halfPicHeight));
                star.StarRect[i].Width = (int)star.StarWidth[i];
                star.StarRect[i].Height = (int)star.StarHeight[i];
                star.StarZ[i] -= 1;

                graphics.FillEllipse(brush, star.StarRect[i]);
            }
            picBox.Image = DrawArea;
            

                


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(DrawArea);
            graphics.Clear(Color.Black);
            StarsMove(graphics);
            graphics.Dispose();
        }
        
        private void SpeedUp_Click(object sender, EventArgs e)
        {
            Speed--;

        }

        private void SpeedDown_Click(object sender, EventArgs e)
        {
            Speed++;

        }

        public float StarOffsetX(int i, float Scale, int Speed)
        {
            float offsetXVal = ((star.StarWidth[i] - Scale) * star.StarX[i] / star.StarZ[i]) / Speed;
            return offsetXVal;
        }

        public float StarOffsetY(int i, float Scale, int Speed)
        {
            float offsetYVal = ((star.StarHeight[i] - Scale) * star.StarY[i] / star.StarZ[i]) / Speed;
            return offsetYVal;
        }
    }
}

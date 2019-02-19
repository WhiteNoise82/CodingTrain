using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Training01
{
    public class Star
    {
        private int _NumberOfStars;
        private int[] _StarWidth;
        private int[] _StarHeight;
        private double[] _StarX;
        private double[] _StarY;

        private Rectangle[] _StarRect;
        static Random rand = new Random();

        public Star(int starMaXSize, int starMinSize, int formWidth, int formHeight, int numberOfStars)
        {
            this._NumberOfStars = numberOfStars;

            this._StarWidth = new int[numberOfStars];
            this._StarHeight = new int[numberOfStars];
            this._StarX = new double[numberOfStars];
            this._StarY = new double[numberOfStars];
            this._StarRect = new Rectangle[numberOfStars];

            int width = formWidth / 2;
            int height = formHeight / 2;

            for (int i = 0; i < _NumberOfStars; i++)
            {
                this._StarWidth[i] = rand.Next(starMinSize, starMaXSize);
                this._StarHeight[i] = rand.Next(starMinSize, starMaXSize);
                //this.StarX = (int)(rand.NextDouble() * formWidth);
                //this.StarY = (int)(rand.NextDouble() * formHeight);            
                this._StarX[i] = rand.Next(-width, width);
                this._StarY[i] = rand.Next(-height, height);

                this._StarRect[i] = new Rectangle((int)_StarX[i], (int)_StarY[i], _StarHeight[i], _StarWidth[i]);

            }
            
        }

        public int[] starWidth
        {
            get { return _StarWidth; }
        }

        public int[] starHeight
        {
            get { return _StarHeight; }
        }
        
        public double[] starX
        {
            get { return _StarX; }
        }

        public double[] starY
        {
            get { return _StarY; }
        }

        public Rectangle[] starRect
        {
            get { return _StarRect; }
            set { _StarRect = value; }
        }
    }
}

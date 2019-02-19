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
        private double[] _StarWidth;
        private double[] _StarHeight;
        private double[] _StarX;
        private double[] _StarY;
        private double[] _StarZ;

        private Rectangle[] _StarRect;
        static Random rand = new Random();

        public Star(int starMinSize, int starMaXSize, int formWidth, int formHeight, int depth, int numberOfStars)
        {
            this._NumberOfStars = numberOfStars;

            this._StarWidth = new double[numberOfStars];
            this._StarHeight = new double[numberOfStars];
            this._StarX = new double[numberOfStars];
            this._StarY = new double[numberOfStars];
            this._StarZ = new double[numberOfStars];
            this._StarRect = new Rectangle[numberOfStars];

            int width = formWidth / 2;
            int height = formHeight / 2;

            for (int i = 0; i < _NumberOfStars; i++)
            {
                this._StarWidth[i] = rand.Next(starMinSize, starMaXSize);
                this._StarHeight[i] = _StarWidth[i]; //rand.Next(starMinSize, starMaXSize);
                //this.StarX = (int)(rand.NextDouble() * formWidth);
                //this.StarY = (int)(rand.NextDouble() * formHeight);            
                this._StarX[i] = rand.Next(-width, width);
                this._StarY[i] = rand.Next(-height, height);
                this._StarZ[i] = rand.Next(0, depth);

                this._StarRect[i] = new Rectangle((int)_StarX[i], (int)_StarY[i], (int)_StarHeight[i], (int)_StarWidth[i]);

            }
            
        }

        public double[] starWidth
        {
            get { return _StarWidth; }
            set { _StarWidth = value; }
        }

        public double[] starHeight
        {
            get { return _StarHeight; }
            set { _StarHeight = value; }
        }
        
        public double[] starX
        {
            get { return _StarX; }
            set { _StarY = value; }
        }

        public double[] starY
        {
            get { return _StarY; }
            set { _StarY = value; }
        }

        public double[] starZ
        {
            get { return _StarZ; }
            set { _StarZ = value; }
        }

        public Rectangle[] starRect
        {
            get { return _StarRect; }
            set { _StarRect = value; }
        }
    }
}

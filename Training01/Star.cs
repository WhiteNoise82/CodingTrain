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
        private float[] _StarWidth;
        private float[] _StarHeight;
        private float[] _StarX;
        private float[] _StarY;
        private float[] _StarZ;

        private Rectangle[] _StarRect;
        static Random rand = new Random();

        public Star(int starMinSize, int starMaXSize, int formWidth, int formHeight, int depth, int numberOfStars)
        {
            this._NumberOfStars = numberOfStars;

            this._StarWidth = new float[numberOfStars];
            this._StarHeight = new float[numberOfStars];
            this._StarX = new float[numberOfStars];
            this._StarY = new float[numberOfStars];
            this._StarZ = new float[numberOfStars];
            this._StarRect = new Rectangle[numberOfStars];

            int width = formWidth / 2;
            int height = formHeight / 2;

            for (int i = 0; i < _NumberOfStars; i++)
            {
                this._StarWidth[i] = rand.Next(starMinSize, starMaXSize);
                this._StarHeight[i] = _StarWidth[i];           
                this._StarX[i] = rand.Next(-width, width);
                this._StarY[i] = rand.Next(-height, height);
                this._StarZ[i] = rand.Next(0, depth);

                this._StarRect[i] = new Rectangle((int)_StarX[i], (int)_StarY[i], (int)_StarHeight[i], (int)_StarWidth[i]);

            }
            
        }

        public float[] StarWidth
        {
            get { return _StarWidth; }
            set { _StarWidth = value; }
        }

        public float[] StarHeight
        {
            get { return _StarHeight; }
            set { _StarHeight = value; }
        }
        
        public float[] StarX
        {
            get { return _StarX; }
            set { _StarY = value; }
        }

        public float[] StarY
        {
            get { return _StarY; }
            set { _StarY = value; }
        }

        public float[] StarZ
        {
            get { return _StarZ; }
            set { _StarZ = value; }
        }

        public Rectangle[] StarRect
        {
            get { return _StarRect; }
            set { _StarRect = value; }
        }
    }
}

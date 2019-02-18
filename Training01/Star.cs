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
        private int[] _StarX;
        private int[] _StarY;
        private Rectangle[] _StarRect;
        static Random rand = new Random();

        public Star(int formWidth, int formHeight, int numberOfStars)
        {
            this._NumberOfStars = numberOfStars;

            this._StarWidth = new int[numberOfStars];
            this._StarHeight = new int[numberOfStars];
            this._StarX = new int[numberOfStars];
            this._StarY = new int[numberOfStars];
            this._StarRect = new Rectangle[numberOfStars];

            for (int i = 0; i < _NumberOfStars; i++)
            {
                this._StarWidth[i] = rand.Next(5, 8);
                this._StarHeight[i] = rand.Next(5,8);
                //this.StarX = (int)(rand.NextDouble() * formWidth);
                //this.StarY = (int)(rand.NextDouble() * formHeight);            
                this._StarX[i] = rand.Next(0, formWidth);
                this._StarY[i] = rand.Next(0, formHeight);

                this._StarRect[i] = new Rectangle(_StarX[i], _StarY[i], _StarHeight[i], _StarWidth[i]);

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
        
        public int[] starX
        {
            get { return _StarX; }
        }

        public int[] starY
        {
            get { return _StarY; }
        }

        public Rectangle[] starRect
        {
            get { return _StarRect; }
        }
    }
}

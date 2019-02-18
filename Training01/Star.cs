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
        private int StarWidth;
        private int StarHeight;
        private int StarX;
        private int StarY;
        private Rectangle StarRect;
        static Random rand = new Random();

        public Star(int formWidth, int formHeight, int seed)
        {            
            this.StarHeight = rand.Next(5,8);
            this.StarWidth = rand.Next(5, 8);
            //this.StarX = (int)(rand.NextDouble() * formWidth);
            //this.StarY = (int)(rand.NextDouble() * formHeight);            
            this.StarX = rand.Next(0, formWidth);
            this.StarY = rand.Next(0, formHeight);

            this.StarRect = new Rectangle(StarX, StarY, StarHeight, StarWidth);
            
        }

        public int starWidth
        {
            get { return StarWidth; }
        }

        public int starHeight
        {
            get { return StarHeight; }
        }
        
        public int starX
        {
            get { return StarX; }
        }

        public int starY
        {
            get { return StarY; }
        }

        public Rectangle starRect
        {
            get { return StarRect; }
        }
    }
}

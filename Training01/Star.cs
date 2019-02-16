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

        public Star(int formWidth, int formHeight)
        {
            Random rand = new Random();
            this.StarHeight = rand.Next(2, 8);
            this.StarWidth = rand.Next(2, 8);
            //this.StarX = (int)(rand.NextDouble() * formWidth);
            //this.StarY = (int)(rand.NextDouble() * formHeight);            
            this.StarX = rand.Next(0, 400);
            this.StarY = rand.Next(0, 400);
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
    }
}

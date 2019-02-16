using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training01
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Star
    {
        private int StarWidth;
        private int StarHeight;
        private int StarX;
        private int StarY;

        public Star(int formWidth, int formHeight)
        {
            Random rand = new Random();
            this.StarHeight = rand.Next(2,20);
            this.StarWidth = rand.Next(2,20);
            this.StarX = (int)rand.NextDouble() * formWidth;
            this.StarY = (int)rand.NextDouble() * formHeight;
        }

        //public int StarWidth
        //{
        //    get { return starWidth; }
        //}

        //public int StarHeight
        //{
        //    get { return starHeight; }
        //}

        public void MakeStar(int formWidth, int formHeight)
        {

        }
    }
}

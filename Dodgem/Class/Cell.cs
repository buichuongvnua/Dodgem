using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodgem.Class
{
    class Cell:PictureBox
    {
        private int X;
        private int Y;
        private char Status;
        private bool Selected;

        public Cell(char type, int x, int y)
        {
            Status = type;
            X = x;
            Y = y;     
        }
        public StatusBar(char type)
        {

        }


    }
}

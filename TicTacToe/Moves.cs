using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Web;
using System.Net;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    //
    public struct Moves
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool isX { get; set; }
        public string text { get; set; }
        public Moves(int x, int y,bool isX)
            : this()
        {
            this.x = x;
            this.y = y;
            if (isX)
            {
                this.isX = true;
                this.text = "X";
            }
            else
            {
                this.isX = false;
                this.text = "O";
            }
        }

    }
}
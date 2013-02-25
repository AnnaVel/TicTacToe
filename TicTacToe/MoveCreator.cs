using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Web;
using System.Net;
using System.Linq;
using System.Text;
using TicTacToe;

namespace TicTacToe
{
    //
    public class MoveCreator
    {
        public  bool isX { get; set; }
        public  MoveCreator(bool isX)
        {
            if (isX)
            {
                this.isX = true;
            }
            else
            {
                this.isX = false;
            }
        }
        public Moves CreateMove(int x,int y)
        {
            Moves newMove = new Moves(x, y, isX);
            return newMove;
        }
    }
}
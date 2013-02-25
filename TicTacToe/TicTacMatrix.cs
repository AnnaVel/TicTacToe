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
    public class TicTacMatrix<Moves>
    {
        public Moves[,] elements;

        public TicTacMatrix()
        {
            elements = new Moves[3, 3];
        }
        public void insertAt(int x, int y,Moves move)
        {
            elements[x, y] = move;
        }

        public Moves this[int x, int y]
        {
            get
            {
                return elements[x, y];
            }
            set
            {
                elements[x, y] = value;
            }
        }
        public void ClearMatrix()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    this.elements[x, y] = default(Moves);
                }
            }
        }
    }
}
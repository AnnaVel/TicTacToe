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
    public static class CheckForWinner
    {
        private static TicTacMatrix<Moves> Matrix { get; set; }
        private static int X { get; set; }
        private static int Y { get; set; }
        private static string Symbol { get; set; }
        public static bool isWinning { get; private set; }
        public static bool DoCheck(int x, int y,TicTacMatrix<Moves> matrix,string symbol)
        {
            isWinning = false;
            Matrix = matrix;
            X = x;
            Y = y;
            Symbol = symbol;
            if (X == 0 && Y == 0)
            {
                bool right = CheckRight();
                bool down = CheckDown();
                bool rightDown = RightDownDiagonal();
                if (right)return true;
                else if (down)return true;
                else if (rightDown)return true;                
            }
            else if (X == 1 && Y == 0)
            {
                bool right = CheckRight();
                bool down = CheckDown();
                bool up = CheckUp();
                if (right) return true;
                else if (up && down) return true;
            }
            else if (X == 2 && Y == 0)
            {
                bool up = CheckUp();
                bool rightUp = RightUpDiagonal();
                bool right = CheckRight();
                if (up) return true;
                else if (right) return true;
                else if (rightUp) return true;
            }
            else if (X == 0 && Y == 1)
            {
                bool right = CheckRight();
                bool left = CheckLeft();
                bool down = CheckDown();
                if (right && left) return true;
                else if (down) return true;
            }
            else if (X == 0 && Y == 2)
            {
                bool left = CheckLeft();
                bool down = CheckDown();
                bool leftDown = LeftDownDiagonal();
                if (left) return true;
                else if (down) return true;
                else if (leftDown) return true;
            }
            else if (X == 1 && Y == 1)
            {
                bool left = CheckLeft();
                bool down = CheckDown();
                bool up = CheckUp();
                bool right = CheckRight();
                bool leftDown = LeftDownDiagonal();
                bool rightDown = RightDownDiagonal();
                bool leftUp = LeftUpDiagonal();
                bool rightUp = RightUpDiagonal();
                if (up && down) return true;
                else if (right && left) return true;
                else if (leftDown && rightUp) return true;
                else if (rightDown && leftUp) return true;
            }
            else if (X == 1 && Y == 2)
            {
                bool left = CheckLeft();
                bool up = CheckUp();
                bool down = CheckDown();
                if (left) return true;
                else if (up && down) return true;
            }
            else if (X == 2 && Y == 1)
            {
                bool up = CheckUp();
                bool right = CheckRight();
                bool left = CheckLeft();
                if (up) return true;
                else if (right && left) return true;                
            }
            else if (X == 2 && Y == 2)
            {
                bool left = CheckLeft();
                bool up = CheckUp();
                bool leftUp = LeftUpDiagonal();
                if (left) return true;
                else if (up) return true;
                else if (leftUp) return true;
            }
            return false;

        }
        private static bool LeftUpDiagonal()
        {
            int y = Y;
            for (int x = X; x >= 0; x--)
            {
                
                if (Matrix[x, y].text == Symbol)
                {
                    y--;
                    continue;
                }
                else
                {
                    return false;
                }
                
                
            }
            return true;
        }
        private static bool RightDownDiagonal()
        {
            int y = Y;
            for (int x = X; x < 3; x++)
            {
                
                if (Matrix[x, y].text == Symbol)
                {
                    y++;
                    continue;
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }
        private static bool RightUpDiagonal()
        {
            int y = Y;
            for (int x = X; x >= 0; x--)
            {
                
                if (Matrix[x, y].text == Symbol)
                {
                    y++;
                    continue;
                }
                else
                {
                    return false;
                }
               
            }
            return true;
        }
        private static bool LeftDownDiagonal()
        {
            int y = Y;
            for (int x = X; x < 3; x++)
            {
                
                if (Matrix[x,y].text == Symbol)
                {
                    y--;
                    continue;
                }
                else
                {
                    return false;
                }
                
               
            }
            return true;
        }
        private static bool CheckRight()
        {
            for (int i = Y; i < 3; i++)
            {
                if (Matrix[X,i].text == Symbol)
                {
                    continue;
                }
                else if (Matrix[X,i].text != Symbol)
                {
                    return false;
                }
            }
            return true;
        }
        private static bool CheckLeft()
        {
            for (int i = Y; i >= 0; i--)
            {
                if (Matrix[X, i].text == Symbol)
                {
                    continue;
                }
                else if (Matrix[X, i].text != Symbol)
                {
                    return false;
                }
            }
            return true;    
        }              
        private static bool CheckDown()
        {
            for (int i = X; i < 3; i++)
            {
                if (Matrix[i, Y].text == Symbol)
                {
                    continue;
                }
                else if (Matrix[i, Y].text != Symbol)
                {
                    return false;
                }
            }
            return true;         
        }              
        private static bool CheckUp()
        {
            for (int i = X; i >= 0; i--)
            {
                if (Matrix[i, Y].text == Symbol)
                {
                    continue;
                }
                else if (Matrix[i, Y].text != Symbol)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
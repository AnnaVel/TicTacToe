using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TicTacToe
{
    
    public partial class TicTacToe : Telerik.WinControls.UI.RadForm
    {

        public bool isX = true;
        Random rnd = new Random();
        public TicTacMatrix<Moves> movesMatrix = new TicTacMatrix<Moves>();
        int XWins = 0;
        int OWins = 0;
        int counter = 0;
        public TicTacToe()
        {
            InitializeComponent();
            
            getRndTurn();
            updateTurn();
            #region BindControls
            x0y0.Click += x0y0_Click;
            x0y1.Click += x0y1_Click;
            x0y2.Click += x0y2_Click;
            x1y0.Click += x1y0_Click;
            x1y1.Click += x1y1_Click;
            x1y2.Click += x1y2_Click;
            x2y0.Click += x2y0_Click;
            x2y1.Click += x2y1_Click;
            x2y2.Click += x2y2_Click;
            #endregion
           
        }
        #region ControlsHandlers
        void x2y2_Click(object sender, EventArgs e)
        {
            if (x2y2.Text == "")
            {
                if (isX)
                {
                    x2y2.Text = "X";
                    isX = false;
                }
                else
                {
                    x2y2.Text = "O";
                    isX = true;
                }
                updateTurn();
                CreateNewMove(2, 2);
            }
           
        }
        void x2y1_Click(object sender, EventArgs e)
        {
            if (x2y1.Text == "")
            {
                if (isX)
                {
                    x2y1.Text = "X";
                    isX = false;
                }
                else
                {
                    x2y1.Text = "O";
                    isX = true;
                }
            }
            updateTurn();
            CreateNewMove(2, 1);
        }
        void x2y0_Click(object sender, EventArgs e)
        {
            if (x2y0.Text == "")
            {
                if (isX)
                {
                    x2y0.Text = "X";
                    isX = false;
                }
                else
                {
                    x2y0.Text = "O";
                    isX = true;
                }
            }
            updateTurn();
            CreateNewMove(2, 0);
        }
        void x1y2_Click(object sender, EventArgs e)
        {
            if (x1y2.Text == "")
            {
                if (isX)
                {
                    x1y2.Text = "X";
                    isX = false;
                }
                else
                {
                    x1y2.Text = "O";
                    isX = true;
                }
            }
            updateTurn();
            CreateNewMove(1, 2);
        }
        void x1y1_Click(object sender, EventArgs e)
        {
            if (x1y1.Text == "")
            {
                if (isX)
                {
                    x1y1.Text = "X";
                    isX = false;
                }
                else
                {
                    x1y1.Text = "O";
                    isX = true;
                }
            }
            updateTurn();
            CreateNewMove(1, 1);
        }
        void x1y0_Click(object sender, EventArgs e)
        {
            if (x1y0.Text == "")
            {
                if (isX)
                {
                    x1y0.Text = "X";
                    isX = false;
                }
                else
                {
                    x1y0.Text = "O";
                    isX = true;
                }
            }
            updateTurn();
            CreateNewMove(1, 0);
        }
        void x0y2_Click(object sender, EventArgs e)
        {
            if (x0y2.Text == "")
            {
                if (isX)
                {
                    x0y2.Text = "X";
                    isX = false;
                }
                else
                {
                    x0y2.Text = "O";
                    isX = true;
                }
            }
            updateTurn();
            CreateNewMove(0, 2);
        }
        void x0y1_Click(object sender, EventArgs e)
        {
            if (x0y1.Text == "")
            {
                if (isX)
                {
                    x0y1.Text = "X";
                    isX = false;
                }
                else
                {
                    x0y1.Text = "O";
                    isX = true;
                }
            }
            updateTurn();
            CreateNewMove(0, 1);
        }
        void x0y0_Click(object sender, EventArgs e)

        {
            if (x0y0.Text == "")
            {
                if (isX)
                {
                    x0y0.Text = "X";
                    isX = false;
                }
                else
                {
                    x0y0.Text = "O";
                    isX = true;
                }
            }
            updateTurn();
            CreateNewMove(0, 0);
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            x0y0.Text = "";
            x0y1.Text = "";
            x0y2.Text = "";
            x1y0.Text = "";
            x1y1.Text = "";
            x1y2.Text = "";
            x2y0.Text = "";
            x2y1.Text = "";
            x2y2.Text = "";
            movesMatrix.ClearMatrix();
        }
        #endregion

        public void updateTurn()
        {
            if (isX)
            {
                onTurnLabel.Text = "X";
            }
            else
            {
                onTurnLabel.Text = "O";
            }
        }
        public void getRndTurn()
        {
            int rndNumber = rnd.Next(0, 11);
            if (rndNumber <= 5)
            {
                isX = true;
            }
            else
            {
                isX = false;
            }
        }
        public void CreateNewMove(int x,int y)
        {
            MoveCreator mc = new MoveCreator(!isX);
            Moves newMove = mc.CreateMove(x, y);
            movesMatrix.insertAt(x, y, newMove);
            string symbol = null;
            counter++;
            if (!isX)
            {
                symbol = "X";
            }
            else
            {
                symbol = "O";
            }
            bool result = CheckForWinner.DoCheck(x, y,movesMatrix,symbol);
            if (result)
            {
                MessageBox.Show(symbol + " Wins");
                if (symbol == "X") XWins++;
                else OWins++;
                clearBtn.PerformClick();
            }
            else if (counter == 9 && !result)
            {
                MessageBox.Show("Draw");
                clearBtn.PerformClick();
            }
            UpdateWins();
        }
        public void UpdateWins()
        {
            xWinsLabel.Text = XWins.ToString();
            oWinsLabel.Text = OWins.ToString();
        }

        

        
    }
}

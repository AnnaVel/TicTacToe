namespace TicTacToe
{
    //Create X or O at the clicked position
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
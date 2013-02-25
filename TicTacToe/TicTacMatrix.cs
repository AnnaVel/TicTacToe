namespace TicTacToe
{
    //The matrix to hold the moves with only needed methods
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
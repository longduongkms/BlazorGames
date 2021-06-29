namespace Games.Models.Minesweeper
{
    public class Panel
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsMine { get; set; }
        public int AdjacentMines { get; set; }
        public bool IsRevealed { get; set; }
        public bool IsFlagged { get; set; }

        public Panel(int id, int x, int y)
        {
            Id = id;
            X = x;
            Y = y;
        }

        public void Flag()
        {
            if (!IsRevealed)
            {
                IsFlagged = !IsFlagged;
            }
        }

        public void Reveal()
        {
            IsRevealed = true;
            IsFlagged = false; //Revealed panels cannot be flagged
        }
    }
}
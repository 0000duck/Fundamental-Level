namespace MinesweeperGame
{
    public class Ranking
    {
        private string name;

        private int points;

        public Ranking()
        {
        }

        public Ranking(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; set; }

        public int Points { get; set; }
    }
}
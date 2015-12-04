namespace FootballLeague.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam
        {
            get { return homeTeam; }
            set { homeTeam = value; }
        }

        public Team AwayTeam
        {
            get { return awayTeam; }
            set { awayTeam = value; }
        }

        public Score Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Team getWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return Score.HomeTeamGoals > Score.AwayTeamGoals ? HomeTeam : AwayTeam;
        }

        private bool IsDraw()
        {
            return Score.AwayTeamGoals == Score.HomeTeamGoals;
        }

        public override string ToString()
        {
            return this.homeTeam.Name + " " + this.Score.HomeTeamGoals + " : " + this.Score.AwayTeamGoals + " " +
                   this.awayTeam.Name;
        }
    }
}
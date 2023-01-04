using System.Collections.Generic;

namespace KnjiznicarDataModel
{
    public class LeaderboardData
    {
        public class LeaderboardPlayer
        {
            public string PlayerName;
            public int Points;
        }

        public List<LeaderboardPlayer> Leaderboard;
    }
}

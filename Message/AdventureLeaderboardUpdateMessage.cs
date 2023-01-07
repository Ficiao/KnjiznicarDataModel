using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class AdventureLeaderboardUpdateMessage : BaseMessage
    {
        public LeaderboardData Leaderboard;

        public AdventureLeaderboardUpdateMessage() : base(MessageType.AdventureLeaderboardUpdate)
        {
        }
    }
}

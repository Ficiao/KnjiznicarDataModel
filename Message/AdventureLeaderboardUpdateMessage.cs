using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class AdventureLeaderboardUpdateMessage : BaseMessage
    {
        public LeaderboardData Leaderboard;

        public AdventureLeaderboardUpdateMessage() : base(MessageType.AdventureLeaderboardUpdate)
        {
        }
    }
}

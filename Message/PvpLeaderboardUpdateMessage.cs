using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PvpLeaderboardUpdateMessage : BaseMessage
    {
        public LeaderboardData Leaderboard;

        public PvpLeaderboardUpdateMessage() : base(MessageType.PvpLeaderboardUpdate)
        {
        }
    }
}

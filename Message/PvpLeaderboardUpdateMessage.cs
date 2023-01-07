using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class PvpLeaderboardUpdateMessage : BaseMessage
    {
        public LeaderboardData Leaderboard;

        public PvpLeaderboardUpdateMessage() : base(MessageType.PvpLeaderboardUpdate)
        {
        }
    }
}

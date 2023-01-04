using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class SpawnPlayerMessage : BaseMessage
    {
        public string PlayerUsername;
        public float[] SpawnPosition;
        public LeaderboardData PvpLeaderboard;
        public LeaderboardData AdventureLeaderboard;

        public SpawnPlayerMessage() : base(MessageType.SpawnPlayer)
        {
        }
    }
}

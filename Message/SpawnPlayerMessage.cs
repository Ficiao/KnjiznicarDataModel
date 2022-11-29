using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class SpawnPlayerMessage : BaseMessage
    {
        public string playerId;
        public string playerUsername;
        public float[] spawnPosition;

        public SpawnPlayerMessage() : base(MessageType.SpawnPlayer)
        {
        }
    }
}

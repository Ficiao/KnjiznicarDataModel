using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class SpawnPlayerMessage : BaseMessage
    {
        public string PlayerUsername;
        public float[] SpawnPosition;

        public SpawnPlayerMessage() : base(MessageType.SpawnPlayer)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

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

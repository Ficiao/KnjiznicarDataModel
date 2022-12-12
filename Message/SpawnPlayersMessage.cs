using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    class SpawnPlayersMessage : BaseMessage
    {
        public List<(string, float[])> spawnArray;

        public SpawnPlayersMessage() : base(MessageType.SpawnPlayers)
        {
            spawnArray = new();
        }
    }
}

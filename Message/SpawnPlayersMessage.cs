using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    class SpawnPlayersMessage : BaseMessage
    {
        public List<(string, float[])> SpawnArray;

        public SpawnPlayersMessage() : base(MessageType.SpawnPlayers)
        {
            SpawnArray = new();
        }
    }
}

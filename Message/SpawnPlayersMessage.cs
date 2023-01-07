using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    public class SpawnPlayersMessage : BaseMessage
    {
        public List<(string, float[])> SpawnArray;

        public SpawnPlayersMessage() : base(MessageType.SpawnPlayers)
        {
            SpawnArray = new();
        }
    }
}

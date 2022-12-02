using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    class PlayerCoordinatesMessage : BaseMessage
    {
        public class PlayerCoordinates
        {
            public string playerId;
            public float[] position = new float[3];
            public float[] rotation = new float[3];
        }

        public List<PlayerCoordinates> PlayerPositions;

        public PlayerCoordinatesMessage() : base(MessageType.PlayerCoordinates)
        {
            PlayerPositions = new List<PlayerCoordinates>();
        }
    }
}

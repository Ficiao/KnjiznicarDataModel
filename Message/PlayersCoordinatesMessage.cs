using KnjiznicarDataModel.Enum;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class PlayersCoordinatesMessage : BaseMessage
    {
        public class PlayerCoordinates
        {
            [JsonProperty("b")]
            public string PlayerUsername;
            [JsonProperty("c")]
            public float[] Position = new float[3];
            [JsonProperty("d")]
            public float[] Rotation = new float[3];
            [JsonProperty("e")]
            public int LeftRightDirection;
            [JsonProperty("f")]
            public int ForwardDirection;
            [JsonProperty("g")]
            public bool Grounded;
        }

        [JsonProperty("a")]
        public List<PlayerCoordinates> PlayerPositions;

        public PlayersCoordinatesMessage() : base(MessageType.PlayersCoordinates)
        {
            PlayerPositions = new List<PlayerCoordinates>();
        }
    }
}

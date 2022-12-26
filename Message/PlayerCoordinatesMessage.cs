using KnjiznicarDataModel.Enum;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class PlayerCoordinatesMessage : BaseMessage
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

        public PlayerCoordinatesMessage() : base(MessageType.PlayerCoordinates)
        {
            PlayerPositions = new List<PlayerCoordinates>();
        }
    }
}

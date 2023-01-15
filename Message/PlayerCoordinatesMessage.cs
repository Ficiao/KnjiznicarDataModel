using KnjiznicarDataModel.Enum;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class PlayerCoordinatesMessage : BaseMessage
    {
        [JsonProperty("a")]
        public int TickIndex;
        [JsonProperty("b")]
        public float[] Position = new float[3];
        [JsonProperty("c")]
        public int LeftRightDirection;
        [JsonProperty("d")]
        public int ForwardDirection;
        [JsonProperty("e")]
        public bool Grounded;

        public PlayerCoordinatesMessage() : base(MessageType.PlayerCoordinates)
        {
        }
    }
}

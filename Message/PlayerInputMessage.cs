using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class PlayerInputMessage : BaseMessage
    {
        [JsonProperty("a")]
        public int TickIndex;
        [JsonProperty("b")]
        public int LeftRightDirection;
        [JsonProperty("c")]
        public int ForwardDirection;
        [JsonProperty("d")]
        public bool Jump;
        [JsonProperty("e")]
        public float[] Rotation = new float[3];

        public PlayerInputMessage() : base(MessageType.PlayerInput)
        {
        }
    }
}

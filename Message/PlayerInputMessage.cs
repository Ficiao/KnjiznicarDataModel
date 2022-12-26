using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class PlayerInputMessage : BaseMessage
    {
        [JsonProperty("a")]
        public int LeftRightDirection;
        [JsonProperty("b")]
        public int ForwardDirection;
        [JsonProperty("c")]
        public bool Jump;
        [JsonProperty("d")]
        public float[] Rotation = new float[3];

        public PlayerInputMessage() : base(MessageType.PlayerInput)
        {
        }
    }
}

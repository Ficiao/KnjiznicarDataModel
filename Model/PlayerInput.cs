using Newtonsoft.Json;

namespace KnjiznicarDataModel
{
    public class PlayerInput
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
    }
}

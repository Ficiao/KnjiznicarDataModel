using Newtonsoft.Json;

namespace KnjiznicarDataModel
{
    public class PlayerState
    {
        [JsonProperty("a")]
        public int TickIndex;
        [JsonProperty("b")]
        public float[] Position;
        [JsonProperty("c")]
        public int LeftRightDirection;
        [JsonProperty("d")]
        public int ForwardDirection;
        [JsonProperty("e")]
        public bool Grounded;
    }
}

using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class PlayerCoordinatesMessage : BaseMessage
    {
        [JsonProperty("a")]
        public PlayerState ProcessedStates;

        public PlayerCoordinatesMessage() : base(MessageType.PlayerCoordinates)
        {
        }
    }
}

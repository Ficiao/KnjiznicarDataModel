using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class MatchmakingRequestMessage : BaseMessage
    {
        public MatchType MatchType;
        public int NpcId;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Level;

        public MatchmakingRequestMessage() : base(MessageType.MatchmakingRequest)
        {
        }
    }
}

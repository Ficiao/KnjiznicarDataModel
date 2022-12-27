using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class MatchmakingRequestMessage : BaseMessage
    {
        internal enum MatchType
        {
            Pvp = 1,
            Adventure = 2,
        }

        public MatchType MatchmakingType;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Level;

        public MatchmakingRequestMessage() : base(MessageType.MatchmakingRequest)
        {
        }
    }
}

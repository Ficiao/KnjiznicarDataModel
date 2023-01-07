using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class MatchEndMessage : BaseMessage
    {
        public MatchType MatchType;
        public bool HasWon;
        public bool IsSurrender;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? AdventureLevel;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? PvpRatingChange;

        public MatchEndMessage() : base(MessageType.MatchEnd)
        {
        }
    }
}

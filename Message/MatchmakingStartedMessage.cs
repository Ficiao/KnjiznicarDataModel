using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class MatchmakingStartedMessage : BaseMessage
    {
        public MatchType MatchType;

        public MatchmakingStartedMessage() : base(MessageType.SearchingForMatch)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class MatchmakingStartedMessage : BaseMessage
    {
        public MatchType MatchType;

        public MatchmakingStartedMessage() : base(MessageType.SearchingForMatch)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;

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

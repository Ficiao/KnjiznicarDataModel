using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class MatchmakingCanceledMessage : BaseMessage
    {
        public MatchmakingCanceledMessage() : base(MessageType.MatchmakingCanceled)
        {
        }
    }
}

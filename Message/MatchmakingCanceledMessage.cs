using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class MatchmakingCanceledMessage : BaseMessage
    {
        public MatchmakingCanceledMessage() : base(MessageType.MatchmakingCanceled)
        {
        }
    }
}

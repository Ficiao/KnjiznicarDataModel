using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class MatchmakingCanceledMessage : BaseMessage
    {
        public MatchmakingCanceledMessage() : base(MessageType.MatchmakingCanceled)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class CancelMatchmakingRequestMessage : BaseMessage
    {
        public CancelMatchmakingRequestMessage() : base(MessageType.CancelMatchmakingRequest)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class CancelMatchmakingRequestMessage : BaseMessage
    {
        public CancelMatchmakingRequestMessage() : base(MessageType.CancelMatchmakingRequest)
        {
        }
    }
}

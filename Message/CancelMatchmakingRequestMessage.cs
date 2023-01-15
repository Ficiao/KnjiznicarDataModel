using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class CancelMatchmakingRequestMessage : BaseMessage
    {
        public CancelMatchmakingRequestMessage() : base(MessageType.CancelMatchmakingRequest)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class ReturnFromInstanceMessage : BaseMessage
    {
        public string SessionId;

        public ReturnFromInstanceMessage() : base(MessageType.ReturnFromInstance)
        {
        }
    }
}

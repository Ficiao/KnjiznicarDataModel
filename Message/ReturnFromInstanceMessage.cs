using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class ReturnFromInstanceMessage : BaseMessage
    {
        public string SessionId;

        public ReturnFromInstanceMessage() : base(MessageType.ReturnFromInstance)
        {
        }
    }
}

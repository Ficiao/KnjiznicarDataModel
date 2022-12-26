using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class LogoutMessage : BaseMessage
    {
        public bool ResponseNeeded;

        public LogoutMessage(bool responseNeeded) : base(MessageType.Logout)
        {
            this.ResponseNeeded = responseNeeded;
        }
    }
}

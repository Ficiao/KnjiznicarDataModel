using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class LogoutMessage : BaseMessage
    {
        public bool ResponseNeeded;

        public LogoutMessage(bool responseNeeded) : base(MessageType.Logout)
        {
            this.ResponseNeeded = responseNeeded;
        }
    }
}

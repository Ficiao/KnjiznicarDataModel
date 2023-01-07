using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class LoginMessage : BaseMessage
    {
        public string Username;
        public string PasswordHash;

        public LoginMessage() : base(MessageType.Login)
        {
        }
    }
}

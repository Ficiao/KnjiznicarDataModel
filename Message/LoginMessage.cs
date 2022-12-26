using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class LoginMessage : BaseMessage
    {
        public string Username;
        public string PasswordHash;

        public LoginMessage() : base(MessageType.Login)
        {
        }
    }
}

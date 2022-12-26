using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class RegisterMessage : BaseMessage
    {
        public string Username;
        public string PasswordHash;

        public RegisterMessage() : base(MessageType.Register)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PlayerChatMessage : BaseMessage
    {
        public string PlayerName;
        public string Message;

        public PlayerChatMessage() : base(MessageType.ChatMessage)
        {
        }
    }
}

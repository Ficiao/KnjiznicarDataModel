using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PlayerChatMessage : BaseMessage
    {
        public string playerName;
        public string message;

        public PlayerChatMessage() : base(MessageType.ChatMessage)
        {
        }
    }
}

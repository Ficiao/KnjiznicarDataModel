using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PlayerNameSelectionMessage : BaseMessage
    {
        public string PlayerName;

        public PlayerNameSelectionMessage() : base(MessageType.PlayerNameSelection)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class PlayerNameSelectionMessage : BaseMessage
    {
        public string PlayerName;

        public PlayerNameSelectionMessage() : base(MessageType.PlayerNameSelection)
        {
        }
    }
}

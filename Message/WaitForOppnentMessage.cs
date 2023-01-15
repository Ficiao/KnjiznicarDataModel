using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class WaitForOpponentMessage : BaseMessage
    {
        public WaitForOpponentMessage() : base(MessageType.WaitForOpponent)
        {
        }
    }
}

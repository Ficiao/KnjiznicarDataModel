using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class WaitForOpponentMessage : BaseMessage
    {
        public WaitForOpponentMessage() : base(MessageType.WaitForOpponent)
        {
        }
    }
}

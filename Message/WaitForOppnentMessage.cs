using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class WaitForOpponentMessage : BaseMessage
    {
        public WaitForOpponentMessage() : base(MessageType.WaitForOpponent)
        {
        }
    }
}

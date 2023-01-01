using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class TurnOverMessage : BaseMessage
    {
        public TurnOverMessage() : base(MessageType.TurnOver)
        {
        }
    }
}

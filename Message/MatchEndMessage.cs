using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class MatchEndMessage : BaseMessage
    {
        public MatchEndMessage() : base(MessageType.MatchEnd)
        {
        }
    }
}

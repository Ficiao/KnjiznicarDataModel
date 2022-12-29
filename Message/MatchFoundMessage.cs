using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class MatchFoundMessage : BaseMessage
    {
        public MatchType MatchType;

        public MatchFoundMessage() : base(MessageType.MatchFound)
        {
        }
    }
}

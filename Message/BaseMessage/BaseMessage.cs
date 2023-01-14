using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class BaseMessage
    {
        [JsonProperty("MT")]
        public MessageType MessageType { get; }

        protected BaseMessage(MessageType type)
        {
            MessageType = type;
        }
    }
}

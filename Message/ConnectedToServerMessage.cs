using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class ConnectedToServerMessage : BaseMessage
    {
        [JsonProperty("welcomeMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string welcomeMessage;        
        [JsonProperty("sessionId", NullValueHandling = NullValueHandling.Ignore)]
        public string sessionId;
        public ServerType serverType;

        public ConnectedToServerMessage() : base(MessageType.Connect)
        {
        }
    }
}

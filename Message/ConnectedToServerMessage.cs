using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class ConnectedToServerMessage : BaseMessage
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string WelcomeMessage;        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId;
        public ServerType ServerType;

        public ConnectedToServerMessage() : base(MessageType.Connect)
        {
        }
    }
}

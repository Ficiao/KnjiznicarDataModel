using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class ConnectedToServerMessage : BaseMessage
    {
        [JsonProperty("welcomeMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string welcomeMessage;
        public int playerId;

        public ConnectedToServerMessage() : base(MessageType.Connect)
        {
        }
    }
}

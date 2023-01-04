using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class PlayerConnectedMessage :BaseMessage
    {
        public string Username;
        public string PlayerName;
        public string PlayerIp;
        public string ClientId;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public PlayerData PlayerData;

        public PlayerConnectedMessage() : base(MessageType.PlayerConnected)
        {

        }
    }
}

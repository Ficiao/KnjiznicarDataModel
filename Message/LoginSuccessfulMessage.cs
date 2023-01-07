using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class LoginSuccessfulMessage : BaseMessage
    {
        public bool LoginSuccessful;
        public bool IsLogin;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Username;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public PlayerData PlayerData;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string OverworldIp;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int OverworldPort;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceIp;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int InstancePort;


        public LoginSuccessfulMessage() : base(MessageType.LoginSuccessful)
        {
        }
    }
}

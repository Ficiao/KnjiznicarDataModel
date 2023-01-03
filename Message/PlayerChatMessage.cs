using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class PlayerChatMessage : BaseMessage
    {
        public string Message;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string PlayerName;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool IsGlobal;

        public PlayerChatMessage() : base(MessageType.ChatMessage)
        {
        }
    }
}

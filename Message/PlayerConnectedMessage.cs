using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PlayerConnectedMessage :BaseMessage
    {
        public PlayerData PlayerData;
        public string Username;
        public string PlayerIp;
        public string ClientId;

        public PlayerConnectedMessage() : base(MessageType.PlayerConnected)
        {

        }
    }
}

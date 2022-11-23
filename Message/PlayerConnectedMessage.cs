using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PlayerConnectedMessage :BaseMessage
    {
        public PlayerData playerData;
        public string username;
        public string playerIp;

        public PlayerConnectedMessage() : base(MessageType.PlayerConnected)
        {

        }
    }
}

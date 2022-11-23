using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PlayerLoggedOutMessage : BaseMessage
    {
        public string id;
        public string ip;
        
        public PlayerLoggedOutMessage() : base(MessageType.PlayerLoggedOut)
        {

        }
    }
}

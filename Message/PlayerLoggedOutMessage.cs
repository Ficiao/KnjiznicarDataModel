using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PlayerLoggedOutMessage : BaseMessage
    {
        public int id;
        public string ip;
        
        public PlayerLoggedOutMessage() : base(MessageType.PlayerLoggedOut)
        {

        }
    }
}

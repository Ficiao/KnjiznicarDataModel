using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class PlayerLoggedOutMessage : BaseMessage
    {
        public string Id;
        
        public PlayerLoggedOutMessage() : base(MessageType.PlayerLoggedOut)
        {
        }
    }
}

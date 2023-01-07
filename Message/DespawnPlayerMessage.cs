using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class DespawnPlayerMessage : BaseMessage
    {
        public string PlayerUsername;

        public DespawnPlayerMessage() : base(MessageType.DespawnPlayer)
        {
        }
    }
}

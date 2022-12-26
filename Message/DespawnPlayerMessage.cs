using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class DespawnPlayerMessage : BaseMessage
    {
        public string PlayerUsername;

        public DespawnPlayerMessage() : base(MessageType.DespawnPlayer)
        {
        }
    }
}

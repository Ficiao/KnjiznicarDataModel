using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class SurrenderRequestMessage : BaseMessage
    {
        public SurrenderRequestMessage() : base(MessageType.SurrenderRequest)
        {
        }
    }
}

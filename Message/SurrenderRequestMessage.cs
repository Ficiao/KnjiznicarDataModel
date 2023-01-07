using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    public class SurrenderRequestMessage : BaseMessage
    {
        public SurrenderRequestMessage() : base(MessageType.SurrenderRequest)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class SurrenderRequestMessage : BaseMessage
    {
        public SurrenderRequestMessage() : base(MessageType.SurrenderRequest)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class ErrorMessage : BaseMessage
    {
        public ErrorType error;

        public ErrorMessage() : base(MessageType.Error)
        {
        }
    }
}

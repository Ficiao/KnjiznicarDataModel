using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class ErrorMessage : BaseMessage
    {
        public ErrorType Error;

        public ErrorMessage() : base(MessageType.Error)
        {
        }
    }
}

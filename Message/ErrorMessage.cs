using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class ErrorMessage : BaseMessage
    {
        public ErrorType Error;

        public ErrorMessage() : base(MessageType.Error)
        {
        }
    }
}

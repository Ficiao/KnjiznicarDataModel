using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class BaseMessage
    {
        public MessageType MessageType { get; }

        protected BaseMessage(MessageType type)
        {
            MessageType = type;
        }
    }
}

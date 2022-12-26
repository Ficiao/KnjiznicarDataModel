using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class BaseMessage
    {
        public MessageType MessageType { get; }

        protected BaseMessage(MessageType type)
        {
            MessageType = type;
        }
    }
}

using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class HeartBeatMessage : BaseMessage
    {
        public HeartBeatMessage() : base(MessageType.HeartBeat)
        {
        }
    }
}

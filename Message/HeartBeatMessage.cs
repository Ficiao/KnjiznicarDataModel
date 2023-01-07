using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class HeartBeatMessage : BaseMessage
    {
        public HeartBeatMessage() : base(MessageType.HeartBeat)
        {
        }
    }
}

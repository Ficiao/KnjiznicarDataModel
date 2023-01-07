using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class UdpConnectMessage : BaseMessage
    {
        public string SessionId;

        public UdpConnectMessage() : base(MessageType.UdpConnect)
        {
        }
    }
}

using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class UdpConnectMessage : BaseMessage
    {
        public string sessionId;

        public UdpConnectMessage() : base(MessageType.UdpConnect)
        {
        }
    }
}

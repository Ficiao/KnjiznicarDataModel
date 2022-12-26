using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class UdpConnectMessage : BaseMessage
    {
        public string SessionId;

        public UdpConnectMessage() : base(MessageType.UdpConnect)
        {
        }
    }
}

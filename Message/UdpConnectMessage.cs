using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class UdpConnectMessage : BaseMessage
    {

        public UdpConnectMessage() : base(MessageType.UdpConnect)
        {
        }
    }
}

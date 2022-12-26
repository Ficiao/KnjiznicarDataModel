using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    class PlayersMissingMessage : BaseMessage
    {
        public List<string> MissingNames;

        public PlayersMissingMessage() : base(MessageType.PlayersMissing)
        {
        }
    }
}

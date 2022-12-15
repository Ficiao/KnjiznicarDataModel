using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    class PlayersMissingMessage : BaseMessage
    {
        public List<string> missingNames;

        public PlayersMissingMessage() : base(MessageType.PlayersMissing)
        {
        }
    }
}

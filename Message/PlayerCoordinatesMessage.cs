using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    public class PlayerCoordinatesMessage : BaseMessage
    {
        public List<PlayerState> ProcessedStates;

        public PlayerCoordinatesMessage() : base(MessageType.PlayerCoordinates)
        {
            ProcessedStates = new List<PlayerState>();
        }
    }
}

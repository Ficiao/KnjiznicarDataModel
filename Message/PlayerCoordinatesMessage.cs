using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    class PlayerCoordinatesMessage : BaseMessage
    {
        public int playerId;
        public float[] position = new float[3];
        public float[] rotation = new float[3];

        public PlayerCoordinatesMessage() : base(MessageType.PlayerCoordinates)
        {
        }
    }
}

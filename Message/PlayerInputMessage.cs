using KnjiznicarDataModel.Enum;

namespace KnjiznicarDataModel.Message
{
    public class PlayerInputMessage : BaseMessage
    {
        public PlayerInput PlayerInput;

        public PlayerInputMessage() : base(MessageType.PlayerInput)
        {
            PlayerInput = new PlayerInput();
        }
    }
}

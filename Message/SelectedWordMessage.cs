using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class SelectedWordMessage : BaseMessage
    {
        public SelectedWordMessage() : base(MessageType.SelectedWord)
        {
        }
    }
}

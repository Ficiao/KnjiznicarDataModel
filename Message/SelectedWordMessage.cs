using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    class SelectedWordMessage : BaseMessage
    {
        public List<(int, int)> LetterIndexes;

        public SelectedWordMessage() : base(MessageType.SelectedWord)
        {
        }
    }
}

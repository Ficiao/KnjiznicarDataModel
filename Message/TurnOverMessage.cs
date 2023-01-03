using KnjiznicarDataModel.Enum;
using System.Collections.Generic;

namespace KnjiznicarDataModel.Message
{
    class TurnOverMessage : BaseMessage
    {
        public string OwnWord;
        public int OwnDamage;
        public string EnemryWord;
        public int EnemyDamage;
        public List<char> NewLetters;

        public TurnOverMessage() : base(MessageType.TurnOver)
        {
        }
    }
}

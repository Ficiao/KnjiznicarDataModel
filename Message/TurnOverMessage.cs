using KnjiznicarDataModel.Enum;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class TurnOverMessage : BaseMessage
    {
        public string OwnWord;
        public int OwnDamage;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string EnemryWord;
        public int EnemyDamage;
        public List<char> NewLetters;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public MatchEndMessage MatchEndData;

        public TurnOverMessage() : base(MessageType.TurnOver)
        {
        }
    }
}

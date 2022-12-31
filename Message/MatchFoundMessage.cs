﻿using KnjiznicarDataModel.Enum;
using Newtonsoft.Json;

namespace KnjiznicarDataModel.Message
{
    class MatchFoundMessage : BaseMessage
    {
        public MatchType MatchType;
        public PlayerMatchData OwnData;
        public string EnemyName;
        public int EnemyHealth;

        public MatchFoundMessage() : base(MessageType.MatchFound)
        {
        }
    }
}

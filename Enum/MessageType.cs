﻿namespace KnjiznicarDataModel.Enum
{
    public enum MessageType
    {
        Connect = 1,
        Register = 2,
        Login = 3,
        LoginSuccessful = 4,
        Logout = 5,
        PlayerConnected = 6,
        AcceptPlayer = 7,
        PlayerLoggedOut = 8,
        PlayerInput = 9,
        PlayerCoordinates = 10,
        SpawnPlayer = 11,
        PlayerNameSelection = 12,
        Error = 13,
        UdpConnect = 14,
        DespawnPlayer = 15,
        SpawnPlayers = 16,
        PlayersMissing = 17,
        HeartBeat = 18,
        ChatMessage = 19,
        MatchmakingRequest = 20,
        SearchingForMatch = 22,
        MatchFound = 21,
        CancelMatchmakingRequest = 22,
        MatchmakingCanceled = 23,
        SurrenderRequest = 24,
        MatchEnd = 25,
        SelectedWord = 26,
        TurnOver = 27,
    }
}

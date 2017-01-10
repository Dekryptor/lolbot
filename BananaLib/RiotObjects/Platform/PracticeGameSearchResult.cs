﻿// Decompiled with JetBrains decompiler
// Type: BananaLib.RiotObjects.Platform.PracticeGameSearchResult
// Assembly: BananaLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75213AF3-E339-4AEB-B3FE-095F85BC5F53
// Assembly location: C:\Users\Hesa\Desktop\eZ\BananaLib.dll

using RtmpSharp.IO;
using System;

namespace BananaLib.RiotObjects.Platform
{
  [SerializedName("com.riotgames.platform.game.practice.PracticeGameSearchResult")]
  [Serializable]
  public class PracticeGameSearchResult
  {
    [SerializedName("spectatorCount")]
    public int SpectatorCount { get; set; }

    [SerializedName("glmGameId")]
    public object GlmGameId { get; set; }

    [SerializedName("glmHost")]
    public object GlmHost { get; set; }

    [SerializedName("glmPort")]
    public int GlmPort { get; set; }

    [SerializedName("gameModeString")]
    public string GameModeString { get; set; }

    [SerializedName("allowSpectators")]
    public string AllowSpectators { get; set; }

    [SerializedName("gameMapId")]
    public int GameMapId { get; set; }

    [SerializedName("maxNumPlayers")]
    public int MaxNumPlayers { get; set; }

    [SerializedName("glmSecurePort")]
    public int GlmSecurePort { get; set; }

    [SerializedName("gameMode")]
    public string GameMode { get; set; }

    [SerializedName("id")]
    public double Id { get; set; }

    [SerializedName("name")]
    public string Name { get; set; }

    [SerializedName("privateGame")]
    public bool PrivateGame { get; set; }

    [SerializedName("owner")]
    public PlayerParticipant Owner { get; set; }

    [SerializedName("team1Count")]
    public int Team1Count { get; set; }

    [SerializedName("team2Count")]
    public int Team2Count { get; set; }
  }
}

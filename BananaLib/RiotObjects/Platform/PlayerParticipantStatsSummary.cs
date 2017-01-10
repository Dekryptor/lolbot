﻿// Decompiled with JetBrains decompiler
// Type: BananaLib.RiotObjects.Platform.PlayerParticipantStatsSummary
// Assembly: BananaLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75213AF3-E339-4AEB-B3FE-095F85BC5F53
// Assembly location: C:\Users\Hesa\Desktop\eZ\BananaLib.dll

using BananaLib.RiotObjects.Team;
using RtmpSharp.IO;
using System;
using System.Collections.Generic;

namespace BananaLib.RiotObjects.Platform
{
  [SerializedName("com.riotgames.platform.statistics.PlayerParticipantStatsSummary")]
  [Serializable]
  public class PlayerParticipantStatsSummary
  {
    [SerializedName("skinName")]
    public string SkinName { get; set; }

    [SerializedName("gameId")]
    public double GameId { get; set; }

    [SerializedName("profileIconId")]
    public int ProfileIconId { get; set; }

    [SerializedName("elo")]
    public int Elo { get; set; }

    [SerializedName("leaver")]
    public bool Leaver { get; set; }

    [SerializedName("leaves")]
    public double Leaves { get; set; }

    [SerializedName("teamId")]
    public double TeamId { get; set; }

    [SerializedName("eloChange")]
    public int EloChange { get; set; }

    [SerializedName("statistics")]
    public List<RawStatDTO> Statistics { get; set; }

    [SerializedName("level")]
    public double Level { get; set; }

    [SerializedName("botPlayer")]
    public bool BotPlayer { get; set; }

    [SerializedName("isMe")]
    public bool IsMe { get; set; }

    [SerializedName("inChat")]
    public bool InChat { get; set; }

    [SerializedName("userId")]
    public double UserId { get; set; }

    [SerializedName("spell2Id")]
    public double Spell2Id { get; set; }

    [SerializedName("losses")]
    public double Losses { get; set; }

    [SerializedName("summonerName")]
    public string SummonerName { get; set; }

    [SerializedName("wins")]
    public double Wins { get; set; }

    [SerializedName("spell1Id")]
    public double Spell1Id { get; set; }

    [SerializedName("teamInfo")]
    public TeamInfo TeamInfo { get; set; }

    [SerializedName("reportEnabled")]
    public bool ReportEnabled { get; set; }

    [SerializedName("kudosEnabled")]
    public bool KudosEnabled { get; set; }
  }
}

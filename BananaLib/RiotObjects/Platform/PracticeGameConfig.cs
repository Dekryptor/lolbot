﻿// Decompiled with JetBrains decompiler
// Type: BananaLib.RiotObjects.Platform.PracticeGameConfig
// Assembly: BananaLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75213AF3-E339-4AEB-B3FE-095F85BC5F53
// Assembly location: C:\Users\Hesa\Desktop\eZ\BananaLib.dll

using RtmpSharp.IO;
using System;

namespace BananaLib.RiotObjects.Platform
{
  [SerializedName("com.riotgames.platform.game.PracticeGameConfig")]
  [Serializable]
  public class PracticeGameConfig
  {
    [SerializedName("passbackUrl")]
    public object PassbackUrl { get; set; }

    [SerializedName("gameName")]
    public string GameName { get; set; }

    [SerializedName("gameTypeConfig")]
    public int GameTypeConfig { get; set; }

    [SerializedName("passbackDataPacket")]
    public object PassbackDataPacket { get; set; }

    [SerializedName("gamePassword")]
    public string GamePassword { get; set; }

    [SerializedName("gameMap")]
    public GameMap GameMap { get; set; }

    [SerializedName("gameMode")]
    public string GameMode { get; set; }

    [SerializedName("allowSpectators")]
    public string AllowSpectators { get; set; }

    [SerializedName("maxNumPlayers")]
    public int MaxNumPlayers { get; set; }

    [SerializedName("region")]
    public string Region { get; set; }
  }
}

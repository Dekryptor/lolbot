﻿// Decompiled with JetBrains decompiler
// Type: BananaLib.RiotObjects.Platform.SummaryAggStats
// Assembly: BananaLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75213AF3-E339-4AEB-B3FE-095F85BC5F53
// Assembly location: C:\Users\Hesa\Desktop\eZ\BananaLib.dll

using RtmpSharp.IO;
using System;
using System.Collections.Generic;

namespace BananaLib.RiotObjects.Platform
{
  [SerializedName("com.riotgames.platform.statistics.SummaryAggStats")]
  [Serializable]
  public class SummaryAggStats
  {
    [SerializedName("statsJson")]
    public object StatsJson { get; set; }

    [SerializedName("stats")]
    public List<SummaryAggStat> Stats { get; set; }
  }
}

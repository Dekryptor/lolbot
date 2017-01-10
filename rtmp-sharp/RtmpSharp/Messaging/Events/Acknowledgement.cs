﻿// Decompiled with JetBrains decompiler
// Type: RtmpSharp.Messaging.Events.Acknowledgement
// Assembly: rtmp-sharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8588136F-A4B9-4004-9712-4EA13AA4AF9D
// Assembly location: C:\Users\Hesa\Desktop\eZ_Source\bin\Debug\rtmp-sharp.dll

using RtmpSharp.Net;

namespace RtmpSharp.Messaging.Events
{
  internal class Acknowledgement : RtmpEvent
  {
    public int BytesRead { get; private set; }

    public Acknowledgement(int bytesRead)
      : base(MessageType.Acknowledgement)
    {
      this.BytesRead = bytesRead;
    }
  }
}

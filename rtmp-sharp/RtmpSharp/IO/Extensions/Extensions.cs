﻿// Decompiled with JetBrains decompiler
// Type: RtmpSharp.IO.Extensions.Extensions
// Assembly: rtmp-sharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8588136F-A4B9-4004-9712-4EA13AA4AF9D
// Assembly location: C:\Users\Hesa\Desktop\eZ_Source\bin\Debug\rtmp-sharp.dll

using System.Collections;
using System.Collections.Generic;

namespace RtmpSharp.IO.Extensions
{
  internal static class Extensions
  {
    public static IList ToList(this IEnumerable enumerable)
    {
      List<object> objectList = new List<object>();
      foreach (object obj in enumerable)
        objectList.Add(obj);
      return (IList) objectList;
    }
  }
}

﻿// Decompiled with JetBrains decompiler
// Type: DisasterServer.Entities.ExellerClone
// Assembly: DisasterServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 543F9D20-F969-4EBF-B20C-D2589F4E3C54
// Assembly location: C:\Users\User\Downloads\DisasterServerWin\DisasterServer.dll

using DisasterServer.Maps;
using DisasterServer.Session;
using DisasterServer.State;

#nullable enable
namespace DisasterServer.Entities
{
  public class ExellerClone : Entity
  {
    public byte ID;
    public ushort PID;
    public sbyte Dir;

    public ExellerClone(ushort pid, byte id, int x, int y, sbyte dir)
    {
      this.Dir = dir;
      this.PID = pid;
      this.ID = id;
      this.X = x;
      this.Y = y;
    }

    public override TcpPacket? Destroy(Server server, Game game, Map map)
    {
      return new TcpPacket(PacketType.SERVER_EXELLERCLONE_STATE, new object[2]
      {
        (object) (byte) 1,
        (object) this.ID
      });
    }

    public override TcpPacket? Spawn(Server server, Game game, Map map)
    {
      return new TcpPacket(PacketType.SERVER_EXELLERCLONE_STATE, new object[6]
      {
        (object) (byte) 0,
        (object) this.ID,
        (object) this.PID,
        (object) (ushort) this.X,
        (object) (ushort) this.Y,
        (object) this.Dir
      });
    }

    public override UdpPacket? Tick(Server server, Game game, Map map) => (UdpPacket) null;
  }
}

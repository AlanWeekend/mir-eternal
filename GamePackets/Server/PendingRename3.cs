﻿using System;

namespace GameServer.Networking
{
	
	[PacketInfoAttribute(Source = PacketSource.Server, Id = 98, Length = 13, Description = "技能释放中断", Broadcast = true)]
	public sealed class 技能释放中断 : GamePacket
	{
		
		public 技能释放中断()
		{
			
			
		}

		
		[WrappingFieldAttribute(SubScript = 2, Length = 4)]
		public int 对象编号;

		
		[WrappingFieldAttribute(SubScript = 6, Length = 2)]
		public ushort SkillId;

		
		[WrappingFieldAttribute(SubScript = 8, Length = 1)]
		public byte SkillLevel;

		
		[WrappingFieldAttribute(SubScript = 9, Length = 1)]
		public byte 技能铭文;

		
		[WrappingFieldAttribute(SubScript = 10, Length = 1)]
		public byte 动作编号;

		
		[WrappingFieldAttribute(SubScript = 11, Length = 1)]
		public byte 技能分段;
	}
}

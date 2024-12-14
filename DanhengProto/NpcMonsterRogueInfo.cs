using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C35 RID: 3125
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcMonsterRogueInfo : IMessage<NpcMonsterRogueInfo>, IMessage, IEquatable<NpcMonsterRogueInfo>, IDeepCloneable<NpcMonsterRogueInfo>, IBufferMessage
	{
		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x06008A79 RID: 35449 RVA: 0x0016D9BB File Offset: 0x0016BBBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcMonsterRogueInfo> Parser
		{
			get
			{
				return NpcMonsterRogueInfo._parser;
			}
		}

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x06008A7A RID: 35450 RVA: 0x0016D9C2 File Offset: 0x0016BBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NpcMonsterRogueInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x06008A7B RID: 35451 RVA: 0x0016D9D4 File Offset: 0x0016BBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcMonsterRogueInfo.Descriptor;
			}
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x0016D9DB File Offset: 0x0016BBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMonsterRogueInfo()
		{
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x0016D9E4 File Offset: 0x0016BBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMonsterRogueInfo(NpcMonsterRogueInfo other) : this()
		{
			this.level_ = other.level_;
			this.rogueMonsterId_ = other.rogueMonsterId_;
			this.eliteGroup_ = other.eliteGroup_;
			this.hardLevelGroup_ = other.hardLevelGroup_;
			this.iIBEOENKNCN_ = other.iIBEOENKNCN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x0016DA44 File Offset: 0x0016BC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMonsterRogueInfo Clone()
		{
			return new NpcMonsterRogueInfo(this);
		}

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x06008A7F RID: 35455 RVA: 0x0016DA4C File Offset: 0x0016BC4C
		// (set) Token: 0x06008A80 RID: 35456 RVA: 0x0016DA54 File Offset: 0x0016BC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x06008A81 RID: 35457 RVA: 0x0016DA5D File Offset: 0x0016BC5D
		// (set) Token: 0x06008A82 RID: 35458 RVA: 0x0016DA65 File Offset: 0x0016BC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueMonsterId
		{
			get
			{
				return this.rogueMonsterId_;
			}
			set
			{
				this.rogueMonsterId_ = value;
			}
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x06008A83 RID: 35459 RVA: 0x0016DA6E File Offset: 0x0016BC6E
		// (set) Token: 0x06008A84 RID: 35460 RVA: 0x0016DA76 File Offset: 0x0016BC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EliteGroup
		{
			get
			{
				return this.eliteGroup_;
			}
			set
			{
				this.eliteGroup_ = value;
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x06008A85 RID: 35461 RVA: 0x0016DA7F File Offset: 0x0016BC7F
		// (set) Token: 0x06008A86 RID: 35462 RVA: 0x0016DA87 File Offset: 0x0016BC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HardLevelGroup
		{
			get
			{
				return this.hardLevelGroup_;
			}
			set
			{
				this.hardLevelGroup_ = value;
			}
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x06008A87 RID: 35463 RVA: 0x0016DA90 File Offset: 0x0016BC90
		// (set) Token: 0x06008A88 RID: 35464 RVA: 0x0016DA98 File Offset: 0x0016BC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IIBEOENKNCN
		{
			get
			{
				return this.iIBEOENKNCN_;
			}
			set
			{
				this.iIBEOENKNCN_ = value;
			}
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x0016DAA1 File Offset: 0x0016BCA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcMonsterRogueInfo);
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x0016DAB0 File Offset: 0x0016BCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcMonsterRogueInfo other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.RogueMonsterId == other.RogueMonsterId && this.EliteGroup == other.EliteGroup && this.HardLevelGroup == other.HardLevelGroup && this.IIBEOENKNCN == other.IIBEOENKNCN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A8B RID: 35467 RVA: 0x0016DB2C File Offset: 0x0016BD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.RogueMonsterId != 0U)
			{
				num ^= this.RogueMonsterId.GetHashCode();
			}
			if (this.EliteGroup != 0U)
			{
				num ^= this.EliteGroup.GetHashCode();
			}
			if (this.HardLevelGroup != 0U)
			{
				num ^= this.HardLevelGroup.GetHashCode();
			}
			if (this.IIBEOENKNCN != 0U)
			{
				num ^= this.IIBEOENKNCN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x0016DBCF File Offset: 0x0016BDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x0016DBD7 File Offset: 0x0016BDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x0016DBE0 File Offset: 0x0016BDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IIBEOENKNCN != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.IIBEOENKNCN);
			}
			if (this.RogueMonsterId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RogueMonsterId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Level);
			}
			if (this.EliteGroup != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.EliteGroup);
			}
			if (this.HardLevelGroup != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.HardLevelGroup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x0016DC90 File Offset: 0x0016BE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.RogueMonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueMonsterId);
			}
			if (this.EliteGroup != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EliteGroup);
			}
			if (this.HardLevelGroup != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HardLevelGroup);
			}
			if (this.IIBEOENKNCN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IIBEOENKNCN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x0016DD30 File Offset: 0x0016BF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcMonsterRogueInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.RogueMonsterId != 0U)
			{
				this.RogueMonsterId = other.RogueMonsterId;
			}
			if (other.EliteGroup != 0U)
			{
				this.EliteGroup = other.EliteGroup;
			}
			if (other.HardLevelGroup != 0U)
			{
				this.HardLevelGroup = other.HardLevelGroup;
			}
			if (other.IIBEOENKNCN != 0U)
			{
				this.IIBEOENKNCN = other.IIBEOENKNCN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x0016DDBC File Offset: 0x0016BFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x0016DDC8 File Offset: 0x0016BFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.IIBEOENKNCN = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.RogueMonsterId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.EliteGroup = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.HardLevelGroup = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003515 RID: 13589
		private static readonly MessageParser<NpcMonsterRogueInfo> _parser = new MessageParser<NpcMonsterRogueInfo>(() => new NpcMonsterRogueInfo());

		// Token: 0x04003516 RID: 13590
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003517 RID: 13591
		public const int LevelFieldNumber = 7;

		// Token: 0x04003518 RID: 13592
		private uint level_;

		// Token: 0x04003519 RID: 13593
		public const int RogueMonsterIdFieldNumber = 4;

		// Token: 0x0400351A RID: 13594
		private uint rogueMonsterId_;

		// Token: 0x0400351B RID: 13595
		public const int EliteGroupFieldNumber = 8;

		// Token: 0x0400351C RID: 13596
		private uint eliteGroup_;

		// Token: 0x0400351D RID: 13597
		public const int HardLevelGroupFieldNumber = 14;

		// Token: 0x0400351E RID: 13598
		private uint hardLevelGroup_;

		// Token: 0x0400351F RID: 13599
		public const int IIBEOENKNCNFieldNumber = 2;

		// Token: 0x04003520 RID: 13600
		private uint iIBEOENKNCN_;
	}
}

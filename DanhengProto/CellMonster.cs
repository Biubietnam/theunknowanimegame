using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200017D RID: 381
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CellMonster : IMessage<CellMonster>, IMessage, IEquatable<CellMonster>, IDeepCloneable<CellMonster>, IBufferMessage
	{
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x000312C0 File Offset: 0x0002F4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CellMonster> Parser
		{
			get
			{
				return CellMonster._parser;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x000312C7 File Offset: 0x0002F4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CellMonsterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x000312D9 File Offset: 0x0002F4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CellMonster.Descriptor;
			}
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000312E0 File Offset: 0x0002F4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonster()
		{
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000312E8 File Offset: 0x0002F4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonster(CellMonster other) : this()
		{
			this.bossDecayId_ = other.bossDecayId_;
			this.monsterId_ = other.monsterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00031319 File Offset: 0x0002F519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonster Clone()
		{
			return new CellMonster(this);
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00031321 File Offset: 0x0002F521
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00031329 File Offset: 0x0002F529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BossDecayId
		{
			get
			{
				return this.bossDecayId_;
			}
			set
			{
				this.bossDecayId_ = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00031332 File Offset: 0x0002F532
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x0003133A File Offset: 0x0002F53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00031343 File Offset: 0x0002F543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CellMonster);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00031351 File Offset: 0x0002F551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CellMonster other)
		{
			return other != null && (other == this || (this.BossDecayId == other.BossDecayId && this.MonsterId == other.MonsterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00031390 File Offset: 0x0002F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BossDecayId != 0U)
			{
				num ^= this.BossDecayId.GetHashCode();
			}
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000313E8 File Offset: 0x0002F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x000313F0 File Offset: 0x0002F5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000313FC File Offset: 0x0002F5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.BossDecayId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BossDecayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00031458 File Offset: 0x0002F658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BossDecayId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BossDecayId);
			}
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000314B0 File Offset: 0x0002F6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CellMonster other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BossDecayId != 0U)
			{
				this.BossDecayId = other.BossDecayId;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00031500 File Offset: 0x0002F700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0003150C File Offset: 0x0002F70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BossDecayId = input.ReadUInt32();
					}
				}
				else
				{
					this.MonsterId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400071F RID: 1823
		private static readonly MessageParser<CellMonster> _parser = new MessageParser<CellMonster>(() => new CellMonster());

		// Token: 0x04000720 RID: 1824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000721 RID: 1825
		public const int BossDecayIdFieldNumber = 3;

		// Token: 0x04000722 RID: 1826
		private uint bossDecayId_;

		// Token: 0x04000723 RID: 1827
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x04000724 RID: 1828
		private uint monsterId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200107B RID: 4219
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneMonster : IMessage<SceneMonster>, IMessage, IEquatable<SceneMonster>, IDeepCloneable<SceneMonster>, IBufferMessage
	{
		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600BC03 RID: 48131 RVA: 0x001FA9F4 File Offset: 0x001F8BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneMonster> Parser
		{
			get
			{
				return SceneMonster._parser;
			}
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600BC04 RID: 48132 RVA: 0x001FA9FB File Offset: 0x001F8BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneMonsterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600BC05 RID: 48133 RVA: 0x001FAA0D File Offset: 0x001F8C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneMonster.Descriptor;
			}
		}

		// Token: 0x0600BC06 RID: 48134 RVA: 0x001FAA14 File Offset: 0x001F8C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonster()
		{
		}

		// Token: 0x0600BC07 RID: 48135 RVA: 0x001FAA1C File Offset: 0x001F8C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonster(SceneMonster other) : this()
		{
			this.maxHp_ = other.maxHp_;
			this.curHp_ = other.curHp_;
			this.monsterId_ = other.monsterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC08 RID: 48136 RVA: 0x001FAA59 File Offset: 0x001F8C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonster Clone()
		{
			return new SceneMonster(this);
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600BC09 RID: 48137 RVA: 0x001FAA61 File Offset: 0x001F8C61
		// (set) Token: 0x0600BC0A RID: 48138 RVA: 0x001FAA69 File Offset: 0x001F8C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxHp
		{
			get
			{
				return this.maxHp_;
			}
			set
			{
				this.maxHp_ = value;
			}
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600BC0B RID: 48139 RVA: 0x001FAA72 File Offset: 0x001F8C72
		// (set) Token: 0x0600BC0C RID: 48140 RVA: 0x001FAA7A File Offset: 0x001F8C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurHp
		{
			get
			{
				return this.curHp_;
			}
			set
			{
				this.curHp_ = value;
			}
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600BC0D RID: 48141 RVA: 0x001FAA83 File Offset: 0x001F8C83
		// (set) Token: 0x0600BC0E RID: 48142 RVA: 0x001FAA8B File Offset: 0x001F8C8B
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

		// Token: 0x0600BC0F RID: 48143 RVA: 0x001FAA94 File Offset: 0x001F8C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneMonster);
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x001FAAA4 File Offset: 0x001F8CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneMonster other)
		{
			return other != null && (other == this || (this.MaxHp == other.MaxHp && this.CurHp == other.CurHp && this.MonsterId == other.MonsterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC11 RID: 48145 RVA: 0x001FAB00 File Offset: 0x001F8D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxHp != 0U)
			{
				num ^= this.MaxHp.GetHashCode();
			}
			if (this.CurHp != 0U)
			{
				num ^= this.CurHp.GetHashCode();
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

		// Token: 0x0600BC12 RID: 48146 RVA: 0x001FAB71 File Offset: 0x001F8D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BC13 RID: 48147 RVA: 0x001FAB79 File Offset: 0x001F8D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC14 RID: 48148 RVA: 0x001FAB84 File Offset: 0x001F8D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxHp != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MaxHp);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.CurHp != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.CurHp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC15 RID: 48149 RVA: 0x001FABFC File Offset: 0x001F8DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxHp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxHp);
			}
			if (this.CurHp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurHp);
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

		// Token: 0x0600BC16 RID: 48150 RVA: 0x001FAC6C File Offset: 0x001F8E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneMonster other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxHp != 0U)
			{
				this.MaxHp = other.MaxHp;
			}
			if (other.CurHp != 0U)
			{
				this.CurHp = other.CurHp;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC17 RID: 48151 RVA: 0x001FACD0 File Offset: 0x001F8ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC18 RID: 48152 RVA: 0x001FACDC File Offset: 0x001F8EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurHp = input.ReadUInt32();
						}
					}
					else
					{
						this.MonsterId = input.ReadUInt32();
					}
				}
				else
				{
					this.MaxHp = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004C74 RID: 19572
		private static readonly MessageParser<SceneMonster> _parser = new MessageParser<SceneMonster>(() => new SceneMonster());

		// Token: 0x04004C75 RID: 19573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C76 RID: 19574
		public const int MaxHpFieldNumber = 10;

		// Token: 0x04004C77 RID: 19575
		private uint maxHp_;

		// Token: 0x04004C78 RID: 19576
		public const int CurHpFieldNumber = 14;

		// Token: 0x04004C79 RID: 19577
		private uint curHp_;

		// Token: 0x04004C7A RID: 19578
		public const int MonsterIdFieldNumber = 11;

		// Token: 0x04004C7B RID: 19579
		private uint monsterId_;
	}
}

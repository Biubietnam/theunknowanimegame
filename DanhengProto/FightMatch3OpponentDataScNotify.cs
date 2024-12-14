using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200054D RID: 1357
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3OpponentDataScNotify : IMessage<FightMatch3OpponentDataScNotify>, IMessage, IEquatable<FightMatch3OpponentDataScNotify>, IDeepCloneable<FightMatch3OpponentDataScNotify>, IBufferMessage
	{
		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x000A5AAB File Offset: 0x000A3CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3OpponentDataScNotify> Parser
		{
			get
			{
				return FightMatch3OpponentDataScNotify._parser;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06003C76 RID: 15478 RVA: 0x000A5AB2 File Offset: 0x000A3CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3OpponentDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06003C77 RID: 15479 RVA: 0x000A5AC4 File Offset: 0x000A3CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3OpponentDataScNotify.Descriptor;
			}
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x000A5ACB File Offset: 0x000A3CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3OpponentDataScNotify()
		{
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x000A5AD4 File Offset: 0x000A3CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3OpponentDataScNotify(FightMatch3OpponentDataScNotify other) : this()
		{
			this.pPJLNEDNDAH_ = other.pPJLNEDNDAH_;
			this.hp_ = other.hp_;
			this.dNAMDNCLOJC_ = other.dNAMDNCLOJC_;
			this.scoreId_ = other.scoreId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x000A5B34 File Offset: 0x000A3D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3OpponentDataScNotify Clone()
		{
			return new FightMatch3OpponentDataScNotify(this);
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x000A5B3C File Offset: 0x000A3D3C
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x000A5B44 File Offset: 0x000A3D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PPJLNEDNDAH
		{
			get
			{
				return this.pPJLNEDNDAH_;
			}
			set
			{
				this.pPJLNEDNDAH_ = value;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x000A5B4D File Offset: 0x000A3D4D
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x000A5B55 File Offset: 0x000A3D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Hp
		{
			get
			{
				return this.hp_;
			}
			set
			{
				this.hp_ = value;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06003C7F RID: 15487 RVA: 0x000A5B5E File Offset: 0x000A3D5E
		// (set) Token: 0x06003C80 RID: 15488 RVA: 0x000A5B66 File Offset: 0x000A3D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DNAMDNCLOJC
		{
			get
			{
				return this.dNAMDNCLOJC_;
			}
			set
			{
				this.dNAMDNCLOJC_ = value;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06003C81 RID: 15489 RVA: 0x000A5B6F File Offset: 0x000A3D6F
		// (set) Token: 0x06003C82 RID: 15490 RVA: 0x000A5B77 File Offset: 0x000A3D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06003C83 RID: 15491 RVA: 0x000A5B80 File Offset: 0x000A3D80
		// (set) Token: 0x06003C84 RID: 15492 RVA: 0x000A5B88 File Offset: 0x000A3D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BLBJBAMDNBN State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x000A5B91 File Offset: 0x000A3D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3OpponentDataScNotify);
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x000A5BA0 File Offset: 0x000A3DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3OpponentDataScNotify other)
		{
			return other != null && (other == this || (this.PPJLNEDNDAH == other.PPJLNEDNDAH && this.Hp == other.Hp && this.DNAMDNCLOJC == other.DNAMDNCLOJC && this.ScoreId == other.ScoreId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x000A5C1C File Offset: 0x000A3E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PPJLNEDNDAH != 0U)
			{
				num ^= this.PPJLNEDNDAH.GetHashCode();
			}
			if (this.Hp != 0U)
			{
				num ^= this.Hp.GetHashCode();
			}
			if (this.DNAMDNCLOJC != 0U)
			{
				num ^= this.DNAMDNCLOJC.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.State != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x000A5CC5 File Offset: 0x000A3EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x000A5CCD File Offset: 0x000A3ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x000A5CD8 File Offset: 0x000A3ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PPJLNEDNDAH != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PPJLNEDNDAH);
			}
			if (this.Hp != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Hp);
			}
			if (this.State != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.State);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.DNAMDNCLOJC != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.DNAMDNCLOJC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x000A5D88 File Offset: 0x000A3F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PPJLNEDNDAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPJLNEDNDAH);
			}
			if (this.Hp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Hp);
			}
			if (this.DNAMDNCLOJC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DNAMDNCLOJC);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.State != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x000A5E28 File Offset: 0x000A4028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3OpponentDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PPJLNEDNDAH != 0U)
			{
				this.PPJLNEDNDAH = other.PPJLNEDNDAH;
			}
			if (other.Hp != 0U)
			{
				this.Hp = other.Hp;
			}
			if (other.DNAMDNCLOJC != 0U)
			{
				this.DNAMDNCLOJC = other.DNAMDNCLOJC;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.State != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x000A5EB4 File Offset: 0x000A40B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x000A5EC0 File Offset: 0x000A40C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 40U)
					{
						this.PPJLNEDNDAH = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Hp = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.State = (BLBJBAMDNBN)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.DNAMDNCLOJC = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001840 RID: 6208
		private static readonly MessageParser<FightMatch3OpponentDataScNotify> _parser = new MessageParser<FightMatch3OpponentDataScNotify>(() => new FightMatch3OpponentDataScNotify());

		// Token: 0x04001841 RID: 6209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001842 RID: 6210
		public const int PPJLNEDNDAHFieldNumber = 5;

		// Token: 0x04001843 RID: 6211
		private uint pPJLNEDNDAH_;

		// Token: 0x04001844 RID: 6212
		public const int HpFieldNumber = 10;

		// Token: 0x04001845 RID: 6213
		private uint hp_;

		// Token: 0x04001846 RID: 6214
		public const int DNAMDNCLOJCFieldNumber = 13;

		// Token: 0x04001847 RID: 6215
		private uint dNAMDNCLOJC_;

		// Token: 0x04001848 RID: 6216
		public const int ScoreIdFieldNumber = 12;

		// Token: 0x04001849 RID: 6217
		private uint scoreId_;

		// Token: 0x0400184A RID: 6218
		public const int StateFieldNumber = 11;

		// Token: 0x0400184B RID: 6219
		private BLBJBAMDNBN state_;
	}
}

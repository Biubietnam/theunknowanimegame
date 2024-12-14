using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000979 RID: 2425
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JMDAEBFHNAI : IMessage<JMDAEBFHNAI>, IMessage, IEquatable<JMDAEBFHNAI>, IDeepCloneable<JMDAEBFHNAI>, IBufferMessage
	{
		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06006C6B RID: 27755 RVA: 0x001216B7 File Offset: 0x0011F8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JMDAEBFHNAI> Parser
		{
			get
			{
				return JMDAEBFHNAI._parser;
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06006C6C RID: 27756 RVA: 0x001216BE File Offset: 0x0011F8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JMDAEBFHNAIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06006C6D RID: 27757 RVA: 0x001216D0 File Offset: 0x0011F8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JMDAEBFHNAI.Descriptor;
			}
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x001216D7 File Offset: 0x0011F8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JMDAEBFHNAI()
		{
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x001216E0 File Offset: 0x0011F8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JMDAEBFHNAI(JMDAEBFHNAI other) : this()
		{
			this.ePJPMBMOKAJ_ = other.ePJPMBMOKAJ_;
			this.turnLeftCount_ = other.turnLeftCount_;
			this.challengeId_ = other.challengeId_;
			this.hLJELCNLJKI_ = other.hLJELCNLJKI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x00121734 File Offset: 0x0011F934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JMDAEBFHNAI Clone()
		{
			return new JMDAEBFHNAI(this);
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06006C71 RID: 27761 RVA: 0x0012173C File Offset: 0x0011F93C
		// (set) Token: 0x06006C72 RID: 27762 RVA: 0x00121744 File Offset: 0x0011F944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EPJPMBMOKAJ
		{
			get
			{
				return this.ePJPMBMOKAJ_;
			}
			set
			{
				this.ePJPMBMOKAJ_ = value;
			}
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x0012174D File Offset: 0x0011F94D
		// (set) Token: 0x06006C74 RID: 27764 RVA: 0x00121755 File Offset: 0x0011F955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TurnLeftCount
		{
			get
			{
				return this.turnLeftCount_;
			}
			set
			{
				this.turnLeftCount_ = value;
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x06006C75 RID: 27765 RVA: 0x0012175E File Offset: 0x0011F95E
		// (set) Token: 0x06006C76 RID: 27766 RVA: 0x00121766 File Offset: 0x0011F966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06006C77 RID: 27767 RVA: 0x0012176F File Offset: 0x0011F96F
		// (set) Token: 0x06006C78 RID: 27768 RVA: 0x00121777 File Offset: 0x0011F977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AAAIFJOAAGO HLJELCNLJKI
		{
			get
			{
				return this.hLJELCNLJKI_;
			}
			set
			{
				this.hLJELCNLJKI_ = value;
			}
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x00121780 File Offset: 0x0011F980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JMDAEBFHNAI);
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x00121790 File Offset: 0x0011F990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JMDAEBFHNAI other)
		{
			return other != null && (other == this || (this.EPJPMBMOKAJ == other.EPJPMBMOKAJ && this.TurnLeftCount == other.TurnLeftCount && this.ChallengeId == other.ChallengeId && this.HLJELCNLJKI == other.HLJELCNLJKI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x001217FC File Offset: 0x0011F9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EPJPMBMOKAJ != 0U)
			{
				num ^= this.EPJPMBMOKAJ.GetHashCode();
			}
			if (this.TurnLeftCount != 0U)
			{
				num ^= this.TurnLeftCount.GetHashCode();
			}
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.HLJELCNLJKI != AAAIFJOAAGO.FightFestBattleRankC)
			{
				num ^= this.HLJELCNLJKI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x0012188C File Offset: 0x0011FA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x00121894 File Offset: 0x0011FA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x001218A0 File Offset: 0x0011FAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HLJELCNLJKI != AAAIFJOAAGO.FightFestBattleRankC)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.HLJELCNLJKI);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.TurnLeftCount != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.TurnLeftCount);
			}
			if (this.EPJPMBMOKAJ != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EPJPMBMOKAJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00121934 File Offset: 0x0011FB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EPJPMBMOKAJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EPJPMBMOKAJ);
			}
			if (this.TurnLeftCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TurnLeftCount);
			}
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.HLJELCNLJKI != AAAIFJOAAGO.FightFestBattleRankC)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.HLJELCNLJKI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x001219BC File Offset: 0x0011FBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JMDAEBFHNAI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EPJPMBMOKAJ != 0U)
			{
				this.EPJPMBMOKAJ = other.EPJPMBMOKAJ;
			}
			if (other.TurnLeftCount != 0U)
			{
				this.TurnLeftCount = other.TurnLeftCount;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.HLJELCNLJKI != AAAIFJOAAGO.FightFestBattleRankC)
			{
				this.HLJELCNLJKI = other.HLJELCNLJKI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x00121A34 File Offset: 0x0011FC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x00121A40 File Offset: 0x0011FC40
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
						this.HLJELCNLJKI = (AAAIFJOAAGO)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.ChallengeId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.TurnLeftCount = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.EPJPMBMOKAJ = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002987 RID: 10631
		private static readonly MessageParser<JMDAEBFHNAI> _parser = new MessageParser<JMDAEBFHNAI>(() => new JMDAEBFHNAI());

		// Token: 0x04002988 RID: 10632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002989 RID: 10633
		public const int EPJPMBMOKAJFieldNumber = 10;

		// Token: 0x0400298A RID: 10634
		private uint ePJPMBMOKAJ_;

		// Token: 0x0400298B RID: 10635
		public const int TurnLeftCountFieldNumber = 8;

		// Token: 0x0400298C RID: 10636
		private uint turnLeftCount_;

		// Token: 0x0400298D RID: 10637
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x0400298E RID: 10638
		private uint challengeId_;

		// Token: 0x0400298F RID: 10639
		public const int HLJELCNLJKIFieldNumber = 2;

		// Token: 0x04002990 RID: 10640
		private AAAIFJOAAGO hLJELCNLJKI_;
	}
}

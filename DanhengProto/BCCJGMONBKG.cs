using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200010F RID: 271
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BCCJGMONBKG : IMessage<BCCJGMONBKG>, IMessage, IEquatable<BCCJGMONBKG>, IDeepCloneable<BCCJGMONBKG>, IBufferMessage
	{
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00024A73 File Offset: 0x00022C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BCCJGMONBKG> Parser
		{
			get
			{
				return BCCJGMONBKG._parser;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00024A7A File Offset: 0x00022C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BCCJGMONBKGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00024A8C File Offset: 0x00022C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BCCJGMONBKG.Descriptor;
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00024A93 File Offset: 0x00022C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BCCJGMONBKG()
		{
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00024A9C File Offset: 0x00022C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BCCJGMONBKG(BCCJGMONBKG other) : this()
		{
			this.mMLBFPNPHCL_ = other.mMLBFPNPHCL_;
			this.groupId_ = other.groupId_;
			this.challengeDefault_ = ((other.challengeDefault_ != null) ? other.challengeDefault_.Clone() : null);
			this.challengeStory_ = ((other.challengeStory_ != null) ? other.challengeStory_.Clone() : null);
			this.challengeBoss_ = ((other.challengeBoss_ != null) ? other.challengeBoss_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00024B2C File Offset: 0x00022D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BCCJGMONBKG Clone()
		{
			return new BCCJGMONBKG(this);
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00024B34 File Offset: 0x00022D34
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00024B3C File Offset: 0x00022D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMLBFPNPHCL
		{
			get
			{
				return this.mMLBFPNPHCL_;
			}
			set
			{
				this.mMLBFPNPHCL_ = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00024B45 File Offset: 0x00022D45
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00024B4D File Offset: 0x00022D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00024B56 File Offset: 0x00022D56
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00024B5E File Offset: 0x00022D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStatistics ChallengeDefault
		{
			get
			{
				return this.challengeDefault_;
			}
			set
			{
				this.challengeDefault_ = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00024B67 File Offset: 0x00022D67
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00024B6F File Offset: 0x00022D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStatistics ChallengeStory
		{
			get
			{
				return this.challengeStory_;
			}
			set
			{
				this.challengeStory_ = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00024B78 File Offset: 0x00022D78
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00024B80 File Offset: 0x00022D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStatistics ChallengeBoss
		{
			get
			{
				return this.challengeBoss_;
			}
			set
			{
				this.challengeBoss_ = value;
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00024B89 File Offset: 0x00022D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BCCJGMONBKG);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00024B98 File Offset: 0x00022D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BCCJGMONBKG other)
		{
			return other != null && (other == this || (this.MMLBFPNPHCL == other.MMLBFPNPHCL && this.GroupId == other.GroupId && object.Equals(this.ChallengeDefault, other.ChallengeDefault) && object.Equals(this.ChallengeStory, other.ChallengeStory) && object.Equals(this.ChallengeBoss, other.ChallengeBoss) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00024C20 File Offset: 0x00022E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MMLBFPNPHCL != 0U)
			{
				num ^= this.MMLBFPNPHCL.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.challengeDefault_ != null)
			{
				num ^= this.ChallengeDefault.GetHashCode();
			}
			if (this.challengeStory_ != null)
			{
				num ^= this.ChallengeStory.GetHashCode();
			}
			if (this.challengeBoss_ != null)
			{
				num ^= this.ChallengeBoss.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00024CBA File Offset: 0x00022EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00024CC2 File Offset: 0x00022EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00024CCC File Offset: 0x00022ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GroupId);
			}
			if (this.MMLBFPNPHCL != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.MMLBFPNPHCL);
			}
			if (this.challengeBoss_ != null)
			{
				output.WriteRawTag(210, 14);
				output.WriteMessage(this.ChallengeBoss);
			}
			if (this.challengeStory_ != null)
			{
				output.WriteRawTag(202, 26);
				output.WriteMessage(this.ChallengeStory);
			}
			if (this.challengeDefault_ != null)
			{
				output.WriteRawTag(146, 47);
				output.WriteMessage(this.ChallengeDefault);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00024D88 File Offset: 0x00022F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MMLBFPNPHCL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMLBFPNPHCL);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.challengeDefault_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChallengeDefault);
			}
			if (this.challengeStory_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChallengeStory);
			}
			if (this.challengeBoss_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChallengeBoss);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00024E28 File Offset: 0x00023028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BCCJGMONBKG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MMLBFPNPHCL != 0U)
			{
				this.MMLBFPNPHCL = other.MMLBFPNPHCL;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.challengeDefault_ != null)
			{
				if (this.challengeDefault_ == null)
				{
					this.ChallengeDefault = new ChallengeStatistics();
				}
				this.ChallengeDefault.MergeFrom(other.ChallengeDefault);
			}
			if (other.challengeStory_ != null)
			{
				if (this.challengeStory_ == null)
				{
					this.ChallengeStory = new ChallengeStoryStatistics();
				}
				this.ChallengeStory.MergeFrom(other.ChallengeStory);
			}
			if (other.challengeBoss_ != null)
			{
				if (this.challengeBoss_ == null)
				{
					this.ChallengeBoss = new ChallengeBossStatistics();
				}
				this.ChallengeBoss.MergeFrom(other.ChallengeBoss);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00024EFC File Offset: 0x000230FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00024F08 File Offset: 0x00023108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 48U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.MMLBFPNPHCL = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 1874U)
					{
						if (this.challengeBoss_ == null)
						{
							this.ChallengeBoss = new ChallengeBossStatistics();
						}
						input.ReadMessage(this.ChallengeBoss);
						continue;
					}
					if (num == 3402U)
					{
						if (this.challengeStory_ == null)
						{
							this.ChallengeStory = new ChallengeStoryStatistics();
						}
						input.ReadMessage(this.ChallengeStory);
						continue;
					}
					if (num == 6034U)
					{
						if (this.challengeDefault_ == null)
						{
							this.ChallengeDefault = new ChallengeStatistics();
						}
						input.ReadMessage(this.ChallengeDefault);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000550 RID: 1360
		private static readonly MessageParser<BCCJGMONBKG> _parser = new MessageParser<BCCJGMONBKG>(() => new BCCJGMONBKG());

		// Token: 0x04000551 RID: 1361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000552 RID: 1362
		public const int MMLBFPNPHCLFieldNumber = 11;

		// Token: 0x04000553 RID: 1363
		private uint mMLBFPNPHCL_;

		// Token: 0x04000554 RID: 1364
		public const int GroupIdFieldNumber = 6;

		// Token: 0x04000555 RID: 1365
		private uint groupId_;

		// Token: 0x04000556 RID: 1366
		public const int ChallengeDefaultFieldNumber = 754;

		// Token: 0x04000557 RID: 1367
		private ChallengeStatistics challengeDefault_;

		// Token: 0x04000558 RID: 1368
		public const int ChallengeStoryFieldNumber = 425;

		// Token: 0x04000559 RID: 1369
		private ChallengeStoryStatistics challengeStory_;

		// Token: 0x0400055A RID: 1370
		public const int ChallengeBossFieldNumber = 234;

		// Token: 0x0400055B RID: 1371
		private ChallengeBossStatistics challengeBoss_;
	}
}

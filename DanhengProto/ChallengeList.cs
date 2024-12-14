using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001AD RID: 429
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeList : IMessage<ChallengeList>, IMessage, IEquatable<ChallengeList>, IDeepCloneable<ChallengeList>, IBufferMessage
	{
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00037A34 File Offset: 0x00035C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeList> Parser
		{
			get
			{
				return ChallengeList._parser;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00037A3B File Offset: 0x00035C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00037A4D File Offset: 0x00035C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeList.Descriptor;
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00037A54 File Offset: 0x00035C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeList()
		{
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00037A5C File Offset: 0x00035C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeList(ChallengeList other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.cFIMDHHMKDJ_ = other.cFIMDHHMKDJ_;
			this.star_ = other.star_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00037A99 File Offset: 0x00035C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeList Clone()
		{
			return new ChallengeList(this);
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x00037AA1 File Offset: 0x00035CA1
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x00037AA9 File Offset: 0x00035CA9
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

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00037AB2 File Offset: 0x00035CB2
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00037ABA File Offset: 0x00035CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CFIMDHHMKDJ
		{
			get
			{
				return this.cFIMDHHMKDJ_;
			}
			set
			{
				this.cFIMDHHMKDJ_ = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00037AC3 File Offset: 0x00035CC3
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00037ACB File Offset: 0x00035CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00037AD4 File Offset: 0x00035CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeList);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00037AE4 File Offset: 0x00035CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeList other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.CFIMDHHMKDJ == other.CFIMDHHMKDJ && this.Star == other.Star && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00037B40 File Offset: 0x00035D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.CFIMDHHMKDJ)
			{
				num ^= this.CFIMDHHMKDJ.GetHashCode();
			}
			if (this.Star != 0U)
			{
				num ^= this.Star.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00037BB1 File Offset: 0x00035DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00037BB9 File Offset: 0x00035DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00037BC4 File Offset: 0x00035DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Star != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Star);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.CFIMDHHMKDJ)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.CFIMDHHMKDJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00037C3C File Offset: 0x00035E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.CFIMDHHMKDJ)
			{
				num += 2;
			}
			if (this.Star != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Star);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00037CA0 File Offset: 0x00035EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeList other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.CFIMDHHMKDJ)
			{
				this.CFIMDHHMKDJ = other.CFIMDHHMKDJ;
			}
			if (other.Star != 0U)
			{
				this.Star = other.Star;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00037D04 File Offset: 0x00035F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00037D10 File Offset: 0x00035F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CFIMDHHMKDJ = input.ReadBool();
						}
					}
					else
					{
						this.ChallengeId = input.ReadUInt32();
					}
				}
				else
				{
					this.Star = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000820 RID: 2080
		private static readonly MessageParser<ChallengeList> _parser = new MessageParser<ChallengeList>(() => new ChallengeList());

		// Token: 0x04000821 RID: 2081
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000822 RID: 2082
		public const int ChallengeIdFieldNumber = 12;

		// Token: 0x04000823 RID: 2083
		private uint challengeId_;

		// Token: 0x04000824 RID: 2084
		public const int CFIMDHHMKDJFieldNumber = 13;

		// Token: 0x04000825 RID: 2085
		private bool cFIMDHHMKDJ_;

		// Token: 0x04000826 RID: 2086
		public const int StarFieldNumber = 2;

		// Token: 0x04000827 RID: 2087
		private uint star_;
	}
}

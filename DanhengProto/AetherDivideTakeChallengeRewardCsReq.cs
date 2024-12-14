using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200006D RID: 109
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideTakeChallengeRewardCsReq : IMessage<AetherDivideTakeChallengeRewardCsReq>, IMessage, IEquatable<AetherDivideTakeChallengeRewardCsReq>, IDeepCloneable<AetherDivideTakeChallengeRewardCsReq>, IBufferMessage
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0000D739 File Offset: 0x0000B939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideTakeChallengeRewardCsReq> Parser
		{
			get
			{
				return AetherDivideTakeChallengeRewardCsReq._parser;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0000D740 File Offset: 0x0000B940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideTakeChallengeRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0000D752 File Offset: 0x0000B952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideTakeChallengeRewardCsReq.Descriptor;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000D759 File Offset: 0x0000B959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTakeChallengeRewardCsReq()
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000D761 File Offset: 0x0000B961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTakeChallengeRewardCsReq(AetherDivideTakeChallengeRewardCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000D786 File Offset: 0x0000B986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTakeChallengeRewardCsReq Clone()
		{
			return new AetherDivideTakeChallengeRewardCsReq(this);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000D78E File Offset: 0x0000B98E
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x0000D796 File Offset: 0x0000B996
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

		// Token: 0x06000487 RID: 1159 RVA: 0x0000D79F File Offset: 0x0000B99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideTakeChallengeRewardCsReq);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000D7AD File Offset: 0x0000B9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideTakeChallengeRewardCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000D81B File Offset: 0x0000BA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000D823 File Offset: 0x0000BA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000D82C File Offset: 0x0000BA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000D860 File Offset: 0x0000BA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000D89E File Offset: 0x0000BA9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideTakeChallengeRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000D8CF File Offset: 0x0000BACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040001B0 RID: 432
		private static readonly MessageParser<AetherDivideTakeChallengeRewardCsReq> _parser = new MessageParser<AetherDivideTakeChallengeRewardCsReq>(() => new AetherDivideTakeChallengeRewardCsReq());

		// Token: 0x040001B1 RID: 433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001B2 RID: 434
		public const int ChallengeIdFieldNumber = 15;

		// Token: 0x040001B3 RID: 435
		private uint challengeId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002C5 RID: 709
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChooseBoxingClubStageOptionalBuffCsReq : IMessage<ChooseBoxingClubStageOptionalBuffCsReq>, IMessage, IEquatable<ChooseBoxingClubStageOptionalBuffCsReq>, IDeepCloneable<ChooseBoxingClubStageOptionalBuffCsReq>, IBufferMessage
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00059B69 File Offset: 0x00057D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChooseBoxingClubStageOptionalBuffCsReq> Parser
		{
			get
			{
				return ChooseBoxingClubStageOptionalBuffCsReq._parser;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00059B70 File Offset: 0x00057D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChooseBoxingClubStageOptionalBuffCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00059B82 File Offset: 0x00057D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChooseBoxingClubStageOptionalBuffCsReq.Descriptor;
			}
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00059B89 File Offset: 0x00057D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubStageOptionalBuffCsReq()
		{
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00059B91 File Offset: 0x00057D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubStageOptionalBuffCsReq(ChooseBoxingClubStageOptionalBuffCsReq other) : this()
		{
			this.nEBEOKGHNAG_ = other.nEBEOKGHNAG_;
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00059BC2 File Offset: 0x00057DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubStageOptionalBuffCsReq Clone()
		{
			return new ChooseBoxingClubStageOptionalBuffCsReq(this);
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00059BCA File Offset: 0x00057DCA
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00059BD2 File Offset: 0x00057DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NEBEOKGHNAG
		{
			get
			{
				return this.nEBEOKGHNAG_;
			}
			set
			{
				this.nEBEOKGHNAG_ = value;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00059BDB File Offset: 0x00057DDB
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x00059BE3 File Offset: 0x00057DE3
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

		// Token: 0x06001F87 RID: 8071 RVA: 0x00059BEC File Offset: 0x00057DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChooseBoxingClubStageOptionalBuffCsReq);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00059BFA File Offset: 0x00057DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChooseBoxingClubStageOptionalBuffCsReq other)
		{
			return other != null && (other == this || (this.NEBEOKGHNAG == other.NEBEOKGHNAG && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00059C38 File Offset: 0x00057E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NEBEOKGHNAG != 0U)
			{
				num ^= this.NEBEOKGHNAG.GetHashCode();
			}
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

		// Token: 0x06001F8A RID: 8074 RVA: 0x00059C90 File Offset: 0x00057E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00059C98 File Offset: 0x00057E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00059CA4 File Offset: 0x00057EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NEBEOKGHNAG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NEBEOKGHNAG);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00059D00 File Offset: 0x00057F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NEBEOKGHNAG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NEBEOKGHNAG);
			}
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

		// Token: 0x06001F8E RID: 8078 RVA: 0x00059D58 File Offset: 0x00057F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChooseBoxingClubStageOptionalBuffCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NEBEOKGHNAG != 0U)
			{
				this.NEBEOKGHNAG = other.NEBEOKGHNAG;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00059DA8 File Offset: 0x00057FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00059DB4 File Offset: 0x00057FB4
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
						this.ChallengeId = input.ReadUInt32();
					}
				}
				else
				{
					this.NEBEOKGHNAG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D0C RID: 3340
		private static readonly MessageParser<ChooseBoxingClubStageOptionalBuffCsReq> _parser = new MessageParser<ChooseBoxingClubStageOptionalBuffCsReq>(() => new ChooseBoxingClubStageOptionalBuffCsReq());

		// Token: 0x04000D0D RID: 3341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D0E RID: 3342
		public const int NEBEOKGHNAGFieldNumber = 2;

		// Token: 0x04000D0F RID: 3343
		private uint nEBEOKGHNAG_;

		// Token: 0x04000D10 RID: 3344
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x04000D11 RID: 3345
		private uint challengeId_;
	}
}

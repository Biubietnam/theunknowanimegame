using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000645 RID: 1605
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChallengeRecommendLineupListCsReq : IMessage<GetChallengeRecommendLineupListCsReq>, IMessage, IEquatable<GetChallengeRecommendLineupListCsReq>, IDeepCloneable<GetChallengeRecommendLineupListCsReq>, IBufferMessage
	{
		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06004806 RID: 18438 RVA: 0x000C522D File Offset: 0x000C342D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChallengeRecommendLineupListCsReq> Parser
		{
			get
			{
				return GetChallengeRecommendLineupListCsReq._parser;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x000C5234 File Offset: 0x000C3434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChallengeRecommendLineupListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06004808 RID: 18440 RVA: 0x000C5246 File Offset: 0x000C3446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChallengeRecommendLineupListCsReq.Descriptor;
			}
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x000C524D File Offset: 0x000C344D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRecommendLineupListCsReq()
		{
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x000C5255 File Offset: 0x000C3455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRecommendLineupListCsReq(GetChallengeRecommendLineupListCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x000C527A File Offset: 0x000C347A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRecommendLineupListCsReq Clone()
		{
			return new GetChallengeRecommendLineupListCsReq(this);
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x0600480C RID: 18444 RVA: 0x000C5282 File Offset: 0x000C3482
		// (set) Token: 0x0600480D RID: 18445 RVA: 0x000C528A File Offset: 0x000C348A
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

		// Token: 0x0600480E RID: 18446 RVA: 0x000C5293 File Offset: 0x000C3493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChallengeRecommendLineupListCsReq);
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x000C52A1 File Offset: 0x000C34A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChallengeRecommendLineupListCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x000C52D0 File Offset: 0x000C34D0
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

		// Token: 0x06004811 RID: 18449 RVA: 0x000C530F File Offset: 0x000C350F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x000C5317 File Offset: 0x000C3517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x000C5320 File Offset: 0x000C3520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x000C5354 File Offset: 0x000C3554
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

		// Token: 0x06004815 RID: 18453 RVA: 0x000C5392 File Offset: 0x000C3592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChallengeRecommendLineupListCsReq other)
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

		// Token: 0x06004816 RID: 18454 RVA: 0x000C53C3 File Offset: 0x000C35C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x000C53CC File Offset: 0x000C35CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CCC RID: 7372
		private static readonly MessageParser<GetChallengeRecommendLineupListCsReq> _parser = new MessageParser<GetChallengeRecommendLineupListCsReq>(() => new GetChallengeRecommendLineupListCsReq());

		// Token: 0x04001CCD RID: 7373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CCE RID: 7374
		public const int ChallengeIdFieldNumber = 5;

		// Token: 0x04001CCF RID: 7375
		private uint challengeId_;
	}
}

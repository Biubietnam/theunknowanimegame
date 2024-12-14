using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200118D RID: 4493
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartAetherDivideChallengeBattleCsReq : IMessage<StartAetherDivideChallengeBattleCsReq>, IMessage, IEquatable<StartAetherDivideChallengeBattleCsReq>, IDeepCloneable<StartAetherDivideChallengeBattleCsReq>, IBufferMessage
	{
		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600C88C RID: 51340 RVA: 0x0021A0ED File Offset: 0x002182ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartAetherDivideChallengeBattleCsReq> Parser
		{
			get
			{
				return StartAetherDivideChallengeBattleCsReq._parser;
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600C88D RID: 51341 RVA: 0x0021A0F4 File Offset: 0x002182F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideChallengeBattleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600C88E RID: 51342 RVA: 0x0021A106 File Offset: 0x00218306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartAetherDivideChallengeBattleCsReq.Descriptor;
			}
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x0021A10D File Offset: 0x0021830D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideChallengeBattleCsReq()
		{
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x0021A115 File Offset: 0x00218315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideChallengeBattleCsReq(StartAetherDivideChallengeBattleCsReq other) : this()
		{
			this.lineupIndex_ = other.lineupIndex_;
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C891 RID: 51345 RVA: 0x0021A146 File Offset: 0x00218346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideChallengeBattleCsReq Clone()
		{
			return new StartAetherDivideChallengeBattleCsReq(this);
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600C892 RID: 51346 RVA: 0x0021A14E File Offset: 0x0021834E
		// (set) Token: 0x0600C893 RID: 51347 RVA: 0x0021A156 File Offset: 0x00218356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LineupIndex
		{
			get
			{
				return this.lineupIndex_;
			}
			set
			{
				this.lineupIndex_ = value;
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600C894 RID: 51348 RVA: 0x0021A15F File Offset: 0x0021835F
		// (set) Token: 0x0600C895 RID: 51349 RVA: 0x0021A167 File Offset: 0x00218367
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

		// Token: 0x0600C896 RID: 51350 RVA: 0x0021A170 File Offset: 0x00218370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartAetherDivideChallengeBattleCsReq);
		}

		// Token: 0x0600C897 RID: 51351 RVA: 0x0021A17E File Offset: 0x0021837E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartAetherDivideChallengeBattleCsReq other)
		{
			return other != null && (other == this || (this.LineupIndex == other.LineupIndex && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C898 RID: 51352 RVA: 0x0021A1BC File Offset: 0x002183BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LineupIndex != 0U)
			{
				num ^= this.LineupIndex.GetHashCode();
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

		// Token: 0x0600C899 RID: 51353 RVA: 0x0021A214 File Offset: 0x00218414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C89A RID: 51354 RVA: 0x0021A21C File Offset: 0x0021841C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C89B RID: 51355 RVA: 0x0021A228 File Offset: 0x00218428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.LineupIndex != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.LineupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C89C RID: 51356 RVA: 0x0021A284 File Offset: 0x00218484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LineupIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LineupIndex);
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

		// Token: 0x0600C89D RID: 51357 RVA: 0x0021A2DC File Offset: 0x002184DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartAetherDivideChallengeBattleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LineupIndex != 0U)
			{
				this.LineupIndex = other.LineupIndex;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C89E RID: 51358 RVA: 0x0021A32C File Offset: 0x0021852C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C89F RID: 51359 RVA: 0x0021A338 File Offset: 0x00218538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LineupIndex = input.ReadUInt32();
					}
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040050F4 RID: 20724
		private static readonly MessageParser<StartAetherDivideChallengeBattleCsReq> _parser = new MessageParser<StartAetherDivideChallengeBattleCsReq>(() => new StartAetherDivideChallengeBattleCsReq());

		// Token: 0x040050F5 RID: 20725
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050F6 RID: 20726
		public const int LineupIndexFieldNumber = 13;

		// Token: 0x040050F7 RID: 20727
		private uint lineupIndex_;

		// Token: 0x040050F8 RID: 20728
		public const int ChallengeIdFieldNumber = 8;

		// Token: 0x040050F9 RID: 20729
		private uint challengeId_;
	}
}

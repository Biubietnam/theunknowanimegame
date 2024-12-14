using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A5 RID: 4517
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartChallengeCsReq : IMessage<StartChallengeCsReq>, IMessage, IEquatable<StartChallengeCsReq>, IDeepCloneable<StartChallengeCsReq>, IBufferMessage
	{
		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600C9A2 RID: 51618 RVA: 0x0021CB5F File Offset: 0x0021AD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartChallengeCsReq> Parser
		{
			get
			{
				return StartChallengeCsReq._parser;
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600C9A3 RID: 51619 RVA: 0x0021CB66 File Offset: 0x0021AD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartChallengeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600C9A4 RID: 51620 RVA: 0x0021CB78 File Offset: 0x0021AD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartChallengeCsReq.Descriptor;
			}
		}

		// Token: 0x0600C9A5 RID: 51621 RVA: 0x0021CB7F File Offset: 0x0021AD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartChallengeCsReq()
		{
		}

		// Token: 0x0600C9A6 RID: 51622 RVA: 0x0021CBA0 File Offset: 0x0021ADA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartChallengeCsReq(StartChallengeCsReq other) : this()
		{
			this.secondLineup_ = other.secondLineup_.Clone();
			this.challengeId_ = other.challengeId_;
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.firstLineup_ = other.firstLineup_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9A7 RID: 51623 RVA: 0x0021CC0E File Offset: 0x0021AE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartChallengeCsReq Clone()
		{
			return new StartChallengeCsReq(this);
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600C9A8 RID: 51624 RVA: 0x0021CC16 File Offset: 0x0021AE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SecondLineup
		{
			get
			{
				return this.secondLineup_;
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600C9A9 RID: 51625 RVA: 0x0021CC1E File Offset: 0x0021AE1E
		// (set) Token: 0x0600C9AA RID: 51626 RVA: 0x0021CC26 File Offset: 0x0021AE26
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

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600C9AB RID: 51627 RVA: 0x0021CC2F File Offset: 0x0021AE2F
		// (set) Token: 0x0600C9AC RID: 51628 RVA: 0x0021CC37 File Offset: 0x0021AE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBuffInfo StageInfo
		{
			get
			{
				return this.stageInfo_;
			}
			set
			{
				this.stageInfo_ = value;
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600C9AD RID: 51629 RVA: 0x0021CC40 File Offset: 0x0021AE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FirstLineup
		{
			get
			{
				return this.firstLineup_;
			}
		}

		// Token: 0x0600C9AE RID: 51630 RVA: 0x0021CC48 File Offset: 0x0021AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartChallengeCsReq);
		}

		// Token: 0x0600C9AF RID: 51631 RVA: 0x0021CC58 File Offset: 0x0021AE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartChallengeCsReq other)
		{
			return other != null && (other == this || (this.secondLineup_.Equals(other.secondLineup_) && this.ChallengeId == other.ChallengeId && object.Equals(this.StageInfo, other.StageInfo) && this.firstLineup_.Equals(other.firstLineup_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x0021CCD0 File Offset: 0x0021AED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.secondLineup_.GetHashCode();
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			num ^= this.firstLineup_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x0021CD41 File Offset: 0x0021AF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C9B2 RID: 51634 RVA: 0x0021CD49 File Offset: 0x0021AF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9B3 RID: 51635 RVA: 0x0021CD54 File Offset: 0x0021AF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.StageInfo);
			}
			this.firstLineup_.WriteTo(ref output, StartChallengeCsReq._repeated_firstLineup_codec);
			this.secondLineup_.WriteTo(ref output, StartChallengeCsReq._repeated_secondLineup_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9B4 RID: 51636 RVA: 0x0021CDD0 File Offset: 0x0021AFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.secondLineup_.CalculateSize(StartChallengeCsReq._repeated_secondLineup_codec);
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			num += this.firstLineup_.CalculateSize(StartChallengeCsReq._repeated_firstLineup_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9B5 RID: 51637 RVA: 0x0021CE4C File Offset: 0x0021B04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartChallengeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.secondLineup_.Add(other.secondLineup_);
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChallengeBuffInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			this.firstLineup_.Add(other.firstLineup_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9B6 RID: 51638 RVA: 0x0021CED6 File Offset: 0x0021B0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9B7 RID: 51639 RVA: 0x0021CEE0 File Offset: 0x0021B0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 32U)
					{
						this.ChallengeId = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.stageInfo_ == null)
						{
							this.StageInfo = new ChallengeBuffInfo();
						}
						input.ReadMessage(this.StageInfo);
						continue;
					}
					if (num == 72U)
					{
						goto IL_6D;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_6D;
					}
					if (num == 96U || num == 98U)
					{
						this.secondLineup_.AddEntriesFrom(ref input, StartChallengeCsReq._repeated_secondLineup_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_6D:
				this.firstLineup_.AddEntriesFrom(ref input, StartChallengeCsReq._repeated_firstLineup_codec);
			}
		}

		// Token: 0x0400514E RID: 20814
		private static readonly MessageParser<StartChallengeCsReq> _parser = new MessageParser<StartChallengeCsReq>(() => new StartChallengeCsReq());

		// Token: 0x0400514F RID: 20815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005150 RID: 20816
		public const int SecondLineupFieldNumber = 12;

		// Token: 0x04005151 RID: 20817
		private static readonly FieldCodec<uint> _repeated_secondLineup_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04005152 RID: 20818
		private readonly RepeatedField<uint> secondLineup_ = new RepeatedField<uint>();

		// Token: 0x04005153 RID: 20819
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x04005154 RID: 20820
		private uint challengeId_;

		// Token: 0x04005155 RID: 20821
		public const int StageInfoFieldNumber = 5;

		// Token: 0x04005156 RID: 20822
		private ChallengeBuffInfo stageInfo_;

		// Token: 0x04005157 RID: 20823
		public const int FirstLineupFieldNumber = 9;

		// Token: 0x04005158 RID: 20824
		private static readonly FieldCodec<uint> _repeated_firstLineup_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04005159 RID: 20825
		private readonly RepeatedField<uint> firstLineup_ = new RepeatedField<uint>();
	}
}

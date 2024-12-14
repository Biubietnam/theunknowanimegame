using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200029F RID: 671
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueStartCsReq : IMessage<ChessRogueStartCsReq>, IMessage, IEquatable<ChessRogueStartCsReq>, IDeepCloneable<ChessRogueStartCsReq>, IBufferMessage
	{
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0005581F File Offset: 0x00053A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueStartCsReq> Parser
		{
			get
			{
				return ChessRogueStartCsReq._parser;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00055826 File Offset: 0x00053A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueStartCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00055838 File Offset: 0x00053A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueStartCsReq.Descriptor;
			}
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0005583F File Offset: 0x00053A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStartCsReq()
		{
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00055874 File Offset: 0x00053A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStartCsReq(ChessRogueStartCsReq other) : this()
		{
			this.branchId_ = other.branchId_;
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.disableAeonIdList_ = other.disableAeonIdList_.Clone();
			this.startDifficultyIdList_ = other.startDifficultyIdList_.Clone();
			this.id_ = other.id_;
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.aeonId_ = other.aeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00055900 File Offset: 0x00053B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStartCsReq Clone()
		{
			return new ChessRogueStartCsReq(this);
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00055908 File Offset: 0x00053B08
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00055910 File Offset: 0x00053B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BranchId
		{
			get
			{
				return this.branchId_;
			}
			set
			{
				this.branchId_ = value;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00055919 File Offset: 0x00053B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00055921 File Offset: 0x00053B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DisableAeonIdList
		{
			get
			{
				return this.disableAeonIdList_;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00055929 File Offset: 0x00053B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> StartDifficultyIdList
		{
			get
			{
				return this.startDifficultyIdList_;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00055931 File Offset: 0x00053B31
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x00055939 File Offset: 0x00053B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00055942 File Offset: 0x00053B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0005594A File Offset: 0x00053B4A
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x00055952 File Offset: 0x00053B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0005595B File Offset: 0x00053B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueStartCsReq);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0005596C File Offset: 0x00053B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueStartCsReq other)
		{
			return other != null && (other == this || (this.BranchId == other.BranchId && this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.disableAeonIdList_.Equals(other.disableAeonIdList_) && this.startDifficultyIdList_.Equals(other.startDifficultyIdList_) && this.Id == other.Id && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.AeonId == other.AeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00055A1C File Offset: 0x00053C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BranchId != 0U)
			{
				num ^= this.BranchId.GetHashCode();
			}
			num ^= this.trialAvatarIdList_.GetHashCode();
			num ^= this.disableAeonIdList_.GetHashCode();
			num ^= this.startDifficultyIdList_.GetHashCode();
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00055AC5 File Offset: 0x00053CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00055ACD File Offset: 0x00053CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00055AD8 File Offset: 0x00053CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseAvatarIdList_.WriteTo(ref output, ChessRogueStartCsReq._repeated_baseAvatarIdList_codec);
			this.trialAvatarIdList_.WriteTo(ref output, ChessRogueStartCsReq._repeated_trialAvatarIdList_codec);
			this.disableAeonIdList_.WriteTo(ref output, ChessRogueStartCsReq._repeated_disableAeonIdList_codec);
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AeonId);
			}
			if (this.BranchId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.BranchId);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Id);
			}
			this.startDifficultyIdList_.WriteTo(ref output, ChessRogueStartCsReq._repeated_startDifficultyIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00055B94 File Offset: 0x00053D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BranchId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BranchId);
			}
			num += this.trialAvatarIdList_.CalculateSize(ChessRogueStartCsReq._repeated_trialAvatarIdList_codec);
			num += this.disableAeonIdList_.CalculateSize(ChessRogueStartCsReq._repeated_disableAeonIdList_codec);
			num += this.startDifficultyIdList_.CalculateSize(ChessRogueStartCsReq._repeated_startDifficultyIdList_codec);
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			num += this.baseAvatarIdList_.CalculateSize(ChessRogueStartCsReq._repeated_baseAvatarIdList_codec);
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00055C50 File Offset: 0x00053E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueStartCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BranchId != 0U)
			{
				this.BranchId = other.BranchId;
			}
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			this.disableAeonIdList_.Add(other.disableAeonIdList_);
			this.startDifficultyIdList_.Add(other.startDifficultyIdList_);
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00055CF8 File Offset: 0x00053EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00055D04 File Offset: 0x00053F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.baseAvatarIdList_.AddEntriesFrom(ref input, ChessRogueStartCsReq._repeated_baseAvatarIdList_codec);
							continue;
						}
					}
					else
					{
						if (num == 32U || num == 34U)
						{
							this.trialAvatarIdList_.AddEntriesFrom(ref input, ChessRogueStartCsReq._repeated_trialAvatarIdList_codec);
							continue;
						}
						if (num == 48U)
						{
							goto IL_8A;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 50U)
					{
						goto IL_8A;
					}
					if (num == 56U)
					{
						this.AeonId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.BranchId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.startDifficultyIdList_.AddEntriesFrom(ref input, ChessRogueStartCsReq._repeated_startDifficultyIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_8A:
				this.disableAeonIdList_.AddEntriesFrom(ref input, ChessRogueStartCsReq._repeated_disableAeonIdList_codec);
			}
		}

		// Token: 0x04000C6E RID: 3182
		private static readonly MessageParser<ChessRogueStartCsReq> _parser = new MessageParser<ChessRogueStartCsReq>(() => new ChessRogueStartCsReq());

		// Token: 0x04000C6F RID: 3183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C70 RID: 3184
		public const int BranchIdFieldNumber = 9;

		// Token: 0x04000C71 RID: 3185
		private uint branchId_;

		// Token: 0x04000C72 RID: 3186
		public const int TrialAvatarIdListFieldNumber = 4;

		// Token: 0x04000C73 RID: 3187
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04000C74 RID: 3188
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04000C75 RID: 3189
		public const int DisableAeonIdListFieldNumber = 6;

		// Token: 0x04000C76 RID: 3190
		private static readonly FieldCodec<uint> _repeated_disableAeonIdList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04000C77 RID: 3191
		private readonly RepeatedField<uint> disableAeonIdList_ = new RepeatedField<uint>();

		// Token: 0x04000C78 RID: 3192
		public const int StartDifficultyIdListFieldNumber = 15;

		// Token: 0x04000C79 RID: 3193
		private static readonly FieldCodec<uint> _repeated_startDifficultyIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04000C7A RID: 3194
		private readonly RepeatedField<uint> startDifficultyIdList_ = new RepeatedField<uint>();

		// Token: 0x04000C7B RID: 3195
		public const int IdFieldNumber = 10;

		// Token: 0x04000C7C RID: 3196
		private uint id_;

		// Token: 0x04000C7D RID: 3197
		public const int BaseAvatarIdListFieldNumber = 1;

		// Token: 0x04000C7E RID: 3198
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04000C7F RID: 3199
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04000C80 RID: 3200
		public const int AeonIdFieldNumber = 7;

		// Token: 0x04000C81 RID: 3201
		private uint aeonId_;
	}
}

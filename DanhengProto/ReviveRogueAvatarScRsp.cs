using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE1 RID: 3553
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReviveRogueAvatarScRsp : IMessage<ReviveRogueAvatarScRsp>, IMessage, IEquatable<ReviveRogueAvatarScRsp>, IDeepCloneable<ReviveRogueAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x06009ECB RID: 40651 RVA: 0x001A8ECB File Offset: 0x001A70CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReviveRogueAvatarScRsp> Parser
		{
			get
			{
				return ReviveRogueAvatarScRsp._parser;
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x06009ECC RID: 40652 RVA: 0x001A8ED2 File Offset: 0x001A70D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReviveRogueAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x06009ECD RID: 40653 RVA: 0x001A8EE4 File Offset: 0x001A70E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReviveRogueAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x001A8EEB File Offset: 0x001A70EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRogueAvatarScRsp()
		{
		}

		// Token: 0x06009ECF RID: 40655 RVA: 0x001A8F0C File Offset: 0x001A710C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRogueAvatarScRsp(ReviveRogueAvatarScRsp other) : this()
		{
			this.baseAvatarId_ = other.baseAvatarId_;
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.retcode_ = other.retcode_;
			this.reviveInfo_ = ((other.reviveInfo_ != null) ? other.reviveInfo_.Clone() : null);
			this.eIACOMMJCCL_ = other.eIACOMMJCCL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x001A8F92 File Offset: 0x001A7192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRogueAvatarScRsp Clone()
		{
			return new ReviveRogueAvatarScRsp(this);
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x06009ED1 RID: 40657 RVA: 0x001A8F9A File Offset: 0x001A719A
		// (set) Token: 0x06009ED2 RID: 40658 RVA: 0x001A8FA2 File Offset: 0x001A71A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x06009ED3 RID: 40659 RVA: 0x001A8FAB File Offset: 0x001A71AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x06009ED4 RID: 40660 RVA: 0x001A8FB3 File Offset: 0x001A71B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x001A8FBB File Offset: 0x001A71BB
		// (set) Token: 0x06009ED6 RID: 40662 RVA: 0x001A8FC3 File Offset: 0x001A71C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x06009ED7 RID: 40663 RVA: 0x001A8FCC File Offset: 0x001A71CC
		// (set) Token: 0x06009ED8 RID: 40664 RVA: 0x001A8FD4 File Offset: 0x001A71D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReviveInfo ReviveInfo
		{
			get
			{
				return this.reviveInfo_;
			}
			set
			{
				this.reviveInfo_ = value;
			}
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x06009ED9 RID: 40665 RVA: 0x001A8FDD File Offset: 0x001A71DD
		// (set) Token: 0x06009EDA RID: 40666 RVA: 0x001A8FE5 File Offset: 0x001A71E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EIACOMMJCCL
		{
			get
			{
				return this.eIACOMMJCCL_;
			}
			set
			{
				this.eIACOMMJCCL_ = value;
			}
		}

		// Token: 0x06009EDB RID: 40667 RVA: 0x001A8FEE File Offset: 0x001A71EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReviveRogueAvatarScRsp);
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x001A8FFC File Offset: 0x001A71FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReviveRogueAvatarScRsp other)
		{
			return other != null && (other == this || (this.BaseAvatarId == other.BaseAvatarId && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.Retcode == other.Retcode && object.Equals(this.ReviveInfo, other.ReviveInfo) && this.EIACOMMJCCL == other.EIACOMMJCCL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x001A9094 File Offset: 0x001A7294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			num ^= this.trialAvatarIdList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.reviveInfo_ != null)
			{
				num ^= this.ReviveInfo.GetHashCode();
			}
			if (this.EIACOMMJCCL != 0U)
			{
				num ^= this.EIACOMMJCCL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x001A9137 File Offset: 0x001A7337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009EDF RID: 40671 RVA: 0x001A913F File Offset: 0x001A733F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EE0 RID: 40672 RVA: 0x001A9148 File Offset: 0x001A7348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reviveInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ReviveInfo);
			}
			this.baseAvatarIdList_.WriteTo(ref output, ReviveRogueAvatarScRsp._repeated_baseAvatarIdList_codec);
			if (this.EIACOMMJCCL != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EIACOMMJCCL);
			}
			this.trialAvatarIdList_.WriteTo(ref output, ReviveRogueAvatarScRsp._repeated_trialAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EE1 RID: 40673 RVA: 0x001A91FC File Offset: 0x001A73FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			num += this.baseAvatarIdList_.CalculateSize(ReviveRogueAvatarScRsp._repeated_baseAvatarIdList_codec);
			num += this.trialAvatarIdList_.CalculateSize(ReviveRogueAvatarScRsp._repeated_trialAvatarIdList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.reviveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReviveInfo);
			}
			if (this.EIACOMMJCCL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EIACOMMJCCL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EE2 RID: 40674 RVA: 0x001A92A8 File Offset: 0x001A74A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReviveRogueAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.reviveInfo_ != null)
			{
				if (this.reviveInfo_ == null)
				{
					this.ReviveInfo = new RogueReviveInfo();
				}
				this.ReviveInfo.MergeFrom(other.ReviveInfo);
			}
			if (other.EIACOMMJCCL != 0U)
			{
				this.EIACOMMJCCL = other.EIACOMMJCCL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009EE3 RID: 40675 RVA: 0x001A935A File Offset: 0x001A755A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EE4 RID: 40676 RVA: 0x001A9364 File Offset: 0x001A7564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 104U)
				{
					if (num <= 64U)
					{
						if (num == 40U)
						{
							this.BaseAvatarId = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							if (this.reviveInfo_ == null)
							{
								this.ReviveInfo = new RogueReviveInfo();
							}
							input.ReadMessage(this.ReviveInfo);
							continue;
						}
						if (num == 104U)
						{
							goto IL_93;
						}
					}
				}
				else if (num <= 112U)
				{
					if (num == 106U)
					{
						goto IL_93;
					}
					if (num == 112U)
					{
						this.EIACOMMJCCL = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.trialAvatarIdList_.AddEntriesFrom(ref input, ReviveRogueAvatarScRsp._repeated_trialAvatarIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_93:
				this.baseAvatarIdList_.AddEntriesFrom(ref input, ReviveRogueAvatarScRsp._repeated_baseAvatarIdList_codec);
			}
		}

		// Token: 0x0400412A RID: 16682
		private static readonly MessageParser<ReviveRogueAvatarScRsp> _parser = new MessageParser<ReviveRogueAvatarScRsp>(() => new ReviveRogueAvatarScRsp());

		// Token: 0x0400412B RID: 16683
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400412C RID: 16684
		public const int BaseAvatarIdFieldNumber = 5;

		// Token: 0x0400412D RID: 16685
		private uint baseAvatarId_;

		// Token: 0x0400412E RID: 16686
		public const int BaseAvatarIdListFieldNumber = 13;

		// Token: 0x0400412F RID: 16687
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04004130 RID: 16688
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04004131 RID: 16689
		public const int TrialAvatarIdListFieldNumber = 15;

		// Token: 0x04004132 RID: 16690
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04004133 RID: 16691
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04004134 RID: 16692
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004135 RID: 16693
		private uint retcode_;

		// Token: 0x04004136 RID: 16694
		public const int ReviveInfoFieldNumber = 11;

		// Token: 0x04004137 RID: 16695
		private RogueReviveInfo reviveInfo_;

		// Token: 0x04004138 RID: 16696
		public const int EIACOMMJCCLFieldNumber = 14;

		// Token: 0x04004139 RID: 16697
		private uint eIACOMMJCCL_;
	}
}

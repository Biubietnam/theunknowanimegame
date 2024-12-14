using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DDF RID: 3551
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReviveRogueAvatarCsReq : IMessage<ReviveRogueAvatarCsReq>, IMessage, IEquatable<ReviveRogueAvatarCsReq>, IDeepCloneable<ReviveRogueAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x06009EB2 RID: 40626 RVA: 0x001A89D7 File Offset: 0x001A6BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReviveRogueAvatarCsReq> Parser
		{
			get
			{
				return ReviveRogueAvatarCsReq._parser;
			}
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x06009EB3 RID: 40627 RVA: 0x001A89DE File Offset: 0x001A6BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReviveRogueAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x06009EB4 RID: 40628 RVA: 0x001A89F0 File Offset: 0x001A6BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReviveRogueAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x001A89F7 File Offset: 0x001A6BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRogueAvatarCsReq()
		{
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x001A8A18 File Offset: 0x001A6C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRogueAvatarCsReq(ReviveRogueAvatarCsReq other) : this()
		{
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EB7 RID: 40631 RVA: 0x001A8A76 File Offset: 0x001A6C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRogueAvatarCsReq Clone()
		{
			return new ReviveRogueAvatarCsReq(this);
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x06009EB8 RID: 40632 RVA: 0x001A8A7E File Offset: 0x001A6C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x06009EB9 RID: 40633 RVA: 0x001A8A86 File Offset: 0x001A6C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x06009EBA RID: 40634 RVA: 0x001A8A8E File Offset: 0x001A6C8E
		// (set) Token: 0x06009EBB RID: 40635 RVA: 0x001A8A96 File Offset: 0x001A6C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x06009EBC RID: 40636 RVA: 0x001A8A9F File Offset: 0x001A6C9F
		// (set) Token: 0x06009EBD RID: 40637 RVA: 0x001A8AA7 File Offset: 0x001A6CA7
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

		// Token: 0x06009EBE RID: 40638 RVA: 0x001A8AB0 File Offset: 0x001A6CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReviveRogueAvatarCsReq);
		}

		// Token: 0x06009EBF RID: 40639 RVA: 0x001A8AC0 File Offset: 0x001A6CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReviveRogueAvatarCsReq other)
		{
			return other != null && (other == this || (this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.InteractedPropEntityId == other.InteractedPropEntityId && this.BaseAvatarId == other.BaseAvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EC0 RID: 40640 RVA: 0x001A8B34 File Offset: 0x001A6D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.baseAvatarIdList_.GetHashCode();
			num ^= this.trialAvatarIdList_.GetHashCode();
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x001A8BA8 File Offset: 0x001A6DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x001A8BB0 File Offset: 0x001A6DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x001A8BBC File Offset: 0x001A6DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseAvatarIdList_.WriteTo(ref output, ReviveRogueAvatarCsReq._repeated_baseAvatarIdList_codec);
			this.trialAvatarIdList_.WriteTo(ref output, ReviveRogueAvatarCsReq._repeated_trialAvatarIdList_codec);
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x001A8C38 File Offset: 0x001A6E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.baseAvatarIdList_.CalculateSize(ReviveRogueAvatarCsReq._repeated_baseAvatarIdList_codec);
			num += this.trialAvatarIdList_.CalculateSize(ReviveRogueAvatarCsReq._repeated_trialAvatarIdList_codec);
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x001A8CB4 File Offset: 0x001A6EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReviveRogueAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x001A8D26 File Offset: 0x001A6F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EC7 RID: 40647 RVA: 0x001A8D30 File Offset: 0x001A6F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 16U || num == 18U)
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, ReviveRogueAvatarCsReq._repeated_baseAvatarIdList_codec);
						continue;
					}
					if (num == 40U)
					{
						goto IL_4E;
					}
				}
				else
				{
					if (num == 42U)
					{
						goto IL_4E;
					}
					if (num == 48U)
					{
						this.BaseAvatarId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.InteractedPropEntityId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4E:
				this.trialAvatarIdList_.AddEntriesFrom(ref input, ReviveRogueAvatarCsReq._repeated_trialAvatarIdList_codec);
			}
		}

		// Token: 0x0400411D RID: 16669
		private static readonly MessageParser<ReviveRogueAvatarCsReq> _parser = new MessageParser<ReviveRogueAvatarCsReq>(() => new ReviveRogueAvatarCsReq());

		// Token: 0x0400411E RID: 16670
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400411F RID: 16671
		public const int BaseAvatarIdListFieldNumber = 2;

		// Token: 0x04004120 RID: 16672
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04004121 RID: 16673
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04004122 RID: 16674
		public const int TrialAvatarIdListFieldNumber = 5;

		// Token: 0x04004123 RID: 16675
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04004124 RID: 16676
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04004125 RID: 16677
		public const int InteractedPropEntityIdFieldNumber = 8;

		// Token: 0x04004126 RID: 16678
		private uint interactedPropEntityId_;

		// Token: 0x04004127 RID: 16679
		public const int BaseAvatarIdFieldNumber = 6;

		// Token: 0x04004128 RID: 16680
		private uint baseAvatarId_;
	}
}

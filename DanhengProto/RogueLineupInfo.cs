using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EA9 RID: 3753
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueLineupInfo : IMessage<RogueLineupInfo>, IMessage, IEquatable<RogueLineupInfo>, IDeepCloneable<RogueLineupInfo>, IBufferMessage
	{
		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x0600A7A8 RID: 42920 RVA: 0x001C383F File Offset: 0x001C1A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueLineupInfo> Parser
		{
			get
			{
				return RogueLineupInfo._parser;
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x001C3846 File Offset: 0x001C1A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueLineupInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x0600A7AA RID: 42922 RVA: 0x001C3858 File Offset: 0x001C1A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueLineupInfo.Descriptor;
			}
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x001C385F File Offset: 0x001C1A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLineupInfo()
		{
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x001C3888 File Offset: 0x001C1A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLineupInfo(RogueLineupInfo other) : this()
		{
			this.reviveInfo_ = ((other.reviveInfo_ != null) ? other.reviveInfo_.Clone() : null);
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.gGHCBPBEFFJ_ = other.gGHCBPBEFFJ_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x001C38FB File Offset: 0x001C1AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLineupInfo Clone()
		{
			return new RogueLineupInfo(this);
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x0600A7AE RID: 42926 RVA: 0x001C3903 File Offset: 0x001C1B03
		// (set) Token: 0x0600A7AF RID: 42927 RVA: 0x001C390B File Offset: 0x001C1B0B
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

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x0600A7B0 RID: 42928 RVA: 0x001C3914 File Offset: 0x001C1B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x0600A7B1 RID: 42929 RVA: 0x001C391C File Offset: 0x001C1B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x0600A7B2 RID: 42930 RVA: 0x001C3924 File Offset: 0x001C1B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GGHCBPBEFFJ
		{
			get
			{
				return this.gGHCBPBEFFJ_;
			}
		}

		// Token: 0x0600A7B3 RID: 42931 RVA: 0x001C392C File Offset: 0x001C1B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueLineupInfo);
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x001C393C File Offset: 0x001C1B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueLineupInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ReviveInfo, other.ReviveInfo) && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.gGHCBPBEFFJ_.Equals(other.gGHCBPBEFFJ_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x001C39BC File Offset: 0x001C1BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reviveInfo_ != null)
			{
				num ^= this.ReviveInfo.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			num ^= this.trialAvatarIdList_.GetHashCode();
			num ^= this.gGHCBPBEFFJ_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x001C3A22 File Offset: 0x001C1C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x001C3A2A File Offset: 0x001C1C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x001C3A34 File Offset: 0x001C1C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialAvatarIdList_.WriteTo(ref output, RogueLineupInfo._repeated_trialAvatarIdList_codec);
			this.baseAvatarIdList_.WriteTo(ref output, RogueLineupInfo._repeated_baseAvatarIdList_codec);
			this.gGHCBPBEFFJ_.WriteTo(ref output, RogueLineupInfo._repeated_gGHCBPBEFFJ_codec);
			if (this.reviveInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ReviveInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x001C3AA4 File Offset: 0x001C1CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reviveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReviveInfo);
			}
			num += this.baseAvatarIdList_.CalculateSize(RogueLineupInfo._repeated_baseAvatarIdList_codec);
			num += this.trialAvatarIdList_.CalculateSize(RogueLineupInfo._repeated_trialAvatarIdList_codec);
			num += this.gGHCBPBEFFJ_.CalculateSize(RogueLineupInfo._repeated_gGHCBPBEFFJ_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x001C3B1C File Offset: 0x001C1D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueLineupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reviveInfo_ != null)
			{
				if (this.reviveInfo_ == null)
				{
					this.ReviveInfo = new RogueReviveInfo();
				}
				this.ReviveInfo.MergeFrom(other.ReviveInfo);
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			this.gGHCBPBEFFJ_.Add(other.gGHCBPBEFFJ_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x001C3BA3 File Offset: 0x001C1DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x001C3BAC File Offset: 0x001C1DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 72U)
				{
					if (num <= 112U)
					{
						if (num == 74U)
						{
							goto IL_5D;
						}
						if (num != 112U)
						{
							goto IL_36;
						}
					}
					else if (num != 114U)
					{
						if (num != 122U)
						{
							goto IL_36;
						}
						if (this.reviveInfo_ == null)
						{
							this.ReviveInfo = new RogueReviveInfo();
						}
						input.ReadMessage(this.ReviveInfo);
						continue;
					}
					this.gGHCBPBEFFJ_.AddEntriesFrom(ref input, RogueLineupInfo._repeated_gGHCBPBEFFJ_codec);
					continue;
				}
				if (num == 40U || num == 42U)
				{
					this.trialAvatarIdList_.AddEntriesFrom(ref input, RogueLineupInfo._repeated_trialAvatarIdList_codec);
					continue;
				}
				if (num == 72U)
				{
					goto IL_5D;
				}
				IL_36:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_5D:
				this.baseAvatarIdList_.AddEntriesFrom(ref input, RogueLineupInfo._repeated_baseAvatarIdList_codec);
			}
		}

		// Token: 0x04004487 RID: 17543
		private static readonly MessageParser<RogueLineupInfo> _parser = new MessageParser<RogueLineupInfo>(() => new RogueLineupInfo());

		// Token: 0x04004488 RID: 17544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004489 RID: 17545
		public const int ReviveInfoFieldNumber = 15;

		// Token: 0x0400448A RID: 17546
		private RogueReviveInfo reviveInfo_;

		// Token: 0x0400448B RID: 17547
		public const int BaseAvatarIdListFieldNumber = 9;

		// Token: 0x0400448C RID: 17548
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x0400448D RID: 17549
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x0400448E RID: 17550
		public const int TrialAvatarIdListFieldNumber = 5;

		// Token: 0x0400448F RID: 17551
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04004490 RID: 17552
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04004491 RID: 17553
		public const int GGHCBPBEFFJFieldNumber = 14;

		// Token: 0x04004492 RID: 17554
		private static readonly FieldCodec<uint> _repeated_gGHCBPBEFFJ_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04004493 RID: 17555
		private readonly RepeatedField<uint> gGHCBPBEFFJ_ = new RepeatedField<uint>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C99 RID: 3225
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PickRogueAvatarScRsp : IMessage<PickRogueAvatarScRsp>, IMessage, IEquatable<PickRogueAvatarScRsp>, IDeepCloneable<PickRogueAvatarScRsp>, IBufferMessage
	{
		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x06008F68 RID: 36712 RVA: 0x0017B025 File Offset: 0x00179225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PickRogueAvatarScRsp> Parser
		{
			get
			{
				return PickRogueAvatarScRsp._parser;
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x06008F69 RID: 36713 RVA: 0x0017B02C File Offset: 0x0017922C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PickRogueAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x06008F6A RID: 36714 RVA: 0x0017B03E File Offset: 0x0017923E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PickRogueAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x06008F6B RID: 36715 RVA: 0x0017B045 File Offset: 0x00179245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickRogueAvatarScRsp()
		{
		}

		// Token: 0x06008F6C RID: 36716 RVA: 0x0017B064 File Offset: 0x00179264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickRogueAvatarScRsp(PickRogueAvatarScRsp other) : this()
		{
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F6D RID: 36717 RVA: 0x0017B0B6 File Offset: 0x001792B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickRogueAvatarScRsp Clone()
		{
			return new PickRogueAvatarScRsp(this);
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x06008F6E RID: 36718 RVA: 0x0017B0BE File Offset: 0x001792BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x06008F6F RID: 36719 RVA: 0x0017B0C6 File Offset: 0x001792C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x06008F70 RID: 36720 RVA: 0x0017B0CE File Offset: 0x001792CE
		// (set) Token: 0x06008F71 RID: 36721 RVA: 0x0017B0D6 File Offset: 0x001792D6
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

		// Token: 0x06008F72 RID: 36722 RVA: 0x0017B0DF File Offset: 0x001792DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PickRogueAvatarScRsp);
		}

		// Token: 0x06008F73 RID: 36723 RVA: 0x0017B0F0 File Offset: 0x001792F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PickRogueAvatarScRsp other)
		{
			return other != null && (other == this || (this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F74 RID: 36724 RVA: 0x0017B154 File Offset: 0x00179354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trialAvatarIdList_.GetHashCode();
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F75 RID: 36725 RVA: 0x0017B1AF File Offset: 0x001793AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x0017B1B7 File Offset: 0x001793B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F77 RID: 36727 RVA: 0x0017B1C0 File Offset: 0x001793C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialAvatarIdList_.WriteTo(ref output, PickRogueAvatarScRsp._repeated_trialAvatarIdList_codec);
			this.baseAvatarIdList_.WriteTo(ref output, PickRogueAvatarScRsp._repeated_baseAvatarIdList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F78 RID: 36728 RVA: 0x0017B220 File Offset: 0x00179420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialAvatarIdList_.CalculateSize(PickRogueAvatarScRsp._repeated_trialAvatarIdList_codec);
			num += this.baseAvatarIdList_.CalculateSize(PickRogueAvatarScRsp._repeated_baseAvatarIdList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F79 RID: 36729 RVA: 0x0017B284 File Offset: 0x00179484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PickRogueAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F7A RID: 36730 RVA: 0x0017B2E2 File Offset: 0x001794E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F7B RID: 36731 RVA: 0x0017B2EC File Offset: 0x001794EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.trialAvatarIdList_.AddEntriesFrom(ref input, PickRogueAvatarScRsp._repeated_trialAvatarIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U || num == 34U)
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, PickRogueAvatarScRsp._repeated_baseAvatarIdList_codec);
						continue;
					}
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003716 RID: 14102
		private static readonly MessageParser<PickRogueAvatarScRsp> _parser = new MessageParser<PickRogueAvatarScRsp>(() => new PickRogueAvatarScRsp());

		// Token: 0x04003717 RID: 14103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003718 RID: 14104
		public const int TrialAvatarIdListFieldNumber = 2;

		// Token: 0x04003719 RID: 14105
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x0400371A RID: 14106
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x0400371B RID: 14107
		public const int BaseAvatarIdListFieldNumber = 4;

		// Token: 0x0400371C RID: 14108
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400371D RID: 14109
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x0400371E RID: 14110
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400371F RID: 14111
		private uint retcode_;
	}
}

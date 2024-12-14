using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E3 RID: 4835
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeMailAttachmentCsReq : IMessage<TakeMailAttachmentCsReq>, IMessage, IEquatable<TakeMailAttachmentCsReq>, IDeepCloneable<TakeMailAttachmentCsReq>, IBufferMessage
	{
		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x0600D7BE RID: 55230 RVA: 0x0023F625 File Offset: 0x0023D825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeMailAttachmentCsReq> Parser
		{
			get
			{
				return TakeMailAttachmentCsReq._parser;
			}
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x0600D7BF RID: 55231 RVA: 0x0023F62C File Offset: 0x0023D82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeMailAttachmentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x0600D7C0 RID: 55232 RVA: 0x0023F63E File Offset: 0x0023D83E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeMailAttachmentCsReq.Descriptor;
			}
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x0023F645 File Offset: 0x0023D845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMailAttachmentCsReq()
		{
		}

		// Token: 0x0600D7C2 RID: 55234 RVA: 0x0023F658 File Offset: 0x0023D858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMailAttachmentCsReq(TakeMailAttachmentCsReq other) : this()
		{
			this.optionalRewardId_ = other.optionalRewardId_;
			this.takeMailIdList_ = other.takeMailIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7C3 RID: 55235 RVA: 0x0023F68E File Offset: 0x0023D88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMailAttachmentCsReq Clone()
		{
			return new TakeMailAttachmentCsReq(this);
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x0600D7C4 RID: 55236 RVA: 0x0023F696 File Offset: 0x0023D896
		// (set) Token: 0x0600D7C5 RID: 55237 RVA: 0x0023F69E File Offset: 0x0023D89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionalRewardId
		{
			get
			{
				return this.optionalRewardId_;
			}
			set
			{
				this.optionalRewardId_ = value;
			}
		}

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x0600D7C6 RID: 55238 RVA: 0x0023F6A7 File Offset: 0x0023D8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TakeMailIdList
		{
			get
			{
				return this.takeMailIdList_;
			}
		}

		// Token: 0x0600D7C7 RID: 55239 RVA: 0x0023F6AF File Offset: 0x0023D8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeMailAttachmentCsReq);
		}

		// Token: 0x0600D7C8 RID: 55240 RVA: 0x0023F6C0 File Offset: 0x0023D8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeMailAttachmentCsReq other)
		{
			return other != null && (other == this || (this.OptionalRewardId == other.OptionalRewardId && this.takeMailIdList_.Equals(other.takeMailIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7C9 RID: 55241 RVA: 0x0023F710 File Offset: 0x0023D910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OptionalRewardId != 0U)
			{
				num ^= this.OptionalRewardId.GetHashCode();
			}
			num ^= this.takeMailIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D7CA RID: 55242 RVA: 0x0023F75D File Offset: 0x0023D95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D7CB RID: 55243 RVA: 0x0023F765 File Offset: 0x0023D965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7CC RID: 55244 RVA: 0x0023F770 File Offset: 0x0023D970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.takeMailIdList_.WriteTo(ref output, TakeMailAttachmentCsReq._repeated_takeMailIdList_codec);
			if (this.OptionalRewardId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.OptionalRewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7CD RID: 55245 RVA: 0x0023F7C0 File Offset: 0x0023D9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OptionalRewardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionalRewardId);
			}
			num += this.takeMailIdList_.CalculateSize(TakeMailAttachmentCsReq._repeated_takeMailIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x0023F814 File Offset: 0x0023DA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeMailAttachmentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OptionalRewardId != 0U)
			{
				this.OptionalRewardId = other.OptionalRewardId;
			}
			this.takeMailIdList_.Add(other.takeMailIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D7CF RID: 55247 RVA: 0x0023F861 File Offset: 0x0023DA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7D0 RID: 55248 RVA: 0x0023F86C File Offset: 0x0023DA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U && num != 50U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OptionalRewardId = input.ReadUInt32();
					}
				}
				else
				{
					this.takeMailIdList_.AddEntriesFrom(ref input, TakeMailAttachmentCsReq._repeated_takeMailIdList_codec);
				}
			}
		}

		// Token: 0x04005618 RID: 22040
		private static readonly MessageParser<TakeMailAttachmentCsReq> _parser = new MessageParser<TakeMailAttachmentCsReq>(() => new TakeMailAttachmentCsReq());

		// Token: 0x04005619 RID: 22041
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400561A RID: 22042
		public const int OptionalRewardIdFieldNumber = 10;

		// Token: 0x0400561B RID: 22043
		private uint optionalRewardId_;

		// Token: 0x0400561C RID: 22044
		public const int TakeMailIdListFieldNumber = 6;

		// Token: 0x0400561D RID: 22045
		private static readonly FieldCodec<uint> _repeated_takeMailIdList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x0400561E RID: 22046
		private readonly RepeatedField<uint> takeMailIdList_ = new RepeatedField<uint>();
	}
}

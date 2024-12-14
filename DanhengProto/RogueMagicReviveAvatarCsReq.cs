using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EF7 RID: 3831
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicReviveAvatarCsReq : IMessage<RogueMagicReviveAvatarCsReq>, IMessage, IEquatable<RogueMagicReviveAvatarCsReq>, IDeepCloneable<RogueMagicReviveAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x0600AB1C RID: 43804 RVA: 0x001CCF59 File Offset: 0x001CB159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicReviveAvatarCsReq> Parser
		{
			get
			{
				return RogueMagicReviveAvatarCsReq._parser;
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x0600AB1D RID: 43805 RVA: 0x001CCF60 File Offset: 0x001CB160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicReviveAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x0600AB1E RID: 43806 RVA: 0x001CCF72 File Offset: 0x001CB172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicReviveAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x001CCF79 File Offset: 0x001CB179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveAvatarCsReq()
		{
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x001CCF8C File Offset: 0x001CB18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveAvatarCsReq(RogueMagicReviveAvatarCsReq other) : this()
		{
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x001CCFC2 File Offset: 0x001CB1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveAvatarCsReq Clone()
		{
			return new RogueMagicReviveAvatarCsReq(this);
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x0600AB22 RID: 43810 RVA: 0x001CCFCA File Offset: 0x001CB1CA
		// (set) Token: 0x0600AB23 RID: 43811 RVA: 0x001CCFD2 File Offset: 0x001CB1D2
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

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x0600AB24 RID: 43812 RVA: 0x001CCFDB File Offset: 0x001CB1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x001CCFE3 File Offset: 0x001CB1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicReviveAvatarCsReq);
		}

		// Token: 0x0600AB26 RID: 43814 RVA: 0x001CCFF4 File Offset: 0x001CB1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicReviveAvatarCsReq other)
		{
			return other != null && (other == this || (this.InteractedPropEntityId == other.InteractedPropEntityId && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x001CD044 File Offset: 0x001CB244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x001CD091 File Offset: 0x001CB291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x001CD099 File Offset: 0x001CB299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x001CD0A4 File Offset: 0x001CB2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseAvatarIdList_.WriteTo(ref output, RogueMagicReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x001CD0F4 File Offset: 0x001CB2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			num += this.baseAvatarIdList_.CalculateSize(RogueMagicReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x001CD148 File Offset: 0x001CB348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicReviveAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB2D RID: 43821 RVA: 0x001CD195 File Offset: 0x001CB395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x001CD1A0 File Offset: 0x001CB3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U && num != 18U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractedPropEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.baseAvatarIdList_.AddEntriesFrom(ref input, RogueMagicReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
				}
			}
		}

		// Token: 0x040045D8 RID: 17880
		private static readonly MessageParser<RogueMagicReviveAvatarCsReq> _parser = new MessageParser<RogueMagicReviveAvatarCsReq>(() => new RogueMagicReviveAvatarCsReq());

		// Token: 0x040045D9 RID: 17881
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045DA RID: 17882
		public const int InteractedPropEntityIdFieldNumber = 10;

		// Token: 0x040045DB RID: 17883
		private uint interactedPropEntityId_;

		// Token: 0x040045DC RID: 17884
		public const int BaseAvatarIdListFieldNumber = 2;

		// Token: 0x040045DD RID: 17885
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040045DE RID: 17886
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();
	}
}

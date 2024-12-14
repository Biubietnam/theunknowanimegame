using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001009 RID: 4105
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournReviveAvatarCsReq : IMessage<RogueTournReviveAvatarCsReq>, IMessage, IEquatable<RogueTournReviveAvatarCsReq>, IDeepCloneable<RogueTournReviveAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600B6A4 RID: 46756 RVA: 0x001E9FA1 File Offset: 0x001E81A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournReviveAvatarCsReq> Parser
		{
			get
			{
				return RogueTournReviveAvatarCsReq._parser;
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600B6A5 RID: 46757 RVA: 0x001E9FA8 File Offset: 0x001E81A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournReviveAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600B6A6 RID: 46758 RVA: 0x001E9FBA File Offset: 0x001E81BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournReviveAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x001E9FC1 File Offset: 0x001E81C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveAvatarCsReq()
		{
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x001E9FD4 File Offset: 0x001E81D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveAvatarCsReq(RogueTournReviveAvatarCsReq other) : this()
		{
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x001EA00A File Offset: 0x001E820A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveAvatarCsReq Clone()
		{
			return new RogueTournReviveAvatarCsReq(this);
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600B6AA RID: 46762 RVA: 0x001EA012 File Offset: 0x001E8212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600B6AB RID: 46763 RVA: 0x001EA01A File Offset: 0x001E821A
		// (set) Token: 0x0600B6AC RID: 46764 RVA: 0x001EA022 File Offset: 0x001E8222
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

		// Token: 0x0600B6AD RID: 46765 RVA: 0x001EA02B File Offset: 0x001E822B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournReviveAvatarCsReq);
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x001EA03C File Offset: 0x001E823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournReviveAvatarCsReq other)
		{
			return other != null && (other == this || (this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x001EA08C File Offset: 0x001E828C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x001EA0D9 File Offset: 0x001E82D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x001EA0E1 File Offset: 0x001E82E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x001EA0EC File Offset: 0x001E82EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			this.baseAvatarIdList_.WriteTo(ref output, RogueTournReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x001EA13C File Offset: 0x001E833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.baseAvatarIdList_.CalculateSize(RogueTournReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x001EA190 File Offset: 0x001E8390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournReviveAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x001EA1DD File Offset: 0x001E83DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x001EA1E8 File Offset: 0x001E83E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, RogueTournReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
					}
				}
				else
				{
					this.InteractedPropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040049FC RID: 18940
		private static readonly MessageParser<RogueTournReviveAvatarCsReq> _parser = new MessageParser<RogueTournReviveAvatarCsReq>(() => new RogueTournReviveAvatarCsReq());

		// Token: 0x040049FD RID: 18941
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049FE RID: 18942
		public const int BaseAvatarIdListFieldNumber = 15;

		// Token: 0x040049FF RID: 18943
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04004A00 RID: 18944
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04004A01 RID: 18945
		public const int InteractedPropEntityIdFieldNumber = 12;

		// Token: 0x04004A02 RID: 18946
		private uint interactedPropEntityId_;
	}
}

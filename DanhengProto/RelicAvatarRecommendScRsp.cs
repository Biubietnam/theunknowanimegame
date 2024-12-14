using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA1 RID: 3489
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicAvatarRecommendScRsp : IMessage<RelicAvatarRecommendScRsp>, IMessage, IEquatable<RelicAvatarRecommendScRsp>, IDeepCloneable<RelicAvatarRecommendScRsp>, IBufferMessage
	{
		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x06009BE4 RID: 39908 RVA: 0x0019EEB3 File Offset: 0x0019D0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicAvatarRecommendScRsp> Parser
		{
			get
			{
				return RelicAvatarRecommendScRsp._parser;
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x06009BE5 RID: 39909 RVA: 0x0019EEBA File Offset: 0x0019D0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicAvatarRecommendScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x06009BE6 RID: 39910 RVA: 0x0019EECC File Offset: 0x0019D0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicAvatarRecommendScRsp.Descriptor;
			}
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x0019EED3 File Offset: 0x0019D0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAvatarRecommendScRsp()
		{
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x0019EEE8 File Offset: 0x0019D0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAvatarRecommendScRsp(RelicAvatarRecommendScRsp other) : this()
		{
			this.eOLGPJIGODN_ = other.eOLGPJIGODN_;
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this.retcode_ = other.retcode_;
			this.rOGUETALENTSTATUSENABLE_ = other.rOGUETALENTSTATUSENABLE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BE9 RID: 39913 RVA: 0x0019EF41 File Offset: 0x0019D141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAvatarRecommendScRsp Clone()
		{
			return new RelicAvatarRecommendScRsp(this);
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x06009BEA RID: 39914 RVA: 0x0019EF49 File Offset: 0x0019D149
		// (set) Token: 0x06009BEB RID: 39915 RVA: 0x0019EF51 File Offset: 0x0019D151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EOLGPJIGODN
		{
			get
			{
				return this.eOLGPJIGODN_;
			}
			set
			{
				this.eOLGPJIGODN_ = value;
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x06009BEC RID: 39916 RVA: 0x0019EF5A File Offset: 0x0019D15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x06009BED RID: 39917 RVA: 0x0019EF62 File Offset: 0x0019D162
		// (set) Token: 0x06009BEE RID: 39918 RVA: 0x0019EF6A File Offset: 0x0019D16A
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

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x06009BEF RID: 39919 RVA: 0x0019EF73 File Offset: 0x0019D173
		// (set) Token: 0x06009BF0 RID: 39920 RVA: 0x0019EF7B File Offset: 0x0019D17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ROGUETALENTSTATUSENABLE
		{
			get
			{
				return this.rOGUETALENTSTATUSENABLE_;
			}
			set
			{
				this.rOGUETALENTSTATUSENABLE_ = value;
			}
		}

		// Token: 0x06009BF1 RID: 39921 RVA: 0x0019EF84 File Offset: 0x0019D184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicAvatarRecommendScRsp);
		}

		// Token: 0x06009BF2 RID: 39922 RVA: 0x0019EF94 File Offset: 0x0019D194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicAvatarRecommendScRsp other)
		{
			return other != null && (other == this || (this.EOLGPJIGODN == other.EOLGPJIGODN && this.avatarIdList_.Equals(other.avatarIdList_) && this.Retcode == other.Retcode && this.ROGUETALENTSTATUSENABLE == other.ROGUETALENTSTATUSENABLE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009BF3 RID: 39923 RVA: 0x0019F004 File Offset: 0x0019D204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EOLGPJIGODN != 0U)
			{
				num ^= this.EOLGPJIGODN.GetHashCode();
			}
			num ^= this.avatarIdList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ROGUETALENTSTATUSENABLE)
			{
				num ^= this.ROGUETALENTSTATUSENABLE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BF4 RID: 39924 RVA: 0x0019F083 File Offset: 0x0019D283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009BF5 RID: 39925 RVA: 0x0019F08B File Offset: 0x0019D28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BF6 RID: 39926 RVA: 0x0019F094 File Offset: 0x0019D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ROGUETALENTSTATUSENABLE)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ROGUETALENTSTATUSENABLE);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			this.avatarIdList_.WriteTo(ref output, RelicAvatarRecommendScRsp._repeated_avatarIdList_codec);
			if (this.EOLGPJIGODN != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.EOLGPJIGODN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BF7 RID: 39927 RVA: 0x0019F11C File Offset: 0x0019D31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EOLGPJIGODN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EOLGPJIGODN);
			}
			num += this.avatarIdList_.CalculateSize(RelicAvatarRecommendScRsp._repeated_avatarIdList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ROGUETALENTSTATUSENABLE)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BF8 RID: 39928 RVA: 0x0019F194 File Offset: 0x0019D394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicAvatarRecommendScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EOLGPJIGODN != 0U)
			{
				this.EOLGPJIGODN = other.EOLGPJIGODN;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ROGUETALENTSTATUSENABLE)
			{
				this.ROGUETALENTSTATUSENABLE = other.ROGUETALENTSTATUSENABLE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009BF9 RID: 39929 RVA: 0x0019F209 File Offset: 0x0019D409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BFA RID: 39930 RVA: 0x0019F214 File Offset: 0x0019D414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 96U)
				{
					if (num == 48U)
					{
						this.ROGUETALENTSTATUSENABLE = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.avatarIdList_.AddEntriesFrom(ref input, RelicAvatarRecommendScRsp._repeated_avatarIdList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.EOLGPJIGODN = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C82 RID: 15490
		private static readonly MessageParser<RelicAvatarRecommendScRsp> _parser = new MessageParser<RelicAvatarRecommendScRsp>(() => new RelicAvatarRecommendScRsp());

		// Token: 0x04003C83 RID: 15491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C84 RID: 15492
		public const int EOLGPJIGODNFieldNumber = 15;

		// Token: 0x04003C85 RID: 15493
		private uint eOLGPJIGODN_;

		// Token: 0x04003C86 RID: 15494
		public const int AvatarIdListFieldNumber = 13;

		// Token: 0x04003C87 RID: 15495
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04003C88 RID: 15496
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04003C89 RID: 15497
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04003C8A RID: 15498
		private uint retcode_;

		// Token: 0x04003C8B RID: 15499
		public const int ROGUETALENTSTATUSENABLEFieldNumber = 6;

		// Token: 0x04003C8C RID: 15500
		private bool rOGUETALENTSTATUSENABLE_;
	}
}

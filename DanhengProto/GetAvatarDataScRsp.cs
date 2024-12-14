using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000629 RID: 1577
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAvatarDataScRsp : IMessage<GetAvatarDataScRsp>, IMessage, IEquatable<GetAvatarDataScRsp>, IDeepCloneable<GetAvatarDataScRsp>, IBufferMessage
	{
		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x000C1833 File Offset: 0x000BFA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAvatarDataScRsp> Parser
		{
			get
			{
				return GetAvatarDataScRsp._parser;
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x000C183A File Offset: 0x000BFA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAvatarDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x000C184C File Offset: 0x000BFA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAvatarDataScRsp.Descriptor;
			}
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x000C1853 File Offset: 0x000BFA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAvatarDataScRsp()
		{
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x000C1874 File Offset: 0x000BFA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAvatarDataScRsp(GetAvatarDataScRsp other) : this()
		{
			this.avatarList_ = other.avatarList_.Clone();
			this.kAHBBLAKBBN_ = other.kAHBBLAKBBN_.Clone();
			this.isGetAll_ = other.isGetAll_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x000C18D2 File Offset: 0x000BFAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAvatarDataScRsp Clone()
		{
			return new GetAvatarDataScRsp(this);
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x000C18DA File Offset: 0x000BFADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Avatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x060046BF RID: 18111 RVA: 0x000C18E2 File Offset: 0x000BFAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KAHBBLAKBBN
		{
			get
			{
				return this.kAHBBLAKBBN_;
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x000C18EA File Offset: 0x000BFAEA
		// (set) Token: 0x060046C1 RID: 18113 RVA: 0x000C18F2 File Offset: 0x000BFAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGetAll
		{
			get
			{
				return this.isGetAll_;
			}
			set
			{
				this.isGetAll_ = value;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x000C18FB File Offset: 0x000BFAFB
		// (set) Token: 0x060046C3 RID: 18115 RVA: 0x000C1903 File Offset: 0x000BFB03
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

		// Token: 0x060046C4 RID: 18116 RVA: 0x000C190C File Offset: 0x000BFB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAvatarDataScRsp);
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x000C191C File Offset: 0x000BFB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAvatarDataScRsp other)
		{
			return other != null && (other == this || (this.avatarList_.Equals(other.avatarList_) && this.kAHBBLAKBBN_.Equals(other.kAHBBLAKBBN_) && this.IsGetAll == other.IsGetAll && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x000C1990 File Offset: 0x000BFB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarList_.GetHashCode();
			num ^= this.kAHBBLAKBBN_.GetHashCode();
			if (this.IsGetAll)
			{
				num ^= this.IsGetAll.GetHashCode();
			}
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

		// Token: 0x060046C7 RID: 18119 RVA: 0x000C1A04 File Offset: 0x000BFC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x000C1A0C File Offset: 0x000BFC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x000C1A18 File Offset: 0x000BFC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kAHBBLAKBBN_.WriteTo(ref output, GetAvatarDataScRsp._repeated_kAHBBLAKBBN_codec);
			this.avatarList_.WriteTo(ref output, GetAvatarDataScRsp._repeated_avatarList_codec);
			if (this.IsGetAll)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsGetAll);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x000C1A94 File Offset: 0x000BFC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarList_.CalculateSize(GetAvatarDataScRsp._repeated_avatarList_codec);
			num += this.kAHBBLAKBBN_.CalculateSize(GetAvatarDataScRsp._repeated_kAHBBLAKBBN_codec);
			if (this.IsGetAll)
			{
				num += 2;
			}
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

		// Token: 0x060046CB RID: 18123 RVA: 0x000C1B04 File Offset: 0x000BFD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAvatarDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarList_.Add(other.avatarList_);
			this.kAHBBLAKBBN_.Add(other.kAHBBLAKBBN_);
			if (other.IsGetAll)
			{
				this.IsGetAll = other.IsGetAll;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x000C1B76 File Offset: 0x000BFD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x000C1B80 File Offset: 0x000BFD80
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
						this.kAHBBLAKBBN_.AddEntriesFrom(ref input, GetAvatarDataScRsp._repeated_kAHBBLAKBBN_codec);
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.avatarList_.AddEntriesFrom(ref input, GetAvatarDataScRsp._repeated_avatarList_codec);
						continue;
					}
					if (num == 56U)
					{
						this.IsGetAll = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C3D RID: 7229
		private static readonly MessageParser<GetAvatarDataScRsp> _parser = new MessageParser<GetAvatarDataScRsp>(() => new GetAvatarDataScRsp());

		// Token: 0x04001C3E RID: 7230
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C3F RID: 7231
		public const int AvatarListFieldNumber = 5;

		// Token: 0x04001C40 RID: 7232
		private static readonly FieldCodec<Avatar> _repeated_avatarList_codec = FieldCodec.ForMessage<Avatar>(42U, Avatar.Parser);

		// Token: 0x04001C41 RID: 7233
		private readonly RepeatedField<Avatar> avatarList_ = new RepeatedField<Avatar>();

		// Token: 0x04001C42 RID: 7234
		public const int KAHBBLAKBBNFieldNumber = 2;

		// Token: 0x04001C43 RID: 7235
		private static readonly FieldCodec<uint> _repeated_kAHBBLAKBBN_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04001C44 RID: 7236
		private readonly RepeatedField<uint> kAHBBLAKBBN_ = new RepeatedField<uint>();

		// Token: 0x04001C45 RID: 7237
		public const int IsGetAllFieldNumber = 7;

		// Token: 0x04001C46 RID: 7238
		private bool isGetAll_;

		// Token: 0x04001C47 RID: 7239
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04001C48 RID: 7240
		private uint retcode_;
	}
}

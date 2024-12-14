using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000703 RID: 1795
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLoginChatInfoScRsp : IMessage<GetLoginChatInfoScRsp>, IMessage, IEquatable<GetLoginChatInfoScRsp>, IDeepCloneable<GetLoginChatInfoScRsp>, IBufferMessage
	{
		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x000D82C5 File Offset: 0x000D64C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLoginChatInfoScRsp> Parser
		{
			get
			{
				return GetLoginChatInfoScRsp._parser;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06005035 RID: 20533 RVA: 0x000D82CC File Offset: 0x000D64CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLoginChatInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x000D82DE File Offset: 0x000D64DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLoginChatInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x000D82E5 File Offset: 0x000D64E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginChatInfoScRsp()
		{
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x000D82F8 File Offset: 0x000D64F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginChatInfoScRsp(GetLoginChatInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.contactIdList_ = other.contactIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x000D832E File Offset: 0x000D652E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginChatInfoScRsp Clone()
		{
			return new GetLoginChatInfoScRsp(this);
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x000D8336 File Offset: 0x000D6536
		// (set) Token: 0x0600503B RID: 20539 RVA: 0x000D833E File Offset: 0x000D653E
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

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x000D8347 File Offset: 0x000D6547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ContactIdList
		{
			get
			{
				return this.contactIdList_;
			}
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x000D834F File Offset: 0x000D654F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLoginChatInfoScRsp);
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x000D8360 File Offset: 0x000D6560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLoginChatInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.contactIdList_.Equals(other.contactIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x000D83B0 File Offset: 0x000D65B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.contactIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x000D83FD File Offset: 0x000D65FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x000D8405 File Offset: 0x000D6605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x000D8410 File Offset: 0x000D6610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contactIdList_.WriteTo(ref output, GetLoginChatInfoScRsp._repeated_contactIdList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x000D8460 File Offset: 0x000D6660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.contactIdList_.CalculateSize(GetLoginChatInfoScRsp._repeated_contactIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x000D84B4 File Offset: 0x000D66B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLoginChatInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.contactIdList_.Add(other.contactIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x000D8501 File Offset: 0x000D6701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x000D850C File Offset: 0x000D670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U && num != 50U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.contactIdList_.AddEntriesFrom(ref input, GetLoginChatInfoScRsp._repeated_contactIdList_codec);
				}
			}
		}

		// Token: 0x04001F88 RID: 8072
		private static readonly MessageParser<GetLoginChatInfoScRsp> _parser = new MessageParser<GetLoginChatInfoScRsp>(() => new GetLoginChatInfoScRsp());

		// Token: 0x04001F89 RID: 8073
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F8A RID: 8074
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001F8B RID: 8075
		private uint retcode_;

		// Token: 0x04001F8C RID: 8076
		public const int ContactIdListFieldNumber = 6;

		// Token: 0x04001F8D RID: 8077
		private static readonly FieldCodec<uint> _repeated_contactIdList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04001F8E RID: 8078
		private readonly RepeatedField<uint> contactIdList_ = new RepeatedField<uint>();
	}
}

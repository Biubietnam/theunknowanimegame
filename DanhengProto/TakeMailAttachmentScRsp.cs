using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E5 RID: 4837
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeMailAttachmentScRsp : IMessage<TakeMailAttachmentScRsp>, IMessage, IEquatable<TakeMailAttachmentScRsp>, IDeepCloneable<TakeMailAttachmentScRsp>, IBufferMessage
	{
		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x0600D7D4 RID: 55252 RVA: 0x0023F9B3 File Offset: 0x0023DBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeMailAttachmentScRsp> Parser
		{
			get
			{
				return TakeMailAttachmentScRsp._parser;
			}
		}

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0600D7D5 RID: 55253 RVA: 0x0023F9BA File Offset: 0x0023DBBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeMailAttachmentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0600D7D6 RID: 55254 RVA: 0x0023F9CC File Offset: 0x0023DBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeMailAttachmentScRsp.Descriptor;
			}
		}

		// Token: 0x0600D7D7 RID: 55255 RVA: 0x0023F9D3 File Offset: 0x0023DBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMailAttachmentScRsp()
		{
		}

		// Token: 0x0600D7D8 RID: 55256 RVA: 0x0023F9F4 File Offset: 0x0023DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMailAttachmentScRsp(TakeMailAttachmentScRsp other) : this()
		{
			this.attachment_ = ((other.attachment_ != null) ? other.attachment_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.failMailList_ = other.failMailList_.Clone();
			this.succMailIdList_ = other.succMailIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7D9 RID: 55257 RVA: 0x0023FA62 File Offset: 0x0023DC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMailAttachmentScRsp Clone()
		{
			return new TakeMailAttachmentScRsp(this);
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x0600D7DA RID: 55258 RVA: 0x0023FA6A File Offset: 0x0023DC6A
		// (set) Token: 0x0600D7DB RID: 55259 RVA: 0x0023FA72 File Offset: 0x0023DC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Attachment
		{
			get
			{
				return this.attachment_;
			}
			set
			{
				this.attachment_ = value;
			}
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x0023FA7B File Offset: 0x0023DC7B
		// (set) Token: 0x0600D7DD RID: 55261 RVA: 0x0023FA83 File Offset: 0x0023DC83
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

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x0600D7DE RID: 55262 RVA: 0x0023FA8C File Offset: 0x0023DC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientMailAttachmentItem> FailMailList
		{
			get
			{
				return this.failMailList_;
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x0600D7DF RID: 55263 RVA: 0x0023FA94 File Offset: 0x0023DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SuccMailIdList
		{
			get
			{
				return this.succMailIdList_;
			}
		}

		// Token: 0x0600D7E0 RID: 55264 RVA: 0x0023FA9C File Offset: 0x0023DC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeMailAttachmentScRsp);
		}

		// Token: 0x0600D7E1 RID: 55265 RVA: 0x0023FAAC File Offset: 0x0023DCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeMailAttachmentScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Attachment, other.Attachment) && this.Retcode == other.Retcode && this.failMailList_.Equals(other.failMailList_) && this.succMailIdList_.Equals(other.succMailIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7E2 RID: 55266 RVA: 0x0023FB24 File Offset: 0x0023DD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.attachment_ != null)
			{
				num ^= this.Attachment.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.failMailList_.GetHashCode();
			num ^= this.succMailIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D7E3 RID: 55267 RVA: 0x0023FB95 File Offset: 0x0023DD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x0023FB9D File Offset: 0x0023DD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7E5 RID: 55269 RVA: 0x0023FBA8 File Offset: 0x0023DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.attachment_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Attachment);
			}
			this.succMailIdList_.WriteTo(ref output, TakeMailAttachmentScRsp._repeated_succMailIdList_codec);
			this.failMailList_.WriteTo(ref output, TakeMailAttachmentScRsp._repeated_failMailList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7E6 RID: 55270 RVA: 0x0023FC24 File Offset: 0x0023DE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.attachment_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Attachment);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.failMailList_.CalculateSize(TakeMailAttachmentScRsp._repeated_failMailList_codec);
			num += this.succMailIdList_.CalculateSize(TakeMailAttachmentScRsp._repeated_succMailIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D7E7 RID: 55271 RVA: 0x0023FCA0 File Offset: 0x0023DEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeMailAttachmentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.attachment_ != null)
			{
				if (this.attachment_ == null)
				{
					this.Attachment = new ItemList();
				}
				this.Attachment.MergeFrom(other.Attachment);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.failMailList_.Add(other.failMailList_);
			this.succMailIdList_.Add(other.succMailIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D7E8 RID: 55272 RVA: 0x0023FD2A File Offset: 0x0023DF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x0023FD34 File Offset: 0x0023DF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 82U)
					{
						if (this.attachment_ == null)
						{
							this.Attachment = new ItemList();
						}
						input.ReadMessage(this.Attachment);
						continue;
					}
				}
				else
				{
					if (num == 88U || num == 90U)
					{
						this.succMailIdList_.AddEntriesFrom(ref input, TakeMailAttachmentScRsp._repeated_succMailIdList_codec);
						continue;
					}
					if (num == 98U)
					{
						this.failMailList_.AddEntriesFrom(ref input, TakeMailAttachmentScRsp._repeated_failMailList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005620 RID: 22048
		private static readonly MessageParser<TakeMailAttachmentScRsp> _parser = new MessageParser<TakeMailAttachmentScRsp>(() => new TakeMailAttachmentScRsp());

		// Token: 0x04005621 RID: 22049
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005622 RID: 22050
		public const int AttachmentFieldNumber = 10;

		// Token: 0x04005623 RID: 22051
		private ItemList attachment_;

		// Token: 0x04005624 RID: 22052
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04005625 RID: 22053
		private uint retcode_;

		// Token: 0x04005626 RID: 22054
		public const int FailMailListFieldNumber = 12;

		// Token: 0x04005627 RID: 22055
		private static readonly FieldCodec<ClientMailAttachmentItem> _repeated_failMailList_codec = FieldCodec.ForMessage<ClientMailAttachmentItem>(98U, ClientMailAttachmentItem.Parser);

		// Token: 0x04005628 RID: 22056
		private readonly RepeatedField<ClientMailAttachmentItem> failMailList_ = new RepeatedField<ClientMailAttachmentItem>();

		// Token: 0x04005629 RID: 22057
		public const int SuccMailIdListFieldNumber = 11;

		// Token: 0x0400562A RID: 22058
		private static readonly FieldCodec<uint> _repeated_succMailIdList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x0400562B RID: 22059
		private readonly RepeatedField<uint> succMailIdList_ = new RepeatedField<uint>();
	}
}

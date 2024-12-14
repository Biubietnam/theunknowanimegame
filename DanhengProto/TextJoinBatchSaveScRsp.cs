using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001351 RID: 4945
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TextJoinBatchSaveScRsp : IMessage<TextJoinBatchSaveScRsp>, IMessage, IEquatable<TextJoinBatchSaveScRsp>, IDeepCloneable<TextJoinBatchSaveScRsp>, IBufferMessage
	{
		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x0600DCB0 RID: 56496 RVA: 0x0024B8FD File Offset: 0x00249AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TextJoinBatchSaveScRsp> Parser
		{
			get
			{
				return TextJoinBatchSaveScRsp._parser;
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x0600DCB1 RID: 56497 RVA: 0x0024B904 File Offset: 0x00249B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TextJoinBatchSaveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x0600DCB2 RID: 56498 RVA: 0x0024B916 File Offset: 0x00249B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextJoinBatchSaveScRsp.Descriptor;
			}
		}

		// Token: 0x0600DCB3 RID: 56499 RVA: 0x0024B91D File Offset: 0x00249B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinBatchSaveScRsp()
		{
		}

		// Token: 0x0600DCB4 RID: 56500 RVA: 0x0024B930 File Offset: 0x00249B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinBatchSaveScRsp(TextJoinBatchSaveScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.textJoinList_ = other.textJoinList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCB5 RID: 56501 RVA: 0x0024B966 File Offset: 0x00249B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinBatchSaveScRsp Clone()
		{
			return new TextJoinBatchSaveScRsp(this);
		}

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x0600DCB6 RID: 56502 RVA: 0x0024B96E File Offset: 0x00249B6E
		// (set) Token: 0x0600DCB7 RID: 56503 RVA: 0x0024B976 File Offset: 0x00249B76
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

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x0024B97F File Offset: 0x00249B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TextJoinInfo> TextJoinList
		{
			get
			{
				return this.textJoinList_;
			}
		}

		// Token: 0x0600DCB9 RID: 56505 RVA: 0x0024B987 File Offset: 0x00249B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextJoinBatchSaveScRsp);
		}

		// Token: 0x0600DCBA RID: 56506 RVA: 0x0024B998 File Offset: 0x00249B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TextJoinBatchSaveScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.textJoinList_.Equals(other.textJoinList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCBB RID: 56507 RVA: 0x0024B9E8 File Offset: 0x00249BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.textJoinList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCBC RID: 56508 RVA: 0x0024BA35 File Offset: 0x00249C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DCBD RID: 56509 RVA: 0x0024BA3D File Offset: 0x00249C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCBE RID: 56510 RVA: 0x0024BA48 File Offset: 0x00249C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			this.textJoinList_.WriteTo(ref output, TextJoinBatchSaveScRsp._repeated_textJoinList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCBF RID: 56511 RVA: 0x0024BA98 File Offset: 0x00249C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.textJoinList_.CalculateSize(TextJoinBatchSaveScRsp._repeated_textJoinList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCC0 RID: 56512 RVA: 0x0024BAEC File Offset: 0x00249CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TextJoinBatchSaveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.textJoinList_.Add(other.textJoinList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCC1 RID: 56513 RVA: 0x0024BB39 File Offset: 0x00249D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCC2 RID: 56514 RVA: 0x0024BB44 File Offset: 0x00249D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.textJoinList_.AddEntriesFrom(ref input, TextJoinBatchSaveScRsp._repeated_textJoinList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040057C8 RID: 22472
		private static readonly MessageParser<TextJoinBatchSaveScRsp> _parser = new MessageParser<TextJoinBatchSaveScRsp>(() => new TextJoinBatchSaveScRsp());

		// Token: 0x040057C9 RID: 22473
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057CA RID: 22474
		public const int RetcodeFieldNumber = 11;

		// Token: 0x040057CB RID: 22475
		private uint retcode_;

		// Token: 0x040057CC RID: 22476
		public const int TextJoinListFieldNumber = 13;

		// Token: 0x040057CD RID: 22477
		private static readonly FieldCodec<TextJoinInfo> _repeated_textJoinList_codec = FieldCodec.ForMessage<TextJoinInfo>(106U, TextJoinInfo.Parser);

		// Token: 0x040057CE RID: 22478
		private readonly RepeatedField<TextJoinInfo> textJoinList_ = new RepeatedField<TextJoinInfo>();
	}
}

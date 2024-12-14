using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001357 RID: 4951
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TextJoinQueryScRsp : IMessage<TextJoinQueryScRsp>, IMessage, IEquatable<TextJoinQueryScRsp>, IDeepCloneable<TextJoinQueryScRsp>, IBufferMessage
	{
		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x0600DCF7 RID: 56567 RVA: 0x0024C481 File Offset: 0x0024A681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TextJoinQueryScRsp> Parser
		{
			get
			{
				return TextJoinQueryScRsp._parser;
			}
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x0600DCF8 RID: 56568 RVA: 0x0024C488 File Offset: 0x0024A688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TextJoinQueryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x0600DCF9 RID: 56569 RVA: 0x0024C49A File Offset: 0x0024A69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextJoinQueryScRsp.Descriptor;
			}
		}

		// Token: 0x0600DCFA RID: 56570 RVA: 0x0024C4A1 File Offset: 0x0024A6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinQueryScRsp()
		{
		}

		// Token: 0x0600DCFB RID: 56571 RVA: 0x0024C4B4 File Offset: 0x0024A6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinQueryScRsp(TextJoinQueryScRsp other) : this()
		{
			this.textJoinList_ = other.textJoinList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCFC RID: 56572 RVA: 0x0024C4EA File Offset: 0x0024A6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinQueryScRsp Clone()
		{
			return new TextJoinQueryScRsp(this);
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x0600DCFD RID: 56573 RVA: 0x0024C4F2 File Offset: 0x0024A6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TextJoinInfo> TextJoinList
		{
			get
			{
				return this.textJoinList_;
			}
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x0600DCFE RID: 56574 RVA: 0x0024C4FA File Offset: 0x0024A6FA
		// (set) Token: 0x0600DCFF RID: 56575 RVA: 0x0024C502 File Offset: 0x0024A702
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

		// Token: 0x0600DD00 RID: 56576 RVA: 0x0024C50B File Offset: 0x0024A70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextJoinQueryScRsp);
		}

		// Token: 0x0600DD01 RID: 56577 RVA: 0x0024C51C File Offset: 0x0024A71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TextJoinQueryScRsp other)
		{
			return other != null && (other == this || (this.textJoinList_.Equals(other.textJoinList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD02 RID: 56578 RVA: 0x0024C56C File Offset: 0x0024A76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.textJoinList_.GetHashCode();
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

		// Token: 0x0600DD03 RID: 56579 RVA: 0x0024C5B9 File Offset: 0x0024A7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DD04 RID: 56580 RVA: 0x0024C5C1 File Offset: 0x0024A7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD05 RID: 56581 RVA: 0x0024C5CC File Offset: 0x0024A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.textJoinList_.WriteTo(ref output, TextJoinQueryScRsp._repeated_textJoinList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD06 RID: 56582 RVA: 0x0024C61C File Offset: 0x0024A81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.textJoinList_.CalculateSize(TextJoinQueryScRsp._repeated_textJoinList_codec);
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

		// Token: 0x0600DD07 RID: 56583 RVA: 0x0024C670 File Offset: 0x0024A870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TextJoinQueryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.textJoinList_.Add(other.textJoinList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD08 RID: 56584 RVA: 0x0024C6BD File Offset: 0x0024A8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD09 RID: 56585 RVA: 0x0024C6C8 File Offset: 0x0024A8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 56U)
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
					this.textJoinList_.AddEntriesFrom(ref input, TextJoinQueryScRsp._repeated_textJoinList_codec);
				}
			}
		}

		// Token: 0x040057E3 RID: 22499
		private static readonly MessageParser<TextJoinQueryScRsp> _parser = new MessageParser<TextJoinQueryScRsp>(() => new TextJoinQueryScRsp());

		// Token: 0x040057E4 RID: 22500
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057E5 RID: 22501
		public const int TextJoinListFieldNumber = 3;

		// Token: 0x040057E6 RID: 22502
		private static readonly FieldCodec<TextJoinInfo> _repeated_textJoinList_codec = FieldCodec.ForMessage<TextJoinInfo>(26U, TextJoinInfo.Parser);

		// Token: 0x040057E7 RID: 22503
		private readonly RepeatedField<TextJoinInfo> textJoinList_ = new RepeatedField<TextJoinInfo>();

		// Token: 0x040057E8 RID: 22504
		public const int RetcodeFieldNumber = 7;

		// Token: 0x040057E9 RID: 22505
		private uint retcode_;
	}
}

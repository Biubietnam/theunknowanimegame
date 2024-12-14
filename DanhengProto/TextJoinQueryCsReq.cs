using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001355 RID: 4949
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TextJoinQueryCsReq : IMessage<TextJoinQueryCsReq>, IMessage, IEquatable<TextJoinQueryCsReq>, IDeepCloneable<TextJoinQueryCsReq>, IBufferMessage
	{
		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x0600DCE3 RID: 56547 RVA: 0x0024C1FC File Offset: 0x0024A3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TextJoinQueryCsReq> Parser
		{
			get
			{
				return TextJoinQueryCsReq._parser;
			}
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x0600DCE4 RID: 56548 RVA: 0x0024C203 File Offset: 0x0024A403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TextJoinQueryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x0600DCE5 RID: 56549 RVA: 0x0024C215 File Offset: 0x0024A415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextJoinQueryCsReq.Descriptor;
			}
		}

		// Token: 0x0600DCE6 RID: 56550 RVA: 0x0024C21C File Offset: 0x0024A41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinQueryCsReq()
		{
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x0024C22F File Offset: 0x0024A42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinQueryCsReq(TextJoinQueryCsReq other) : this()
		{
			this.jPEADHMNMAP_ = other.jPEADHMNMAP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCE8 RID: 56552 RVA: 0x0024C259 File Offset: 0x0024A459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinQueryCsReq Clone()
		{
			return new TextJoinQueryCsReq(this);
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x0600DCE9 RID: 56553 RVA: 0x0024C261 File Offset: 0x0024A461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JPEADHMNMAP
		{
			get
			{
				return this.jPEADHMNMAP_;
			}
		}

		// Token: 0x0600DCEA RID: 56554 RVA: 0x0024C269 File Offset: 0x0024A469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextJoinQueryCsReq);
		}

		// Token: 0x0600DCEB RID: 56555 RVA: 0x0024C277 File Offset: 0x0024A477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TextJoinQueryCsReq other)
		{
			return other != null && (other == this || (this.jPEADHMNMAP_.Equals(other.jPEADHMNMAP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCEC RID: 56556 RVA: 0x0024C2AC File Offset: 0x0024A4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jPEADHMNMAP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCED RID: 56557 RVA: 0x0024C2E0 File Offset: 0x0024A4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DCEE RID: 56558 RVA: 0x0024C2E8 File Offset: 0x0024A4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCEF RID: 56559 RVA: 0x0024C2F1 File Offset: 0x0024A4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jPEADHMNMAP_.WriteTo(ref output, TextJoinQueryCsReq._repeated_jPEADHMNMAP_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCF0 RID: 56560 RVA: 0x0024C318 File Offset: 0x0024A518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jPEADHMNMAP_.CalculateSize(TextJoinQueryCsReq._repeated_jPEADHMNMAP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCF1 RID: 56561 RVA: 0x0024C351 File Offset: 0x0024A551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TextJoinQueryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.jPEADHMNMAP_.Add(other.jPEADHMNMAP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCF2 RID: 56562 RVA: 0x0024C37F File Offset: 0x0024A57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCF3 RID: 56563 RVA: 0x0024C388 File Offset: 0x0024A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.jPEADHMNMAP_.AddEntriesFrom(ref input, TextJoinQueryCsReq._repeated_jPEADHMNMAP_codec);
				}
			}
		}

		// Token: 0x040057DD RID: 22493
		private static readonly MessageParser<TextJoinQueryCsReq> _parser = new MessageParser<TextJoinQueryCsReq>(() => new TextJoinQueryCsReq());

		// Token: 0x040057DE RID: 22494
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057DF RID: 22495
		public const int JPEADHMNMAPFieldNumber = 2;

		// Token: 0x040057E0 RID: 22496
		private static readonly FieldCodec<uint> _repeated_jPEADHMNMAP_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040057E1 RID: 22497
		private readonly RepeatedField<uint> jPEADHMNMAP_ = new RepeatedField<uint>();
	}
}

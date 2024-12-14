using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200092F RID: 2351
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class INAMOOJHEAJ : IMessage<INAMOOJHEAJ>, IMessage, IEquatable<INAMOOJHEAJ>, IDeepCloneable<INAMOOJHEAJ>, IBufferMessage
	{
		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x060068E9 RID: 26857 RVA: 0x001183B9 File Offset: 0x001165B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<INAMOOJHEAJ> Parser
		{
			get
			{
				return INAMOOJHEAJ._parser;
			}
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x060068EA RID: 26858 RVA: 0x001183C0 File Offset: 0x001165C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return INAMOOJHEAJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x060068EB RID: 26859 RVA: 0x001183D2 File Offset: 0x001165D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return INAMOOJHEAJ.Descriptor;
			}
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x001183D9 File Offset: 0x001165D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public INAMOOJHEAJ()
		{
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x001183EC File Offset: 0x001165EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public INAMOOJHEAJ(INAMOOJHEAJ other) : this()
		{
			this.bDHMEMPHAGI_ = other.bDHMEMPHAGI_.Clone();
			this.goodsId_ = other.goodsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x00118422 File Offset: 0x00116622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public INAMOOJHEAJ Clone()
		{
			return new INAMOOJHEAJ(this);
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x060068EF RID: 26863 RVA: 0x0011842A File Offset: 0x0011662A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DPPBBCKLCBF> BDHMEMPHAGI
		{
			get
			{
				return this.bDHMEMPHAGI_;
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x060068F0 RID: 26864 RVA: 0x00118432 File Offset: 0x00116632
		// (set) Token: 0x060068F1 RID: 26865 RVA: 0x0011843A File Offset: 0x0011663A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GoodsId
		{
			get
			{
				return this.goodsId_;
			}
			set
			{
				this.goodsId_ = value;
			}
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x00118443 File Offset: 0x00116643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as INAMOOJHEAJ);
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x00118454 File Offset: 0x00116654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(INAMOOJHEAJ other)
		{
			return other != null && (other == this || (this.bDHMEMPHAGI_.Equals(other.bDHMEMPHAGI_) && this.GoodsId == other.GoodsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x001184A4 File Offset: 0x001166A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bDHMEMPHAGI_.GetHashCode();
			if (this.GoodsId != 0U)
			{
				num ^= this.GoodsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x001184F1 File Offset: 0x001166F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x001184F9 File Offset: 0x001166F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068F7 RID: 26871 RVA: 0x00118504 File Offset: 0x00116704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GoodsId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GoodsId);
			}
			this.bDHMEMPHAGI_.WriteTo(ref output, INAMOOJHEAJ._repeated_bDHMEMPHAGI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068F8 RID: 26872 RVA: 0x00118554 File Offset: 0x00116754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bDHMEMPHAGI_.CalculateSize(INAMOOJHEAJ._repeated_bDHMEMPHAGI_codec);
			if (this.GoodsId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GoodsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x001185A8 File Offset: 0x001167A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(INAMOOJHEAJ other)
		{
			if (other == null)
			{
				return;
			}
			this.bDHMEMPHAGI_.Add(other.bDHMEMPHAGI_);
			if (other.GoodsId != 0U)
			{
				this.GoodsId = other.GoodsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x001185F5 File Offset: 0x001167F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x00118600 File Offset: 0x00116800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bDHMEMPHAGI_.AddEntriesFrom(ref input, INAMOOJHEAJ._repeated_bDHMEMPHAGI_codec);
					}
				}
				else
				{
					this.GoodsId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400283F RID: 10303
		private static readonly MessageParser<INAMOOJHEAJ> _parser = new MessageParser<INAMOOJHEAJ>(() => new INAMOOJHEAJ());

		// Token: 0x04002840 RID: 10304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002841 RID: 10305
		public const int BDHMEMPHAGIFieldNumber = 5;

		// Token: 0x04002842 RID: 10306
		private static readonly FieldCodec<DPPBBCKLCBF> _repeated_bDHMEMPHAGI_codec = FieldCodec.ForMessage<DPPBBCKLCBF>(42U, DPPBBCKLCBF.Parser);

		// Token: 0x04002843 RID: 10307
		private readonly RepeatedField<DPPBBCKLCBF> bDHMEMPHAGI_ = new RepeatedField<DPPBBCKLCBF>();

		// Token: 0x04002844 RID: 10308
		public const int GoodsIdFieldNumber = 1;

		// Token: 0x04002845 RID: 10309
		private uint goodsId_;
	}
}

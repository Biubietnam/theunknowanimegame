using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200097B RID: 2427
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JNDMKHIBCPJ : IMessage<JNDMKHIBCPJ>, IMessage, IEquatable<JNDMKHIBCPJ>, IDeepCloneable<JNDMKHIBCPJ>, IBufferMessage
	{
		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06006C86 RID: 27782 RVA: 0x00121B9F File Offset: 0x0011FD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JNDMKHIBCPJ> Parser
		{
			get
			{
				return JNDMKHIBCPJ._parser;
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06006C87 RID: 27783 RVA: 0x00121BA6 File Offset: 0x0011FDA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JNDMKHIBCPJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x00121BB8 File Offset: 0x0011FDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JNDMKHIBCPJ.Descriptor;
			}
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x00121BBF File Offset: 0x0011FDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JNDMKHIBCPJ()
		{
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x00121BF4 File Offset: 0x0011FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JNDMKHIBCPJ(JNDMKHIBCPJ other) : this()
		{
			this.hHFFBJLBOKC_ = other.hHFFBJLBOKC_.Clone();
			this.aJBKFJJHGLF_ = other.aJBKFJJHGLF_.Clone();
			this.hLKBEPEMBDC_ = other.hLKBEPEMBDC_.Clone();
			this.eGDELMANGPJ_ = other.eGDELMANGPJ_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x00121C5C File Offset: 0x0011FE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JNDMKHIBCPJ Clone()
		{
			return new JNDMKHIBCPJ(this);
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06006C8C RID: 27788 RVA: 0x00121C64 File Offset: 0x0011FE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicScepter> HHFFBJLBOKC
		{
			get
			{
				return this.hHFFBJLBOKC_;
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06006C8D RID: 27789 RVA: 0x00121C6C File Offset: 0x0011FE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AJBKFJJHGLF
		{
			get
			{
				return this.aJBKFJJHGLF_;
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06006C8E RID: 27790 RVA: 0x00121C74 File Offset: 0x0011FE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HLKBEPEMBDC
		{
			get
			{
				return this.hLKBEPEMBDC_;
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06006C8F RID: 27791 RVA: 0x00121C7C File Offset: 0x0011FE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicGameUnit> EGDELMANGPJ
		{
			get
			{
				return this.eGDELMANGPJ_;
			}
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x00121C84 File Offset: 0x0011FE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JNDMKHIBCPJ);
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x00121C94 File Offset: 0x0011FE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JNDMKHIBCPJ other)
		{
			return other != null && (other == this || (this.hHFFBJLBOKC_.Equals(other.hHFFBJLBOKC_) && this.aJBKFJJHGLF_.Equals(other.aJBKFJJHGLF_) && this.hLKBEPEMBDC_.Equals(other.hLKBEPEMBDC_) && this.eGDELMANGPJ_.Equals(other.eGDELMANGPJ_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x00121D14 File Offset: 0x0011FF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hHFFBJLBOKC_.GetHashCode();
			num ^= this.aJBKFJJHGLF_.GetHashCode();
			num ^= this.hLKBEPEMBDC_.GetHashCode();
			num ^= this.eGDELMANGPJ_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x00121D72 File Offset: 0x0011FF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x00121D7A File Offset: 0x0011FF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x00121D84 File Offset: 0x0011FF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hHFFBJLBOKC_.WriteTo(ref output, JNDMKHIBCPJ._repeated_hHFFBJLBOKC_codec);
			this.hLKBEPEMBDC_.WriteTo(ref output, JNDMKHIBCPJ._repeated_hLKBEPEMBDC_codec);
			this.aJBKFJJHGLF_.WriteTo(ref output, JNDMKHIBCPJ._repeated_aJBKFJJHGLF_codec);
			this.eGDELMANGPJ_.WriteTo(ref output, JNDMKHIBCPJ._repeated_eGDELMANGPJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x00121DEC File Offset: 0x0011FFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hHFFBJLBOKC_.CalculateSize(JNDMKHIBCPJ._repeated_hHFFBJLBOKC_codec);
			num += this.aJBKFJJHGLF_.CalculateSize(JNDMKHIBCPJ._repeated_aJBKFJJHGLF_codec);
			num += this.hLKBEPEMBDC_.CalculateSize(JNDMKHIBCPJ._repeated_hLKBEPEMBDC_codec);
			num += this.eGDELMANGPJ_.CalculateSize(JNDMKHIBCPJ._repeated_eGDELMANGPJ_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00121E60 File Offset: 0x00120060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JNDMKHIBCPJ other)
		{
			if (other == null)
			{
				return;
			}
			this.hHFFBJLBOKC_.Add(other.hHFFBJLBOKC_);
			this.aJBKFJJHGLF_.Add(other.aJBKFJJHGLF_);
			this.hLKBEPEMBDC_.Add(other.hLKBEPEMBDC_);
			this.eGDELMANGPJ_.Add(other.eGDELMANGPJ_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00121ECC File Offset: 0x001200CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x00121ED8 File Offset: 0x001200D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 10U)
					{
						this.hHFFBJLBOKC_.AddEntriesFrom(ref input, JNDMKHIBCPJ._repeated_hHFFBJLBOKC_codec);
						continue;
					}
					if (num == 48U || num == 50U)
					{
						this.hLKBEPEMBDC_.AddEntriesFrom(ref input, JNDMKHIBCPJ._repeated_hLKBEPEMBDC_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U || num == 58U)
					{
						this.aJBKFJJHGLF_.AddEntriesFrom(ref input, JNDMKHIBCPJ._repeated_aJBKFJJHGLF_codec);
						continue;
					}
					if (num == 106U)
					{
						this.eGDELMANGPJ_.AddEntriesFrom(ref input, JNDMKHIBCPJ._repeated_eGDELMANGPJ_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002992 RID: 10642
		private static readonly MessageParser<JNDMKHIBCPJ> _parser = new MessageParser<JNDMKHIBCPJ>(() => new JNDMKHIBCPJ());

		// Token: 0x04002993 RID: 10643
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002994 RID: 10644
		public const int HHFFBJLBOKCFieldNumber = 1;

		// Token: 0x04002995 RID: 10645
		private static readonly FieldCodec<RogueMagicScepter> _repeated_hHFFBJLBOKC_codec = FieldCodec.ForMessage<RogueMagicScepter>(10U, RogueMagicScepter.Parser);

		// Token: 0x04002996 RID: 10646
		private readonly RepeatedField<RogueMagicScepter> hHFFBJLBOKC_ = new RepeatedField<RogueMagicScepter>();

		// Token: 0x04002997 RID: 10647
		public const int AJBKFJJHGLFFieldNumber = 7;

		// Token: 0x04002998 RID: 10648
		private static readonly FieldCodec<uint> _repeated_aJBKFJJHGLF_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04002999 RID: 10649
		private readonly RepeatedField<uint> aJBKFJJHGLF_ = new RepeatedField<uint>();

		// Token: 0x0400299A RID: 10650
		public const int HLKBEPEMBDCFieldNumber = 6;

		// Token: 0x0400299B RID: 10651
		private static readonly FieldCodec<uint> _repeated_hLKBEPEMBDC_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x0400299C RID: 10652
		private readonly RepeatedField<uint> hLKBEPEMBDC_ = new RepeatedField<uint>();

		// Token: 0x0400299D RID: 10653
		public const int EGDELMANGPJFieldNumber = 13;

		// Token: 0x0400299E RID: 10654
		private static readonly FieldCodec<RogueMagicGameUnit> _repeated_eGDELMANGPJ_codec = FieldCodec.ForMessage<RogueMagicGameUnit>(106U, RogueMagicGameUnit.Parser);

		// Token: 0x0400299F RID: 10655
		private readonly RepeatedField<RogueMagicGameUnit> eGDELMANGPJ_ = new RepeatedField<RogueMagicGameUnit>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000507 RID: 1287
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FCDNGMIFCNO : IMessage<FCDNGMIFCNO>, IMessage, IEquatable<FCDNGMIFCNO>, IDeepCloneable<FCDNGMIFCNO>, IBufferMessage
	{
		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x0009EA45 File Offset: 0x0009CC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FCDNGMIFCNO> Parser
		{
			get
			{
				return FCDNGMIFCNO._parser;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x0009EA4C File Offset: 0x0009CC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FCDNGMIFCNOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x0009EA5E File Offset: 0x0009CC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FCDNGMIFCNO.Descriptor;
			}
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x0009EA65 File Offset: 0x0009CC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FCDNGMIFCNO()
		{
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x0009EA70 File Offset: 0x0009CC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FCDNGMIFCNO(FCDNGMIFCNO other) : this()
		{
			this.eMOALFBGGAI_ = ((other.eMOALFBGGAI_ != null) ? other.eMOALFBGGAI_.Clone() : null);
			this.jGKJJKFBLCF_ = other.jGKJJKFBLCF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x0009EABC File Offset: 0x0009CCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FCDNGMIFCNO Clone()
		{
			return new FCDNGMIFCNO(this);
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x060039B1 RID: 14769 RVA: 0x0009EAC4 File Offset: 0x0009CCC4
		// (set) Token: 0x060039B2 RID: 14770 RVA: 0x0009EACC File Offset: 0x0009CCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKACCPKNCKI EMOALFBGGAI
		{
			get
			{
				return this.eMOALFBGGAI_;
			}
			set
			{
				this.eMOALFBGGAI_ = value;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x060039B3 RID: 14771 RVA: 0x0009EAD5 File Offset: 0x0009CCD5
		// (set) Token: 0x060039B4 RID: 14772 RVA: 0x0009EADD File Offset: 0x0009CCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JGKJJKFBLCF
		{
			get
			{
				return this.jGKJJKFBLCF_;
			}
			set
			{
				this.jGKJJKFBLCF_ = value;
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0009EAE6 File Offset: 0x0009CCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FCDNGMIFCNO);
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x0009EAF4 File Offset: 0x0009CCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FCDNGMIFCNO other)
		{
			return other != null && (other == this || (object.Equals(this.EMOALFBGGAI, other.EMOALFBGGAI) && this.JGKJJKFBLCF == other.JGKJJKFBLCF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0009EB44 File Offset: 0x0009CD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.eMOALFBGGAI_ != null)
			{
				num ^= this.EMOALFBGGAI.GetHashCode();
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				num ^= this.JGKJJKFBLCF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0009EB99 File Offset: 0x0009CD99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0009EBA1 File Offset: 0x0009CDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x0009EBAC File Offset: 0x0009CDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.eMOALFBGGAI_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.EMOALFBGGAI);
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.JGKJJKFBLCF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x0009EC08 File Offset: 0x0009CE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.eMOALFBGGAI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EMOALFBGGAI);
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JGKJJKFBLCF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x0009EC60 File Offset: 0x0009CE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FCDNGMIFCNO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.eMOALFBGGAI_ != null)
			{
				if (this.eMOALFBGGAI_ == null)
				{
					this.EMOALFBGGAI = new MKACCPKNCKI();
				}
				this.EMOALFBGGAI.MergeFrom(other.EMOALFBGGAI);
			}
			if (other.JGKJJKFBLCF != 0U)
			{
				this.JGKJJKFBLCF = other.JGKJJKFBLCF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x0009ECC8 File Offset: 0x0009CEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x0009ECD4 File Offset: 0x0009CED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.JGKJJKFBLCF = input.ReadUInt32();
					}
				}
				else
				{
					if (this.eMOALFBGGAI_ == null)
					{
						this.EMOALFBGGAI = new MKACCPKNCKI();
					}
					input.ReadMessage(this.EMOALFBGGAI);
				}
			}
		}

		// Token: 0x040016F7 RID: 5879
		private static readonly MessageParser<FCDNGMIFCNO> _parser = new MessageParser<FCDNGMIFCNO>(() => new FCDNGMIFCNO());

		// Token: 0x040016F8 RID: 5880
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016F9 RID: 5881
		public const int EMOALFBGGAIFieldNumber = 3;

		// Token: 0x040016FA RID: 5882
		private MKACCPKNCKI eMOALFBGGAI_;

		// Token: 0x040016FB RID: 5883
		public const int JGKJJKFBLCFFieldNumber = 9;

		// Token: 0x040016FC RID: 5884
		private uint jGKJJKFBLCF_;
	}
}

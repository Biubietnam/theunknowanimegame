using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C5D RID: 3165
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OKEDFCPCFJO : IMessage<OKEDFCPCFJO>, IMessage, IEquatable<OKEDFCPCFJO>, IDeepCloneable<OKEDFCPCFJO>, IBufferMessage
	{
		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x06008C95 RID: 35989 RVA: 0x00173AFD File Offset: 0x00171CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OKEDFCPCFJO> Parser
		{
			get
			{
				return OKEDFCPCFJO._parser;
			}
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06008C96 RID: 35990 RVA: 0x00173B04 File Offset: 0x00171D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OKEDFCPCFJOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x06008C97 RID: 35991 RVA: 0x00173B16 File Offset: 0x00171D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OKEDFCPCFJO.Descriptor;
			}
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x00173B1D File Offset: 0x00171D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKEDFCPCFJO()
		{
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x00173B28 File Offset: 0x00171D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKEDFCPCFJO(OKEDFCPCFJO other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.kKCHCLOLPMB_ = other.kKCHCLOLPMB_;
			this.aDPPOPDFHPK_ = other.aDPPOPDFHPK_;
			this.lGKAIBKLJKG_ = other.lGKAIBKLJKG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C9A RID: 35994 RVA: 0x00173B7C File Offset: 0x00171D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKEDFCPCFJO Clone()
		{
			return new OKEDFCPCFJO(this);
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x06008C9B RID: 35995 RVA: 0x00173B84 File Offset: 0x00171D84
		// (set) Token: 0x06008C9C RID: 35996 RVA: 0x00173B8C File Offset: 0x00171D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x06008C9D RID: 35997 RVA: 0x00173B95 File Offset: 0x00171D95
		// (set) Token: 0x06008C9E RID: 35998 RVA: 0x00173B9D File Offset: 0x00171D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KKCHCLOLPMB
		{
			get
			{
				return this.kKCHCLOLPMB_;
			}
			set
			{
				this.kKCHCLOLPMB_ = value;
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x06008C9F RID: 35999 RVA: 0x00173BA6 File Offset: 0x00171DA6
		// (set) Token: 0x06008CA0 RID: 36000 RVA: 0x00173BAE File Offset: 0x00171DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ADPPOPDFHPK
		{
			get
			{
				return this.aDPPOPDFHPK_;
			}
			set
			{
				this.aDPPOPDFHPK_ = value;
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x06008CA1 RID: 36001 RVA: 0x00173BB7 File Offset: 0x00171DB7
		// (set) Token: 0x06008CA2 RID: 36002 RVA: 0x00173BBF File Offset: 0x00171DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LGKAIBKLJKG
		{
			get
			{
				return this.lGKAIBKLJKG_;
			}
			set
			{
				this.lGKAIBKLJKG_ = value;
			}
		}

		// Token: 0x06008CA3 RID: 36003 RVA: 0x00173BC8 File Offset: 0x00171DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OKEDFCPCFJO);
		}

		// Token: 0x06008CA4 RID: 36004 RVA: 0x00173BD8 File Offset: 0x00171DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OKEDFCPCFJO other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.KKCHCLOLPMB == other.KKCHCLOLPMB && this.ADPPOPDFHPK == other.ADPPOPDFHPK && this.LGKAIBKLJKG == other.LGKAIBKLJKG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x00173C44 File Offset: 0x00171E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				num ^= this.KKCHCLOLPMB.GetHashCode();
			}
			if (this.ADPPOPDFHPK != 0U)
			{
				num ^= this.ADPPOPDFHPK.GetHashCode();
			}
			if (this.LGKAIBKLJKG != 0U)
			{
				num ^= this.LGKAIBKLJKG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CA6 RID: 36006 RVA: 0x00173CCE File Offset: 0x00171ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008CA7 RID: 36007 RVA: 0x00173CD6 File Offset: 0x00171ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CA8 RID: 36008 RVA: 0x00173CE0 File Offset: 0x00171EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.KKCHCLOLPMB);
			}
			if (this.ADPPOPDFHPK != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ADPPOPDFHPK);
			}
			if (this.LGKAIBKLJKG != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LGKAIBKLJKG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CA9 RID: 36009 RVA: 0x00173D70 File Offset: 0x00171F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KKCHCLOLPMB);
			}
			if (this.ADPPOPDFHPK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ADPPOPDFHPK);
			}
			if (this.LGKAIBKLJKG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LGKAIBKLJKG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CAA RID: 36010 RVA: 0x00173DF8 File Offset: 0x00171FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OKEDFCPCFJO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.KKCHCLOLPMB != 0U)
			{
				this.KKCHCLOLPMB = other.KKCHCLOLPMB;
			}
			if (other.ADPPOPDFHPK != 0U)
			{
				this.ADPPOPDFHPK = other.ADPPOPDFHPK;
			}
			if (other.LGKAIBKLJKG != 0U)
			{
				this.LGKAIBKLJKG = other.LGKAIBKLJKG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x00173E70 File Offset: 0x00172070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x00173E7C File Offset: 0x0017207C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.MonsterId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.KKCHCLOLPMB = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ADPPOPDFHPK = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.LGKAIBKLJKG = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003601 RID: 13825
		private static readonly MessageParser<OKEDFCPCFJO> _parser = new MessageParser<OKEDFCPCFJO>(() => new OKEDFCPCFJO());

		// Token: 0x04003602 RID: 13826
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003603 RID: 13827
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x04003604 RID: 13828
		private uint monsterId_;

		// Token: 0x04003605 RID: 13829
		public const int KKCHCLOLPMBFieldNumber = 2;

		// Token: 0x04003606 RID: 13830
		private uint kKCHCLOLPMB_;

		// Token: 0x04003607 RID: 13831
		public const int ADPPOPDFHPKFieldNumber = 3;

		// Token: 0x04003608 RID: 13832
		private uint aDPPOPDFHPK_;

		// Token: 0x04003609 RID: 13833
		public const int LGKAIBKLJKGFieldNumber = 4;

		// Token: 0x0400360A RID: 13834
		private uint lGKAIBKLJKG_;
	}
}

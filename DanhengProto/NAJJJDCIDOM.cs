using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BFB RID: 3067
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NAJJJDCIDOM : IMessage<NAJJJDCIDOM>, IMessage, IEquatable<NAJJJDCIDOM>, IDeepCloneable<NAJJJDCIDOM>, IBufferMessage
	{
		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x060087C2 RID: 34754 RVA: 0x00166865 File Offset: 0x00164A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NAJJJDCIDOM> Parser
		{
			get
			{
				return NAJJJDCIDOM._parser;
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x060087C3 RID: 34755 RVA: 0x0016686C File Offset: 0x00164A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NAJJJDCIDOMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x060087C4 RID: 34756 RVA: 0x0016687E File Offset: 0x00164A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NAJJJDCIDOM.Descriptor;
			}
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x00166885 File Offset: 0x00164A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAJJJDCIDOM()
		{
		}

		// Token: 0x060087C6 RID: 34758 RVA: 0x00166890 File Offset: 0x00164A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAJJJDCIDOM(NAJJJDCIDOM other) : this()
		{
			this.eJOLGOMIJNK_ = other.eJOLGOMIJNK_;
			this.cCGBAAKJHFK_ = other.cCGBAAKJHFK_;
			this.nFFLIIKFGBI_ = other.nFFLIIKFGBI_;
			this.fHPNLFHNPLJ_ = other.fHPNLFHNPLJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x001668E4 File Offset: 0x00164AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAJJJDCIDOM Clone()
		{
			return new NAJJJDCIDOM(this);
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x060087C8 RID: 34760 RVA: 0x001668EC File Offset: 0x00164AEC
		// (set) Token: 0x060087C9 RID: 34761 RVA: 0x001668F4 File Offset: 0x00164AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EJOLGOMIJNK
		{
			get
			{
				return this.eJOLGOMIJNK_;
			}
			set
			{
				this.eJOLGOMIJNK_ = value;
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x060087CA RID: 34762 RVA: 0x001668FD File Offset: 0x00164AFD
		// (set) Token: 0x060087CB RID: 34763 RVA: 0x00166905 File Offset: 0x00164B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CCGBAAKJHFK
		{
			get
			{
				return this.cCGBAAKJHFK_;
			}
			set
			{
				this.cCGBAAKJHFK_ = value;
			}
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x0016690E File Offset: 0x00164B0E
		// (set) Token: 0x060087CD RID: 34765 RVA: 0x00166916 File Offset: 0x00164B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NFFLIIKFGBI
		{
			get
			{
				return this.nFFLIIKFGBI_;
			}
			set
			{
				this.nFFLIIKFGBI_ = value;
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x060087CE RID: 34766 RVA: 0x0016691F File Offset: 0x00164B1F
		// (set) Token: 0x060087CF RID: 34767 RVA: 0x00166927 File Offset: 0x00164B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FHPNLFHNPLJ
		{
			get
			{
				return this.fHPNLFHNPLJ_;
			}
			set
			{
				this.fHPNLFHNPLJ_ = value;
			}
		}

		// Token: 0x060087D0 RID: 34768 RVA: 0x00166930 File Offset: 0x00164B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NAJJJDCIDOM);
		}

		// Token: 0x060087D1 RID: 34769 RVA: 0x00166940 File Offset: 0x00164B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NAJJJDCIDOM other)
		{
			return other != null && (other == this || (this.EJOLGOMIJNK == other.EJOLGOMIJNK && this.CCGBAAKJHFK == other.CCGBAAKJHFK && this.NFFLIIKFGBI == other.NFFLIIKFGBI && this.FHPNLFHNPLJ == other.FHPNLFHNPLJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087D2 RID: 34770 RVA: 0x001669AC File Offset: 0x00164BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EJOLGOMIJNK != 0U)
			{
				num ^= this.EJOLGOMIJNK.GetHashCode();
			}
			if (this.CCGBAAKJHFK != 0U)
			{
				num ^= this.CCGBAAKJHFK.GetHashCode();
			}
			if (this.NFFLIIKFGBI != 0U)
			{
				num ^= this.NFFLIIKFGBI.GetHashCode();
			}
			if (this.FHPNLFHNPLJ != 0U)
			{
				num ^= this.FHPNLFHNPLJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x00166A36 File Offset: 0x00164C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060087D4 RID: 34772 RVA: 0x00166A3E File Offset: 0x00164C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087D5 RID: 34773 RVA: 0x00166A48 File Offset: 0x00164C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NFFLIIKFGBI != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.NFFLIIKFGBI);
			}
			if (this.FHPNLFHNPLJ != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.FHPNLFHNPLJ);
			}
			if (this.CCGBAAKJHFK != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.CCGBAAKJHFK);
			}
			if (this.EJOLGOMIJNK != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EJOLGOMIJNK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087D6 RID: 34774 RVA: 0x00166ADC File Offset: 0x00164CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EJOLGOMIJNK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EJOLGOMIJNK);
			}
			if (this.CCGBAAKJHFK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CCGBAAKJHFK);
			}
			if (this.NFFLIIKFGBI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NFFLIIKFGBI);
			}
			if (this.FHPNLFHNPLJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FHPNLFHNPLJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087D7 RID: 34775 RVA: 0x00166B64 File Offset: 0x00164D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NAJJJDCIDOM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EJOLGOMIJNK != 0U)
			{
				this.EJOLGOMIJNK = other.EJOLGOMIJNK;
			}
			if (other.CCGBAAKJHFK != 0U)
			{
				this.CCGBAAKJHFK = other.CCGBAAKJHFK;
			}
			if (other.NFFLIIKFGBI != 0U)
			{
				this.NFFLIIKFGBI = other.NFFLIIKFGBI;
			}
			if (other.FHPNLFHNPLJ != 0U)
			{
				this.FHPNLFHNPLJ = other.FHPNLFHNPLJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x00166BDC File Offset: 0x00164DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x00166BE8 File Offset: 0x00164DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.NFFLIIKFGBI = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.FHPNLFHNPLJ = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.CCGBAAKJHFK = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.EJOLGOMIJNK = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003412 RID: 13330
		private static readonly MessageParser<NAJJJDCIDOM> _parser = new MessageParser<NAJJJDCIDOM>(() => new NAJJJDCIDOM());

		// Token: 0x04003413 RID: 13331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003414 RID: 13332
		public const int EJOLGOMIJNKFieldNumber = 12;

		// Token: 0x04003415 RID: 13333
		private uint eJOLGOMIJNK_;

		// Token: 0x04003416 RID: 13334
		public const int CCGBAAKJHFKFieldNumber = 7;

		// Token: 0x04003417 RID: 13335
		private uint cCGBAAKJHFK_;

		// Token: 0x04003418 RID: 13336
		public const int NFFLIIKFGBIFieldNumber = 4;

		// Token: 0x04003419 RID: 13337
		private uint nFFLIIKFGBI_;

		// Token: 0x0400341A RID: 13338
		public const int FHPNLFHNPLJFieldNumber = 5;

		// Token: 0x0400341B RID: 13339
		private uint fHPNLFHNPLJ_;
	}
}

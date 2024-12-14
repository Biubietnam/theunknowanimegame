using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200092D RID: 2349
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IMJPKICFBLI : IMessage<IMJPKICFBLI>, IMessage, IEquatable<IMJPKICFBLI>, IDeepCloneable<IMJPKICFBLI>, IBufferMessage
	{
		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x060068D0 RID: 26832 RVA: 0x00117FC9 File Offset: 0x001161C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IMJPKICFBLI> Parser
		{
			get
			{
				return IMJPKICFBLI._parser;
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x060068D1 RID: 26833 RVA: 0x00117FD0 File Offset: 0x001161D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IMJPKICFBLIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x060068D2 RID: 26834 RVA: 0x00117FE2 File Offset: 0x001161E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IMJPKICFBLI.Descriptor;
			}
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x00117FE9 File Offset: 0x001161E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMJPKICFBLI()
		{
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x00117FF1 File Offset: 0x001161F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMJPKICFBLI(IMJPKICFBLI other) : this()
		{
			this.aPJBNMCNODJ_ = other.aPJBNMCNODJ_;
			this.hAMHNEEJILB_ = other.hAMHNEEJILB_;
			this.mHDMMOCGLCB_ = other.mHDMMOCGLCB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x0011802E File Offset: 0x0011622E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMJPKICFBLI Clone()
		{
			return new IMJPKICFBLI(this);
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x060068D6 RID: 26838 RVA: 0x00118036 File Offset: 0x00116236
		// (set) Token: 0x060068D7 RID: 26839 RVA: 0x0011803E File Offset: 0x0011623E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int APJBNMCNODJ
		{
			get
			{
				return this.aPJBNMCNODJ_;
			}
			set
			{
				this.aPJBNMCNODJ_ = value;
			}
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x060068D8 RID: 26840 RVA: 0x00118047 File Offset: 0x00116247
		// (set) Token: 0x060068D9 RID: 26841 RVA: 0x0011804F File Offset: 0x0011624F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HAMHNEEJILB
		{
			get
			{
				return this.hAMHNEEJILB_;
			}
			set
			{
				this.hAMHNEEJILB_ = value;
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x060068DA RID: 26842 RVA: 0x00118058 File Offset: 0x00116258
		// (set) Token: 0x060068DB RID: 26843 RVA: 0x00118060 File Offset: 0x00116260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MHDMMOCGLCB
		{
			get
			{
				return this.mHDMMOCGLCB_;
			}
			set
			{
				this.mHDMMOCGLCB_ = value;
			}
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x00118069 File Offset: 0x00116269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IMJPKICFBLI);
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x00118078 File Offset: 0x00116278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IMJPKICFBLI other)
		{
			return other != null && (other == this || (this.APJBNMCNODJ == other.APJBNMCNODJ && this.HAMHNEEJILB == other.HAMHNEEJILB && this.MHDMMOCGLCB == other.MHDMMOCGLCB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x001180D4 File Offset: 0x001162D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.APJBNMCNODJ != 0)
			{
				num ^= this.APJBNMCNODJ.GetHashCode();
			}
			if (this.HAMHNEEJILB != 0)
			{
				num ^= this.HAMHNEEJILB.GetHashCode();
			}
			if (this.MHDMMOCGLCB != 0)
			{
				num ^= this.MHDMMOCGLCB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x00118145 File Offset: 0x00116345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x0011814D File Offset: 0x0011634D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x00118158 File Offset: 0x00116358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HAMHNEEJILB != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HAMHNEEJILB);
			}
			if (this.APJBNMCNODJ != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.APJBNMCNODJ);
			}
			if (this.MHDMMOCGLCB != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MHDMMOCGLCB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x001181D0 File Offset: 0x001163D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.APJBNMCNODJ != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.APJBNMCNODJ);
			}
			if (this.HAMHNEEJILB != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HAMHNEEJILB);
			}
			if (this.MHDMMOCGLCB != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MHDMMOCGLCB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x00118240 File Offset: 0x00116440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IMJPKICFBLI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.APJBNMCNODJ != 0)
			{
				this.APJBNMCNODJ = other.APJBNMCNODJ;
			}
			if (other.HAMHNEEJILB != 0)
			{
				this.HAMHNEEJILB = other.HAMHNEEJILB;
			}
			if (other.MHDMMOCGLCB != 0)
			{
				this.MHDMMOCGLCB = other.MHDMMOCGLCB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x001182A4 File Offset: 0x001164A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x001182B0 File Offset: 0x001164B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 88U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MHDMMOCGLCB = input.ReadInt32();
						}
					}
					else
					{
						this.APJBNMCNODJ = input.ReadInt32();
					}
				}
				else
				{
					this.HAMHNEEJILB = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002836 RID: 10294
		private static readonly MessageParser<IMJPKICFBLI> _parser = new MessageParser<IMJPKICFBLI>(() => new IMJPKICFBLI());

		// Token: 0x04002837 RID: 10295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002838 RID: 10296
		public const int APJBNMCNODJFieldNumber = 11;

		// Token: 0x04002839 RID: 10297
		private int aPJBNMCNODJ_;

		// Token: 0x0400283A RID: 10298
		public const int HAMHNEEJILBFieldNumber = 5;

		// Token: 0x0400283B RID: 10299
		private int hAMHNEEJILB_;

		// Token: 0x0400283C RID: 10300
		public const int MHDMMOCGLCBFieldNumber = 13;

		// Token: 0x0400283D RID: 10301
		private int mHDMMOCGLCB_;
	}
}

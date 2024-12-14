using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200098D RID: 2445
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KCLICGHKKPH : IMessage<KCLICGHKKPH>, IMessage, IEquatable<KCLICGHKKPH>, IDeepCloneable<KCLICGHKKPH>, IBufferMessage
	{
		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06006D63 RID: 28003 RVA: 0x0012482F File Offset: 0x00122A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KCLICGHKKPH> Parser
		{
			get
			{
				return KCLICGHKKPH._parser;
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06006D64 RID: 28004 RVA: 0x00124836 File Offset: 0x00122A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KCLICGHKKPHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06006D65 RID: 28005 RVA: 0x00124848 File Offset: 0x00122A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KCLICGHKKPH.Descriptor;
			}
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x0012484F File Offset: 0x00122A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KCLICGHKKPH()
		{
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x00124858 File Offset: 0x00122A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KCLICGHKKPH(KCLICGHKKPH other) : this()
		{
			this.fINJGCCOKDO_ = other.fINJGCCOKDO_;
			this.jBBKLJJCLPH_ = other.jBBKLJJCLPH_;
			this.kFOGCJPNCNB_ = other.kFOGCJPNCNB_;
			this.cOAMOBLAGLB_ = other.cOAMOBLAGLB_;
			this.mOPLDLOFBAJ_ = other.mOPLDLOFBAJ_;
			this.itemValue_ = other.itemValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x001248C4 File Offset: 0x00122AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KCLICGHKKPH Clone()
		{
			return new KCLICGHKKPH(this);
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x001248CC File Offset: 0x00122ACC
		// (set) Token: 0x06006D6A RID: 28010 RVA: 0x001248D4 File Offset: 0x00122AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FINJGCCOKDO
		{
			get
			{
				return this.fINJGCCOKDO_;
			}
			set
			{
				this.fINJGCCOKDO_ = value;
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06006D6B RID: 28011 RVA: 0x001248DD File Offset: 0x00122ADD
		// (set) Token: 0x06006D6C RID: 28012 RVA: 0x001248E5 File Offset: 0x00122AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JBBKLJJCLPH
		{
			get
			{
				return this.jBBKLJJCLPH_;
			}
			set
			{
				this.jBBKLJJCLPH_ = value;
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06006D6D RID: 28013 RVA: 0x001248EE File Offset: 0x00122AEE
		// (set) Token: 0x06006D6E RID: 28014 RVA: 0x001248F6 File Offset: 0x00122AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KFOGCJPNCNB
		{
			get
			{
				return this.kFOGCJPNCNB_;
			}
			set
			{
				this.kFOGCJPNCNB_ = value;
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06006D6F RID: 28015 RVA: 0x001248FF File Offset: 0x00122AFF
		// (set) Token: 0x06006D70 RID: 28016 RVA: 0x00124907 File Offset: 0x00122B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool COAMOBLAGLB
		{
			get
			{
				return this.cOAMOBLAGLB_;
			}
			set
			{
				this.cOAMOBLAGLB_ = value;
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x00124910 File Offset: 0x00122B10
		// (set) Token: 0x06006D72 RID: 28018 RVA: 0x00124918 File Offset: 0x00122B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MOPLDLOFBAJ
		{
			get
			{
				return this.mOPLDLOFBAJ_;
			}
			set
			{
				this.mOPLDLOFBAJ_ = value;
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06006D73 RID: 28019 RVA: 0x00124921 File Offset: 0x00122B21
		// (set) Token: 0x06006D74 RID: 28020 RVA: 0x00124929 File Offset: 0x00122B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemValue
		{
			get
			{
				return this.itemValue_;
			}
			set
			{
				this.itemValue_ = value;
			}
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x00124932 File Offset: 0x00122B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KCLICGHKKPH);
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x00124940 File Offset: 0x00122B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KCLICGHKKPH other)
		{
			return other != null && (other == this || (this.FINJGCCOKDO == other.FINJGCCOKDO && this.JBBKLJJCLPH == other.JBBKLJJCLPH && this.KFOGCJPNCNB == other.KFOGCJPNCNB && this.COAMOBLAGLB == other.COAMOBLAGLB && this.MOPLDLOFBAJ == other.MOPLDLOFBAJ && this.ItemValue == other.ItemValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x001249CC File Offset: 0x00122BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FINJGCCOKDO != 0U)
			{
				num ^= this.FINJGCCOKDO.GetHashCode();
			}
			if (this.JBBKLJJCLPH != 0U)
			{
				num ^= this.JBBKLJJCLPH.GetHashCode();
			}
			if (this.KFOGCJPNCNB != 0U)
			{
				num ^= this.KFOGCJPNCNB.GetHashCode();
			}
			if (this.COAMOBLAGLB)
			{
				num ^= this.COAMOBLAGLB.GetHashCode();
			}
			if (this.MOPLDLOFBAJ)
			{
				num ^= this.MOPLDLOFBAJ.GetHashCode();
			}
			if (this.ItemValue != 0U)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x00124A88 File Offset: 0x00122C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x00124A90 File Offset: 0x00122C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x00124A9C File Offset: 0x00122C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MOPLDLOFBAJ)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.MOPLDLOFBAJ);
			}
			if (this.FINJGCCOKDO != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.FINJGCCOKDO);
			}
			if (this.ItemValue != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ItemValue);
			}
			if (this.KFOGCJPNCNB != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.KFOGCJPNCNB);
			}
			if (this.JBBKLJJCLPH != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.JBBKLJJCLPH);
			}
			if (this.COAMOBLAGLB)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.COAMOBLAGLB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x00124B64 File Offset: 0x00122D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FINJGCCOKDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FINJGCCOKDO);
			}
			if (this.JBBKLJJCLPH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JBBKLJJCLPH);
			}
			if (this.KFOGCJPNCNB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KFOGCJPNCNB);
			}
			if (this.COAMOBLAGLB)
			{
				num += 2;
			}
			if (this.MOPLDLOFBAJ)
			{
				num += 2;
			}
			if (this.ItemValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x00124C04 File Offset: 0x00122E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KCLICGHKKPH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FINJGCCOKDO != 0U)
			{
				this.FINJGCCOKDO = other.FINJGCCOKDO;
			}
			if (other.JBBKLJJCLPH != 0U)
			{
				this.JBBKLJJCLPH = other.JBBKLJJCLPH;
			}
			if (other.KFOGCJPNCNB != 0U)
			{
				this.KFOGCJPNCNB = other.KFOGCJPNCNB;
			}
			if (other.COAMOBLAGLB)
			{
				this.COAMOBLAGLB = other.COAMOBLAGLB;
			}
			if (other.MOPLDLOFBAJ)
			{
				this.MOPLDLOFBAJ = other.MOPLDLOFBAJ;
			}
			if (other.ItemValue != 0U)
			{
				this.ItemValue = other.ItemValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x00124CA4 File Offset: 0x00122EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x00124CB0 File Offset: 0x00122EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.MOPLDLOFBAJ = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.FINJGCCOKDO = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ItemValue = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.KFOGCJPNCNB = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.JBBKLJJCLPH = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.COAMOBLAGLB = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A0B RID: 10763
		private static readonly MessageParser<KCLICGHKKPH> _parser = new MessageParser<KCLICGHKKPH>(() => new KCLICGHKKPH());

		// Token: 0x04002A0C RID: 10764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A0D RID: 10765
		public const int FINJGCCOKDOFieldNumber = 3;

		// Token: 0x04002A0E RID: 10766
		private uint fINJGCCOKDO_;

		// Token: 0x04002A0F RID: 10767
		public const int JBBKLJJCLPHFieldNumber = 11;

		// Token: 0x04002A10 RID: 10768
		private uint jBBKLJJCLPH_;

		// Token: 0x04002A11 RID: 10769
		public const int KFOGCJPNCNBFieldNumber = 9;

		// Token: 0x04002A12 RID: 10770
		private uint kFOGCJPNCNB_;

		// Token: 0x04002A13 RID: 10771
		public const int COAMOBLAGLBFieldNumber = 15;

		// Token: 0x04002A14 RID: 10772
		private bool cOAMOBLAGLB_;

		// Token: 0x04002A15 RID: 10773
		public const int MOPLDLOFBAJFieldNumber = 1;

		// Token: 0x04002A16 RID: 10774
		private bool mOPLDLOFBAJ_;

		// Token: 0x04002A17 RID: 10775
		public const int ItemValueFieldNumber = 8;

		// Token: 0x04002A18 RID: 10776
		private uint itemValue_;
	}
}

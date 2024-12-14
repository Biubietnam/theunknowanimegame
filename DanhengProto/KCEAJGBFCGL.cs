using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200098B RID: 2443
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KCEAJGBFCGL : IMessage<KCEAJGBFCGL>, IMessage, IEquatable<KCEAJGBFCGL>, IDeepCloneable<KCEAJGBFCGL>, IBufferMessage
	{
		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06006D4C RID: 27980 RVA: 0x001244BC File Offset: 0x001226BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KCEAJGBFCGL> Parser
		{
			get
			{
				return KCEAJGBFCGL._parser;
			}
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06006D4D RID: 27981 RVA: 0x001244C3 File Offset: 0x001226C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KCEAJGBFCGLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x001244D5 File Offset: 0x001226D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KCEAJGBFCGL.Descriptor;
			}
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x001244DC File Offset: 0x001226DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KCEAJGBFCGL()
		{
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x001244E4 File Offset: 0x001226E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KCEAJGBFCGL(KCEAJGBFCGL other) : this()
		{
			this.cCFBOIGONMH_ = other.cCFBOIGONMH_;
			this.formulaId_ = other.formulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x00124515 File Offset: 0x00122715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KCEAJGBFCGL Clone()
		{
			return new KCEAJGBFCGL(this);
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06006D52 RID: 27986 RVA: 0x0012451D File Offset: 0x0012271D
		// (set) Token: 0x06006D53 RID: 27987 RVA: 0x00124525 File Offset: 0x00122725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CCFBOIGONMH
		{
			get
			{
				return this.cCFBOIGONMH_;
			}
			set
			{
				this.cCFBOIGONMH_ = value;
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06006D54 RID: 27988 RVA: 0x0012452E File Offset: 0x0012272E
		// (set) Token: 0x06006D55 RID: 27989 RVA: 0x00124536 File Offset: 0x00122736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FormulaId
		{
			get
			{
				return this.formulaId_;
			}
			set
			{
				this.formulaId_ = value;
			}
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x0012453F File Offset: 0x0012273F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KCEAJGBFCGL);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x0012454D File Offset: 0x0012274D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KCEAJGBFCGL other)
		{
			return other != null && (other == this || (this.CCFBOIGONMH == other.CCFBOIGONMH && this.FormulaId == other.FormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x0012458C File Offset: 0x0012278C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CCFBOIGONMH != 0U)
			{
				num ^= this.CCFBOIGONMH.GetHashCode();
			}
			if (this.FormulaId != 0U)
			{
				num ^= this.FormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x001245E4 File Offset: 0x001227E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x001245EC File Offset: 0x001227EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x001245F8 File Offset: 0x001227F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CCFBOIGONMH != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CCFBOIGONMH);
			}
			if (this.FormulaId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x00124654 File Offset: 0x00122854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CCFBOIGONMH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CCFBOIGONMH);
			}
			if (this.FormulaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x001246AC File Offset: 0x001228AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KCEAJGBFCGL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CCFBOIGONMH != 0U)
			{
				this.CCFBOIGONMH = other.CCFBOIGONMH;
			}
			if (other.FormulaId != 0U)
			{
				this.FormulaId = other.FormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x001246FC File Offset: 0x001228FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x00124708 File Offset: 0x00122908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FormulaId = input.ReadUInt32();
					}
				}
				else
				{
					this.CCFBOIGONMH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002A04 RID: 10756
		private static readonly MessageParser<KCEAJGBFCGL> _parser = new MessageParser<KCEAJGBFCGL>(() => new KCEAJGBFCGL());

		// Token: 0x04002A05 RID: 10757
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A06 RID: 10758
		public const int CCFBOIGONMHFieldNumber = 2;

		// Token: 0x04002A07 RID: 10759
		private uint cCFBOIGONMH_;

		// Token: 0x04002A08 RID: 10760
		public const int FormulaIdFieldNumber = 10;

		// Token: 0x04002A09 RID: 10761
		private uint formulaId_;
	}
}

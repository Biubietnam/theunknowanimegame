using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000967 RID: 2407
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JHHKEBFANLL : IMessage<JHHKEBFANLL>, IMessage, IEquatable<JHHKEBFANLL>, IDeepCloneable<JHHKEBFANLL>, IBufferMessage
	{
		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06006B7C RID: 27516 RVA: 0x0011E8F8 File Offset: 0x0011CAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JHHKEBFANLL> Parser
		{
			get
			{
				return JHHKEBFANLL._parser;
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06006B7D RID: 27517 RVA: 0x0011E8FF File Offset: 0x0011CAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JHHKEBFANLLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06006B7E RID: 27518 RVA: 0x0011E911 File Offset: 0x0011CB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JHHKEBFANLL.Descriptor;
			}
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x0011E918 File Offset: 0x0011CB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHHKEBFANLL()
		{
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x0011E920 File Offset: 0x0011CB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHHKEBFANLL(JHHKEBFANLL other) : this()
		{
			this.dPOMILCEDFC_ = other.dPOMILCEDFC_;
			this.cOJGEGHIADI_ = other.cOJGEGHIADI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x0011E951 File Offset: 0x0011CB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHHKEBFANLL Clone()
		{
			return new JHHKEBFANLL(this);
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x0011E959 File Offset: 0x0011CB59
		// (set) Token: 0x06006B83 RID: 27523 RVA: 0x0011E961 File Offset: 0x0011CB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DPOMILCEDFC
		{
			get
			{
				return this.dPOMILCEDFC_;
			}
			set
			{
				this.dPOMILCEDFC_ = value;
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06006B84 RID: 27524 RVA: 0x0011E96A File Offset: 0x0011CB6A
		// (set) Token: 0x06006B85 RID: 27525 RVA: 0x0011E972 File Offset: 0x0011CB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COJGEGHIADI
		{
			get
			{
				return this.cOJGEGHIADI_;
			}
			set
			{
				this.cOJGEGHIADI_ = value;
			}
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x0011E97B File Offset: 0x0011CB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JHHKEBFANLL);
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x0011E989 File Offset: 0x0011CB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JHHKEBFANLL other)
		{
			return other != null && (other == this || (this.DPOMILCEDFC == other.DPOMILCEDFC && this.COJGEGHIADI == other.COJGEGHIADI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x0011E9C8 File Offset: 0x0011CBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DPOMILCEDFC)
			{
				num ^= this.DPOMILCEDFC.GetHashCode();
			}
			if (this.COJGEGHIADI != 0U)
			{
				num ^= this.COJGEGHIADI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x0011EA20 File Offset: 0x0011CC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x0011EA28 File Offset: 0x0011CC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x0011EA34 File Offset: 0x0011CC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DPOMILCEDFC)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.DPOMILCEDFC);
			}
			if (this.COJGEGHIADI != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x0011EA90 File Offset: 0x0011CC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DPOMILCEDFC)
			{
				num += 2;
			}
			if (this.COJGEGHIADI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x0011EADC File Offset: 0x0011CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JHHKEBFANLL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DPOMILCEDFC)
			{
				this.DPOMILCEDFC = other.DPOMILCEDFC;
			}
			if (other.COJGEGHIADI != 0U)
			{
				this.COJGEGHIADI = other.COJGEGHIADI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x0011EB2C File Offset: 0x0011CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x0011EB38 File Offset: 0x0011CD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.COJGEGHIADI = input.ReadUInt32();
					}
				}
				else
				{
					this.DPOMILCEDFC = input.ReadBool();
				}
			}
		}

		// Token: 0x04002924 RID: 10532
		private static readonly MessageParser<JHHKEBFANLL> _parser = new MessageParser<JHHKEBFANLL>(() => new JHHKEBFANLL());

		// Token: 0x04002925 RID: 10533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002926 RID: 10534
		public const int DPOMILCEDFCFieldNumber = 5;

		// Token: 0x04002927 RID: 10535
		private bool dPOMILCEDFC_;

		// Token: 0x04002928 RID: 10536
		public const int COJGEGHIADIFieldNumber = 6;

		// Token: 0x04002929 RID: 10537
		private uint cOJGEGHIADI_;
	}
}

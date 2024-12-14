using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009CD RID: 2509
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KNOAKLPPLOM : IMessage<KNOAKLPPLOM>, IMessage, IEquatable<KNOAKLPPLOM>, IDeepCloneable<KNOAKLPPLOM>, IBufferMessage
	{
		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06006FE6 RID: 28646 RVA: 0x0012AAC8 File Offset: 0x00128CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KNOAKLPPLOM> Parser
		{
			get
			{
				return KNOAKLPPLOM._parser;
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06006FE7 RID: 28647 RVA: 0x0012AACF File Offset: 0x00128CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KNOAKLPPLOMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06006FE8 RID: 28648 RVA: 0x0012AAE1 File Offset: 0x00128CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KNOAKLPPLOM.Descriptor;
			}
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x0012AAE8 File Offset: 0x00128CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNOAKLPPLOM()
		{
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x0012AAF0 File Offset: 0x00128CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNOAKLPPLOM(KNOAKLPPLOM other) : this()
		{
			this.id_ = other.id_;
			this.bMFFEOGBCOL_ = other.bMFFEOGBCOL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x0012AB21 File Offset: 0x00128D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNOAKLPPLOM Clone()
		{
			return new KNOAKLPPLOM(this);
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06006FEC RID: 28652 RVA: 0x0012AB29 File Offset: 0x00128D29
		// (set) Token: 0x06006FED RID: 28653 RVA: 0x0012AB31 File Offset: 0x00128D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06006FEE RID: 28654 RVA: 0x0012AB3A File Offset: 0x00128D3A
		// (set) Token: 0x06006FEF RID: 28655 RVA: 0x0012AB42 File Offset: 0x00128D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BMFFEOGBCOL
		{
			get
			{
				return this.bMFFEOGBCOL_;
			}
			set
			{
				this.bMFFEOGBCOL_ = value;
			}
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x0012AB4B File Offset: 0x00128D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KNOAKLPPLOM);
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x0012AB59 File Offset: 0x00128D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KNOAKLPPLOM other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BMFFEOGBCOL == other.BMFFEOGBCOL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x0012AB98 File Offset: 0x00128D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BMFFEOGBCOL != 0U)
			{
				num ^= this.BMFFEOGBCOL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x0012ABF0 File Offset: 0x00128DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x0012ABF8 File Offset: 0x00128DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x0012AC04 File Offset: 0x00128E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BMFFEOGBCOL != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BMFFEOGBCOL);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x0012AC60 File Offset: 0x00128E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.BMFFEOGBCOL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BMFFEOGBCOL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x0012ACB8 File Offset: 0x00128EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KNOAKLPPLOM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.BMFFEOGBCOL != 0U)
			{
				this.BMFFEOGBCOL = other.BMFFEOGBCOL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x0012AD08 File Offset: 0x00128F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x0012AD14 File Offset: 0x00128F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.BMFFEOGBCOL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B0C RID: 11020
		private static readonly MessageParser<KNOAKLPPLOM> _parser = new MessageParser<KNOAKLPPLOM>(() => new KNOAKLPPLOM());

		// Token: 0x04002B0D RID: 11021
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B0E RID: 11022
		public const int IdFieldNumber = 14;

		// Token: 0x04002B0F RID: 11023
		private uint id_;

		// Token: 0x04002B10 RID: 11024
		public const int BMFFEOGBCOLFieldNumber = 2;

		// Token: 0x04002B11 RID: 11025
		private uint bMFFEOGBCOL_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009CF RID: 2511
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KOGBDHNMMDF : IMessage<KOGBDHNMMDF>, IMessage, IEquatable<KOGBDHNMMDF>, IDeepCloneable<KOGBDHNMMDF>, IBufferMessage
	{
		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06006FFD RID: 28669 RVA: 0x0012ADF4 File Offset: 0x00128FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KOGBDHNMMDF> Parser
		{
			get
			{
				return KOGBDHNMMDF._parser;
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06006FFE RID: 28670 RVA: 0x0012ADFB File Offset: 0x00128FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KOGBDHNMMDFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06006FFF RID: 28671 RVA: 0x0012AE0D File Offset: 0x0012900D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KOGBDHNMMDF.Descriptor;
			}
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x0012AE14 File Offset: 0x00129014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KOGBDHNMMDF()
		{
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x0012AE1C File Offset: 0x0012901C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KOGBDHNMMDF(KOGBDHNMMDF other) : this()
		{
			this.iEHICFJODDD_ = other.iEHICFJODDD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x0012AE41 File Offset: 0x00129041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KOGBDHNMMDF Clone()
		{
			return new KOGBDHNMMDF(this);
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06007003 RID: 28675 RVA: 0x0012AE49 File Offset: 0x00129049
		// (set) Token: 0x06007004 RID: 28676 RVA: 0x0012AE51 File Offset: 0x00129051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IEHICFJODDD
		{
			get
			{
				return this.iEHICFJODDD_;
			}
			set
			{
				this.iEHICFJODDD_ = value;
			}
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x0012AE5A File Offset: 0x0012905A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KOGBDHNMMDF);
		}

		// Token: 0x06007006 RID: 28678 RVA: 0x0012AE68 File Offset: 0x00129068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KOGBDHNMMDF other)
		{
			return other != null && (other == this || (this.IEHICFJODDD == other.IEHICFJODDD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007007 RID: 28679 RVA: 0x0012AE98 File Offset: 0x00129098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IEHICFJODDD != 0U)
			{
				num ^= this.IEHICFJODDD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007008 RID: 28680 RVA: 0x0012AED7 File Offset: 0x001290D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x0012AEDF File Offset: 0x001290DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x0012AEE8 File Offset: 0x001290E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IEHICFJODDD != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.IEHICFJODDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x0012AF1C File Offset: 0x0012911C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IEHICFJODDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IEHICFJODDD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x0012AF5A File Offset: 0x0012915A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KOGBDHNMMDF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IEHICFJODDD != 0U)
			{
				this.IEHICFJODDD = other.IEHICFJODDD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x0012AF8B File Offset: 0x0012918B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x0012AF94 File Offset: 0x00129194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IEHICFJODDD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B13 RID: 11027
		private static readonly MessageParser<KOGBDHNMMDF> _parser = new MessageParser<KOGBDHNMMDF>(() => new KOGBDHNMMDF());

		// Token: 0x04002B14 RID: 11028
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B15 RID: 11029
		public const int IEHICFJODDDFieldNumber = 1;

		// Token: 0x04002B16 RID: 11030
		private uint iEHICFJODDD_;
	}
}

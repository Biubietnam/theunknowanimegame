using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C05 RID: 3077
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NCIHLLAEJJK : IMessage<NCIHLLAEJJK>, IMessage, IEquatable<NCIHLLAEJJK>, IDeepCloneable<NCIHLLAEJJK>, IBufferMessage
	{
		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x06008835 RID: 34869 RVA: 0x00167990 File Offset: 0x00165B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NCIHLLAEJJK> Parser
		{
			get
			{
				return NCIHLLAEJJK._parser;
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x06008836 RID: 34870 RVA: 0x00167997 File Offset: 0x00165B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NCIHLLAEJJKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x06008837 RID: 34871 RVA: 0x001679A9 File Offset: 0x00165BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NCIHLLAEJJK.Descriptor;
			}
		}

		// Token: 0x06008838 RID: 34872 RVA: 0x001679B0 File Offset: 0x00165BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCIHLLAEJJK()
		{
		}

		// Token: 0x06008839 RID: 34873 RVA: 0x001679C3 File Offset: 0x00165BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCIHLLAEJJK(NCIHLLAEJJK other) : this()
		{
			this.dEPLEJMPJAI_ = other.dEPLEJMPJAI_.Clone();
			this.jKGNKPJOKAF_ = other.jKGNKPJOKAF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x001679F9 File Offset: 0x00165BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCIHLLAEJJK Clone()
		{
			return new NCIHLLAEJJK(this);
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x0600883B RID: 34875 RVA: 0x00167A01 File Offset: 0x00165C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DEPLEJMPJAI
		{
			get
			{
				return this.dEPLEJMPJAI_;
			}
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x0600883C RID: 34876 RVA: 0x00167A09 File Offset: 0x00165C09
		// (set) Token: 0x0600883D RID: 34877 RVA: 0x00167A11 File Offset: 0x00165C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JKGNKPJOKAF
		{
			get
			{
				return this.jKGNKPJOKAF_;
			}
			set
			{
				this.jKGNKPJOKAF_ = value;
			}
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x00167A1A File Offset: 0x00165C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NCIHLLAEJJK);
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x00167A28 File Offset: 0x00165C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NCIHLLAEJJK other)
		{
			return other != null && (other == this || (this.dEPLEJMPJAI_.Equals(other.dEPLEJMPJAI_) && this.JKGNKPJOKAF == other.JKGNKPJOKAF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x00167A78 File Offset: 0x00165C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dEPLEJMPJAI_.GetHashCode();
			if (this.JKGNKPJOKAF != 0U)
			{
				num ^= this.JKGNKPJOKAF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x00167AC5 File Offset: 0x00165CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x00167ACD File Offset: 0x00165CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x00167AD8 File Offset: 0x00165CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dEPLEJMPJAI_.WriteTo(ref output, NCIHLLAEJJK._repeated_dEPLEJMPJAI_codec);
			if (this.JKGNKPJOKAF != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.JKGNKPJOKAF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x00167B28 File Offset: 0x00165D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dEPLEJMPJAI_.CalculateSize(NCIHLLAEJJK._repeated_dEPLEJMPJAI_codec);
			if (this.JKGNKPJOKAF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKGNKPJOKAF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008845 RID: 34885 RVA: 0x00167B7C File Offset: 0x00165D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NCIHLLAEJJK other)
		{
			if (other == null)
			{
				return;
			}
			this.dEPLEJMPJAI_.Add(other.dEPLEJMPJAI_);
			if (other.JKGNKPJOKAF != 0U)
			{
				this.JKGNKPJOKAF = other.JKGNKPJOKAF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x00167BC9 File Offset: 0x00165DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x00167BD4 File Offset: 0x00165DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U && num != 74U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.JKGNKPJOKAF = input.ReadUInt32();
					}
				}
				else
				{
					this.dEPLEJMPJAI_.AddEntriesFrom(ref input, NCIHLLAEJJK._repeated_dEPLEJMPJAI_codec);
				}
			}
		}

		// Token: 0x04003439 RID: 13369
		private static readonly MessageParser<NCIHLLAEJJK> _parser = new MessageParser<NCIHLLAEJJK>(() => new NCIHLLAEJJK());

		// Token: 0x0400343A RID: 13370
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400343B RID: 13371
		public const int DEPLEJMPJAIFieldNumber = 9;

		// Token: 0x0400343C RID: 13372
		private static readonly FieldCodec<uint> _repeated_dEPLEJMPJAI_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x0400343D RID: 13373
		private readonly RepeatedField<uint> dEPLEJMPJAI_ = new RepeatedField<uint>();

		// Token: 0x0400343E RID: 13374
		public const int JKGNKPJOKAFFieldNumber = 13;

		// Token: 0x0400343F RID: 13375
		private uint jKGNKPJOKAF_;
	}
}

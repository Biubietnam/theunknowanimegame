using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C8D RID: 3213
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PFJOGHHDEAH : IMessage<PFJOGHHDEAH>, IMessage, IEquatable<PFJOGHHDEAH>, IDeepCloneable<PFJOGHHDEAH>, IBufferMessage
	{
		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x06008ED8 RID: 36568 RVA: 0x001798C9 File Offset: 0x00177AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PFJOGHHDEAH> Parser
		{
			get
			{
				return PFJOGHHDEAH._parser;
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x06008ED9 RID: 36569 RVA: 0x001798D0 File Offset: 0x00177AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PFJOGHHDEAHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x06008EDA RID: 36570 RVA: 0x001798E2 File Offset: 0x00177AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PFJOGHHDEAH.Descriptor;
			}
		}

		// Token: 0x06008EDB RID: 36571 RVA: 0x001798E9 File Offset: 0x00177AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PFJOGHHDEAH()
		{
		}

		// Token: 0x06008EDC RID: 36572 RVA: 0x001798F4 File Offset: 0x00177AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PFJOGHHDEAH(PFJOGHHDEAH other) : this()
		{
			this.pLFPJDMGBBN_ = other.pLFPJDMGBBN_;
			this.hDLINLMKPDG_ = other.hDLINLMKPDG_;
			this.iBFFLFONFDD_ = other.iBFFLFONFDD_;
			this.eFACEOIFCLN_ = other.eFACEOIFCLN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EDD RID: 36573 RVA: 0x00179948 File Offset: 0x00177B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PFJOGHHDEAH Clone()
		{
			return new PFJOGHHDEAH(this);
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x06008EDE RID: 36574 RVA: 0x00179950 File Offset: 0x00177B50
		// (set) Token: 0x06008EDF RID: 36575 RVA: 0x00179958 File Offset: 0x00177B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PLFPJDMGBBN
		{
			get
			{
				return this.pLFPJDMGBBN_;
			}
			set
			{
				this.pLFPJDMGBBN_ = value;
			}
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x06008EE0 RID: 36576 RVA: 0x00179961 File Offset: 0x00177B61
		// (set) Token: 0x06008EE1 RID: 36577 RVA: 0x00179969 File Offset: 0x00177B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HDLINLMKPDG
		{
			get
			{
				return this.hDLINLMKPDG_;
			}
			set
			{
				this.hDLINLMKPDG_ = value;
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x06008EE2 RID: 36578 RVA: 0x00179972 File Offset: 0x00177B72
		// (set) Token: 0x06008EE3 RID: 36579 RVA: 0x0017997A File Offset: 0x00177B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IBFFLFONFDD
		{
			get
			{
				return this.iBFFLFONFDD_;
			}
			set
			{
				this.iBFFLFONFDD_ = value;
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x06008EE4 RID: 36580 RVA: 0x00179983 File Offset: 0x00177B83
		// (set) Token: 0x06008EE5 RID: 36581 RVA: 0x0017998B File Offset: 0x00177B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EFACEOIFCLN
		{
			get
			{
				return this.eFACEOIFCLN_;
			}
			set
			{
				this.eFACEOIFCLN_ = value;
			}
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x00179994 File Offset: 0x00177B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PFJOGHHDEAH);
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x001799A4 File Offset: 0x00177BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PFJOGHHDEAH other)
		{
			return other != null && (other == this || (this.PLFPJDMGBBN == other.PLFPJDMGBBN && this.HDLINLMKPDG == other.HDLINLMKPDG && this.IBFFLFONFDD == other.IBFFLFONFDD && this.EFACEOIFCLN == other.EFACEOIFCLN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EE8 RID: 36584 RVA: 0x00179A10 File Offset: 0x00177C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PLFPJDMGBBN)
			{
				num ^= this.PLFPJDMGBBN.GetHashCode();
			}
			if (this.HDLINLMKPDG != 0U)
			{
				num ^= this.HDLINLMKPDG.GetHashCode();
			}
			if (this.IBFFLFONFDD != 0U)
			{
				num ^= this.IBFFLFONFDD.GetHashCode();
			}
			if (this.EFACEOIFCLN != 0U)
			{
				num ^= this.EFACEOIFCLN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x00179A9A File Offset: 0x00177C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x00179AA2 File Offset: 0x00177CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x00179AAC File Offset: 0x00177CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HDLINLMKPDG != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HDLINLMKPDG);
			}
			if (this.PLFPJDMGBBN)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.PLFPJDMGBBN);
			}
			if (this.EFACEOIFCLN != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EFACEOIFCLN);
			}
			if (this.IBFFLFONFDD != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.IBFFLFONFDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x00179B40 File Offset: 0x00177D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PLFPJDMGBBN)
			{
				num += 2;
			}
			if (this.HDLINLMKPDG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HDLINLMKPDG);
			}
			if (this.IBFFLFONFDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IBFFLFONFDD);
			}
			if (this.EFACEOIFCLN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EFACEOIFCLN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x00179BBC File Offset: 0x00177DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PFJOGHHDEAH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PLFPJDMGBBN)
			{
				this.PLFPJDMGBBN = other.PLFPJDMGBBN;
			}
			if (other.HDLINLMKPDG != 0U)
			{
				this.HDLINLMKPDG = other.HDLINLMKPDG;
			}
			if (other.IBFFLFONFDD != 0U)
			{
				this.IBFFLFONFDD = other.IBFFLFONFDD;
			}
			if (other.EFACEOIFCLN != 0U)
			{
				this.EFACEOIFCLN = other.EFACEOIFCLN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x00179C34 File Offset: 0x00177E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x00179C40 File Offset: 0x00177E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.HDLINLMKPDG = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.PLFPJDMGBBN = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.EFACEOIFCLN = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IBFFLFONFDD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040036DE RID: 14046
		private static readonly MessageParser<PFJOGHHDEAH> _parser = new MessageParser<PFJOGHHDEAH>(() => new PFJOGHHDEAH());

		// Token: 0x040036DF RID: 14047
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036E0 RID: 14048
		public const int PLFPJDMGBBNFieldNumber = 8;

		// Token: 0x040036E1 RID: 14049
		private bool pLFPJDMGBBN_;

		// Token: 0x040036E2 RID: 14050
		public const int HDLINLMKPDGFieldNumber = 5;

		// Token: 0x040036E3 RID: 14051
		private uint hDLINLMKPDG_;

		// Token: 0x040036E4 RID: 14052
		public const int IBFFLFONFDDFieldNumber = 14;

		// Token: 0x040036E5 RID: 14053
		private uint iBFFLFONFDD_;

		// Token: 0x040036E6 RID: 14054
		public const int EFACEOIFCLNFieldNumber = 12;

		// Token: 0x040036E7 RID: 14055
		private uint eFACEOIFCLN_;
	}
}

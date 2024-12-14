using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200090D RID: 2317
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IBFALCFDLDG : IMessage<IBFALCFDLDG>, IMessage, IEquatable<IBFALCFDLDG>, IDeepCloneable<IBFALCFDLDG>, IBufferMessage
	{
		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x06006771 RID: 26481 RVA: 0x00114A0D File Offset: 0x00112C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IBFALCFDLDG> Parser
		{
			get
			{
				return IBFALCFDLDG._parser;
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06006772 RID: 26482 RVA: 0x00114A14 File Offset: 0x00112C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IBFALCFDLDGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06006773 RID: 26483 RVA: 0x00114A26 File Offset: 0x00112C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IBFALCFDLDG.Descriptor;
			}
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x00114A2D File Offset: 0x00112C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IBFALCFDLDG()
		{
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x00114A35 File Offset: 0x00112C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IBFALCFDLDG(IBFALCFDLDG other) : this()
		{
			this.jBPMLMCCNDO_ = other.jBPMLMCCNDO_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x00114A66 File Offset: 0x00112C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IBFALCFDLDG Clone()
		{
			return new IBFALCFDLDG(this);
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06006777 RID: 26487 RVA: 0x00114A6E File Offset: 0x00112C6E
		// (set) Token: 0x06006778 RID: 26488 RVA: 0x00114A76 File Offset: 0x00112C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JBPMLMCCNDO
		{
			get
			{
				return this.jBPMLMCCNDO_;
			}
			set
			{
				this.jBPMLMCCNDO_ = value;
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06006779 RID: 26489 RVA: 0x00114A7F File Offset: 0x00112C7F
		// (set) Token: 0x0600677A RID: 26490 RVA: 0x00114A87 File Offset: 0x00112C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueExhibitionStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x00114A90 File Offset: 0x00112C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IBFALCFDLDG);
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x00114A9E File Offset: 0x00112C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IBFALCFDLDG other)
		{
			return other != null && (other == this || (this.JBPMLMCCNDO == other.JBPMLMCCNDO && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x00114ADC File Offset: 0x00112CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JBPMLMCCNDO != 0U)
			{
				num ^= this.JBPMLMCCNDO.GetHashCode();
			}
			if (this.Status != RogueExhibitionStatus.RogueExhibitionNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00114B3A File Offset: 0x00112D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00114B42 File Offset: 0x00112D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x00114B4C File Offset: 0x00112D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JBPMLMCCNDO != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.JBPMLMCCNDO);
			}
			if (this.Status != RogueExhibitionStatus.RogueExhibitionNone)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x00114BA4 File Offset: 0x00112DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JBPMLMCCNDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JBPMLMCCNDO);
			}
			if (this.Status != RogueExhibitionStatus.RogueExhibitionNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x00114BFC File Offset: 0x00112DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IBFALCFDLDG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JBPMLMCCNDO != 0U)
			{
				this.JBPMLMCCNDO = other.JBPMLMCCNDO;
			}
			if (other.Status != RogueExhibitionStatus.RogueExhibitionNone)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x00114C4C File Offset: 0x00112E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x00114C58 File Offset: 0x00112E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = (RogueExhibitionStatus)input.ReadEnum();
					}
				}
				else
				{
					this.JBPMLMCCNDO = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040027C0 RID: 10176
		private static readonly MessageParser<IBFALCFDLDG> _parser = new MessageParser<IBFALCFDLDG>(() => new IBFALCFDLDG());

		// Token: 0x040027C1 RID: 10177
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027C2 RID: 10178
		public const int JBPMLMCCNDOFieldNumber = 1;

		// Token: 0x040027C3 RID: 10179
		private uint jBPMLMCCNDO_;

		// Token: 0x040027C4 RID: 10180
		public const int StatusFieldNumber = 13;

		// Token: 0x040027C5 RID: 10181
		private RogueExhibitionStatus status_;
	}
}

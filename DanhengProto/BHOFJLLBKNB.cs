using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000123 RID: 291
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BHOFJLLBKNB : IMessage<BHOFJLLBKNB>, IMessage, IEquatable<BHOFJLLBKNB>, IDeepCloneable<BHOFJLLBKNB>, IBufferMessage
	{
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00027615 File Offset: 0x00025815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BHOFJLLBKNB> Parser
		{
			get
			{
				return BHOFJLLBKNB._parser;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0002761C File Offset: 0x0002581C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BHOFJLLBKNBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0002762E File Offset: 0x0002582E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BHOFJLLBKNB.Descriptor;
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00027635 File Offset: 0x00025835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHOFJLLBKNB()
		{
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0002763D File Offset: 0x0002583D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHOFJLLBKNB(BHOFJLLBKNB other) : this()
		{
			this.status_ = other.status_;
			this.iPOGPDABCIF_ = other.iPOGPDABCIF_;
			this.jBPMLMCCNDO_ = other.jBPMLMCCNDO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0002767A File Offset: 0x0002587A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHOFJLLBKNB Clone()
		{
			return new BHOFJLLBKNB(this);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x00027682 File Offset: 0x00025882
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x0002768A File Offset: 0x0002588A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBoothStatus Status
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

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x00027693 File Offset: 0x00025893
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x0002769B File Offset: 0x0002589B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IPOGPDABCIF
		{
			get
			{
				return this.iPOGPDABCIF_;
			}
			set
			{
				this.iPOGPDABCIF_ = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000276A4 File Offset: 0x000258A4
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x000276AC File Offset: 0x000258AC
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

		// Token: 0x06000D27 RID: 3367 RVA: 0x000276B5 File Offset: 0x000258B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BHOFJLLBKNB);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x000276C4 File Offset: 0x000258C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BHOFJLLBKNB other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.IPOGPDABCIF == other.IPOGPDABCIF && this.JBPMLMCCNDO == other.JBPMLMCCNDO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00027720 File Offset: 0x00025920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != RogueBoothStatus.RogueBoothNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.IPOGPDABCIF != 0U)
			{
				num ^= this.IPOGPDABCIF.GetHashCode();
			}
			if (this.JBPMLMCCNDO != 0U)
			{
				num ^= this.JBPMLMCCNDO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00027797 File Offset: 0x00025997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0002779F File Offset: 0x0002599F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000277A8 File Offset: 0x000259A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != RogueBoothStatus.RogueBoothNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Status);
			}
			if (this.IPOGPDABCIF != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.IPOGPDABCIF);
			}
			if (this.JBPMLMCCNDO != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.JBPMLMCCNDO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00027820 File Offset: 0x00025A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != RogueBoothStatus.RogueBoothNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.IPOGPDABCIF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IPOGPDABCIF);
			}
			if (this.JBPMLMCCNDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JBPMLMCCNDO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00027890 File Offset: 0x00025A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BHOFJLLBKNB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != RogueBoothStatus.RogueBoothNone)
			{
				this.Status = other.Status;
			}
			if (other.IPOGPDABCIF != 0U)
			{
				this.IPOGPDABCIF = other.IPOGPDABCIF;
			}
			if (other.JBPMLMCCNDO != 0U)
			{
				this.JBPMLMCCNDO = other.JBPMLMCCNDO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000278F4 File Offset: 0x00025AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00027900 File Offset: 0x00025B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.JBPMLMCCNDO = input.ReadUInt32();
						}
					}
					else
					{
						this.IPOGPDABCIF = input.ReadUInt32();
					}
				}
				else
				{
					this.Status = (RogueBoothStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x040005B2 RID: 1458
		private static readonly MessageParser<BHOFJLLBKNB> _parser = new MessageParser<BHOFJLLBKNB>(() => new BHOFJLLBKNB());

		// Token: 0x040005B3 RID: 1459
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005B4 RID: 1460
		public const int StatusFieldNumber = 5;

		// Token: 0x040005B5 RID: 1461
		private RogueBoothStatus status_;

		// Token: 0x040005B6 RID: 1462
		public const int IPOGPDABCIFFieldNumber = 8;

		// Token: 0x040005B7 RID: 1463
		private uint iPOGPDABCIF_;

		// Token: 0x040005B8 RID: 1464
		public const int JBPMLMCCNDOFieldNumber = 10;

		// Token: 0x040005B9 RID: 1465
		private uint jBPMLMCCNDO_;
	}
}

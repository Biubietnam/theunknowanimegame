using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BC5 RID: 3013
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumRandomEventSelectCsReq : IMessage<MuseumRandomEventSelectCsReq>, IMessage, IEquatable<MuseumRandomEventSelectCsReq>, IDeepCloneable<MuseumRandomEventSelectCsReq>, IBufferMessage
	{
		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x06008561 RID: 34145 RVA: 0x001603B5 File Offset: 0x0015E5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumRandomEventSelectCsReq> Parser
		{
			get
			{
				return MuseumRandomEventSelectCsReq._parser;
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x06008562 RID: 34146 RVA: 0x001603BC File Offset: 0x0015E5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumRandomEventSelectCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x001603CE File Offset: 0x0015E5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumRandomEventSelectCsReq.Descriptor;
			}
		}

		// Token: 0x06008564 RID: 34148 RVA: 0x001603D5 File Offset: 0x0015E5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventSelectCsReq()
		{
		}

		// Token: 0x06008565 RID: 34149 RVA: 0x001603DD File Offset: 0x0015E5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventSelectCsReq(MuseumRandomEventSelectCsReq other) : this()
		{
			this.eventId_ = other.eventId_;
			this.aPOELPDBOHG_ = other.aPOELPDBOHG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x0016040E File Offset: 0x0015E60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventSelectCsReq Clone()
		{
			return new MuseumRandomEventSelectCsReq(this);
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x06008567 RID: 34151 RVA: 0x00160416 File Offset: 0x0015E616
		// (set) Token: 0x06008568 RID: 34152 RVA: 0x0016041E File Offset: 0x0015E61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x06008569 RID: 34153 RVA: 0x00160427 File Offset: 0x0015E627
		// (set) Token: 0x0600856A RID: 34154 RVA: 0x0016042F File Offset: 0x0015E62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint APOELPDBOHG
		{
			get
			{
				return this.aPOELPDBOHG_;
			}
			set
			{
				this.aPOELPDBOHG_ = value;
			}
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x00160438 File Offset: 0x0015E638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumRandomEventSelectCsReq);
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x00160446 File Offset: 0x0015E646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumRandomEventSelectCsReq other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && this.APOELPDBOHG == other.APOELPDBOHG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x00160484 File Offset: 0x0015E684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.APOELPDBOHG != 0U)
			{
				num ^= this.APOELPDBOHG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600856E RID: 34158 RVA: 0x001604DC File Offset: 0x0015E6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x001604E4 File Offset: 0x0015E6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x001604F0 File Offset: 0x0015E6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.EventId);
			}
			if (this.APOELPDBOHG != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.APOELPDBOHG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x0016054C File Offset: 0x0015E74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.APOELPDBOHG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.APOELPDBOHG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008572 RID: 34162 RVA: 0x001605A4 File Offset: 0x0015E7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumRandomEventSelectCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.APOELPDBOHG != 0U)
			{
				this.APOELPDBOHG = other.APOELPDBOHG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008573 RID: 34163 RVA: 0x001605F4 File Offset: 0x0015E7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008574 RID: 34164 RVA: 0x00160600 File Offset: 0x0015E800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.APOELPDBOHG = input.ReadUInt32();
					}
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400331A RID: 13082
		private static readonly MessageParser<MuseumRandomEventSelectCsReq> _parser = new MessageParser<MuseumRandomEventSelectCsReq>(() => new MuseumRandomEventSelectCsReq());

		// Token: 0x0400331B RID: 13083
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400331C RID: 13084
		public const int EventIdFieldNumber = 7;

		// Token: 0x0400331D RID: 13085
		private uint eventId_;

		// Token: 0x0400331E RID: 13086
		public const int APOELPDBOHGFieldNumber = 13;

		// Token: 0x0400331F RID: 13087
		private uint aPOELPDBOHG_;
	}
}

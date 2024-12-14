using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B1F RID: 2847
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyConfirmRandomCsReq : IMessage<MonopolyConfirmRandomCsReq>, IMessage, IEquatable<MonopolyConfirmRandomCsReq>, IDeepCloneable<MonopolyConfirmRandomCsReq>, IBufferMessage
	{
		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x06007E02 RID: 32258 RVA: 0x0014D3EC File Offset: 0x0014B5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyConfirmRandomCsReq> Parser
		{
			get
			{
				return MonopolyConfirmRandomCsReq._parser;
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x06007E03 RID: 32259 RVA: 0x0014D3F3 File Offset: 0x0014B5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyConfirmRandomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x06007E04 RID: 32260 RVA: 0x0014D405 File Offset: 0x0014B605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyConfirmRandomCsReq.Descriptor;
			}
		}

		// Token: 0x06007E05 RID: 32261 RVA: 0x0014D40C File Offset: 0x0014B60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConfirmRandomCsReq()
		{
		}

		// Token: 0x06007E06 RID: 32262 RVA: 0x0014D414 File Offset: 0x0014B614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConfirmRandomCsReq(MonopolyConfirmRandomCsReq other) : this()
		{
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E07 RID: 32263 RVA: 0x0014D439 File Offset: 0x0014B639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConfirmRandomCsReq Clone()
		{
			return new MonopolyConfirmRandomCsReq(this);
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x06007E08 RID: 32264 RVA: 0x0014D441 File Offset: 0x0014B641
		// (set) Token: 0x06007E09 RID: 32265 RVA: 0x0014D449 File Offset: 0x0014B649
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

		// Token: 0x06007E0A RID: 32266 RVA: 0x0014D452 File Offset: 0x0014B652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyConfirmRandomCsReq);
		}

		// Token: 0x06007E0B RID: 32267 RVA: 0x0014D460 File Offset: 0x0014B660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyConfirmRandomCsReq other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x0014D490 File Offset: 0x0014B690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x0014D4CF File Offset: 0x0014B6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x0014D4D7 File Offset: 0x0014B6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x0014D4E0 File Offset: 0x0014B6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x0014D514 File Offset: 0x0014B714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x0014D552 File Offset: 0x0014B752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyConfirmRandomCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x0014D583 File Offset: 0x0014B783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x0014D58C File Offset: 0x0014B78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003059 RID: 12377
		private static readonly MessageParser<MonopolyConfirmRandomCsReq> _parser = new MessageParser<MonopolyConfirmRandomCsReq>(() => new MonopolyConfirmRandomCsReq());

		// Token: 0x0400305A RID: 12378
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400305B RID: 12379
		public const int EventIdFieldNumber = 13;

		// Token: 0x0400305C RID: 12380
		private uint eventId_;
	}
}

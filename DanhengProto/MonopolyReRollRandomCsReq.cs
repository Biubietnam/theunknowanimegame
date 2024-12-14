using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B67 RID: 2919
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyReRollRandomCsReq : IMessage<MonopolyReRollRandomCsReq>, IMessage, IEquatable<MonopolyReRollRandomCsReq>, IDeepCloneable<MonopolyReRollRandomCsReq>, IBufferMessage
	{
		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x0600812B RID: 33067 RVA: 0x00154834 File Offset: 0x00152A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyReRollRandomCsReq> Parser
		{
			get
			{
				return MonopolyReRollRandomCsReq._parser;
			}
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600812C RID: 33068 RVA: 0x0015483B File Offset: 0x00152A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyReRollRandomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x0600812D RID: 33069 RVA: 0x0015484D File Offset: 0x00152A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyReRollRandomCsReq.Descriptor;
			}
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x00154854 File Offset: 0x00152A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyReRollRandomCsReq()
		{
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x0015485C File Offset: 0x00152A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyReRollRandomCsReq(MonopolyReRollRandomCsReq other) : this()
		{
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x00154881 File Offset: 0x00152A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyReRollRandomCsReq Clone()
		{
			return new MonopolyReRollRandomCsReq(this);
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x06008131 RID: 33073 RVA: 0x00154889 File Offset: 0x00152A89
		// (set) Token: 0x06008132 RID: 33074 RVA: 0x00154891 File Offset: 0x00152A91
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

		// Token: 0x06008133 RID: 33075 RVA: 0x0015489A File Offset: 0x00152A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyReRollRandomCsReq);
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x001548A8 File Offset: 0x00152AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyReRollRandomCsReq other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x001548D8 File Offset: 0x00152AD8
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

		// Token: 0x06008136 RID: 33078 RVA: 0x00154917 File Offset: 0x00152B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008137 RID: 33079 RVA: 0x0015491F File Offset: 0x00152B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x00154928 File Offset: 0x00152B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x0015495C File Offset: 0x00152B5C
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

		// Token: 0x0600813A RID: 33082 RVA: 0x0015499A File Offset: 0x00152B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyReRollRandomCsReq other)
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

		// Token: 0x0600813B RID: 33083 RVA: 0x001549CB File Offset: 0x00152BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x001549D4 File Offset: 0x00152BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003154 RID: 12628
		private static readonly MessageParser<MonopolyReRollRandomCsReq> _parser = new MessageParser<MonopolyReRollRandomCsReq>(() => new MonopolyReRollRandomCsReq());

		// Token: 0x04003155 RID: 12629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003156 RID: 12630
		public const int EventIdFieldNumber = 2;

		// Token: 0x04003157 RID: 12631
		private uint eventId_;
	}
}

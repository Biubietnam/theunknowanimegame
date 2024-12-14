using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B6F RID: 2927
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyRollRandomCsReq : IMessage<MonopolyRollRandomCsReq>, IMessage, IEquatable<MonopolyRollRandomCsReq>, IDeepCloneable<MonopolyRollRandomCsReq>, IBufferMessage
	{
		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x06008183 RID: 33155 RVA: 0x001553E4 File Offset: 0x001535E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyRollRandomCsReq> Parser
		{
			get
			{
				return MonopolyRollRandomCsReq._parser;
			}
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x06008184 RID: 33156 RVA: 0x001553EB File Offset: 0x001535EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyRollRandomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x06008185 RID: 33157 RVA: 0x001553FD File Offset: 0x001535FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyRollRandomCsReq.Descriptor;
			}
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x00155404 File Offset: 0x00153604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollRandomCsReq()
		{
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x0015540C File Offset: 0x0015360C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollRandomCsReq(MonopolyRollRandomCsReq other) : this()
		{
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x00155431 File Offset: 0x00153631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollRandomCsReq Clone()
		{
			return new MonopolyRollRandomCsReq(this);
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x06008189 RID: 33161 RVA: 0x00155439 File Offset: 0x00153639
		// (set) Token: 0x0600818A RID: 33162 RVA: 0x00155441 File Offset: 0x00153641
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

		// Token: 0x0600818B RID: 33163 RVA: 0x0015544A File Offset: 0x0015364A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyRollRandomCsReq);
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x00155458 File Offset: 0x00153658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyRollRandomCsReq other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x00155488 File Offset: 0x00153688
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

		// Token: 0x0600818E RID: 33166 RVA: 0x001554C7 File Offset: 0x001536C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x001554CF File Offset: 0x001536CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x001554D8 File Offset: 0x001536D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x0015550C File Offset: 0x0015370C
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

		// Token: 0x06008192 RID: 33170 RVA: 0x0015554A File Offset: 0x0015374A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyRollRandomCsReq other)
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

		// Token: 0x06008193 RID: 33171 RVA: 0x0015557B File Offset: 0x0015377B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x00155584 File Offset: 0x00153784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400316C RID: 12652
		private static readonly MessageParser<MonopolyRollRandomCsReq> _parser = new MessageParser<MonopolyRollRandomCsReq>(() => new MonopolyRollRandomCsReq());

		// Token: 0x0400316D RID: 12653
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400316E RID: 12654
		public const int EventIdFieldNumber = 7;

		// Token: 0x0400316F RID: 12655
		private uint eventId_;
	}
}

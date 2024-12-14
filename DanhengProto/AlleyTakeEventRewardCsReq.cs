using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000099 RID: 153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyTakeEventRewardCsReq : IMessage<AlleyTakeEventRewardCsReq>, IMessage, IEquatable<AlleyTakeEventRewardCsReq>, IDeepCloneable<AlleyTakeEventRewardCsReq>, IBufferMessage
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00012854 File Offset: 0x00010A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyTakeEventRewardCsReq> Parser
		{
			get
			{
				return AlleyTakeEventRewardCsReq._parser;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001285B File Offset: 0x00010A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyTakeEventRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001286D File Offset: 0x00010A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyTakeEventRewardCsReq.Descriptor;
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00012874 File Offset: 0x00010A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyTakeEventRewardCsReq()
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001287C File Offset: 0x00010A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyTakeEventRewardCsReq(AlleyTakeEventRewardCsReq other) : this()
		{
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000128A1 File Offset: 0x00010AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyTakeEventRewardCsReq Clone()
		{
			return new AlleyTakeEventRewardCsReq(this);
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x000128A9 File Offset: 0x00010AA9
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x000128B1 File Offset: 0x00010AB1
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

		// Token: 0x06000686 RID: 1670 RVA: 0x000128BA File Offset: 0x00010ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyTakeEventRewardCsReq);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000128C8 File Offset: 0x00010AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyTakeEventRewardCsReq other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000128F8 File Offset: 0x00010AF8
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

		// Token: 0x06000689 RID: 1673 RVA: 0x00012937 File Offset: 0x00010B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001293F File Offset: 0x00010B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00012948 File Offset: 0x00010B48
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

		// Token: 0x0600068C RID: 1676 RVA: 0x0001297C File Offset: 0x00010B7C
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

		// Token: 0x0600068D RID: 1677 RVA: 0x000129BA File Offset: 0x00010BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyTakeEventRewardCsReq other)
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

		// Token: 0x0600068E RID: 1678 RVA: 0x000129EB File Offset: 0x00010BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000129F4 File Offset: 0x00010BF4
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

		// Token: 0x0400026B RID: 619
		private static readonly MessageParser<AlleyTakeEventRewardCsReq> _parser = new MessageParser<AlleyTakeEventRewardCsReq>(() => new AlleyTakeEventRewardCsReq());

		// Token: 0x0400026C RID: 620
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400026D RID: 621
		public const int EventIdFieldNumber = 2;

		// Token: 0x0400026E RID: 622
		private uint eventId_;
	}
}

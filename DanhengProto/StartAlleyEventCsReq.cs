using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001199 RID: 4505
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartAlleyEventCsReq : IMessage<StartAlleyEventCsReq>, IMessage, IEquatable<StartAlleyEventCsReq>, IDeepCloneable<StartAlleyEventCsReq>, IBufferMessage
	{
		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600C91A RID: 51482 RVA: 0x0021B7E8 File Offset: 0x002199E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartAlleyEventCsReq> Parser
		{
			get
			{
				return StartAlleyEventCsReq._parser;
			}
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600C91B RID: 51483 RVA: 0x0021B7EF File Offset: 0x002199EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartAlleyEventCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600C91C RID: 51484 RVA: 0x0021B801 File Offset: 0x00219A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartAlleyEventCsReq.Descriptor;
			}
		}

		// Token: 0x0600C91D RID: 51485 RVA: 0x0021B808 File Offset: 0x00219A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAlleyEventCsReq()
		{
		}

		// Token: 0x0600C91E RID: 51486 RVA: 0x0021B810 File Offset: 0x00219A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAlleyEventCsReq(StartAlleyEventCsReq other) : this()
		{
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C91F RID: 51487 RVA: 0x0021B835 File Offset: 0x00219A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAlleyEventCsReq Clone()
		{
			return new StartAlleyEventCsReq(this);
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600C920 RID: 51488 RVA: 0x0021B83D File Offset: 0x00219A3D
		// (set) Token: 0x0600C921 RID: 51489 RVA: 0x0021B845 File Offset: 0x00219A45
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

		// Token: 0x0600C922 RID: 51490 RVA: 0x0021B84E File Offset: 0x00219A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartAlleyEventCsReq);
		}

		// Token: 0x0600C923 RID: 51491 RVA: 0x0021B85C File Offset: 0x00219A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartAlleyEventCsReq other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C924 RID: 51492 RVA: 0x0021B88C File Offset: 0x00219A8C
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

		// Token: 0x0600C925 RID: 51493 RVA: 0x0021B8CB File Offset: 0x00219ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C926 RID: 51494 RVA: 0x0021B8D3 File Offset: 0x00219AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C927 RID: 51495 RVA: 0x0021B8DC File Offset: 0x00219ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C928 RID: 51496 RVA: 0x0021B910 File Offset: 0x00219B10
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

		// Token: 0x0600C929 RID: 51497 RVA: 0x0021B94E File Offset: 0x00219B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartAlleyEventCsReq other)
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

		// Token: 0x0600C92A RID: 51498 RVA: 0x0021B97F File Offset: 0x00219B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C92B RID: 51499 RVA: 0x0021B988 File Offset: 0x00219B88
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
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005126 RID: 20774
		private static readonly MessageParser<StartAlleyEventCsReq> _parser = new MessageParser<StartAlleyEventCsReq>(() => new StartAlleyEventCsReq());

		// Token: 0x04005127 RID: 20775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005128 RID: 20776
		public const int EventIdFieldNumber = 1;

		// Token: 0x04005129 RID: 20777
		private uint eventId_;
	}
}

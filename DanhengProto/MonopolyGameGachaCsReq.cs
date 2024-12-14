using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B33 RID: 2867
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGameGachaCsReq : IMessage<MonopolyGameGachaCsReq>, IMessage, IEquatable<MonopolyGameGachaCsReq>, IDeepCloneable<MonopolyGameGachaCsReq>, IBufferMessage
	{
		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x06007EE9 RID: 32489 RVA: 0x0014F7CB File Offset: 0x0014D9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGameGachaCsReq> Parser
		{
			get
			{
				return MonopolyGameGachaCsReq._parser;
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x06007EEA RID: 32490 RVA: 0x0014F7D2 File Offset: 0x0014D9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGameGachaCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x06007EEB RID: 32491 RVA: 0x0014F7E4 File Offset: 0x0014D9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGameGachaCsReq.Descriptor;
			}
		}

		// Token: 0x06007EEC RID: 32492 RVA: 0x0014F7EB File Offset: 0x0014D9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameGachaCsReq()
		{
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x0014F7F3 File Offset: 0x0014D9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameGachaCsReq(MonopolyGameGachaCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x0014F80C File Offset: 0x0014DA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameGachaCsReq Clone()
		{
			return new MonopolyGameGachaCsReq(this);
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x0014F814 File Offset: 0x0014DA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGameGachaCsReq);
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x0014F822 File Offset: 0x0014DA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGameGachaCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x0014F840 File Offset: 0x0014DA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x0014F866 File Offset: 0x0014DA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007EF3 RID: 32499 RVA: 0x0014F86E File Offset: 0x0014DA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EF4 RID: 32500 RVA: 0x0014F877 File Offset: 0x0014DA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007EF5 RID: 32501 RVA: 0x0014F890 File Offset: 0x0014DA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EF6 RID: 32502 RVA: 0x0014F8B6 File Offset: 0x0014DAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGameGachaCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x0014F8D3 File Offset: 0x0014DAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x0014F8DC File Offset: 0x0014DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040030A6 RID: 12454
		private static readonly MessageParser<MonopolyGameGachaCsReq> _parser = new MessageParser<MonopolyGameGachaCsReq>(() => new MonopolyGameGachaCsReq());

		// Token: 0x040030A7 RID: 12455
		private UnknownFieldSet _unknownFields;
	}
}

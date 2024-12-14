using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B6B RID: 2923
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyRollDiceCsReq : IMessage<MonopolyRollDiceCsReq>, IMessage, IEquatable<MonopolyRollDiceCsReq>, IDeepCloneable<MonopolyRollDiceCsReq>, IBufferMessage
	{
		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x06008159 RID: 33113 RVA: 0x00154EF3 File Offset: 0x001530F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyRollDiceCsReq> Parser
		{
			get
			{
				return MonopolyRollDiceCsReq._parser;
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x0600815A RID: 33114 RVA: 0x00154EFA File Offset: 0x001530FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyRollDiceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x0600815B RID: 33115 RVA: 0x00154F0C File Offset: 0x0015310C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyRollDiceCsReq.Descriptor;
			}
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x00154F13 File Offset: 0x00153113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollDiceCsReq()
		{
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x00154F1B File Offset: 0x0015311B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollDiceCsReq(MonopolyRollDiceCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x00154F34 File Offset: 0x00153134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollDiceCsReq Clone()
		{
			return new MonopolyRollDiceCsReq(this);
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x00154F3C File Offset: 0x0015313C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyRollDiceCsReq);
		}

		// Token: 0x06008160 RID: 33120 RVA: 0x00154F4A File Offset: 0x0015314A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyRollDiceCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x00154F68 File Offset: 0x00153168
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

		// Token: 0x06008162 RID: 33122 RVA: 0x00154F8E File Offset: 0x0015318E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x00154F96 File Offset: 0x00153196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008164 RID: 33124 RVA: 0x00154F9F File Offset: 0x0015319F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x00154FB8 File Offset: 0x001531B8
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

		// Token: 0x06008166 RID: 33126 RVA: 0x00154FDE File Offset: 0x001531DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyRollDiceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x00154FFB File Offset: 0x001531FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x00155004 File Offset: 0x00153204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003162 RID: 12642
		private static readonly MessageParser<MonopolyRollDiceCsReq> _parser = new MessageParser<MonopolyRollDiceCsReq>(() => new MonopolyRollDiceCsReq());

		// Token: 0x04003163 RID: 12643
		private UnknownFieldSet _unknownFields;
	}
}

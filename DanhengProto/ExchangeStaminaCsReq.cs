using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004E3 RID: 1251
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeStaminaCsReq : IMessage<ExchangeStaminaCsReq>, IMessage, IEquatable<ExchangeStaminaCsReq>, IDeepCloneable<ExchangeStaminaCsReq>, IBufferMessage
	{
		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x0009944F File Offset: 0x0009764F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeStaminaCsReq> Parser
		{
			get
			{
				return ExchangeStaminaCsReq._parser;
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x00099456 File Offset: 0x00097656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeStaminaCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x00099468 File Offset: 0x00097668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeStaminaCsReq.Descriptor;
			}
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x0009946F File Offset: 0x0009766F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeStaminaCsReq()
		{
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00099477 File Offset: 0x00097677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeStaminaCsReq(ExchangeStaminaCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00099490 File Offset: 0x00097690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeStaminaCsReq Clone()
		{
			return new ExchangeStaminaCsReq(this);
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00099498 File Offset: 0x00097698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeStaminaCsReq);
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x000994A6 File Offset: 0x000976A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeStaminaCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x000994C4 File Offset: 0x000976C4
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

		// Token: 0x060037F9 RID: 14329 RVA: 0x000994EA File Offset: 0x000976EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x000994F2 File Offset: 0x000976F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x000994FB File Offset: 0x000976FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00099514 File Offset: 0x00097714
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

		// Token: 0x060037FD RID: 14333 RVA: 0x0009953A File Offset: 0x0009773A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeStaminaCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00099557 File Offset: 0x00097757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00099560 File Offset: 0x00097760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400161F RID: 5663
		private static readonly MessageParser<ExchangeStaminaCsReq> _parser = new MessageParser<ExchangeStaminaCsReq>(() => new ExchangeStaminaCsReq());

		// Token: 0x04001620 RID: 5664
		private UnknownFieldSet _unknownFields;
	}
}

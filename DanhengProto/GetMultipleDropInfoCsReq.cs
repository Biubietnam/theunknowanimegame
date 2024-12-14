using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000741 RID: 1857
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMultipleDropInfoCsReq : IMessage<GetMultipleDropInfoCsReq>, IMessage, IEquatable<GetMultipleDropInfoCsReq>, IDeepCloneable<GetMultipleDropInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x060052FE RID: 21246 RVA: 0x000DF7DF File Offset: 0x000DD9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMultipleDropInfoCsReq> Parser
		{
			get
			{
				return GetMultipleDropInfoCsReq._parser;
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x060052FF RID: 21247 RVA: 0x000DF7E6 File Offset: 0x000DD9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMultipleDropInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06005300 RID: 21248 RVA: 0x000DF7F8 File Offset: 0x000DD9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMultipleDropInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x000DF7FF File Offset: 0x000DD9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultipleDropInfoCsReq()
		{
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x000DF807 File Offset: 0x000DDA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultipleDropInfoCsReq(GetMultipleDropInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x000DF820 File Offset: 0x000DDA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultipleDropInfoCsReq Clone()
		{
			return new GetMultipleDropInfoCsReq(this);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x000DF828 File Offset: 0x000DDA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMultipleDropInfoCsReq);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x000DF836 File Offset: 0x000DDA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMultipleDropInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x000DF854 File Offset: 0x000DDA54
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

		// Token: 0x06005307 RID: 21255 RVA: 0x000DF87A File Offset: 0x000DDA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x000DF882 File Offset: 0x000DDA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x000DF88B File Offset: 0x000DDA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x000DF8A4 File Offset: 0x000DDAA4
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

		// Token: 0x0600530B RID: 21259 RVA: 0x000DF8CA File Offset: 0x000DDACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMultipleDropInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x000DF8E7 File Offset: 0x000DDAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x000DF8F0 File Offset: 0x000DDAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400209C RID: 8348
		private static readonly MessageParser<GetMultipleDropInfoCsReq> _parser = new MessageParser<GetMultipleDropInfoCsReq>(() => new GetMultipleDropInfoCsReq());

		// Token: 0x0400209D RID: 8349
		private UnknownFieldSet _unknownFields;
	}
}

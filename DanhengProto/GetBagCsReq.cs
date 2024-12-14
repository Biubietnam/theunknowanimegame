using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200062B RID: 1579
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetBagCsReq : IMessage<GetBagCsReq>, IMessage, IEquatable<GetBagCsReq>, IDeepCloneable<GetBagCsReq>, IBufferMessage
	{
		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x000C1CAA File Offset: 0x000BFEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetBagCsReq> Parser
		{
			get
			{
				return GetBagCsReq._parser;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x000C1CB1 File Offset: 0x000BFEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetBagCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x000C1CC3 File Offset: 0x000BFEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBagCsReq.Descriptor;
			}
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x000C1CCA File Offset: 0x000BFECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBagCsReq()
		{
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x000C1CD2 File Offset: 0x000BFED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBagCsReq(GetBagCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x000C1CEB File Offset: 0x000BFEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBagCsReq Clone()
		{
			return new GetBagCsReq(this);
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x000C1CF3 File Offset: 0x000BFEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBagCsReq);
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x000C1D01 File Offset: 0x000BFF01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetBagCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x000C1D20 File Offset: 0x000BFF20
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

		// Token: 0x060046DA RID: 18138 RVA: 0x000C1D46 File Offset: 0x000BFF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x000C1D4E File Offset: 0x000BFF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x000C1D57 File Offset: 0x000BFF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x000C1D70 File Offset: 0x000BFF70
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

		// Token: 0x060046DE RID: 18142 RVA: 0x000C1D96 File Offset: 0x000BFF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetBagCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x000C1DB3 File Offset: 0x000BFFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x000C1DBC File Offset: 0x000BFFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C4A RID: 7242
		private static readonly MessageParser<GetBagCsReq> _parser = new MessageParser<GetBagCsReq>(() => new GetBagCsReq());

		// Token: 0x04001C4B RID: 7243
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200077D RID: 1917
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPunkLordDataCsReq : IMessage<GetPunkLordDataCsReq>, IMessage, IEquatable<GetPunkLordDataCsReq>, IDeepCloneable<GetPunkLordDataCsReq>, IBufferMessage
	{
		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x060055A4 RID: 21924 RVA: 0x000E609B File Offset: 0x000E429B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPunkLordDataCsReq> Parser
		{
			get
			{
				return GetPunkLordDataCsReq._parser;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x060055A5 RID: 21925 RVA: 0x000E60A2 File Offset: 0x000E42A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPunkLordDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x060055A6 RID: 21926 RVA: 0x000E60B4 File Offset: 0x000E42B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPunkLordDataCsReq.Descriptor;
			}
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x000E60BB File Offset: 0x000E42BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordDataCsReq()
		{
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x000E60C3 File Offset: 0x000E42C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordDataCsReq(GetPunkLordDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x000E60DC File Offset: 0x000E42DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordDataCsReq Clone()
		{
			return new GetPunkLordDataCsReq(this);
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x000E60E4 File Offset: 0x000E42E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPunkLordDataCsReq);
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x000E60F2 File Offset: 0x000E42F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPunkLordDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x000E6110 File Offset: 0x000E4310
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

		// Token: 0x060055AD RID: 21933 RVA: 0x000E6136 File Offset: 0x000E4336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x000E613E File Offset: 0x000E433E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x000E6147 File Offset: 0x000E4347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x000E6160 File Offset: 0x000E4360
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

		// Token: 0x060055B1 RID: 21937 RVA: 0x000E6186 File Offset: 0x000E4386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPunkLordDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x000E61A3 File Offset: 0x000E43A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x000E61AC File Offset: 0x000E43AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002192 RID: 8594
		private static readonly MessageParser<GetPunkLordDataCsReq> _parser = new MessageParser<GetPunkLordDataCsReq>(() => new GetPunkLordDataCsReq());

		// Token: 0x04002193 RID: 8595
		private UnknownFieldSet _unknownFields;
	}
}

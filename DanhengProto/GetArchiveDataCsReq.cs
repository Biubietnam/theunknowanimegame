using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000617 RID: 1559
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetArchiveDataCsReq : IMessage<GetArchiveDataCsReq>, IMessage, IEquatable<GetArchiveDataCsReq>, IDeepCloneable<GetArchiveDataCsReq>, IBufferMessage
	{
		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x000BF7EA File Offset: 0x000BD9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetArchiveDataCsReq> Parser
		{
			get
			{
				return GetArchiveDataCsReq._parser;
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x000BF7F1 File Offset: 0x000BD9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetArchiveDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x000BF803 File Offset: 0x000BDA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetArchiveDataCsReq.Descriptor;
			}
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x000BF80A File Offset: 0x000BDA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetArchiveDataCsReq()
		{
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x000BF812 File Offset: 0x000BDA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetArchiveDataCsReq(GetArchiveDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x000BF82B File Offset: 0x000BDA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetArchiveDataCsReq Clone()
		{
			return new GetArchiveDataCsReq(this);
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x000BF833 File Offset: 0x000BDA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetArchiveDataCsReq);
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x000BF841 File Offset: 0x000BDA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetArchiveDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x000BF860 File Offset: 0x000BDA60
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

		// Token: 0x060045EF RID: 17903 RVA: 0x000BF886 File Offset: 0x000BDA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x000BF88E File Offset: 0x000BDA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x000BF897 File Offset: 0x000BDA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x000BF8B0 File Offset: 0x000BDAB0
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

		// Token: 0x060045F3 RID: 17907 RVA: 0x000BF8D6 File Offset: 0x000BDAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetArchiveDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x000BF8F3 File Offset: 0x000BDAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x000BF8FC File Offset: 0x000BDAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BF5 RID: 7157
		private static readonly MessageParser<GetArchiveDataCsReq> _parser = new MessageParser<GetArchiveDataCsReq>(() => new GetArchiveDataCsReq());

		// Token: 0x04001BF6 RID: 7158
		private UnknownFieldSet _unknownFields;
	}
}

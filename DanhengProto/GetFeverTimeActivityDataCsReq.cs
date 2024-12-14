using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200069D RID: 1693
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFeverTimeActivityDataCsReq : IMessage<GetFeverTimeActivityDataCsReq>, IMessage, IEquatable<GetFeverTimeActivityDataCsReq>, IDeepCloneable<GetFeverTimeActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x000CDE4B File Offset: 0x000CC04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFeverTimeActivityDataCsReq> Parser
		{
			get
			{
				return GetFeverTimeActivityDataCsReq._parser;
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06004BCF RID: 19407 RVA: 0x000CDE52 File Offset: 0x000CC052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFeverTimeActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06004BD0 RID: 19408 RVA: 0x000CDE64 File Offset: 0x000CC064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFeverTimeActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x000CDE6B File Offset: 0x000CC06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFeverTimeActivityDataCsReq()
		{
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x000CDE73 File Offset: 0x000CC073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFeverTimeActivityDataCsReq(GetFeverTimeActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x000CDE8C File Offset: 0x000CC08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFeverTimeActivityDataCsReq Clone()
		{
			return new GetFeverTimeActivityDataCsReq(this);
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x000CDE94 File Offset: 0x000CC094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFeverTimeActivityDataCsReq);
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x000CDEA2 File Offset: 0x000CC0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFeverTimeActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x000CDEC0 File Offset: 0x000CC0C0
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

		// Token: 0x06004BD7 RID: 19415 RVA: 0x000CDEE6 File Offset: 0x000CC0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x000CDEEE File Offset: 0x000CC0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x000CDEF7 File Offset: 0x000CC0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x000CDF10 File Offset: 0x000CC110
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

		// Token: 0x06004BDB RID: 19419 RVA: 0x000CDF36 File Offset: 0x000CC136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFeverTimeActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x000CDF53 File Offset: 0x000CC153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x000CDF5C File Offset: 0x000CC15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E08 RID: 7688
		private static readonly MessageParser<GetFeverTimeActivityDataCsReq> _parser = new MessageParser<GetFeverTimeActivityDataCsReq>(() => new GetFeverTimeActivityDataCsReq());

		// Token: 0x04001E09 RID: 7689
		private UnknownFieldSet _unknownFields;
	}
}

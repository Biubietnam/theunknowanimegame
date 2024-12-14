using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200071D RID: 1821
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMissionDataCsReq : IMessage<GetMissionDataCsReq>, IMessage, IEquatable<GetMissionDataCsReq>, IDeepCloneable<GetMissionDataCsReq>, IBufferMessage
	{
		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x000DB286 File Offset: 0x000D9486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMissionDataCsReq> Parser
		{
			get
			{
				return GetMissionDataCsReq._parser;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06005163 RID: 20835 RVA: 0x000DB28D File Offset: 0x000D948D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMissionDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x000DB29F File Offset: 0x000D949F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMissionDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x000DB2A6 File Offset: 0x000D94A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionDataCsReq()
		{
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x000DB2AE File Offset: 0x000D94AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionDataCsReq(GetMissionDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x000DB2C7 File Offset: 0x000D94C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionDataCsReq Clone()
		{
			return new GetMissionDataCsReq(this);
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x000DB2CF File Offset: 0x000D94CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMissionDataCsReq);
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x000DB2DD File Offset: 0x000D94DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMissionDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x000DB2FC File Offset: 0x000D94FC
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

		// Token: 0x0600516B RID: 20843 RVA: 0x000DB322 File Offset: 0x000D9522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x000DB32A File Offset: 0x000D952A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x000DB333 File Offset: 0x000D9533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x000DB34C File Offset: 0x000D954C
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

		// Token: 0x0600516F RID: 20847 RVA: 0x000DB372 File Offset: 0x000D9572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMissionDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x000DB38F File Offset: 0x000D958F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x000DB398 File Offset: 0x000D9598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FFC RID: 8188
		private static readonly MessageParser<GetMissionDataCsReq> _parser = new MessageParser<GetMissionDataCsReq>(() => new GetMissionDataCsReq());

		// Token: 0x04001FFD RID: 8189
		private UnknownFieldSet _unknownFields;
	}
}

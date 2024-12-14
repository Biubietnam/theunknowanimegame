using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200070D RID: 1805
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMapRotationDataCsReq : IMessage<GetMapRotationDataCsReq>, IMessage, IEquatable<GetMapRotationDataCsReq>, IDeepCloneable<GetMapRotationDataCsReq>, IBufferMessage
	{
		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x060050A8 RID: 20648 RVA: 0x000D952F File Offset: 0x000D772F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMapRotationDataCsReq> Parser
		{
			get
			{
				return GetMapRotationDataCsReq._parser;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x000D9536 File Offset: 0x000D7736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMapRotationDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x060050AA RID: 20650 RVA: 0x000D9548 File Offset: 0x000D7748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMapRotationDataCsReq.Descriptor;
			}
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x000D954F File Offset: 0x000D774F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMapRotationDataCsReq()
		{
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x000D9557 File Offset: 0x000D7757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMapRotationDataCsReq(GetMapRotationDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x000D9570 File Offset: 0x000D7770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMapRotationDataCsReq Clone()
		{
			return new GetMapRotationDataCsReq(this);
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x000D9578 File Offset: 0x000D7778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMapRotationDataCsReq);
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x000D9586 File Offset: 0x000D7786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMapRotationDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x000D95A4 File Offset: 0x000D77A4
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

		// Token: 0x060050B1 RID: 20657 RVA: 0x000D95CA File Offset: 0x000D77CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x000D95D2 File Offset: 0x000D77D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x000D95DB File Offset: 0x000D77DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x000D95F4 File Offset: 0x000D77F4
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

		// Token: 0x060050B5 RID: 20661 RVA: 0x000D961A File Offset: 0x000D781A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMapRotationDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x000D9637 File Offset: 0x000D7837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x000D9640 File Offset: 0x000D7840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FB6 RID: 8118
		private static readonly MessageParser<GetMapRotationDataCsReq> _parser = new MessageParser<GetMapRotationDataCsReq>(() => new GetMapRotationDataCsReq());

		// Token: 0x04001FB7 RID: 8119
		private UnknownFieldSet _unknownFields;
	}
}

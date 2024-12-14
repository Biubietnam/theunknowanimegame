using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007BD RID: 1981
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueHandbookDataCsReq : IMessage<GetRogueHandbookDataCsReq>, IMessage, IEquatable<GetRogueHandbookDataCsReq>, IDeepCloneable<GetRogueHandbookDataCsReq>, IBufferMessage
	{
		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06005863 RID: 22627 RVA: 0x000EC50F File Offset: 0x000EA70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueHandbookDataCsReq> Parser
		{
			get
			{
				return GetRogueHandbookDataCsReq._parser;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06005864 RID: 22628 RVA: 0x000EC516 File Offset: 0x000EA716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueHandbookDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06005865 RID: 22629 RVA: 0x000EC528 File Offset: 0x000EA728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueHandbookDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x000EC52F File Offset: 0x000EA72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueHandbookDataCsReq()
		{
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x000EC537 File Offset: 0x000EA737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueHandbookDataCsReq(GetRogueHandbookDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005868 RID: 22632 RVA: 0x000EC550 File Offset: 0x000EA750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueHandbookDataCsReq Clone()
		{
			return new GetRogueHandbookDataCsReq(this);
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x000EC558 File Offset: 0x000EA758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueHandbookDataCsReq);
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x000EC566 File Offset: 0x000EA766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueHandbookDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x000EC584 File Offset: 0x000EA784
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

		// Token: 0x0600586C RID: 22636 RVA: 0x000EC5AA File Offset: 0x000EA7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x000EC5B2 File Offset: 0x000EA7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x000EC5BB File Offset: 0x000EA7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x000EC5D4 File Offset: 0x000EA7D4
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

		// Token: 0x06005870 RID: 22640 RVA: 0x000EC5FA File Offset: 0x000EA7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueHandbookDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x000EC617 File Offset: 0x000EA817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x000EC620 File Offset: 0x000EA820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002277 RID: 8823
		private static readonly MessageParser<GetRogueHandbookDataCsReq> _parser = new MessageParser<GetRogueHandbookDataCsReq>(() => new GetRogueHandbookDataCsReq());

		// Token: 0x04002278 RID: 8824
		private UnknownFieldSet _unknownFields;
	}
}

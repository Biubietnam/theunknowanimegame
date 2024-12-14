using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000819 RID: 2073
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSummonActivityDataCsReq : IMessage<GetSummonActivityDataCsReq>, IMessage, IEquatable<GetSummonActivityDataCsReq>, IDeepCloneable<GetSummonActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x000F55D7 File Offset: 0x000F37D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSummonActivityDataCsReq> Parser
		{
			get
			{
				return GetSummonActivityDataCsReq._parser;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06005C52 RID: 23634 RVA: 0x000F55DE File Offset: 0x000F37DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSummonActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x000F55F0 File Offset: 0x000F37F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSummonActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x000F55F7 File Offset: 0x000F37F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSummonActivityDataCsReq()
		{
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x000F55FF File Offset: 0x000F37FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSummonActivityDataCsReq(GetSummonActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x000F5618 File Offset: 0x000F3818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSummonActivityDataCsReq Clone()
		{
			return new GetSummonActivityDataCsReq(this);
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x000F5620 File Offset: 0x000F3820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSummonActivityDataCsReq);
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x000F562E File Offset: 0x000F382E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSummonActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005C59 RID: 23641 RVA: 0x000F564C File Offset: 0x000F384C
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

		// Token: 0x06005C5A RID: 23642 RVA: 0x000F5672 File Offset: 0x000F3872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x000F567A File Offset: 0x000F387A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x000F5683 File Offset: 0x000F3883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x000F569C File Offset: 0x000F389C
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

		// Token: 0x06005C5E RID: 23646 RVA: 0x000F56C2 File Offset: 0x000F38C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSummonActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x000F56DF File Offset: 0x000F38DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x000F56E8 File Offset: 0x000F38E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023B6 RID: 9142
		private static readonly MessageParser<GetSummonActivityDataCsReq> _parser = new MessageParser<GetSummonActivityDataCsReq>(() => new GetSummonActivityDataCsReq());

		// Token: 0x040023B7 RID: 9143
		private UnknownFieldSet _unknownFields;
	}
}

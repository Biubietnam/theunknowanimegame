using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007B9 RID: 1977
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueExhibitionCsReq : IMessage<GetRogueExhibitionCsReq>, IMessage, IEquatable<GetRogueExhibitionCsReq>, IDeepCloneable<GetRogueExhibitionCsReq>, IBufferMessage
	{
		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06005839 RID: 22585 RVA: 0x000EBF33 File Offset: 0x000EA133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueExhibitionCsReq> Parser
		{
			get
			{
				return GetRogueExhibitionCsReq._parser;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x0600583A RID: 22586 RVA: 0x000EBF3A File Offset: 0x000EA13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueExhibitionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x0600583B RID: 22587 RVA: 0x000EBF4C File Offset: 0x000EA14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueExhibitionCsReq.Descriptor;
			}
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x000EBF53 File Offset: 0x000EA153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueExhibitionCsReq()
		{
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x000EBF5B File Offset: 0x000EA15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueExhibitionCsReq(GetRogueExhibitionCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x000EBF74 File Offset: 0x000EA174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueExhibitionCsReq Clone()
		{
			return new GetRogueExhibitionCsReq(this);
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x000EBF7C File Offset: 0x000EA17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueExhibitionCsReq);
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x000EBF8A File Offset: 0x000EA18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueExhibitionCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x000EBFA8 File Offset: 0x000EA1A8
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

		// Token: 0x06005842 RID: 22594 RVA: 0x000EBFCE File Offset: 0x000EA1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x000EBFD6 File Offset: 0x000EA1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x000EBFDF File Offset: 0x000EA1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x000EBFF8 File Offset: 0x000EA1F8
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

		// Token: 0x06005846 RID: 22598 RVA: 0x000EC01E File Offset: 0x000EA21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueExhibitionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x000EC03B File Offset: 0x000EA23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x000EC044 File Offset: 0x000EA244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002269 RID: 8809
		private static readonly MessageParser<GetRogueExhibitionCsReq> _parser = new MessageParser<GetRogueExhibitionCsReq>(() => new GetRogueExhibitionCsReq());

		// Token: 0x0400226A RID: 8810
		private UnknownFieldSet _unknownFields;
	}
}

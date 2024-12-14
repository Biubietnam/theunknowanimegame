using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000633 RID: 1587
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetBattleCollegeDataCsReq : IMessage<GetBattleCollegeDataCsReq>, IMessage, IEquatable<GetBattleCollegeDataCsReq>, IDeepCloneable<GetBattleCollegeDataCsReq>, IBufferMessage
	{
		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x000C362B File Offset: 0x000C182B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetBattleCollegeDataCsReq> Parser
		{
			get
			{
				return GetBattleCollegeDataCsReq._parser;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x000C3632 File Offset: 0x000C1832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetBattleCollegeDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x000C3644 File Offset: 0x000C1844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBattleCollegeDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x000C364B File Offset: 0x000C184B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBattleCollegeDataCsReq()
		{
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x000C3653 File Offset: 0x000C1853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBattleCollegeDataCsReq(GetBattleCollegeDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x000C366C File Offset: 0x000C186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBattleCollegeDataCsReq Clone()
		{
			return new GetBattleCollegeDataCsReq(this);
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x000C3674 File Offset: 0x000C1874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBattleCollegeDataCsReq);
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x000C3682 File Offset: 0x000C1882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetBattleCollegeDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x000C36A0 File Offset: 0x000C18A0
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

		// Token: 0x0600474A RID: 18250 RVA: 0x000C36C6 File Offset: 0x000C18C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x000C36CE File Offset: 0x000C18CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x000C36D7 File Offset: 0x000C18D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x000C36F0 File Offset: 0x000C18F0
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

		// Token: 0x0600474E RID: 18254 RVA: 0x000C3716 File Offset: 0x000C1916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetBattleCollegeDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x000C3733 File Offset: 0x000C1933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x000C373C File Offset: 0x000C193C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C92 RID: 7314
		private static readonly MessageParser<GetBattleCollegeDataCsReq> _parser = new MessageParser<GetBattleCollegeDataCsReq>(() => new GetBattleCollegeDataCsReq());

		// Token: 0x04001C93 RID: 7315
		private UnknownFieldSet _unknownFields;
	}
}

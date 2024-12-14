using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000275 RID: 629
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryCsReq : IMessage<ChessRogueQueryCsReq>, IMessage, IEquatable<ChessRogueQueryCsReq>, IDeepCloneable<ChessRogueQueryCsReq>, IBufferMessage
	{
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x000504E3 File Offset: 0x0004E6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryCsReq> Parser
		{
			get
			{
				return ChessRogueQueryCsReq._parser;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000504EA File Offset: 0x0004E6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x000504FC File Offset: 0x0004E6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryCsReq.Descriptor;
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00050503 File Offset: 0x0004E703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryCsReq()
		{
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0005050B File Offset: 0x0004E70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryCsReq(ChessRogueQueryCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00050524 File Offset: 0x0004E724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryCsReq Clone()
		{
			return new ChessRogueQueryCsReq(this);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0005052C File Offset: 0x0004E72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryCsReq);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0005053A File Offset: 0x0004E73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00050558 File Offset: 0x0004E758
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

		// Token: 0x06001C10 RID: 7184 RVA: 0x0005057E File Offset: 0x0004E77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00050586 File Offset: 0x0004E786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0005058F File Offset: 0x0004E78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000505A8 File Offset: 0x0004E7A8
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

		// Token: 0x06001C14 RID: 7188 RVA: 0x000505CE File Offset: 0x0004E7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000505EB File Offset: 0x0004E7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000505F4 File Offset: 0x0004E7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000BB8 RID: 3000
		private static readonly MessageParser<ChessRogueQueryCsReq> _parser = new MessageParser<ChessRogueQueryCsReq>(() => new ChessRogueQueryCsReq());

		// Token: 0x04000BB9 RID: 3001
		private UnknownFieldSet _unknownFields;
	}
}

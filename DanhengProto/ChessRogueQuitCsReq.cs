using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000281 RID: 641
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQuitCsReq : IMessage<ChessRogueQuitCsReq>, IMessage, IEquatable<ChessRogueQuitCsReq>, IDeepCloneable<ChessRogueQuitCsReq>, IBufferMessage
	{
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x000521A2 File Offset: 0x000503A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQuitCsReq> Parser
		{
			get
			{
				return ChessRogueQuitCsReq._parser;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x000521A9 File Offset: 0x000503A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQuitCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x000521BB File Offset: 0x000503BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQuitCsReq.Descriptor;
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000521C2 File Offset: 0x000503C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuitCsReq()
		{
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x000521CA File Offset: 0x000503CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuitCsReq(ChessRogueQuitCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000521E3 File Offset: 0x000503E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuitCsReq Clone()
		{
			return new ChessRogueQuitCsReq(this);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000521EB File Offset: 0x000503EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQuitCsReq);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000521F9 File Offset: 0x000503F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQuitCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00052218 File Offset: 0x00050418
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

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0005223E File Offset: 0x0005043E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00052246 File Offset: 0x00050446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0005224F File Offset: 0x0005044F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00052268 File Offset: 0x00050468
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

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0005228E File Offset: 0x0005048E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQuitCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000522AB File Offset: 0x000504AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000522B4 File Offset: 0x000504B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000BF8 RID: 3064
		private static readonly MessageParser<ChessRogueQuitCsReq> _parser = new MessageParser<ChessRogueQuitCsReq>(() => new ChessRogueQuitCsReq());

		// Token: 0x04000BF9 RID: 3065
		private UnknownFieldSet _unknownFields;
	}
}

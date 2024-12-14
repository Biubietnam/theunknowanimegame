using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A37 RID: 2615
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyGetInfoCsReq : IMessage<LobbyGetInfoCsReq>, IMessage, IEquatable<LobbyGetInfoCsReq>, IDeepCloneable<LobbyGetInfoCsReq>, IBufferMessage
	{
		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06007409 RID: 29705 RVA: 0x00134A42 File Offset: 0x00132C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyGetInfoCsReq> Parser
		{
			get
			{
				return LobbyGetInfoCsReq._parser;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600740A RID: 29706 RVA: 0x00134A49 File Offset: 0x00132C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyGetInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x0600740B RID: 29707 RVA: 0x00134A5B File Offset: 0x00132C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyGetInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x00134A62 File Offset: 0x00132C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyGetInfoCsReq()
		{
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x00134A6A File Offset: 0x00132C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyGetInfoCsReq(LobbyGetInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x00134A83 File Offset: 0x00132C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyGetInfoCsReq Clone()
		{
			return new LobbyGetInfoCsReq(this);
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x00134A8B File Offset: 0x00132C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyGetInfoCsReq);
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x00134A99 File Offset: 0x00132C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyGetInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x00134AB8 File Offset: 0x00132CB8
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

		// Token: 0x06007412 RID: 29714 RVA: 0x00134ADE File Offset: 0x00132CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x00134AE6 File Offset: 0x00132CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x00134AEF File Offset: 0x00132CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x00134B08 File Offset: 0x00132D08
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

		// Token: 0x06007416 RID: 29718 RVA: 0x00134B2E File Offset: 0x00132D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyGetInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x00134B4B File Offset: 0x00132D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x00134B54 File Offset: 0x00132D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002CA7 RID: 11431
		private static readonly MessageParser<LobbyGetInfoCsReq> _parser = new MessageParser<LobbyGetInfoCsReq>(() => new LobbyGetInfoCsReq());

		// Token: 0x04002CA8 RID: 11432
		private UnknownFieldSet _unknownFields;
	}
}

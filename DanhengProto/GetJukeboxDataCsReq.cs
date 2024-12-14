using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006E9 RID: 1769
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetJukeboxDataCsReq : IMessage<GetJukeboxDataCsReq>, IMessage, IEquatable<GetJukeboxDataCsReq>, IDeepCloneable<GetJukeboxDataCsReq>, IBufferMessage
	{
		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004F21 RID: 20257 RVA: 0x000D5E76 File Offset: 0x000D4076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetJukeboxDataCsReq> Parser
		{
			get
			{
				return GetJukeboxDataCsReq._parser;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06004F22 RID: 20258 RVA: 0x000D5E7D File Offset: 0x000D407D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetJukeboxDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004F23 RID: 20259 RVA: 0x000D5E8F File Offset: 0x000D408F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetJukeboxDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x000D5E96 File Offset: 0x000D4096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetJukeboxDataCsReq()
		{
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x000D5E9E File Offset: 0x000D409E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetJukeboxDataCsReq(GetJukeboxDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x000D5EB7 File Offset: 0x000D40B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetJukeboxDataCsReq Clone()
		{
			return new GetJukeboxDataCsReq(this);
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x000D5EBF File Offset: 0x000D40BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetJukeboxDataCsReq);
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x000D5ECD File Offset: 0x000D40CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetJukeboxDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x000D5EEC File Offset: 0x000D40EC
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

		// Token: 0x06004F2A RID: 20266 RVA: 0x000D5F12 File Offset: 0x000D4112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x000D5F1A File Offset: 0x000D411A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x000D5F23 File Offset: 0x000D4123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x000D5F3C File Offset: 0x000D413C
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

		// Token: 0x06004F2E RID: 20270 RVA: 0x000D5F62 File Offset: 0x000D4162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetJukeboxDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x000D5F7F File Offset: 0x000D417F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x000D5F88 File Offset: 0x000D4188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F39 RID: 7993
		private static readonly MessageParser<GetJukeboxDataCsReq> _parser = new MessageParser<GetJukeboxDataCsReq>(() => new GetJukeboxDataCsReq());

		// Token: 0x04001F3A RID: 7994
		private UnknownFieldSet _unknownFields;
	}
}

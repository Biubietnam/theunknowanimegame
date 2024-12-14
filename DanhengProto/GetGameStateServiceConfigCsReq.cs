using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006DD RID: 1757
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetGameStateServiceConfigCsReq : IMessage<GetGameStateServiceConfigCsReq>, IMessage, IEquatable<GetGameStateServiceConfigCsReq>, IDeepCloneable<GetGameStateServiceConfigCsReq>, IBufferMessage
	{
		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x000D4B87 File Offset: 0x000D2D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetGameStateServiceConfigCsReq> Parser
		{
			get
			{
				return GetGameStateServiceConfigCsReq._parser;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x000D4B8E File Offset: 0x000D2D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetGameStateServiceConfigCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06004EA2 RID: 20130 RVA: 0x000D4BA0 File Offset: 0x000D2DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameStateServiceConfigCsReq.Descriptor;
			}
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x000D4BA7 File Offset: 0x000D2DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGameStateServiceConfigCsReq()
		{
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x000D4BAF File Offset: 0x000D2DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGameStateServiceConfigCsReq(GetGameStateServiceConfigCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x000D4BC8 File Offset: 0x000D2DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGameStateServiceConfigCsReq Clone()
		{
			return new GetGameStateServiceConfigCsReq(this);
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x000D4BD0 File Offset: 0x000D2DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameStateServiceConfigCsReq);
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x000D4BDE File Offset: 0x000D2DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetGameStateServiceConfigCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x000D4BFC File Offset: 0x000D2DFC
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

		// Token: 0x06004EA9 RID: 20137 RVA: 0x000D4C22 File Offset: 0x000D2E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x000D4C2A File Offset: 0x000D2E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x000D4C33 File Offset: 0x000D2E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x000D4C4C File Offset: 0x000D2E4C
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

		// Token: 0x06004EAD RID: 20141 RVA: 0x000D4C72 File Offset: 0x000D2E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetGameStateServiceConfigCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x000D4C8F File Offset: 0x000D2E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x000D4C98 File Offset: 0x000D2E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F0A RID: 7946
		private static readonly MessageParser<GetGameStateServiceConfigCsReq> _parser = new MessageParser<GetGameStateServiceConfigCsReq>(() => new GetGameStateServiceConfigCsReq());

		// Token: 0x04001F0B RID: 7947
		private UnknownFieldSet _unknownFields;
	}
}

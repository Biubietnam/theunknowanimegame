using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000169 RID: 361
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelMatchCsReq : IMessage<CancelMatchCsReq>, IMessage, IEquatable<CancelMatchCsReq>, IDeepCloneable<CancelMatchCsReq>, IBufferMessage
	{
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0002EC96 File Offset: 0x0002CE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelMatchCsReq> Parser
		{
			get
			{
				return CancelMatchCsReq._parser;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x0002EC9D File Offset: 0x0002CE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelMatchCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0002ECAF File Offset: 0x0002CEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchCsReq.Descriptor;
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0002ECB6 File Offset: 0x0002CEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchCsReq()
		{
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0002ECBE File Offset: 0x0002CEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchCsReq(CancelMatchCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0002ECD7 File Offset: 0x0002CED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchCsReq Clone()
		{
			return new CancelMatchCsReq(this);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0002ECDF File Offset: 0x0002CEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchCsReq);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0002ECED File Offset: 0x0002CEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMatchCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0002ED0C File Offset: 0x0002CF0C
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

		// Token: 0x06001021 RID: 4129 RVA: 0x0002ED32 File Offset: 0x0002CF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0002ED3A File Offset: 0x0002CF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0002ED43 File Offset: 0x0002CF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0002ED5C File Offset: 0x0002CF5C
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

		// Token: 0x06001025 RID: 4133 RVA: 0x0002ED82 File Offset: 0x0002CF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelMatchCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0002ED9F File Offset: 0x0002CF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0002EDA8 File Offset: 0x0002CFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040006CE RID: 1742
		private static readonly MessageParser<CancelMatchCsReq> _parser = new MessageParser<CancelMatchCsReq>(() => new CancelMatchCsReq());

		// Token: 0x040006CF RID: 1743
		private UnknownFieldSet _unknownFields;
	}
}

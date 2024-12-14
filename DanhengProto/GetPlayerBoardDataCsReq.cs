using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000765 RID: 1893
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlayerBoardDataCsReq : IMessage<GetPlayerBoardDataCsReq>, IMessage, IEquatable<GetPlayerBoardDataCsReq>, IDeepCloneable<GetPlayerBoardDataCsReq>, IBufferMessage
	{
		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06005495 RID: 21653 RVA: 0x000E36D7 File Offset: 0x000E18D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlayerBoardDataCsReq> Parser
		{
			get
			{
				return GetPlayerBoardDataCsReq._parser;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06005496 RID: 21654 RVA: 0x000E36DE File Offset: 0x000E18DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlayerBoardDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06005497 RID: 21655 RVA: 0x000E36F0 File Offset: 0x000E18F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerBoardDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x000E36F7 File Offset: 0x000E18F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerBoardDataCsReq()
		{
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x000E36FF File Offset: 0x000E18FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerBoardDataCsReq(GetPlayerBoardDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x000E3718 File Offset: 0x000E1918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerBoardDataCsReq Clone()
		{
			return new GetPlayerBoardDataCsReq(this);
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x000E3720 File Offset: 0x000E1920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerBoardDataCsReq);
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x000E372E File Offset: 0x000E192E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlayerBoardDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x000E374C File Offset: 0x000E194C
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

		// Token: 0x0600549E RID: 21662 RVA: 0x000E3772 File Offset: 0x000E1972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x000E377A File Offset: 0x000E197A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x000E3783 File Offset: 0x000E1983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x000E379C File Offset: 0x000E199C
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

		// Token: 0x060054A2 RID: 21666 RVA: 0x000E37C2 File Offset: 0x000E19C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlayerBoardDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x000E37DF File Offset: 0x000E19DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x000E37E8 File Offset: 0x000E19E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002135 RID: 8501
		private static readonly MessageParser<GetPlayerBoardDataCsReq> _parser = new MessageParser<GetPlayerBoardDataCsReq>(() => new GetPlayerBoardDataCsReq());

		// Token: 0x04002136 RID: 8502
		private UnknownFieldSet _unknownFields;
	}
}

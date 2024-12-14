using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007B1 RID: 1969
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueCommonDialogueDataCsReq : IMessage<GetRogueCommonDialogueDataCsReq>, IMessage, IEquatable<GetRogueCommonDialogueDataCsReq>, IDeepCloneable<GetRogueCommonDialogueDataCsReq>, IBufferMessage
	{
		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x060057E2 RID: 22498 RVA: 0x000EB2D7 File Offset: 0x000E94D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueCommonDialogueDataCsReq> Parser
		{
			get
			{
				return GetRogueCommonDialogueDataCsReq._parser;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x000EB2DE File Offset: 0x000E94DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueCommonDialogueDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x060057E4 RID: 22500 RVA: 0x000EB2F0 File Offset: 0x000E94F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueCommonDialogueDataCsReq.Descriptor;
			}
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x000EB2F7 File Offset: 0x000E94F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCommonDialogueDataCsReq()
		{
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x000EB2FF File Offset: 0x000E94FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCommonDialogueDataCsReq(GetRogueCommonDialogueDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x000EB318 File Offset: 0x000E9518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCommonDialogueDataCsReq Clone()
		{
			return new GetRogueCommonDialogueDataCsReq(this);
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x000EB320 File Offset: 0x000E9520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueCommonDialogueDataCsReq);
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x000EB32E File Offset: 0x000E952E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueCommonDialogueDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x000EB34C File Offset: 0x000E954C
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

		// Token: 0x060057EB RID: 22507 RVA: 0x000EB372 File Offset: 0x000E9572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x000EB37A File Offset: 0x000E957A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x000EB383 File Offset: 0x000E9583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x000EB39C File Offset: 0x000E959C
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

		// Token: 0x060057EF RID: 22511 RVA: 0x000EB3C2 File Offset: 0x000E95C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueCommonDialogueDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x000EB3DF File Offset: 0x000E95DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x000EB3E8 File Offset: 0x000E95E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400224C RID: 8780
		private static readonly MessageParser<GetRogueCommonDialogueDataCsReq> _parser = new MessageParser<GetRogueCommonDialogueDataCsReq>(() => new GetRogueCommonDialogueDataCsReq());

		// Token: 0x0400224D RID: 8781
		private UnknownFieldSet _unknownFields;
	}
}

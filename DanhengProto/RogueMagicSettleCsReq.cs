using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F19 RID: 3865
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicSettleCsReq : IMessage<RogueMagicSettleCsReq>, IMessage, IEquatable<RogueMagicSettleCsReq>, IDeepCloneable<RogueMagicSettleCsReq>, IBufferMessage
	{
		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0600AC85 RID: 44165 RVA: 0x001D02E3 File Offset: 0x001CE4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicSettleCsReq> Parser
		{
			get
			{
				return RogueMagicSettleCsReq._parser;
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0600AC86 RID: 44166 RVA: 0x001D02EA File Offset: 0x001CE4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicSettleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0600AC87 RID: 44167 RVA: 0x001D02FC File Offset: 0x001CE4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicSettleCsReq.Descriptor;
			}
		}

		// Token: 0x0600AC88 RID: 44168 RVA: 0x001D0303 File Offset: 0x001CE503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSettleCsReq()
		{
		}

		// Token: 0x0600AC89 RID: 44169 RVA: 0x001D030B File Offset: 0x001CE50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSettleCsReq(RogueMagicSettleCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC8A RID: 44170 RVA: 0x001D0324 File Offset: 0x001CE524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSettleCsReq Clone()
		{
			return new RogueMagicSettleCsReq(this);
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x001D032C File Offset: 0x001CE52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicSettleCsReq);
		}

		// Token: 0x0600AC8C RID: 44172 RVA: 0x001D033A File Offset: 0x001CE53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicSettleCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AC8D RID: 44173 RVA: 0x001D0358 File Offset: 0x001CE558
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

		// Token: 0x0600AC8E RID: 44174 RVA: 0x001D037E File Offset: 0x001CE57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC8F RID: 44175 RVA: 0x001D0386 File Offset: 0x001CE586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC90 RID: 44176 RVA: 0x001D038F File Offset: 0x001CE58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x001D03A8 File Offset: 0x001CE5A8
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

		// Token: 0x0600AC92 RID: 44178 RVA: 0x001D03CE File Offset: 0x001CE5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicSettleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x001D03EB File Offset: 0x001CE5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x001D03F4 File Offset: 0x001CE5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400464B RID: 17995
		private static readonly MessageParser<RogueMagicSettleCsReq> _parser = new MessageParser<RogueMagicSettleCsReq>(() => new RogueMagicSettleCsReq());

		// Token: 0x0400464C RID: 17996
		private UnknownFieldSet _unknownFields;
	}
}

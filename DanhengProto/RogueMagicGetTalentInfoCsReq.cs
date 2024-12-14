using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EE3 RID: 3811
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGetTalentInfoCsReq : IMessage<RogueMagicGetTalentInfoCsReq>, IMessage, IEquatable<RogueMagicGetTalentInfoCsReq>, IDeepCloneable<RogueMagicGetTalentInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0600AA5E RID: 43614 RVA: 0x001CB11F File Offset: 0x001C931F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGetTalentInfoCsReq> Parser
		{
			get
			{
				return RogueMagicGetTalentInfoCsReq._parser;
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0600AA5F RID: 43615 RVA: 0x001CB126 File Offset: 0x001C9326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGetTalentInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0600AA60 RID: 43616 RVA: 0x001CB138 File Offset: 0x001C9338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGetTalentInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x001CB13F File Offset: 0x001C933F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetTalentInfoCsReq()
		{
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x001CB147 File Offset: 0x001C9347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetTalentInfoCsReq(RogueMagicGetTalentInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA63 RID: 43619 RVA: 0x001CB160 File Offset: 0x001C9360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetTalentInfoCsReq Clone()
		{
			return new RogueMagicGetTalentInfoCsReq(this);
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x001CB168 File Offset: 0x001C9368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGetTalentInfoCsReq);
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x001CB176 File Offset: 0x001C9376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGetTalentInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AA66 RID: 43622 RVA: 0x001CB194 File Offset: 0x001C9394
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

		// Token: 0x0600AA67 RID: 43623 RVA: 0x001CB1BA File Offset: 0x001C93BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x001CB1C2 File Offset: 0x001C93C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x001CB1CB File Offset: 0x001C93CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x001CB1E4 File Offset: 0x001C93E4
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

		// Token: 0x0600AA6B RID: 43627 RVA: 0x001CB20A File Offset: 0x001C940A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGetTalentInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA6C RID: 43628 RVA: 0x001CB227 File Offset: 0x001C9427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x001CB230 File Offset: 0x001C9430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400458F RID: 17807
		private static readonly MessageParser<RogueMagicGetTalentInfoCsReq> _parser = new MessageParser<RogueMagicGetTalentInfoCsReq>(() => new RogueMagicGetTalentInfoCsReq());

		// Token: 0x04004590 RID: 17808
		private UnknownFieldSet _unknownFields;
	}
}

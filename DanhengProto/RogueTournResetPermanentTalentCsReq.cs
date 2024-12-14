using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001005 RID: 4101
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournResetPermanentTalentCsReq : IMessage<RogueTournResetPermanentTalentCsReq>, IMessage, IEquatable<RogueTournResetPermanentTalentCsReq>, IDeepCloneable<RogueTournResetPermanentTalentCsReq>, IBufferMessage
	{
		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600B67A RID: 46714 RVA: 0x001E9A1B File Offset: 0x001E7C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournResetPermanentTalentCsReq> Parser
		{
			get
			{
				return RogueTournResetPermanentTalentCsReq._parser;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600B67B RID: 46715 RVA: 0x001E9A22 File Offset: 0x001E7C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournResetPermanentTalentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600B67C RID: 46716 RVA: 0x001E9A34 File Offset: 0x001E7C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournResetPermanentTalentCsReq.Descriptor;
			}
		}

		// Token: 0x0600B67D RID: 46717 RVA: 0x001E9A3B File Offset: 0x001E7C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournResetPermanentTalentCsReq()
		{
		}

		// Token: 0x0600B67E RID: 46718 RVA: 0x001E9A43 File Offset: 0x001E7C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournResetPermanentTalentCsReq(RogueTournResetPermanentTalentCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B67F RID: 46719 RVA: 0x001E9A5C File Offset: 0x001E7C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournResetPermanentTalentCsReq Clone()
		{
			return new RogueTournResetPermanentTalentCsReq(this);
		}

		// Token: 0x0600B680 RID: 46720 RVA: 0x001E9A64 File Offset: 0x001E7C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournResetPermanentTalentCsReq);
		}

		// Token: 0x0600B681 RID: 46721 RVA: 0x001E9A72 File Offset: 0x001E7C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournResetPermanentTalentCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B682 RID: 46722 RVA: 0x001E9A90 File Offset: 0x001E7C90
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

		// Token: 0x0600B683 RID: 46723 RVA: 0x001E9AB6 File Offset: 0x001E7CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B684 RID: 46724 RVA: 0x001E9ABE File Offset: 0x001E7CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B685 RID: 46725 RVA: 0x001E9AC7 File Offset: 0x001E7CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B686 RID: 46726 RVA: 0x001E9AE0 File Offset: 0x001E7CE0
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

		// Token: 0x0600B687 RID: 46727 RVA: 0x001E9B06 File Offset: 0x001E7D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournResetPermanentTalentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x001E9B23 File Offset: 0x001E7D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x001E9B2C File Offset: 0x001E7D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040049F2 RID: 18930
		private static readonly MessageParser<RogueTournResetPermanentTalentCsReq> _parser = new MessageParser<RogueTournResetPermanentTalentCsReq>(() => new RogueTournResetPermanentTalentCsReq());

		// Token: 0x040049F3 RID: 18931
		private UnknownFieldSet _unknownFields;
	}
}

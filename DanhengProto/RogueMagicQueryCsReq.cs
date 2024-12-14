using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EF3 RID: 3827
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicQueryCsReq : IMessage<RogueMagicQueryCsReq>, IMessage, IEquatable<RogueMagicQueryCsReq>, IDeepCloneable<RogueMagicQueryCsReq>, IBufferMessage
	{
		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0600AAF0 RID: 43760 RVA: 0x001CC8E3 File Offset: 0x001CAAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicQueryCsReq> Parser
		{
			get
			{
				return RogueMagicQueryCsReq._parser;
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0600AAF1 RID: 43761 RVA: 0x001CC8EA File Offset: 0x001CAAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicQueryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x0600AAF2 RID: 43762 RVA: 0x001CC8FC File Offset: 0x001CAAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicQueryCsReq.Descriptor;
			}
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x001CC903 File Offset: 0x001CAB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicQueryCsReq()
		{
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x001CC90B File Offset: 0x001CAB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicQueryCsReq(RogueMagicQueryCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x001CC924 File Offset: 0x001CAB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicQueryCsReq Clone()
		{
			return new RogueMagicQueryCsReq(this);
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x001CC92C File Offset: 0x001CAB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicQueryCsReq);
		}

		// Token: 0x0600AAF7 RID: 43767 RVA: 0x001CC93A File Offset: 0x001CAB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicQueryCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AAF8 RID: 43768 RVA: 0x001CC958 File Offset: 0x001CAB58
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

		// Token: 0x0600AAF9 RID: 43769 RVA: 0x001CC97E File Offset: 0x001CAB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AAFA RID: 43770 RVA: 0x001CC986 File Offset: 0x001CAB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAFB RID: 43771 RVA: 0x001CC98F File Offset: 0x001CAB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x001CC9A8 File Offset: 0x001CABA8
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

		// Token: 0x0600AAFD RID: 43773 RVA: 0x001CC9CE File Offset: 0x001CABCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicQueryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAFE RID: 43774 RVA: 0x001CC9EB File Offset: 0x001CABEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x001CC9F4 File Offset: 0x001CABF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045CC RID: 17868
		private static readonly MessageParser<RogueMagicQueryCsReq> _parser = new MessageParser<RogueMagicQueryCsReq>(() => new RogueMagicQueryCsReq());

		// Token: 0x040045CD RID: 17869
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001017 RID: 4119
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournSettleCsReq : IMessage<RogueTournSettleCsReq>, IMessage, IEquatable<RogueTournSettleCsReq>, IDeepCloneable<RogueTournSettleCsReq>, IBufferMessage
	{
		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600B73B RID: 46907 RVA: 0x001EB9E3 File Offset: 0x001E9BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournSettleCsReq> Parser
		{
			get
			{
				return RogueTournSettleCsReq._parser;
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600B73C RID: 46908 RVA: 0x001EB9EA File Offset: 0x001E9BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournSettleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600B73D RID: 46909 RVA: 0x001EB9FC File Offset: 0x001E9BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournSettleCsReq.Descriptor;
			}
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x001EBA03 File Offset: 0x001E9C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSettleCsReq()
		{
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x001EBA0B File Offset: 0x001E9C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSettleCsReq(RogueTournSettleCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B740 RID: 46912 RVA: 0x001EBA24 File Offset: 0x001E9C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSettleCsReq Clone()
		{
			return new RogueTournSettleCsReq(this);
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x001EBA2C File Offset: 0x001E9C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournSettleCsReq);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x001EBA3A File Offset: 0x001E9C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournSettleCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x001EBA58 File Offset: 0x001E9C58
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

		// Token: 0x0600B744 RID: 46916 RVA: 0x001EBA7E File Offset: 0x001E9C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x001EBA86 File Offset: 0x001E9C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x001EBA8F File Offset: 0x001E9C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x001EBAA8 File Offset: 0x001E9CA8
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

		// Token: 0x0600B748 RID: 46920 RVA: 0x001EBACE File Offset: 0x001E9CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournSettleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x001EBAEB File Offset: 0x001E9CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x001EBAF4 File Offset: 0x001E9CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A39 RID: 19001
		private static readonly MessageParser<RogueTournSettleCsReq> _parser = new MessageParser<RogueTournSettleCsReq>(() => new RogueTournSettleCsReq());

		// Token: 0x04004A3A RID: 19002
		private UnknownFieldSet _unknownFields;
	}
}

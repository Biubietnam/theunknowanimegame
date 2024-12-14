using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FC5 RID: 4037
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetArchiveRepositoryCsReq : IMessage<RogueTournGetArchiveRepositoryCsReq>, IMessage, IEquatable<RogueTournGetArchiveRepositoryCsReq>, IDeepCloneable<RogueTournGetArchiveRepositoryCsReq>, IBufferMessage
	{
		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600B3DA RID: 46042 RVA: 0x001E2E07 File Offset: 0x001E1007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetArchiveRepositoryCsReq> Parser
		{
			get
			{
				return RogueTournGetArchiveRepositoryCsReq._parser;
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600B3DB RID: 46043 RVA: 0x001E2E0E File Offset: 0x001E100E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetArchiveRepositoryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600B3DC RID: 46044 RVA: 0x001E2E20 File Offset: 0x001E1020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetArchiveRepositoryCsReq.Descriptor;
			}
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x001E2E27 File Offset: 0x001E1027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetArchiveRepositoryCsReq()
		{
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x001E2E2F File Offset: 0x001E102F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetArchiveRepositoryCsReq(RogueTournGetArchiveRepositoryCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x001E2E48 File Offset: 0x001E1048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetArchiveRepositoryCsReq Clone()
		{
			return new RogueTournGetArchiveRepositoryCsReq(this);
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x001E2E50 File Offset: 0x001E1050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetArchiveRepositoryCsReq);
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x001E2E5E File Offset: 0x001E105E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetArchiveRepositoryCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x001E2E7C File Offset: 0x001E107C
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

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x001E2EA2 File Offset: 0x001E10A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3E4 RID: 46052 RVA: 0x001E2EAA File Offset: 0x001E10AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x001E2EB3 File Offset: 0x001E10B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x001E2ECC File Offset: 0x001E10CC
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

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x001E2EF2 File Offset: 0x001E10F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetArchiveRepositoryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x001E2F0F File Offset: 0x001E110F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3E9 RID: 46057 RVA: 0x001E2F18 File Offset: 0x001E1118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048F7 RID: 18679
		private static readonly MessageParser<RogueTournGetArchiveRepositoryCsReq> _parser = new MessageParser<RogueTournGetArchiveRepositoryCsReq>(() => new RogueTournGetArchiveRepositoryCsReq());

		// Token: 0x040048F8 RID: 18680
		private UnknownFieldSet _unknownFields;
	}
}

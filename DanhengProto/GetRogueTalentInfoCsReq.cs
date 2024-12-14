using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007D5 RID: 2005
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueTalentInfoCsReq : IMessage<GetRogueTalentInfoCsReq>, IMessage, IEquatable<GetRogueTalentInfoCsReq>, IDeepCloneable<GetRogueTalentInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x0600596F RID: 22895 RVA: 0x000EEB6B File Offset: 0x000ECD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueTalentInfoCsReq> Parser
		{
			get
			{
				return GetRogueTalentInfoCsReq._parser;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06005970 RID: 22896 RVA: 0x000EEB72 File Offset: 0x000ECD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueTalentInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06005971 RID: 22897 RVA: 0x000EEB84 File Offset: 0x000ECD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueTalentInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x000EEB8B File Offset: 0x000ECD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueTalentInfoCsReq()
		{
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x000EEB93 File Offset: 0x000ECD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueTalentInfoCsReq(GetRogueTalentInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x000EEBAC File Offset: 0x000ECDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueTalentInfoCsReq Clone()
		{
			return new GetRogueTalentInfoCsReq(this);
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x000EEBB4 File Offset: 0x000ECDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueTalentInfoCsReq);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x000EEBC2 File Offset: 0x000ECDC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueTalentInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x000EEBE0 File Offset: 0x000ECDE0
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

		// Token: 0x06005978 RID: 22904 RVA: 0x000EEC06 File Offset: 0x000ECE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x000EEC0E File Offset: 0x000ECE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x000EEC17 File Offset: 0x000ECE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x000EEC30 File Offset: 0x000ECE30
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

		// Token: 0x0600597C RID: 22908 RVA: 0x000EEC56 File Offset: 0x000ECE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueTalentInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x000EEC73 File Offset: 0x000ECE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x000EEC7C File Offset: 0x000ECE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022C3 RID: 8899
		private static readonly MessageParser<GetRogueTalentInfoCsReq> _parser = new MessageParser<GetRogueTalentInfoCsReq>(() => new GetRogueTalentInfoCsReq());

		// Token: 0x040022C4 RID: 8900
		private UnknownFieldSet _unknownFields;
	}
}

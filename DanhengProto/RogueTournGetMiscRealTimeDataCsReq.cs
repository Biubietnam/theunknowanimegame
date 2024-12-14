using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FCD RID: 4045
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetMiscRealTimeDataCsReq : IMessage<RogueTournGetMiscRealTimeDataCsReq>, IMessage, IEquatable<RogueTournGetMiscRealTimeDataCsReq>, IDeepCloneable<RogueTournGetMiscRealTimeDataCsReq>, IBufferMessage
	{
		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600B432 RID: 46130 RVA: 0x001E3A57 File Offset: 0x001E1C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetMiscRealTimeDataCsReq> Parser
		{
			get
			{
				return RogueTournGetMiscRealTimeDataCsReq._parser;
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600B433 RID: 46131 RVA: 0x001E3A5E File Offset: 0x001E1C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetMiscRealTimeDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600B434 RID: 46132 RVA: 0x001E3A70 File Offset: 0x001E1C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetMiscRealTimeDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600B435 RID: 46133 RVA: 0x001E3A77 File Offset: 0x001E1C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetMiscRealTimeDataCsReq()
		{
		}

		// Token: 0x0600B436 RID: 46134 RVA: 0x001E3A7F File Offset: 0x001E1C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetMiscRealTimeDataCsReq(RogueTournGetMiscRealTimeDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B437 RID: 46135 RVA: 0x001E3A98 File Offset: 0x001E1C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetMiscRealTimeDataCsReq Clone()
		{
			return new RogueTournGetMiscRealTimeDataCsReq(this);
		}

		// Token: 0x0600B438 RID: 46136 RVA: 0x001E3AA0 File Offset: 0x001E1CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetMiscRealTimeDataCsReq);
		}

		// Token: 0x0600B439 RID: 46137 RVA: 0x001E3AAE File Offset: 0x001E1CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetMiscRealTimeDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B43A RID: 46138 RVA: 0x001E3ACC File Offset: 0x001E1CCC
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

		// Token: 0x0600B43B RID: 46139 RVA: 0x001E3AF2 File Offset: 0x001E1CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B43C RID: 46140 RVA: 0x001E3AFA File Offset: 0x001E1CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B43D RID: 46141 RVA: 0x001E3B03 File Offset: 0x001E1D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B43E RID: 46142 RVA: 0x001E3B1C File Offset: 0x001E1D1C
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

		// Token: 0x0600B43F RID: 46143 RVA: 0x001E3B42 File Offset: 0x001E1D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetMiscRealTimeDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B440 RID: 46144 RVA: 0x001E3B5F File Offset: 0x001E1D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B441 RID: 46145 RVA: 0x001E3B68 File Offset: 0x001E1D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004913 RID: 18707
		private static readonly MessageParser<RogueTournGetMiscRealTimeDataCsReq> _parser = new MessageParser<RogueTournGetMiscRealTimeDataCsReq>(() => new RogueTournGetMiscRealTimeDataCsReq());

		// Token: 0x04004914 RID: 18708
		private UnknownFieldSet _unknownFields;
	}
}

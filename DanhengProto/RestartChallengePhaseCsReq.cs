using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DCD RID: 3533
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RestartChallengePhaseCsReq : IMessage<RestartChallengePhaseCsReq>, IMessage, IEquatable<RestartChallengePhaseCsReq>, IDeepCloneable<RestartChallengePhaseCsReq>, IBufferMessage
	{
		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x06009DF9 RID: 40441 RVA: 0x001A4D5B File Offset: 0x001A2F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RestartChallengePhaseCsReq> Parser
		{
			get
			{
				return RestartChallengePhaseCsReq._parser;
			}
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x06009DFA RID: 40442 RVA: 0x001A4D62 File Offset: 0x001A2F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RestartChallengePhaseCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x06009DFB RID: 40443 RVA: 0x001A4D74 File Offset: 0x001A2F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestartChallengePhaseCsReq.Descriptor;
			}
		}

		// Token: 0x06009DFC RID: 40444 RVA: 0x001A4D7B File Offset: 0x001A2F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestartChallengePhaseCsReq()
		{
		}

		// Token: 0x06009DFD RID: 40445 RVA: 0x001A4D83 File Offset: 0x001A2F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestartChallengePhaseCsReq(RestartChallengePhaseCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x001A4D9C File Offset: 0x001A2F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestartChallengePhaseCsReq Clone()
		{
			return new RestartChallengePhaseCsReq(this);
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x001A4DA4 File Offset: 0x001A2FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestartChallengePhaseCsReq);
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x001A4DB2 File Offset: 0x001A2FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RestartChallengePhaseCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x001A4DD0 File Offset: 0x001A2FD0
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

		// Token: 0x06009E02 RID: 40450 RVA: 0x001A4DF6 File Offset: 0x001A2FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x001A4DFE File Offset: 0x001A2FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x001A4E07 File Offset: 0x001A3007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x001A4E20 File Offset: 0x001A3020
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

		// Token: 0x06009E06 RID: 40454 RVA: 0x001A4E46 File Offset: 0x001A3046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RestartChallengePhaseCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x001A4E63 File Offset: 0x001A3063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x001A4E6C File Offset: 0x001A306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D69 RID: 15721
		private static readonly MessageParser<RestartChallengePhaseCsReq> _parser = new MessageParser<RestartChallengePhaseCsReq>(() => new RestartChallengePhaseCsReq());

		// Token: 0x04003D6A RID: 15722
		private UnknownFieldSet _unknownFields;
	}
}

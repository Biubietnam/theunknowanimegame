using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200063B RID: 1595
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChallengeCsReq : IMessage<GetChallengeCsReq>, IMessage, IEquatable<GetChallengeCsReq>, IDeepCloneable<GetChallengeCsReq>, IBufferMessage
	{
		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06004795 RID: 18325 RVA: 0x000C40E6 File Offset: 0x000C22E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChallengeCsReq> Parser
		{
			get
			{
				return GetChallengeCsReq._parser;
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x000C40ED File Offset: 0x000C22ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChallengeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x000C40FF File Offset: 0x000C22FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChallengeCsReq.Descriptor;
			}
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x000C4106 File Offset: 0x000C2306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeCsReq()
		{
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x000C410E File Offset: 0x000C230E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeCsReq(GetChallengeCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x000C4127 File Offset: 0x000C2327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeCsReq Clone()
		{
			return new GetChallengeCsReq(this);
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x000C412F File Offset: 0x000C232F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChallengeCsReq);
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x000C413D File Offset: 0x000C233D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChallengeCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x000C415C File Offset: 0x000C235C
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

		// Token: 0x0600479E RID: 18334 RVA: 0x000C4182 File Offset: 0x000C2382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x000C418A File Offset: 0x000C238A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x000C4193 File Offset: 0x000C2393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x000C41AC File Offset: 0x000C23AC
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

		// Token: 0x060047A2 RID: 18338 RVA: 0x000C41D2 File Offset: 0x000C23D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChallengeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x000C41EF File Offset: 0x000C23EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x000C41F8 File Offset: 0x000C23F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CAA RID: 7338
		private static readonly MessageParser<GetChallengeCsReq> _parser = new MessageParser<GetChallengeCsReq>(() => new GetChallengeCsReq());

		// Token: 0x04001CAB RID: 7339
		private UnknownFieldSet _unknownFields;
	}
}

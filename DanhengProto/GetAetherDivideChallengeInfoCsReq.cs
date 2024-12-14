using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005FB RID: 1531
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAetherDivideChallengeInfoCsReq : IMessage<GetAetherDivideChallengeInfoCsReq>, IMessage, IEquatable<GetAetherDivideChallengeInfoCsReq>, IDeepCloneable<GetAetherDivideChallengeInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x000BC4B7 File Offset: 0x000BA6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAetherDivideChallengeInfoCsReq> Parser
		{
			get
			{
				return GetAetherDivideChallengeInfoCsReq._parser;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x000BC4BE File Offset: 0x000BA6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAetherDivideChallengeInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x000BC4D0 File Offset: 0x000BA6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAetherDivideChallengeInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x000BC4D7 File Offset: 0x000BA6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideChallengeInfoCsReq()
		{
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x000BC4DF File Offset: 0x000BA6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideChallengeInfoCsReq(GetAetherDivideChallengeInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x000BC4F8 File Offset: 0x000BA6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideChallengeInfoCsReq Clone()
		{
			return new GetAetherDivideChallengeInfoCsReq(this);
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x000BC500 File Offset: 0x000BA700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAetherDivideChallengeInfoCsReq);
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x000BC50E File Offset: 0x000BA70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAetherDivideChallengeInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x000BC52C File Offset: 0x000BA72C
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

		// Token: 0x060044AF RID: 17583 RVA: 0x000BC552 File Offset: 0x000BA752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x000BC55A File Offset: 0x000BA75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x000BC563 File Offset: 0x000BA763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x000BC57C File Offset: 0x000BA77C
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

		// Token: 0x060044B3 RID: 17587 RVA: 0x000BC5A2 File Offset: 0x000BA7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAetherDivideChallengeInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x000BC5BF File Offset: 0x000BA7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x000BC5C8 File Offset: 0x000BA7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B79 RID: 7033
		private static readonly MessageParser<GetAetherDivideChallengeInfoCsReq> _parser = new MessageParser<GetAetherDivideChallengeInfoCsReq>(() => new GetAetherDivideChallengeInfoCsReq());

		// Token: 0x04001B7A RID: 7034
		private UnknownFieldSet _unknownFields;
	}
}

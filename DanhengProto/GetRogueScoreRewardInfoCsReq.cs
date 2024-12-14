using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007C9 RID: 1993
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueScoreRewardInfoCsReq : IMessage<GetRogueScoreRewardInfoCsReq>, IMessage, IEquatable<GetRogueScoreRewardInfoCsReq>, IDeepCloneable<GetRogueScoreRewardInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060058E1 RID: 22753 RVA: 0x000ED507 File Offset: 0x000EB707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueScoreRewardInfoCsReq> Parser
		{
			get
			{
				return GetRogueScoreRewardInfoCsReq._parser;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x000ED50E File Offset: 0x000EB70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueScoreRewardInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060058E3 RID: 22755 RVA: 0x000ED520 File Offset: 0x000EB720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueScoreRewardInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x000ED527 File Offset: 0x000EB727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueScoreRewardInfoCsReq()
		{
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x000ED52F File Offset: 0x000EB72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueScoreRewardInfoCsReq(GetRogueScoreRewardInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x000ED548 File Offset: 0x000EB748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueScoreRewardInfoCsReq Clone()
		{
			return new GetRogueScoreRewardInfoCsReq(this);
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x000ED550 File Offset: 0x000EB750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueScoreRewardInfoCsReq);
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x000ED55E File Offset: 0x000EB75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueScoreRewardInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x000ED57C File Offset: 0x000EB77C
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

		// Token: 0x060058EA RID: 22762 RVA: 0x000ED5A2 File Offset: 0x000EB7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x000ED5AA File Offset: 0x000EB7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x000ED5B3 File Offset: 0x000EB7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x000ED5CC File Offset: 0x000EB7CC
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

		// Token: 0x060058EE RID: 22766 RVA: 0x000ED5F2 File Offset: 0x000EB7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueScoreRewardInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x000ED60F File Offset: 0x000EB80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x000ED618 File Offset: 0x000EB818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002295 RID: 8853
		private static readonly MessageParser<GetRogueScoreRewardInfoCsReq> _parser = new MessageParser<GetRogueScoreRewardInfoCsReq>(() => new GetRogueScoreRewardInfoCsReq());

		// Token: 0x04002296 RID: 8854
		private UnknownFieldSet _unknownFields;
	}
}

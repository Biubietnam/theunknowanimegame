using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006AD RID: 1709
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFirstTalkNpcCsReq : IMessage<GetFirstTalkNpcCsReq>, IMessage, IEquatable<GetFirstTalkNpcCsReq>, IDeepCloneable<GetFirstTalkNpcCsReq>, IBufferMessage
	{
		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x000CF7F8 File Offset: 0x000CD9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFirstTalkNpcCsReq> Parser
		{
			get
			{
				return GetFirstTalkNpcCsReq._parser;
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x000CF7FF File Offset: 0x000CD9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFirstTalkNpcCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x000CF811 File Offset: 0x000CDA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFirstTalkNpcCsReq.Descriptor;
			}
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x000CF818 File Offset: 0x000CDA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkNpcCsReq()
		{
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x000CF82B File Offset: 0x000CDA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkNpcCsReq(GetFirstTalkNpcCsReq other) : this()
		{
			this.npcIdList_ = other.npcIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x000CF855 File Offset: 0x000CDA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkNpcCsReq Clone()
		{
			return new GetFirstTalkNpcCsReq(this);
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x000CF85D File Offset: 0x000CDA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NpcIdList
		{
			get
			{
				return this.npcIdList_;
			}
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x000CF865 File Offset: 0x000CDA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFirstTalkNpcCsReq);
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x000CF873 File Offset: 0x000CDA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFirstTalkNpcCsReq other)
		{
			return other != null && (other == this || (this.npcIdList_.Equals(other.npcIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x000CF8A8 File Offset: 0x000CDAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.npcIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x000CF8DC File Offset: 0x000CDADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x000CF8E4 File Offset: 0x000CDAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x000CF8ED File Offset: 0x000CDAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.npcIdList_.WriteTo(ref output, GetFirstTalkNpcCsReq._repeated_npcIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x000CF914 File Offset: 0x000CDB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.npcIdList_.CalculateSize(GetFirstTalkNpcCsReq._repeated_npcIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x000CF94D File Offset: 0x000CDB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFirstTalkNpcCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.npcIdList_.Add(other.npcIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x000CF97B File Offset: 0x000CDB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x000CF984 File Offset: 0x000CDB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.npcIdList_.AddEntriesFrom(ref input, GetFirstTalkNpcCsReq._repeated_npcIdList_codec);
				}
			}
		}

		// Token: 0x04001E45 RID: 7749
		private static readonly MessageParser<GetFirstTalkNpcCsReq> _parser = new MessageParser<GetFirstTalkNpcCsReq>(() => new GetFirstTalkNpcCsReq());

		// Token: 0x04001E46 RID: 7750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E47 RID: 7751
		public const int NpcIdListFieldNumber = 14;

		// Token: 0x04001E48 RID: 7752
		private static readonly FieldCodec<uint> _repeated_npcIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04001E49 RID: 7753
		private readonly RepeatedField<uint> npcIdList_ = new RepeatedField<uint>();
	}
}

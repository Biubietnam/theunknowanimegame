using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001319 RID: 4889
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeQuestRewardCsReq : IMessage<TakeQuestRewardCsReq>, IMessage, IEquatable<TakeQuestRewardCsReq>, IDeepCloneable<TakeQuestRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x0600DA22 RID: 55842 RVA: 0x00245188 File Offset: 0x00243388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeQuestRewardCsReq> Parser
		{
			get
			{
				return TakeQuestRewardCsReq._parser;
			}
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x0600DA23 RID: 55843 RVA: 0x0024518F File Offset: 0x0024338F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeQuestRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x0600DA24 RID: 55844 RVA: 0x002451A1 File Offset: 0x002433A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeQuestRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DA25 RID: 55845 RVA: 0x002451A8 File Offset: 0x002433A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestRewardCsReq()
		{
		}

		// Token: 0x0600DA26 RID: 55846 RVA: 0x002451BB File Offset: 0x002433BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestRewardCsReq(TakeQuestRewardCsReq other) : this()
		{
			this.questIdList_ = other.questIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA27 RID: 55847 RVA: 0x002451E5 File Offset: 0x002433E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestRewardCsReq Clone()
		{
			return new TakeQuestRewardCsReq(this);
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x0600DA28 RID: 55848 RVA: 0x002451ED File Offset: 0x002433ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> QuestIdList
		{
			get
			{
				return this.questIdList_;
			}
		}

		// Token: 0x0600DA29 RID: 55849 RVA: 0x002451F5 File Offset: 0x002433F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeQuestRewardCsReq);
		}

		// Token: 0x0600DA2A RID: 55850 RVA: 0x00245203 File Offset: 0x00243403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeQuestRewardCsReq other)
		{
			return other != null && (other == this || (this.questIdList_.Equals(other.questIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA2B RID: 55851 RVA: 0x00245238 File Offset: 0x00243438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA2C RID: 55852 RVA: 0x0024526C File Offset: 0x0024346C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DA2D RID: 55853 RVA: 0x00245274 File Offset: 0x00243474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA2E RID: 55854 RVA: 0x0024527D File Offset: 0x0024347D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIdList_.WriteTo(ref output, TakeQuestRewardCsReq._repeated_questIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA2F RID: 55855 RVA: 0x002452A4 File Offset: 0x002434A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIdList_.CalculateSize(TakeQuestRewardCsReq._repeated_questIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA30 RID: 55856 RVA: 0x002452DD File Offset: 0x002434DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeQuestRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.questIdList_.Add(other.questIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA31 RID: 55857 RVA: 0x0024530B File Offset: 0x0024350B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA32 RID: 55858 RVA: 0x00245314 File Offset: 0x00243514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIdList_.AddEntriesFrom(ref input, TakeQuestRewardCsReq._repeated_questIdList_codec);
				}
			}
		}

		// Token: 0x040056E2 RID: 22242
		private static readonly MessageParser<TakeQuestRewardCsReq> _parser = new MessageParser<TakeQuestRewardCsReq>(() => new TakeQuestRewardCsReq());

		// Token: 0x040056E3 RID: 22243
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056E4 RID: 22244
		public const int QuestIdListFieldNumber = 5;

		// Token: 0x040056E5 RID: 22245
		private static readonly FieldCodec<uint> _repeated_questIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040056E6 RID: 22246
		private readonly RepeatedField<uint> questIdList_ = new RepeatedField<uint>();
	}
}

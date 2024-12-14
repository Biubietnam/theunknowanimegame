using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D1 RID: 209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BatchGetQuestDataCsReq : IMessage<BatchGetQuestDataCsReq>, IMessage, IEquatable<BatchGetQuestDataCsReq>, IDeepCloneable<BatchGetQuestDataCsReq>, IBufferMessage
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BatchGetQuestDataCsReq> Parser
		{
			get
			{
				return BatchGetQuestDataCsReq._parser;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0001B8AF File Offset: 0x00019AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BatchGetQuestDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0001B8C1 File Offset: 0x00019AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchGetQuestDataCsReq.Descriptor;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchGetQuestDataCsReq()
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0001B8DB File Offset: 0x00019ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchGetQuestDataCsReq(BatchGetQuestDataCsReq other) : this()
		{
			this.questList_ = other.questList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001B905 File Offset: 0x00019B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchGetQuestDataCsReq Clone()
		{
			return new BatchGetQuestDataCsReq(this);
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0001B90D File Offset: 0x00019B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> QuestList
		{
			get
			{
				return this.questList_;
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0001B915 File Offset: 0x00019B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchGetQuestDataCsReq);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0001B923 File Offset: 0x00019B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchGetQuestDataCsReq other)
		{
			return other != null && (other == this || (this.questList_.Equals(other.questList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0001B958 File Offset: 0x00019B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0001B98C File Offset: 0x00019B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0001B994 File Offset: 0x00019B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0001B99D File Offset: 0x00019B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questList_.WriteTo(ref output, BatchGetQuestDataCsReq._repeated_questList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0001B9C4 File Offset: 0x00019BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questList_.CalculateSize(BatchGetQuestDataCsReq._repeated_questList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0001B9FD File Offset: 0x00019BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchGetQuestDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.questList_.Add(other.questList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0001BA2B File Offset: 0x00019C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0001BA34 File Offset: 0x00019C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questList_.AddEntriesFrom(ref input, BatchGetQuestDataCsReq._repeated_questList_codec);
				}
			}
		}

		// Token: 0x040003D0 RID: 976
		private static readonly MessageParser<BatchGetQuestDataCsReq> _parser = new MessageParser<BatchGetQuestDataCsReq>(() => new BatchGetQuestDataCsReq());

		// Token: 0x040003D1 RID: 977
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003D2 RID: 978
		public const int QuestListFieldNumber = 3;

		// Token: 0x040003D3 RID: 979
		private static readonly FieldCodec<uint> _repeated_questList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x040003D4 RID: 980
		private readonly RepeatedField<uint> questList_ = new RepeatedField<uint>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D3 RID: 211
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BatchGetQuestDataScRsp : IMessage<BatchGetQuestDataScRsp>, IMessage, IEquatable<BatchGetQuestDataScRsp>, IDeepCloneable<BatchGetQuestDataScRsp>, IBufferMessage
	{
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0001BB2D File Offset: 0x00019D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BatchGetQuestDataScRsp> Parser
		{
			get
			{
				return BatchGetQuestDataScRsp._parser;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0001BB34 File Offset: 0x00019D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BatchGetQuestDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0001BB46 File Offset: 0x00019D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchGetQuestDataScRsp.Descriptor;
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0001BB4D File Offset: 0x00019D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchGetQuestDataScRsp()
		{
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0001BB60 File Offset: 0x00019D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchGetQuestDataScRsp(BatchGetQuestDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.questList_ = other.questList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0001BB96 File Offset: 0x00019D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchGetQuestDataScRsp Clone()
		{
			return new BatchGetQuestDataScRsp(this);
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0001BB9E File Offset: 0x00019D9E
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x0001BBA6 File Offset: 0x00019DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0001BBAF File Offset: 0x00019DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Quest> QuestList
		{
			get
			{
				return this.questList_;
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0001BBB7 File Offset: 0x00019DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchGetQuestDataScRsp);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0001BBC8 File Offset: 0x00019DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchGetQuestDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.questList_.Equals(other.questList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0001BC18 File Offset: 0x00019E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.questList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0001BC65 File Offset: 0x00019E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0001BC6D File Offset: 0x00019E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0001BC78 File Offset: 0x00019E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.questList_.WriteTo(ref output, BatchGetQuestDataScRsp._repeated_questList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0001BCC8 File Offset: 0x00019EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.questList_.CalculateSize(BatchGetQuestDataScRsp._repeated_questList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0001BD1C File Offset: 0x00019F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchGetQuestDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.questList_.Add(other.questList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0001BD69 File Offset: 0x00019F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0001BD74 File Offset: 0x00019F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.questList_.AddEntriesFrom(ref input, BatchGetQuestDataScRsp._repeated_questList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040003D6 RID: 982
		private static readonly MessageParser<BatchGetQuestDataScRsp> _parser = new MessageParser<BatchGetQuestDataScRsp>(() => new BatchGetQuestDataScRsp());

		// Token: 0x040003D7 RID: 983
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003D8 RID: 984
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040003D9 RID: 985
		private uint retcode_;

		// Token: 0x040003DA RID: 986
		public const int QuestListFieldNumber = 13;

		// Token: 0x040003DB RID: 987
		private static readonly FieldCodec<Quest> _repeated_questList_codec = FieldCodec.ForMessage<Quest>(106U, Quest.Parser);

		// Token: 0x040003DC RID: 988
		private readonly RepeatedField<Quest> questList_ = new RepeatedField<Quest>();
	}
}

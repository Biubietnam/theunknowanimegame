using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200027F RID: 639
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQuestFinishNotify : IMessage<ChessRogueQuestFinishNotify>, IMessage, IEquatable<ChessRogueQuestFinishNotify>, IDeepCloneable<ChessRogueQuestFinishNotify>, IBufferMessage
	{
		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00051E89 File Offset: 0x00050089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQuestFinishNotify> Parser
		{
			get
			{
				return ChessRogueQuestFinishNotify._parser;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00051E90 File Offset: 0x00050090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQuestFinishNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00051EA2 File Offset: 0x000500A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQuestFinishNotify.Descriptor;
			}
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00051EA9 File Offset: 0x000500A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuestFinishNotify()
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00051EB1 File Offset: 0x000500B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuestFinishNotify(ChessRogueQuestFinishNotify other) : this()
		{
			this.kFIBCFJMADF_ = other.kFIBCFJMADF_;
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00051EE2 File Offset: 0x000500E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuestFinishNotify Clone()
		{
			return new ChessRogueQuestFinishNotify(this);
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00051EEA File Offset: 0x000500EA
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x00051EF2 File Offset: 0x000500F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KFIBCFJMADF
		{
			get
			{
				return this.kFIBCFJMADF_;
			}
			set
			{
				this.kFIBCFJMADF_ = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x00051EFB File Offset: 0x000500FB
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x00051F03 File Offset: 0x00050103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00051F0C File Offset: 0x0005010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQuestFinishNotify);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00051F1A File Offset: 0x0005011A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQuestFinishNotify other)
		{
			return other != null && (other == this || (this.KFIBCFJMADF == other.KFIBCFJMADF && this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00051F58 File Offset: 0x00050158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KFIBCFJMADF != 0U)
			{
				num ^= this.KFIBCFJMADF.GetHashCode();
			}
			if (this.QuestId != 0U)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00051FB0 File Offset: 0x000501B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00051FB8 File Offset: 0x000501B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00051FC4 File Offset: 0x000501C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.QuestId);
			}
			if (this.KFIBCFJMADF != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.KFIBCFJMADF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00052020 File Offset: 0x00050220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KFIBCFJMADF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KFIBCFJMADF);
			}
			if (this.QuestId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00052078 File Offset: 0x00050278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQuestFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KFIBCFJMADF != 0U)
			{
				this.KFIBCFJMADF = other.KFIBCFJMADF;
			}
			if (other.QuestId != 0U)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x000520C8 File Offset: 0x000502C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x000520D4 File Offset: 0x000502D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.KFIBCFJMADF = input.ReadUInt32();
					}
				}
				else
				{
					this.QuestId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000BF1 RID: 3057
		private static readonly MessageParser<ChessRogueQuestFinishNotify> _parser = new MessageParser<ChessRogueQuestFinishNotify>(() => new ChessRogueQuestFinishNotify());

		// Token: 0x04000BF2 RID: 3058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BF3 RID: 3059
		public const int KFIBCFJMADFFieldNumber = 15;

		// Token: 0x04000BF4 RID: 3060
		private uint kFIBCFJMADF_;

		// Token: 0x04000BF5 RID: 3061
		public const int QuestIdFieldNumber = 10;

		// Token: 0x04000BF6 RID: 3062
		private uint questId_;
	}
}

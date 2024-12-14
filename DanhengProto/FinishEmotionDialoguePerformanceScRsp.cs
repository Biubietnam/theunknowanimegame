using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000579 RID: 1401
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishEmotionDialoguePerformanceScRsp : IMessage<FinishEmotionDialoguePerformanceScRsp>, IMessage, IEquatable<FinishEmotionDialoguePerformanceScRsp>, IDeepCloneable<FinishEmotionDialoguePerformanceScRsp>, IBufferMessage
	{
		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06003E80 RID: 16000 RVA: 0x000AADC3 File Offset: 0x000A8FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishEmotionDialoguePerformanceScRsp> Parser
		{
			get
			{
				return FinishEmotionDialoguePerformanceScRsp._parser;
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06003E81 RID: 16001 RVA: 0x000AADCA File Offset: 0x000A8FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishEmotionDialoguePerformanceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06003E82 RID: 16002 RVA: 0x000AADDC File Offset: 0x000A8FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishEmotionDialoguePerformanceScRsp.Descriptor;
			}
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x000AADE3 File Offset: 0x000A8FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishEmotionDialoguePerformanceScRsp()
		{
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x000AADEC File Offset: 0x000A8FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishEmotionDialoguePerformanceScRsp(FinishEmotionDialoguePerformanceScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.dialogueId_ = other.dialogueId_;
			this.scriptId_ = other.scriptId_;
			this.rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x000AAE50 File Offset: 0x000A9050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishEmotionDialoguePerformanceScRsp Clone()
		{
			return new FinishEmotionDialoguePerformanceScRsp(this);
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06003E86 RID: 16006 RVA: 0x000AAE58 File Offset: 0x000A9058
		// (set) Token: 0x06003E87 RID: 16007 RVA: 0x000AAE60 File Offset: 0x000A9060
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

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06003E88 RID: 16008 RVA: 0x000AAE69 File Offset: 0x000A9069
		// (set) Token: 0x06003E89 RID: 16009 RVA: 0x000AAE71 File Offset: 0x000A9071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DialogueId
		{
			get
			{
				return this.dialogueId_;
			}
			set
			{
				this.dialogueId_ = value;
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06003E8A RID: 16010 RVA: 0x000AAE7A File Offset: 0x000A907A
		// (set) Token: 0x06003E8B RID: 16011 RVA: 0x000AAE82 File Offset: 0x000A9082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06003E8C RID: 16012 RVA: 0x000AAE8B File Offset: 0x000A908B
		// (set) Token: 0x06003E8D RID: 16013 RVA: 0x000AAE93 File Offset: 0x000A9093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList RewardList
		{
			get
			{
				return this.rewardList_;
			}
			set
			{
				this.rewardList_ = value;
			}
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x000AAE9C File Offset: 0x000A909C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishEmotionDialoguePerformanceScRsp);
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x000AAEAC File Offset: 0x000A90AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishEmotionDialoguePerformanceScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.DialogueId == other.DialogueId && this.ScriptId == other.ScriptId && object.Equals(this.RewardList, other.RewardList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x000AAF1C File Offset: 0x000A911C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.DialogueId != 0U)
			{
				num ^= this.DialogueId.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.rewardList_ != null)
			{
				num ^= this.RewardList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x000AAFA3 File Offset: 0x000A91A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x000AAFAB File Offset: 0x000A91AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x000AAFB4 File Offset: 0x000A91B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rewardList_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RewardList);
			}
			if (this.DialogueId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DialogueId);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x000AB044 File Offset: 0x000A9244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.DialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DialogueId);
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this.rewardList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x000AB0CC File Offset: 0x000A92CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishEmotionDialoguePerformanceScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.DialogueId != 0U)
			{
				this.DialogueId = other.DialogueId;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.rewardList_ != null)
			{
				if (this.rewardList_ == null)
				{
					this.RewardList = new ItemList();
				}
				this.RewardList.MergeFrom(other.RewardList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x000AB15C File Offset: 0x000A935C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x000AB168 File Offset: 0x000A9368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						if (this.rewardList_ == null)
						{
							this.RewardList = new ItemList();
						}
						input.ReadMessage(this.RewardList);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.DialogueId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ScriptId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040018F1 RID: 6385
		private static readonly MessageParser<FinishEmotionDialoguePerformanceScRsp> _parser = new MessageParser<FinishEmotionDialoguePerformanceScRsp>(() => new FinishEmotionDialoguePerformanceScRsp());

		// Token: 0x040018F2 RID: 6386
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018F3 RID: 6387
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040018F4 RID: 6388
		private uint retcode_;

		// Token: 0x040018F5 RID: 6389
		public const int DialogueIdFieldNumber = 11;

		// Token: 0x040018F6 RID: 6390
		private uint dialogueId_;

		// Token: 0x040018F7 RID: 6391
		public const int ScriptIdFieldNumber = 12;

		// Token: 0x040018F8 RID: 6392
		private uint scriptId_;

		// Token: 0x040018F9 RID: 6393
		public const int RewardListFieldNumber = 6;

		// Token: 0x040018FA RID: 6394
		private ItemList rewardList_;
	}
}

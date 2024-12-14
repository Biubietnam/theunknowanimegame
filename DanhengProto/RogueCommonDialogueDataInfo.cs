using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E43 RID: 3651
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonDialogueDataInfo : IMessage<RogueCommonDialogueDataInfo>, IMessage, IEquatable<RogueCommonDialogueDataInfo>, IDeepCloneable<RogueCommonDialogueDataInfo>, IBufferMessage
	{
		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0600A2D5 RID: 41685 RVA: 0x001B5F3F File Offset: 0x001B413F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonDialogueDataInfo> Parser
		{
			get
			{
				return RogueCommonDialogueDataInfo._parser;
			}
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0600A2D6 RID: 41686 RVA: 0x001B5F46 File Offset: 0x001B4146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueDataInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x001B5F58 File Offset: 0x001B4158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonDialogueDataInfo.Descriptor;
			}
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x001B5F5F File Offset: 0x001B415F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueDataInfo()
		{
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x001B5F74 File Offset: 0x001B4174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueDataInfo(RogueCommonDialogueDataInfo other) : this()
		{
			this.eventUniqueId_ = other.eventUniqueId_;
			this.dialogueInfo_ = ((other.dialogueInfo_ != null) ? other.dialogueInfo_.Clone() : null);
			this.optionList_ = other.optionList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x001B5FD1 File Offset: 0x001B41D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueDataInfo Clone()
		{
			return new RogueCommonDialogueDataInfo(this);
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0600A2DB RID: 41691 RVA: 0x001B5FD9 File Offset: 0x001B41D9
		// (set) Token: 0x0600A2DC RID: 41692 RVA: 0x001B5FE1 File Offset: 0x001B41E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventUniqueId
		{
			get
			{
				return this.eventUniqueId_;
			}
			set
			{
				this.eventUniqueId_ = value;
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0600A2DD RID: 41693 RVA: 0x001B5FEA File Offset: 0x001B41EA
		// (set) Token: 0x0600A2DE RID: 41694 RVA: 0x001B5FF2 File Offset: 0x001B41F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueInfo DialogueInfo
		{
			get
			{
				return this.dialogueInfo_;
			}
			set
			{
				this.dialogueInfo_ = value;
			}
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0600A2DF RID: 41695 RVA: 0x001B5FFB File Offset: 0x001B41FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonDialogueOptionInfo> OptionList
		{
			get
			{
				return this.optionList_;
			}
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x001B6003 File Offset: 0x001B4203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonDialogueDataInfo);
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x001B6014 File Offset: 0x001B4214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonDialogueDataInfo other)
		{
			return other != null && (other == this || (this.EventUniqueId == other.EventUniqueId && object.Equals(this.DialogueInfo, other.DialogueInfo) && this.optionList_.Equals(other.optionList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x001B6078 File Offset: 0x001B4278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this.dialogueInfo_ != null)
			{
				num ^= this.DialogueInfo.GetHashCode();
			}
			num ^= this.optionList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x001B60DB File Offset: 0x001B42DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x001B60E3 File Offset: 0x001B42E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x001B60EC File Offset: 0x001B42EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this.dialogueInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.DialogueInfo);
			}
			this.optionList_.WriteTo(ref output, RogueCommonDialogueDataInfo._repeated_optionList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x001B6158 File Offset: 0x001B4358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this.dialogueInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DialogueInfo);
			}
			num += this.optionList_.CalculateSize(RogueCommonDialogueDataInfo._repeated_optionList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x001B61C4 File Offset: 0x001B43C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonDialogueDataInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			if (other.dialogueInfo_ != null)
			{
				if (this.dialogueInfo_ == null)
				{
					this.DialogueInfo = new RogueCommonDialogueInfo();
				}
				this.DialogueInfo.MergeFrom(other.DialogueInfo);
			}
			this.optionList_.Add(other.optionList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x001B623D File Offset: 0x001B443D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x001B6248 File Offset: 0x001B4448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 82U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.optionList_.AddEntriesFrom(ref input, RogueCommonDialogueDataInfo._repeated_optionList_codec);
						}
					}
					else
					{
						if (this.dialogueInfo_ == null)
						{
							this.DialogueInfo = new RogueCommonDialogueInfo();
						}
						input.ReadMessage(this.DialogueInfo);
					}
				}
				else
				{
					this.EventUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040042B3 RID: 17075
		private static readonly MessageParser<RogueCommonDialogueDataInfo> _parser = new MessageParser<RogueCommonDialogueDataInfo>(() => new RogueCommonDialogueDataInfo());

		// Token: 0x040042B4 RID: 17076
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042B5 RID: 17077
		public const int EventUniqueIdFieldNumber = 1;

		// Token: 0x040042B6 RID: 17078
		private uint eventUniqueId_;

		// Token: 0x040042B7 RID: 17079
		public const int DialogueInfoFieldNumber = 10;

		// Token: 0x040042B8 RID: 17080
		private RogueCommonDialogueInfo dialogueInfo_;

		// Token: 0x040042B9 RID: 17081
		public const int OptionListFieldNumber = 14;

		// Token: 0x040042BA RID: 17082
		private static readonly FieldCodec<RogueCommonDialogueOptionInfo> _repeated_optionList_codec = FieldCodec.ForMessage<RogueCommonDialogueOptionInfo>(114U, RogueCommonDialogueOptionInfo.Parser);

		// Token: 0x040042BB RID: 17083
		private readonly RepeatedField<RogueCommonDialogueOptionInfo> optionList_ = new RepeatedField<RogueCommonDialogueOptionInfo>();
	}
}

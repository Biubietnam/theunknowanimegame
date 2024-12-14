using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010B5 RID: 4277
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectRogueCommonDialogueOptionScRsp : IMessage<SelectRogueCommonDialogueOptionScRsp>, IMessage, IEquatable<SelectRogueCommonDialogueOptionScRsp>, IDeepCloneable<SelectRogueCommonDialogueOptionScRsp>, IBufferMessage
	{
		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600BEB0 RID: 48816 RVA: 0x002018A3 File Offset: 0x001FFAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectRogueCommonDialogueOptionScRsp> Parser
		{
			get
			{
				return SelectRogueCommonDialogueOptionScRsp._parser;
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600BEB1 RID: 48817 RVA: 0x002018AA File Offset: 0x001FFAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectRogueCommonDialogueOptionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600BEB2 RID: 48818 RVA: 0x002018BC File Offset: 0x001FFABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectRogueCommonDialogueOptionScRsp.Descriptor;
			}
		}

		// Token: 0x0600BEB3 RID: 48819 RVA: 0x002018C3 File Offset: 0x001FFAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectRogueCommonDialogueOptionScRsp()
		{
		}

		// Token: 0x0600BEB4 RID: 48820 RVA: 0x002018D8 File Offset: 0x001FFAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectRogueCommonDialogueOptionScRsp(SelectRogueCommonDialogueOptionScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.optionId_ = other.optionId_;
			this.effectEventIdList_ = other.effectEventIdList_.Clone();
			this.eventUniqueId_ = other.eventUniqueId_;
			this.eventHasEffect_ = other.eventHasEffect_;
			this.dialogueData_ = ((other.dialogueData_ != null) ? other.dialogueData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BEB5 RID: 48821 RVA: 0x00201959 File Offset: 0x001FFB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectRogueCommonDialogueOptionScRsp Clone()
		{
			return new SelectRogueCommonDialogueOptionScRsp(this);
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600BEB6 RID: 48822 RVA: 0x00201961 File Offset: 0x001FFB61
		// (set) Token: 0x0600BEB7 RID: 48823 RVA: 0x00201969 File Offset: 0x001FFB69
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

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600BEB8 RID: 48824 RVA: 0x00201972 File Offset: 0x001FFB72
		// (set) Token: 0x0600BEB9 RID: 48825 RVA: 0x0020197A File Offset: 0x001FFB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionId
		{
			get
			{
				return this.optionId_;
			}
			set
			{
				this.optionId_ = value;
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600BEBA RID: 48826 RVA: 0x00201983 File Offset: 0x001FFB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EffectEventIdList
		{
			get
			{
				return this.effectEventIdList_;
			}
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600BEBB RID: 48827 RVA: 0x0020198B File Offset: 0x001FFB8B
		// (set) Token: 0x0600BEBC RID: 48828 RVA: 0x00201993 File Offset: 0x001FFB93
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

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600BEBD RID: 48829 RVA: 0x0020199C File Offset: 0x001FFB9C
		// (set) Token: 0x0600BEBE RID: 48830 RVA: 0x002019A4 File Offset: 0x001FFBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EventHasEffect
		{
			get
			{
				return this.eventHasEffect_;
			}
			set
			{
				this.eventHasEffect_ = value;
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600BEBF RID: 48831 RVA: 0x002019AD File Offset: 0x001FFBAD
		// (set) Token: 0x0600BEC0 RID: 48832 RVA: 0x002019B5 File Offset: 0x001FFBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueDataInfo DialogueData
		{
			get
			{
				return this.dialogueData_;
			}
			set
			{
				this.dialogueData_ = value;
			}
		}

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x002019BE File Offset: 0x001FFBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectRogueCommonDialogueOptionScRsp);
		}

		// Token: 0x0600BEC2 RID: 48834 RVA: 0x002019CC File Offset: 0x001FFBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectRogueCommonDialogueOptionScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.OptionId == other.OptionId && this.effectEventIdList_.Equals(other.effectEventIdList_) && this.EventUniqueId == other.EventUniqueId && this.EventHasEffect == other.EventHasEffect && object.Equals(this.DialogueData, other.DialogueData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEC3 RID: 48835 RVA: 0x00201A60 File Offset: 0x001FFC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.OptionId != 0U)
			{
				num ^= this.OptionId.GetHashCode();
			}
			num ^= this.effectEventIdList_.GetHashCode();
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this.EventHasEffect)
			{
				num ^= this.EventHasEffect.GetHashCode();
			}
			if (this.dialogueData_ != null)
			{
				num ^= this.DialogueData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BEC4 RID: 48836 RVA: 0x00201B0E File Offset: 0x001FFD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BEC5 RID: 48837 RVA: 0x00201B16 File Offset: 0x001FFD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x00201B20 File Offset: 0x001FFD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this.EventHasEffect)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.EventHasEffect);
			}
			if (this.dialogueData_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.DialogueData);
			}
			this.effectEventIdList_.WriteTo(ref output, SelectRogueCommonDialogueOptionScRsp._repeated_effectEventIdList_codec);
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.OptionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEC7 RID: 48839 RVA: 0x00201BE0 File Offset: 0x001FFDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.OptionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionId);
			}
			num += this.effectEventIdList_.CalculateSize(SelectRogueCommonDialogueOptionScRsp._repeated_effectEventIdList_codec);
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this.EventHasEffect)
			{
				num += 2;
			}
			if (this.dialogueData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DialogueData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BEC8 RID: 48840 RVA: 0x00201C88 File Offset: 0x001FFE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectRogueCommonDialogueOptionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			this.effectEventIdList_.Add(other.effectEventIdList_);
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			if (other.EventHasEffect)
			{
				this.EventHasEffect = other.EventHasEffect;
			}
			if (other.dialogueData_ != null)
			{
				if (this.dialogueData_ == null)
				{
					this.DialogueData = new RogueCommonDialogueDataInfo();
				}
				this.DialogueData.MergeFrom(other.DialogueData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BEC9 RID: 48841 RVA: 0x00201D3D File Offset: 0x001FFF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BECA RID: 48842 RVA: 0x00201D48 File Offset: 0x001FFF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 56U)
				{
					if (num <= 88U)
					{
						if (num == 82U)
						{
							if (this.dialogueData_ == null)
							{
								this.DialogueData = new RogueCommonDialogueDataInfo();
							}
							input.ReadMessage(this.DialogueData);
							continue;
						}
						if (num != 88U)
						{
							goto IL_35;
						}
					}
					else if (num != 90U)
					{
						if (num != 112U)
						{
							goto IL_35;
						}
						this.OptionId = input.ReadUInt32();
						continue;
					}
					this.effectEventIdList_.AddEntriesFrom(ref input, SelectRogueCommonDialogueOptionScRsp._repeated_effectEventIdList_codec);
					continue;
				}
				if (num == 8U)
				{
					this.Retcode = input.ReadUInt32();
					continue;
				}
				if (num == 24U)
				{
					this.EventUniqueId = input.ReadUInt32();
					continue;
				}
				if (num == 56U)
				{
					this.EventHasEffect = input.ReadBool();
					continue;
				}
				IL_35:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D73 RID: 19827
		private static readonly MessageParser<SelectRogueCommonDialogueOptionScRsp> _parser = new MessageParser<SelectRogueCommonDialogueOptionScRsp>(() => new SelectRogueCommonDialogueOptionScRsp());

		// Token: 0x04004D74 RID: 19828
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D75 RID: 19829
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04004D76 RID: 19830
		private uint retcode_;

		// Token: 0x04004D77 RID: 19831
		public const int OptionIdFieldNumber = 14;

		// Token: 0x04004D78 RID: 19832
		private uint optionId_;

		// Token: 0x04004D79 RID: 19833
		public const int EffectEventIdListFieldNumber = 11;

		// Token: 0x04004D7A RID: 19834
		private static readonly FieldCodec<uint> _repeated_effectEventIdList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04004D7B RID: 19835
		private readonly RepeatedField<uint> effectEventIdList_ = new RepeatedField<uint>();

		// Token: 0x04004D7C RID: 19836
		public const int EventUniqueIdFieldNumber = 3;

		// Token: 0x04004D7D RID: 19837
		private uint eventUniqueId_;

		// Token: 0x04004D7E RID: 19838
		public const int EventHasEffectFieldNumber = 7;

		// Token: 0x04004D7F RID: 19839
		private bool eventHasEffect_;

		// Token: 0x04004D80 RID: 19840
		public const int DialogueDataFieldNumber = 10;

		// Token: 0x04004D81 RID: 19841
		private RogueCommonDialogueDataInfo dialogueData_;
	}
}

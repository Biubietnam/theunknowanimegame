using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E4B RID: 3659
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonDialogueOptionInfo : IMessage<RogueCommonDialogueOptionInfo>, IMessage, IEquatable<RogueCommonDialogueOptionInfo>, IDeepCloneable<RogueCommonDialogueOptionInfo>, IBufferMessage
	{
		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0600A338 RID: 41784 RVA: 0x001B71A4 File Offset: 0x001B53A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonDialogueOptionInfo> Parser
		{
			get
			{
				return RogueCommonDialogueOptionInfo._parser;
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0600A339 RID: 41785 RVA: 0x001B71AB File Offset: 0x001B53AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x0600A33A RID: 41786 RVA: 0x001B71BD File Offset: 0x001B53BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionInfo.Descriptor;
			}
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x001B71C4 File Offset: 0x001B53C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionInfo()
		{
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x001B71D8 File Offset: 0x001B53D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionInfo(RogueCommonDialogueOptionInfo other) : this()
		{
			this.optionId_ = other.optionId_;
			this.argId_ = other.argId_;
			this.isValid_ = other.isValid_;
			this.displayValue_ = ((other.displayValue_ != null) ? other.displayValue_.Clone() : null);
			this.optionResultInfo_ = other.optionResultInfo_.Clone();
			this.confirm_ = other.confirm_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x001B7259 File Offset: 0x001B5459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionInfo Clone()
		{
			return new RogueCommonDialogueOptionInfo(this);
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0600A33E RID: 41790 RVA: 0x001B7261 File Offset: 0x001B5461
		// (set) Token: 0x0600A33F RID: 41791 RVA: 0x001B7269 File Offset: 0x001B5469
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

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600A340 RID: 41792 RVA: 0x001B7272 File Offset: 0x001B5472
		// (set) Token: 0x0600A341 RID: 41793 RVA: 0x001B727A File Offset: 0x001B547A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ArgId
		{
			get
			{
				return this.argId_;
			}
			set
			{
				this.argId_ = value;
			}
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0600A342 RID: 41794 RVA: 0x001B7283 File Offset: 0x001B5483
		// (set) Token: 0x0600A343 RID: 41795 RVA: 0x001B728B File Offset: 0x001B548B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsValid
		{
			get
			{
				return this.isValid_;
			}
			set
			{
				this.isValid_ = value;
			}
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0600A344 RID: 41796 RVA: 0x001B7294 File Offset: 0x001B5494
		// (set) Token: 0x0600A345 RID: 41797 RVA: 0x001B729C File Offset: 0x001B549C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionDisplayInfo DisplayValue
		{
			get
			{
				return this.displayValue_;
			}
			set
			{
				this.displayValue_ = value;
			}
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0600A346 RID: 41798 RVA: 0x001B72A5 File Offset: 0x001B54A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonDialogueOptionResultInfo> OptionResultInfo
		{
			get
			{
				return this.optionResultInfo_;
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600A347 RID: 41799 RVA: 0x001B72AD File Offset: 0x001B54AD
		// (set) Token: 0x0600A348 RID: 41800 RVA: 0x001B72B5 File Offset: 0x001B54B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Confirm
		{
			get
			{
				return this.confirm_;
			}
			set
			{
				this.confirm_ = value;
			}
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x001B72BE File Offset: 0x001B54BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonDialogueOptionInfo);
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x001B72CC File Offset: 0x001B54CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonDialogueOptionInfo other)
		{
			return other != null && (other == this || (this.OptionId == other.OptionId && this.ArgId == other.ArgId && this.IsValid == other.IsValid && object.Equals(this.DisplayValue, other.DisplayValue) && this.optionResultInfo_.Equals(other.optionResultInfo_) && this.Confirm == other.Confirm && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x001B7360 File Offset: 0x001B5560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OptionId != 0U)
			{
				num ^= this.OptionId.GetHashCode();
			}
			if (this.ArgId != 0U)
			{
				num ^= this.ArgId.GetHashCode();
			}
			if (this.IsValid)
			{
				num ^= this.IsValid.GetHashCode();
			}
			if (this.displayValue_ != null)
			{
				num ^= this.DisplayValue.GetHashCode();
			}
			num ^= this.optionResultInfo_.GetHashCode();
			if (this.Confirm)
			{
				num ^= this.Confirm.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x001B740E File Offset: 0x001B560E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x001B7416 File Offset: 0x001B5616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x001B7420 File Offset: 0x001B5620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.optionResultInfo_.WriteTo(ref output, RogueCommonDialogueOptionInfo._repeated_optionResultInfo_codec);
			if (this.Confirm)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Confirm);
			}
			if (this.IsValid)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsValid);
			}
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.OptionId);
			}
			if (this.ArgId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ArgId);
			}
			if (this.displayValue_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.DisplayValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x001B74E0 File Offset: 0x001B56E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OptionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionId);
			}
			if (this.ArgId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ArgId);
			}
			if (this.IsValid)
			{
				num += 2;
			}
			if (this.displayValue_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DisplayValue);
			}
			num += this.optionResultInfo_.CalculateSize(RogueCommonDialogueOptionInfo._repeated_optionResultInfo_codec);
			if (this.Confirm)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x001B757C File Offset: 0x001B577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonDialogueOptionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			if (other.ArgId != 0U)
			{
				this.ArgId = other.ArgId;
			}
			if (other.IsValid)
			{
				this.IsValid = other.IsValid;
			}
			if (other.displayValue_ != null)
			{
				if (this.displayValue_ == null)
				{
					this.DisplayValue = new RogueCommonDialogueOptionDisplayInfo();
				}
				this.DisplayValue.MergeFrom(other.DisplayValue);
			}
			this.optionResultInfo_.Add(other.optionResultInfo_);
			if (other.Confirm)
			{
				this.Confirm = other.Confirm;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x001B7631 File Offset: 0x001B5831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x001B763C File Offset: 0x001B583C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 34U)
					{
						this.optionResultInfo_.AddEntriesFrom(ref input, RogueCommonDialogueOptionInfo._repeated_optionResultInfo_codec);
						continue;
					}
					if (num == 40U)
					{
						this.Confirm = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.IsValid = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.OptionId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ArgId = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						if (this.displayValue_ == null)
						{
							this.DisplayValue = new RogueCommonDialogueOptionDisplayInfo();
						}
						input.ReadMessage(this.DisplayValue);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042D8 RID: 17112
		private static readonly MessageParser<RogueCommonDialogueOptionInfo> _parser = new MessageParser<RogueCommonDialogueOptionInfo>(() => new RogueCommonDialogueOptionInfo());

		// Token: 0x040042D9 RID: 17113
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042DA RID: 17114
		public const int OptionIdFieldNumber = 7;

		// Token: 0x040042DB RID: 17115
		private uint optionId_;

		// Token: 0x040042DC RID: 17116
		public const int ArgIdFieldNumber = 8;

		// Token: 0x040042DD RID: 17117
		private uint argId_;

		// Token: 0x040042DE RID: 17118
		public const int IsValidFieldNumber = 6;

		// Token: 0x040042DF RID: 17119
		private bool isValid_;

		// Token: 0x040042E0 RID: 17120
		public const int DisplayValueFieldNumber = 9;

		// Token: 0x040042E1 RID: 17121
		private RogueCommonDialogueOptionDisplayInfo displayValue_;

		// Token: 0x040042E2 RID: 17122
		public const int OptionResultInfoFieldNumber = 4;

		// Token: 0x040042E3 RID: 17123
		private static readonly FieldCodec<RogueCommonDialogueOptionResultInfo> _repeated_optionResultInfo_codec = FieldCodec.ForMessage<RogueCommonDialogueOptionResultInfo>(34U, RogueCommonDialogueOptionResultInfo.Parser);

		// Token: 0x040042E4 RID: 17124
		private readonly RepeatedField<RogueCommonDialogueOptionResultInfo> optionResultInfo_ = new RepeatedField<RogueCommonDialogueOptionResultInfo>();

		// Token: 0x040042E5 RID: 17125
		public const int ConfirmFieldNumber = 5;

		// Token: 0x040042E6 RID: 17126
		private bool confirm_;
	}
}

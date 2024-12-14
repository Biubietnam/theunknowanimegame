using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005A3 RID: 1443
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishTutorialGuideScRsp : IMessage<FinishTutorialGuideScRsp>, IMessage, IEquatable<FinishTutorialGuideScRsp>, IDeepCloneable<FinishTutorialGuideScRsp>, IBufferMessage
	{
		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06004065 RID: 16485 RVA: 0x000AF56B File Offset: 0x000AD76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishTutorialGuideScRsp> Parser
		{
			get
			{
				return FinishTutorialGuideScRsp._parser;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x000AF572 File Offset: 0x000AD772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishTutorialGuideScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x000AF584 File Offset: 0x000AD784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishTutorialGuideScRsp.Descriptor;
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x000AF58B File Offset: 0x000AD78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialGuideScRsp()
		{
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x000AF594 File Offset: 0x000AD794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialGuideScRsp(FinishTutorialGuideScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.tutorialGuide_ = ((other.tutorialGuide_ != null) ? other.tutorialGuide_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x000AF5FC File Offset: 0x000AD7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialGuideScRsp Clone()
		{
			return new FinishTutorialGuideScRsp(this);
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x000AF604 File Offset: 0x000AD804
		// (set) Token: 0x0600406C RID: 16492 RVA: 0x000AF60C File Offset: 0x000AD80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x000AF615 File Offset: 0x000AD815
		// (set) Token: 0x0600406E RID: 16494 RVA: 0x000AF61D File Offset: 0x000AD81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialGuide TutorialGuide
		{
			get
			{
				return this.tutorialGuide_;
			}
			set
			{
				this.tutorialGuide_ = value;
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x000AF626 File Offset: 0x000AD826
		// (set) Token: 0x06004070 RID: 16496 RVA: 0x000AF62E File Offset: 0x000AD82E
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

		// Token: 0x06004071 RID: 16497 RVA: 0x000AF637 File Offset: 0x000AD837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishTutorialGuideScRsp);
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x000AF648 File Offset: 0x000AD848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishTutorialGuideScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && object.Equals(this.TutorialGuide, other.TutorialGuide) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x000AF6AC File Offset: 0x000AD8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.tutorialGuide_ != null)
			{
				num ^= this.TutorialGuide.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x000AF717 File Offset: 0x000AD917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x000AF71F File Offset: 0x000AD91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x000AF728 File Offset: 0x000AD928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.tutorialGuide_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TutorialGuide);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x000AF7A0 File Offset: 0x000AD9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.tutorialGuide_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TutorialGuide);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x000AF810 File Offset: 0x000ADA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishTutorialGuideScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.tutorialGuide_ != null)
			{
				if (this.tutorialGuide_ == null)
				{
					this.TutorialGuide = new TutorialGuide();
				}
				this.TutorialGuide.MergeFrom(other.TutorialGuide);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x000AF8A4 File Offset: 0x000ADAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x000AF8B0 File Offset: 0x000ADAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 88U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.reward_ == null)
							{
								this.Reward = new ItemList();
							}
							input.ReadMessage(this.Reward);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.tutorialGuide_ == null)
					{
						this.TutorialGuide = new TutorialGuide();
					}
					input.ReadMessage(this.TutorialGuide);
				}
			}
		}

		// Token: 0x0400198E RID: 6542
		private static readonly MessageParser<FinishTutorialGuideScRsp> _parser = new MessageParser<FinishTutorialGuideScRsp>(() => new FinishTutorialGuideScRsp());

		// Token: 0x0400198F RID: 6543
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001990 RID: 6544
		public const int RewardFieldNumber = 13;

		// Token: 0x04001991 RID: 6545
		private ItemList reward_;

		// Token: 0x04001992 RID: 6546
		public const int TutorialGuideFieldNumber = 9;

		// Token: 0x04001993 RID: 6547
		private TutorialGuide tutorialGuide_;

		// Token: 0x04001994 RID: 6548
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001995 RID: 6549
		private uint retcode_;
	}
}

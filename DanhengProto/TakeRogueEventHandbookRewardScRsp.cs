using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200132B RID: 4907
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueEventHandbookRewardScRsp : IMessage<TakeRogueEventHandbookRewardScRsp>, IMessage, IEquatable<TakeRogueEventHandbookRewardScRsp>, IDeepCloneable<TakeRogueEventHandbookRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x0600DAF6 RID: 56054 RVA: 0x002473A3 File Offset: 0x002455A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueEventHandbookRewardScRsp> Parser
		{
			get
			{
				return TakeRogueEventHandbookRewardScRsp._parser;
			}
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x0600DAF7 RID: 56055 RVA: 0x002473AA File Offset: 0x002455AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueEventHandbookRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x0600DAF8 RID: 56056 RVA: 0x002473BC File Offset: 0x002455BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueEventHandbookRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DAF9 RID: 56057 RVA: 0x002473C3 File Offset: 0x002455C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEventHandbookRewardScRsp()
		{
		}

		// Token: 0x0600DAFA RID: 56058 RVA: 0x002473D8 File Offset: 0x002455D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEventHandbookRewardScRsp(TakeRogueEventHandbookRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.dPOAHKMLAKK_ = other.dPOAHKMLAKK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DAFB RID: 56059 RVA: 0x00247435 File Offset: 0x00245635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEventHandbookRewardScRsp Clone()
		{
			return new TakeRogueEventHandbookRewardScRsp(this);
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x0600DAFC RID: 56060 RVA: 0x0024743D File Offset: 0x0024563D
		// (set) Token: 0x0600DAFD RID: 56061 RVA: 0x00247445 File Offset: 0x00245645
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

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x0600DAFE RID: 56062 RVA: 0x0024744E File Offset: 0x0024564E
		// (set) Token: 0x0600DAFF RID: 56063 RVA: 0x00247456 File Offset: 0x00245656
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

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x0600DB00 RID: 56064 RVA: 0x0024745F File Offset: 0x0024565F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DPOAHKMLAKK
		{
			get
			{
				return this.dPOAHKMLAKK_;
			}
		}

		// Token: 0x0600DB01 RID: 56065 RVA: 0x00247467 File Offset: 0x00245667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueEventHandbookRewardScRsp);
		}

		// Token: 0x0600DB02 RID: 56066 RVA: 0x00247478 File Offset: 0x00245678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueEventHandbookRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && this.dPOAHKMLAKK_.Equals(other.dPOAHKMLAKK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB03 RID: 56067 RVA: 0x002474DC File Offset: 0x002456DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			num ^= this.dPOAHKMLAKK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB04 RID: 56068 RVA: 0x0024753F File Offset: 0x0024573F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x00247547 File Offset: 0x00245747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB06 RID: 56070 RVA: 0x00247550 File Offset: 0x00245750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dPOAHKMLAKK_.WriteTo(ref output, TakeRogueEventHandbookRewardScRsp._repeated_dPOAHKMLAKK_codec);
			if (this.reward_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB07 RID: 56071 RVA: 0x002475BC File Offset: 0x002457BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			num += this.dPOAHKMLAKK_.CalculateSize(TakeRogueEventHandbookRewardScRsp._repeated_dPOAHKMLAKK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB08 RID: 56072 RVA: 0x00247628 File Offset: 0x00245828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueEventHandbookRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this.dPOAHKMLAKK_.Add(other.dPOAHKMLAKK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB09 RID: 56073 RVA: 0x002476A1 File Offset: 0x002458A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB0A RID: 56074 RVA: 0x002476AC File Offset: 0x002458AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.dPOAHKMLAKK_.AddEntriesFrom(ref input, TakeRogueEventHandbookRewardScRsp._repeated_dPOAHKMLAKK_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005730 RID: 22320
		private static readonly MessageParser<TakeRogueEventHandbookRewardScRsp> _parser = new MessageParser<TakeRogueEventHandbookRewardScRsp>(() => new TakeRogueEventHandbookRewardScRsp());

		// Token: 0x04005731 RID: 22321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005732 RID: 22322
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04005733 RID: 22323
		private uint retcode_;

		// Token: 0x04005734 RID: 22324
		public const int RewardFieldNumber = 8;

		// Token: 0x04005735 RID: 22325
		private ItemList reward_;

		// Token: 0x04005736 RID: 22326
		public const int DPOAHKMLAKKFieldNumber = 4;

		// Token: 0x04005737 RID: 22327
		private static readonly FieldCodec<uint> _repeated_dPOAHKMLAKK_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04005738 RID: 22328
		private readonly RepeatedField<uint> dPOAHKMLAKK_ = new RepeatedField<uint>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001327 RID: 4903
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueEndlessActivityPointRewardScRsp : IMessage<TakeRogueEndlessActivityPointRewardScRsp>, IMessage, IEquatable<TakeRogueEndlessActivityPointRewardScRsp>, IDeepCloneable<TakeRogueEndlessActivityPointRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x0600DAC4 RID: 56004 RVA: 0x00246AE7 File Offset: 0x00244CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueEndlessActivityPointRewardScRsp> Parser
		{
			get
			{
				return TakeRogueEndlessActivityPointRewardScRsp._parser;
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x0600DAC5 RID: 56005 RVA: 0x00246AEE File Offset: 0x00244CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueEndlessActivityPointRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x0600DAC6 RID: 56006 RVA: 0x00246B00 File Offset: 0x00244D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueEndlessActivityPointRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x00246B07 File Offset: 0x00244D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityPointRewardScRsp()
		{
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x00246B1C File Offset: 0x00244D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityPointRewardScRsp(TakeRogueEndlessActivityPointRewardScRsp other) : this()
		{
			this.aPGBCNNPHMB_ = other.aPGBCNNPHMB_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.level_ = other.level_;
			this.mGCIACFKBFM_ = other.mGCIACFKBFM_;
			this.lHFDCBAFJGK_ = other.lHFDCBAFJGK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DAC9 RID: 56009 RVA: 0x00246B9D File Offset: 0x00244D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityPointRewardScRsp Clone()
		{
			return new TakeRogueEndlessActivityPointRewardScRsp(this);
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x0600DACA RID: 56010 RVA: 0x00246BA5 File Offset: 0x00244DA5
		// (set) Token: 0x0600DACB RID: 56011 RVA: 0x00246BAD File Offset: 0x00244DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint APGBCNNPHMB
		{
			get
			{
				return this.aPGBCNNPHMB_;
			}
			set
			{
				this.aPGBCNNPHMB_ = value;
			}
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x0600DACC RID: 56012 RVA: 0x00246BB6 File Offset: 0x00244DB6
		// (set) Token: 0x0600DACD RID: 56013 RVA: 0x00246BBE File Offset: 0x00244DBE
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

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x0600DACE RID: 56014 RVA: 0x00246BC7 File Offset: 0x00244DC7
		// (set) Token: 0x0600DACF RID: 56015 RVA: 0x00246BCF File Offset: 0x00244DCF
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

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x0600DAD0 RID: 56016 RVA: 0x00246BD8 File Offset: 0x00244DD8
		// (set) Token: 0x0600DAD1 RID: 56017 RVA: 0x00246BE0 File Offset: 0x00244DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x0600DAD2 RID: 56018 RVA: 0x00246BE9 File Offset: 0x00244DE9
		// (set) Token: 0x0600DAD3 RID: 56019 RVA: 0x00246BF1 File Offset: 0x00244DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MGCIACFKBFM
		{
			get
			{
				return this.mGCIACFKBFM_;
			}
			set
			{
				this.mGCIACFKBFM_ = value;
			}
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x0600DAD4 RID: 56020 RVA: 0x00246BFA File Offset: 0x00244DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LHFDCBAFJGK
		{
			get
			{
				return this.lHFDCBAFJGK_;
			}
		}

		// Token: 0x0600DAD5 RID: 56021 RVA: 0x00246C02 File Offset: 0x00244E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueEndlessActivityPointRewardScRsp);
		}

		// Token: 0x0600DAD6 RID: 56022 RVA: 0x00246C10 File Offset: 0x00244E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueEndlessActivityPointRewardScRsp other)
		{
			return other != null && (other == this || (this.APGBCNNPHMB == other.APGBCNNPHMB && object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.Level == other.Level && this.MGCIACFKBFM == other.MGCIACFKBFM && this.lHFDCBAFJGK_.Equals(other.lHFDCBAFJGK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAD7 RID: 56023 RVA: 0x00246CA4 File Offset: 0x00244EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.APGBCNNPHMB != 0U)
			{
				num ^= this.APGBCNNPHMB.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MGCIACFKBFM)
			{
				num ^= this.MGCIACFKBFM.GetHashCode();
			}
			num ^= this.lHFDCBAFJGK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DAD8 RID: 56024 RVA: 0x00246D52 File Offset: 0x00244F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DAD9 RID: 56025 RVA: 0x00246D5A File Offset: 0x00244F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DADA RID: 56026 RVA: 0x00246D64 File Offset: 0x00244F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.lHFDCBAFJGK_.WriteTo(ref output, TakeRogueEndlessActivityPointRewardScRsp._repeated_lHFDCBAFJGK_codec);
			if (this.Level != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Level);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Reward);
			}
			if (this.MGCIACFKBFM)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.MGCIACFKBFM);
			}
			if (this.APGBCNNPHMB != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.APGBCNNPHMB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DADB RID: 56027 RVA: 0x00246E24 File Offset: 0x00245024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.APGBCNNPHMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.APGBCNNPHMB);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.MGCIACFKBFM)
			{
				num += 2;
			}
			num += this.lHFDCBAFJGK_.CalculateSize(TakeRogueEndlessActivityPointRewardScRsp._repeated_lHFDCBAFJGK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DADC RID: 56028 RVA: 0x00246ECC File Offset: 0x002450CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueEndlessActivityPointRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.APGBCNNPHMB != 0U)
			{
				this.APGBCNNPHMB = other.APGBCNNPHMB;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.MGCIACFKBFM)
			{
				this.MGCIACFKBFM = other.MGCIACFKBFM;
			}
			this.lHFDCBAFJGK_.Add(other.lHFDCBAFJGK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DADD RID: 56029 RVA: 0x00246F81 File Offset: 0x00245181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DADE RID: 56030 RVA: 0x00246F8C File Offset: 0x0024518C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 56U || num == 58U)
					{
						this.lHFDCBAFJGK_.AddEntriesFrom(ref input, TakeRogueEndlessActivityPointRewardScRsp._repeated_lHFDCBAFJGK_codec);
						continue;
					}
				}
				else if (num <= 74U)
				{
					if (num == 64U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.MGCIACFKBFM = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.APGBCNNPHMB = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400571A RID: 22298
		private static readonly MessageParser<TakeRogueEndlessActivityPointRewardScRsp> _parser = new MessageParser<TakeRogueEndlessActivityPointRewardScRsp>(() => new TakeRogueEndlessActivityPointRewardScRsp());

		// Token: 0x0400571B RID: 22299
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400571C RID: 22300
		public const int APGBCNNPHMBFieldNumber = 12;

		// Token: 0x0400571D RID: 22301
		private uint aPGBCNNPHMB_;

		// Token: 0x0400571E RID: 22302
		public const int RewardFieldNumber = 9;

		// Token: 0x0400571F RID: 22303
		private ItemList reward_;

		// Token: 0x04005720 RID: 22304
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04005721 RID: 22305
		private uint retcode_;

		// Token: 0x04005722 RID: 22306
		public const int LevelFieldNumber = 8;

		// Token: 0x04005723 RID: 22307
		private uint level_;

		// Token: 0x04005724 RID: 22308
		public const int MGCIACFKBFMFieldNumber = 10;

		// Token: 0x04005725 RID: 22309
		private bool mGCIACFKBFM_;

		// Token: 0x04005726 RID: 22310
		public const int LHFDCBAFJGKFieldNumber = 7;

		// Token: 0x04005727 RID: 22311
		private static readonly FieldCodec<uint> _repeated_lHFDCBAFJGK_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04005728 RID: 22312
		private readonly RepeatedField<uint> lHFDCBAFJGK_ = new RepeatedField<uint>();
	}
}

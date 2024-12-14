using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200041D RID: 1053
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EndDrinkMakerSequenceScRsp : IMessage<EndDrinkMakerSequenceScRsp>, IMessage, IEquatable<EndDrinkMakerSequenceScRsp>, IDeepCloneable<EndDrinkMakerSequenceScRsp>, IBufferMessage
	{
		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x00081053 File Offset: 0x0007F253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EndDrinkMakerSequenceScRsp> Parser
		{
			get
			{
				return EndDrinkMakerSequenceScRsp._parser;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x0008105A File Offset: 0x0007F25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EndDrinkMakerSequenceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x0008106C File Offset: 0x0007F26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndDrinkMakerSequenceScRsp.Descriptor;
			}
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x00081073 File Offset: 0x0007F273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndDrinkMakerSequenceScRsp()
		{
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x00081088 File Offset: 0x0007F288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndDrinkMakerSequenceScRsp(EndDrinkMakerSequenceScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.tips_ = other.tips_;
			this.exp_ = other.exp_;
			this.nextSequenceId_ = other.nextSequenceId_;
			this.guest_ = ((other.guest_ != null) ? other.guest_.Clone() : null);
			this.level_ = other.level_;
			this.retcode_ = other.retcode_;
			this.requestList_ = other.requestList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00081131 File Offset: 0x0007F331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndDrinkMakerSequenceScRsp Clone()
		{
			return new EndDrinkMakerSequenceScRsp(this);
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x00081139 File Offset: 0x0007F339
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x00081141 File Offset: 0x0007F341
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

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x0008114A File Offset: 0x0007F34A
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x00081152 File Offset: 0x0007F352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tips
		{
			get
			{
				return this.tips_;
			}
			set
			{
				this.tips_ = value;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x0008115B File Offset: 0x0007F35B
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00081163 File Offset: 0x0007F363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x0008116C File Offset: 0x0007F36C
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x00081174 File Offset: 0x0007F374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NextSequenceId
		{
			get
			{
				return this.nextSequenceId_;
			}
			set
			{
				this.nextSequenceId_ = value;
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x0008117D File Offset: 0x0007F37D
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x00081185 File Offset: 0x0007F385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerGuest Guest
		{
			get
			{
				return this.guest_;
			}
			set
			{
				this.guest_ = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x0008118E File Offset: 0x0007F38E
		// (set) Token: 0x06002ECF RID: 11983 RVA: 0x00081196 File Offset: 0x0007F396
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

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x0008119F File Offset: 0x0007F39F
		// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x000811A7 File Offset: 0x0007F3A7
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

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x000811B0 File Offset: 0x0007F3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BKFLLOHDLEM> RequestList
		{
			get
			{
				return this.requestList_;
			}
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x000811B8 File Offset: 0x0007F3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndDrinkMakerSequenceScRsp);
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x000811C8 File Offset: 0x0007F3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndDrinkMakerSequenceScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Tips == other.Tips && this.Exp == other.Exp && this.NextSequenceId == other.NextSequenceId && object.Equals(this.Guest, other.Guest) && this.Level == other.Level && this.Retcode == other.Retcode && this.requestList_.Equals(other.requestList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00081280 File Offset: 0x0007F480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Tips != 0U)
			{
				num ^= this.Tips.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.NextSequenceId != 0U)
			{
				num ^= this.NextSequenceId.GetHashCode();
			}
			if (this.guest_ != null)
			{
				num ^= this.Guest.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.requestList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x0008135D File Offset: 0x0007F55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00081365 File Offset: 0x0007F565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00081370 File Offset: 0x0007F570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.requestList_.WriteTo(ref output, EndDrinkMakerSequenceScRsp._repeated_requestList_codec);
			if (this.guest_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Guest);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Exp);
			}
			if (this.Tips != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Tips);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			if (this.NextSequenceId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.NextSequenceId);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(98);
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

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00081468 File Offset: 0x0007F668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Tips != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tips);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.NextSequenceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NextSequenceId);
			}
			if (this.guest_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Guest);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.requestList_.CalculateSize(EndDrinkMakerSequenceScRsp._repeated_requestList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x0008154C File Offset: 0x0007F74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndDrinkMakerSequenceScRsp other)
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
			if (other.Tips != 0U)
			{
				this.Tips = other.Tips;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.NextSequenceId != 0U)
			{
				this.NextSequenceId = other.NextSequenceId;
			}
			if (other.guest_ != null)
			{
				if (this.guest_ == null)
				{
					this.Guest = new DrinkMakerGuest();
				}
				this.Guest.MergeFrom(other.Guest);
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.requestList_.Add(other.requestList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00081641 File Offset: 0x0007F841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x0008164C File Offset: 0x0007F84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							this.requestList_.AddEntriesFrom(ref input, EndDrinkMakerSequenceScRsp._repeated_requestList_codec);
							continue;
						}
						if (num == 26U)
						{
							if (this.guest_ == null)
							{
								this.Guest = new DrinkMakerGuest();
							}
							input.ReadMessage(this.Guest);
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Exp = input.ReadUInt32();
							continue;
						}
						if (num == 72U)
						{
							this.Tips = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.NextSequenceId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
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

		// Token: 0x040012BB RID: 4795
		private static readonly MessageParser<EndDrinkMakerSequenceScRsp> _parser = new MessageParser<EndDrinkMakerSequenceScRsp>(() => new EndDrinkMakerSequenceScRsp());

		// Token: 0x040012BC RID: 4796
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012BD RID: 4797
		public const int RewardFieldNumber = 12;

		// Token: 0x040012BE RID: 4798
		private ItemList reward_;

		// Token: 0x040012BF RID: 4799
		public const int TipsFieldNumber = 9;

		// Token: 0x040012C0 RID: 4800
		private uint tips_;

		// Token: 0x040012C1 RID: 4801
		public const int ExpFieldNumber = 4;

		// Token: 0x040012C2 RID: 4802
		private uint exp_;

		// Token: 0x040012C3 RID: 4803
		public const int NextSequenceIdFieldNumber = 11;

		// Token: 0x040012C4 RID: 4804
		private uint nextSequenceId_;

		// Token: 0x040012C5 RID: 4805
		public const int GuestFieldNumber = 3;

		// Token: 0x040012C6 RID: 4806
		private DrinkMakerGuest guest_;

		// Token: 0x040012C7 RID: 4807
		public const int LevelFieldNumber = 10;

		// Token: 0x040012C8 RID: 4808
		private uint level_;

		// Token: 0x040012C9 RID: 4809
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040012CA RID: 4810
		private uint retcode_;

		// Token: 0x040012CB RID: 4811
		public const int RequestListFieldNumber = 1;

		// Token: 0x040012CC RID: 4812
		private static readonly FieldCodec<BKFLLOHDLEM> _repeated_requestList_codec = FieldCodec.ForMessage<BKFLLOHDLEM>(10U, BKFLLOHDLEM.Parser);

		// Token: 0x040012CD RID: 4813
		private readonly RepeatedField<BKFLLOHDLEM> requestList_ = new RepeatedField<BKFLLOHDLEM>();
	}
}

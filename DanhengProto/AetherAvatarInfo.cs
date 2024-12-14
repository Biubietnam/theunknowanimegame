using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200004F RID: 79
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherAvatarInfo : IMessage<AetherAvatarInfo>, IMessage, IEquatable<AetherAvatarInfo>, IDeepCloneable<AetherAvatarInfo>, IBufferMessage
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000A0D7 File Offset: 0x000082D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherAvatarInfo> Parser
		{
			get
			{
				return AetherAvatarInfo._parser;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000A0DE File Offset: 0x000082DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherAvatarInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000A0F0 File Offset: 0x000082F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherAvatarInfo.Descriptor;
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000A0F7 File Offset: 0x000082F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherAvatarInfo()
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000A10C File Offset: 0x0000830C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherAvatarInfo(AetherAvatarInfo other) : this()
		{
			this.id_ = other.id_;
			this.index_ = other.index_;
			this.promotion_ = other.promotion_;
			this.passiveSkill_ = other.passiveSkill_.Clone();
			this.spiritLineupType_ = other.spiritLineupType_;
			this.spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000A18D File Offset: 0x0000838D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherAvatarInfo Clone()
		{
			return new AetherAvatarInfo(this);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000A195 File Offset: 0x00008395
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000A19D File Offset: 0x0000839D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000A1A6 File Offset: 0x000083A6
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000A1AE File Offset: 0x000083AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000A1B7 File Offset: 0x000083B7
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000A1BF File Offset: 0x000083BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Promotion
		{
			get
			{
				return this.promotion_;
			}
			set
			{
				this.promotion_ = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000A1C8 File Offset: 0x000083C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PassiveSkill
		{
			get
			{
				return this.passiveSkill_;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000A1D0 File Offset: 0x000083D0
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000A1D8 File Offset: 0x000083D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherdivideSpiritLineupType SpiritLineupType
		{
			get
			{
				return this.spiritLineupType_;
			}
			set
			{
				this.spiritLineupType_ = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000A1E1 File Offset: 0x000083E1
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0000A1E9 File Offset: 0x000083E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo SpBar
		{
			get
			{
				return this.spBar_;
			}
			set
			{
				this.spBar_ = value;
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000A1F2 File Offset: 0x000083F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherAvatarInfo);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000A200 File Offset: 0x00008400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherAvatarInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Index == other.Index && this.Promotion == other.Promotion && this.passiveSkill_.Equals(other.passiveSkill_) && this.SpiritLineupType == other.SpiritLineupType && object.Equals(this.SpBar, other.SpBar) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000A294 File Offset: 0x00008494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			num ^= this.passiveSkill_.GetHashCode();
			if (this.SpiritLineupType != AetherdivideSpiritLineupType.AetherdivideSpiritLineupNone)
			{
				num ^= this.SpiritLineupType.GetHashCode();
			}
			if (this.spBar_ != null)
			{
				num ^= this.SpBar.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000A348 File Offset: 0x00008548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000A350 File Offset: 0x00008550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000A35C File Offset: 0x0000855C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Index);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Promotion);
			}
			this.passiveSkill_.WriteTo(ref output, AetherAvatarInfo._repeated_passiveSkill_codec);
			if (this.SpiritLineupType != AetherdivideSpiritLineupType.AetherdivideSpiritLineupNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.SpiritLineupType);
			}
			if (this.spBar_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SpBar);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000A41C File Offset: 0x0000861C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			num += this.passiveSkill_.CalculateSize(AetherAvatarInfo._repeated_passiveSkill_codec);
			if (this.SpiritLineupType != AetherdivideSpiritLineupType.AetherdivideSpiritLineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SpiritLineupType);
			}
			if (this.spBar_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpBar);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherAvatarInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			this.passiveSkill_.Add(other.passiveSkill_);
			if (other.SpiritLineupType != AetherdivideSpiritLineupType.AetherdivideSpiritLineupNone)
			{
				this.SpiritLineupType = other.SpiritLineupType;
			}
			if (other.spBar_ != null)
			{
				if (this.spBar_ == null)
				{
					this.SpBar = new SpBarInfo();
				}
				this.SpBar.MergeFrom(other.SpBar);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000A585 File Offset: 0x00008785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000A590 File Offset: 0x00008790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Index = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.passiveSkill_.AddEntriesFrom(ref input, AetherAvatarInfo._repeated_passiveSkill_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.SpiritLineupType = (AetherdivideSpiritLineupType)input.ReadEnum();
						continue;
					}
					if (num == 50U)
					{
						if (this.spBar_ == null)
						{
							this.SpBar = new SpBarInfo();
						}
						input.ReadMessage(this.SpBar);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400012E RID: 302
		private static readonly MessageParser<AetherAvatarInfo> _parser = new MessageParser<AetherAvatarInfo>(() => new AetherAvatarInfo());

		// Token: 0x0400012F RID: 303
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000130 RID: 304
		public const int IdFieldNumber = 1;

		// Token: 0x04000131 RID: 305
		private uint id_;

		// Token: 0x04000132 RID: 306
		public const int IndexFieldNumber = 2;

		// Token: 0x04000133 RID: 307
		private uint index_;

		// Token: 0x04000134 RID: 308
		public const int PromotionFieldNumber = 3;

		// Token: 0x04000135 RID: 309
		private uint promotion_;

		// Token: 0x04000136 RID: 310
		public const int PassiveSkillFieldNumber = 4;

		// Token: 0x04000137 RID: 311
		private static readonly FieldCodec<uint> _repeated_passiveSkill_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04000138 RID: 312
		private readonly RepeatedField<uint> passiveSkill_ = new RepeatedField<uint>();

		// Token: 0x04000139 RID: 313
		public const int SpiritLineupTypeFieldNumber = 5;

		// Token: 0x0400013A RID: 314
		private AetherdivideSpiritLineupType spiritLineupType_;

		// Token: 0x0400013B RID: 315
		public const int SpBarFieldNumber = 6;

		// Token: 0x0400013C RID: 316
		private SpBarInfo spBar_;
	}
}

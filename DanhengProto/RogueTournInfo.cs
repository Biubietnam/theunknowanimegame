using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FDF RID: 4063
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournInfo : IMessage<RogueTournInfo>, IMessage, IEquatable<RogueTournInfo>, IDeepCloneable<RogueTournInfo>, IBufferMessage
	{
		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600B4E8 RID: 46312 RVA: 0x001E5898 File Offset: 0x001E3A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournInfo> Parser
		{
			get
			{
				return RogueTournInfo._parser;
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600B4E9 RID: 46313 RVA: 0x001E589F File Offset: 0x001E3A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600B4EA RID: 46314 RVA: 0x001E58B1 File Offset: 0x001E3AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournInfo.Descriptor;
			}
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x001E58B8 File Offset: 0x001E3AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournInfo()
		{
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x001E58E4 File Offset: 0x001E3AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournInfo(RogueTournInfo other) : this()
		{
			this.rogueSeasonInfo_ = ((other.rogueSeasonInfo_ != null) ? other.rogueSeasonInfo_.Clone() : null);
			this.rogueTournExpInfo_ = ((other.rogueTournExpInfo_ != null) ? other.rogueTournExpInfo_.Clone() : null);
			this.rogueTournDifficultyInfo_ = other.rogueTournDifficultyInfo_.Clone();
			this.rogueTournHandbook_ = ((other.rogueTournHandbook_ != null) ? other.rogueTournHandbook_.Clone() : null);
			this.permanentInfo_ = ((other.permanentInfo_ != null) ? other.permanentInfo_.Clone() : null);
			this.rogueTournSaveList_ = other.rogueTournSaveList_.Clone();
			this.rogueTournAreaInfo_ = other.rogueTournAreaInfo_.Clone();
			this.extraScoreInfo_ = ((other.extraScoreInfo_ != null) ? other.extraScoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x001E59C7 File Offset: 0x001E3BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournInfo Clone()
		{
			return new RogueTournInfo(this);
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600B4EE RID: 46318 RVA: 0x001E59CF File Offset: 0x001E3BCF
		// (set) Token: 0x0600B4EF RID: 46319 RVA: 0x001E59D7 File Offset: 0x001E3BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSeasonInfo RogueSeasonInfo
		{
			get
			{
				return this.rogueSeasonInfo_;
			}
			set
			{
				this.rogueSeasonInfo_ = value;
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600B4F0 RID: 46320 RVA: 0x001E59E0 File Offset: 0x001E3BE0
		// (set) Token: 0x0600B4F1 RID: 46321 RVA: 0x001E59E8 File Offset: 0x001E3BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournExpInfo RogueTournExpInfo
		{
			get
			{
				return this.rogueTournExpInfo_;
			}
			set
			{
				this.rogueTournExpInfo_ = value;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600B4F2 RID: 46322 RVA: 0x001E59F1 File Offset: 0x001E3BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTournDifficultyInfo> RogueTournDifficultyInfo
		{
			get
			{
				return this.rogueTournDifficultyInfo_;
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600B4F3 RID: 46323 RVA: 0x001E59F9 File Offset: 0x001E3BF9
		// (set) Token: 0x0600B4F4 RID: 46324 RVA: 0x001E5A01 File Offset: 0x001E3C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournHandbookInfo RogueTournHandbook
		{
			get
			{
				return this.rogueTournHandbook_;
			}
			set
			{
				this.rogueTournHandbook_ = value;
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600B4F5 RID: 46325 RVA: 0x001E5A0A File Offset: 0x001E3C0A
		// (set) Token: 0x0600B4F6 RID: 46326 RVA: 0x001E5A12 File Offset: 0x001E3C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournPermanentTalentInfo PermanentInfo
		{
			get
			{
				return this.permanentInfo_;
			}
			set
			{
				this.permanentInfo_ = value;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600B4F7 RID: 46327 RVA: 0x001E5A1B File Offset: 0x001E3C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTournSaveList> RogueTournSaveList
		{
			get
			{
				return this.rogueTournSaveList_;
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600B4F8 RID: 46328 RVA: 0x001E5A23 File Offset: 0x001E3C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTournAreaInfo> RogueTournAreaInfo
		{
			get
			{
				return this.rogueTournAreaInfo_;
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600B4F9 RID: 46329 RVA: 0x001E5A2B File Offset: 0x001E3C2B
		// (set) Token: 0x0600B4FA RID: 46330 RVA: 0x001E5A33 File Offset: 0x001E3C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraScoreInfo ExtraScoreInfo
		{
			get
			{
				return this.extraScoreInfo_;
			}
			set
			{
				this.extraScoreInfo_ = value;
			}
		}

		// Token: 0x0600B4FB RID: 46331 RVA: 0x001E5A3C File Offset: 0x001E3C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournInfo);
		}

		// Token: 0x0600B4FC RID: 46332 RVA: 0x001E5A4C File Offset: 0x001E3C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueSeasonInfo, other.RogueSeasonInfo) && object.Equals(this.RogueTournExpInfo, other.RogueTournExpInfo) && this.rogueTournDifficultyInfo_.Equals(other.rogueTournDifficultyInfo_) && object.Equals(this.RogueTournHandbook, other.RogueTournHandbook) && object.Equals(this.PermanentInfo, other.PermanentInfo) && this.rogueTournSaveList_.Equals(other.rogueTournSaveList_) && this.rogueTournAreaInfo_.Equals(other.rogueTournAreaInfo_) && object.Equals(this.ExtraScoreInfo, other.ExtraScoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x001E5B20 File Offset: 0x001E3D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueSeasonInfo_ != null)
			{
				num ^= this.RogueSeasonInfo.GetHashCode();
			}
			if (this.rogueTournExpInfo_ != null)
			{
				num ^= this.RogueTournExpInfo.GetHashCode();
			}
			num ^= this.rogueTournDifficultyInfo_.GetHashCode();
			if (this.rogueTournHandbook_ != null)
			{
				num ^= this.RogueTournHandbook.GetHashCode();
			}
			if (this.permanentInfo_ != null)
			{
				num ^= this.PermanentInfo.GetHashCode();
			}
			num ^= this.rogueTournSaveList_.GetHashCode();
			num ^= this.rogueTournAreaInfo_.GetHashCode();
			if (this.extraScoreInfo_ != null)
			{
				num ^= this.ExtraScoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x001E5BDE File Offset: 0x001E3DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x001E5BE6 File Offset: 0x001E3DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x001E5BF0 File Offset: 0x001E3DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournHandbook_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueTournHandbook);
			}
			if (this.rogueTournExpInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueTournExpInfo);
			}
			this.rogueTournDifficultyInfo_.WriteTo(ref output, RogueTournInfo._repeated_rogueTournDifficultyInfo_codec);
			if (this.permanentInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PermanentInfo);
			}
			this.rogueTournAreaInfo_.WriteTo(ref output, RogueTournInfo._repeated_rogueTournAreaInfo_codec);
			this.rogueTournSaveList_.WriteTo(ref output, RogueTournInfo._repeated_rogueTournSaveList_codec);
			if (this.extraScoreInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ExtraScoreInfo);
			}
			if (this.rogueSeasonInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueSeasonInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x001E5CD0 File Offset: 0x001E3ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueSeasonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueSeasonInfo);
			}
			if (this.rogueTournExpInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournExpInfo);
			}
			num += this.rogueTournDifficultyInfo_.CalculateSize(RogueTournInfo._repeated_rogueTournDifficultyInfo_codec);
			if (this.rogueTournHandbook_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournHandbook);
			}
			if (this.permanentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PermanentInfo);
			}
			num += this.rogueTournSaveList_.CalculateSize(RogueTournInfo._repeated_rogueTournSaveList_codec);
			num += this.rogueTournAreaInfo_.CalculateSize(RogueTournInfo._repeated_rogueTournAreaInfo_codec);
			if (this.extraScoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ExtraScoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x001E5DA8 File Offset: 0x001E3FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueSeasonInfo_ != null)
			{
				if (this.rogueSeasonInfo_ == null)
				{
					this.RogueSeasonInfo = new RogueTournSeasonInfo();
				}
				this.RogueSeasonInfo.MergeFrom(other.RogueSeasonInfo);
			}
			if (other.rogueTournExpInfo_ != null)
			{
				if (this.rogueTournExpInfo_ == null)
				{
					this.RogueTournExpInfo = new RogueTournExpInfo();
				}
				this.RogueTournExpInfo.MergeFrom(other.RogueTournExpInfo);
			}
			this.rogueTournDifficultyInfo_.Add(other.rogueTournDifficultyInfo_);
			if (other.rogueTournHandbook_ != null)
			{
				if (this.rogueTournHandbook_ == null)
				{
					this.RogueTournHandbook = new RogueTournHandbookInfo();
				}
				this.RogueTournHandbook.MergeFrom(other.RogueTournHandbook);
			}
			if (other.permanentInfo_ != null)
			{
				if (this.permanentInfo_ == null)
				{
					this.PermanentInfo = new RogueTournPermanentTalentInfo();
				}
				this.PermanentInfo.MergeFrom(other.PermanentInfo);
			}
			this.rogueTournSaveList_.Add(other.rogueTournSaveList_);
			this.rogueTournAreaInfo_.Add(other.rogueTournAreaInfo_);
			if (other.extraScoreInfo_ != null)
			{
				if (this.extraScoreInfo_ == null)
				{
					this.ExtraScoreInfo = new ExtraScoreInfo();
				}
				this.ExtraScoreInfo.MergeFrom(other.ExtraScoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x001E5EDF File Offset: 0x001E40DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x001E5EE8 File Offset: 0x001E40E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num <= 26U)
					{
						if (num == 18U)
						{
							if (this.rogueTournHandbook_ == null)
							{
								this.RogueTournHandbook = new RogueTournHandbookInfo();
							}
							input.ReadMessage(this.RogueTournHandbook);
							continue;
						}
						if (num == 26U)
						{
							if (this.rogueTournExpInfo_ == null)
							{
								this.RogueTournExpInfo = new RogueTournExpInfo();
							}
							input.ReadMessage(this.RogueTournExpInfo);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.rogueTournDifficultyInfo_.AddEntriesFrom(ref input, RogueTournInfo._repeated_rogueTournDifficultyInfo_codec);
							continue;
						}
						if (num == 74U)
						{
							if (this.permanentInfo_ == null)
							{
								this.PermanentInfo = new RogueTournPermanentTalentInfo();
							}
							input.ReadMessage(this.PermanentInfo);
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num == 90U)
					{
						this.rogueTournAreaInfo_.AddEntriesFrom(ref input, RogueTournInfo._repeated_rogueTournAreaInfo_codec);
						continue;
					}
					if (num == 98U)
					{
						this.rogueTournSaveList_.AddEntriesFrom(ref input, RogueTournInfo._repeated_rogueTournSaveList_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.extraScoreInfo_ == null)
						{
							this.ExtraScoreInfo = new ExtraScoreInfo();
						}
						input.ReadMessage(this.ExtraScoreInfo);
						continue;
					}
					if (num == 122U)
					{
						if (this.rogueSeasonInfo_ == null)
						{
							this.RogueSeasonInfo = new RogueTournSeasonInfo();
						}
						input.ReadMessage(this.RogueSeasonInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400495B RID: 18779
		private static readonly MessageParser<RogueTournInfo> _parser = new MessageParser<RogueTournInfo>(() => new RogueTournInfo());

		// Token: 0x0400495C RID: 18780
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400495D RID: 18781
		public const int RogueSeasonInfoFieldNumber = 15;

		// Token: 0x0400495E RID: 18782
		private RogueTournSeasonInfo rogueSeasonInfo_;

		// Token: 0x0400495F RID: 18783
		public const int RogueTournExpInfoFieldNumber = 3;

		// Token: 0x04004960 RID: 18784
		private RogueTournExpInfo rogueTournExpInfo_;

		// Token: 0x04004961 RID: 18785
		public const int RogueTournDifficultyInfoFieldNumber = 4;

		// Token: 0x04004962 RID: 18786
		private static readonly FieldCodec<RogueTournDifficultyInfo> _repeated_rogueTournDifficultyInfo_codec = FieldCodec.ForMessage<RogueTournDifficultyInfo>(34U, EggLink.DanhengServer.Proto.RogueTournDifficultyInfo.Parser);

		// Token: 0x04004963 RID: 18787
		private readonly RepeatedField<RogueTournDifficultyInfo> rogueTournDifficultyInfo_ = new RepeatedField<RogueTournDifficultyInfo>();

		// Token: 0x04004964 RID: 18788
		public const int RogueTournHandbookFieldNumber = 2;

		// Token: 0x04004965 RID: 18789
		private RogueTournHandbookInfo rogueTournHandbook_;

		// Token: 0x04004966 RID: 18790
		public const int PermanentInfoFieldNumber = 9;

		// Token: 0x04004967 RID: 18791
		private RogueTournPermanentTalentInfo permanentInfo_;

		// Token: 0x04004968 RID: 18792
		public const int RogueTournSaveListFieldNumber = 12;

		// Token: 0x04004969 RID: 18793
		private static readonly FieldCodec<RogueTournSaveList> _repeated_rogueTournSaveList_codec = FieldCodec.ForMessage<RogueTournSaveList>(98U, EggLink.DanhengServer.Proto.RogueTournSaveList.Parser);

		// Token: 0x0400496A RID: 18794
		private readonly RepeatedField<RogueTournSaveList> rogueTournSaveList_ = new RepeatedField<RogueTournSaveList>();

		// Token: 0x0400496B RID: 18795
		public const int RogueTournAreaInfoFieldNumber = 11;

		// Token: 0x0400496C RID: 18796
		private static readonly FieldCodec<RogueTournAreaInfo> _repeated_rogueTournAreaInfo_codec = FieldCodec.ForMessage<RogueTournAreaInfo>(90U, EggLink.DanhengServer.Proto.RogueTournAreaInfo.Parser);

		// Token: 0x0400496D RID: 18797
		private readonly RepeatedField<RogueTournAreaInfo> rogueTournAreaInfo_ = new RepeatedField<RogueTournAreaInfo>();

		// Token: 0x0400496E RID: 18798
		public const int ExtraScoreInfoFieldNumber = 13;

		// Token: 0x0400496F RID: 18799
		private ExtraScoreInfo extraScoreInfo_;
	}
}

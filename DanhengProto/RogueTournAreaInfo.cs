using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F7F RID: 3967
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournAreaInfo : IMessage<RogueTournAreaInfo>, IMessage, IEquatable<RogueTournAreaInfo>, IDeepCloneable<RogueTournAreaInfo>, IBufferMessage
	{
		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600B0A3 RID: 45219 RVA: 0x001DA833 File Offset: 0x001D8A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournAreaInfo> Parser
		{
			get
			{
				return RogueTournAreaInfo._parser;
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600B0A4 RID: 45220 RVA: 0x001DA83A File Offset: 0x001D8A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournAreaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x001DA84C File Offset: 0x001D8A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600B0A6 RID: 45222 RVA: 0x001DA853 File Offset: 0x001D8A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournAreaInfo()
		{
		}

		// Token: 0x0600B0A7 RID: 45223 RVA: 0x001DA868 File Offset: 0x001D8A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournAreaInfo(RogueTournAreaInfo other) : this()
		{
			this.unlockedTournDifficultyList_ = other.unlockedTournDifficultyList_.Clone();
			this.isTakenReward_ = other.isTakenReward_;
			this.areaId_ = other.areaId_;
			this.isTournFinish_ = other.isTournFinish_;
			this.isUnlocked_ = other.isUnlocked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0A8 RID: 45224 RVA: 0x001DA8CD File Offset: 0x001D8ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournAreaInfo Clone()
		{
			return new RogueTournAreaInfo(this);
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600B0A9 RID: 45225 RVA: 0x001DA8D5 File Offset: 0x001D8AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockedTournDifficultyList
		{
			get
			{
				return this.unlockedTournDifficultyList_;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600B0AA RID: 45226 RVA: 0x001DA8DD File Offset: 0x001D8ADD
		// (set) Token: 0x0600B0AB RID: 45227 RVA: 0x001DA8E5 File Offset: 0x001D8AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTakenReward
		{
			get
			{
				return this.isTakenReward_;
			}
			set
			{
				this.isTakenReward_ = value;
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600B0AC RID: 45228 RVA: 0x001DA8EE File Offset: 0x001D8AEE
		// (set) Token: 0x0600B0AD RID: 45229 RVA: 0x001DA8F6 File Offset: 0x001D8AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600B0AE RID: 45230 RVA: 0x001DA8FF File Offset: 0x001D8AFF
		// (set) Token: 0x0600B0AF RID: 45231 RVA: 0x001DA907 File Offset: 0x001D8B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTournFinish
		{
			get
			{
				return this.isTournFinish_;
			}
			set
			{
				this.isTournFinish_ = value;
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600B0B0 RID: 45232 RVA: 0x001DA910 File Offset: 0x001D8B10
		// (set) Token: 0x0600B0B1 RID: 45233 RVA: 0x001DA918 File Offset: 0x001D8B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlocked
		{
			get
			{
				return this.isUnlocked_;
			}
			set
			{
				this.isUnlocked_ = value;
			}
		}

		// Token: 0x0600B0B2 RID: 45234 RVA: 0x001DA921 File Offset: 0x001D8B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournAreaInfo);
		}

		// Token: 0x0600B0B3 RID: 45235 RVA: 0x001DA930 File Offset: 0x001D8B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournAreaInfo other)
		{
			return other != null && (other == this || (this.unlockedTournDifficultyList_.Equals(other.unlockedTournDifficultyList_) && this.IsTakenReward == other.IsTakenReward && this.AreaId == other.AreaId && this.IsTournFinish == other.IsTournFinish && this.IsUnlocked == other.IsUnlocked && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0B4 RID: 45236 RVA: 0x001DA9B0 File Offset: 0x001D8BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedTournDifficultyList_.GetHashCode();
			if (this.IsTakenReward)
			{
				num ^= this.IsTakenReward.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.IsTournFinish)
			{
				num ^= this.IsTournFinish.GetHashCode();
			}
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0B5 RID: 45237 RVA: 0x001DAA48 File Offset: 0x001D8C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B0B6 RID: 45238 RVA: 0x001DAA50 File Offset: 0x001D8C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0B7 RID: 45239 RVA: 0x001DAA5C File Offset: 0x001D8C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AreaId);
			}
			if (this.IsTakenReward)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsTakenReward);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUnlocked);
			}
			this.unlockedTournDifficultyList_.WriteTo(ref output, RogueTournAreaInfo._repeated_unlockedTournDifficultyList_codec);
			if (this.IsTournFinish)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsTournFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0B8 RID: 45240 RVA: 0x001DAB00 File Offset: 0x001D8D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedTournDifficultyList_.CalculateSize(RogueTournAreaInfo._repeated_unlockedTournDifficultyList_codec);
			if (this.IsTakenReward)
			{
				num += 2;
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.IsTournFinish)
			{
				num += 2;
			}
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0B9 RID: 45241 RVA: 0x001DAB78 File Offset: 0x001D8D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedTournDifficultyList_.Add(other.unlockedTournDifficultyList_);
			if (other.IsTakenReward)
			{
				this.IsTakenReward = other.IsTakenReward;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.IsTournFinish)
			{
				this.IsTournFinish = other.IsTournFinish;
			}
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B0BA RID: 45242 RVA: 0x001DAC01 File Offset: 0x001D8E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0BB RID: 45243 RVA: 0x001DAC0C File Offset: 0x001D8E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsTakenReward = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.IsUnlocked = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U || num == 98U)
					{
						this.unlockedTournDifficultyList_.AddEntriesFrom(ref input, RogueTournAreaInfo._repeated_unlockedTournDifficultyList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.IsTournFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047E0 RID: 18400
		private static readonly MessageParser<RogueTournAreaInfo> _parser = new MessageParser<RogueTournAreaInfo>(() => new RogueTournAreaInfo());

		// Token: 0x040047E1 RID: 18401
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047E2 RID: 18402
		public const int UnlockedTournDifficultyListFieldNumber = 12;

		// Token: 0x040047E3 RID: 18403
		private static readonly FieldCodec<uint> _repeated_unlockedTournDifficultyList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x040047E4 RID: 18404
		private readonly RepeatedField<uint> unlockedTournDifficultyList_ = new RepeatedField<uint>();

		// Token: 0x040047E5 RID: 18405
		public const int IsTakenRewardFieldNumber = 6;

		// Token: 0x040047E6 RID: 18406
		private bool isTakenReward_;

		// Token: 0x040047E7 RID: 18407
		public const int AreaIdFieldNumber = 5;

		// Token: 0x040047E8 RID: 18408
		private uint areaId_;

		// Token: 0x040047E9 RID: 18409
		public const int IsTournFinishFieldNumber = 15;

		// Token: 0x040047EA RID: 18410
		private bool isTournFinish_;

		// Token: 0x040047EB RID: 18411
		public const int IsUnlockedFieldNumber = 7;

		// Token: 0x040047EC RID: 18412
		private bool isUnlocked_;
	}
}

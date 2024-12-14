using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EAB RID: 3755
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicAreaInfo : IMessage<RogueMagicAreaInfo>, IMessage, IEquatable<RogueMagicAreaInfo>, IDeepCloneable<RogueMagicAreaInfo>, IBufferMessage
	{
		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x0600A7C0 RID: 42944 RVA: 0x001C3D9B File Offset: 0x001C1F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicAreaInfo> Parser
		{
			get
			{
				return RogueMagicAreaInfo._parser;
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x0600A7C1 RID: 42945 RVA: 0x001C3DA2 File Offset: 0x001C1FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicAreaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x0600A7C2 RID: 42946 RVA: 0x001C3DB4 File Offset: 0x001C1FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x001C3DBB File Offset: 0x001C1FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAreaInfo()
		{
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x001C3DD0 File Offset: 0x001C1FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAreaInfo(RogueMagicAreaInfo other) : this()
		{
			this.unlockedTournDifficultyList_ = other.unlockedTournDifficultyList_.Clone();
			this.isUnlocked_ = other.isUnlocked_;
			this.eCONHGPNDKI_ = ((other.eCONHGPNDKI_ != null) ? other.eCONHGPNDKI_.Clone() : null);
			this.isTakenReward_ = other.isTakenReward_;
			this.iEKBMJEOINP_ = other.iEKBMJEOINP_;
			this.isTournFinish_ = other.isTournFinish_;
			this.recordInfo_ = ((other.recordInfo_ != null) ? other.recordInfo_.Clone() : null);
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x001C3E79 File Offset: 0x001C2079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAreaInfo Clone()
		{
			return new RogueMagicAreaInfo(this);
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x0600A7C6 RID: 42950 RVA: 0x001C3E81 File Offset: 0x001C2081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockedTournDifficultyList
		{
			get
			{
				return this.unlockedTournDifficultyList_;
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x0600A7C7 RID: 42951 RVA: 0x001C3E89 File Offset: 0x001C2089
		// (set) Token: 0x0600A7C8 RID: 42952 RVA: 0x001C3E91 File Offset: 0x001C2091
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

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x0600A7C9 RID: 42953 RVA: 0x001C3E9A File Offset: 0x001C209A
		// (set) Token: 0x0600A7CA RID: 42954 RVA: 0x001C3EA2 File Offset: 0x001C20A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MJKPAPMILML ECONHGPNDKI
		{
			get
			{
				return this.eCONHGPNDKI_;
			}
			set
			{
				this.eCONHGPNDKI_ = value;
			}
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x0600A7CB RID: 42955 RVA: 0x001C3EAB File Offset: 0x001C20AB
		// (set) Token: 0x0600A7CC RID: 42956 RVA: 0x001C3EB3 File Offset: 0x001C20B3
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

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x0600A7CD RID: 42957 RVA: 0x001C3EBC File Offset: 0x001C20BC
		// (set) Token: 0x0600A7CE RID: 42958 RVA: 0x001C3EC4 File Offset: 0x001C20C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IEKBMJEOINP
		{
			get
			{
				return this.iEKBMJEOINP_;
			}
			set
			{
				this.iEKBMJEOINP_ = value;
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x0600A7CF RID: 42959 RVA: 0x001C3ECD File Offset: 0x001C20CD
		// (set) Token: 0x0600A7D0 RID: 42960 RVA: 0x001C3ED5 File Offset: 0x001C20D5
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

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x001C3EDE File Offset: 0x001C20DE
		// (set) Token: 0x0600A7D2 RID: 42962 RVA: 0x001C3EE6 File Offset: 0x001C20E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGPPMGKGOBH RecordInfo
		{
			get
			{
				return this.recordInfo_;
			}
			set
			{
				this.recordInfo_ = value;
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x0600A7D3 RID: 42963 RVA: 0x001C3EEF File Offset: 0x001C20EF
		// (set) Token: 0x0600A7D4 RID: 42964 RVA: 0x001C3EF7 File Offset: 0x001C20F7
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

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x001C3F00 File Offset: 0x001C2100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicAreaInfo);
		}

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x001C3F10 File Offset: 0x001C2110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicAreaInfo other)
		{
			return other != null && (other == this || (this.unlockedTournDifficultyList_.Equals(other.unlockedTournDifficultyList_) && this.IsUnlocked == other.IsUnlocked && object.Equals(this.ECONHGPNDKI, other.ECONHGPNDKI) && this.IsTakenReward == other.IsTakenReward && this.IEKBMJEOINP == other.IEKBMJEOINP && this.IsTournFinish == other.IsTournFinish && object.Equals(this.RecordInfo, other.RecordInfo) && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x001C3FC8 File Offset: 0x001C21C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedTournDifficultyList_.GetHashCode();
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this.eCONHGPNDKI_ != null)
			{
				num ^= this.ECONHGPNDKI.GetHashCode();
			}
			if (this.IsTakenReward)
			{
				num ^= this.IsTakenReward.GetHashCode();
			}
			if (this.IEKBMJEOINP != 0U)
			{
				num ^= this.IEKBMJEOINP.GetHashCode();
			}
			if (this.IsTournFinish)
			{
				num ^= this.IsTournFinish.GetHashCode();
			}
			if (this.recordInfo_ != null)
			{
				num ^= this.RecordInfo.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x001C40A5 File Offset: 0x001C22A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x001C40AD File Offset: 0x001C22AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x001C40B8 File Offset: 0x001C22B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedTournDifficultyList_.WriteTo(ref output, RogueMagicAreaInfo._repeated_unlockedTournDifficultyList_codec);
			if (this.recordInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RecordInfo);
			}
			if (this.IsTakenReward)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsTakenReward);
			}
			if (this.IsTournFinish)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsTournFinish);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsUnlocked);
			}
			if (this.eCONHGPNDKI_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ECONHGPNDKI);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.AreaId);
			}
			if (this.IEKBMJEOINP != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.IEKBMJEOINP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x001C41B0 File Offset: 0x001C23B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedTournDifficultyList_.CalculateSize(RogueMagicAreaInfo._repeated_unlockedTournDifficultyList_codec);
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this.eCONHGPNDKI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ECONHGPNDKI);
			}
			if (this.IsTakenReward)
			{
				num += 2;
			}
			if (this.IEKBMJEOINP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IEKBMJEOINP);
			}
			if (this.IsTournFinish)
			{
				num += 2;
			}
			if (this.recordInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RecordInfo);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x001C4270 File Offset: 0x001C2470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedTournDifficultyList_.Add(other.unlockedTournDifficultyList_);
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			if (other.eCONHGPNDKI_ != null)
			{
				if (this.eCONHGPNDKI_ == null)
				{
					this.ECONHGPNDKI = new MJKPAPMILML();
				}
				this.ECONHGPNDKI.MergeFrom(other.ECONHGPNDKI);
			}
			if (other.IsTakenReward)
			{
				this.IsTakenReward = other.IsTakenReward;
			}
			if (other.IEKBMJEOINP != 0U)
			{
				this.IEKBMJEOINP = other.IEKBMJEOINP;
			}
			if (other.IsTournFinish)
			{
				this.IsTournFinish = other.IsTournFinish;
			}
			if (other.recordInfo_ != null)
			{
				if (this.recordInfo_ == null)
				{
					this.RecordInfo = new NGPPMGKGOBH();
				}
				this.RecordInfo.MergeFrom(other.RecordInfo);
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x001C4365 File Offset: 0x001C2565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x001C4370 File Offset: 0x001C2570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.unlockedTournDifficultyList_.AddEntriesFrom(ref input, RogueMagicAreaInfo._repeated_unlockedTournDifficultyList_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.recordInfo_ == null)
							{
								this.RecordInfo = new NGPPMGKGOBH();
							}
							input.ReadMessage(this.RecordInfo);
							continue;
						}
						if (num == 32U)
						{
							this.IsTakenReward = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 88U)
					{
						this.IsTournFinish = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.IsUnlocked = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.eCONHGPNDKI_ == null)
						{
							this.ECONHGPNDKI = new MJKPAPMILML();
						}
						input.ReadMessage(this.ECONHGPNDKI);
						continue;
					}
					if (num == 112U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IEKBMJEOINP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004495 RID: 17557
		private static readonly MessageParser<RogueMagicAreaInfo> _parser = new MessageParser<RogueMagicAreaInfo>(() => new RogueMagicAreaInfo());

		// Token: 0x04004496 RID: 17558
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004497 RID: 17559
		public const int UnlockedTournDifficultyListFieldNumber = 1;

		// Token: 0x04004498 RID: 17560
		private static readonly FieldCodec<uint> _repeated_unlockedTournDifficultyList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04004499 RID: 17561
		private readonly RepeatedField<uint> unlockedTournDifficultyList_ = new RepeatedField<uint>();

		// Token: 0x0400449A RID: 17562
		public const int IsUnlockedFieldNumber = 12;

		// Token: 0x0400449B RID: 17563
		private bool isUnlocked_;

		// Token: 0x0400449C RID: 17564
		public const int ECONHGPNDKIFieldNumber = 13;

		// Token: 0x0400449D RID: 17565
		private MJKPAPMILML eCONHGPNDKI_;

		// Token: 0x0400449E RID: 17566
		public const int IsTakenRewardFieldNumber = 4;

		// Token: 0x0400449F RID: 17567
		private bool isTakenReward_;

		// Token: 0x040044A0 RID: 17568
		public const int IEKBMJEOINPFieldNumber = 15;

		// Token: 0x040044A1 RID: 17569
		private uint iEKBMJEOINP_;

		// Token: 0x040044A2 RID: 17570
		public const int IsTournFinishFieldNumber = 11;

		// Token: 0x040044A3 RID: 17571
		private bool isTournFinish_;

		// Token: 0x040044A4 RID: 17572
		public const int RecordInfoFieldNumber = 3;

		// Token: 0x040044A5 RID: 17573
		private NGPPMGKGOBH recordInfo_;

		// Token: 0x040044A6 RID: 17574
		public const int AreaIdFieldNumber = 14;

		// Token: 0x040044A7 RID: 17575
		private uint areaId_;
	}
}

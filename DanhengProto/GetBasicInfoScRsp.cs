using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000631 RID: 1585
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetBasicInfoScRsp : IMessage<GetBasicInfoScRsp>, IMessage, IEquatable<GetBasicInfoScRsp>, IDeepCloneable<GetBasicInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x0600471A RID: 18202 RVA: 0x000C2D86 File Offset: 0x000C0F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetBasicInfoScRsp> Parser
		{
			get
			{
				return GetBasicInfoScRsp._parser;
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x0600471B RID: 18203 RVA: 0x000C2D8D File Offset: 0x000C0F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetBasicInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x0600471C RID: 18204 RVA: 0x000C2D9F File Offset: 0x000C0F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBasicInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x000C2DA6 File Offset: 0x000C0FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBasicInfoScRsp()
		{
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x000C2DB0 File Offset: 0x000C0FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBasicInfoScRsp(GetBasicInfoScRsp other) : this()
		{
			this.isGenderSet_ = other.isGenderSet_;
			this.curDay_ = other.curDay_;
			this.exchangeTimes_ = other.exchangeTimes_;
			this.playerSettingInfo_ = ((other.playerSettingInfo_ != null) ? other.playerSettingInfo_.Clone() : null);
			this.gameplayBirthday_ = other.gameplayBirthday_;
			this.lastSetNicknameTime_ = other.lastSetNicknameTime_;
			this.weekCocoonFinishedCount_ = other.weekCocoonFinishedCount_;
			this.retcode_ = other.retcode_;
			this.gender_ = other.gender_;
			this.nextRecoverTime_ = other.nextRecoverTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x000C2E5C File Offset: 0x000C105C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBasicInfoScRsp Clone()
		{
			return new GetBasicInfoScRsp(this);
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x000C2E64 File Offset: 0x000C1064
		// (set) Token: 0x06004721 RID: 18209 RVA: 0x000C2E6C File Offset: 0x000C106C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGenderSet
		{
			get
			{
				return this.isGenderSet_;
			}
			set
			{
				this.isGenderSet_ = value;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06004722 RID: 18210 RVA: 0x000C2E75 File Offset: 0x000C1075
		// (set) Token: 0x06004723 RID: 18211 RVA: 0x000C2E7D File Offset: 0x000C107D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurDay
		{
			get
			{
				return this.curDay_;
			}
			set
			{
				this.curDay_ = value;
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x000C2E86 File Offset: 0x000C1086
		// (set) Token: 0x06004725 RID: 18213 RVA: 0x000C2E8E File Offset: 0x000C108E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExchangeTimes
		{
			get
			{
				return this.exchangeTimes_;
			}
			set
			{
				this.exchangeTimes_ = value;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x000C2E97 File Offset: 0x000C1097
		// (set) Token: 0x06004727 RID: 18215 RVA: 0x000C2E9F File Offset: 0x000C109F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettingInfo PlayerSettingInfo
		{
			get
			{
				return this.playerSettingInfo_;
			}
			set
			{
				this.playerSettingInfo_ = value;
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06004728 RID: 18216 RVA: 0x000C2EA8 File Offset: 0x000C10A8
		// (set) Token: 0x06004729 RID: 18217 RVA: 0x000C2EB0 File Offset: 0x000C10B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameplayBirthday
		{
			get
			{
				return this.gameplayBirthday_;
			}
			set
			{
				this.gameplayBirthday_ = value;
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x000C2EB9 File Offset: 0x000C10B9
		// (set) Token: 0x0600472B RID: 18219 RVA: 0x000C2EC1 File Offset: 0x000C10C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastSetNicknameTime
		{
			get
			{
				return this.lastSetNicknameTime_;
			}
			set
			{
				this.lastSetNicknameTime_ = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x0600472C RID: 18220 RVA: 0x000C2ECA File Offset: 0x000C10CA
		// (set) Token: 0x0600472D RID: 18221 RVA: 0x000C2ED2 File Offset: 0x000C10D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WeekCocoonFinishedCount
		{
			get
			{
				return this.weekCocoonFinishedCount_;
			}
			set
			{
				this.weekCocoonFinishedCount_ = value;
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x000C2EDB File Offset: 0x000C10DB
		// (set) Token: 0x0600472F RID: 18223 RVA: 0x000C2EE3 File Offset: 0x000C10E3
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

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06004730 RID: 18224 RVA: 0x000C2EEC File Offset: 0x000C10EC
		// (set) Token: 0x06004731 RID: 18225 RVA: 0x000C2EF4 File Offset: 0x000C10F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Gender
		{
			get
			{
				return this.gender_;
			}
			set
			{
				this.gender_ = value;
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x000C2EFD File Offset: 0x000C10FD
		// (set) Token: 0x06004733 RID: 18227 RVA: 0x000C2F05 File Offset: 0x000C1105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextRecoverTime
		{
			get
			{
				return this.nextRecoverTime_;
			}
			set
			{
				this.nextRecoverTime_ = value;
			}
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x000C2F0E File Offset: 0x000C110E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBasicInfoScRsp);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x000C2F1C File Offset: 0x000C111C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetBasicInfoScRsp other)
		{
			return other != null && (other == this || (this.IsGenderSet == other.IsGenderSet && this.CurDay == other.CurDay && this.ExchangeTimes == other.ExchangeTimes && object.Equals(this.PlayerSettingInfo, other.PlayerSettingInfo) && this.GameplayBirthday == other.GameplayBirthday && this.LastSetNicknameTime == other.LastSetNicknameTime && this.WeekCocoonFinishedCount == other.WeekCocoonFinishedCount && this.Retcode == other.Retcode && this.Gender == other.Gender && this.NextRecoverTime == other.NextRecoverTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x000C2FEC File Offset: 0x000C11EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsGenderSet)
			{
				num ^= this.IsGenderSet.GetHashCode();
			}
			if (this.CurDay != 0U)
			{
				num ^= this.CurDay.GetHashCode();
			}
			if (this.ExchangeTimes != 0U)
			{
				num ^= this.ExchangeTimes.GetHashCode();
			}
			if (this.playerSettingInfo_ != null)
			{
				num ^= this.PlayerSettingInfo.GetHashCode();
			}
			if (this.GameplayBirthday != 0U)
			{
				num ^= this.GameplayBirthday.GetHashCode();
			}
			if (this.LastSetNicknameTime != 0L)
			{
				num ^= this.LastSetNicknameTime.GetHashCode();
			}
			if (this.WeekCocoonFinishedCount != 0U)
			{
				num ^= this.WeekCocoonFinishedCount.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Gender != 0U)
			{
				num ^= this.Gender.GetHashCode();
			}
			if (this.NextRecoverTime != 0L)
			{
				num ^= this.NextRecoverTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x000C3109 File Offset: 0x000C1309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x000C3111 File Offset: 0x000C1311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x000C311C File Offset: 0x000C131C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameplayBirthday != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameplayBirthday);
			}
			if (this.IsGenderSet)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsGenderSet);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.WeekCocoonFinishedCount != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.WeekCocoonFinishedCount);
			}
			if (this.Gender != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Gender);
			}
			if (this.playerSettingInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PlayerSettingInfo);
			}
			if (this.LastSetNicknameTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.LastSetNicknameTime);
			}
			if (this.CurDay != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CurDay);
			}
			if (this.NextRecoverTime != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.NextRecoverTime);
			}
			if (this.ExchangeTimes != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ExchangeTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x000C3254 File Offset: 0x000C1454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsGenderSet)
			{
				num += 2;
			}
			if (this.CurDay != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurDay);
			}
			if (this.ExchangeTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExchangeTimes);
			}
			if (this.playerSettingInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerSettingInfo);
			}
			if (this.GameplayBirthday != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameplayBirthday);
			}
			if (this.LastSetNicknameTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastSetNicknameTime);
			}
			if (this.WeekCocoonFinishedCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WeekCocoonFinishedCount);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Gender != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Gender);
			}
			if (this.NextRecoverTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextRecoverTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x000C3360 File Offset: 0x000C1560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetBasicInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsGenderSet)
			{
				this.IsGenderSet = other.IsGenderSet;
			}
			if (other.CurDay != 0U)
			{
				this.CurDay = other.CurDay;
			}
			if (other.ExchangeTimes != 0U)
			{
				this.ExchangeTimes = other.ExchangeTimes;
			}
			if (other.playerSettingInfo_ != null)
			{
				if (this.playerSettingInfo_ == null)
				{
					this.PlayerSettingInfo = new PlayerSettingInfo();
				}
				this.PlayerSettingInfo.MergeFrom(other.PlayerSettingInfo);
			}
			if (other.GameplayBirthday != 0U)
			{
				this.GameplayBirthday = other.GameplayBirthday;
			}
			if (other.LastSetNicknameTime != 0L)
			{
				this.LastSetNicknameTime = other.LastSetNicknameTime;
			}
			if (other.WeekCocoonFinishedCount != 0U)
			{
				this.WeekCocoonFinishedCount = other.WeekCocoonFinishedCount;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Gender != 0U)
			{
				this.Gender = other.Gender;
			}
			if (other.NextRecoverTime != 0L)
			{
				this.NextRecoverTime = other.NextRecoverTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x000C3468 File Offset: 0x000C1668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x000C3474 File Offset: 0x000C1674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.GameplayBirthday = input.ReadUInt32();
							continue;
						}
						if (num == 24U)
						{
							this.IsGenderSet = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.WeekCocoonFinishedCount = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.Gender = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 74U)
					{
						if (this.playerSettingInfo_ == null)
						{
							this.PlayerSettingInfo = new PlayerSettingInfo();
						}
						input.ReadMessage(this.PlayerSettingInfo);
						continue;
					}
					if (num == 80U)
					{
						this.LastSetNicknameTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.CurDay = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.NextRecoverTime = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.ExchangeTimes = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C7B RID: 7291
		private static readonly MessageParser<GetBasicInfoScRsp> _parser = new MessageParser<GetBasicInfoScRsp>(() => new GetBasicInfoScRsp());

		// Token: 0x04001C7C RID: 7292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C7D RID: 7293
		public const int IsGenderSetFieldNumber = 3;

		// Token: 0x04001C7E RID: 7294
		private bool isGenderSet_;

		// Token: 0x04001C7F RID: 7295
		public const int CurDayFieldNumber = 11;

		// Token: 0x04001C80 RID: 7296
		private uint curDay_;

		// Token: 0x04001C81 RID: 7297
		public const int ExchangeTimesFieldNumber = 14;

		// Token: 0x04001C82 RID: 7298
		private uint exchangeTimes_;

		// Token: 0x04001C83 RID: 7299
		public const int PlayerSettingInfoFieldNumber = 9;

		// Token: 0x04001C84 RID: 7300
		private PlayerSettingInfo playerSettingInfo_;

		// Token: 0x04001C85 RID: 7301
		public const int GameplayBirthdayFieldNumber = 1;

		// Token: 0x04001C86 RID: 7302
		private uint gameplayBirthday_;

		// Token: 0x04001C87 RID: 7303
		public const int LastSetNicknameTimeFieldNumber = 10;

		// Token: 0x04001C88 RID: 7304
		private long lastSetNicknameTime_;

		// Token: 0x04001C89 RID: 7305
		public const int WeekCocoonFinishedCountFieldNumber = 6;

		// Token: 0x04001C8A RID: 7306
		private uint weekCocoonFinishedCount_;

		// Token: 0x04001C8B RID: 7307
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001C8C RID: 7308
		private uint retcode_;

		// Token: 0x04001C8D RID: 7309
		public const int GenderFieldNumber = 8;

		// Token: 0x04001C8E RID: 7310
		private uint gender_;

		// Token: 0x04001C8F RID: 7311
		public const int NextRecoverTimeFieldNumber = 12;

		// Token: 0x04001C90 RID: 7312
		private long nextRecoverTime_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EDD RID: 3805
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGetInfo : IMessage<RogueMagicGetInfo>, IMessage, IEquatable<RogueMagicGetInfo>, IDeepCloneable<RogueMagicGetInfo>, IBufferMessage
	{
		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x0600AA17 RID: 43543 RVA: 0x001CA45D File Offset: 0x001C865D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGetInfo> Parser
		{
			get
			{
				return RogueMagicGetInfo._parser;
			}
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x0600AA18 RID: 43544 RVA: 0x001CA464 File Offset: 0x001C8664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x0600AA19 RID: 43545 RVA: 0x001CA476 File Offset: 0x001C8676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGetInfo.Descriptor;
			}
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x001CA47D File Offset: 0x001C867D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetInfo()
		{
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x001CA4B4 File Offset: 0x001C86B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetInfo(RogueMagicGetInfo other) : this()
		{
			this.storyInfo_ = ((other.storyInfo_ != null) ? other.storyInfo_.Clone() : null);
			this.rogueTournAreaInfo_ = other.rogueTournAreaInfo_.Clone();
			this.rogueMagicTalentInfo_ = ((other.rogueMagicTalentInfo_ != null) ? other.rogueMagicTalentInfo_.Clone() : null);
			this.rogueMagicScepterInfoList_ = other.rogueMagicScepterInfoList_.Clone();
			this.rogueMagicUnitInfoList_ = other.rogueMagicUnitInfoList_.Clone();
			this.rogueTournDifficultyInfo_ = other.rogueTournDifficultyInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x001CA554 File Offset: 0x001C8754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetInfo Clone()
		{
			return new RogueMagicGetInfo(this);
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x0600AA1D RID: 43549 RVA: 0x001CA55C File Offset: 0x001C875C
		// (set) Token: 0x0600AA1E RID: 43550 RVA: 0x001CA564 File Offset: 0x001C8764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStoryInfo StoryInfo
		{
			get
			{
				return this.storyInfo_;
			}
			set
			{
				this.storyInfo_ = value;
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x0600AA1F RID: 43551 RVA: 0x001CA56D File Offset: 0x001C876D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicAreaInfo> RogueTournAreaInfo
		{
			get
			{
				return this.rogueTournAreaInfo_;
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x0600AA20 RID: 43552 RVA: 0x001CA575 File Offset: 0x001C8775
		// (set) Token: 0x0600AA21 RID: 43553 RVA: 0x001CA57D File Offset: 0x001C877D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicTalentInfo RogueMagicTalentInfo
		{
			get
			{
				return this.rogueMagicTalentInfo_;
			}
			set
			{
				this.rogueMagicTalentInfo_ = value;
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x0600AA22 RID: 43554 RVA: 0x001CA586 File Offset: 0x001C8786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicScepterInfo> RogueMagicScepterInfoList
		{
			get
			{
				return this.rogueMagicScepterInfoList_;
			}
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0600AA23 RID: 43555 RVA: 0x001CA58E File Offset: 0x001C878E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicUnitInfo> RogueMagicUnitInfoList
		{
			get
			{
				return this.rogueMagicUnitInfoList_;
			}
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0600AA24 RID: 43556 RVA: 0x001CA596 File Offset: 0x001C8796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicDifficultyInfo> RogueTournDifficultyInfo
		{
			get
			{
				return this.rogueTournDifficultyInfo_;
			}
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x001CA59E File Offset: 0x001C879E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGetInfo);
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x001CA5AC File Offset: 0x001C87AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGetInfo other)
		{
			return other != null && (other == this || (object.Equals(this.StoryInfo, other.StoryInfo) && this.rogueTournAreaInfo_.Equals(other.rogueTournAreaInfo_) && object.Equals(this.RogueMagicTalentInfo, other.RogueMagicTalentInfo) && this.rogueMagicScepterInfoList_.Equals(other.rogueMagicScepterInfoList_) && this.rogueMagicUnitInfoList_.Equals(other.rogueMagicUnitInfoList_) && this.rogueTournDifficultyInfo_.Equals(other.rogueTournDifficultyInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x001CA654 File Offset: 0x001C8854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.storyInfo_ != null)
			{
				num ^= this.StoryInfo.GetHashCode();
			}
			num ^= this.rogueTournAreaInfo_.GetHashCode();
			if (this.rogueMagicTalentInfo_ != null)
			{
				num ^= this.RogueMagicTalentInfo.GetHashCode();
			}
			num ^= this.rogueMagicScepterInfoList_.GetHashCode();
			num ^= this.rogueMagicUnitInfoList_.GetHashCode();
			num ^= this.rogueTournDifficultyInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x001CA6DE File Offset: 0x001C88DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x001CA6E6 File Offset: 0x001C88E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA2A RID: 43562 RVA: 0x001CA6F0 File Offset: 0x001C88F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.storyInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.StoryInfo);
			}
			this.rogueTournAreaInfo_.WriteTo(ref output, RogueMagicGetInfo._repeated_rogueTournAreaInfo_codec);
			this.rogueMagicUnitInfoList_.WriteTo(ref output, RogueMagicGetInfo._repeated_rogueMagicUnitInfoList_codec);
			this.rogueMagicScepterInfoList_.WriteTo(ref output, RogueMagicGetInfo._repeated_rogueMagicScepterInfoList_codec);
			this.rogueTournDifficultyInfo_.WriteTo(ref output, RogueMagicGetInfo._repeated_rogueTournDifficultyInfo_codec);
			if (this.rogueMagicTalentInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueMagicTalentInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x001CA790 File Offset: 0x001C8990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.storyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StoryInfo);
			}
			num += this.rogueTournAreaInfo_.CalculateSize(RogueMagicGetInfo._repeated_rogueTournAreaInfo_codec);
			if (this.rogueMagicTalentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueMagicTalentInfo);
			}
			num += this.rogueMagicScepterInfoList_.CalculateSize(RogueMagicGetInfo._repeated_rogueMagicScepterInfoList_codec);
			num += this.rogueMagicUnitInfoList_.CalculateSize(RogueMagicGetInfo._repeated_rogueMagicUnitInfoList_codec);
			num += this.rogueTournDifficultyInfo_.CalculateSize(RogueMagicGetInfo._repeated_rogueTournDifficultyInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA2C RID: 43564 RVA: 0x001CA834 File Offset: 0x001C8A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.storyInfo_ != null)
			{
				if (this.storyInfo_ == null)
				{
					this.StoryInfo = new RogueMagicStoryInfo();
				}
				this.StoryInfo.MergeFrom(other.StoryInfo);
			}
			this.rogueTournAreaInfo_.Add(other.rogueTournAreaInfo_);
			if (other.rogueMagicTalentInfo_ != null)
			{
				if (this.rogueMagicTalentInfo_ == null)
				{
					this.RogueMagicTalentInfo = new RogueMagicTalentInfo();
				}
				this.RogueMagicTalentInfo.MergeFrom(other.RogueMagicTalentInfo);
			}
			this.rogueMagicScepterInfoList_.Add(other.rogueMagicScepterInfoList_);
			this.rogueMagicUnitInfoList_.Add(other.rogueMagicUnitInfoList_);
			this.rogueTournDifficultyInfo_.Add(other.rogueTournDifficultyInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x001CA8F8 File Offset: 0x001C8AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA2E RID: 43566 RVA: 0x001CA904 File Offset: 0x001C8B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 26U)
					{
						if (this.storyInfo_ == null)
						{
							this.StoryInfo = new RogueMagicStoryInfo();
						}
						input.ReadMessage(this.StoryInfo);
						continue;
					}
					if (num == 42U)
					{
						this.rogueTournAreaInfo_.AddEntriesFrom(ref input, RogueMagicGetInfo._repeated_rogueTournAreaInfo_codec);
						continue;
					}
					if (num == 50U)
					{
						this.rogueMagicUnitInfoList_.AddEntriesFrom(ref input, RogueMagicGetInfo._repeated_rogueMagicUnitInfoList_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.rogueMagicScepterInfoList_.AddEntriesFrom(ref input, RogueMagicGetInfo._repeated_rogueMagicScepterInfoList_codec);
						continue;
					}
					if (num == 74U)
					{
						this.rogueTournDifficultyInfo_.AddEntriesFrom(ref input, RogueMagicGetInfo._repeated_rogueTournDifficultyInfo_codec);
						continue;
					}
					if (num == 82U)
					{
						if (this.rogueMagicTalentInfo_ == null)
						{
							this.RogueMagicTalentInfo = new RogueMagicTalentInfo();
						}
						input.ReadMessage(this.RogueMagicTalentInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004570 RID: 17776
		private static readonly MessageParser<RogueMagicGetInfo> _parser = new MessageParser<RogueMagicGetInfo>(() => new RogueMagicGetInfo());

		// Token: 0x04004571 RID: 17777
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004572 RID: 17778
		public const int StoryInfoFieldNumber = 3;

		// Token: 0x04004573 RID: 17779
		private RogueMagicStoryInfo storyInfo_;

		// Token: 0x04004574 RID: 17780
		public const int RogueTournAreaInfoFieldNumber = 5;

		// Token: 0x04004575 RID: 17781
		private static readonly FieldCodec<RogueMagicAreaInfo> _repeated_rogueTournAreaInfo_codec = FieldCodec.ForMessage<RogueMagicAreaInfo>(42U, RogueMagicAreaInfo.Parser);

		// Token: 0x04004576 RID: 17782
		private readonly RepeatedField<RogueMagicAreaInfo> rogueTournAreaInfo_ = new RepeatedField<RogueMagicAreaInfo>();

		// Token: 0x04004577 RID: 17783
		public const int RogueMagicTalentInfoFieldNumber = 10;

		// Token: 0x04004578 RID: 17784
		private RogueMagicTalentInfo rogueMagicTalentInfo_;

		// Token: 0x04004579 RID: 17785
		public const int RogueMagicScepterInfoListFieldNumber = 8;

		// Token: 0x0400457A RID: 17786
		private static readonly FieldCodec<RogueMagicScepterInfo> _repeated_rogueMagicScepterInfoList_codec = FieldCodec.ForMessage<RogueMagicScepterInfo>(66U, RogueMagicScepterInfo.Parser);

		// Token: 0x0400457B RID: 17787
		private readonly RepeatedField<RogueMagicScepterInfo> rogueMagicScepterInfoList_ = new RepeatedField<RogueMagicScepterInfo>();

		// Token: 0x0400457C RID: 17788
		public const int RogueMagicUnitInfoListFieldNumber = 6;

		// Token: 0x0400457D RID: 17789
		private static readonly FieldCodec<RogueMagicUnitInfo> _repeated_rogueMagicUnitInfoList_codec = FieldCodec.ForMessage<RogueMagicUnitInfo>(50U, RogueMagicUnitInfo.Parser);

		// Token: 0x0400457E RID: 17790
		private readonly RepeatedField<RogueMagicUnitInfo> rogueMagicUnitInfoList_ = new RepeatedField<RogueMagicUnitInfo>();

		// Token: 0x0400457F RID: 17791
		public const int RogueTournDifficultyInfoFieldNumber = 9;

		// Token: 0x04004580 RID: 17792
		private static readonly FieldCodec<RogueMagicDifficultyInfo> _repeated_rogueTournDifficultyInfo_codec = FieldCodec.ForMessage<RogueMagicDifficultyInfo>(74U, RogueMagicDifficultyInfo.Parser);

		// Token: 0x04004581 RID: 17793
		private readonly RepeatedField<RogueMagicDifficultyInfo> rogueTournDifficultyInfo_ = new RepeatedField<RogueMagicDifficultyInfo>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001013 RID: 4115
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournSaveList : IMessage<RogueTournSaveList>, IMessage, IEquatable<RogueTournSaveList>, IDeepCloneable<RogueTournSaveList>, IBufferMessage
	{
		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600B703 RID: 46851 RVA: 0x001EAF47 File Offset: 0x001E9147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournSaveList> Parser
		{
			get
			{
				return RogueTournSaveList._parser;
			}
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600B704 RID: 46852 RVA: 0x001EAF4E File Offset: 0x001E914E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournSaveListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600B705 RID: 46853 RVA: 0x001EAF60 File Offset: 0x001E9160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournSaveList.Descriptor;
			}
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x001EAF67 File Offset: 0x001E9167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSaveList()
		{
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x001EAF7C File Offset: 0x001E917C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSaveList(RogueTournSaveList other) : this()
		{
			this.time_ = other.time_;
			this.endTime_ = other.endTime_;
			this.name_ = other.name_;
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this.maxTimes_ = other.maxTimes_;
			this.rogueSeasonInfo_ = ((other.rogueSeasonInfo_ != null) ? other.rogueSeasonInfo_.Clone() : null);
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x001EB024 File Offset: 0x001E9224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSaveList Clone()
		{
			return new RogueTournSaveList(this);
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600B709 RID: 46857 RVA: 0x001EB02C File Offset: 0x001E922C
		// (set) Token: 0x0600B70A RID: 46858 RVA: 0x001EB034 File Offset: 0x001E9234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Time
		{
			get
			{
				return this.time_;
			}
			set
			{
				this.time_ = value;
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600B70B RID: 46859 RVA: 0x001EB03D File Offset: 0x001E923D
		// (set) Token: 0x0600B70C RID: 46860 RVA: 0x001EB045 File Offset: 0x001E9245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600B70D RID: 46861 RVA: 0x001EB04E File Offset: 0x001E924E
		// (set) Token: 0x0600B70E RID: 46862 RVA: 0x001EB056 File Offset: 0x001E9256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600B70F RID: 46863 RVA: 0x001EB069 File Offset: 0x001E9269
		// (set) Token: 0x0600B710 RID: 46864 RVA: 0x001EB071 File Offset: 0x001E9271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurInfo RogueTournCurInfo
		{
			get
			{
				return this.rogueTournCurInfo_;
			}
			set
			{
				this.rogueTournCurInfo_ = value;
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600B711 RID: 46865 RVA: 0x001EB07A File Offset: 0x001E927A
		// (set) Token: 0x0600B712 RID: 46866 RVA: 0x001EB082 File Offset: 0x001E9282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600B713 RID: 46867 RVA: 0x001EB08B File Offset: 0x001E928B
		// (set) Token: 0x0600B714 RID: 46868 RVA: 0x001EB093 File Offset: 0x001E9293
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

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600B715 RID: 46869 RVA: 0x001EB09C File Offset: 0x001E929C
		// (set) Token: 0x0600B716 RID: 46870 RVA: 0x001EB0A4 File Offset: 0x001E92A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBAPLJDBOCB Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x001EB0AD File Offset: 0x001E92AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournSaveList);
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x001EB0BC File Offset: 0x001E92BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournSaveList other)
		{
			return other != null && (other == this || (this.Time == other.Time && this.EndTime == other.EndTime && !(this.Name != other.Name) && object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && this.MaxTimes == other.MaxTimes && object.Equals(this.RogueSeasonInfo, other.RogueSeasonInfo) && object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B719 RID: 46873 RVA: 0x001EB16C File Offset: 0x001E936C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Time != 0L)
			{
				num ^= this.Time.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
			}
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
			}
			if (this.rogueSeasonInfo_ != null)
			{
				num ^= this.RogueSeasonInfo.GetHashCode();
			}
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x001EB23A File Offset: 0x001E943A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x001EB242 File Offset: 0x001E9442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B71C RID: 46876 RVA: 0x001EB24C File Offset: 0x001E944C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Data);
			}
			if (this.rogueSeasonInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueSeasonInfo);
			}
			if (this.Time != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.Time);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Name);
			}
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MaxTimes);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x001EB338 File Offset: 0x001E9538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Time != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Time);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
			}
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
			}
			if (this.rogueSeasonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueSeasonInfo);
			}
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x001EB40C File Offset: 0x001E960C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournSaveList other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Time != 0L)
			{
				this.Time = other.Time;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueTournCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			if (other.rogueSeasonInfo_ != null)
			{
				if (this.rogueSeasonInfo_ == null)
				{
					this.RogueSeasonInfo = new RogueTournSeasonInfo();
				}
				this.RogueSeasonInfo.MergeFrom(other.RogueSeasonInfo);
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new NBAPLJDBOCB();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x001EB50D File Offset: 0x001E970D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x001EB518 File Offset: 0x001E9718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 10U)
					{
						if (this.data_ == null)
						{
							this.Data = new NBAPLJDBOCB();
						}
						input.ReadMessage(this.Data);
						continue;
					}
					if (num == 34U)
					{
						if (this.rogueSeasonInfo_ == null)
						{
							this.RogueSeasonInfo = new RogueTournSeasonInfo();
						}
						input.ReadMessage(this.RogueSeasonInfo);
						continue;
					}
					if (num == 40U)
					{
						this.Time = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 98U)
				{
					if (num == 58U)
					{
						if (this.rogueTournCurInfo_ == null)
						{
							this.RogueTournCurInfo = new RogueTournCurInfo();
						}
						input.ReadMessage(this.RogueTournCurInfo);
						continue;
					}
					if (num == 98U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.MaxTimes = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A21 RID: 18977
		private static readonly MessageParser<RogueTournSaveList> _parser = new MessageParser<RogueTournSaveList>(() => new RogueTournSaveList());

		// Token: 0x04004A22 RID: 18978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A23 RID: 18979
		public const int TimeFieldNumber = 5;

		// Token: 0x04004A24 RID: 18980
		private long time_;

		// Token: 0x04004A25 RID: 18981
		public const int EndTimeFieldNumber = 15;

		// Token: 0x04004A26 RID: 18982
		private long endTime_;

		// Token: 0x04004A27 RID: 18983
		public const int NameFieldNumber = 12;

		// Token: 0x04004A28 RID: 18984
		private string name_ = "";

		// Token: 0x04004A29 RID: 18985
		public const int RogueTournCurInfoFieldNumber = 7;

		// Token: 0x04004A2A RID: 18986
		private RogueTournCurInfo rogueTournCurInfo_;

		// Token: 0x04004A2B RID: 18987
		public const int MaxTimesFieldNumber = 13;

		// Token: 0x04004A2C RID: 18988
		private uint maxTimes_;

		// Token: 0x04004A2D RID: 18989
		public const int RogueSeasonInfoFieldNumber = 4;

		// Token: 0x04004A2E RID: 18990
		private RogueTournSeasonInfo rogueSeasonInfo_;

		// Token: 0x04004A2F RID: 18991
		public const int DataFieldNumber = 1;

		// Token: 0x04004A30 RID: 18992
		private NBAPLJDBOCB data_;
	}
}

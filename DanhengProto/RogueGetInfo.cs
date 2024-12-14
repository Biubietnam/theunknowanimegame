using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E99 RID: 3737
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGetInfo : IMessage<RogueGetInfo>, IMessage, IEquatable<RogueGetInfo>, IDeepCloneable<RogueGetInfo>, IBufferMessage
	{
		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0600A6F3 RID: 42739 RVA: 0x001C1B59 File Offset: 0x001BFD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGetInfo> Parser
		{
			get
			{
				return RogueGetInfo._parser;
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600A6F4 RID: 42740 RVA: 0x001C1B60 File Offset: 0x001BFD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600A6F5 RID: 42741 RVA: 0x001C1B72 File Offset: 0x001BFD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGetInfo.Descriptor;
			}
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x001C1B79 File Offset: 0x001BFD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetInfo()
		{
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x001C1B84 File Offset: 0x001BFD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetInfo(RogueGetInfo other) : this()
		{
			this.rogueVirtualItemInfo_ = ((other.rogueVirtualItemInfo_ != null) ? other.rogueVirtualItemInfo_.Clone() : null);
			this.rogueScoreRewardInfo_ = ((other.rogueScoreRewardInfo_ != null) ? other.rogueScoreRewardInfo_.Clone() : null);
			this.rogueAreaInfo_ = ((other.rogueAreaInfo_ != null) ? other.rogueAreaInfo_.Clone() : null);
			this.rogueAeonInfo_ = ((other.rogueAeonInfo_ != null) ? other.rogueAeonInfo_.Clone() : null);
			this.rogueSeasonInfo_ = ((other.rogueSeasonInfo_ != null) ? other.rogueSeasonInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6F8 RID: 42744 RVA: 0x001C1C34 File Offset: 0x001BFE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetInfo Clone()
		{
			return new RogueGetInfo(this);
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x0600A6F9 RID: 42745 RVA: 0x001C1C3C File Offset: 0x001BFE3C
		// (set) Token: 0x0600A6FA RID: 42746 RVA: 0x001C1C44 File Offset: 0x001BFE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetVirtualItemInfo RogueVirtualItemInfo
		{
			get
			{
				return this.rogueVirtualItemInfo_;
			}
			set
			{
				this.rogueVirtualItemInfo_ = value;
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x0600A6FB RID: 42747 RVA: 0x001C1C4D File Offset: 0x001BFE4D
		// (set) Token: 0x0600A6FC RID: 42748 RVA: 0x001C1C55 File Offset: 0x001BFE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo RogueScoreRewardInfo
		{
			get
			{
				return this.rogueScoreRewardInfo_;
			}
			set
			{
				this.rogueScoreRewardInfo_ = value;
			}
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x0600A6FD RID: 42749 RVA: 0x001C1C5E File Offset: 0x001BFE5E
		// (set) Token: 0x0600A6FE RID: 42750 RVA: 0x001C1C66 File Offset: 0x001BFE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAreaInfo RogueAreaInfo
		{
			get
			{
				return this.rogueAreaInfo_;
			}
			set
			{
				this.rogueAreaInfo_ = value;
			}
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x0600A6FF RID: 42751 RVA: 0x001C1C6F File Offset: 0x001BFE6F
		// (set) Token: 0x0600A700 RID: 42752 RVA: 0x001C1C77 File Offset: 0x001BFE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAeonInfo RogueAeonInfo
		{
			get
			{
				return this.rogueAeonInfo_;
			}
			set
			{
				this.rogueAeonInfo_ = value;
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x0600A701 RID: 42753 RVA: 0x001C1C80 File Offset: 0x001BFE80
		// (set) Token: 0x0600A702 RID: 42754 RVA: 0x001C1C88 File Offset: 0x001BFE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonInfo RogueSeasonInfo
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

		// Token: 0x0600A703 RID: 42755 RVA: 0x001C1C91 File Offset: 0x001BFE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGetInfo);
		}

		// Token: 0x0600A704 RID: 42756 RVA: 0x001C1CA0 File Offset: 0x001BFEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGetInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueVirtualItemInfo, other.RogueVirtualItemInfo) && object.Equals(this.RogueScoreRewardInfo, other.RogueScoreRewardInfo) && object.Equals(this.RogueAreaInfo, other.RogueAreaInfo) && object.Equals(this.RogueAeonInfo, other.RogueAeonInfo) && object.Equals(this.RogueSeasonInfo, other.RogueSeasonInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A705 RID: 42757 RVA: 0x001C1D34 File Offset: 0x001BFF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueVirtualItemInfo_ != null)
			{
				num ^= this.RogueVirtualItemInfo.GetHashCode();
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				num ^= this.RogueScoreRewardInfo.GetHashCode();
			}
			if (this.rogueAreaInfo_ != null)
			{
				num ^= this.RogueAreaInfo.GetHashCode();
			}
			if (this.rogueAeonInfo_ != null)
			{
				num ^= this.RogueAeonInfo.GetHashCode();
			}
			if (this.rogueSeasonInfo_ != null)
			{
				num ^= this.RogueSeasonInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A706 RID: 42758 RVA: 0x001C1DC8 File Offset: 0x001BFFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A707 RID: 42759 RVA: 0x001C1DD0 File Offset: 0x001BFFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A708 RID: 42760 RVA: 0x001C1DDC File Offset: 0x001BFFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueVirtualItemInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueVirtualItemInfo);
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueScoreRewardInfo);
			}
			if (this.rogueAeonInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RogueAeonInfo);
			}
			if (this.rogueSeasonInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueSeasonInfo);
			}
			if (this.rogueAreaInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueAreaInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A709 RID: 42761 RVA: 0x001C1E8C File Offset: 0x001C008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueVirtualItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueVirtualItemInfo);
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueScoreRewardInfo);
			}
			if (this.rogueAreaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAreaInfo);
			}
			if (this.rogueAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAeonInfo);
			}
			if (this.rogueSeasonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueSeasonInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A70A RID: 42762 RVA: 0x001C1F2C File Offset: 0x001C012C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueVirtualItemInfo_ != null)
			{
				if (this.rogueVirtualItemInfo_ == null)
				{
					this.RogueVirtualItemInfo = new RogueGetVirtualItemInfo();
				}
				this.RogueVirtualItemInfo.MergeFrom(other.RogueVirtualItemInfo);
			}
			if (other.rogueScoreRewardInfo_ != null)
			{
				if (this.rogueScoreRewardInfo_ == null)
				{
					this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
				}
				this.RogueScoreRewardInfo.MergeFrom(other.RogueScoreRewardInfo);
			}
			if (other.rogueAreaInfo_ != null)
			{
				if (this.rogueAreaInfo_ == null)
				{
					this.RogueAreaInfo = new RogueAreaInfo();
				}
				this.RogueAreaInfo.MergeFrom(other.RogueAreaInfo);
			}
			if (other.rogueAeonInfo_ != null)
			{
				if (this.rogueAeonInfo_ == null)
				{
					this.RogueAeonInfo = new RogueAeonInfo();
				}
				this.RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
			}
			if (other.rogueSeasonInfo_ != null)
			{
				if (this.rogueSeasonInfo_ == null)
				{
					this.RogueSeasonInfo = new RogueSeasonInfo();
				}
				this.RogueSeasonInfo.MergeFrom(other.RogueSeasonInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A70B RID: 42763 RVA: 0x001C2030 File Offset: 0x001C0230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A70C RID: 42764 RVA: 0x001C203C File Offset: 0x001C023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 34U)
					{
						if (this.rogueVirtualItemInfo_ == null)
						{
							this.RogueVirtualItemInfo = new RogueGetVirtualItemInfo();
						}
						input.ReadMessage(this.RogueVirtualItemInfo);
						continue;
					}
					if (num == 82U)
					{
						if (this.rogueScoreRewardInfo_ == null)
						{
							this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
						}
						input.ReadMessage(this.RogueScoreRewardInfo);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.rogueAeonInfo_ == null)
						{
							this.RogueAeonInfo = new RogueAeonInfo();
						}
						input.ReadMessage(this.RogueAeonInfo);
						continue;
					}
					if (num == 106U)
					{
						if (this.rogueSeasonInfo_ == null)
						{
							this.RogueSeasonInfo = new RogueSeasonInfo();
						}
						input.ReadMessage(this.RogueSeasonInfo);
						continue;
					}
					if (num == 114U)
					{
						if (this.rogueAreaInfo_ == null)
						{
							this.RogueAreaInfo = new RogueAreaInfo();
						}
						input.ReadMessage(this.RogueAreaInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004448 RID: 17480
		private static readonly MessageParser<RogueGetInfo> _parser = new MessageParser<RogueGetInfo>(() => new RogueGetInfo());

		// Token: 0x04004449 RID: 17481
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400444A RID: 17482
		public const int RogueVirtualItemInfoFieldNumber = 4;

		// Token: 0x0400444B RID: 17483
		private RogueGetVirtualItemInfo rogueVirtualItemInfo_;

		// Token: 0x0400444C RID: 17484
		public const int RogueScoreRewardInfoFieldNumber = 10;

		// Token: 0x0400444D RID: 17485
		private RogueScoreRewardInfo rogueScoreRewardInfo_;

		// Token: 0x0400444E RID: 17486
		public const int RogueAreaInfoFieldNumber = 14;

		// Token: 0x0400444F RID: 17487
		private RogueAreaInfo rogueAreaInfo_;

		// Token: 0x04004450 RID: 17488
		public const int RogueAeonInfoFieldNumber = 12;

		// Token: 0x04004451 RID: 17489
		private RogueAeonInfo rogueAeonInfo_;

		// Token: 0x04004452 RID: 17490
		public const int RogueSeasonInfoFieldNumber = 13;

		// Token: 0x04004453 RID: 17491
		private RogueSeasonInfo rogueSeasonInfo_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E89 RID: 3721
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGambleInfo : IMessage<RogueGambleInfo>, IMessage, IEquatable<RogueGambleInfo>, IDeepCloneable<RogueGambleInfo>, IBufferMessage
	{
		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0600A626 RID: 42534 RVA: 0x001BF447 File Offset: 0x001BD647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGambleInfo> Parser
		{
			get
			{
				return RogueGambleInfo._parser;
			}
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x0600A627 RID: 42535 RVA: 0x001BF44E File Offset: 0x001BD64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGambleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x0600A628 RID: 42536 RVA: 0x001BF460 File Offset: 0x001BD660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGambleInfo.Descriptor;
			}
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x001BF467 File Offset: 0x001BD667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleInfo()
		{
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x001BF47C File Offset: 0x001BD67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleInfo(RogueGambleInfo other) : this()
		{
			this.curTimes_ = other.curTimes_;
			this.maxGameTimes_ = other.maxGameTimes_;
			this.iHEIOJKJIEH_ = other.iHEIOJKJIEH_;
			this.mOMKFEJMJMI_ = other.mOMKFEJMJMI_;
			this.curCostItem_ = ((other.curCostItem_ != null) ? other.curCostItem_.Clone() : null);
			this.canPlay_ = other.canPlay_;
			this.mazeGroupList_ = other.mazeGroupList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x001BF509 File Offset: 0x001BD709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleInfo Clone()
		{
			return new RogueGambleInfo(this);
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x0600A62C RID: 42540 RVA: 0x001BF511 File Offset: 0x001BD711
		// (set) Token: 0x0600A62D RID: 42541 RVA: 0x001BF519 File Offset: 0x001BD719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurTimes
		{
			get
			{
				return this.curTimes_;
			}
			set
			{
				this.curTimes_ = value;
			}
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x0600A62E RID: 42542 RVA: 0x001BF522 File Offset: 0x001BD722
		// (set) Token: 0x0600A62F RID: 42543 RVA: 0x001BF52A File Offset: 0x001BD72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxGameTimes
		{
			get
			{
				return this.maxGameTimes_;
			}
			set
			{
				this.maxGameTimes_ = value;
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x0600A630 RID: 42544 RVA: 0x001BF533 File Offset: 0x001BD733
		// (set) Token: 0x0600A631 RID: 42545 RVA: 0x001BF53B File Offset: 0x001BD73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IHEIOJKJIEH
		{
			get
			{
				return this.iHEIOJKJIEH_;
			}
			set
			{
				this.iHEIOJKJIEH_ = value;
			}
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x0600A632 RID: 42546 RVA: 0x001BF544 File Offset: 0x001BD744
		// (set) Token: 0x0600A633 RID: 42547 RVA: 0x001BF54C File Offset: 0x001BD74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MOMKFEJMJMI
		{
			get
			{
				return this.mOMKFEJMJMI_;
			}
			set
			{
				this.mOMKFEJMJMI_ = value;
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x0600A634 RID: 42548 RVA: 0x001BF555 File Offset: 0x001BD755
		// (set) Token: 0x0600A635 RID: 42549 RVA: 0x001BF55D File Offset: 0x001BD75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData CurCostItem
		{
			get
			{
				return this.curCostItem_;
			}
			set
			{
				this.curCostItem_ = value;
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x0600A636 RID: 42550 RVA: 0x001BF566 File Offset: 0x001BD766
		// (set) Token: 0x0600A637 RID: 42551 RVA: 0x001BF56E File Offset: 0x001BD76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanPlay
		{
			get
			{
				return this.canPlay_;
			}
			set
			{
				this.canPlay_ = value;
			}
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x0600A638 RID: 42552 RVA: 0x001BF577 File Offset: 0x001BD777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGambleMazeGroupInfo> MazeGroupList
		{
			get
			{
				return this.mazeGroupList_;
			}
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x001BF57F File Offset: 0x001BD77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGambleInfo);
		}

		// Token: 0x0600A63A RID: 42554 RVA: 0x001BF590 File Offset: 0x001BD790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGambleInfo other)
		{
			return other != null && (other == this || (this.CurTimes == other.CurTimes && this.MaxGameTimes == other.MaxGameTimes && this.IHEIOJKJIEH == other.IHEIOJKJIEH && this.MOMKFEJMJMI == other.MOMKFEJMJMI && object.Equals(this.CurCostItem, other.CurCostItem) && this.CanPlay == other.CanPlay && this.mazeGroupList_.Equals(other.mazeGroupList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A63B RID: 42555 RVA: 0x001BF634 File Offset: 0x001BD834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurTimes != 0U)
			{
				num ^= this.CurTimes.GetHashCode();
			}
			if (this.MaxGameTimes != 0U)
			{
				num ^= this.MaxGameTimes.GetHashCode();
			}
			if (this.IHEIOJKJIEH != 0U)
			{
				num ^= this.IHEIOJKJIEH.GetHashCode();
			}
			if (this.MOMKFEJMJMI != 0U)
			{
				num ^= this.MOMKFEJMJMI.GetHashCode();
			}
			if (this.curCostItem_ != null)
			{
				num ^= this.CurCostItem.GetHashCode();
			}
			if (this.CanPlay)
			{
				num ^= this.CanPlay.GetHashCode();
			}
			num ^= this.mazeGroupList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x001BF6FB File Offset: 0x001BD8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A63D RID: 42557 RVA: 0x001BF703 File Offset: 0x001BD903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x001BF70C File Offset: 0x001BD90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxGameTimes != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MaxGameTimes);
			}
			if (this.CurTimes != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CurTimes);
			}
			if (this.MOMKFEJMJMI != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MOMKFEJMJMI);
			}
			if (this.IHEIOJKJIEH != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.IHEIOJKJIEH);
			}
			if (this.CanPlay)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.CanPlay);
			}
			if (this.curCostItem_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CurCostItem);
			}
			this.mazeGroupList_.WriteTo(ref output, RogueGambleInfo._repeated_mazeGroupList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x001BF7E8 File Offset: 0x001BD9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurTimes);
			}
			if (this.MaxGameTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxGameTimes);
			}
			if (this.IHEIOJKJIEH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IHEIOJKJIEH);
			}
			if (this.MOMKFEJMJMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MOMKFEJMJMI);
			}
			if (this.curCostItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurCostItem);
			}
			if (this.CanPlay)
			{
				num += 2;
			}
			num += this.mazeGroupList_.CalculateSize(RogueGambleInfo._repeated_mazeGroupList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x001BF8A8 File Offset: 0x001BDAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGambleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurTimes != 0U)
			{
				this.CurTimes = other.CurTimes;
			}
			if (other.MaxGameTimes != 0U)
			{
				this.MaxGameTimes = other.MaxGameTimes;
			}
			if (other.IHEIOJKJIEH != 0U)
			{
				this.IHEIOJKJIEH = other.IHEIOJKJIEH;
			}
			if (other.MOMKFEJMJMI != 0U)
			{
				this.MOMKFEJMJMI = other.MOMKFEJMJMI;
			}
			if (other.curCostItem_ != null)
			{
				if (this.curCostItem_ == null)
				{
					this.CurCostItem = new ItemCostData();
				}
				this.CurCostItem.MergeFrom(other.CurCostItem);
			}
			if (other.CanPlay)
			{
				this.CanPlay = other.CanPlay;
			}
			this.mazeGroupList_.Add(other.mazeGroupList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x001BF971 File Offset: 0x001BDB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x001BF97C File Offset: 0x001BDB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.MaxGameTimes = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurTimes = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.MOMKFEJMJMI = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.IHEIOJKJIEH = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.CanPlay = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.curCostItem_ == null)
						{
							this.CurCostItem = new ItemCostData();
						}
						input.ReadMessage(this.CurCostItem);
						continue;
					}
					if (num == 114U)
					{
						this.mazeGroupList_.AddEntriesFrom(ref input, RogueGambleInfo._repeated_mazeGroupList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043F5 RID: 17397
		private static readonly MessageParser<RogueGambleInfo> _parser = new MessageParser<RogueGambleInfo>(() => new RogueGambleInfo());

		// Token: 0x040043F6 RID: 17398
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043F7 RID: 17399
		public const int CurTimesFieldNumber = 2;

		// Token: 0x040043F8 RID: 17400
		private uint curTimes_;

		// Token: 0x040043F9 RID: 17401
		public const int MaxGameTimesFieldNumber = 1;

		// Token: 0x040043FA RID: 17402
		private uint maxGameTimes_;

		// Token: 0x040043FB RID: 17403
		public const int IHEIOJKJIEHFieldNumber = 8;

		// Token: 0x040043FC RID: 17404
		private uint iHEIOJKJIEH_;

		// Token: 0x040043FD RID: 17405
		public const int MOMKFEJMJMIFieldNumber = 4;

		// Token: 0x040043FE RID: 17406
		private uint mOMKFEJMJMI_;

		// Token: 0x040043FF RID: 17407
		public const int CurCostItemFieldNumber = 12;

		// Token: 0x04004400 RID: 17408
		private ItemCostData curCostItem_;

		// Token: 0x04004401 RID: 17409
		public const int CanPlayFieldNumber = 9;

		// Token: 0x04004402 RID: 17410
		private bool canPlay_;

		// Token: 0x04004403 RID: 17411
		public const int MazeGroupListFieldNumber = 14;

		// Token: 0x04004404 RID: 17412
		private static readonly FieldCodec<RogueGambleMazeGroupInfo> _repeated_mazeGroupList_codec = FieldCodec.ForMessage<RogueGambleMazeGroupInfo>(114U, RogueGambleMazeGroupInfo.Parser);

		// Token: 0x04004405 RID: 17413
		private readonly RepeatedField<RogueGambleMazeGroupInfo> mazeGroupList_ = new RepeatedField<RogueGambleMazeGroupInfo>();
	}
}

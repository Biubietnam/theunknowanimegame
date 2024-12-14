using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D1 RID: 1489
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GachaInfo : IMessage<GachaInfo>, IMessage, IEquatable<GachaInfo>, IDeepCloneable<GachaInfo>, IBufferMessage
	{
		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x000B4D2D File Offset: 0x000B2F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaInfo> Parser
		{
			get
			{
				return GachaInfo._parser;
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x000B4D34 File Offset: 0x000B2F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GachaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x000B4D46 File Offset: 0x000B2F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaInfo.Descriptor;
			}
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x000B4D4D File Offset: 0x000B2F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfo()
		{
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x000B4D84 File Offset: 0x000B2F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfo(GachaInfo other) : this()
		{
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.hNPCPDJPGLL_ = other.hNPCPDJPGLL_;
			this.gachaCeiling_ = ((other.gachaCeiling_ != null) ? other.gachaCeiling_.Clone() : null);
			this.lHMBNMIOKHB_ = other.lHMBNMIOKHB_;
			this.gachaId_ = other.gachaId_;
			this.itemDetailList_ = other.itemDetailList_.Clone();
			this.prizeItemList_ = other.prizeItemList_.Clone();
			this.detailWebview_ = other.detailWebview_;
			this.dropHistoryWebview_ = other.dropHistoryWebview_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x000B4E3A File Offset: 0x000B303A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfo Clone()
		{
			return new GachaInfo(this);
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x000B4E42 File Offset: 0x000B3042
		// (set) Token: 0x06004274 RID: 17012 RVA: 0x000B4E4A File Offset: 0x000B304A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x000B4E53 File Offset: 0x000B3053
		// (set) Token: 0x06004276 RID: 17014 RVA: 0x000B4E5B File Offset: 0x000B305B
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

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x000B4E64 File Offset: 0x000B3064
		// (set) Token: 0x06004278 RID: 17016 RVA: 0x000B4E6C File Offset: 0x000B306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HNPCPDJPGLL
		{
			get
			{
				return this.hNPCPDJPGLL_;
			}
			set
			{
				this.hNPCPDJPGLL_ = value;
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x000B4E75 File Offset: 0x000B3075
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x000B4E7D File Offset: 0x000B307D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeiling GachaCeiling
		{
			get
			{
				return this.gachaCeiling_;
			}
			set
			{
				this.gachaCeiling_ = value;
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x000B4E86 File Offset: 0x000B3086
		// (set) Token: 0x0600427C RID: 17020 RVA: 0x000B4E8E File Offset: 0x000B308E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LHMBNMIOKHB
		{
			get
			{
				return this.lHMBNMIOKHB_;
			}
			set
			{
				this.lHMBNMIOKHB_ = value;
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x000B4E97 File Offset: 0x000B3097
		// (set) Token: 0x0600427E RID: 17022 RVA: 0x000B4E9F File Offset: 0x000B309F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x000B4EA8 File Offset: 0x000B30A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ItemDetailList
		{
			get
			{
				return this.itemDetailList_;
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06004280 RID: 17024 RVA: 0x000B4EB0 File Offset: 0x000B30B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PrizeItemList
		{
			get
			{
				return this.prizeItemList_;
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06004281 RID: 17025 RVA: 0x000B4EB8 File Offset: 0x000B30B8
		// (set) Token: 0x06004282 RID: 17026 RVA: 0x000B4EC0 File Offset: 0x000B30C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DetailWebview
		{
			get
			{
				return this.detailWebview_;
			}
			set
			{
				this.detailWebview_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x000B4ED3 File Offset: 0x000B30D3
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x000B4EDB File Offset: 0x000B30DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DropHistoryWebview
		{
			get
			{
				return this.dropHistoryWebview_;
			}
			set
			{
				this.dropHistoryWebview_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x000B4EEE File Offset: 0x000B30EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaInfo);
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x000B4EFC File Offset: 0x000B30FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaInfo other)
		{
			return other != null && (other == this || (this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.HNPCPDJPGLL == other.HNPCPDJPGLL && object.Equals(this.GachaCeiling, other.GachaCeiling) && this.LHMBNMIOKHB == other.LHMBNMIOKHB && this.GachaId == other.GachaId && this.itemDetailList_.Equals(other.itemDetailList_) && this.prizeItemList_.Equals(other.prizeItemList_) && !(this.DetailWebview != other.DetailWebview) && !(this.DropHistoryWebview != other.DropHistoryWebview) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x000B4FE0 File Offset: 0x000B31E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.HNPCPDJPGLL != 0U)
			{
				num ^= this.HNPCPDJPGLL.GetHashCode();
			}
			if (this.gachaCeiling_ != null)
			{
				num ^= this.GachaCeiling.GetHashCode();
			}
			if (this.LHMBNMIOKHB != 0U)
			{
				num ^= this.LHMBNMIOKHB.GetHashCode();
			}
			if (this.GachaId != 0U)
			{
				num ^= this.GachaId.GetHashCode();
			}
			num ^= this.itemDetailList_.GetHashCode();
			num ^= this.prizeItemList_.GetHashCode();
			if (this.DetailWebview.Length != 0)
			{
				num ^= this.DetailWebview.GetHashCode();
			}
			if (this.DropHistoryWebview.Length != 0)
			{
				num ^= this.DropHistoryWebview.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x000B50EB File Offset: 0x000B32EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x000B50F3 File Offset: 0x000B32F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x000B50FC File Offset: 0x000B32FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EndTime);
			}
			if (this.DropHistoryWebview.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.DropHistoryWebview);
			}
			this.itemDetailList_.WriteTo(ref output, GachaInfo._repeated_itemDetailList_codec);
			if (this.DetailWebview.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.DetailWebview);
			}
			this.prizeItemList_.WriteTo(ref output, GachaInfo._repeated_prizeItemList_codec);
			if (this.gachaCeiling_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GachaCeiling);
			}
			if (this.HNPCPDJPGLL != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.HNPCPDJPGLL);
			}
			if (this.LHMBNMIOKHB != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LHMBNMIOKHB);
			}
			if (this.GachaId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GachaId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.BeginTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x000B522C File Offset: 0x000B342C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.HNPCPDJPGLL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HNPCPDJPGLL);
			}
			if (this.gachaCeiling_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaCeiling);
			}
			if (this.LHMBNMIOKHB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LHMBNMIOKHB);
			}
			if (this.GachaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaId);
			}
			num += this.itemDetailList_.CalculateSize(GachaInfo._repeated_itemDetailList_codec);
			num += this.prizeItemList_.CalculateSize(GachaInfo._repeated_prizeItemList_codec);
			if (this.DetailWebview.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DetailWebview);
			}
			if (this.DropHistoryWebview.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DropHistoryWebview);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x000B5344 File Offset: 0x000B3544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.HNPCPDJPGLL != 0U)
			{
				this.HNPCPDJPGLL = other.HNPCPDJPGLL;
			}
			if (other.gachaCeiling_ != null)
			{
				if (this.gachaCeiling_ == null)
				{
					this.GachaCeiling = new GachaCeiling();
				}
				this.GachaCeiling.MergeFrom(other.GachaCeiling);
			}
			if (other.LHMBNMIOKHB != 0U)
			{
				this.LHMBNMIOKHB = other.LHMBNMIOKHB;
			}
			if (other.GachaId != 0U)
			{
				this.GachaId = other.GachaId;
			}
			this.itemDetailList_.Add(other.itemDetailList_);
			this.prizeItemList_.Add(other.prizeItemList_);
			if (other.DetailWebview.Length != 0)
			{
				this.DetailWebview = other.DetailWebview;
			}
			if (other.DropHistoryWebview.Length != 0)
			{
				this.DropHistoryWebview = other.DropHistoryWebview;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x000B5450 File Offset: 0x000B3650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x000B545C File Offset: 0x000B365C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 48U)
					{
						if (num == 16U)
						{
							this.EndTime = input.ReadInt64();
							continue;
						}
						if (num == 34U)
						{
							this.DropHistoryWebview = input.ReadString();
							continue;
						}
						if (num != 48U)
						{
							goto IL_77;
						}
					}
					else if (num != 50U)
					{
						if (num == 58U)
						{
							this.DetailWebview = input.ReadString();
							continue;
						}
						if (num != 64U)
						{
							goto IL_77;
						}
						goto IL_D1;
					}
					this.itemDetailList_.AddEntriesFrom(ref input, GachaInfo._repeated_itemDetailList_codec);
					continue;
				}
				if (num <= 88U)
				{
					if (num == 66U)
					{
						goto IL_D1;
					}
					if (num == 74U)
					{
						if (this.gachaCeiling_ == null)
						{
							this.GachaCeiling = new GachaCeiling();
						}
						input.ReadMessage(this.GachaCeiling);
						continue;
					}
					if (num == 88U)
					{
						this.HNPCPDJPGLL = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.LHMBNMIOKHB = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.GachaId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
				}
				IL_77:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_D1:
				this.prizeItemList_.AddEntriesFrom(ref input, GachaInfo._repeated_prizeItemList_codec);
			}
		}

		// Token: 0x04001A5D RID: 6749
		private static readonly MessageParser<GachaInfo> _parser = new MessageParser<GachaInfo>(() => new GachaInfo());

		// Token: 0x04001A5E RID: 6750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A5F RID: 6751
		public const int BeginTimeFieldNumber = 15;

		// Token: 0x04001A60 RID: 6752
		private long beginTime_;

		// Token: 0x04001A61 RID: 6753
		public const int EndTimeFieldNumber = 2;

		// Token: 0x04001A62 RID: 6754
		private long endTime_;

		// Token: 0x04001A63 RID: 6755
		public const int HNPCPDJPGLLFieldNumber = 11;

		// Token: 0x04001A64 RID: 6756
		private uint hNPCPDJPGLL_;

		// Token: 0x04001A65 RID: 6757
		public const int GachaCeilingFieldNumber = 9;

		// Token: 0x04001A66 RID: 6758
		private GachaCeiling gachaCeiling_;

		// Token: 0x04001A67 RID: 6759
		public const int LHMBNMIOKHBFieldNumber = 12;

		// Token: 0x04001A68 RID: 6760
		private uint lHMBNMIOKHB_;

		// Token: 0x04001A69 RID: 6761
		public const int GachaIdFieldNumber = 13;

		// Token: 0x04001A6A RID: 6762
		private uint gachaId_;

		// Token: 0x04001A6B RID: 6763
		public const int ItemDetailListFieldNumber = 6;

		// Token: 0x04001A6C RID: 6764
		private static readonly FieldCodec<uint> _repeated_itemDetailList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04001A6D RID: 6765
		private readonly RepeatedField<uint> itemDetailList_ = new RepeatedField<uint>();

		// Token: 0x04001A6E RID: 6766
		public const int PrizeItemListFieldNumber = 8;

		// Token: 0x04001A6F RID: 6767
		private static readonly FieldCodec<uint> _repeated_prizeItemList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04001A70 RID: 6768
		private readonly RepeatedField<uint> prizeItemList_ = new RepeatedField<uint>();

		// Token: 0x04001A71 RID: 6769
		public const int DetailWebviewFieldNumber = 7;

		// Token: 0x04001A72 RID: 6770
		private string detailWebview_ = "";

		// Token: 0x04001A73 RID: 6771
		public const int DropHistoryWebviewFieldNumber = 4;

		// Token: 0x04001A74 RID: 6772
		private string dropHistoryWebview_ = "";
	}
}

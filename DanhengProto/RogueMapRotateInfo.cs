using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F3B RID: 3899
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMapRotateInfo : IMessage<RogueMapRotateInfo>, IMessage, IEquatable<RogueMapRotateInfo>, IDeepCloneable<RogueMapRotateInfo>, IBufferMessage
	{
		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x001D3B28 File Offset: 0x001D1D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMapRotateInfo> Parser
		{
			get
			{
				return RogueMapRotateInfo._parser;
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x001D3B2F File Offset: 0x001D1D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMapRotateInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0600ADF4 RID: 44532 RVA: 0x001D3B41 File Offset: 0x001D1D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMapRotateInfo.Descriptor;
			}
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x001D3B48 File Offset: 0x001D1D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapRotateInfo()
		{
		}

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x001D3B68 File Offset: 0x001D1D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapRotateInfo(RogueMapRotateInfo other) : this()
		{
			this.chargerInfo_ = other.chargerInfo_.Clone();
			this.rotaterDataList_ = other.rotaterDataList_.Clone();
			this.cHJMODIMLDA_ = other.cHJMODIMLDA_;
			this.isRotate_ = other.isRotate_;
			this.roomMap_ = ((other.roomMap_ != null) ? other.roomMap_.Clone() : null);
			this.iPFOFHHKJKP_ = other.iPFOFHHKJKP_;
			this.energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x001D3C0A File Offset: 0x001D1E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapRotateInfo Clone()
		{
			return new RogueMapRotateInfo(this);
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x001D3C12 File Offset: 0x001D1E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChargerInfo> ChargerInfo
		{
			get
			{
				return this.chargerInfo_;
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x0600ADF9 RID: 44537 RVA: 0x001D3C1A File Offset: 0x001D1E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RotaterData> RotaterDataList
		{
			get
			{
				return this.rotaterDataList_;
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x001D3C22 File Offset: 0x001D1E22
		// (set) Token: 0x0600ADFB RID: 44539 RVA: 0x001D3C2A File Offset: 0x001D1E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CHJMODIMLDA
		{
			get
			{
				return this.cHJMODIMLDA_;
			}
			set
			{
				this.cHJMODIMLDA_ = value;
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0600ADFC RID: 44540 RVA: 0x001D3C33 File Offset: 0x001D1E33
		// (set) Token: 0x0600ADFD RID: 44541 RVA: 0x001D3C3B File Offset: 0x001D1E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRotate
		{
			get
			{
				return this.isRotate_;
			}
			set
			{
				this.isRotate_ = value;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x001D3C44 File Offset: 0x001D1E44
		// (set) Token: 0x0600ADFF RID: 44543 RVA: 0x001D3C4C File Offset: 0x001D1E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMBLIADNKEO RoomMap
		{
			get
			{
				return this.roomMap_;
			}
			set
			{
				this.roomMap_ = value;
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0600AE00 RID: 44544 RVA: 0x001D3C55 File Offset: 0x001D1E55
		// (set) Token: 0x0600AE01 RID: 44545 RVA: 0x001D3C5D File Offset: 0x001D1E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IPFOFHHKJKP
		{
			get
			{
				return this.iPFOFHHKJKP_;
			}
			set
			{
				this.iPFOFHHKJKP_ = value;
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600AE02 RID: 44546 RVA: 0x001D3C66 File Offset: 0x001D1E66
		// (set) Token: 0x0600AE03 RID: 44547 RVA: 0x001D3C6E File Offset: 0x001D1E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterEnergyInfo EnergyInfo
		{
			get
			{
				return this.energyInfo_;
			}
			set
			{
				this.energyInfo_ = value;
			}
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x001D3C77 File Offset: 0x001D1E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMapRotateInfo);
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x001D3C88 File Offset: 0x001D1E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMapRotateInfo other)
		{
			return other != null && (other == this || (this.chargerInfo_.Equals(other.chargerInfo_) && this.rotaterDataList_.Equals(other.rotaterDataList_) && this.CHJMODIMLDA == other.CHJMODIMLDA && this.IsRotate == other.IsRotate && object.Equals(this.RoomMap, other.RoomMap) && this.IPFOFHHKJKP == other.IPFOFHHKJKP && object.Equals(this.EnergyInfo, other.EnergyInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x001D3D38 File Offset: 0x001D1F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chargerInfo_.GetHashCode();
			num ^= this.rotaterDataList_.GetHashCode();
			if (this.CHJMODIMLDA != 0U)
			{
				num ^= this.CHJMODIMLDA.GetHashCode();
			}
			if (this.IsRotate)
			{
				num ^= this.IsRotate.GetHashCode();
			}
			if (this.roomMap_ != null)
			{
				num ^= this.RoomMap.GetHashCode();
			}
			if (this.IPFOFHHKJKP != 0)
			{
				num ^= this.IPFOFHHKJKP.GetHashCode();
			}
			if (this.energyInfo_ != null)
			{
				num ^= this.EnergyInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE07 RID: 44551 RVA: 0x001D3DF1 File Offset: 0x001D1FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE08 RID: 44552 RVA: 0x001D3DF9 File Offset: 0x001D1FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE09 RID: 44553 RVA: 0x001D3E04 File Offset: 0x001D2004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roomMap_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RoomMap);
			}
			this.rotaterDataList_.WriteTo(ref output, RogueMapRotateInfo._repeated_rotaterDataList_codec);
			if (this.IPFOFHHKJKP != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.IPFOFHHKJKP);
			}
			this.chargerInfo_.WriteTo(ref output, RogueMapRotateInfo._repeated_chargerInfo_codec);
			if (this.energyInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EnergyInfo);
			}
			if (this.CHJMODIMLDA != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.CHJMODIMLDA);
			}
			if (this.IsRotate)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsRotate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x001D3ED4 File Offset: 0x001D20D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chargerInfo_.CalculateSize(RogueMapRotateInfo._repeated_chargerInfo_codec);
			num += this.rotaterDataList_.CalculateSize(RogueMapRotateInfo._repeated_rotaterDataList_codec);
			if (this.CHJMODIMLDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CHJMODIMLDA);
			}
			if (this.IsRotate)
			{
				num += 2;
			}
			if (this.roomMap_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoomMap);
			}
			if (this.IPFOFHHKJKP != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IPFOFHHKJKP);
			}
			if (this.energyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnergyInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE0B RID: 44555 RVA: 0x001D3F8C File Offset: 0x001D218C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMapRotateInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.chargerInfo_.Add(other.chargerInfo_);
			this.rotaterDataList_.Add(other.rotaterDataList_);
			if (other.CHJMODIMLDA != 0U)
			{
				this.CHJMODIMLDA = other.CHJMODIMLDA;
			}
			if (other.IsRotate)
			{
				this.IsRotate = other.IsRotate;
			}
			if (other.roomMap_ != null)
			{
				if (this.roomMap_ == null)
				{
					this.RoomMap = new HMBLIADNKEO();
				}
				this.RoomMap.MergeFrom(other.RoomMap);
			}
			if (other.IPFOFHHKJKP != 0)
			{
				this.IPFOFHHKJKP = other.IPFOFHHKJKP;
			}
			if (other.energyInfo_ != null)
			{
				if (this.energyInfo_ == null)
				{
					this.EnergyInfo = new RotaterEnergyInfo();
				}
				this.EnergyInfo.MergeFrom(other.EnergyInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE0C RID: 44556 RVA: 0x001D406A File Offset: 0x001D226A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE0D RID: 44557 RVA: 0x001D4074 File Offset: 0x001D2274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 34U)
					{
						if (this.roomMap_ == null)
						{
							this.RoomMap = new HMBLIADNKEO();
						}
						input.ReadMessage(this.RoomMap);
						continue;
					}
					if (num == 50U)
					{
						this.rotaterDataList_.AddEntriesFrom(ref input, RogueMapRotateInfo._repeated_rotaterDataList_codec);
						continue;
					}
					if (num == 64U)
					{
						this.IPFOFHHKJKP = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 82U)
				{
					if (num == 74U)
					{
						this.chargerInfo_.AddEntriesFrom(ref input, RogueMapRotateInfo._repeated_chargerInfo_codec);
						continue;
					}
					if (num == 82U)
					{
						if (this.energyInfo_ == null)
						{
							this.EnergyInfo = new RotaterEnergyInfo();
						}
						input.ReadMessage(this.EnergyInfo);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.CHJMODIMLDA = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsRotate = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046CA RID: 18122
		private static readonly MessageParser<RogueMapRotateInfo> _parser = new MessageParser<RogueMapRotateInfo>(() => new RogueMapRotateInfo());

		// Token: 0x040046CB RID: 18123
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046CC RID: 18124
		public const int ChargerInfoFieldNumber = 9;

		// Token: 0x040046CD RID: 18125
		private static readonly FieldCodec<ChargerInfo> _repeated_chargerInfo_codec = FieldCodec.ForMessage<ChargerInfo>(74U, EggLink.DanhengServer.Proto.ChargerInfo.Parser);

		// Token: 0x040046CE RID: 18126
		private readonly RepeatedField<ChargerInfo> chargerInfo_ = new RepeatedField<ChargerInfo>();

		// Token: 0x040046CF RID: 18127
		public const int RotaterDataListFieldNumber = 6;

		// Token: 0x040046D0 RID: 18128
		private static readonly FieldCodec<RotaterData> _repeated_rotaterDataList_codec = FieldCodec.ForMessage<RotaterData>(50U, RotaterData.Parser);

		// Token: 0x040046D1 RID: 18129
		private readonly RepeatedField<RotaterData> rotaterDataList_ = new RepeatedField<RotaterData>();

		// Token: 0x040046D2 RID: 18130
		public const int CHJMODIMLDAFieldNumber = 14;

		// Token: 0x040046D3 RID: 18131
		private uint cHJMODIMLDA_;

		// Token: 0x040046D4 RID: 18132
		public const int IsRotateFieldNumber = 15;

		// Token: 0x040046D5 RID: 18133
		private bool isRotate_;

		// Token: 0x040046D6 RID: 18134
		public const int RoomMapFieldNumber = 4;

		// Token: 0x040046D7 RID: 18135
		private HMBLIADNKEO roomMap_;

		// Token: 0x040046D8 RID: 18136
		public const int IPFOFHHKJKPFieldNumber = 8;

		// Token: 0x040046D9 RID: 18137
		private int iPFOFHHKJKP_;

		// Token: 0x040046DA RID: 18138
		public const int EnergyInfoFieldNumber = 10;

		// Token: 0x040046DB RID: 18139
		private RotaterEnergyInfo energyInfo_;
	}
}

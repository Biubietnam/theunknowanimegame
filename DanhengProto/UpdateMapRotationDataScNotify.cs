using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013DF RID: 5087
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateMapRotationDataScNotify : IMessage<UpdateMapRotationDataScNotify>, IMessage, IEquatable<UpdateMapRotationDataScNotify>, IDeepCloneable<UpdateMapRotationDataScNotify>, IBufferMessage
	{
		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x0600E2C4 RID: 58052 RVA: 0x0025B1FD File Offset: 0x002593FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateMapRotationDataScNotify> Parser
		{
			get
			{
				return UpdateMapRotationDataScNotify._parser;
			}
		}

		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x0600E2C5 RID: 58053 RVA: 0x0025B204 File Offset: 0x00259404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateMapRotationDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x0600E2C6 RID: 58054 RVA: 0x0025B216 File Offset: 0x00259416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMapRotationDataScNotify.Descriptor;
			}
		}

		// Token: 0x0600E2C7 RID: 58055 RVA: 0x0025B21D File Offset: 0x0025941D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMapRotationDataScNotify()
		{
		}

		// Token: 0x0600E2C8 RID: 58056 RVA: 0x0025B23C File Offset: 0x0025943C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMapRotationDataScNotify(UpdateMapRotationDataScNotify other) : this()
		{
			this.cHJMODIMLDA_ = other.cHJMODIMLDA_;
			this.roomMap_ = ((other.roomMap_ != null) ? other.roomMap_.Clone() : null);
			this.rotaterDataList_ = other.rotaterDataList_.Clone();
			this.hFJNNBPDLCK_ = other.hFJNNBPDLCK_;
			this.chargerInfo_ = other.chargerInfo_.Clone();
			this.energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
			this.iPFOFHHKJKP_ = other.iPFOFHHKJKP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2C9 RID: 58057 RVA: 0x0025B2DE File Offset: 0x002594DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMapRotationDataScNotify Clone()
		{
			return new UpdateMapRotationDataScNotify(this);
		}

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x0600E2CA RID: 58058 RVA: 0x0025B2E6 File Offset: 0x002594E6
		// (set) Token: 0x0600E2CB RID: 58059 RVA: 0x0025B2EE File Offset: 0x002594EE
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

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x0600E2CC RID: 58060 RVA: 0x0025B2F7 File Offset: 0x002594F7
		// (set) Token: 0x0600E2CD RID: 58061 RVA: 0x0025B2FF File Offset: 0x002594FF
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

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x0600E2CE RID: 58062 RVA: 0x0025B308 File Offset: 0x00259508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RotaterData> RotaterDataList
		{
			get
			{
				return this.rotaterDataList_;
			}
		}

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x0600E2CF RID: 58063 RVA: 0x0025B310 File Offset: 0x00259510
		// (set) Token: 0x0600E2D0 RID: 58064 RVA: 0x0025B318 File Offset: 0x00259518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HFJNNBPDLCK
		{
			get
			{
				return this.hFJNNBPDLCK_;
			}
			set
			{
				this.hFJNNBPDLCK_ = value;
			}
		}

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x0600E2D1 RID: 58065 RVA: 0x0025B321 File Offset: 0x00259521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChargerInfo> ChargerInfo
		{
			get
			{
				return this.chargerInfo_;
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x0600E2D2 RID: 58066 RVA: 0x0025B329 File Offset: 0x00259529
		// (set) Token: 0x0600E2D3 RID: 58067 RVA: 0x0025B331 File Offset: 0x00259531
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

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x0600E2D4 RID: 58068 RVA: 0x0025B33A File Offset: 0x0025953A
		// (set) Token: 0x0600E2D5 RID: 58069 RVA: 0x0025B342 File Offset: 0x00259542
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

		// Token: 0x0600E2D6 RID: 58070 RVA: 0x0025B34B File Offset: 0x0025954B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMapRotationDataScNotify);
		}

		// Token: 0x0600E2D7 RID: 58071 RVA: 0x0025B35C File Offset: 0x0025955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateMapRotationDataScNotify other)
		{
			return other != null && (other == this || (this.CHJMODIMLDA == other.CHJMODIMLDA && object.Equals(this.RoomMap, other.RoomMap) && this.rotaterDataList_.Equals(other.rotaterDataList_) && this.HFJNNBPDLCK == other.HFJNNBPDLCK && this.chargerInfo_.Equals(other.chargerInfo_) && object.Equals(this.EnergyInfo, other.EnergyInfo) && this.IPFOFHHKJKP == other.IPFOFHHKJKP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2D8 RID: 58072 RVA: 0x0025B40C File Offset: 0x0025960C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CHJMODIMLDA != 0U)
			{
				num ^= this.CHJMODIMLDA.GetHashCode();
			}
			if (this.roomMap_ != null)
			{
				num ^= this.RoomMap.GetHashCode();
			}
			num ^= this.rotaterDataList_.GetHashCode();
			if (this.HFJNNBPDLCK)
			{
				num ^= this.HFJNNBPDLCK.GetHashCode();
			}
			num ^= this.chargerInfo_.GetHashCode();
			if (this.energyInfo_ != null)
			{
				num ^= this.EnergyInfo.GetHashCode();
			}
			if (this.IPFOFHHKJKP != 0)
			{
				num ^= this.IPFOFHHKJKP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E2D9 RID: 58073 RVA: 0x0025B4C5 File Offset: 0x002596C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E2DA RID: 58074 RVA: 0x0025B4CD File Offset: 0x002596CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2DB RID: 58075 RVA: 0x0025B4D8 File Offset: 0x002596D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.energyInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EnergyInfo);
			}
			if (this.CHJMODIMLDA != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CHJMODIMLDA);
			}
			this.chargerInfo_.WriteTo(ref output, UpdateMapRotationDataScNotify._repeated_chargerInfo_codec);
			this.rotaterDataList_.WriteTo(ref output, UpdateMapRotationDataScNotify._repeated_rotaterDataList_codec);
			if (this.IPFOFHHKJKP != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IPFOFHHKJKP);
			}
			if (this.HFJNNBPDLCK)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.HFJNNBPDLCK);
			}
			if (this.roomMap_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RoomMap);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2DC RID: 58076 RVA: 0x0025B5A8 File Offset: 0x002597A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CHJMODIMLDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CHJMODIMLDA);
			}
			if (this.roomMap_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoomMap);
			}
			num += this.rotaterDataList_.CalculateSize(UpdateMapRotationDataScNotify._repeated_rotaterDataList_codec);
			if (this.HFJNNBPDLCK)
			{
				num += 2;
			}
			num += this.chargerInfo_.CalculateSize(UpdateMapRotationDataScNotify._repeated_chargerInfo_codec);
			if (this.energyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnergyInfo);
			}
			if (this.IPFOFHHKJKP != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IPFOFHHKJKP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2DD RID: 58077 RVA: 0x0025B660 File Offset: 0x00259860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateMapRotationDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CHJMODIMLDA != 0U)
			{
				this.CHJMODIMLDA = other.CHJMODIMLDA;
			}
			if (other.roomMap_ != null)
			{
				if (this.roomMap_ == null)
				{
					this.RoomMap = new HMBLIADNKEO();
				}
				this.RoomMap.MergeFrom(other.RoomMap);
			}
			this.rotaterDataList_.Add(other.rotaterDataList_);
			if (other.HFJNNBPDLCK)
			{
				this.HFJNNBPDLCK = other.HFJNNBPDLCK;
			}
			this.chargerInfo_.Add(other.chargerInfo_);
			if (other.energyInfo_ != null)
			{
				if (this.energyInfo_ == null)
				{
					this.EnergyInfo = new RotaterEnergyInfo();
				}
				this.EnergyInfo.MergeFrom(other.EnergyInfo);
			}
			if (other.IPFOFHHKJKP != 0)
			{
				this.IPFOFHHKJKP = other.IPFOFHHKJKP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2DE RID: 58078 RVA: 0x0025B73E File Offset: 0x0025993E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2DF RID: 58079 RVA: 0x0025B748 File Offset: 0x00259948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 10U)
					{
						if (this.energyInfo_ == null)
						{
							this.EnergyInfo = new RotaterEnergyInfo();
						}
						input.ReadMessage(this.EnergyInfo);
						continue;
					}
					if (num == 16U)
					{
						this.CHJMODIMLDA = input.ReadUInt32();
						continue;
					}
					if (num == 26U)
					{
						this.chargerInfo_.AddEntriesFrom(ref input, UpdateMapRotationDataScNotify._repeated_chargerInfo_codec);
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 34U)
					{
						this.rotaterDataList_.AddEntriesFrom(ref input, UpdateMapRotationDataScNotify._repeated_rotaterDataList_codec);
						continue;
					}
					if (num == 40U)
					{
						this.IPFOFHHKJKP = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.HFJNNBPDLCK = input.ReadBool();
						continue;
					}
					if (num == 98U)
					{
						if (this.roomMap_ == null)
						{
							this.RoomMap = new HMBLIADNKEO();
						}
						input.ReadMessage(this.RoomMap);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A2A RID: 23082
		private static readonly MessageParser<UpdateMapRotationDataScNotify> _parser = new MessageParser<UpdateMapRotationDataScNotify>(() => new UpdateMapRotationDataScNotify());

		// Token: 0x04005A2B RID: 23083
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A2C RID: 23084
		public const int CHJMODIMLDAFieldNumber = 2;

		// Token: 0x04005A2D RID: 23085
		private uint cHJMODIMLDA_;

		// Token: 0x04005A2E RID: 23086
		public const int RoomMapFieldNumber = 12;

		// Token: 0x04005A2F RID: 23087
		private HMBLIADNKEO roomMap_;

		// Token: 0x04005A30 RID: 23088
		public const int RotaterDataListFieldNumber = 4;

		// Token: 0x04005A31 RID: 23089
		private static readonly FieldCodec<RotaterData> _repeated_rotaterDataList_codec = FieldCodec.ForMessage<RotaterData>(34U, RotaterData.Parser);

		// Token: 0x04005A32 RID: 23090
		private readonly RepeatedField<RotaterData> rotaterDataList_ = new RepeatedField<RotaterData>();

		// Token: 0x04005A33 RID: 23091
		public const int HFJNNBPDLCKFieldNumber = 8;

		// Token: 0x04005A34 RID: 23092
		private bool hFJNNBPDLCK_;

		// Token: 0x04005A35 RID: 23093
		public const int ChargerInfoFieldNumber = 3;

		// Token: 0x04005A36 RID: 23094
		private static readonly FieldCodec<ChargerInfo> _repeated_chargerInfo_codec = FieldCodec.ForMessage<ChargerInfo>(26U, EggLink.DanhengServer.Proto.ChargerInfo.Parser);

		// Token: 0x04005A37 RID: 23095
		private readonly RepeatedField<ChargerInfo> chargerInfo_ = new RepeatedField<ChargerInfo>();

		// Token: 0x04005A38 RID: 23096
		public const int EnergyInfoFieldNumber = 1;

		// Token: 0x04005A39 RID: 23097
		private RotaterEnergyInfo energyInfo_;

		// Token: 0x04005A3A RID: 23098
		public const int IPFOFHHKJKPFieldNumber = 5;

		// Token: 0x04005A3B RID: 23099
		private int iPFOFHHKJKP_;
	}
}

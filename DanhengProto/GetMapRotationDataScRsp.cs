using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200070F RID: 1807
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMapRotationDataScRsp : IMessage<GetMapRotationDataScRsp>, IMessage, IEquatable<GetMapRotationDataScRsp>, IDeepCloneable<GetMapRotationDataScRsp>, IBufferMessage
	{
		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x060050BB RID: 20667 RVA: 0x000D9791 File Offset: 0x000D7991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMapRotationDataScRsp> Parser
		{
			get
			{
				return GetMapRotationDataScRsp._parser;
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x060050BC RID: 20668 RVA: 0x000D9798 File Offset: 0x000D7998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMapRotationDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x060050BD RID: 20669 RVA: 0x000D97AA File Offset: 0x000D79AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMapRotationDataScRsp.Descriptor;
			}
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x000D97B1 File Offset: 0x000D79B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMapRotationDataScRsp()
		{
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x000D97D0 File Offset: 0x000D79D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMapRotationDataScRsp(GetMapRotationDataScRsp other) : this()
		{
			this.roomMap_ = ((other.roomMap_ != null) ? other.roomMap_.Clone() : null);
			this.hFJNNBPDLCK_ = other.hFJNNBPDLCK_;
			this.retcode_ = other.retcode_;
			this.chargerInfo_ = other.chargerInfo_.Clone();
			this.cHJMODIMLDA_ = other.cHJMODIMLDA_;
			this.rotaterDataList_ = other.rotaterDataList_.Clone();
			this.iPFOFHHKJKP_ = other.iPFOFHHKJKP_;
			this.energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x000D987E File Offset: 0x000D7A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMapRotationDataScRsp Clone()
		{
			return new GetMapRotationDataScRsp(this);
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x060050C1 RID: 20673 RVA: 0x000D9886 File Offset: 0x000D7A86
		// (set) Token: 0x060050C2 RID: 20674 RVA: 0x000D988E File Offset: 0x000D7A8E
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

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x060050C3 RID: 20675 RVA: 0x000D9897 File Offset: 0x000D7A97
		// (set) Token: 0x060050C4 RID: 20676 RVA: 0x000D989F File Offset: 0x000D7A9F
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

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x060050C5 RID: 20677 RVA: 0x000D98A8 File Offset: 0x000D7AA8
		// (set) Token: 0x060050C6 RID: 20678 RVA: 0x000D98B0 File Offset: 0x000D7AB0
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

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x000D98B9 File Offset: 0x000D7AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChargerInfo> ChargerInfo
		{
			get
			{
				return this.chargerInfo_;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x060050C8 RID: 20680 RVA: 0x000D98C1 File Offset: 0x000D7AC1
		// (set) Token: 0x060050C9 RID: 20681 RVA: 0x000D98C9 File Offset: 0x000D7AC9
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

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x060050CA RID: 20682 RVA: 0x000D98D2 File Offset: 0x000D7AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RotaterData> RotaterDataList
		{
			get
			{
				return this.rotaterDataList_;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x060050CB RID: 20683 RVA: 0x000D98DA File Offset: 0x000D7ADA
		// (set) Token: 0x060050CC RID: 20684 RVA: 0x000D98E2 File Offset: 0x000D7AE2
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

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x060050CD RID: 20685 RVA: 0x000D98EB File Offset: 0x000D7AEB
		// (set) Token: 0x060050CE RID: 20686 RVA: 0x000D98F3 File Offset: 0x000D7AF3
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

		// Token: 0x060050CF RID: 20687 RVA: 0x000D98FC File Offset: 0x000D7AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMapRotationDataScRsp);
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x000D990C File Offset: 0x000D7B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMapRotationDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RoomMap, other.RoomMap) && this.HFJNNBPDLCK == other.HFJNNBPDLCK && this.Retcode == other.Retcode && this.chargerInfo_.Equals(other.chargerInfo_) && this.CHJMODIMLDA == other.CHJMODIMLDA && this.rotaterDataList_.Equals(other.rotaterDataList_) && this.IPFOFHHKJKP == other.IPFOFHHKJKP && object.Equals(this.EnergyInfo, other.EnergyInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x000D99CC File Offset: 0x000D7BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roomMap_ != null)
			{
				num ^= this.RoomMap.GetHashCode();
			}
			if (this.HFJNNBPDLCK)
			{
				num ^= this.HFJNNBPDLCK.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.chargerInfo_.GetHashCode();
			if (this.CHJMODIMLDA != 0U)
			{
				num ^= this.CHJMODIMLDA.GetHashCode();
			}
			num ^= this.rotaterDataList_.GetHashCode();
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

		// Token: 0x060050D2 RID: 20690 RVA: 0x000D9A9E File Offset: 0x000D7C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x000D9AA6 File Offset: 0x000D7CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x000D9AB0 File Offset: 0x000D7CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IPFOFHHKJKP != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IPFOFHHKJKP);
			}
			if (this.CHJMODIMLDA != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CHJMODIMLDA);
			}
			this.chargerInfo_.WriteTo(ref output, GetMapRotationDataScRsp._repeated_chargerInfo_codec);
			if (this.roomMap_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RoomMap);
			}
			if (this.energyInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.EnergyInfo);
			}
			if (this.HFJNNBPDLCK)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.HFJNNBPDLCK);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			this.rotaterDataList_.WriteTo(ref output, GetMapRotationDataScRsp._repeated_rotaterDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x000D9B9C File Offset: 0x000D7D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roomMap_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoomMap);
			}
			if (this.HFJNNBPDLCK)
			{
				num += 2;
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.chargerInfo_.CalculateSize(GetMapRotationDataScRsp._repeated_chargerInfo_codec);
			if (this.CHJMODIMLDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CHJMODIMLDA);
			}
			num += this.rotaterDataList_.CalculateSize(GetMapRotationDataScRsp._repeated_rotaterDataList_codec);
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

		// Token: 0x060050D6 RID: 20694 RVA: 0x000D9C6C File Offset: 0x000D7E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMapRotationDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roomMap_ != null)
			{
				if (this.roomMap_ == null)
				{
					this.RoomMap = new HMBLIADNKEO();
				}
				this.RoomMap.MergeFrom(other.RoomMap);
			}
			if (other.HFJNNBPDLCK)
			{
				this.HFJNNBPDLCK = other.HFJNNBPDLCK;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.chargerInfo_.Add(other.chargerInfo_);
			if (other.CHJMODIMLDA != 0U)
			{
				this.CHJMODIMLDA = other.CHJMODIMLDA;
			}
			this.rotaterDataList_.Add(other.rotaterDataList_);
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

		// Token: 0x060050D7 RID: 20695 RVA: 0x000D9D5E File Offset: 0x000D7F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x000D9D68 File Offset: 0x000D7F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.IPFOFHHKJKP = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.CHJMODIMLDA = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.chargerInfo_.AddEntriesFrom(ref input, GetMapRotationDataScRsp._repeated_chargerInfo_codec);
							continue;
						}
						if (num == 50U)
						{
							if (this.roomMap_ == null)
							{
								this.RoomMap = new HMBLIADNKEO();
							}
							input.ReadMessage(this.RoomMap);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 58U)
					{
						if (this.energyInfo_ == null)
						{
							this.EnergyInfo = new RotaterEnergyInfo();
						}
						input.ReadMessage(this.EnergyInfo);
						continue;
					}
					if (num == 88U)
					{
						this.HFJNNBPDLCK = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.rotaterDataList_.AddEntriesFrom(ref input, GetMapRotationDataScRsp._repeated_rotaterDataList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FB9 RID: 8121
		private static readonly MessageParser<GetMapRotationDataScRsp> _parser = new MessageParser<GetMapRotationDataScRsp>(() => new GetMapRotationDataScRsp());

		// Token: 0x04001FBA RID: 8122
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FBB RID: 8123
		public const int RoomMapFieldNumber = 6;

		// Token: 0x04001FBC RID: 8124
		private HMBLIADNKEO roomMap_;

		// Token: 0x04001FBD RID: 8125
		public const int HFJNNBPDLCKFieldNumber = 11;

		// Token: 0x04001FBE RID: 8126
		private bool hFJNNBPDLCK_;

		// Token: 0x04001FBF RID: 8127
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04001FC0 RID: 8128
		private uint retcode_;

		// Token: 0x04001FC1 RID: 8129
		public const int ChargerInfoFieldNumber = 5;

		// Token: 0x04001FC2 RID: 8130
		private static readonly FieldCodec<ChargerInfo> _repeated_chargerInfo_codec = FieldCodec.ForMessage<ChargerInfo>(42U, EggLink.DanhengServer.Proto.ChargerInfo.Parser);

		// Token: 0x04001FC3 RID: 8131
		private readonly RepeatedField<ChargerInfo> chargerInfo_ = new RepeatedField<ChargerInfo>();

		// Token: 0x04001FC4 RID: 8132
		public const int CHJMODIMLDAFieldNumber = 4;

		// Token: 0x04001FC5 RID: 8133
		private uint cHJMODIMLDA_;

		// Token: 0x04001FC6 RID: 8134
		public const int RotaterDataListFieldNumber = 14;

		// Token: 0x04001FC7 RID: 8135
		private static readonly FieldCodec<RotaterData> _repeated_rotaterDataList_codec = FieldCodec.ForMessage<RotaterData>(114U, RotaterData.Parser);

		// Token: 0x04001FC8 RID: 8136
		private readonly RepeatedField<RotaterData> rotaterDataList_ = new RepeatedField<RotaterData>();

		// Token: 0x04001FC9 RID: 8137
		public const int IPFOFHHKJKPFieldNumber = 1;

		// Token: 0x04001FCA RID: 8138
		private int iPFOFHHKJKP_;

		// Token: 0x04001FCB RID: 8139
		public const int EnergyInfoFieldNumber = 7;

		// Token: 0x04001FCC RID: 8140
		private RotaterEnergyInfo energyInfo_;
	}
}

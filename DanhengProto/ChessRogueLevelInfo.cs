using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200023B RID: 571
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueLevelInfo : IMessage<ChessRogueLevelInfo>, IMessage, IEquatable<ChessRogueLevelInfo>, IDeepCloneable<ChessRogueLevelInfo>, IBufferMessage
	{
		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x0004ADC4 File Offset: 0x00048FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueLevelInfo> Parser
		{
			get
			{
				return ChessRogueLevelInfo._parser;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0004ADCB File Offset: 0x00048FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueLevelInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x0004ADDD File Offset: 0x00048FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueLevelInfo.Descriptor;
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0004ADE4 File Offset: 0x00048FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLevelInfo()
		{
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0004AE04 File Offset: 0x00049004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLevelInfo(ChessRogueLevelInfo other) : this()
		{
			this.layerId_ = other.layerId_;
			this.actionPoint_ = other.actionPoint_;
			this.levelStatus_ = other.levelStatus_;
			this.id_ = other.id_;
			this.oNDPGANOLJA_ = other.oNDPGANOLJA_;
			this.areaIdList_ = other.areaIdList_.Clone();
			this.cNNEMJIJNEB_ = other.cNNEMJIJNEB_;
			this.exploredAreaIdList_ = other.exploredAreaIdList_.Clone();
			this.areaInfo_ = ((other.areaInfo_ != null) ? other.areaInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0004AEAE File Offset: 0x000490AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLevelInfo Clone()
		{
			return new ChessRogueLevelInfo(this);
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x0004AEB6 File Offset: 0x000490B6
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x0004AEBE File Offset: 0x000490BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LayerId
		{
			get
			{
				return this.layerId_;
			}
			set
			{
				this.layerId_ = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0004AEC7 File Offset: 0x000490C7
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x0004AECF File Offset: 0x000490CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionPoint
		{
			get
			{
				return this.actionPoint_;
			}
			set
			{
				this.actionPoint_ = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x0004AED8 File Offset: 0x000490D8
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x0004AEE0 File Offset: 0x000490E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelStatus
		{
			get
			{
				return this.levelStatus_;
			}
			set
			{
				this.levelStatus_ = value;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x0004AEE9 File Offset: 0x000490E9
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x0004AEF1 File Offset: 0x000490F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x0004AEFA File Offset: 0x000490FA
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x0004AF02 File Offset: 0x00049102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ONDPGANOLJA
		{
			get
			{
				return this.oNDPGANOLJA_;
			}
			set
			{
				this.oNDPGANOLJA_ = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x0004AF0B File Offset: 0x0004910B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AreaIdList
		{
			get
			{
				return this.areaIdList_;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0004AF13 File Offset: 0x00049113
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0004AF1B File Offset: 0x0004911B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CNNEMJIJNEB
		{
			get
			{
				return this.cNNEMJIJNEB_;
			}
			set
			{
				this.cNNEMJIJNEB_ = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0004AF24 File Offset: 0x00049124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ExploredAreaIdList
		{
			get
			{
				return this.exploredAreaIdList_;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x0004AF2C File Offset: 0x0004912C
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x0004AF34 File Offset: 0x00049134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAreaInfo AreaInfo
		{
			get
			{
				return this.areaInfo_;
			}
			set
			{
				this.areaInfo_ = value;
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0004AF3D File Offset: 0x0004913D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueLevelInfo);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0004AF4C File Offset: 0x0004914C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueLevelInfo other)
		{
			return other != null && (other == this || (this.LayerId == other.LayerId && this.ActionPoint == other.ActionPoint && this.LevelStatus == other.LevelStatus && this.Id == other.Id && this.ONDPGANOLJA == other.ONDPGANOLJA && this.areaIdList_.Equals(other.areaIdList_) && this.CNNEMJIJNEB == other.CNNEMJIJNEB && this.exploredAreaIdList_.Equals(other.exploredAreaIdList_) && object.Equals(this.AreaInfo, other.AreaInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0004B014 File Offset: 0x00049214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LayerId != 0U)
			{
				num ^= this.LayerId.GetHashCode();
			}
			if (this.ActionPoint != 0)
			{
				num ^= this.ActionPoint.GetHashCode();
			}
			if (this.LevelStatus != 0U)
			{
				num ^= this.LevelStatus.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ONDPGANOLJA != 0)
			{
				num ^= this.ONDPGANOLJA.GetHashCode();
			}
			num ^= this.areaIdList_.GetHashCode();
			if (this.CNNEMJIJNEB != 0U)
			{
				num ^= this.CNNEMJIJNEB.GetHashCode();
			}
			num ^= this.exploredAreaIdList_.GetHashCode();
			if (this.areaInfo_ != null)
			{
				num ^= this.AreaInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0004B102 File Offset: 0x00049302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0004B10A File Offset: 0x0004930A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0004B114 File Offset: 0x00049314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaIdList_.WriteTo(ref output, ChessRogueLevelInfo._repeated_areaIdList_codec);
			if (this.CNNEMJIJNEB != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CNNEMJIJNEB);
			}
			this.exploredAreaIdList_.WriteTo(ref output, ChessRogueLevelInfo._repeated_exploredAreaIdList_codec);
			if (this.LayerId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.LayerId);
			}
			if (this.ActionPoint != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActionPoint);
			}
			if (this.areaInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.AreaInfo);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Id);
			}
			if (this.ONDPGANOLJA != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ONDPGANOLJA);
			}
			if (this.LevelStatus != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LevelStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0004B21C File Offset: 0x0004941C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LayerId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LayerId);
			}
			if (this.ActionPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionPoint);
			}
			if (this.LevelStatus != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelStatus);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.ONDPGANOLJA != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ONDPGANOLJA);
			}
			num += this.areaIdList_.CalculateSize(ChessRogueLevelInfo._repeated_areaIdList_codec);
			if (this.CNNEMJIJNEB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CNNEMJIJNEB);
			}
			num += this.exploredAreaIdList_.CalculateSize(ChessRogueLevelInfo._repeated_exploredAreaIdList_codec);
			if (this.areaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AreaInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0004B310 File Offset: 0x00049510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LayerId != 0U)
			{
				this.LayerId = other.LayerId;
			}
			if (other.ActionPoint != 0)
			{
				this.ActionPoint = other.ActionPoint;
			}
			if (other.LevelStatus != 0U)
			{
				this.LevelStatus = other.LevelStatus;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.ONDPGANOLJA != 0)
			{
				this.ONDPGANOLJA = other.ONDPGANOLJA;
			}
			this.areaIdList_.Add(other.areaIdList_);
			if (other.CNNEMJIJNEB != 0U)
			{
				this.CNNEMJIJNEB = other.CNNEMJIJNEB;
			}
			this.exploredAreaIdList_.Add(other.exploredAreaIdList_);
			if (other.areaInfo_ != null)
			{
				if (this.areaInfo_ == null)
				{
					this.AreaInfo = new ChessRogueAreaInfo();
				}
				this.AreaInfo.MergeFrom(other.AreaInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0004B3FE File Offset: 0x000495FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0004B408 File Offset: 0x00049608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 18U)
					{
						if (num == 16U || num == 18U)
						{
							this.areaIdList_.AddEntriesFrom(ref input, ChessRogueLevelInfo._repeated_areaIdList_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.CNNEMJIJNEB = input.ReadUInt32();
							continue;
						}
						if (num == 40U || num == 42U)
						{
							this.exploredAreaIdList_.AddEntriesFrom(ref input, ChessRogueLevelInfo._repeated_exploredAreaIdList_codec);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 64U)
					{
						this.LayerId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ActionPoint = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						if (this.areaInfo_ == null)
						{
							this.AreaInfo = new ChessRogueAreaInfo();
						}
						input.ReadMessage(this.AreaInfo);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ONDPGANOLJA = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.LevelStatus = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000AED RID: 2797
		private static readonly MessageParser<ChessRogueLevelInfo> _parser = new MessageParser<ChessRogueLevelInfo>(() => new ChessRogueLevelInfo());

		// Token: 0x04000AEE RID: 2798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AEF RID: 2799
		public const int LayerIdFieldNumber = 8;

		// Token: 0x04000AF0 RID: 2800
		private uint layerId_;

		// Token: 0x04000AF1 RID: 2801
		public const int ActionPointFieldNumber = 9;

		// Token: 0x04000AF2 RID: 2802
		private int actionPoint_;

		// Token: 0x04000AF3 RID: 2803
		public const int LevelStatusFieldNumber = 15;

		// Token: 0x04000AF4 RID: 2804
		private uint levelStatus_;

		// Token: 0x04000AF5 RID: 2805
		public const int IdFieldNumber = 11;

		// Token: 0x04000AF6 RID: 2806
		private uint id_;

		// Token: 0x04000AF7 RID: 2807
		public const int ONDPGANOLJAFieldNumber = 12;

		// Token: 0x04000AF8 RID: 2808
		private int oNDPGANOLJA_;

		// Token: 0x04000AF9 RID: 2809
		public const int AreaIdListFieldNumber = 2;

		// Token: 0x04000AFA RID: 2810
		private static readonly FieldCodec<uint> _repeated_areaIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04000AFB RID: 2811
		private readonly RepeatedField<uint> areaIdList_ = new RepeatedField<uint>();

		// Token: 0x04000AFC RID: 2812
		public const int CNNEMJIJNEBFieldNumber = 3;

		// Token: 0x04000AFD RID: 2813
		private uint cNNEMJIJNEB_;

		// Token: 0x04000AFE RID: 2814
		public const int ExploredAreaIdListFieldNumber = 5;

		// Token: 0x04000AFF RID: 2815
		private static readonly FieldCodec<uint> _repeated_exploredAreaIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04000B00 RID: 2816
		private readonly RepeatedField<uint> exploredAreaIdList_ = new RepeatedField<uint>();

		// Token: 0x04000B01 RID: 2817
		public const int AreaInfoFieldNumber = 10;

		// Token: 0x04000B02 RID: 2818
		private ChessRogueAreaInfo areaInfo_;
	}
}

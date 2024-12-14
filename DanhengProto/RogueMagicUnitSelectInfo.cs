using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F35 RID: 3893
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicUnitSelectInfo : IMessage<RogueMagicUnitSelectInfo>, IMessage, IEquatable<RogueMagicUnitSelectInfo>, IDeepCloneable<RogueMagicUnitSelectInfo>, IBufferMessage
	{
		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x0600ADA5 RID: 44453 RVA: 0x001D2CE3 File Offset: 0x001D0EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicUnitSelectInfo> Parser
		{
			get
			{
				return RogueMagicUnitSelectInfo._parser;
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x0600ADA6 RID: 44454 RVA: 0x001D2CEA File Offset: 0x001D0EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x0600ADA7 RID: 44455 RVA: 0x001D2CFC File Offset: 0x001D0EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicUnitSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x001D2D03 File Offset: 0x001D0F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectInfo()
		{
		}

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x001D2D18 File Offset: 0x001D0F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectInfo(RogueMagicUnitSelectInfo other) : this()
		{
			this.selectMagicUnits_ = other.selectMagicUnits_.Clone();
			this.oMPAAKLLLFD_ = other.oMPAAKLLLFD_;
			this.nAPGCECDDBM_ = ((other.nAPGCECDDBM_ != null) ? other.nAPGCECDDBM_.Clone() : null);
			this.aBHPIGOGACI_ = other.aBHPIGOGACI_;
			this.selectHintId_ = other.selectHintId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x001D2D8D File Offset: 0x001D0F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectInfo Clone()
		{
			return new RogueMagicUnitSelectInfo(this);
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x0600ADAB RID: 44459 RVA: 0x001D2D95 File Offset: 0x001D0F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicGameUnit> SelectMagicUnits
		{
			get
			{
				return this.selectMagicUnits_;
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x0600ADAC RID: 44460 RVA: 0x001D2D9D File Offset: 0x001D0F9D
		// (set) Token: 0x0600ADAD RID: 44461 RVA: 0x001D2DA5 File Offset: 0x001D0FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OMPAAKLLLFD
		{
			get
			{
				return this.oMPAAKLLLFD_;
			}
			set
			{
				this.oMPAAKLLLFD_ = value;
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x001D2DAE File Offset: 0x001D0FAE
		// (set) Token: 0x0600ADAF RID: 44463 RVA: 0x001D2DB6 File Offset: 0x001D0FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnit NAPGCECDDBM
		{
			get
			{
				return this.nAPGCECDDBM_;
			}
			set
			{
				this.nAPGCECDDBM_ = value;
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x001D2DBF File Offset: 0x001D0FBF
		// (set) Token: 0x0600ADB1 RID: 44465 RVA: 0x001D2DC7 File Offset: 0x001D0FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ABHPIGOGACI
		{
			get
			{
				return this.aBHPIGOGACI_;
			}
			set
			{
				this.aBHPIGOGACI_ = value;
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x0600ADB2 RID: 44466 RVA: 0x001D2DD0 File Offset: 0x001D0FD0
		// (set) Token: 0x0600ADB3 RID: 44467 RVA: 0x001D2DD8 File Offset: 0x001D0FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x0600ADB4 RID: 44468 RVA: 0x001D2DE1 File Offset: 0x001D0FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicUnitSelectInfo);
		}

		// Token: 0x0600ADB5 RID: 44469 RVA: 0x001D2DF0 File Offset: 0x001D0FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicUnitSelectInfo other)
		{
			return other != null && (other == this || (this.selectMagicUnits_.Equals(other.selectMagicUnits_) && this.OMPAAKLLLFD == other.OMPAAKLLLFD && object.Equals(this.NAPGCECDDBM, other.NAPGCECDDBM) && this.ABHPIGOGACI == other.ABHPIGOGACI && this.SelectHintId == other.SelectHintId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x001D2E74 File Offset: 0x001D1074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selectMagicUnits_.GetHashCode();
			if (this.OMPAAKLLLFD != 0U)
			{
				num ^= this.OMPAAKLLLFD.GetHashCode();
			}
			if (this.nAPGCECDDBM_ != null)
			{
				num ^= this.NAPGCECDDBM.GetHashCode();
			}
			if (this.ABHPIGOGACI != 0U)
			{
				num ^= this.ABHPIGOGACI.GetHashCode();
			}
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADB7 RID: 44471 RVA: 0x001D2F09 File Offset: 0x001D1109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ADB8 RID: 44472 RVA: 0x001D2F11 File Offset: 0x001D1111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADB9 RID: 44473 RVA: 0x001D2F1C File Offset: 0x001D111C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nAPGCECDDBM_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NAPGCECDDBM);
			}
			if (this.OMPAAKLLLFD != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.OMPAAKLLLFD);
			}
			if (this.ABHPIGOGACI != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ABHPIGOGACI);
			}
			this.selectMagicUnits_.WriteTo(ref output, RogueMagicUnitSelectInfo._repeated_selectMagicUnits_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADBA RID: 44474 RVA: 0x001D2FC0 File Offset: 0x001D11C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selectMagicUnits_.CalculateSize(RogueMagicUnitSelectInfo._repeated_selectMagicUnits_codec);
			if (this.OMPAAKLLLFD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OMPAAKLLLFD);
			}
			if (this.nAPGCECDDBM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NAPGCECDDBM);
			}
			if (this.ABHPIGOGACI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ABHPIGOGACI);
			}
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADBB RID: 44475 RVA: 0x001D305C File Offset: 0x001D125C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicUnitSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.selectMagicUnits_.Add(other.selectMagicUnits_);
			if (other.OMPAAKLLLFD != 0U)
			{
				this.OMPAAKLLLFD = other.OMPAAKLLLFD;
			}
			if (other.nAPGCECDDBM_ != null)
			{
				if (this.nAPGCECDDBM_ == null)
				{
					this.NAPGCECDDBM = new RogueMagicGameUnit();
				}
				this.NAPGCECDDBM.MergeFrom(other.NAPGCECDDBM);
			}
			if (other.ABHPIGOGACI != 0U)
			{
				this.ABHPIGOGACI = other.ABHPIGOGACI;
			}
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x001D30FD File Offset: 0x001D12FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADBD RID: 44477 RVA: 0x001D3108 File Offset: 0x001D1308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 10U)
					{
						if (this.nAPGCECDDBM_ == null)
						{
							this.NAPGCECDDBM = new RogueMagicGameUnit();
						}
						input.ReadMessage(this.NAPGCECDDBM);
						continue;
					}
					if (num == 16U)
					{
						this.OMPAAKLLLFD = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ABHPIGOGACI = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						this.selectMagicUnits_.AddEntriesFrom(ref input, RogueMagicUnitSelectInfo._repeated_selectMagicUnits_codec);
						continue;
					}
					if (num == 120U)
					{
						this.SelectHintId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046A9 RID: 18089
		private static readonly MessageParser<RogueMagicUnitSelectInfo> _parser = new MessageParser<RogueMagicUnitSelectInfo>(() => new RogueMagicUnitSelectInfo());

		// Token: 0x040046AA RID: 18090
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046AB RID: 18091
		public const int SelectMagicUnitsFieldNumber = 9;

		// Token: 0x040046AC RID: 18092
		private static readonly FieldCodec<RogueMagicGameUnit> _repeated_selectMagicUnits_codec = FieldCodec.ForMessage<RogueMagicGameUnit>(74U, RogueMagicGameUnit.Parser);

		// Token: 0x040046AD RID: 18093
		private readonly RepeatedField<RogueMagicGameUnit> selectMagicUnits_ = new RepeatedField<RogueMagicGameUnit>();

		// Token: 0x040046AE RID: 18094
		public const int OMPAAKLLLFDFieldNumber = 2;

		// Token: 0x040046AF RID: 18095
		private uint oMPAAKLLLFD_;

		// Token: 0x040046B0 RID: 18096
		public const int NAPGCECDDBMFieldNumber = 1;

		// Token: 0x040046B1 RID: 18097
		private RogueMagicGameUnit nAPGCECDDBM_;

		// Token: 0x040046B2 RID: 18098
		public const int ABHPIGOGACIFieldNumber = 3;

		// Token: 0x040046B3 RID: 18099
		private uint aBHPIGOGACI_;

		// Token: 0x040046B4 RID: 18100
		public const int SelectHintIdFieldNumber = 15;

		// Token: 0x040046B5 RID: 18101
		private uint selectHintId_;
	}
}

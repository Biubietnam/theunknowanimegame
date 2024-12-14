using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200062D RID: 1581
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetBagScRsp : IMessage<GetBagScRsp>, IMessage, IEquatable<GetBagScRsp>, IDeepCloneable<GetBagScRsp>, IBufferMessage
	{
		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x060046E4 RID: 18148 RVA: 0x000C1F7F File Offset: 0x000C017F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetBagScRsp> Parser
		{
			get
			{
				return GetBagScRsp._parser;
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x060046E5 RID: 18149 RVA: 0x000C1F86 File Offset: 0x000C0186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetBagScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x000C1F98 File Offset: 0x000C0198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBagScRsp.Descriptor;
			}
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x000C1FA0 File Offset: 0x000C01A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBagScRsp()
		{
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x000C2038 File Offset: 0x000C0238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBagScRsp(GetBagScRsp other) : this()
		{
			this.nGENOBFFLAB_ = other.nGENOBFFLAB_.Clone();
			this.hNBHLCAKAJG_ = other.hNBHLCAKAJG_.Clone();
			this.equipmentList_ = other.equipmentList_.Clone();
			this.pNBPDOGEKGB_ = other.pNBPDOGEKGB_.Clone();
			this.dHDJIIOIPKH_ = other.dHDJIIOIPKH_.Clone();
			this.fAMNCJFBAFF_ = other.fAMNCJFBAFF_.Clone();
			this.cGFLEKCNJKD_ = other.cGFLEKCNJKD_;
			this.iBLPHOPOEOK_ = other.iBLPHOPOEOK_.Clone();
			this.materialList_ = other.materialList_.Clone();
			this.relicList_ = other.relicList_.Clone();
			this.retcode_ = other.retcode_;
			this.pileItemList_ = other.pileItemList_.Clone();
			this.waitDelResourceList_ = other.waitDelResourceList_.Clone();
			this.unlockFormulaList_ = other.unlockFormulaList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x000C2140 File Offset: 0x000C0340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBagScRsp Clone()
		{
			return new GetBagScRsp(this);
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x000C2148 File Offset: 0x000C0348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Material0> NGENOBFFLAB
		{
			get
			{
				return this.nGENOBFFLAB_;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x000C2150 File Offset: 0x000C0350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Material0> HNBHLCAKAJG
		{
			get
			{
				return this.hNBHLCAKAJG_;
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x000C2158 File Offset: 0x000C0358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Equipment> EquipmentList
		{
			get
			{
				return this.equipmentList_;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x000C2160 File Offset: 0x000C0360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PNBPDOGEKGB
		{
			get
			{
				return this.pNBPDOGEKGB_;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x000C2168 File Offset: 0x000C0368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DHDJIIOIPKH
		{
			get
			{
				return this.dHDJIIOIPKH_;
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x000C2170 File Offset: 0x000C0370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Material> FAMNCJFBAFF
		{
			get
			{
				return this.fAMNCJFBAFF_;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x000C2178 File Offset: 0x000C0378
		// (set) Token: 0x060046F1 RID: 18161 RVA: 0x000C2180 File Offset: 0x000C0380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGFLEKCNJKD
		{
			get
			{
				return this.cGFLEKCNJKD_;
			}
			set
			{
				this.cGFLEKCNJKD_ = value;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x000C2189 File Offset: 0x000C0389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TurnFoodSwitch> IBLPHOPOEOK
		{
			get
			{
				return this.iBLPHOPOEOK_;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x000C2191 File Offset: 0x000C0391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Material> MaterialList
		{
			get
			{
				return this.materialList_;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x000C2199 File Offset: 0x000C0399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Relic> RelicList
		{
			get
			{
				return this.relicList_;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x000C21A1 File Offset: 0x000C03A1
		// (set) Token: 0x060046F6 RID: 18166 RVA: 0x000C21A9 File Offset: 0x000C03A9
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

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x000C21B2 File Offset: 0x000C03B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PileItem> PileItemList
		{
			get
			{
				return this.pileItemList_;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x000C21BA File Offset: 0x000C03BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WaitDelResource> WaitDelResourceList
		{
			get
			{
				return this.waitDelResourceList_;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x000C21C2 File Offset: 0x000C03C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockFormulaList
		{
			get
			{
				return this.unlockFormulaList_;
			}
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x000C21CA File Offset: 0x000C03CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBagScRsp);
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x000C21D8 File Offset: 0x000C03D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetBagScRsp other)
		{
			return other != null && (other == this || (this.nGENOBFFLAB_.Equals(other.nGENOBFFLAB_) && this.hNBHLCAKAJG_.Equals(other.hNBHLCAKAJG_) && this.equipmentList_.Equals(other.equipmentList_) && this.pNBPDOGEKGB_.Equals(other.pNBPDOGEKGB_) && this.dHDJIIOIPKH_.Equals(other.dHDJIIOIPKH_) && this.fAMNCJFBAFF_.Equals(other.fAMNCJFBAFF_) && this.CGFLEKCNJKD == other.CGFLEKCNJKD && this.iBLPHOPOEOK_.Equals(other.iBLPHOPOEOK_) && this.materialList_.Equals(other.materialList_) && this.relicList_.Equals(other.relicList_) && this.Retcode == other.Retcode && this.pileItemList_.Equals(other.pileItemList_) && this.waitDelResourceList_.Equals(other.waitDelResourceList_) && this.unlockFormulaList_.Equals(other.unlockFormulaList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x000C2320 File Offset: 0x000C0520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nGENOBFFLAB_.GetHashCode();
			num ^= this.hNBHLCAKAJG_.GetHashCode();
			num ^= this.equipmentList_.GetHashCode();
			num ^= this.pNBPDOGEKGB_.GetHashCode();
			num ^= this.dHDJIIOIPKH_.GetHashCode();
			num ^= this.fAMNCJFBAFF_.GetHashCode();
			if (this.CGFLEKCNJKD != 0U)
			{
				num ^= this.CGFLEKCNJKD.GetHashCode();
			}
			num ^= this.iBLPHOPOEOK_.GetHashCode();
			num ^= this.materialList_.GetHashCode();
			num ^= this.relicList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.pileItemList_.GetHashCode();
			num ^= this.waitDelResourceList_.GetHashCode();
			num ^= this.unlockFormulaList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x000C2420 File Offset: 0x000C0620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x000C2428 File Offset: 0x000C0628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x000C2434 File Offset: 0x000C0634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockFormulaList_.WriteTo(ref output, GetBagScRsp._repeated_unlockFormulaList_codec);
			this.nGENOBFFLAB_.WriteTo(ref output, GetBagScRsp._repeated_nGENOBFFLAB_codec);
			this.hNBHLCAKAJG_.WriteTo(ref output, GetBagScRsp._repeated_hNBHLCAKAJG_codec);
			this.pNBPDOGEKGB_.WriteTo(ref output, GetBagScRsp._repeated_pNBPDOGEKGB_codec);
			this.fAMNCJFBAFF_.WriteTo(ref output, GetBagScRsp._repeated_fAMNCJFBAFF_codec);
			this.materialList_.WriteTo(ref output, GetBagScRsp._repeated_materialList_codec);
			this.waitDelResourceList_.WriteTo(ref output, GetBagScRsp._repeated_waitDelResourceList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			this.relicList_.WriteTo(ref output, GetBagScRsp._repeated_relicList_codec);
			this.iBLPHOPOEOK_.WriteTo(ref output, GetBagScRsp._repeated_iBLPHOPOEOK_codec);
			this.pileItemList_.WriteTo(ref output, GetBagScRsp._repeated_pileItemList_codec);
			this.dHDJIIOIPKH_.WriteTo(ref output, GetBagScRsp._repeated_dHDJIIOIPKH_codec);
			if (this.CGFLEKCNJKD != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.CGFLEKCNJKD);
			}
			this.equipmentList_.WriteTo(ref output, GetBagScRsp._repeated_equipmentList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x000C255C File Offset: 0x000C075C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nGENOBFFLAB_.CalculateSize(GetBagScRsp._repeated_nGENOBFFLAB_codec);
			num += this.hNBHLCAKAJG_.CalculateSize(GetBagScRsp._repeated_hNBHLCAKAJG_codec);
			num += this.equipmentList_.CalculateSize(GetBagScRsp._repeated_equipmentList_codec);
			num += this.pNBPDOGEKGB_.CalculateSize(GetBagScRsp._repeated_pNBPDOGEKGB_codec);
			num += this.dHDJIIOIPKH_.CalculateSize(GetBagScRsp._repeated_dHDJIIOIPKH_codec);
			num += this.fAMNCJFBAFF_.CalculateSize(GetBagScRsp._repeated_fAMNCJFBAFF_codec);
			if (this.CGFLEKCNJKD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGFLEKCNJKD);
			}
			num += this.iBLPHOPOEOK_.CalculateSize(GetBagScRsp._repeated_iBLPHOPOEOK_codec);
			num += this.materialList_.CalculateSize(GetBagScRsp._repeated_materialList_codec);
			num += this.relicList_.CalculateSize(GetBagScRsp._repeated_relicList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.pileItemList_.CalculateSize(GetBagScRsp._repeated_pileItemList_codec);
			num += this.waitDelResourceList_.CalculateSize(GetBagScRsp._repeated_waitDelResourceList_codec);
			num += this.unlockFormulaList_.CalculateSize(GetBagScRsp._repeated_unlockFormulaList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x000C2698 File Offset: 0x000C0898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetBagScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.nGENOBFFLAB_.Add(other.nGENOBFFLAB_);
			this.hNBHLCAKAJG_.Add(other.hNBHLCAKAJG_);
			this.equipmentList_.Add(other.equipmentList_);
			this.pNBPDOGEKGB_.Add(other.pNBPDOGEKGB_);
			this.dHDJIIOIPKH_.Add(other.dHDJIIOIPKH_);
			this.fAMNCJFBAFF_.Add(other.fAMNCJFBAFF_);
			if (other.CGFLEKCNJKD != 0U)
			{
				this.CGFLEKCNJKD = other.CGFLEKCNJKD;
			}
			this.iBLPHOPOEOK_.Add(other.iBLPHOPOEOK_);
			this.materialList_.Add(other.materialList_);
			this.relicList_.Add(other.relicList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.pileItemList_.Add(other.pileItemList_);
			this.waitDelResourceList_.Add(other.waitDelResourceList_);
			this.unlockFormulaList_.Add(other.unlockFormulaList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x000C27B4 File Offset: 0x000C09B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x000C27C0 File Offset: 0x000C09C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num <= 34U)
					{
						if (num <= 18U)
						{
							if (num == 16U || num == 18U)
							{
								this.unlockFormulaList_.AddEntriesFrom(ref input, GetBagScRsp._repeated_unlockFormulaList_codec);
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								this.nGENOBFFLAB_.AddEntriesFrom(ref input, GetBagScRsp._repeated_nGENOBFFLAB_codec);
								continue;
							}
							if (num == 34U)
							{
								this.hNBHLCAKAJG_.AddEntriesFrom(ref input, GetBagScRsp._repeated_hNBHLCAKAJG_codec);
								continue;
							}
						}
					}
					else if (num <= 42U)
					{
						if (num == 40U || num == 42U)
						{
							this.pNBPDOGEKGB_.AddEntriesFrom(ref input, GetBagScRsp._repeated_pNBPDOGEKGB_codec);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							this.fAMNCJFBAFF_.AddEntriesFrom(ref input, GetBagScRsp._repeated_fAMNCJFBAFF_codec);
							continue;
						}
						if (num == 58U)
						{
							this.materialList_.AddEntriesFrom(ref input, GetBagScRsp._repeated_materialList_codec);
							continue;
						}
						if (num == 66U)
						{
							this.waitDelResourceList_.AddEntriesFrom(ref input, GetBagScRsp._repeated_waitDelResourceList_codec);
							continue;
						}
					}
				}
				else
				{
					if (num > 90U)
					{
						if (num <= 104U)
						{
							if (num == 98U)
							{
								this.pileItemList_.AddEntriesFrom(ref input, GetBagScRsp._repeated_pileItemList_codec);
								continue;
							}
							if (num != 104U)
							{
								goto IL_CC;
							}
						}
						else if (num != 106U)
						{
							if (num == 112U)
							{
								this.CGFLEKCNJKD = input.ReadUInt32();
								continue;
							}
							if (num != 122U)
							{
								goto IL_CC;
							}
							this.equipmentList_.AddEntriesFrom(ref input, GetBagScRsp._repeated_equipmentList_codec);
							continue;
						}
						this.dHDJIIOIPKH_.AddEntriesFrom(ref input, GetBagScRsp._repeated_dHDJIIOIPKH_codec);
						continue;
					}
					if (num <= 82U)
					{
						if (num == 72U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
						if (num == 82U)
						{
							this.relicList_.AddEntriesFrom(ref input, GetBagScRsp._repeated_relicList_codec);
							continue;
						}
					}
					else if (num == 88U || num == 90U)
					{
						this.iBLPHOPOEOK_.AddEntriesFrom(ref input, GetBagScRsp._repeated_iBLPHOPOEOK_codec);
						continue;
					}
				}
				IL_CC:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C4D RID: 7245
		private static readonly MessageParser<GetBagScRsp> _parser = new MessageParser<GetBagScRsp>(() => new GetBagScRsp());

		// Token: 0x04001C4E RID: 7246
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C4F RID: 7247
		public const int NGENOBFFLABFieldNumber = 3;

		// Token: 0x04001C50 RID: 7248
		private static readonly FieldCodec<Material0> _repeated_nGENOBFFLAB_codec = FieldCodec.ForMessage<Material0>(26U, Material0.Parser);

		// Token: 0x04001C51 RID: 7249
		private readonly RepeatedField<Material0> nGENOBFFLAB_ = new RepeatedField<Material0>();

		// Token: 0x04001C52 RID: 7250
		public const int HNBHLCAKAJGFieldNumber = 4;

		// Token: 0x04001C53 RID: 7251
		private static readonly FieldCodec<Material0> _repeated_hNBHLCAKAJG_codec = FieldCodec.ForMessage<Material0>(34U, Material0.Parser);

		// Token: 0x04001C54 RID: 7252
		private readonly RepeatedField<Material0> hNBHLCAKAJG_ = new RepeatedField<Material0>();

		// Token: 0x04001C55 RID: 7253
		public const int EquipmentListFieldNumber = 15;

		// Token: 0x04001C56 RID: 7254
		private static readonly FieldCodec<Equipment> _repeated_equipmentList_codec = FieldCodec.ForMessage<Equipment>(122U, Equipment.Parser);

		// Token: 0x04001C57 RID: 7255
		private readonly RepeatedField<Equipment> equipmentList_ = new RepeatedField<Equipment>();

		// Token: 0x04001C58 RID: 7256
		public const int PNBPDOGEKGBFieldNumber = 5;

		// Token: 0x04001C59 RID: 7257
		private static readonly FieldCodec<uint> _repeated_pNBPDOGEKGB_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04001C5A RID: 7258
		private readonly RepeatedField<uint> pNBPDOGEKGB_ = new RepeatedField<uint>();

		// Token: 0x04001C5B RID: 7259
		public const int DHDJIIOIPKHFieldNumber = 13;

		// Token: 0x04001C5C RID: 7260
		private static readonly FieldCodec<uint> _repeated_dHDJIIOIPKH_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04001C5D RID: 7261
		private readonly RepeatedField<uint> dHDJIIOIPKH_ = new RepeatedField<uint>();

		// Token: 0x04001C5E RID: 7262
		public const int FAMNCJFBAFFFieldNumber = 6;

		// Token: 0x04001C5F RID: 7263
		private static readonly FieldCodec<Material> _repeated_fAMNCJFBAFF_codec = FieldCodec.ForMessage<Material>(50U, Material.Parser);

		// Token: 0x04001C60 RID: 7264
		private readonly RepeatedField<Material> fAMNCJFBAFF_ = new RepeatedField<Material>();

		// Token: 0x04001C61 RID: 7265
		public const int CGFLEKCNJKDFieldNumber = 14;

		// Token: 0x04001C62 RID: 7266
		private uint cGFLEKCNJKD_;

		// Token: 0x04001C63 RID: 7267
		public const int IBLPHOPOEOKFieldNumber = 11;

		// Token: 0x04001C64 RID: 7268
		private static readonly FieldCodec<TurnFoodSwitch> _repeated_iBLPHOPOEOK_codec = FieldCodec.ForEnum<TurnFoodSwitch>(90U, (TurnFoodSwitch x) => (int)x, (int x) => (TurnFoodSwitch)x);

		// Token: 0x04001C65 RID: 7269
		private readonly RepeatedField<TurnFoodSwitch> iBLPHOPOEOK_ = new RepeatedField<TurnFoodSwitch>();

		// Token: 0x04001C66 RID: 7270
		public const int MaterialListFieldNumber = 7;

		// Token: 0x04001C67 RID: 7271
		private static readonly FieldCodec<Material> _repeated_materialList_codec = FieldCodec.ForMessage<Material>(58U, Material.Parser);

		// Token: 0x04001C68 RID: 7272
		private readonly RepeatedField<Material> materialList_ = new RepeatedField<Material>();

		// Token: 0x04001C69 RID: 7273
		public const int RelicListFieldNumber = 10;

		// Token: 0x04001C6A RID: 7274
		private static readonly FieldCodec<Relic> _repeated_relicList_codec = FieldCodec.ForMessage<Relic>(82U, Relic.Parser);

		// Token: 0x04001C6B RID: 7275
		private readonly RepeatedField<Relic> relicList_ = new RepeatedField<Relic>();

		// Token: 0x04001C6C RID: 7276
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04001C6D RID: 7277
		private uint retcode_;

		// Token: 0x04001C6E RID: 7278
		public const int PileItemListFieldNumber = 12;

		// Token: 0x04001C6F RID: 7279
		private static readonly FieldCodec<PileItem> _repeated_pileItemList_codec = FieldCodec.ForMessage<PileItem>(98U, PileItem.Parser);

		// Token: 0x04001C70 RID: 7280
		private readonly RepeatedField<PileItem> pileItemList_ = new RepeatedField<PileItem>();

		// Token: 0x04001C71 RID: 7281
		public const int WaitDelResourceListFieldNumber = 8;

		// Token: 0x04001C72 RID: 7282
		private static readonly FieldCodec<WaitDelResource> _repeated_waitDelResourceList_codec = FieldCodec.ForMessage<WaitDelResource>(66U, WaitDelResource.Parser);

		// Token: 0x04001C73 RID: 7283
		private readonly RepeatedField<WaitDelResource> waitDelResourceList_ = new RepeatedField<WaitDelResource>();

		// Token: 0x04001C74 RID: 7284
		public const int UnlockFormulaListFieldNumber = 2;

		// Token: 0x04001C75 RID: 7285
		private static readonly FieldCodec<uint> _repeated_unlockFormulaList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04001C76 RID: 7286
		private readonly RepeatedField<uint> unlockFormulaList_ = new RepeatedField<uint>();
	}
}

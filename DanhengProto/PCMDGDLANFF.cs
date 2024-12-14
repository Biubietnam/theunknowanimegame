using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C85 RID: 3205
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PCMDGDLANFF : IMessage<PCMDGDLANFF>, IMessage, IEquatable<PCMDGDLANFF>, IDeepCloneable<PCMDGDLANFF>, IBufferMessage
	{
		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x06008E6E RID: 36462 RVA: 0x001785C3 File Offset: 0x001767C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PCMDGDLANFF> Parser
		{
			get
			{
				return PCMDGDLANFF._parser;
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x06008E6F RID: 36463 RVA: 0x001785CA File Offset: 0x001767CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PCMDGDLANFFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x06008E70 RID: 36464 RVA: 0x001785DC File Offset: 0x001767DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PCMDGDLANFF.Descriptor;
			}
		}

		// Token: 0x06008E71 RID: 36465 RVA: 0x001785E3 File Offset: 0x001767E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PCMDGDLANFF()
		{
		}

		// Token: 0x06008E72 RID: 36466 RVA: 0x001785F8 File Offset: 0x001767F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PCMDGDLANFF(PCMDGDLANFF other) : this()
		{
			this.oCLOINEKDEM_ = other.oCLOINEKDEM_;
			this.oKCAOLBFLKD_ = other.oKCAOLBFLKD_.Clone();
			this.aLAOMAOBNFG_ = other.aLAOMAOBNFG_;
			this.oNNHABCMGPD_ = other.oNNHABCMGPD_;
			this.mOMMNLJBHBI_ = other.mOMMNLJBHBI_;
			this.eDJEAKCCCNJ_ = other.eDJEAKCCCNJ_;
			this.mBFOAGMCOOM_ = other.mBFOAGMCOOM_;
			this.gDLLHHELILE_ = other.gDLLHHELILE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E73 RID: 36467 RVA: 0x00178681 File Offset: 0x00176881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PCMDGDLANFF Clone()
		{
			return new PCMDGDLANFF(this);
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x06008E74 RID: 36468 RVA: 0x00178689 File Offset: 0x00176889
		// (set) Token: 0x06008E75 RID: 36469 RVA: 0x00178691 File Offset: 0x00176891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OCLOINEKDEM
		{
			get
			{
				return this.oCLOINEKDEM_;
			}
			set
			{
				this.oCLOINEKDEM_ = value;
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x06008E76 RID: 36470 RVA: 0x0017869A File Offset: 0x0017689A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DDLHPHLLNAA> OKCAOLBFLKD
		{
			get
			{
				return this.oKCAOLBFLKD_;
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x06008E77 RID: 36471 RVA: 0x001786A2 File Offset: 0x001768A2
		// (set) Token: 0x06008E78 RID: 36472 RVA: 0x001786AA File Offset: 0x001768AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ALAOMAOBNFG
		{
			get
			{
				return this.aLAOMAOBNFG_;
			}
			set
			{
				this.aLAOMAOBNFG_ = value;
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x06008E79 RID: 36473 RVA: 0x001786B3 File Offset: 0x001768B3
		// (set) Token: 0x06008E7A RID: 36474 RVA: 0x001786BB File Offset: 0x001768BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ONNHABCMGPD
		{
			get
			{
				return this.oNNHABCMGPD_;
			}
			set
			{
				this.oNNHABCMGPD_ = value;
			}
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x06008E7B RID: 36475 RVA: 0x001786C4 File Offset: 0x001768C4
		// (set) Token: 0x06008E7C RID: 36476 RVA: 0x001786CC File Offset: 0x001768CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MOMMNLJBHBI
		{
			get
			{
				return this.mOMMNLJBHBI_;
			}
			set
			{
				this.mOMMNLJBHBI_ = value;
			}
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x06008E7D RID: 36477 RVA: 0x001786D5 File Offset: 0x001768D5
		// (set) Token: 0x06008E7E RID: 36478 RVA: 0x001786DD File Offset: 0x001768DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EDJEAKCCCNJ
		{
			get
			{
				return this.eDJEAKCCCNJ_;
			}
			set
			{
				this.eDJEAKCCCNJ_ = value;
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x06008E7F RID: 36479 RVA: 0x001786E6 File Offset: 0x001768E6
		// (set) Token: 0x06008E80 RID: 36480 RVA: 0x001786EE File Offset: 0x001768EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MBFOAGMCOOM
		{
			get
			{
				return this.mBFOAGMCOOM_;
			}
			set
			{
				this.mBFOAGMCOOM_ = value;
			}
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x06008E81 RID: 36481 RVA: 0x001786F7 File Offset: 0x001768F7
		// (set) Token: 0x06008E82 RID: 36482 RVA: 0x001786FF File Offset: 0x001768FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GDLLHHELILE
		{
			get
			{
				return this.gDLLHHELILE_;
			}
			set
			{
				this.gDLLHHELILE_ = value;
			}
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x00178708 File Offset: 0x00176908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PCMDGDLANFF);
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x00178718 File Offset: 0x00176918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PCMDGDLANFF other)
		{
			return other != null && (other == this || (this.OCLOINEKDEM == other.OCLOINEKDEM && this.oKCAOLBFLKD_.Equals(other.oKCAOLBFLKD_) && this.ALAOMAOBNFG == other.ALAOMAOBNFG && this.ONNHABCMGPD == other.ONNHABCMGPD && this.MOMMNLJBHBI == other.MOMMNLJBHBI && this.EDJEAKCCCNJ == other.EDJEAKCCCNJ && this.MBFOAGMCOOM == other.MBFOAGMCOOM && this.GDLLHHELILE == other.GDLLHHELILE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x001787C8 File Offset: 0x001769C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OCLOINEKDEM)
			{
				num ^= this.OCLOINEKDEM.GetHashCode();
			}
			num ^= this.oKCAOLBFLKD_.GetHashCode();
			if (this.ALAOMAOBNFG != 0U)
			{
				num ^= this.ALAOMAOBNFG.GetHashCode();
			}
			if (this.ONNHABCMGPD != 0U)
			{
				num ^= this.ONNHABCMGPD.GetHashCode();
			}
			if (this.MOMMNLJBHBI != 0U)
			{
				num ^= this.MOMMNLJBHBI.GetHashCode();
			}
			if (this.EDJEAKCCCNJ)
			{
				num ^= this.EDJEAKCCCNJ.GetHashCode();
			}
			if (this.MBFOAGMCOOM != 0U)
			{
				num ^= this.MBFOAGMCOOM.GetHashCode();
			}
			if (this.GDLLHHELILE != 0U)
			{
				num ^= this.GDLLHHELILE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x001788AB File Offset: 0x00176AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E87 RID: 36487 RVA: 0x001788B3 File Offset: 0x00176AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x001788BC File Offset: 0x00176ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ALAOMAOBNFG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ALAOMAOBNFG);
			}
			if (this.MBFOAGMCOOM != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MBFOAGMCOOM);
			}
			if (this.OCLOINEKDEM)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.OCLOINEKDEM);
			}
			if (this.EDJEAKCCCNJ)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.EDJEAKCCCNJ);
			}
			if (this.GDLLHHELILE != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GDLLHHELILE);
			}
			if (this.MOMMNLJBHBI != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MOMMNLJBHBI);
			}
			if (this.ONNHABCMGPD != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ONNHABCMGPD);
			}
			this.oKCAOLBFLKD_.WriteTo(ref output, PCMDGDLANFF._repeated_oKCAOLBFLKD_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x001789B4 File Offset: 0x00176BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OCLOINEKDEM)
			{
				num += 2;
			}
			num += this.oKCAOLBFLKD_.CalculateSize(PCMDGDLANFF._repeated_oKCAOLBFLKD_codec);
			if (this.ALAOMAOBNFG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ALAOMAOBNFG);
			}
			if (this.ONNHABCMGPD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ONNHABCMGPD);
			}
			if (this.MOMMNLJBHBI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MOMMNLJBHBI);
			}
			if (this.EDJEAKCCCNJ)
			{
				num += 2;
			}
			if (this.MBFOAGMCOOM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MBFOAGMCOOM);
			}
			if (this.GDLLHHELILE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GDLLHHELILE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x00178A80 File Offset: 0x00176C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PCMDGDLANFF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OCLOINEKDEM)
			{
				this.OCLOINEKDEM = other.OCLOINEKDEM;
			}
			this.oKCAOLBFLKD_.Add(other.oKCAOLBFLKD_);
			if (other.ALAOMAOBNFG != 0U)
			{
				this.ALAOMAOBNFG = other.ALAOMAOBNFG;
			}
			if (other.ONNHABCMGPD != 0U)
			{
				this.ONNHABCMGPD = other.ONNHABCMGPD;
			}
			if (other.MOMMNLJBHBI != 0U)
			{
				this.MOMMNLJBHBI = other.MOMMNLJBHBI;
			}
			if (other.EDJEAKCCCNJ)
			{
				this.EDJEAKCCCNJ = other.EDJEAKCCCNJ;
			}
			if (other.MBFOAGMCOOM != 0U)
			{
				this.MBFOAGMCOOM = other.MBFOAGMCOOM;
			}
			if (other.GDLLHHELILE != 0U)
			{
				this.GDLLHHELILE = other.GDLLHHELILE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x00178B45 File Offset: 0x00176D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x00178B50 File Offset: 0x00176D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.ALAOMAOBNFG = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.MBFOAGMCOOM = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.OCLOINEKDEM = input.ReadBool();
							continue;
						}
						if (num == 48U)
						{
							this.EDJEAKCCCNJ = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.GDLLHHELILE = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.MOMMNLJBHBI = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ONNHABCMGPD = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.oKCAOLBFLKD_.AddEntriesFrom(ref input, PCMDGDLANFF._repeated_oKCAOLBFLKD_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040036B0 RID: 14000
		private static readonly MessageParser<PCMDGDLANFF> _parser = new MessageParser<PCMDGDLANFF>(() => new PCMDGDLANFF());

		// Token: 0x040036B1 RID: 14001
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036B2 RID: 14002
		public const int OCLOINEKDEMFieldNumber = 5;

		// Token: 0x040036B3 RID: 14003
		private bool oCLOINEKDEM_;

		// Token: 0x040036B4 RID: 14004
		public const int OKCAOLBFLKDFieldNumber = 14;

		// Token: 0x040036B5 RID: 14005
		private static readonly FieldCodec<DDLHPHLLNAA> _repeated_oKCAOLBFLKD_codec = FieldCodec.ForMessage<DDLHPHLLNAA>(114U, DDLHPHLLNAA.Parser);

		// Token: 0x040036B6 RID: 14006
		private readonly RepeatedField<DDLHPHLLNAA> oKCAOLBFLKD_ = new RepeatedField<DDLHPHLLNAA>();

		// Token: 0x040036B7 RID: 14007
		public const int ALAOMAOBNFGFieldNumber = 2;

		// Token: 0x040036B8 RID: 14008
		private uint aLAOMAOBNFG_;

		// Token: 0x040036B9 RID: 14009
		public const int ONNHABCMGPDFieldNumber = 13;

		// Token: 0x040036BA RID: 14010
		private uint oNNHABCMGPD_;

		// Token: 0x040036BB RID: 14011
		public const int MOMMNLJBHBIFieldNumber = 8;

		// Token: 0x040036BC RID: 14012
		private uint mOMMNLJBHBI_;

		// Token: 0x040036BD RID: 14013
		public const int EDJEAKCCCNJFieldNumber = 6;

		// Token: 0x040036BE RID: 14014
		private bool eDJEAKCCCNJ_;

		// Token: 0x040036BF RID: 14015
		public const int MBFOAGMCOOMFieldNumber = 4;

		// Token: 0x040036C0 RID: 14016
		private uint mBFOAGMCOOM_;

		// Token: 0x040036C1 RID: 14017
		public const int GDLLHHELILEFieldNumber = 7;

		// Token: 0x040036C2 RID: 14018
		private uint gDLLHHELILE_;
	}
}

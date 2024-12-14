using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200040F RID: 1039
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ELGEEHOFEKF : IMessage<ELGEEHOFEKF>, IMessage, IEquatable<ELGEEHOFEKF>, IDeepCloneable<ELGEEHOFEKF>, IBufferMessage
	{
		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x0007F67F File Offset: 0x0007D87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ELGEEHOFEKF> Parser
		{
			get
			{
				return ELGEEHOFEKF._parser;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x0007F686 File Offset: 0x0007D886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ELGEEHOFEKFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x0007F698 File Offset: 0x0007D898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ELGEEHOFEKF.Descriptor;
			}
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x0007F69F File Offset: 0x0007D89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELGEEHOFEKF()
		{
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x0007F6A8 File Offset: 0x0007D8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELGEEHOFEKF(ELGEEHOFEKF other) : this()
		{
			this.hMMNEGOOCOB_ = other.hMMNEGOOCOB_;
			this.iGMGMCELOGJ_ = ((other.iGMGMCELOGJ_ != null) ? other.iGMGMCELOGJ_.Clone() : null);
			this.mCMGKPLCAAP_ = other.mCMGKPLCAAP_;
			this.buffId_ = other.buffId_;
			this.aNHOJKEDAID_ = other.aNHOJKEDAID_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x0007F734 File Offset: 0x0007D934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELGEEHOFEKF Clone()
		{
			return new ELGEEHOFEKF(this);
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x0007F73C File Offset: 0x0007D93C
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0007F744 File Offset: 0x0007D944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HMMNEGOOCOB
		{
			get
			{
				return this.hMMNEGOOCOB_;
			}
			set
			{
				this.hMMNEGOOCOB_ = value;
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x0007F74D File Offset: 0x0007D94D
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x0007F755 File Offset: 0x0007D955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData IGMGMCELOGJ
		{
			get
			{
				return this.iGMGMCELOGJ_;
			}
			set
			{
				this.iGMGMCELOGJ_ = value;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x0007F75E File Offset: 0x0007D95E
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x0007F766 File Offset: 0x0007D966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MCMGKPLCAAP
		{
			get
			{
				return this.mCMGKPLCAAP_;
			}
			set
			{
				this.mCMGKPLCAAP_ = value;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x0007F76F File Offset: 0x0007D96F
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x0007F777 File Offset: 0x0007D977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x0007F780 File Offset: 0x0007D980
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x0007F788 File Offset: 0x0007D988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ANHOJKEDAID
		{
			get
			{
				return this.aNHOJKEDAID_;
			}
			set
			{
				this.aNHOJKEDAID_ = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x0007F791 File Offset: 0x0007D991
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x0007F799 File Offset: 0x0007D999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData CostData
		{
			get
			{
				return this.costData_;
			}
			set
			{
				this.costData_ = value;
			}
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x0007F7A2 File Offset: 0x0007D9A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ELGEEHOFEKF);
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x0007F7B0 File Offset: 0x0007D9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ELGEEHOFEKF other)
		{
			return other != null && (other == this || (this.HMMNEGOOCOB == other.HMMNEGOOCOB && object.Equals(this.IGMGMCELOGJ, other.IGMGMCELOGJ) && this.MCMGKPLCAAP == other.MCMGKPLCAAP && this.BuffId == other.BuffId && this.ANHOJKEDAID == other.ANHOJKEDAID && object.Equals(this.CostData, other.CostData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x0007F844 File Offset: 0x0007DA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HMMNEGOOCOB)
			{
				num ^= this.HMMNEGOOCOB.GetHashCode();
			}
			if (this.iGMGMCELOGJ_ != null)
			{
				num ^= this.IGMGMCELOGJ.GetHashCode();
			}
			if (this.MCMGKPLCAAP != 0U)
			{
				num ^= this.MCMGKPLCAAP.GetHashCode();
			}
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.ANHOJKEDAID)
			{
				num ^= this.ANHOJKEDAID.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x0007F8FA File Offset: 0x0007DAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0007F902 File Offset: 0x0007DB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x0007F90C File Offset: 0x0007DB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.costData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CostData);
			}
			if (this.iGMGMCELOGJ_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.IGMGMCELOGJ);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.BuffId);
			}
			if (this.MCMGKPLCAAP != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.MCMGKPLCAAP);
			}
			if (this.ANHOJKEDAID)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.ANHOJKEDAID);
			}
			if (this.HMMNEGOOCOB)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.HMMNEGOOCOB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x0007F9D8 File Offset: 0x0007DBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HMMNEGOOCOB)
			{
				num += 2;
			}
			if (this.iGMGMCELOGJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IGMGMCELOGJ);
			}
			if (this.MCMGKPLCAAP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MCMGKPLCAAP);
			}
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this.ANHOJKEDAID)
			{
				num += 2;
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x0007FA78 File Offset: 0x0007DC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ELGEEHOFEKF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HMMNEGOOCOB)
			{
				this.HMMNEGOOCOB = other.HMMNEGOOCOB;
			}
			if (other.iGMGMCELOGJ_ != null)
			{
				if (this.iGMGMCELOGJ_ == null)
				{
					this.IGMGMCELOGJ = new ItemCostData();
				}
				this.IGMGMCELOGJ.MergeFrom(other.IGMGMCELOGJ);
			}
			if (other.MCMGKPLCAAP != 0U)
			{
				this.MCMGKPLCAAP = other.MCMGKPLCAAP;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			if (other.ANHOJKEDAID)
			{
				this.ANHOJKEDAID = other.ANHOJKEDAID;
			}
			if (other.costData_ != null)
			{
				if (this.costData_ == null)
				{
					this.CostData = new ItemCostData();
				}
				this.CostData.MergeFrom(other.CostData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x0007FB48 File Offset: 0x0007DD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x0007FB54 File Offset: 0x0007DD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 26U)
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
						continue;
					}
					if (num == 42U)
					{
						if (this.iGMGMCELOGJ_ == null)
						{
							this.IGMGMCELOGJ = new ItemCostData();
						}
						input.ReadMessage(this.IGMGMCELOGJ);
						continue;
					}
					if (num == 64U)
					{
						this.BuffId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.MCMGKPLCAAP = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ANHOJKEDAID = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.HMMNEGOOCOB = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001286 RID: 4742
		private static readonly MessageParser<ELGEEHOFEKF> _parser = new MessageParser<ELGEEHOFEKF>(() => new ELGEEHOFEKF());

		// Token: 0x04001287 RID: 4743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001288 RID: 4744
		public const int HMMNEGOOCOBFieldNumber = 15;

		// Token: 0x04001289 RID: 4745
		private bool hMMNEGOOCOB_;

		// Token: 0x0400128A RID: 4746
		public const int IGMGMCELOGJFieldNumber = 5;

		// Token: 0x0400128B RID: 4747
		private ItemCostData iGMGMCELOGJ_;

		// Token: 0x0400128C RID: 4748
		public const int MCMGKPLCAAPFieldNumber = 11;

		// Token: 0x0400128D RID: 4749
		private uint mCMGKPLCAAP_;

		// Token: 0x0400128E RID: 4750
		public const int BuffIdFieldNumber = 8;

		// Token: 0x0400128F RID: 4751
		private uint buffId_;

		// Token: 0x04001290 RID: 4752
		public const int ANHOJKEDAIDFieldNumber = 14;

		// Token: 0x04001291 RID: 4753
		private bool aNHOJKEDAID_;

		// Token: 0x04001292 RID: 4754
		public const int CostDataFieldNumber = 3;

		// Token: 0x04001293 RID: 4755
		private ItemCostData costData_;
	}
}

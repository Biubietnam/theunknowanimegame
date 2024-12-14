using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000947 RID: 2375
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IPICDPBDHBJ : IMessage<IPICDPBDHBJ>, IMessage, IEquatable<IPICDPBDHBJ>, IDeepCloneable<IPICDPBDHBJ>, IBufferMessage
	{
		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x06006A00 RID: 27136 RVA: 0x0011AD7B File Offset: 0x00118F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IPICDPBDHBJ> Parser
		{
			get
			{
				return IPICDPBDHBJ._parser;
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06006A01 RID: 27137 RVA: 0x0011AD82 File Offset: 0x00118F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IPICDPBDHBJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x06006A02 RID: 27138 RVA: 0x0011AD94 File Offset: 0x00118F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IPICDPBDHBJ.Descriptor;
			}
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x0011AD9B File Offset: 0x00118F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IPICDPBDHBJ()
		{
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x0011ADA4 File Offset: 0x00118FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IPICDPBDHBJ(IPICDPBDHBJ other) : this()
		{
			this.iGMGMCELOGJ_ = ((other.iGMGMCELOGJ_ != null) ? other.iGMGMCELOGJ_.Clone() : null);
			this.miracleId_ = other.miracleId_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.aNHOJKEDAID_ = other.aNHOJKEDAID_;
			this.hMMNEGOOCOB_ = other.hMMNEGOOCOB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x0011AE24 File Offset: 0x00119024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IPICDPBDHBJ Clone()
		{
			return new IPICDPBDHBJ(this);
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x06006A06 RID: 27142 RVA: 0x0011AE2C File Offset: 0x0011902C
		// (set) Token: 0x06006A07 RID: 27143 RVA: 0x0011AE34 File Offset: 0x00119034
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

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06006A08 RID: 27144 RVA: 0x0011AE3D File Offset: 0x0011903D
		// (set) Token: 0x06006A09 RID: 27145 RVA: 0x0011AE45 File Offset: 0x00119045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleId
		{
			get
			{
				return this.miracleId_;
			}
			set
			{
				this.miracleId_ = value;
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06006A0A RID: 27146 RVA: 0x0011AE4E File Offset: 0x0011904E
		// (set) Token: 0x06006A0B RID: 27147 RVA: 0x0011AE56 File Offset: 0x00119056
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

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06006A0C RID: 27148 RVA: 0x0011AE5F File Offset: 0x0011905F
		// (set) Token: 0x06006A0D RID: 27149 RVA: 0x0011AE67 File Offset: 0x00119067
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

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06006A0E RID: 27150 RVA: 0x0011AE70 File Offset: 0x00119070
		// (set) Token: 0x06006A0F RID: 27151 RVA: 0x0011AE78 File Offset: 0x00119078
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

		// Token: 0x06006A10 RID: 27152 RVA: 0x0011AE81 File Offset: 0x00119081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IPICDPBDHBJ);
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x0011AE90 File Offset: 0x00119090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IPICDPBDHBJ other)
		{
			return other != null && (other == this || (object.Equals(this.IGMGMCELOGJ, other.IGMGMCELOGJ) && this.MiracleId == other.MiracleId && object.Equals(this.CostData, other.CostData) && this.ANHOJKEDAID == other.ANHOJKEDAID && this.HMMNEGOOCOB == other.HMMNEGOOCOB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x0011AF14 File Offset: 0x00119114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.iGMGMCELOGJ_ != null)
			{
				num ^= this.IGMGMCELOGJ.GetHashCode();
			}
			if (this.MiracleId != 0U)
			{
				num ^= this.MiracleId.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this.ANHOJKEDAID)
			{
				num ^= this.ANHOJKEDAID.GetHashCode();
			}
			if (this.HMMNEGOOCOB)
			{
				num ^= this.HMMNEGOOCOB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x0011AFB1 File Offset: 0x001191B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x0011AFB9 File Offset: 0x001191B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x0011AFC4 File Offset: 0x001191C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iGMGMCELOGJ_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.IGMGMCELOGJ);
			}
			if (this.MiracleId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MiracleId);
			}
			if (this.HMMNEGOOCOB)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.HMMNEGOOCOB);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CostData);
			}
			if (this.ANHOJKEDAID)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.ANHOJKEDAID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x0011B074 File Offset: 0x00119274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.iGMGMCELOGJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IGMGMCELOGJ);
			}
			if (this.MiracleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleId);
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this.ANHOJKEDAID)
			{
				num += 2;
			}
			if (this.HMMNEGOOCOB)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x0011B0FC File Offset: 0x001192FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IPICDPBDHBJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.iGMGMCELOGJ_ != null)
			{
				if (this.iGMGMCELOGJ_ == null)
				{
					this.IGMGMCELOGJ = new ItemCostData();
				}
				this.IGMGMCELOGJ.MergeFrom(other.IGMGMCELOGJ);
			}
			if (other.MiracleId != 0U)
			{
				this.MiracleId = other.MiracleId;
			}
			if (other.costData_ != null)
			{
				if (this.costData_ == null)
				{
					this.CostData = new ItemCostData();
				}
				this.CostData.MergeFrom(other.CostData);
			}
			if (other.ANHOJKEDAID)
			{
				this.ANHOJKEDAID = other.ANHOJKEDAID;
			}
			if (other.HMMNEGOOCOB)
			{
				this.HMMNEGOOCOB = other.HMMNEGOOCOB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x0011B1B8 File Offset: 0x001193B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x0011B1C4 File Offset: 0x001193C4
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
						if (this.iGMGMCELOGJ_ == null)
						{
							this.IGMGMCELOGJ = new ItemCostData();
						}
						input.ReadMessage(this.IGMGMCELOGJ);
						continue;
					}
					if (num == 16U)
					{
						this.MiracleId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.HMMNEGOOCOB = input.ReadBool();
						continue;
					}
					if (num == 58U)
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
						continue;
					}
					if (num == 104U)
					{
						this.ANHOJKEDAID = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002898 RID: 10392
		private static readonly MessageParser<IPICDPBDHBJ> _parser = new MessageParser<IPICDPBDHBJ>(() => new IPICDPBDHBJ());

		// Token: 0x04002899 RID: 10393
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400289A RID: 10394
		public const int IGMGMCELOGJFieldNumber = 1;

		// Token: 0x0400289B RID: 10395
		private ItemCostData iGMGMCELOGJ_;

		// Token: 0x0400289C RID: 10396
		public const int MiracleIdFieldNumber = 2;

		// Token: 0x0400289D RID: 10397
		private uint miracleId_;

		// Token: 0x0400289E RID: 10398
		public const int CostDataFieldNumber = 7;

		// Token: 0x0400289F RID: 10399
		private ItemCostData costData_;

		// Token: 0x040028A0 RID: 10400
		public const int ANHOJKEDAIDFieldNumber = 13;

		// Token: 0x040028A1 RID: 10401
		private bool aNHOJKEDAID_;

		// Token: 0x040028A2 RID: 10402
		public const int HMMNEGOOCOBFieldNumber = 4;

		// Token: 0x040028A3 RID: 10403
		private bool hMMNEGOOCOB_;
	}
}

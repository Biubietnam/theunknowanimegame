using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000361 RID: 865
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DDBGPHLEGIC : IMessage<DDBGPHLEGIC>, IMessage, IEquatable<DDBGPHLEGIC>, IDeepCloneable<DDBGPHLEGIC>, IBufferMessage
	{
		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x0006C21F File Offset: 0x0006A41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DDBGPHLEGIC> Parser
		{
			get
			{
				return DDBGPHLEGIC._parser;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x0006C226 File Offset: 0x0006A426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DDBGPHLEGICReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x0006C238 File Offset: 0x0006A438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DDBGPHLEGIC.Descriptor;
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0006C23F File Offset: 0x0006A43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DDBGPHLEGIC()
		{
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x0006C248 File Offset: 0x0006A448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DDBGPHLEGIC(DDBGPHLEGIC other) : this()
		{
			this.iBPPPCMOAFI_ = other.iBPPPCMOAFI_;
			this.magicUnitId_ = other.magicUnitId_;
			this.magicUnitLevel_ = other.magicUnitLevel_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x0006C2AC File Offset: 0x0006A4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DDBGPHLEGIC Clone()
		{
			return new DDBGPHLEGIC(this);
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x0006C2B4 File Offset: 0x0006A4B4
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x0006C2BC File Offset: 0x0006A4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IBPPPCMOAFI
		{
			get
			{
				return this.iBPPPCMOAFI_;
			}
			set
			{
				this.iBPPPCMOAFI_ = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x0006C2C5 File Offset: 0x0006A4C5
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x0006C2CD File Offset: 0x0006A4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MagicUnitId
		{
			get
			{
				return this.magicUnitId_;
			}
			set
			{
				this.magicUnitId_ = value;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x0006C2D6 File Offset: 0x0006A4D6
		// (set) Token: 0x0600269D RID: 9885 RVA: 0x0006C2DE File Offset: 0x0006A4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MagicUnitLevel
		{
			get
			{
				return this.magicUnitLevel_;
			}
			set
			{
				this.magicUnitLevel_ = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x0006C2E7 File Offset: 0x0006A4E7
		// (set) Token: 0x0600269F RID: 9887 RVA: 0x0006C2EF File Offset: 0x0006A4EF
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

		// Token: 0x060026A0 RID: 9888 RVA: 0x0006C2F8 File Offset: 0x0006A4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DDBGPHLEGIC);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x0006C308 File Offset: 0x0006A508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DDBGPHLEGIC other)
		{
			return other != null && (other == this || (this.IBPPPCMOAFI == other.IBPPPCMOAFI && this.MagicUnitId == other.MagicUnitId && this.MagicUnitLevel == other.MagicUnitLevel && object.Equals(this.CostData, other.CostData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x0006C378 File Offset: 0x0006A578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IBPPPCMOAFI)
			{
				num ^= this.IBPPPCMOAFI.GetHashCode();
			}
			if (this.MagicUnitId != 0U)
			{
				num ^= this.MagicUnitId.GetHashCode();
			}
			if (this.MagicUnitLevel != 0U)
			{
				num ^= this.MagicUnitLevel.GetHashCode();
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

		// Token: 0x060026A3 RID: 9891 RVA: 0x0006C3FF File Offset: 0x0006A5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x0006C407 File Offset: 0x0006A607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x0006C410 File Offset: 0x0006A610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IBPPPCMOAFI)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IBPPPCMOAFI);
			}
			if (this.MagicUnitLevel != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MagicUnitLevel);
			}
			if (this.MagicUnitId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MagicUnitId);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CostData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x0006C4A4 File Offset: 0x0006A6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IBPPPCMOAFI)
			{
				num += 2;
			}
			if (this.MagicUnitId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MagicUnitId);
			}
			if (this.MagicUnitLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MagicUnitLevel);
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

		// Token: 0x060026A7 RID: 9895 RVA: 0x0006C520 File Offset: 0x0006A720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DDBGPHLEGIC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IBPPPCMOAFI)
			{
				this.IBPPPCMOAFI = other.IBPPPCMOAFI;
			}
			if (other.MagicUnitId != 0U)
			{
				this.MagicUnitId = other.MagicUnitId;
			}
			if (other.MagicUnitLevel != 0U)
			{
				this.MagicUnitLevel = other.MagicUnitLevel;
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

		// Token: 0x060026A8 RID: 9896 RVA: 0x0006C5B0 File Offset: 0x0006A7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0006C5BC File Offset: 0x0006A7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.IBPPPCMOAFI = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.MagicUnitLevel = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.MagicUnitId = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F9A RID: 3994
		private static readonly MessageParser<DDBGPHLEGIC> _parser = new MessageParser<DDBGPHLEGIC>(() => new DDBGPHLEGIC());

		// Token: 0x04000F9B RID: 3995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F9C RID: 3996
		public const int IBPPPCMOAFIFieldNumber = 2;

		// Token: 0x04000F9D RID: 3997
		private bool iBPPPCMOAFI_;

		// Token: 0x04000F9E RID: 3998
		public const int MagicUnitIdFieldNumber = 10;

		// Token: 0x04000F9F RID: 3999
		private uint magicUnitId_;

		// Token: 0x04000FA0 RID: 4000
		public const int MagicUnitLevelFieldNumber = 4;

		// Token: 0x04000FA1 RID: 4001
		private uint magicUnitLevel_;

		// Token: 0x04000FA2 RID: 4002
		public const int CostDataFieldNumber = 14;

		// Token: 0x04000FA3 RID: 4003
		private ItemCostData costData_;
	}
}

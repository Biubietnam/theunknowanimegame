using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C3 RID: 963
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DoGachaInRollShopCsReq : IMessage<DoGachaInRollShopCsReq>, IMessage, IEquatable<DoGachaInRollShopCsReq>, IDeepCloneable<DoGachaInRollShopCsReq>, IBufferMessage
	{
		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0007744D File Offset: 0x0007564D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DoGachaInRollShopCsReq> Parser
		{
			get
			{
				return DoGachaInRollShopCsReq._parser;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x00077454 File Offset: 0x00075654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DoGachaInRollShopCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x00077466 File Offset: 0x00075666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoGachaInRollShopCsReq.Descriptor;
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x0007746D File Offset: 0x0007566D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaInRollShopCsReq()
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00077475 File Offset: 0x00075675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaInRollShopCsReq(DoGachaInRollShopCsReq other) : this()
		{
			this.gachaCount_ = other.gachaCount_;
			this.rollShopId_ = other.rollShopId_;
			this.gachaRandom_ = other.gachaRandom_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000774B2 File Offset: 0x000756B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaInRollShopCsReq Clone()
		{
			return new DoGachaInRollShopCsReq(this);
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000774BA File Offset: 0x000756BA
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x000774C2 File Offset: 0x000756C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaCount
		{
			get
			{
				return this.gachaCount_;
			}
			set
			{
				this.gachaCount_ = value;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x000774CB File Offset: 0x000756CB
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x000774D3 File Offset: 0x000756D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollShopId
		{
			get
			{
				return this.rollShopId_;
			}
			set
			{
				this.rollShopId_ = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x000774DC File Offset: 0x000756DC
		// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x000774E4 File Offset: 0x000756E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaRandom
		{
			get
			{
				return this.gachaRandom_;
			}
			set
			{
				this.gachaRandom_ = value;
			}
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000774ED File Offset: 0x000756ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DoGachaInRollShopCsReq);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000774FC File Offset: 0x000756FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoGachaInRollShopCsReq other)
		{
			return other != null && (other == this || (this.GachaCount == other.GachaCount && this.RollShopId == other.RollShopId && this.GachaRandom == other.GachaRandom && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00077558 File Offset: 0x00075758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaCount != 0U)
			{
				num ^= this.GachaCount.GetHashCode();
			}
			if (this.RollShopId != 0U)
			{
				num ^= this.RollShopId.GetHashCode();
			}
			if (this.GachaRandom != 0U)
			{
				num ^= this.GachaRandom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000775C9 File Offset: 0x000757C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000775D1 File Offset: 0x000757D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000775DC File Offset: 0x000757DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaRandom != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GachaRandom);
			}
			if (this.GachaCount != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GachaCount);
			}
			if (this.RollShopId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.RollShopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x00077654 File Offset: 0x00075854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaCount);
			}
			if (this.RollShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollShopId);
			}
			if (this.GachaRandom != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaRandom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000776C4 File Offset: 0x000758C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DoGachaInRollShopCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaCount != 0U)
			{
				this.GachaCount = other.GachaCount;
			}
			if (other.RollShopId != 0U)
			{
				this.RollShopId = other.RollShopId;
			}
			if (other.GachaRandom != 0U)
			{
				this.GachaRandom = other.GachaRandom;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00077728 File Offset: 0x00075928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00077734 File Offset: 0x00075934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RollShopId = input.ReadUInt32();
						}
					}
					else
					{
						this.GachaCount = input.ReadUInt32();
					}
				}
				else
				{
					this.GachaRandom = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400115D RID: 4445
		private static readonly MessageParser<DoGachaInRollShopCsReq> _parser = new MessageParser<DoGachaInRollShopCsReq>(() => new DoGachaInRollShopCsReq());

		// Token: 0x0400115E RID: 4446
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400115F RID: 4447
		public const int GachaCountFieldNumber = 10;

		// Token: 0x04001160 RID: 4448
		private uint gachaCount_;

		// Token: 0x04001161 RID: 4449
		public const int RollShopIdFieldNumber = 11;

		// Token: 0x04001162 RID: 4450
		private uint rollShopId_;

		// Token: 0x04001163 RID: 4451
		public const int GachaRandomFieldNumber = 2;

		// Token: 0x04001164 RID: 4452
		private uint gachaRandom_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F87 RID: 3975
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournConfirmSettleCsReq : IMessage<RogueTournConfirmSettleCsReq>, IMessage, IEquatable<RogueTournConfirmSettleCsReq>, IDeepCloneable<RogueTournConfirmSettleCsReq>, IBufferMessage
	{
		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600B0FF RID: 45311 RVA: 0x001DB66D File Offset: 0x001D986D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournConfirmSettleCsReq> Parser
		{
			get
			{
				return RogueTournConfirmSettleCsReq._parser;
			}
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600B100 RID: 45312 RVA: 0x001DB674 File Offset: 0x001D9874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournConfirmSettleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600B101 RID: 45313 RVA: 0x001DB686 File Offset: 0x001D9886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournConfirmSettleCsReq.Descriptor;
			}
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x001DB68D File Offset: 0x001D988D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournConfirmSettleCsReq()
		{
		}

		// Token: 0x0600B103 RID: 45315 RVA: 0x001DB6A0 File Offset: 0x001D98A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournConfirmSettleCsReq(RogueTournConfirmSettleCsReq other) : this()
		{
			this.maxTimes_ = other.maxTimes_;
			this.name_ = other.name_;
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B104 RID: 45316 RVA: 0x001DB6DD File Offset: 0x001D98DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournConfirmSettleCsReq Clone()
		{
			return new RogueTournConfirmSettleCsReq(this);
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600B105 RID: 45317 RVA: 0x001DB6E5 File Offset: 0x001D98E5
		// (set) Token: 0x0600B106 RID: 45318 RVA: 0x001DB6ED File Offset: 0x001D98ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600B107 RID: 45319 RVA: 0x001DB6F6 File Offset: 0x001D98F6
		// (set) Token: 0x0600B108 RID: 45320 RVA: 0x001DB6FE File Offset: 0x001D98FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600B109 RID: 45321 RVA: 0x001DB711 File Offset: 0x001D9911
		// (set) Token: 0x0600B10A RID: 45322 RVA: 0x001DB719 File Offset: 0x001D9919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x0600B10B RID: 45323 RVA: 0x001DB722 File Offset: 0x001D9922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournConfirmSettleCsReq);
		}

		// Token: 0x0600B10C RID: 45324 RVA: 0x001DB730 File Offset: 0x001D9930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournConfirmSettleCsReq other)
		{
			return other != null && (other == this || (this.MaxTimes == other.MaxTimes && !(this.Name != other.Name) && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B10D RID: 45325 RVA: 0x001DB790 File Offset: 0x001D9990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B10E RID: 45326 RVA: 0x001DB803 File Offset: 0x001D9A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B10F RID: 45327 RVA: 0x001DB80B File Offset: 0x001D9A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x001DB814 File Offset: 0x001D9A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AreaId);
			}
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MaxTimes);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x001DB890 File Offset: 0x001D9A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B112 RID: 45330 RVA: 0x001DB904 File Offset: 0x001D9B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournConfirmSettleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B113 RID: 45331 RVA: 0x001DB96D File Offset: 0x001D9B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x001DB978 File Offset: 0x001D9B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 48U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Name = input.ReadString();
						}
					}
					else
					{
						this.MaxTimes = input.ReadUInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004800 RID: 18432
		private static readonly MessageParser<RogueTournConfirmSettleCsReq> _parser = new MessageParser<RogueTournConfirmSettleCsReq>(() => new RogueTournConfirmSettleCsReq());

		// Token: 0x04004801 RID: 18433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004802 RID: 18434
		public const int MaxTimesFieldNumber = 6;

		// Token: 0x04004803 RID: 18435
		private uint maxTimes_;

		// Token: 0x04004804 RID: 18436
		public const int NameFieldNumber = 7;

		// Token: 0x04004805 RID: 18437
		private string name_ = "";

		// Token: 0x04004806 RID: 18438
		public const int AreaIdFieldNumber = 1;

		// Token: 0x04004807 RID: 18439
		private uint areaId_;
	}
}

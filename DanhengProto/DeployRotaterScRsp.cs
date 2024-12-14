using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000389 RID: 905
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeployRotaterScRsp : IMessage<DeployRotaterScRsp>, IMessage, IEquatable<DeployRotaterScRsp>, IDeepCloneable<DeployRotaterScRsp>, IBufferMessage
	{
		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x0006FDEB File Offset: 0x0006DFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeployRotaterScRsp> Parser
		{
			get
			{
				return DeployRotaterScRsp._parser;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x0006FDF2 File Offset: 0x0006DFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeployRotaterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x0006FE04 File Offset: 0x0006E004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeployRotaterScRsp.Descriptor;
			}
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x0006FE0B File Offset: 0x0006E00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeployRotaterScRsp()
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0006FE14 File Offset: 0x0006E014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeployRotaterScRsp(DeployRotaterScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
			this.rotaterData_ = ((other.rotaterData_ != null) ? other.rotaterData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x0006FE7C File Offset: 0x0006E07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeployRotaterScRsp Clone()
		{
			return new DeployRotaterScRsp(this);
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x0006FE84 File Offset: 0x0006E084
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x0006FE8C File Offset: 0x0006E08C
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

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x0006FE95 File Offset: 0x0006E095
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x0006FE9D File Offset: 0x0006E09D
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

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x0006FEA6 File Offset: 0x0006E0A6
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x0006FEAE File Offset: 0x0006E0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterData RotaterData
		{
			get
			{
				return this.rotaterData_;
			}
			set
			{
				this.rotaterData_ = value;
			}
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x0006FEB7 File Offset: 0x0006E0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeployRotaterScRsp);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0006FEC8 File Offset: 0x0006E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeployRotaterScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.EnergyInfo, other.EnergyInfo) && object.Equals(this.RotaterData, other.RotaterData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0006FF2C File Offset: 0x0006E12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.energyInfo_ != null)
			{
				num ^= this.EnergyInfo.GetHashCode();
			}
			if (this.rotaterData_ != null)
			{
				num ^= this.RotaterData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x0006FF97 File Offset: 0x0006E197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x0006FF9F File Offset: 0x0006E19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x0006FFA8 File Offset: 0x0006E1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotaterData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RotaterData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.energyInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.EnergyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00070020 File Offset: 0x0006E220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.energyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnergyInfo);
			}
			if (this.rotaterData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotaterData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00070090 File Offset: 0x0006E290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeployRotaterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.energyInfo_ != null)
			{
				if (this.energyInfo_ == null)
				{
					this.EnergyInfo = new RotaterEnergyInfo();
				}
				this.EnergyInfo.MergeFrom(other.EnergyInfo);
			}
			if (other.rotaterData_ != null)
			{
				if (this.rotaterData_ == null)
				{
					this.RotaterData = new RotaterData();
				}
				this.RotaterData.MergeFrom(other.RotaterData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00070124 File Offset: 0x0006E324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x00070130 File Offset: 0x0006E330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 88U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.energyInfo_ == null)
							{
								this.EnergyInfo = new RotaterEnergyInfo();
							}
							input.ReadMessage(this.EnergyInfo);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rotaterData_ == null)
					{
						this.RotaterData = new RotaterData();
					}
					input.ReadMessage(this.RotaterData);
				}
			}
		}

		// Token: 0x04001029 RID: 4137
		private static readonly MessageParser<DeployRotaterScRsp> _parser = new MessageParser<DeployRotaterScRsp>(() => new DeployRotaterScRsp());

		// Token: 0x0400102A RID: 4138
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400102B RID: 4139
		public const int RetcodeFieldNumber = 11;

		// Token: 0x0400102C RID: 4140
		private uint retcode_;

		// Token: 0x0400102D RID: 4141
		public const int EnergyInfoFieldNumber = 13;

		// Token: 0x0400102E RID: 4142
		private RotaterEnergyInfo energyInfo_;

		// Token: 0x0400102F RID: 4143
		public const int RotaterDataFieldNumber = 6;

		// Token: 0x04001030 RID: 4144
		private RotaterData rotaterData_;
	}
}

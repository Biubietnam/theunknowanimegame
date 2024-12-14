using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DB3 RID: 3507
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveRotaterScRsp : IMessage<RemoveRotaterScRsp>, IMessage, IEquatable<RemoveRotaterScRsp>, IDeepCloneable<RemoveRotaterScRsp>, IBufferMessage
	{
		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x06009CCC RID: 40140 RVA: 0x001A1BDF File Offset: 0x0019FDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveRotaterScRsp> Parser
		{
			get
			{
				return RemoveRotaterScRsp._parser;
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x06009CCD RID: 40141 RVA: 0x001A1BE6 File Offset: 0x0019FDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RemoveRotaterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x06009CCE RID: 40142 RVA: 0x001A1BF8 File Offset: 0x0019FDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveRotaterScRsp.Descriptor;
			}
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x001A1BFF File Offset: 0x0019FDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveRotaterScRsp()
		{
		}

		// Token: 0x06009CD0 RID: 40144 RVA: 0x001A1C08 File Offset: 0x0019FE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveRotaterScRsp(RemoveRotaterScRsp other) : this()
		{
			this.energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.rotaterData_ = ((other.rotaterData_ != null) ? other.rotaterData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x001A1C70 File Offset: 0x0019FE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveRotaterScRsp Clone()
		{
			return new RemoveRotaterScRsp(this);
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x001A1C78 File Offset: 0x0019FE78
		// (set) Token: 0x06009CD3 RID: 40147 RVA: 0x001A1C80 File Offset: 0x0019FE80
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

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x06009CD4 RID: 40148 RVA: 0x001A1C89 File Offset: 0x0019FE89
		// (set) Token: 0x06009CD5 RID: 40149 RVA: 0x001A1C91 File Offset: 0x0019FE91
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

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x06009CD6 RID: 40150 RVA: 0x001A1C9A File Offset: 0x0019FE9A
		// (set) Token: 0x06009CD7 RID: 40151 RVA: 0x001A1CA2 File Offset: 0x0019FEA2
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

		// Token: 0x06009CD8 RID: 40152 RVA: 0x001A1CAB File Offset: 0x0019FEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveRotaterScRsp);
		}

		// Token: 0x06009CD9 RID: 40153 RVA: 0x001A1CBC File Offset: 0x0019FEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveRotaterScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.EnergyInfo, other.EnergyInfo) && this.Retcode == other.Retcode && object.Equals(this.RotaterData, other.RotaterData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CDA RID: 40154 RVA: 0x001A1D20 File Offset: 0x0019FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.energyInfo_ != null)
			{
				num ^= this.EnergyInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x06009CDB RID: 40155 RVA: 0x001A1D8B File Offset: 0x0019FF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009CDC RID: 40156 RVA: 0x001A1D93 File Offset: 0x0019FF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CDD RID: 40157 RVA: 0x001A1D9C File Offset: 0x0019FF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rotaterData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RotaterData);
			}
			if (this.energyInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.EnergyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CDE RID: 40158 RVA: 0x001A1E14 File Offset: 0x001A0014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.energyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnergyInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x06009CDF RID: 40159 RVA: 0x001A1E84 File Offset: 0x001A0084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveRotaterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.energyInfo_ != null)
			{
				if (this.energyInfo_ == null)
				{
					this.EnergyInfo = new RotaterEnergyInfo();
				}
				this.EnergyInfo.MergeFrom(other.EnergyInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
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

		// Token: 0x06009CE0 RID: 40160 RVA: 0x001A1F18 File Offset: 0x001A0118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CE1 RID: 40161 RVA: 0x001A1F24 File Offset: 0x001A0124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 50U)
					{
						if (num != 74U)
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
						if (this.rotaterData_ == null)
						{
							this.RotaterData = new RotaterData();
						}
						input.ReadMessage(this.RotaterData);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003CF8 RID: 15608
		private static readonly MessageParser<RemoveRotaterScRsp> _parser = new MessageParser<RemoveRotaterScRsp>(() => new RemoveRotaterScRsp());

		// Token: 0x04003CF9 RID: 15609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CFA RID: 15610
		public const int EnergyInfoFieldNumber = 9;

		// Token: 0x04003CFB RID: 15611
		private RotaterEnergyInfo energyInfo_;

		// Token: 0x04003CFC RID: 15612
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04003CFD RID: 15613
		private uint retcode_;

		// Token: 0x04003CFE RID: 15614
		public const int RotaterDataFieldNumber = 6;

		// Token: 0x04003CFF RID: 15615
		private RotaterData rotaterData_;
	}
}

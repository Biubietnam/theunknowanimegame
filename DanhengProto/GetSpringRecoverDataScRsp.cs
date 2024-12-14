using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000803 RID: 2051
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSpringRecoverDataScRsp : IMessage<GetSpringRecoverDataScRsp>, IMessage, IEquatable<GetSpringRecoverDataScRsp>, IDeepCloneable<GetSpringRecoverDataScRsp>, IBufferMessage
	{
		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06005B77 RID: 23415 RVA: 0x000F37D7 File Offset: 0x000F19D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSpringRecoverDataScRsp> Parser
		{
			get
			{
				return GetSpringRecoverDataScRsp._parser;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06005B78 RID: 23416 RVA: 0x000F37DE File Offset: 0x000F19DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSpringRecoverDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06005B79 RID: 23417 RVA: 0x000F37F0 File Offset: 0x000F19F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSpringRecoverDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x000F37F7 File Offset: 0x000F19F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSpringRecoverDataScRsp()
		{
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x000F3800 File Offset: 0x000F1A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSpringRecoverDataScRsp(GetSpringRecoverDataScRsp other) : this()
		{
			this.healPoolInfo_ = ((other.healPoolInfo_ != null) ? other.healPoolInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.springRecoverConfig_ = ((other.springRecoverConfig_ != null) ? other.springRecoverConfig_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x000F3868 File Offset: 0x000F1A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSpringRecoverDataScRsp Clone()
		{
			return new GetSpringRecoverDataScRsp(this);
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06005B7D RID: 23421 RVA: 0x000F3870 File Offset: 0x000F1A70
		// (set) Token: 0x06005B7E RID: 23422 RVA: 0x000F3878 File Offset: 0x000F1A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfo HealPoolInfo
		{
			get
			{
				return this.healPoolInfo_;
			}
			set
			{
				this.healPoolInfo_ = value;
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06005B7F RID: 23423 RVA: 0x000F3881 File Offset: 0x000F1A81
		// (set) Token: 0x06005B80 RID: 23424 RVA: 0x000F3889 File Offset: 0x000F1A89
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

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06005B81 RID: 23425 RVA: 0x000F3892 File Offset: 0x000F1A92
		// (set) Token: 0x06005B82 RID: 23426 RVA: 0x000F389A File Offset: 0x000F1A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverConfig SpringRecoverConfig
		{
			get
			{
				return this.springRecoverConfig_;
			}
			set
			{
				this.springRecoverConfig_ = value;
			}
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x000F38A3 File Offset: 0x000F1AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSpringRecoverDataScRsp);
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x000F38B4 File Offset: 0x000F1AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSpringRecoverDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.HealPoolInfo, other.HealPoolInfo) && this.Retcode == other.Retcode && object.Equals(this.SpringRecoverConfig, other.SpringRecoverConfig) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x000F3918 File Offset: 0x000F1B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.healPoolInfo_ != null)
			{
				num ^= this.HealPoolInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.springRecoverConfig_ != null)
			{
				num ^= this.SpringRecoverConfig.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x000F3983 File Offset: 0x000F1B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x000F398B File Offset: 0x000F1B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x000F3994 File Offset: 0x000F1B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.springRecoverConfig_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SpringRecoverConfig);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.healPoolInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.HealPoolInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x000F3A0C File Offset: 0x000F1C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.healPoolInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HealPoolInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.springRecoverConfig_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpringRecoverConfig);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x000F3A7C File Offset: 0x000F1C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSpringRecoverDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.healPoolInfo_ != null)
			{
				if (this.healPoolInfo_ == null)
				{
					this.HealPoolInfo = new HealPoolInfo();
				}
				this.HealPoolInfo.MergeFrom(other.HealPoolInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.springRecoverConfig_ != null)
			{
				if (this.springRecoverConfig_ == null)
				{
					this.SpringRecoverConfig = new SpringRecoverConfig();
				}
				this.SpringRecoverConfig.MergeFrom(other.SpringRecoverConfig);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x000F3B10 File Offset: 0x000F1D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x000F3B1C File Offset: 0x000F1D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 72U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.healPoolInfo_ == null)
							{
								this.HealPoolInfo = new HealPoolInfo();
							}
							input.ReadMessage(this.HealPoolInfo);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.springRecoverConfig_ == null)
					{
						this.SpringRecoverConfig = new SpringRecoverConfig();
					}
					input.ReadMessage(this.SpringRecoverConfig);
				}
			}
		}

		// Token: 0x0400236D RID: 9069
		private static readonly MessageParser<GetSpringRecoverDataScRsp> _parser = new MessageParser<GetSpringRecoverDataScRsp>(() => new GetSpringRecoverDataScRsp());

		// Token: 0x0400236E RID: 9070
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400236F RID: 9071
		public const int HealPoolInfoFieldNumber = 13;

		// Token: 0x04002370 RID: 9072
		private HealPoolInfo healPoolInfo_;

		// Token: 0x04002371 RID: 9073
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04002372 RID: 9074
		private uint retcode_;

		// Token: 0x04002373 RID: 9075
		public const int SpringRecoverConfigFieldNumber = 2;

		// Token: 0x04002374 RID: 9076
		private SpringRecoverConfig springRecoverConfig_;
	}
}

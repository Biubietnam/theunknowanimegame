using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001141 RID: 4417
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetTurnFoodSwitchScRsp : IMessage<SetTurnFoodSwitchScRsp>, IMessage, IEquatable<SetTurnFoodSwitchScRsp>, IDeepCloneable<SetTurnFoodSwitchScRsp>, IBufferMessage
	{
		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600C502 RID: 50434 RVA: 0x00210C6F File Offset: 0x0020EE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetTurnFoodSwitchScRsp> Parser
		{
			get
			{
				return SetTurnFoodSwitchScRsp._parser;
			}
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600C503 RID: 50435 RVA: 0x00210C76 File Offset: 0x0020EE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetTurnFoodSwitchScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0600C504 RID: 50436 RVA: 0x00210C88 File Offset: 0x0020EE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetTurnFoodSwitchScRsp.Descriptor;
			}
		}

		// Token: 0x0600C505 RID: 50437 RVA: 0x00210C8F File Offset: 0x0020EE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetTurnFoodSwitchScRsp()
		{
		}

		// Token: 0x0600C506 RID: 50438 RVA: 0x00210C97 File Offset: 0x0020EE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetTurnFoodSwitchScRsp(SetTurnFoodSwitchScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.cIEEDPPEKAC_ = other.cIEEDPPEKAC_;
			this.eDHONFLKEGG_ = other.eDHONFLKEGG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C507 RID: 50439 RVA: 0x00210CD4 File Offset: 0x0020EED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetTurnFoodSwitchScRsp Clone()
		{
			return new SetTurnFoodSwitchScRsp(this);
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0600C508 RID: 50440 RVA: 0x00210CDC File Offset: 0x0020EEDC
		// (set) Token: 0x0600C509 RID: 50441 RVA: 0x00210CE4 File Offset: 0x0020EEE4
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

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600C50A RID: 50442 RVA: 0x00210CED File Offset: 0x0020EEED
		// (set) Token: 0x0600C50B RID: 50443 RVA: 0x00210CF5 File Offset: 0x0020EEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurnFoodSwitch CIEEDPPEKAC
		{
			get
			{
				return this.cIEEDPPEKAC_;
			}
			set
			{
				this.cIEEDPPEKAC_ = value;
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600C50C RID: 50444 RVA: 0x00210CFE File Offset: 0x0020EEFE
		// (set) Token: 0x0600C50D RID: 50445 RVA: 0x00210D06 File Offset: 0x0020EF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EDHONFLKEGG
		{
			get
			{
				return this.eDHONFLKEGG_;
			}
			set
			{
				this.eDHONFLKEGG_ = value;
			}
		}

		// Token: 0x0600C50E RID: 50446 RVA: 0x00210D0F File Offset: 0x0020EF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetTurnFoodSwitchScRsp);
		}

		// Token: 0x0600C50F RID: 50447 RVA: 0x00210D20 File Offset: 0x0020EF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetTurnFoodSwitchScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.CIEEDPPEKAC == other.CIEEDPPEKAC && this.EDHONFLKEGG == other.EDHONFLKEGG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C510 RID: 50448 RVA: 0x00210D7C File Offset: 0x0020EF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CIEEDPPEKAC != TurnFoodSwitch.None)
			{
				num ^= this.CIEEDPPEKAC.GetHashCode();
			}
			if (this.EDHONFLKEGG)
			{
				num ^= this.EDHONFLKEGG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C511 RID: 50449 RVA: 0x00210DF3 File Offset: 0x0020EFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C512 RID: 50450 RVA: 0x00210DFB File Offset: 0x0020EFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C513 RID: 50451 RVA: 0x00210E04 File Offset: 0x0020F004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EDHONFLKEGG)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.EDHONFLKEGG);
			}
			if (this.CIEEDPPEKAC != TurnFoodSwitch.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.CIEEDPPEKAC);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C514 RID: 50452 RVA: 0x00210E7C File Offset: 0x0020F07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CIEEDPPEKAC != TurnFoodSwitch.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CIEEDPPEKAC);
			}
			if (this.EDHONFLKEGG)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C515 RID: 50453 RVA: 0x00210EE0 File Offset: 0x0020F0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetTurnFoodSwitchScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CIEEDPPEKAC != TurnFoodSwitch.None)
			{
				this.CIEEDPPEKAC = other.CIEEDPPEKAC;
			}
			if (other.EDHONFLKEGG)
			{
				this.EDHONFLKEGG = other.EDHONFLKEGG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C516 RID: 50454 RVA: 0x00210F44 File Offset: 0x0020F144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C517 RID: 50455 RVA: 0x00210F50 File Offset: 0x0020F150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.CIEEDPPEKAC = (TurnFoodSwitch)input.ReadEnum();
					}
				}
				else
				{
					this.EDHONFLKEGG = input.ReadBool();
				}
			}
		}

		// Token: 0x04004F95 RID: 20373
		private static readonly MessageParser<SetTurnFoodSwitchScRsp> _parser = new MessageParser<SetTurnFoodSwitchScRsp>(() => new SetTurnFoodSwitchScRsp());

		// Token: 0x04004F96 RID: 20374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F97 RID: 20375
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04004F98 RID: 20376
		private uint retcode_;

		// Token: 0x04004F99 RID: 20377
		public const int CIEEDPPEKACFieldNumber = 9;

		// Token: 0x04004F9A RID: 20378
		private TurnFoodSwitch cIEEDPPEKAC_;

		// Token: 0x04004F9B RID: 20379
		public const int EDHONFLKEGGFieldNumber = 8;

		// Token: 0x04004F9C RID: 20380
		private bool eDHONFLKEGG_;
	}
}

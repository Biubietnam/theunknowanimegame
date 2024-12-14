using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200113F RID: 4415
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetTurnFoodSwitchCsReq : IMessage<SetTurnFoodSwitchCsReq>, IMessage, IEquatable<SetTurnFoodSwitchCsReq>, IDeepCloneable<SetTurnFoodSwitchCsReq>, IBufferMessage
	{
		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0600C4EB RID: 50411 RVA: 0x00210915 File Offset: 0x0020EB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetTurnFoodSwitchCsReq> Parser
		{
			get
			{
				return SetTurnFoodSwitchCsReq._parser;
			}
		}

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0600C4EC RID: 50412 RVA: 0x0021091C File Offset: 0x0020EB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetTurnFoodSwitchCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600C4ED RID: 50413 RVA: 0x0021092E File Offset: 0x0020EB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetTurnFoodSwitchCsReq.Descriptor;
			}
		}

		// Token: 0x0600C4EE RID: 50414 RVA: 0x00210935 File Offset: 0x0020EB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetTurnFoodSwitchCsReq()
		{
		}

		// Token: 0x0600C4EF RID: 50415 RVA: 0x0021093D File Offset: 0x0020EB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetTurnFoodSwitchCsReq(SetTurnFoodSwitchCsReq other) : this()
		{
			this.eDHONFLKEGG_ = other.eDHONFLKEGG_;
			this.cIEEDPPEKAC_ = other.cIEEDPPEKAC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4F0 RID: 50416 RVA: 0x0021096E File Offset: 0x0020EB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetTurnFoodSwitchCsReq Clone()
		{
			return new SetTurnFoodSwitchCsReq(this);
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600C4F1 RID: 50417 RVA: 0x00210976 File Offset: 0x0020EB76
		// (set) Token: 0x0600C4F2 RID: 50418 RVA: 0x0021097E File Offset: 0x0020EB7E
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

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600C4F3 RID: 50419 RVA: 0x00210987 File Offset: 0x0020EB87
		// (set) Token: 0x0600C4F4 RID: 50420 RVA: 0x0021098F File Offset: 0x0020EB8F
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

		// Token: 0x0600C4F5 RID: 50421 RVA: 0x00210998 File Offset: 0x0020EB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetTurnFoodSwitchCsReq);
		}

		// Token: 0x0600C4F6 RID: 50422 RVA: 0x002109A6 File Offset: 0x0020EBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetTurnFoodSwitchCsReq other)
		{
			return other != null && (other == this || (this.EDHONFLKEGG == other.EDHONFLKEGG && this.CIEEDPPEKAC == other.CIEEDPPEKAC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4F7 RID: 50423 RVA: 0x002109E4 File Offset: 0x0020EBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EDHONFLKEGG)
			{
				num ^= this.EDHONFLKEGG.GetHashCode();
			}
			if (this.CIEEDPPEKAC != TurnFoodSwitch.None)
			{
				num ^= this.CIEEDPPEKAC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4F8 RID: 50424 RVA: 0x00210A42 File Offset: 0x0020EC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C4F9 RID: 50425 RVA: 0x00210A4A File Offset: 0x0020EC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4FA RID: 50426 RVA: 0x00210A54 File Offset: 0x0020EC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CIEEDPPEKAC != TurnFoodSwitch.None)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.CIEEDPPEKAC);
			}
			if (this.EDHONFLKEGG)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.EDHONFLKEGG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4FB RID: 50427 RVA: 0x00210AB0 File Offset: 0x0020ECB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EDHONFLKEGG)
			{
				num += 2;
			}
			if (this.CIEEDPPEKAC != TurnFoodSwitch.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CIEEDPPEKAC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4FC RID: 50428 RVA: 0x00210AFC File Offset: 0x0020ECFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetTurnFoodSwitchCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EDHONFLKEGG)
			{
				this.EDHONFLKEGG = other.EDHONFLKEGG;
			}
			if (other.CIEEDPPEKAC != TurnFoodSwitch.None)
			{
				this.CIEEDPPEKAC = other.CIEEDPPEKAC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4FD RID: 50429 RVA: 0x00210B4C File Offset: 0x0020ED4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x00210B58 File Offset: 0x0020ED58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EDHONFLKEGG = input.ReadBool();
					}
				}
				else
				{
					this.CIEEDPPEKAC = (TurnFoodSwitch)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004F8E RID: 20366
		private static readonly MessageParser<SetTurnFoodSwitchCsReq> _parser = new MessageParser<SetTurnFoodSwitchCsReq>(() => new SetTurnFoodSwitchCsReq());

		// Token: 0x04004F8F RID: 20367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F90 RID: 20368
		public const int EDHONFLKEGGFieldNumber = 14;

		// Token: 0x04004F91 RID: 20369
		private bool eDHONFLKEGG_;

		// Token: 0x04004F92 RID: 20370
		public const int CIEEDPPEKACFieldNumber = 10;

		// Token: 0x04004F93 RID: 20371
		private TurnFoodSwitch cIEEDPPEKAC_;
	}
}

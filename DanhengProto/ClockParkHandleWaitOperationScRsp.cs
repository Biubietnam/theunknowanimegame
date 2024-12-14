using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002F5 RID: 757
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkHandleWaitOperationScRsp : IMessage<ClockParkHandleWaitOperationScRsp>, IMessage, IEquatable<ClockParkHandleWaitOperationScRsp>, IDeepCloneable<ClockParkHandleWaitOperationScRsp>, IBufferMessage
	{
		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x000609DB File Offset: 0x0005EBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkHandleWaitOperationScRsp> Parser
		{
			get
			{
				return ClockParkHandleWaitOperationScRsp._parser;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x000609E2 File Offset: 0x0005EBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkHandleWaitOperationScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x000609F4 File Offset: 0x0005EBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkHandleWaitOperationScRsp.Descriptor;
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000609FB File Offset: 0x0005EBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkHandleWaitOperationScRsp()
		{
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00060A04 File Offset: 0x0005EC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkHandleWaitOperationScRsp(ClockParkHandleWaitOperationScRsp other) : this()
		{
			this.kELMDDKDNJA_ = other.kELMDDKDNJA_;
			this.retcode_ = other.retcode_;
			this.hIAGEINLAHL_ = other.hIAGEINLAHL_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.fGBPANCBLEC_ = other.fGBPANCBLEC_;
			this.bLPMDKEPMJB_ = other.bLPMDKEPMJB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00060A80 File Offset: 0x0005EC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkHandleWaitOperationScRsp Clone()
		{
			return new ClockParkHandleWaitOperationScRsp(this);
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x00060A88 File Offset: 0x0005EC88
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x00060A90 File Offset: 0x0005EC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkPlayStatus KELMDDKDNJA
		{
			get
			{
				return this.kELMDDKDNJA_;
			}
			set
			{
				this.kELMDDKDNJA_ = value;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00060A99 File Offset: 0x0005EC99
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x00060AA1 File Offset: 0x0005ECA1
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

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x00060AAA File Offset: 0x0005ECAA
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x00060AB2 File Offset: 0x0005ECB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HIAGEINLAHL
		{
			get
			{
				return this.hIAGEINLAHL_;
			}
			set
			{
				this.hIAGEINLAHL_ = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00060ABB File Offset: 0x0005ECBB
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x00060AC3 File Offset: 0x0005ECC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x00060ACC File Offset: 0x0005ECCC
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x00060AD4 File Offset: 0x0005ECD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FGBPANCBLEC
		{
			get
			{
				return this.fGBPANCBLEC_;
			}
			set
			{
				this.fGBPANCBLEC_ = value;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x00060ADD File Offset: 0x0005ECDD
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x00060AE5 File Offset: 0x0005ECE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BLPMDKEPMJB
		{
			get
			{
				return this.bLPMDKEPMJB_;
			}
			set
			{
				this.bLPMDKEPMJB_ = value;
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00060AEE File Offset: 0x0005ECEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkHandleWaitOperationScRsp);
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00060AFC File Offset: 0x0005ECFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkHandleWaitOperationScRsp other)
		{
			return other != null && (other == this || (this.KELMDDKDNJA == other.KELMDDKDNJA && this.Retcode == other.Retcode && this.HIAGEINLAHL == other.HIAGEINLAHL && object.Equals(this.BattleInfo, other.BattleInfo) && this.FGBPANCBLEC == other.FGBPANCBLEC && this.BLPMDKEPMJB == other.BLPMDKEPMJB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00060B8C File Offset: 0x0005ED8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KELMDDKDNJA != ClockParkPlayStatus.ClockParkPlayNone)
			{
				num ^= this.KELMDDKDNJA.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.HIAGEINLAHL != 0U)
			{
				num ^= this.HIAGEINLAHL.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.FGBPANCBLEC != 0U)
			{
				num ^= this.FGBPANCBLEC.GetHashCode();
			}
			if (this.BLPMDKEPMJB != 0U)
			{
				num ^= this.BLPMDKEPMJB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00060C4B File Offset: 0x0005EE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00060C53 File Offset: 0x0005EE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00060C5C File Offset: 0x0005EE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BLPMDKEPMJB != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BLPMDKEPMJB);
			}
			if (this.KELMDDKDNJA != ClockParkPlayStatus.ClockParkPlayNone)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.KELMDDKDNJA);
			}
			if (this.HIAGEINLAHL != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.HIAGEINLAHL);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.FGBPANCBLEC != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FGBPANCBLEC);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00060D24 File Offset: 0x0005EF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KELMDDKDNJA != ClockParkPlayStatus.ClockParkPlayNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.KELMDDKDNJA);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.HIAGEINLAHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HIAGEINLAHL);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.FGBPANCBLEC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FGBPANCBLEC);
			}
			if (this.BLPMDKEPMJB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BLPMDKEPMJB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00060DDC File Offset: 0x0005EFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkHandleWaitOperationScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KELMDDKDNJA != ClockParkPlayStatus.ClockParkPlayNone)
			{
				this.KELMDDKDNJA = other.KELMDDKDNJA;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.HIAGEINLAHL != 0U)
			{
				this.HIAGEINLAHL = other.HIAGEINLAHL;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.FGBPANCBLEC != 0U)
			{
				this.FGBPANCBLEC = other.FGBPANCBLEC;
			}
			if (other.BLPMDKEPMJB != 0U)
			{
				this.BLPMDKEPMJB = other.BLPMDKEPMJB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00060E94 File Offset: 0x0005F094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00060EA0 File Offset: 0x0005F0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.BLPMDKEPMJB = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.KELMDDKDNJA = (ClockParkPlayStatus)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.HIAGEINLAHL = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
					if (num == 80U)
					{
						this.FGBPANCBLEC = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DFF RID: 3583
		private static readonly MessageParser<ClockParkHandleWaitOperationScRsp> _parser = new MessageParser<ClockParkHandleWaitOperationScRsp>(() => new ClockParkHandleWaitOperationScRsp());

		// Token: 0x04000E00 RID: 3584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E01 RID: 3585
		public const int KELMDDKDNJAFieldNumber = 6;

		// Token: 0x04000E02 RID: 3586
		private ClockParkPlayStatus kELMDDKDNJA_;

		// Token: 0x04000E03 RID: 3587
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04000E04 RID: 3588
		private uint retcode_;

		// Token: 0x04000E05 RID: 3589
		public const int HIAGEINLAHLFieldNumber = 8;

		// Token: 0x04000E06 RID: 3590
		private uint hIAGEINLAHL_;

		// Token: 0x04000E07 RID: 3591
		public const int BattleInfoFieldNumber = 9;

		// Token: 0x04000E08 RID: 3592
		private SceneBattleInfo battleInfo_;

		// Token: 0x04000E09 RID: 3593
		public const int FGBPANCBLECFieldNumber = 10;

		// Token: 0x04000E0A RID: 3594
		private uint fGBPANCBLEC_;

		// Token: 0x04000E0B RID: 3595
		public const int BLPMDKEPMJBFieldNumber = 1;

		// Token: 0x04000E0C RID: 3596
		private uint bLPMDKEPMJB_;
	}
}

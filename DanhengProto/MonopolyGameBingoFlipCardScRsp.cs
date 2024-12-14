using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B2F RID: 2863
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGameBingoFlipCardScRsp : IMessage<MonopolyGameBingoFlipCardScRsp>, IMessage, IEquatable<MonopolyGameBingoFlipCardScRsp>, IDeepCloneable<MonopolyGameBingoFlipCardScRsp>, IBufferMessage
	{
		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x06007EB8 RID: 32440 RVA: 0x0014EF5F File Offset: 0x0014D15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGameBingoFlipCardScRsp> Parser
		{
			get
			{
				return MonopolyGameBingoFlipCardScRsp._parser;
			}
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x0014EF66 File Offset: 0x0014D166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGameBingoFlipCardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x06007EBA RID: 32442 RVA: 0x0014EF78 File Offset: 0x0014D178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGameBingoFlipCardScRsp.Descriptor;
			}
		}

		// Token: 0x06007EBB RID: 32443 RVA: 0x0014EF7F File Offset: 0x0014D17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameBingoFlipCardScRsp()
		{
		}

		// Token: 0x06007EBC RID: 32444 RVA: 0x0014EF94 File Offset: 0x0014D194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameBingoFlipCardScRsp(MonopolyGameBingoFlipCardScRsp other) : this()
		{
			this.bBKDCNDIJLN_ = other.bBKDCNDIJLN_;
			this.dFPOPHBKELB_ = other.dFPOPHBKELB_.Clone();
			this.retcode_ = other.retcode_;
			this.lPPHCCHIKFG_ = other.lPPHCCHIKFG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EBD RID: 32445 RVA: 0x0014EFED File Offset: 0x0014D1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameBingoFlipCardScRsp Clone()
		{
			return new MonopolyGameBingoFlipCardScRsp(this);
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x06007EBE RID: 32446 RVA: 0x0014EFF5 File Offset: 0x0014D1F5
		// (set) Token: 0x06007EBF RID: 32447 RVA: 0x0014EFFD File Offset: 0x0014D1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BBKDCNDIJLN
		{
			get
			{
				return this.bBKDCNDIJLN_;
			}
			set
			{
				this.bBKDCNDIJLN_ = value;
			}
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x0014F006 File Offset: 0x0014D206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DFPOPHBKELB
		{
			get
			{
				return this.dFPOPHBKELB_;
			}
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x06007EC1 RID: 32449 RVA: 0x0014F00E File Offset: 0x0014D20E
		// (set) Token: 0x06007EC2 RID: 32450 RVA: 0x0014F016 File Offset: 0x0014D216
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

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x06007EC3 RID: 32451 RVA: 0x0014F01F File Offset: 0x0014D21F
		// (set) Token: 0x06007EC4 RID: 32452 RVA: 0x0014F027 File Offset: 0x0014D227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LPPHCCHIKFG
		{
			get
			{
				return this.lPPHCCHIKFG_;
			}
			set
			{
				this.lPPHCCHIKFG_ = value;
			}
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x0014F030 File Offset: 0x0014D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGameBingoFlipCardScRsp);
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x0014F040 File Offset: 0x0014D240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGameBingoFlipCardScRsp other)
		{
			return other != null && (other == this || (this.BBKDCNDIJLN == other.BBKDCNDIJLN && this.dFPOPHBKELB_.Equals(other.dFPOPHBKELB_) && this.Retcode == other.Retcode && this.LPPHCCHIKFG == other.LPPHCCHIKFG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x0014F0B0 File Offset: 0x0014D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BBKDCNDIJLN != 0U)
			{
				num ^= this.BBKDCNDIJLN.GetHashCode();
			}
			num ^= this.dFPOPHBKELB_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.LPPHCCHIKFG)
			{
				num ^= this.LPPHCCHIKFG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x0014F12F File Offset: 0x0014D32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007EC9 RID: 32457 RVA: 0x0014F137 File Offset: 0x0014D337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007ECA RID: 32458 RVA: 0x0014F140 File Offset: 0x0014D340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.dFPOPHBKELB_.WriteTo(ref output, MonopolyGameBingoFlipCardScRsp._repeated_dFPOPHBKELB_codec);
			if (this.LPPHCCHIKFG)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.LPPHCCHIKFG);
			}
			if (this.BBKDCNDIJLN != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BBKDCNDIJLN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007ECB RID: 32459 RVA: 0x0014F1C8 File Offset: 0x0014D3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BBKDCNDIJLN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BBKDCNDIJLN);
			}
			num += this.dFPOPHBKELB_.CalculateSize(MonopolyGameBingoFlipCardScRsp._repeated_dFPOPHBKELB_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.LPPHCCHIKFG)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x0014F240 File Offset: 0x0014D440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGameBingoFlipCardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BBKDCNDIJLN != 0U)
			{
				this.BBKDCNDIJLN = other.BBKDCNDIJLN;
			}
			this.dFPOPHBKELB_.Add(other.dFPOPHBKELB_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.LPPHCCHIKFG)
			{
				this.LPPHCCHIKFG = other.LPPHCCHIKFG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007ECD RID: 32461 RVA: 0x0014F2B5 File Offset: 0x0014D4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007ECE RID: 32462 RVA: 0x0014F2C0 File Offset: 0x0014D4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						goto IL_44;
					}
				}
				else
				{
					if (num == 50U)
					{
						goto IL_44;
					}
					if (num == 64U)
					{
						this.LPPHCCHIKFG = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.BBKDCNDIJLN = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_44:
				this.dFPOPHBKELB_.AddEntriesFrom(ref input, MonopolyGameBingoFlipCardScRsp._repeated_dFPOPHBKELB_codec);
			}
		}

		// Token: 0x04003093 RID: 12435
		private static readonly MessageParser<MonopolyGameBingoFlipCardScRsp> _parser = new MessageParser<MonopolyGameBingoFlipCardScRsp>(() => new MonopolyGameBingoFlipCardScRsp());

		// Token: 0x04003094 RID: 12436
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003095 RID: 12437
		public const int BBKDCNDIJLNFieldNumber = 11;

		// Token: 0x04003096 RID: 12438
		private uint bBKDCNDIJLN_;

		// Token: 0x04003097 RID: 12439
		public const int DFPOPHBKELBFieldNumber = 6;

		// Token: 0x04003098 RID: 12440
		private static readonly FieldCodec<uint> _repeated_dFPOPHBKELB_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04003099 RID: 12441
		private readonly RepeatedField<uint> dFPOPHBKELB_ = new RepeatedField<uint>();

		// Token: 0x0400309A RID: 12442
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400309B RID: 12443
		private uint retcode_;

		// Token: 0x0400309C RID: 12444
		public const int LPPHCCHIKFGFieldNumber = 8;

		// Token: 0x0400309D RID: 12445
		private bool lPPHCCHIKFG_;
	}
}

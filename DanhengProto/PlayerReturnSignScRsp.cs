using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CD9 RID: 3289
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnSignScRsp : IMessage<PlayerReturnSignScRsp>, IMessage, IEquatable<PlayerReturnSignScRsp>, IDeepCloneable<PlayerReturnSignScRsp>, IBufferMessage
	{
		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x060092B5 RID: 37557 RVA: 0x001850F7 File Offset: 0x001832F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnSignScRsp> Parser
		{
			get
			{
				return PlayerReturnSignScRsp._parser;
			}
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x060092B6 RID: 37558 RVA: 0x001850FE File Offset: 0x001832FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnSignScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x060092B7 RID: 37559 RVA: 0x00185110 File Offset: 0x00183310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnSignScRsp.Descriptor;
			}
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x00185117 File Offset: 0x00183317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnSignScRsp()
		{
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x00185138 File Offset: 0x00183338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnSignScRsp(PlayerReturnSignScRsp other) : this()
		{
			this.gPIHCHDJAPF_ = other.gPIHCHDJAPF_.Clone();
			this.kABFEPDMFBH_ = other.kABFEPDMFBH_;
			this.retcode_ = other.retcode_;
			this.nOFCPIPLKOI_ = other.nOFCPIPLKOI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x00185196 File Offset: 0x00183396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnSignScRsp Clone()
		{
			return new PlayerReturnSignScRsp(this);
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x060092BB RID: 37563 RVA: 0x0018519E File Offset: 0x0018339E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemList> GPIHCHDJAPF
		{
			get
			{
				return this.gPIHCHDJAPF_;
			}
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x060092BC RID: 37564 RVA: 0x001851A6 File Offset: 0x001833A6
		// (set) Token: 0x060092BD RID: 37565 RVA: 0x001851AE File Offset: 0x001833AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KABFEPDMFBH
		{
			get
			{
				return this.kABFEPDMFBH_;
			}
			set
			{
				this.kABFEPDMFBH_ = value;
			}
		}

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x060092BE RID: 37566 RVA: 0x001851B7 File Offset: 0x001833B7
		// (set) Token: 0x060092BF RID: 37567 RVA: 0x001851BF File Offset: 0x001833BF
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

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x060092C0 RID: 37568 RVA: 0x001851C8 File Offset: 0x001833C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NOFCPIPLKOI
		{
			get
			{
				return this.nOFCPIPLKOI_;
			}
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x001851D0 File Offset: 0x001833D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnSignScRsp);
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x001851E0 File Offset: 0x001833E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnSignScRsp other)
		{
			return other != null && (other == this || (this.gPIHCHDJAPF_.Equals(other.gPIHCHDJAPF_) && this.KABFEPDMFBH == other.KABFEPDMFBH && this.Retcode == other.Retcode && this.nOFCPIPLKOI_.Equals(other.nOFCPIPLKOI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x00185254 File Offset: 0x00183454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gPIHCHDJAPF_.GetHashCode();
			if (this.KABFEPDMFBH != 0U)
			{
				num ^= this.KABFEPDMFBH.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.nOFCPIPLKOI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092C4 RID: 37572 RVA: 0x001852C8 File Offset: 0x001834C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060092C5 RID: 37573 RVA: 0x001852D0 File Offset: 0x001834D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x001852DC File Offset: 0x001834DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KABFEPDMFBH != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.KABFEPDMFBH);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.nOFCPIPLKOI_.WriteTo(ref output, PlayerReturnSignScRsp._repeated_nOFCPIPLKOI_codec);
			this.gPIHCHDJAPF_.WriteTo(ref output, PlayerReturnSignScRsp._repeated_gPIHCHDJAPF_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x00185358 File Offset: 0x00183558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gPIHCHDJAPF_.CalculateSize(PlayerReturnSignScRsp._repeated_gPIHCHDJAPF_codec);
			if (this.KABFEPDMFBH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KABFEPDMFBH);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.nOFCPIPLKOI_.CalculateSize(PlayerReturnSignScRsp._repeated_nOFCPIPLKOI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x001853D4 File Offset: 0x001835D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnSignScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.gPIHCHDJAPF_.Add(other.gPIHCHDJAPF_);
			if (other.KABFEPDMFBH != 0U)
			{
				this.KABFEPDMFBH = other.KABFEPDMFBH;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.nOFCPIPLKOI_.Add(other.nOFCPIPLKOI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092C9 RID: 37577 RVA: 0x00185446 File Offset: 0x00183646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092CA RID: 37578 RVA: 0x00185450 File Offset: 0x00183650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.KABFEPDMFBH = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U || num == 66U)
					{
						this.nOFCPIPLKOI_.AddEntriesFrom(ref input, PlayerReturnSignScRsp._repeated_nOFCPIPLKOI_codec);
						continue;
					}
					if (num == 98U)
					{
						this.gPIHCHDJAPF_.AddEntriesFrom(ref input, PlayerReturnSignScRsp._repeated_gPIHCHDJAPF_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003897 RID: 14487
		private static readonly MessageParser<PlayerReturnSignScRsp> _parser = new MessageParser<PlayerReturnSignScRsp>(() => new PlayerReturnSignScRsp());

		// Token: 0x04003898 RID: 14488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003899 RID: 14489
		public const int GPIHCHDJAPFFieldNumber = 12;

		// Token: 0x0400389A RID: 14490
		private static readonly FieldCodec<ItemList> _repeated_gPIHCHDJAPF_codec = FieldCodec.ForMessage<ItemList>(98U, ItemList.Parser);

		// Token: 0x0400389B RID: 14491
		private readonly RepeatedField<ItemList> gPIHCHDJAPF_ = new RepeatedField<ItemList>();

		// Token: 0x0400389C RID: 14492
		public const int KABFEPDMFBHFieldNumber = 1;

		// Token: 0x0400389D RID: 14493
		private uint kABFEPDMFBH_;

		// Token: 0x0400389E RID: 14494
		public const int RetcodeFieldNumber = 4;

		// Token: 0x0400389F RID: 14495
		private uint retcode_;

		// Token: 0x040038A0 RID: 14496
		public const int NOFCPIPLKOIFieldNumber = 8;

		// Token: 0x040038A1 RID: 14497
		private static readonly FieldCodec<uint> _repeated_nOFCPIPLKOI_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x040038A2 RID: 14498
		private readonly RepeatedField<uint> nOFCPIPLKOI_ = new RepeatedField<uint>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000685 RID: 1669
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetDrinkMakerDataScRsp : IMessage<GetDrinkMakerDataScRsp>, IMessage, IEquatable<GetDrinkMakerDataScRsp>, IDeepCloneable<GetDrinkMakerDataScRsp>, IBufferMessage
	{
		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x000CB372 File Offset: 0x000C9572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetDrinkMakerDataScRsp> Parser
		{
			get
			{
				return GetDrinkMakerDataScRsp._parser;
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x000CB379 File Offset: 0x000C9579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetDrinkMakerDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x000CB38B File Offset: 0x000C958B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDrinkMakerDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x000CB392 File Offset: 0x000C9592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDrinkMakerDataScRsp()
		{
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x000CB3B0 File Offset: 0x000C95B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDrinkMakerDataScRsp(GetDrinkMakerDataScRsp other) : this()
		{
			this.exp_ = other.exp_;
			this.pAHBKDPKLFB_ = other.pAHBKDPKLFB_;
			this.fLNJDFHNNFI_ = ((other.fLNJDFHNNFI_ != null) ? other.fLNJDFHNNFI_.Clone() : null);
			this.bAAGLIIDLNK_ = other.bAAGLIIDLNK_;
			this.hJIFBKPIDOG_ = other.hJIFBKPIDOG_;
			this.dCPHNKMFLMN_ = other.dCPHNKMFLMN_.Clone();
			this.level_ = other.level_;
			this.fAABGHNMGHM_ = other.fAABGHNMGHM_;
			this.lPNCFLAKPOH_ = other.lPNCFLAKPOH_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x000CB466 File Offset: 0x000C9666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDrinkMakerDataScRsp Clone()
		{
			return new GetDrinkMakerDataScRsp(this);
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06004AC1 RID: 19137 RVA: 0x000CB46E File Offset: 0x000C966E
		// (set) Token: 0x06004AC2 RID: 19138 RVA: 0x000CB476 File Offset: 0x000C9676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x000CB47F File Offset: 0x000C967F
		// (set) Token: 0x06004AC4 RID: 19140 RVA: 0x000CB487 File Offset: 0x000C9687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PAHBKDPKLFB
		{
			get
			{
				return this.pAHBKDPKLFB_;
			}
			set
			{
				this.pAHBKDPKLFB_ = value;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06004AC5 RID: 19141 RVA: 0x000CB490 File Offset: 0x000C9690
		// (set) Token: 0x06004AC6 RID: 19142 RVA: 0x000CB498 File Offset: 0x000C9698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LGNIOADJNOJ FLNJDFHNNFI
		{
			get
			{
				return this.fLNJDFHNNFI_;
			}
			set
			{
				this.fLNJDFHNNFI_ = value;
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06004AC7 RID: 19143 RVA: 0x000CB4A1 File Offset: 0x000C96A1
		// (set) Token: 0x06004AC8 RID: 19144 RVA: 0x000CB4A9 File Offset: 0x000C96A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BAAGLIIDLNK
		{
			get
			{
				return this.bAAGLIIDLNK_;
			}
			set
			{
				this.bAAGLIIDLNK_ = value;
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x000CB4B2 File Offset: 0x000C96B2
		// (set) Token: 0x06004ACA RID: 19146 RVA: 0x000CB4BA File Offset: 0x000C96BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HJIFBKPIDOG
		{
			get
			{
				return this.hJIFBKPIDOG_;
			}
			set
			{
				this.hJIFBKPIDOG_ = value;
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06004ACB RID: 19147 RVA: 0x000CB4C3 File Offset: 0x000C96C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DCPHNKMFLMN
		{
			get
			{
				return this.dCPHNKMFLMN_;
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x000CB4CB File Offset: 0x000C96CB
		// (set) Token: 0x06004ACD RID: 19149 RVA: 0x000CB4D3 File Offset: 0x000C96D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x000CB4DC File Offset: 0x000C96DC
		// (set) Token: 0x06004ACF RID: 19151 RVA: 0x000CB4E4 File Offset: 0x000C96E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FAABGHNMGHM
		{
			get
			{
				return this.fAABGHNMGHM_;
			}
			set
			{
				this.fAABGHNMGHM_ = value;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x000CB4ED File Offset: 0x000C96ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DrinkMakerGuest> LPNCFLAKPOH
		{
			get
			{
				return this.lPNCFLAKPOH_;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06004AD1 RID: 19153 RVA: 0x000CB4F5 File Offset: 0x000C96F5
		// (set) Token: 0x06004AD2 RID: 19154 RVA: 0x000CB4FD File Offset: 0x000C96FD
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

		// Token: 0x06004AD3 RID: 19155 RVA: 0x000CB506 File Offset: 0x000C9706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDrinkMakerDataScRsp);
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x000CB514 File Offset: 0x000C9714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDrinkMakerDataScRsp other)
		{
			return other != null && (other == this || (this.Exp == other.Exp && this.PAHBKDPKLFB == other.PAHBKDPKLFB && object.Equals(this.FLNJDFHNNFI, other.FLNJDFHNNFI) && this.BAAGLIIDLNK == other.BAAGLIIDLNK && this.HJIFBKPIDOG == other.HJIFBKPIDOG && this.dCPHNKMFLMN_.Equals(other.dCPHNKMFLMN_) && this.Level == other.Level && this.FAABGHNMGHM == other.FAABGHNMGHM && this.lPNCFLAKPOH_.Equals(other.lPNCFLAKPOH_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x000CB5EC File Offset: 0x000C97EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.PAHBKDPKLFB != 0U)
			{
				num ^= this.PAHBKDPKLFB.GetHashCode();
			}
			if (this.fLNJDFHNNFI_ != null)
			{
				num ^= this.FLNJDFHNNFI.GetHashCode();
			}
			if (this.BAAGLIIDLNK != 0U)
			{
				num ^= this.BAAGLIIDLNK.GetHashCode();
			}
			if (this.HJIFBKPIDOG != 0U)
			{
				num ^= this.HJIFBKPIDOG.GetHashCode();
			}
			num ^= this.dCPHNKMFLMN_.GetHashCode();
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.FAABGHNMGHM != 0U)
			{
				num ^= this.FAABGHNMGHM.GetHashCode();
			}
			num ^= this.lPNCFLAKPOH_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x000CB6F3 File Offset: 0x000C98F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x000CB6FB File Offset: 0x000C98FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x000CB704 File Offset: 0x000C9904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dCPHNKMFLMN_.WriteTo(ref output, GetDrinkMakerDataScRsp._repeated_dCPHNKMFLMN_codec);
			if (this.PAHBKDPKLFB != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PAHBKDPKLFB);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Exp);
			}
			if (this.HJIFBKPIDOG != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HJIFBKPIDOG);
			}
			if (this.FAABGHNMGHM != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.FAABGHNMGHM);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Level);
			}
			if (this.fLNJDFHNNFI_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FLNJDFHNNFI);
			}
			if (this.BAAGLIIDLNK != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BAAGLIIDLNK);
			}
			this.lPNCFLAKPOH_.WriteTo(ref output, GetDrinkMakerDataScRsp._repeated_lPNCFLAKPOH_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x000CB828 File Offset: 0x000C9A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.PAHBKDPKLFB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PAHBKDPKLFB);
			}
			if (this.fLNJDFHNNFI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FLNJDFHNNFI);
			}
			if (this.BAAGLIIDLNK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BAAGLIIDLNK);
			}
			if (this.HJIFBKPIDOG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HJIFBKPIDOG);
			}
			num += this.dCPHNKMFLMN_.CalculateSize(GetDrinkMakerDataScRsp._repeated_dCPHNKMFLMN_codec);
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.FAABGHNMGHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FAABGHNMGHM);
			}
			num += this.lPNCFLAKPOH_.CalculateSize(GetDrinkMakerDataScRsp._repeated_lPNCFLAKPOH_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x000CB934 File Offset: 0x000C9B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDrinkMakerDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.PAHBKDPKLFB != 0U)
			{
				this.PAHBKDPKLFB = other.PAHBKDPKLFB;
			}
			if (other.fLNJDFHNNFI_ != null)
			{
				if (this.fLNJDFHNNFI_ == null)
				{
					this.FLNJDFHNNFI = new LGNIOADJNOJ();
				}
				this.FLNJDFHNNFI.MergeFrom(other.FLNJDFHNNFI);
			}
			if (other.BAAGLIIDLNK != 0U)
			{
				this.BAAGLIIDLNK = other.BAAGLIIDLNK;
			}
			if (other.HJIFBKPIDOG != 0U)
			{
				this.HJIFBKPIDOG = other.HJIFBKPIDOG;
			}
			this.dCPHNKMFLMN_.Add(other.dCPHNKMFLMN_);
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.FAABGHNMGHM != 0U)
			{
				this.FAABGHNMGHM = other.FAABGHNMGHM;
			}
			this.lPNCFLAKPOH_.Add(other.lPNCFLAKPOH_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x000CBA36 File Offset: 0x000C9C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x000CBA40 File Offset: 0x000C9C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.dCPHNKMFLMN_.AddEntriesFrom(ref input, GetDrinkMakerDataScRsp._repeated_dCPHNKMFLMN_codec);
							continue;
						}
					}
					else
					{
						if (num == 16U)
						{
							this.PAHBKDPKLFB = input.ReadUInt32();
							continue;
						}
						if (num == 24U)
						{
							this.Exp = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.HJIFBKPIDOG = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 48U)
					{
						this.FAABGHNMGHM = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 82U)
					{
						if (this.fLNJDFHNNFI_ == null)
						{
							this.FLNJDFHNNFI = new LGNIOADJNOJ();
						}
						input.ReadMessage(this.FLNJDFHNNFI);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.BAAGLIIDLNK = input.ReadUInt32();
						continue;
					}
					if (num == 98U)
					{
						this.lPNCFLAKPOH_.AddEntriesFrom(ref input, GetDrinkMakerDataScRsp._repeated_lPNCFLAKPOH_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D9F RID: 7583
		private static readonly MessageParser<GetDrinkMakerDataScRsp> _parser = new MessageParser<GetDrinkMakerDataScRsp>(() => new GetDrinkMakerDataScRsp());

		// Token: 0x04001DA0 RID: 7584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DA1 RID: 7585
		public const int ExpFieldNumber = 3;

		// Token: 0x04001DA2 RID: 7586
		private uint exp_;

		// Token: 0x04001DA3 RID: 7587
		public const int PAHBKDPKLFBFieldNumber = 2;

		// Token: 0x04001DA4 RID: 7588
		private uint pAHBKDPKLFB_;

		// Token: 0x04001DA5 RID: 7589
		public const int FLNJDFHNNFIFieldNumber = 10;

		// Token: 0x04001DA6 RID: 7590
		private LGNIOADJNOJ fLNJDFHNNFI_;

		// Token: 0x04001DA7 RID: 7591
		public const int BAAGLIIDLNKFieldNumber = 11;

		// Token: 0x04001DA8 RID: 7592
		private uint bAAGLIIDLNK_;

		// Token: 0x04001DA9 RID: 7593
		public const int HJIFBKPIDOGFieldNumber = 5;

		// Token: 0x04001DAA RID: 7594
		private uint hJIFBKPIDOG_;

		// Token: 0x04001DAB RID: 7595
		public const int DCPHNKMFLMNFieldNumber = 1;

		// Token: 0x04001DAC RID: 7596
		private static readonly FieldCodec<uint> _repeated_dCPHNKMFLMN_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04001DAD RID: 7597
		private readonly RepeatedField<uint> dCPHNKMFLMN_ = new RepeatedField<uint>();

		// Token: 0x04001DAE RID: 7598
		public const int LevelFieldNumber = 9;

		// Token: 0x04001DAF RID: 7599
		private uint level_;

		// Token: 0x04001DB0 RID: 7600
		public const int FAABGHNMGHMFieldNumber = 6;

		// Token: 0x04001DB1 RID: 7601
		private uint fAABGHNMGHM_;

		// Token: 0x04001DB2 RID: 7602
		public const int LPNCFLAKPOHFieldNumber = 12;

		// Token: 0x04001DB3 RID: 7603
		private static readonly FieldCodec<DrinkMakerGuest> _repeated_lPNCFLAKPOH_codec = FieldCodec.ForMessage<DrinkMakerGuest>(98U, DrinkMakerGuest.Parser);

		// Token: 0x04001DB4 RID: 7604
		private readonly RepeatedField<DrinkMakerGuest> lPNCFLAKPOH_ = new RepeatedField<DrinkMakerGuest>();

		// Token: 0x04001DB5 RID: 7605
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04001DB6 RID: 7606
		private uint retcode_;
	}
}

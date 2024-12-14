using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000605 RID: 1541
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAlleyInfoScRsp : IMessage<GetAlleyInfoScRsp>, IMessage, IEquatable<GetAlleyInfoScRsp>, IDeepCloneable<GetAlleyInfoScRsp>, IBufferMessage
	{
		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x000BD811 File Offset: 0x000BBA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAlleyInfoScRsp> Parser
		{
			get
			{
				return GetAlleyInfoScRsp._parser;
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x000BD818 File Offset: 0x000BBA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAlleyInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x000BD82A File Offset: 0x000BBA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAlleyInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x000BD831 File Offset: 0x000BBA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAlleyInfoScRsp()
		{
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x000BD870 File Offset: 0x000BBA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAlleyInfoScRsp(GetAlleyInfoScRsp other) : this()
		{
			this.cGKLMFHHPCC_ = ((other.cGKLMFHHPCC_ != null) ? other.cGKLMFHHPCC_.Clone() : null);
			this.nKNKOJKHDDF_ = other.nKNKOJKHDDF_.Clone();
			this.level_ = other.level_;
			this.jAAMCLIBAIO_ = ((other.jAAMCLIBAIO_ != null) ? other.jAAMCLIBAIO_.Clone() : null);
			this.nMHDBEMILMA_ = other.nMHDBEMILMA_;
			this.aBLBGHOJIBC_ = ((other.aBLBGHOJIBC_ != null) ? other.aBLBGHOJIBC_.Clone() : null);
			this.nLDEAJOMBIO_ = other.nLDEAJOMBIO_.Clone();
			this.mMIDJEHMHMP_ = other.mMIDJEHMHMP_;
			this.nEHCBGHEJHK_ = other.nEHCBGHEJHK_.Clone();
			this.oLDHNGGKABL_ = other.oLDHNGGKABL_.Clone();
			this.mMOMFLMMOII_ = other.mMOMFLMMOII_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x000BD96D File Offset: 0x000BBB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAlleyInfoScRsp Clone()
		{
			return new GetAlleyInfoScRsp(this);
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x000BD975 File Offset: 0x000BBB75
		// (set) Token: 0x06004521 RID: 17697 RVA: 0x000BD97D File Offset: 0x000BBB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BNPAEMJJCFG CGKLMFHHPCC
		{
			get
			{
				return this.cGKLMFHHPCC_;
			}
			set
			{
				this.cGKLMFHHPCC_ = value;
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x000BD986 File Offset: 0x000BBB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NKNKOJKHDDF
		{
			get
			{
				return this.nKNKOJKHDDF_;
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06004523 RID: 17699 RVA: 0x000BD98E File Offset: 0x000BBB8E
		// (set) Token: 0x06004524 RID: 17700 RVA: 0x000BD996 File Offset: 0x000BBB96
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

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06004525 RID: 17701 RVA: 0x000BD99F File Offset: 0x000BBB9F
		// (set) Token: 0x06004526 RID: 17702 RVA: 0x000BD9A7 File Offset: 0x000BBBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AEBKGEAGJCJ JAAMCLIBAIO
		{
			get
			{
				return this.jAAMCLIBAIO_;
			}
			set
			{
				this.jAAMCLIBAIO_ = value;
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06004527 RID: 17703 RVA: 0x000BD9B0 File Offset: 0x000BBBB0
		// (set) Token: 0x06004528 RID: 17704 RVA: 0x000BD9B8 File Offset: 0x000BBBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NMHDBEMILMA
		{
			get
			{
				return this.nMHDBEMILMA_;
			}
			set
			{
				this.nMHDBEMILMA_ = value;
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x000BD9C1 File Offset: 0x000BBBC1
		// (set) Token: 0x0600452A RID: 17706 RVA: 0x000BD9C9 File Offset: 0x000BBBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCHNGGIIOCD ABLBGHOJIBC
		{
			get
			{
				return this.aBLBGHOJIBC_;
			}
			set
			{
				this.aBLBGHOJIBC_ = value;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600452B RID: 17707 RVA: 0x000BD9D2 File Offset: 0x000BBBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> NLDEAJOMBIO
		{
			get
			{
				return this.nLDEAJOMBIO_;
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x000BD9DA File Offset: 0x000BBBDA
		// (set) Token: 0x0600452D RID: 17709 RVA: 0x000BD9E2 File Offset: 0x000BBBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMIDJEHMHMP
		{
			get
			{
				return this.mMIDJEHMHMP_;
			}
			set
			{
				this.mMIDJEHMHMP_ = value;
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600452E RID: 17710 RVA: 0x000BD9EB File Offset: 0x000BBBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NEHCBGHEJHK
		{
			get
			{
				return this.nEHCBGHEJHK_;
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x000BD9F3 File Offset: 0x000BBBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CKFJJBFEAPC> OLDHNGGKABL
		{
			get
			{
				return this.oLDHNGGKABL_;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06004530 RID: 17712 RVA: 0x000BD9FB File Offset: 0x000BBBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MMOMFLMMOII
		{
			get
			{
				return this.mMOMFLMMOII_;
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x000BDA03 File Offset: 0x000BBC03
		// (set) Token: 0x06004532 RID: 17714 RVA: 0x000BDA0B File Offset: 0x000BBC0B
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

		// Token: 0x06004533 RID: 17715 RVA: 0x000BDA14 File Offset: 0x000BBC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAlleyInfoScRsp);
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x000BDA24 File Offset: 0x000BBC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAlleyInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.CGKLMFHHPCC, other.CGKLMFHHPCC) && this.nKNKOJKHDDF_.Equals(other.nKNKOJKHDDF_) && this.Level == other.Level && object.Equals(this.JAAMCLIBAIO, other.JAAMCLIBAIO) && this.NMHDBEMILMA == other.NMHDBEMILMA && object.Equals(this.ABLBGHOJIBC, other.ABLBGHOJIBC) && this.NLDEAJOMBIO.Equals(other.NLDEAJOMBIO) && this.MMIDJEHMHMP == other.MMIDJEHMHMP && this.nEHCBGHEJHK_.Equals(other.nEHCBGHEJHK_) && this.oLDHNGGKABL_.Equals(other.oLDHNGGKABL_) && this.mMOMFLMMOII_.Equals(other.mMOMFLMMOII_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x000BDB38 File Offset: 0x000BBD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cGKLMFHHPCC_ != null)
			{
				num ^= this.CGKLMFHHPCC.GetHashCode();
			}
			num ^= this.nKNKOJKHDDF_.GetHashCode();
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.jAAMCLIBAIO_ != null)
			{
				num ^= this.JAAMCLIBAIO.GetHashCode();
			}
			if (this.NMHDBEMILMA != 0U)
			{
				num ^= this.NMHDBEMILMA.GetHashCode();
			}
			if (this.aBLBGHOJIBC_ != null)
			{
				num ^= this.ABLBGHOJIBC.GetHashCode();
			}
			num ^= this.NLDEAJOMBIO.GetHashCode();
			if (this.MMIDJEHMHMP != 0U)
			{
				num ^= this.MMIDJEHMHMP.GetHashCode();
			}
			num ^= this.nEHCBGHEJHK_.GetHashCode();
			num ^= this.oLDHNGGKABL_.GetHashCode();
			num ^= this.mMOMFLMMOII_.GetHashCode();
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

		// Token: 0x06004536 RID: 17718 RVA: 0x000BDC4A File Offset: 0x000BBE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x000BDC52 File Offset: 0x000BBE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x000BDC5C File Offset: 0x000BBE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Level);
			}
			this.nEHCBGHEJHK_.WriteTo(ref output, GetAlleyInfoScRsp._repeated_nEHCBGHEJHK_codec);
			this.nKNKOJKHDDF_.WriteTo(ref output, GetAlleyInfoScRsp._repeated_nKNKOJKHDDF_codec);
			if (this.NMHDBEMILMA != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NMHDBEMILMA);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			this.oLDHNGGKABL_.WriteTo(ref output, GetAlleyInfoScRsp._repeated_oLDHNGGKABL_codec);
			if (this.MMIDJEHMHMP != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MMIDJEHMHMP);
			}
			this.mMOMFLMMOII_.WriteTo(ref output, GetAlleyInfoScRsp._repeated_mMOMFLMMOII_codec);
			this.nLDEAJOMBIO_.WriteTo(ref output, GetAlleyInfoScRsp._map_nLDEAJOMBIO_codec);
			if (this.jAAMCLIBAIO_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.JAAMCLIBAIO);
			}
			if (this.aBLBGHOJIBC_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ABLBGHOJIBC);
			}
			if (this.cGKLMFHHPCC_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CGKLMFHHPCC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x000BDD98 File Offset: 0x000BBF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cGKLMFHHPCC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CGKLMFHHPCC);
			}
			num += this.nKNKOJKHDDF_.CalculateSize(GetAlleyInfoScRsp._repeated_nKNKOJKHDDF_codec);
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.jAAMCLIBAIO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JAAMCLIBAIO);
			}
			if (this.NMHDBEMILMA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMHDBEMILMA);
			}
			if (this.aBLBGHOJIBC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ABLBGHOJIBC);
			}
			num += this.nLDEAJOMBIO_.CalculateSize(GetAlleyInfoScRsp._map_nLDEAJOMBIO_codec);
			if (this.MMIDJEHMHMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMIDJEHMHMP);
			}
			num += this.nEHCBGHEJHK_.CalculateSize(GetAlleyInfoScRsp._repeated_nEHCBGHEJHK_codec);
			num += this.oLDHNGGKABL_.CalculateSize(GetAlleyInfoScRsp._repeated_oLDHNGGKABL_codec);
			num += this.mMOMFLMMOII_.CalculateSize(GetAlleyInfoScRsp._repeated_mMOMFLMMOII_codec);
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

		// Token: 0x0600453A RID: 17722 RVA: 0x000BDEC8 File Offset: 0x000BC0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAlleyInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cGKLMFHHPCC_ != null)
			{
				if (this.cGKLMFHHPCC_ == null)
				{
					this.CGKLMFHHPCC = new BNPAEMJJCFG();
				}
				this.CGKLMFHHPCC.MergeFrom(other.CGKLMFHHPCC);
			}
			this.nKNKOJKHDDF_.Add(other.nKNKOJKHDDF_);
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.jAAMCLIBAIO_ != null)
			{
				if (this.jAAMCLIBAIO_ == null)
				{
					this.JAAMCLIBAIO = new AEBKGEAGJCJ();
				}
				this.JAAMCLIBAIO.MergeFrom(other.JAAMCLIBAIO);
			}
			if (other.NMHDBEMILMA != 0U)
			{
				this.NMHDBEMILMA = other.NMHDBEMILMA;
			}
			if (other.aBLBGHOJIBC_ != null)
			{
				if (this.aBLBGHOJIBC_ == null)
				{
					this.ABLBGHOJIBC = new JCHNGGIIOCD();
				}
				this.ABLBGHOJIBC.MergeFrom(other.ABLBGHOJIBC);
			}
			this.nLDEAJOMBIO_.MergeFrom(other.nLDEAJOMBIO_);
			if (other.MMIDJEHMHMP != 0U)
			{
				this.MMIDJEHMHMP = other.MMIDJEHMHMP;
			}
			this.nEHCBGHEJHK_.Add(other.nEHCBGHEJHK_);
			this.oLDHNGGKABL_.Add(other.oLDHNGGKABL_);
			this.mMOMFLMMOII_.Add(other.mMOMFLMMOII_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x000BE019 File Offset: 0x000BC219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x000BE024 File Offset: 0x000BC224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 34U)
					{
						if (num == 24U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
						if (num == 32U || num == 34U)
						{
							this.nEHCBGHEJHK_.AddEntriesFrom(ref input, GetAlleyInfoScRsp._repeated_nEHCBGHEJHK_codec);
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 40U || num == 42U)
						{
							this.nKNKOJKHDDF_.AddEntriesFrom(ref input, GetAlleyInfoScRsp._repeated_nKNKOJKHDDF_codec);
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.NMHDBEMILMA = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num <= 80U)
					{
						if (num == 74U)
						{
							this.oLDHNGGKABL_.AddEntriesFrom(ref input, GetAlleyInfoScRsp._repeated_oLDHNGGKABL_codec);
							continue;
						}
						if (num == 80U)
						{
							this.MMIDJEHMHMP = input.ReadUInt32();
							continue;
						}
					}
					else if (num == 88U || num == 90U)
					{
						this.mMOMFLMMOII_.AddEntriesFrom(ref input, GetAlleyInfoScRsp._repeated_mMOMFLMMOII_codec);
						continue;
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						this.nLDEAJOMBIO_.AddEntriesFrom(ref input, GetAlleyInfoScRsp._map_nLDEAJOMBIO_codec);
						continue;
					}
					if (num == 106U)
					{
						if (this.jAAMCLIBAIO_ == null)
						{
							this.JAAMCLIBAIO = new AEBKGEAGJCJ();
						}
						input.ReadMessage(this.JAAMCLIBAIO);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.aBLBGHOJIBC_ == null)
						{
							this.ABLBGHOJIBC = new JCHNGGIIOCD();
						}
						input.ReadMessage(this.ABLBGHOJIBC);
						continue;
					}
					if (num == 122U)
					{
						if (this.cGKLMFHHPCC_ == null)
						{
							this.CGKLMFHHPCC = new BNPAEMJJCFG();
						}
						input.ReadMessage(this.CGKLMFHHPCC);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BA7 RID: 7079
		private static readonly MessageParser<GetAlleyInfoScRsp> _parser = new MessageParser<GetAlleyInfoScRsp>(() => new GetAlleyInfoScRsp());

		// Token: 0x04001BA8 RID: 7080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BA9 RID: 7081
		public const int CGKLMFHHPCCFieldNumber = 15;

		// Token: 0x04001BAA RID: 7082
		private BNPAEMJJCFG cGKLMFHHPCC_;

		// Token: 0x04001BAB RID: 7083
		public const int NKNKOJKHDDFFieldNumber = 5;

		// Token: 0x04001BAC RID: 7084
		private static readonly FieldCodec<uint> _repeated_nKNKOJKHDDF_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04001BAD RID: 7085
		private readonly RepeatedField<uint> nKNKOJKHDDF_ = new RepeatedField<uint>();

		// Token: 0x04001BAE RID: 7086
		public const int LevelFieldNumber = 3;

		// Token: 0x04001BAF RID: 7087
		private uint level_;

		// Token: 0x04001BB0 RID: 7088
		public const int JAAMCLIBAIOFieldNumber = 13;

		// Token: 0x04001BB1 RID: 7089
		private AEBKGEAGJCJ jAAMCLIBAIO_;

		// Token: 0x04001BB2 RID: 7090
		public const int NMHDBEMILMAFieldNumber = 6;

		// Token: 0x04001BB3 RID: 7091
		private uint nMHDBEMILMA_;

		// Token: 0x04001BB4 RID: 7092
		public const int ABLBGHOJIBCFieldNumber = 14;

		// Token: 0x04001BB5 RID: 7093
		private JCHNGGIIOCD aBLBGHOJIBC_;

		// Token: 0x04001BB6 RID: 7094
		public const int NLDEAJOMBIOFieldNumber = 12;

		// Token: 0x04001BB7 RID: 7095
		private static readonly MapField<uint, uint>.Codec _map_nLDEAJOMBIO_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 98U);

		// Token: 0x04001BB8 RID: 7096
		private readonly MapField<uint, uint> nLDEAJOMBIO_ = new MapField<uint, uint>();

		// Token: 0x04001BB9 RID: 7097
		public const int MMIDJEHMHMPFieldNumber = 10;

		// Token: 0x04001BBA RID: 7098
		private uint mMIDJEHMHMP_;

		// Token: 0x04001BBB RID: 7099
		public const int NEHCBGHEJHKFieldNumber = 4;

		// Token: 0x04001BBC RID: 7100
		private static readonly FieldCodec<uint> _repeated_nEHCBGHEJHK_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04001BBD RID: 7101
		private readonly RepeatedField<uint> nEHCBGHEJHK_ = new RepeatedField<uint>();

		// Token: 0x04001BBE RID: 7102
		public const int OLDHNGGKABLFieldNumber = 9;

		// Token: 0x04001BBF RID: 7103
		private static readonly FieldCodec<CKFJJBFEAPC> _repeated_oLDHNGGKABL_codec = FieldCodec.ForMessage<CKFJJBFEAPC>(74U, CKFJJBFEAPC.Parser);

		// Token: 0x04001BC0 RID: 7104
		private readonly RepeatedField<CKFJJBFEAPC> oLDHNGGKABL_ = new RepeatedField<CKFJJBFEAPC>();

		// Token: 0x04001BC1 RID: 7105
		public const int MMOMFLMMOIIFieldNumber = 11;

		// Token: 0x04001BC2 RID: 7106
		private static readonly FieldCodec<uint> _repeated_mMOMFLMMOII_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04001BC3 RID: 7107
		private readonly RepeatedField<uint> mMOMFLMMOII_ = new RepeatedField<uint>();

		// Token: 0x04001BC4 RID: 7108
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04001BC5 RID: 7109
		private uint retcode_;
	}
}

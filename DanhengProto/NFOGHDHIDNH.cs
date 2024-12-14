using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C11 RID: 3089
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NFOGHDHIDNH : IMessage<NFOGHDHIDNH>, IMessage, IEquatable<NFOGHDHIDNH>, IDeepCloneable<NFOGHDHIDNH>, IBufferMessage
	{
		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x060088B9 RID: 35001 RVA: 0x00168C3D File Offset: 0x00166E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NFOGHDHIDNH> Parser
		{
			get
			{
				return NFOGHDHIDNH._parser;
			}
		}

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x060088BA RID: 35002 RVA: 0x00168C44 File Offset: 0x00166E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NFOGHDHIDNHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x00168C56 File Offset: 0x00166E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NFOGHDHIDNH.Descriptor;
			}
		}

		// Token: 0x060088BC RID: 35004 RVA: 0x00168C5D File Offset: 0x00166E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFOGHDHIDNH()
		{
		}

		// Token: 0x060088BD RID: 35005 RVA: 0x00168C68 File Offset: 0x00166E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFOGHDHIDNH(NFOGHDHIDNH other) : this()
		{
			this.gAJNFOGLJGE_ = other.gAJNFOGLJGE_;
			this.jIDENEADELO_ = ((other.jIDENEADELO_ != null) ? other.jIDENEADELO_.Clone() : null);
			this.kAJIKKHPBBA_ = ((other.kAJIKKHPBBA_ != null) ? other.kAJIKKHPBBA_.Clone() : null);
			this.gKFDGDNNEEO_ = ((other.gKFDGDNNEEO_ != null) ? other.gKFDGDNNEEO_.Clone() : null);
			this.nKJPMLMNOKA_ = ((other.nKJPMLMNOKA_ != null) ? other.nKJPMLMNOKA_.Clone() : null);
			this.dMMJHDEOGNE_ = ((other.dMMJHDEOGNE_ != null) ? other.dMMJHDEOGNE_.Clone() : null);
			this.bEDINILDMEB_ = ((other.bEDINILDMEB_ != null) ? other.bEDINILDMEB_.Clone() : null);
			this.pUNKLORDSHARETYPEFRIEND_ = ((other.pUNKLORDSHARETYPEFRIEND_ != null) ? other.pUNKLORDSHARETYPEFRIEND_.Clone() : null);
			this.iEFNCDEECOF_ = ((other.iEFNCDEECOF_ != null) ? other.iEFNCDEECOF_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088BE RID: 35006 RVA: 0x00168D78 File Offset: 0x00166F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFOGHDHIDNH Clone()
		{
			return new NFOGHDHIDNH(this);
		}

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x060088BF RID: 35007 RVA: 0x00168D80 File Offset: 0x00166F80
		// (set) Token: 0x060088C0 RID: 35008 RVA: 0x00168D88 File Offset: 0x00166F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GAJNFOGLJGE
		{
			get
			{
				return this.gAJNFOGLJGE_;
			}
			set
			{
				this.gAJNFOGLJGE_ = value;
			}
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x060088C1 RID: 35009 RVA: 0x00168D91 File Offset: 0x00166F91
		// (set) Token: 0x060088C2 RID: 35010 RVA: 0x00168D99 File Offset: 0x00166F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HDGPKBGIHNB JIDENEADELO
		{
			get
			{
				return this.jIDENEADELO_;
			}
			set
			{
				this.jIDENEADELO_ = value;
			}
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x00168DA2 File Offset: 0x00166FA2
		// (set) Token: 0x060088C4 RID: 35012 RVA: 0x00168DAA File Offset: 0x00166FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMOJPENPNOL KAJIKKHPBBA
		{
			get
			{
				return this.kAJIKKHPBBA_;
			}
			set
			{
				this.kAJIKKHPBBA_ = value;
			}
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x060088C5 RID: 35013 RVA: 0x00168DB3 File Offset: 0x00166FB3
		// (set) Token: 0x060088C6 RID: 35014 RVA: 0x00168DBB File Offset: 0x00166FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NIPFDPOBDBP GKFDGDNNEEO
		{
			get
			{
				return this.gKFDGDNNEEO_;
			}
			set
			{
				this.gKFDGDNNEEO_ = value;
			}
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x060088C7 RID: 35015 RVA: 0x00168DC4 File Offset: 0x00166FC4
		// (set) Token: 0x060088C8 RID: 35016 RVA: 0x00168DCC File Offset: 0x00166FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FFJPONDPNAL NKJPMLMNOKA
		{
			get
			{
				return this.nKJPMLMNOKA_;
			}
			set
			{
				this.nKJPMLMNOKA_ = value;
			}
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x060088C9 RID: 35017 RVA: 0x00168DD5 File Offset: 0x00166FD5
		// (set) Token: 0x060088CA RID: 35018 RVA: 0x00168DDD File Offset: 0x00166FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PKGEFMGJONL DMMJHDEOGNE
		{
			get
			{
				return this.dMMJHDEOGNE_;
			}
			set
			{
				this.dMMJHDEOGNE_ = value;
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x060088CB RID: 35019 RVA: 0x00168DE6 File Offset: 0x00166FE6
		// (set) Token: 0x060088CC RID: 35020 RVA: 0x00168DEE File Offset: 0x00166FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MNEMPJMPPJE BEDINILDMEB
		{
			get
			{
				return this.bEDINILDMEB_;
			}
			set
			{
				this.bEDINILDMEB_ = value;
			}
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x060088CD RID: 35021 RVA: 0x00168DF7 File Offset: 0x00166FF7
		// (set) Token: 0x060088CE RID: 35022 RVA: 0x00168DFF File Offset: 0x00166FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHJINGMAIEB PUNKLORDSHARETYPEFRIEND
		{
			get
			{
				return this.pUNKLORDSHARETYPEFRIEND_;
			}
			set
			{
				this.pUNKLORDSHARETYPEFRIEND_ = value;
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x060088CF RID: 35023 RVA: 0x00168E08 File Offset: 0x00167008
		// (set) Token: 0x060088D0 RID: 35024 RVA: 0x00168E10 File Offset: 0x00167010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HEKPBHDOPNP IEFNCDEECOF
		{
			get
			{
				return this.iEFNCDEECOF_;
			}
			set
			{
				this.iEFNCDEECOF_ = value;
			}
		}

		// Token: 0x060088D1 RID: 35025 RVA: 0x00168E19 File Offset: 0x00167019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NFOGHDHIDNH);
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x00168E28 File Offset: 0x00167028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NFOGHDHIDNH other)
		{
			return other != null && (other == this || (this.GAJNFOGLJGE == other.GAJNFOGLJGE && object.Equals(this.JIDENEADELO, other.JIDENEADELO) && object.Equals(this.KAJIKKHPBBA, other.KAJIKKHPBBA) && object.Equals(this.GKFDGDNNEEO, other.GKFDGDNNEEO) && object.Equals(this.NKJPMLMNOKA, other.NKJPMLMNOKA) && object.Equals(this.DMMJHDEOGNE, other.DMMJHDEOGNE) && object.Equals(this.BEDINILDMEB, other.BEDINILDMEB) && object.Equals(this.PUNKLORDSHARETYPEFRIEND, other.PUNKLORDSHARETYPEFRIEND) && object.Equals(this.IEFNCDEECOF, other.IEFNCDEECOF) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088D3 RID: 35027 RVA: 0x00168F0C File Offset: 0x0016710C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GAJNFOGLJGE != 0U)
			{
				num ^= this.GAJNFOGLJGE.GetHashCode();
			}
			if (this.jIDENEADELO_ != null)
			{
				num ^= this.JIDENEADELO.GetHashCode();
			}
			if (this.kAJIKKHPBBA_ != null)
			{
				num ^= this.KAJIKKHPBBA.GetHashCode();
			}
			if (this.gKFDGDNNEEO_ != null)
			{
				num ^= this.GKFDGDNNEEO.GetHashCode();
			}
			if (this.nKJPMLMNOKA_ != null)
			{
				num ^= this.NKJPMLMNOKA.GetHashCode();
			}
			if (this.dMMJHDEOGNE_ != null)
			{
				num ^= this.DMMJHDEOGNE.GetHashCode();
			}
			if (this.bEDINILDMEB_ != null)
			{
				num ^= this.BEDINILDMEB.GetHashCode();
			}
			if (this.pUNKLORDSHARETYPEFRIEND_ != null)
			{
				num ^= this.PUNKLORDSHARETYPEFRIEND.GetHashCode();
			}
			if (this.iEFNCDEECOF_ != null)
			{
				num ^= this.IEFNCDEECOF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088D4 RID: 35028 RVA: 0x00168FFB File Offset: 0x001671FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060088D5 RID: 35029 RVA: 0x00169003 File Offset: 0x00167203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x0016900C File Offset: 0x0016720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.jIDENEADELO_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.JIDENEADELO);
			}
			if (this.gKFDGDNNEEO_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GKFDGDNNEEO);
			}
			if (this.kAJIKKHPBBA_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.KAJIKKHPBBA);
			}
			if (this.bEDINILDMEB_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.BEDINILDMEB);
			}
			if (this.GAJNFOGLJGE != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GAJNFOGLJGE);
			}
			if (this.nKJPMLMNOKA_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.NKJPMLMNOKA);
			}
			if (this.dMMJHDEOGNE_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.DMMJHDEOGNE);
			}
			if (this.pUNKLORDSHARETYPEFRIEND_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PUNKLORDSHARETYPEFRIEND);
			}
			if (this.iEFNCDEECOF_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.IEFNCDEECOF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x0016912C File Offset: 0x0016732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GAJNFOGLJGE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GAJNFOGLJGE);
			}
			if (this.jIDENEADELO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JIDENEADELO);
			}
			if (this.kAJIKKHPBBA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KAJIKKHPBBA);
			}
			if (this.gKFDGDNNEEO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GKFDGDNNEEO);
			}
			if (this.nKJPMLMNOKA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NKJPMLMNOKA);
			}
			if (this.dMMJHDEOGNE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DMMJHDEOGNE);
			}
			if (this.bEDINILDMEB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BEDINILDMEB);
			}
			if (this.pUNKLORDSHARETYPEFRIEND_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PUNKLORDSHARETYPEFRIEND);
			}
			if (this.iEFNCDEECOF_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IEFNCDEECOF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x0016922C File Offset: 0x0016742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NFOGHDHIDNH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GAJNFOGLJGE != 0U)
			{
				this.GAJNFOGLJGE = other.GAJNFOGLJGE;
			}
			if (other.jIDENEADELO_ != null)
			{
				if (this.jIDENEADELO_ == null)
				{
					this.JIDENEADELO = new HDGPKBGIHNB();
				}
				this.JIDENEADELO.MergeFrom(other.JIDENEADELO);
			}
			if (other.kAJIKKHPBBA_ != null)
			{
				if (this.kAJIKKHPBBA_ == null)
				{
					this.KAJIKKHPBBA = new PMOJPENPNOL();
				}
				this.KAJIKKHPBBA.MergeFrom(other.KAJIKKHPBBA);
			}
			if (other.gKFDGDNNEEO_ != null)
			{
				if (this.gKFDGDNNEEO_ == null)
				{
					this.GKFDGDNNEEO = new NIPFDPOBDBP();
				}
				this.GKFDGDNNEEO.MergeFrom(other.GKFDGDNNEEO);
			}
			if (other.nKJPMLMNOKA_ != null)
			{
				if (this.nKJPMLMNOKA_ == null)
				{
					this.NKJPMLMNOKA = new FFJPONDPNAL();
				}
				this.NKJPMLMNOKA.MergeFrom(other.NKJPMLMNOKA);
			}
			if (other.dMMJHDEOGNE_ != null)
			{
				if (this.dMMJHDEOGNE_ == null)
				{
					this.DMMJHDEOGNE = new PKGEFMGJONL();
				}
				this.DMMJHDEOGNE.MergeFrom(other.DMMJHDEOGNE);
			}
			if (other.bEDINILDMEB_ != null)
			{
				if (this.bEDINILDMEB_ == null)
				{
					this.BEDINILDMEB = new MNEMPJMPPJE();
				}
				this.BEDINILDMEB.MergeFrom(other.BEDINILDMEB);
			}
			if (other.pUNKLORDSHARETYPEFRIEND_ != null)
			{
				if (this.pUNKLORDSHARETYPEFRIEND_ == null)
				{
					this.PUNKLORDSHARETYPEFRIEND = new BHJINGMAIEB();
				}
				this.PUNKLORDSHARETYPEFRIEND.MergeFrom(other.PUNKLORDSHARETYPEFRIEND);
			}
			if (other.iEFNCDEECOF_ != null)
			{
				if (this.iEFNCDEECOF_ == null)
				{
					this.IEFNCDEECOF = new HEKPBHDOPNP();
				}
				this.IEFNCDEECOF.MergeFrom(other.IEFNCDEECOF);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x001693C8 File Offset: 0x001675C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x001693D4 File Offset: 0x001675D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num <= 26U)
					{
						if (num == 18U)
						{
							if (this.jIDENEADELO_ == null)
							{
								this.JIDENEADELO = new HDGPKBGIHNB();
							}
							input.ReadMessage(this.JIDENEADELO);
							continue;
						}
						if (num == 26U)
						{
							if (this.gKFDGDNNEEO_ == null)
							{
								this.GKFDGDNNEEO = new NIPFDPOBDBP();
							}
							input.ReadMessage(this.GKFDGDNNEEO);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.kAJIKKHPBBA_ == null)
							{
								this.KAJIKKHPBBA = new PMOJPENPNOL();
							}
							input.ReadMessage(this.KAJIKKHPBBA);
							continue;
						}
						if (num == 58U)
						{
							if (this.bEDINILDMEB_ == null)
							{
								this.BEDINILDMEB = new MNEMPJMPPJE();
							}
							input.ReadMessage(this.BEDINILDMEB);
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 80U)
					{
						this.GAJNFOGLJGE = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.nKJPMLMNOKA_ == null)
						{
							this.NKJPMLMNOKA = new FFJPONDPNAL();
						}
						input.ReadMessage(this.NKJPMLMNOKA);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.dMMJHDEOGNE_ == null)
						{
							this.DMMJHDEOGNE = new PKGEFMGJONL();
						}
						input.ReadMessage(this.DMMJHDEOGNE);
						continue;
					}
					if (num == 106U)
					{
						if (this.pUNKLORDSHARETYPEFRIEND_ == null)
						{
							this.PUNKLORDSHARETYPEFRIEND = new BHJINGMAIEB();
						}
						input.ReadMessage(this.PUNKLORDSHARETYPEFRIEND);
						continue;
					}
					if (num == 114U)
					{
						if (this.iEFNCDEECOF_ == null)
						{
							this.IEFNCDEECOF = new HEKPBHDOPNP();
						}
						input.ReadMessage(this.IEFNCDEECOF);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003461 RID: 13409
		private static readonly MessageParser<NFOGHDHIDNH> _parser = new MessageParser<NFOGHDHIDNH>(() => new NFOGHDHIDNH());

		// Token: 0x04003462 RID: 13410
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003463 RID: 13411
		public const int GAJNFOGLJGEFieldNumber = 10;

		// Token: 0x04003464 RID: 13412
		private uint gAJNFOGLJGE_;

		// Token: 0x04003465 RID: 13413
		public const int JIDENEADELOFieldNumber = 2;

		// Token: 0x04003466 RID: 13414
		private HDGPKBGIHNB jIDENEADELO_;

		// Token: 0x04003467 RID: 13415
		public const int KAJIKKHPBBAFieldNumber = 6;

		// Token: 0x04003468 RID: 13416
		private PMOJPENPNOL kAJIKKHPBBA_;

		// Token: 0x04003469 RID: 13417
		public const int GKFDGDNNEEOFieldNumber = 3;

		// Token: 0x0400346A RID: 13418
		private NIPFDPOBDBP gKFDGDNNEEO_;

		// Token: 0x0400346B RID: 13419
		public const int NKJPMLMNOKAFieldNumber = 11;

		// Token: 0x0400346C RID: 13420
		private FFJPONDPNAL nKJPMLMNOKA_;

		// Token: 0x0400346D RID: 13421
		public const int DMMJHDEOGNEFieldNumber = 12;

		// Token: 0x0400346E RID: 13422
		private PKGEFMGJONL dMMJHDEOGNE_;

		// Token: 0x0400346F RID: 13423
		public const int BEDINILDMEBFieldNumber = 7;

		// Token: 0x04003470 RID: 13424
		private MNEMPJMPPJE bEDINILDMEB_;

		// Token: 0x04003471 RID: 13425
		public const int PUNKLORDSHARETYPEFRIENDFieldNumber = 13;

		// Token: 0x04003472 RID: 13426
		private BHJINGMAIEB pUNKLORDSHARETYPEFRIEND_;

		// Token: 0x04003473 RID: 13427
		public const int IEFNCDEECOFFieldNumber = 14;

		// Token: 0x04003474 RID: 13428
		private HEKPBHDOPNP iEFNCDEECOF_;
	}
}

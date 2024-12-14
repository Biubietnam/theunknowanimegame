using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CF7 RID: 3319
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class POPDHFEBLPG : IMessage<POPDHFEBLPG>, IMessage, IEquatable<POPDHFEBLPG>, IDeepCloneable<POPDHFEBLPG>, IBufferMessage
	{
		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x06009440 RID: 37952 RVA: 0x0018A3F3 File Offset: 0x001885F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<POPDHFEBLPG> Parser
		{
			get
			{
				return POPDHFEBLPG._parser;
			}
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x06009441 RID: 37953 RVA: 0x0018A3FA File Offset: 0x001885FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return POPDHFEBLPGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x0018A40C File Offset: 0x0018860C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return POPDHFEBLPG.Descriptor;
			}
		}

		// Token: 0x06009443 RID: 37955 RVA: 0x0018A413 File Offset: 0x00188613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public POPDHFEBLPG()
		{
		}

		// Token: 0x06009444 RID: 37956 RVA: 0x0018A428 File Offset: 0x00188628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public POPDHFEBLPG(POPDHFEBLPG other) : this()
		{
			this.pNFEFBJLNLE_ = other.pNFEFBJLNLE_;
			this.lEKMMLONAGK_ = other.lEKMMLONAGK_.Clone();
			this.aJMHIDFPBGN_ = other.aJMHIDFPBGN_;
			this.bGKKLJMJGOF_ = other.bGKKLJMJGOF_;
			this.lBOBPHAOKPI_ = other.lBOBPHAOKPI_;
			this.lMFBFIJDAAP_ = other.lMFBFIJDAAP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x0018A499 File Offset: 0x00188699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public POPDHFEBLPG Clone()
		{
			return new POPDHFEBLPG(this);
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x06009446 RID: 37958 RVA: 0x0018A4A1 File Offset: 0x001886A1
		// (set) Token: 0x06009447 RID: 37959 RVA: 0x0018A4A9 File Offset: 0x001886A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PNFEFBJLNLE
		{
			get
			{
				return this.pNFEFBJLNLE_;
			}
			set
			{
				this.pNFEFBJLNLE_ = value;
			}
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x06009448 RID: 37960 RVA: 0x0018A4B2 File Offset: 0x001886B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LEKMMLONAGK
		{
			get
			{
				return this.lEKMMLONAGK_;
			}
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x06009449 RID: 37961 RVA: 0x0018A4BA File Offset: 0x001886BA
		// (set) Token: 0x0600944A RID: 37962 RVA: 0x0018A4C2 File Offset: 0x001886C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AJMHIDFPBGN
		{
			get
			{
				return this.aJMHIDFPBGN_;
			}
			set
			{
				this.aJMHIDFPBGN_ = value;
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x0600944B RID: 37963 RVA: 0x0018A4CB File Offset: 0x001886CB
		// (set) Token: 0x0600944C RID: 37964 RVA: 0x0018A4D3 File Offset: 0x001886D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BGKKLJMJGOF
		{
			get
			{
				return this.bGKKLJMJGOF_;
			}
			set
			{
				this.bGKKLJMJGOF_ = value;
			}
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x0600944D RID: 37965 RVA: 0x0018A4DC File Offset: 0x001886DC
		// (set) Token: 0x0600944E RID: 37966 RVA: 0x0018A4E4 File Offset: 0x001886E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LBOBPHAOKPI
		{
			get
			{
				return this.lBOBPHAOKPI_;
			}
			set
			{
				this.lBOBPHAOKPI_ = value;
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x0600944F RID: 37967 RVA: 0x0018A4ED File Offset: 0x001886ED
		// (set) Token: 0x06009450 RID: 37968 RVA: 0x0018A4F5 File Offset: 0x001886F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DNCBHBOCOEG LMFBFIJDAAP
		{
			get
			{
				return this.lMFBFIJDAAP_;
			}
			set
			{
				this.lMFBFIJDAAP_ = value;
			}
		}

		// Token: 0x06009451 RID: 37969 RVA: 0x0018A4FE File Offset: 0x001886FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as POPDHFEBLPG);
		}

		// Token: 0x06009452 RID: 37970 RVA: 0x0018A50C File Offset: 0x0018870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(POPDHFEBLPG other)
		{
			return other != null && (other == this || (this.PNFEFBJLNLE == other.PNFEFBJLNLE && this.lEKMMLONAGK_.Equals(other.lEKMMLONAGK_) && this.AJMHIDFPBGN == other.AJMHIDFPBGN && this.BGKKLJMJGOF == other.BGKKLJMJGOF && this.LBOBPHAOKPI == other.LBOBPHAOKPI && this.LMFBFIJDAAP == other.LMFBFIJDAAP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009453 RID: 37971 RVA: 0x0018A59C File Offset: 0x0018879C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PNFEFBJLNLE != 0U)
			{
				num ^= this.PNFEFBJLNLE.GetHashCode();
			}
			num ^= this.lEKMMLONAGK_.GetHashCode();
			if (this.AJMHIDFPBGN != 0U)
			{
				num ^= this.AJMHIDFPBGN.GetHashCode();
			}
			if (this.BGKKLJMJGOF != 0U)
			{
				num ^= this.BGKKLJMJGOF.GetHashCode();
			}
			if (this.LBOBPHAOKPI != 0U)
			{
				num ^= this.LBOBPHAOKPI.GetHashCode();
			}
			if (this.LMFBFIJDAAP != DNCBHBOCOEG.OfferingStateNone)
			{
				num ^= this.LMFBFIJDAAP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009454 RID: 37972 RVA: 0x0018A653 File Offset: 0x00188853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x0018A65B File Offset: 0x0018885B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x0018A664 File Offset: 0x00188864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lEKMMLONAGK_.WriteTo(ref output, POPDHFEBLPG._repeated_lEKMMLONAGK_codec);
			if (this.PNFEFBJLNLE != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PNFEFBJLNLE);
			}
			if (this.LMFBFIJDAAP != DNCBHBOCOEG.OfferingStateNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.LMFBFIJDAAP);
			}
			if (this.LBOBPHAOKPI != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.LBOBPHAOKPI);
			}
			if (this.BGKKLJMJGOF != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.BGKKLJMJGOF);
			}
			if (this.AJMHIDFPBGN != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AJMHIDFPBGN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x0018A724 File Offset: 0x00188924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PNFEFBJLNLE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PNFEFBJLNLE);
			}
			num += this.lEKMMLONAGK_.CalculateSize(POPDHFEBLPG._repeated_lEKMMLONAGK_codec);
			if (this.AJMHIDFPBGN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AJMHIDFPBGN);
			}
			if (this.BGKKLJMJGOF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BGKKLJMJGOF);
			}
			if (this.LBOBPHAOKPI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LBOBPHAOKPI);
			}
			if (this.LMFBFIJDAAP != DNCBHBOCOEG.OfferingStateNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LMFBFIJDAAP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x0018A7D8 File Offset: 0x001889D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(POPDHFEBLPG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PNFEFBJLNLE != 0U)
			{
				this.PNFEFBJLNLE = other.PNFEFBJLNLE;
			}
			this.lEKMMLONAGK_.Add(other.lEKMMLONAGK_);
			if (other.AJMHIDFPBGN != 0U)
			{
				this.AJMHIDFPBGN = other.AJMHIDFPBGN;
			}
			if (other.BGKKLJMJGOF != 0U)
			{
				this.BGKKLJMJGOF = other.BGKKLJMJGOF;
			}
			if (other.LBOBPHAOKPI != 0U)
			{
				this.LBOBPHAOKPI = other.LBOBPHAOKPI;
			}
			if (other.LMFBFIJDAAP != DNCBHBOCOEG.OfferingStateNone)
			{
				this.LMFBFIJDAAP = other.LMFBFIJDAAP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x0018A875 File Offset: 0x00188A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600945A RID: 37978 RVA: 0x0018A880 File Offset: 0x00188A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.lEKMMLONAGK_.AddEntriesFrom(ref input, POPDHFEBLPG._repeated_lEKMMLONAGK_codec);
						continue;
					}
					if (num == 16U)
					{
						this.PNFEFBJLNLE = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.LMFBFIJDAAP = (DNCBHBOCOEG)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.LBOBPHAOKPI = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.BGKKLJMJGOF = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.AJMHIDFPBGN = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003971 RID: 14705
		private static readonly MessageParser<POPDHFEBLPG> _parser = new MessageParser<POPDHFEBLPG>(() => new POPDHFEBLPG());

		// Token: 0x04003972 RID: 14706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003973 RID: 14707
		public const int PNFEFBJLNLEFieldNumber = 2;

		// Token: 0x04003974 RID: 14708
		private uint pNFEFBJLNLE_;

		// Token: 0x04003975 RID: 14709
		public const int LEKMMLONAGKFieldNumber = 1;

		// Token: 0x04003976 RID: 14710
		private static readonly FieldCodec<uint> _repeated_lEKMMLONAGK_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04003977 RID: 14711
		private readonly RepeatedField<uint> lEKMMLONAGK_ = new RepeatedField<uint>();

		// Token: 0x04003978 RID: 14712
		public const int AJMHIDFPBGNFieldNumber = 11;

		// Token: 0x04003979 RID: 14713
		private uint aJMHIDFPBGN_;

		// Token: 0x0400397A RID: 14714
		public const int BGKKLJMJGOFFieldNumber = 10;

		// Token: 0x0400397B RID: 14715
		private uint bGKKLJMJGOF_;

		// Token: 0x0400397C RID: 14716
		public const int LBOBPHAOKPIFieldNumber = 6;

		// Token: 0x0400397D RID: 14717
		private uint lBOBPHAOKPI_;

		// Token: 0x0400397E RID: 14718
		public const int LMFBFIJDAAPFieldNumber = 5;

		// Token: 0x0400397F RID: 14719
		private DNCBHBOCOEG lMFBFIJDAAP_;
	}
}

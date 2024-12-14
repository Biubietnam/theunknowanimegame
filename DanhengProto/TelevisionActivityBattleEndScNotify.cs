using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001349 RID: 4937
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TelevisionActivityBattleEndScNotify : IMessage<TelevisionActivityBattleEndScNotify>, IMessage, IEquatable<TelevisionActivityBattleEndScNotify>, IDeepCloneable<TelevisionActivityBattleEndScNotify>, IBufferMessage
	{
		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x0600DC52 RID: 56402 RVA: 0x0024AA6F File Offset: 0x00248C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TelevisionActivityBattleEndScNotify> Parser
		{
			get
			{
				return TelevisionActivityBattleEndScNotify._parser;
			}
		}

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x0600DC53 RID: 56403 RVA: 0x0024AA76 File Offset: 0x00248C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TelevisionActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x0600DC54 RID: 56404 RVA: 0x0024AA88 File Offset: 0x00248C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TelevisionActivityBattleEndScNotify.Descriptor;
			}
		}

		// Token: 0x0600DC55 RID: 56405 RVA: 0x0024AA8F File Offset: 0x00248C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityBattleEndScNotify()
		{
		}

		// Token: 0x0600DC56 RID: 56406 RVA: 0x0024AA98 File Offset: 0x00248C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityBattleEndScNotify(TelevisionActivityBattleEndScNotify other) : this()
		{
			this.bBKDCNDIJLN_ = other.bBKDCNDIJLN_;
			this.bFADHPMMODP_ = other.bFADHPMMODP_;
			this.jCBHCEIIPDM_ = ((other.jCBHCEIIPDM_ != null) ? other.jCBHCEIIPDM_.Clone() : null);
			this.lCLBKIADCOK_ = other.lCLBKIADCOK_;
			this.oFCGBCPEFEO_ = other.oFCGBCPEFEO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC57 RID: 56407 RVA: 0x0024AB08 File Offset: 0x00248D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityBattleEndScNotify Clone()
		{
			return new TelevisionActivityBattleEndScNotify(this);
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x0600DC58 RID: 56408 RVA: 0x0024AB10 File Offset: 0x00248D10
		// (set) Token: 0x0600DC59 RID: 56409 RVA: 0x0024AB18 File Offset: 0x00248D18
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

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x0600DC5A RID: 56410 RVA: 0x0024AB21 File Offset: 0x00248D21
		// (set) Token: 0x0600DC5B RID: 56411 RVA: 0x0024AB29 File Offset: 0x00248D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BFADHPMMODP
		{
			get
			{
				return this.bFADHPMMODP_;
			}
			set
			{
				this.bFADHPMMODP_ = value;
			}
		}

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x0600DC5C RID: 56412 RVA: 0x0024AB32 File Offset: 0x00248D32
		// (set) Token: 0x0600DC5D RID: 56413 RVA: 0x0024AB3A File Offset: 0x00248D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityData JCBHCEIIPDM
		{
			get
			{
				return this.jCBHCEIIPDM_;
			}
			set
			{
				this.jCBHCEIIPDM_ = value;
			}
		}

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x0600DC5E RID: 56414 RVA: 0x0024AB43 File Offset: 0x00248D43
		// (set) Token: 0x0600DC5F RID: 56415 RVA: 0x0024AB4B File Offset: 0x00248D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LCLBKIADCOK
		{
			get
			{
				return this.lCLBKIADCOK_;
			}
			set
			{
				this.lCLBKIADCOK_ = value;
			}
		}

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x0600DC60 RID: 56416 RVA: 0x0024AB54 File Offset: 0x00248D54
		// (set) Token: 0x0600DC61 RID: 56417 RVA: 0x0024AB5C File Offset: 0x00248D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OFCGBCPEFEO
		{
			get
			{
				return this.oFCGBCPEFEO_;
			}
			set
			{
				this.oFCGBCPEFEO_ = value;
			}
		}

		// Token: 0x0600DC62 RID: 56418 RVA: 0x0024AB65 File Offset: 0x00248D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TelevisionActivityBattleEndScNotify);
		}

		// Token: 0x0600DC63 RID: 56419 RVA: 0x0024AB74 File Offset: 0x00248D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TelevisionActivityBattleEndScNotify other)
		{
			return other != null && (other == this || (this.BBKDCNDIJLN == other.BBKDCNDIJLN && this.BFADHPMMODP == other.BFADHPMMODP && object.Equals(this.JCBHCEIIPDM, other.JCBHCEIIPDM) && this.LCLBKIADCOK == other.LCLBKIADCOK && this.OFCGBCPEFEO == other.OFCGBCPEFEO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC64 RID: 56420 RVA: 0x0024ABF4 File Offset: 0x00248DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BBKDCNDIJLN != 0U)
			{
				num ^= this.BBKDCNDIJLN.GetHashCode();
			}
			if (this.BFADHPMMODP != 0U)
			{
				num ^= this.BFADHPMMODP.GetHashCode();
			}
			if (this.jCBHCEIIPDM_ != null)
			{
				num ^= this.JCBHCEIIPDM.GetHashCode();
			}
			if (this.LCLBKIADCOK != 0U)
			{
				num ^= this.LCLBKIADCOK.GetHashCode();
			}
			if (this.OFCGBCPEFEO != 0U)
			{
				num ^= this.OFCGBCPEFEO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC65 RID: 56421 RVA: 0x0024AC94 File Offset: 0x00248E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DC66 RID: 56422 RVA: 0x0024AC9C File Offset: 0x00248E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC67 RID: 56423 RVA: 0x0024ACA8 File Offset: 0x00248EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BBKDCNDIJLN != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.BBKDCNDIJLN);
			}
			if (this.jCBHCEIIPDM_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.JCBHCEIIPDM);
			}
			if (this.OFCGBCPEFEO != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.OFCGBCPEFEO);
			}
			if (this.BFADHPMMODP != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BFADHPMMODP);
			}
			if (this.LCLBKIADCOK != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LCLBKIADCOK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC68 RID: 56424 RVA: 0x0024AD58 File Offset: 0x00248F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BBKDCNDIJLN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BBKDCNDIJLN);
			}
			if (this.BFADHPMMODP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BFADHPMMODP);
			}
			if (this.jCBHCEIIPDM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JCBHCEIIPDM);
			}
			if (this.LCLBKIADCOK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LCLBKIADCOK);
			}
			if (this.OFCGBCPEFEO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OFCGBCPEFEO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC69 RID: 56425 RVA: 0x0024ADF8 File Offset: 0x00248FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TelevisionActivityBattleEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BBKDCNDIJLN != 0U)
			{
				this.BBKDCNDIJLN = other.BBKDCNDIJLN;
			}
			if (other.BFADHPMMODP != 0U)
			{
				this.BFADHPMMODP = other.BFADHPMMODP;
			}
			if (other.jCBHCEIIPDM_ != null)
			{
				if (this.jCBHCEIIPDM_ == null)
				{
					this.JCBHCEIIPDM = new TelevisionActivityData();
				}
				this.JCBHCEIIPDM.MergeFrom(other.JCBHCEIIPDM);
			}
			if (other.LCLBKIADCOK != 0U)
			{
				this.LCLBKIADCOK = other.LCLBKIADCOK;
			}
			if (other.OFCGBCPEFEO != 0U)
			{
				this.OFCGBCPEFEO = other.OFCGBCPEFEO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC6A RID: 56426 RVA: 0x0024AE9C File Offset: 0x0024909C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC6B RID: 56427 RVA: 0x0024AEA8 File Offset: 0x002490A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 48U)
					{
						this.BBKDCNDIJLN = input.ReadUInt32();
						continue;
					}
					if (num == 82U)
					{
						if (this.jCBHCEIIPDM_ == null)
						{
							this.JCBHCEIIPDM = new TelevisionActivityData();
						}
						input.ReadMessage(this.JCBHCEIIPDM);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.OFCGBCPEFEO = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.BFADHPMMODP = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.LCLBKIADCOK = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040057A6 RID: 22438
		private static readonly MessageParser<TelevisionActivityBattleEndScNotify> _parser = new MessageParser<TelevisionActivityBattleEndScNotify>(() => new TelevisionActivityBattleEndScNotify());

		// Token: 0x040057A7 RID: 22439
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057A8 RID: 22440
		public const int BBKDCNDIJLNFieldNumber = 6;

		// Token: 0x040057A9 RID: 22441
		private uint bBKDCNDIJLN_;

		// Token: 0x040057AA RID: 22442
		public const int BFADHPMMODPFieldNumber = 13;

		// Token: 0x040057AB RID: 22443
		private uint bFADHPMMODP_;

		// Token: 0x040057AC RID: 22444
		public const int JCBHCEIIPDMFieldNumber = 10;

		// Token: 0x040057AD RID: 22445
		private TelevisionActivityData jCBHCEIIPDM_;

		// Token: 0x040057AE RID: 22446
		public const int LCLBKIADCOKFieldNumber = 15;

		// Token: 0x040057AF RID: 22447
		private uint lCLBKIADCOK_;

		// Token: 0x040057B0 RID: 22448
		public const int OFCGBCPEFEOFieldNumber = 12;

		// Token: 0x040057B1 RID: 22449
		private uint oFCGBCPEFEO_;
	}
}

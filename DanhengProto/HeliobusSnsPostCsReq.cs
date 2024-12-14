using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008CF RID: 2255
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsPostCsReq : IMessage<HeliobusSnsPostCsReq>, IMessage, IEquatable<HeliobusSnsPostCsReq>, IDeepCloneable<HeliobusSnsPostCsReq>, IBufferMessage
	{
		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x0600648B RID: 25739 RVA: 0x0010D219 File Offset: 0x0010B419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsPostCsReq> Parser
		{
			get
			{
				return HeliobusSnsPostCsReq._parser;
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x0600648C RID: 25740 RVA: 0x0010D220 File Offset: 0x0010B420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsPostCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x0600648D RID: 25741 RVA: 0x0010D232 File Offset: 0x0010B432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsPostCsReq.Descriptor;
			}
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x0010D239 File Offset: 0x0010B439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsPostCsReq()
		{
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x0010D241 File Offset: 0x0010B441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsPostCsReq(HeliobusSnsPostCsReq other) : this()
		{
			this.mBFOAGMCOOM_ = other.mBFOAGMCOOM_;
			this.aLAOMAOBNFG_ = other.aLAOMAOBNFG_;
			this.gDLLHHELILE_ = other.gDLLHHELILE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x0010D27E File Offset: 0x0010B47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsPostCsReq Clone()
		{
			return new HeliobusSnsPostCsReq(this);
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06006491 RID: 25745 RVA: 0x0010D286 File Offset: 0x0010B486
		// (set) Token: 0x06006492 RID: 25746 RVA: 0x0010D28E File Offset: 0x0010B48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MBFOAGMCOOM
		{
			get
			{
				return this.mBFOAGMCOOM_;
			}
			set
			{
				this.mBFOAGMCOOM_ = value;
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06006493 RID: 25747 RVA: 0x0010D297 File Offset: 0x0010B497
		// (set) Token: 0x06006494 RID: 25748 RVA: 0x0010D29F File Offset: 0x0010B49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ALAOMAOBNFG
		{
			get
			{
				return this.aLAOMAOBNFG_;
			}
			set
			{
				this.aLAOMAOBNFG_ = value;
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06006495 RID: 25749 RVA: 0x0010D2A8 File Offset: 0x0010B4A8
		// (set) Token: 0x06006496 RID: 25750 RVA: 0x0010D2B0 File Offset: 0x0010B4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GDLLHHELILE
		{
			get
			{
				return this.gDLLHHELILE_;
			}
			set
			{
				this.gDLLHHELILE_ = value;
			}
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x0010D2B9 File Offset: 0x0010B4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsPostCsReq);
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x0010D2C8 File Offset: 0x0010B4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsPostCsReq other)
		{
			return other != null && (other == this || (this.MBFOAGMCOOM == other.MBFOAGMCOOM && this.ALAOMAOBNFG == other.ALAOMAOBNFG && this.GDLLHHELILE == other.GDLLHHELILE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x0010D324 File Offset: 0x0010B524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MBFOAGMCOOM != 0U)
			{
				num ^= this.MBFOAGMCOOM.GetHashCode();
			}
			if (this.ALAOMAOBNFG != 0U)
			{
				num ^= this.ALAOMAOBNFG.GetHashCode();
			}
			if (this.GDLLHHELILE != 0U)
			{
				num ^= this.GDLLHHELILE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x0010D395 File Offset: 0x0010B595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x0010D39D File Offset: 0x0010B59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x0010D3A8 File Offset: 0x0010B5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MBFOAGMCOOM != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MBFOAGMCOOM);
			}
			if (this.GDLLHHELILE != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GDLLHHELILE);
			}
			if (this.ALAOMAOBNFG != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ALAOMAOBNFG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x0010D420 File Offset: 0x0010B620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MBFOAGMCOOM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MBFOAGMCOOM);
			}
			if (this.ALAOMAOBNFG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ALAOMAOBNFG);
			}
			if (this.GDLLHHELILE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GDLLHHELILE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x0010D490 File Offset: 0x0010B690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsPostCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MBFOAGMCOOM != 0U)
			{
				this.MBFOAGMCOOM = other.MBFOAGMCOOM;
			}
			if (other.ALAOMAOBNFG != 0U)
			{
				this.ALAOMAOBNFG = other.ALAOMAOBNFG;
			}
			if (other.GDLLHHELILE != 0U)
			{
				this.GDLLHHELILE = other.GDLLHHELILE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x0010D4F4 File Offset: 0x0010B6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x0010D500 File Offset: 0x0010B700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ALAOMAOBNFG = input.ReadUInt32();
						}
					}
					else
					{
						this.GDLLHHELILE = input.ReadUInt32();
					}
				}
				else
				{
					this.MBFOAGMCOOM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040026B8 RID: 9912
		private static readonly MessageParser<HeliobusSnsPostCsReq> _parser = new MessageParser<HeliobusSnsPostCsReq>(() => new HeliobusSnsPostCsReq());

		// Token: 0x040026B9 RID: 9913
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026BA RID: 9914
		public const int MBFOAGMCOOMFieldNumber = 9;

		// Token: 0x040026BB RID: 9915
		private uint mBFOAGMCOOM_;

		// Token: 0x040026BC RID: 9916
		public const int ALAOMAOBNFGFieldNumber = 15;

		// Token: 0x040026BD RID: 9917
		private uint aLAOMAOBNFG_;

		// Token: 0x040026BE RID: 9918
		public const int GDLLHHELILEFieldNumber = 13;

		// Token: 0x040026BF RID: 9919
		private uint gDLLHHELILE_;
	}
}

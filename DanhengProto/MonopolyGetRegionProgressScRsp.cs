using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B4B RID: 2891
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGetRegionProgressScRsp : IMessage<MonopolyGetRegionProgressScRsp>, IMessage, IEquatable<MonopolyGetRegionProgressScRsp>, IDeepCloneable<MonopolyGetRegionProgressScRsp>, IBufferMessage
	{
		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x00151E61 File Offset: 0x00150061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGetRegionProgressScRsp> Parser
		{
			get
			{
				return MonopolyGetRegionProgressScRsp._parser;
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x06007FF8 RID: 32760 RVA: 0x00151E68 File Offset: 0x00150068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGetRegionProgressScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x06007FF9 RID: 32761 RVA: 0x00151E7A File Offset: 0x0015007A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGetRegionProgressScRsp.Descriptor;
			}
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x00151E81 File Offset: 0x00150081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRegionProgressScRsp()
		{
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x00151E89 File Offset: 0x00150089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRegionProgressScRsp(MonopolyGetRegionProgressScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.kFINEODPDIJ_ = other.kFINEODPDIJ_;
			this.eDKBMNFOOAJ_ = other.eDKBMNFOOAJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x00151EC6 File Offset: 0x001500C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRegionProgressScRsp Clone()
		{
			return new MonopolyGetRegionProgressScRsp(this);
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x06007FFD RID: 32765 RVA: 0x00151ECE File Offset: 0x001500CE
		// (set) Token: 0x06007FFE RID: 32766 RVA: 0x00151ED6 File Offset: 0x001500D6
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

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x06007FFF RID: 32767 RVA: 0x00151EDF File Offset: 0x001500DF
		// (set) Token: 0x06008000 RID: 32768 RVA: 0x00151EE7 File Offset: 0x001500E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KFINEODPDIJ
		{
			get
			{
				return this.kFINEODPDIJ_;
			}
			set
			{
				this.kFINEODPDIJ_ = value;
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x06008001 RID: 32769 RVA: 0x00151EF0 File Offset: 0x001500F0
		// (set) Token: 0x06008002 RID: 32770 RVA: 0x00151EF8 File Offset: 0x001500F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EDKBMNFOOAJ
		{
			get
			{
				return this.eDKBMNFOOAJ_;
			}
			set
			{
				this.eDKBMNFOOAJ_ = value;
			}
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x00151F01 File Offset: 0x00150101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGetRegionProgressScRsp);
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x00151F10 File Offset: 0x00150110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGetRegionProgressScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.KFINEODPDIJ == other.KFINEODPDIJ && this.EDKBMNFOOAJ == other.EDKBMNFOOAJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008005 RID: 32773 RVA: 0x00151F6C File Offset: 0x0015016C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.KFINEODPDIJ != 0U)
			{
				num ^= this.KFINEODPDIJ.GetHashCode();
			}
			if (this.EDKBMNFOOAJ != 0U)
			{
				num ^= this.EDKBMNFOOAJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x00151FDD File Offset: 0x001501DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x00151FE5 File Offset: 0x001501E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x00151FF0 File Offset: 0x001501F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EDKBMNFOOAJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EDKBMNFOOAJ);
			}
			if (this.KFINEODPDIJ != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.KFINEODPDIJ);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x00152064 File Offset: 0x00150264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.KFINEODPDIJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KFINEODPDIJ);
			}
			if (this.EDKBMNFOOAJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EDKBMNFOOAJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x001520D4 File Offset: 0x001502D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGetRegionProgressScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.KFINEODPDIJ != 0U)
			{
				this.KFINEODPDIJ = other.KFINEODPDIJ;
			}
			if (other.EDKBMNFOOAJ != 0U)
			{
				this.EDKBMNFOOAJ = other.EDKBMNFOOAJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x00152138 File Offset: 0x00150338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x00152144 File Offset: 0x00150344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 40U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.KFINEODPDIJ = input.ReadUInt32();
					}
				}
				else
				{
					this.EDKBMNFOOAJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040030F8 RID: 12536
		private static readonly MessageParser<MonopolyGetRegionProgressScRsp> _parser = new MessageParser<MonopolyGetRegionProgressScRsp>(() => new MonopolyGetRegionProgressScRsp());

		// Token: 0x040030F9 RID: 12537
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030FA RID: 12538
		public const int RetcodeFieldNumber = 8;

		// Token: 0x040030FB RID: 12539
		private uint retcode_;

		// Token: 0x040030FC RID: 12540
		public const int KFINEODPDIJFieldNumber = 5;

		// Token: 0x040030FD RID: 12541
		private uint kFINEODPDIJ_;

		// Token: 0x040030FE RID: 12542
		public const int EDKBMNFOOAJFieldNumber = 1;

		// Token: 0x040030FF RID: 12543
		private uint eDKBMNFOOAJ_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B3F RID: 2879
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGetDailyInitItemScRsp : IMessage<MonopolyGetDailyInitItemScRsp>, IMessage, IEquatable<MonopolyGetDailyInitItemScRsp>, IDeepCloneable<MonopolyGetDailyInitItemScRsp>, IBufferMessage
	{
		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x06007F6C RID: 32620 RVA: 0x00150A1F File Offset: 0x0014EC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGetDailyInitItemScRsp> Parser
		{
			get
			{
				return MonopolyGetDailyInitItemScRsp._parser;
			}
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x06007F6D RID: 32621 RVA: 0x00150A26 File Offset: 0x0014EC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGetDailyInitItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x06007F6E RID: 32622 RVA: 0x00150A38 File Offset: 0x0014EC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGetDailyInitItemScRsp.Descriptor;
			}
		}

		// Token: 0x06007F6F RID: 32623 RVA: 0x00150A3F File Offset: 0x0014EC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetDailyInitItemScRsp()
		{
		}

		// Token: 0x06007F70 RID: 32624 RVA: 0x00150A48 File Offset: 0x0014EC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetDailyInitItemScRsp(MonopolyGetDailyInitItemScRsp other) : this()
		{
			this.lBMEIHABLKN_ = other.lBMEIHABLKN_;
			this.fBMLKJJMMFJ_ = other.fBMLKJJMMFJ_;
			this.dBABLKNONJF_ = other.dBABLKNONJF_;
			this.aABJAEIBGGM_ = other.aABJAEIBGGM_;
			this.oBIDNHGHHMH_ = other.oBIDNHGHHMH_;
			this.retcode_ = other.retcode_;
			this.gELALEKMCGH_ = other.gELALEKMCGH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F71 RID: 32625 RVA: 0x00150AC0 File Offset: 0x0014ECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetDailyInitItemScRsp Clone()
		{
			return new MonopolyGetDailyInitItemScRsp(this);
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x06007F72 RID: 32626 RVA: 0x00150AC8 File Offset: 0x0014ECC8
		// (set) Token: 0x06007F73 RID: 32627 RVA: 0x00150AD0 File Offset: 0x0014ECD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LBMEIHABLKN
		{
			get
			{
				return this.lBMEIHABLKN_;
			}
			set
			{
				this.lBMEIHABLKN_ = value;
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x06007F74 RID: 32628 RVA: 0x00150AD9 File Offset: 0x0014ECD9
		// (set) Token: 0x06007F75 RID: 32629 RVA: 0x00150AE1 File Offset: 0x0014ECE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FBMLKJJMMFJ
		{
			get
			{
				return this.fBMLKJJMMFJ_;
			}
			set
			{
				this.fBMLKJJMMFJ_ = value;
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x06007F76 RID: 32630 RVA: 0x00150AEA File Offset: 0x0014ECEA
		// (set) Token: 0x06007F77 RID: 32631 RVA: 0x00150AF2 File Offset: 0x0014ECF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DBABLKNONJF
		{
			get
			{
				return this.dBABLKNONJF_;
			}
			set
			{
				this.dBABLKNONJF_ = value;
			}
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x06007F78 RID: 32632 RVA: 0x00150AFB File Offset: 0x0014ECFB
		// (set) Token: 0x06007F79 RID: 32633 RVA: 0x00150B03 File Offset: 0x0014ED03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AABJAEIBGGM
		{
			get
			{
				return this.aABJAEIBGGM_;
			}
			set
			{
				this.aABJAEIBGGM_ = value;
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x06007F7A RID: 32634 RVA: 0x00150B0C File Offset: 0x0014ED0C
		// (set) Token: 0x06007F7B RID: 32635 RVA: 0x00150B14 File Offset: 0x0014ED14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OBIDNHGHHMH
		{
			get
			{
				return this.oBIDNHGHHMH_;
			}
			set
			{
				this.oBIDNHGHHMH_ = value;
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x06007F7C RID: 32636 RVA: 0x00150B1D File Offset: 0x0014ED1D
		// (set) Token: 0x06007F7D RID: 32637 RVA: 0x00150B25 File Offset: 0x0014ED25
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

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x06007F7E RID: 32638 RVA: 0x00150B2E File Offset: 0x0014ED2E
		// (set) Token: 0x06007F7F RID: 32639 RVA: 0x00150B36 File Offset: 0x0014ED36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GELALEKMCGH
		{
			get
			{
				return this.gELALEKMCGH_;
			}
			set
			{
				this.gELALEKMCGH_ = value;
			}
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x00150B3F File Offset: 0x0014ED3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGetDailyInitItemScRsp);
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x00150B50 File Offset: 0x0014ED50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGetDailyInitItemScRsp other)
		{
			return other != null && (other == this || (this.LBMEIHABLKN == other.LBMEIHABLKN && this.FBMLKJJMMFJ == other.FBMLKJJMMFJ && this.DBABLKNONJF == other.DBABLKNONJF && this.AABJAEIBGGM == other.AABJAEIBGGM && this.OBIDNHGHHMH == other.OBIDNHGHHMH && this.Retcode == other.Retcode && this.GELALEKMCGH == other.GELALEKMCGH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x00150BEC File Offset: 0x0014EDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LBMEIHABLKN != 0U)
			{
				num ^= this.LBMEIHABLKN.GetHashCode();
			}
			if (this.FBMLKJJMMFJ != 0U)
			{
				num ^= this.FBMLKJJMMFJ.GetHashCode();
			}
			if (this.DBABLKNONJF != 0U)
			{
				num ^= this.DBABLKNONJF.GetHashCode();
			}
			if (this.AABJAEIBGGM != 0L)
			{
				num ^= this.AABJAEIBGGM.GetHashCode();
			}
			if (this.OBIDNHGHHMH != 0U)
			{
				num ^= this.OBIDNHGHHMH.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.GELALEKMCGH != 0U)
			{
				num ^= this.GELALEKMCGH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x00150CC1 File Offset: 0x0014EEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x00150CC9 File Offset: 0x0014EEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x00150CD4 File Offset: 0x0014EED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FBMLKJJMMFJ != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FBMLKJJMMFJ);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.OBIDNHGHHMH != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OBIDNHGHHMH);
			}
			if (this.GELALEKMCGH != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GELALEKMCGH);
			}
			if (this.LBMEIHABLKN != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.LBMEIHABLKN);
			}
			if (this.AABJAEIBGGM != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.AABJAEIBGGM);
			}
			if (this.DBABLKNONJF != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.DBABLKNONJF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x00150DBC File Offset: 0x0014EFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LBMEIHABLKN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LBMEIHABLKN);
			}
			if (this.FBMLKJJMMFJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FBMLKJJMMFJ);
			}
			if (this.DBABLKNONJF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DBABLKNONJF);
			}
			if (this.AABJAEIBGGM != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AABJAEIBGGM);
			}
			if (this.OBIDNHGHHMH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OBIDNHGHHMH);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.GELALEKMCGH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GELALEKMCGH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x00150E8C File Offset: 0x0014F08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGetDailyInitItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LBMEIHABLKN != 0U)
			{
				this.LBMEIHABLKN = other.LBMEIHABLKN;
			}
			if (other.FBMLKJJMMFJ != 0U)
			{
				this.FBMLKJJMMFJ = other.FBMLKJJMMFJ;
			}
			if (other.DBABLKNONJF != 0U)
			{
				this.DBABLKNONJF = other.DBABLKNONJF;
			}
			if (other.AABJAEIBGGM != 0L)
			{
				this.AABJAEIBGGM = other.AABJAEIBGGM;
			}
			if (other.OBIDNHGHHMH != 0U)
			{
				this.OBIDNHGHHMH = other.OBIDNHGHHMH;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.GELALEKMCGH != 0U)
			{
				this.GELALEKMCGH = other.GELALEKMCGH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x00150F40 File Offset: 0x0014F140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x00150F4C File Offset: 0x0014F14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.FBMLKJJMMFJ = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.OBIDNHGHHMH = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 64U)
				{
					if (num == 40U)
					{
						this.GELALEKMCGH = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.LBMEIHABLKN = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.AABJAEIBGGM = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.DBABLKNONJF = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040030CB RID: 12491
		private static readonly MessageParser<MonopolyGetDailyInitItemScRsp> _parser = new MessageParser<MonopolyGetDailyInitItemScRsp>(() => new MonopolyGetDailyInitItemScRsp());

		// Token: 0x040030CC RID: 12492
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030CD RID: 12493
		public const int LBMEIHABLKNFieldNumber = 8;

		// Token: 0x040030CE RID: 12494
		private uint lBMEIHABLKN_;

		// Token: 0x040030CF RID: 12495
		public const int FBMLKJJMMFJFieldNumber = 2;

		// Token: 0x040030D0 RID: 12496
		private uint fBMLKJJMMFJ_;

		// Token: 0x040030D1 RID: 12497
		public const int DBABLKNONJFFieldNumber = 15;

		// Token: 0x040030D2 RID: 12498
		private uint dBABLKNONJF_;

		// Token: 0x040030D3 RID: 12499
		public const int AABJAEIBGGMFieldNumber = 14;

		// Token: 0x040030D4 RID: 12500
		private long aABJAEIBGGM_;

		// Token: 0x040030D5 RID: 12501
		public const int OBIDNHGHHMHFieldNumber = 4;

		// Token: 0x040030D6 RID: 12502
		private uint oBIDNHGHHMH_;

		// Token: 0x040030D7 RID: 12503
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040030D8 RID: 12504
		private uint retcode_;

		// Token: 0x040030D9 RID: 12505
		public const int GELALEKMCGHFieldNumber = 5;

		// Token: 0x040030DA RID: 12506
		private uint gELALEKMCGH_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CF1 RID: 3313
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PMPGCOMJKMM : IMessage<PMPGCOMJKMM>, IMessage, IEquatable<PMPGCOMJKMM>, IDeepCloneable<PMPGCOMJKMM>, IBufferMessage
	{
		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x060093F0 RID: 37872 RVA: 0x001894CB File Offset: 0x001876CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PMPGCOMJKMM> Parser
		{
			get
			{
				return PMPGCOMJKMM._parser;
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x060093F1 RID: 37873 RVA: 0x001894D2 File Offset: 0x001876D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PMPGCOMJKMMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x060093F2 RID: 37874 RVA: 0x001894E4 File Offset: 0x001876E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PMPGCOMJKMM.Descriptor;
			}
		}

		// Token: 0x060093F3 RID: 37875 RVA: 0x001894EB File Offset: 0x001876EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMPGCOMJKMM()
		{
		}

		// Token: 0x060093F4 RID: 37876 RVA: 0x001894F4 File Offset: 0x001876F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMPGCOMJKMM(PMPGCOMJKMM other) : this()
		{
			this.gEBIEMEFINN_ = other.gEBIEMEFINN_;
			this.iANMNDOBEOF_ = other.iANMNDOBEOF_;
			this.cOHAKBPNCDG_ = other.cOHAKBPNCDG_;
			this.itemId_ = other.itemId_;
			this.uniqueId_ = other.uniqueId_;
			this.mIBHBOCHMCH_ = other.mIBHBOCHMCH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093F5 RID: 37877 RVA: 0x00189560 File Offset: 0x00187760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMPGCOMJKMM Clone()
		{
			return new PMPGCOMJKMM(this);
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x060093F6 RID: 37878 RVA: 0x00189568 File Offset: 0x00187768
		// (set) Token: 0x060093F7 RID: 37879 RVA: 0x00189570 File Offset: 0x00187770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GEBIEMEFINN
		{
			get
			{
				return this.gEBIEMEFINN_;
			}
			set
			{
				this.gEBIEMEFINN_ = value;
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x060093F8 RID: 37880 RVA: 0x00189579 File Offset: 0x00187779
		// (set) Token: 0x060093F9 RID: 37881 RVA: 0x00189581 File Offset: 0x00187781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IANMNDOBEOF
		{
			get
			{
				return this.iANMNDOBEOF_;
			}
			set
			{
				this.iANMNDOBEOF_ = value;
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x060093FA RID: 37882 RVA: 0x0018958A File Offset: 0x0018778A
		// (set) Token: 0x060093FB RID: 37883 RVA: 0x00189592 File Offset: 0x00187792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COHAKBPNCDG
		{
			get
			{
				return this.cOHAKBPNCDG_;
			}
			set
			{
				this.cOHAKBPNCDG_ = value;
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x060093FC RID: 37884 RVA: 0x0018959B File Offset: 0x0018779B
		// (set) Token: 0x060093FD RID: 37885 RVA: 0x001895A3 File Offset: 0x001877A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x060093FE RID: 37886 RVA: 0x001895AC File Offset: 0x001877AC
		// (set) Token: 0x060093FF RID: 37887 RVA: 0x001895B4 File Offset: 0x001877B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x06009400 RID: 37888 RVA: 0x001895BD File Offset: 0x001877BD
		// (set) Token: 0x06009401 RID: 37889 RVA: 0x001895C5 File Offset: 0x001877C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MIBHBOCHMCH
		{
			get
			{
				return this.mIBHBOCHMCH_;
			}
			set
			{
				this.mIBHBOCHMCH_ = value;
			}
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x001895CE File Offset: 0x001877CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PMPGCOMJKMM);
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x001895DC File Offset: 0x001877DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PMPGCOMJKMM other)
		{
			return other != null && (other == this || (this.GEBIEMEFINN == other.GEBIEMEFINN && this.IANMNDOBEOF == other.IANMNDOBEOF && this.COHAKBPNCDG == other.COHAKBPNCDG && this.ItemId == other.ItemId && this.UniqueId == other.UniqueId && this.MIBHBOCHMCH == other.MIBHBOCHMCH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x00189668 File Offset: 0x00187868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GEBIEMEFINN != 0)
			{
				num ^= this.GEBIEMEFINN.GetHashCode();
			}
			if (this.IANMNDOBEOF != 0)
			{
				num ^= this.IANMNDOBEOF.GetHashCode();
			}
			if (this.COHAKBPNCDG != 0U)
			{
				num ^= this.COHAKBPNCDG.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.UniqueId != 0UL)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				num ^= this.MIBHBOCHMCH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x00189724 File Offset: 0x00187924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x0018972C File Offset: 0x0018792C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x00189738 File Offset: 0x00187938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MIBHBOCHMCH != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MIBHBOCHMCH);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ItemId);
			}
			if (this.GEBIEMEFINN != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GEBIEMEFINN);
			}
			if (this.UniqueId != 0UL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.UniqueId);
			}
			if (this.COHAKBPNCDG != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.COHAKBPNCDG);
			}
			if (this.IANMNDOBEOF != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IANMNDOBEOF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x00189800 File Offset: 0x00187A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GEBIEMEFINN != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GEBIEMEFINN);
			}
			if (this.IANMNDOBEOF != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IANMNDOBEOF);
			}
			if (this.COHAKBPNCDG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COHAKBPNCDG);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.UniqueId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MIBHBOCHMCH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x001898B8 File Offset: 0x00187AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PMPGCOMJKMM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GEBIEMEFINN != 0)
			{
				this.GEBIEMEFINN = other.GEBIEMEFINN;
			}
			if (other.IANMNDOBEOF != 0)
			{
				this.IANMNDOBEOF = other.IANMNDOBEOF;
			}
			if (other.COHAKBPNCDG != 0U)
			{
				this.COHAKBPNCDG = other.COHAKBPNCDG;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.UniqueId != 0UL)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.MIBHBOCHMCH != 0U)
			{
				this.MIBHBOCHMCH = other.MIBHBOCHMCH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x00189958 File Offset: 0x00187B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x00189964 File Offset: 0x00187B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.MIBHBOCHMCH = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ItemId = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.GEBIEMEFINN = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.UniqueId = input.ReadUInt64();
						continue;
					}
					if (num == 96U)
					{
						this.COHAKBPNCDG = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IANMNDOBEOF = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400394B RID: 14667
		private static readonly MessageParser<PMPGCOMJKMM> _parser = new MessageParser<PMPGCOMJKMM>(() => new PMPGCOMJKMM());

		// Token: 0x0400394C RID: 14668
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400394D RID: 14669
		public const int GEBIEMEFINNFieldNumber = 5;

		// Token: 0x0400394E RID: 14670
		private int gEBIEMEFINN_;

		// Token: 0x0400394F RID: 14671
		public const int IANMNDOBEOFFieldNumber = 14;

		// Token: 0x04003950 RID: 14672
		private int iANMNDOBEOF_;

		// Token: 0x04003951 RID: 14673
		public const int COHAKBPNCDGFieldNumber = 12;

		// Token: 0x04003952 RID: 14674
		private uint cOHAKBPNCDG_;

		// Token: 0x04003953 RID: 14675
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04003954 RID: 14676
		private uint itemId_;

		// Token: 0x04003955 RID: 14677
		public const int UniqueIdFieldNumber = 11;

		// Token: 0x04003956 RID: 14678
		private ulong uniqueId_;

		// Token: 0x04003957 RID: 14679
		public const int MIBHBOCHMCHFieldNumber = 1;

		// Token: 0x04003958 RID: 14680
		private uint mIBHBOCHMCH_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200138F RID: 5007
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureUpdatePasterPosCsReq : IMessage<TravelBrochureUpdatePasterPosCsReq>, IMessage, IEquatable<TravelBrochureUpdatePasterPosCsReq>, IDeepCloneable<TravelBrochureUpdatePasterPosCsReq>, IBufferMessage
	{
		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x0600DF5A RID: 57178 RVA: 0x002522C3 File Offset: 0x002504C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureUpdatePasterPosCsReq> Parser
		{
			get
			{
				return TravelBrochureUpdatePasterPosCsReq._parser;
			}
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x0600DF5B RID: 57179 RVA: 0x002522CA File Offset: 0x002504CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureUpdatePasterPosCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x0600DF5C RID: 57180 RVA: 0x002522DC File Offset: 0x002504DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureUpdatePasterPosCsReq.Descriptor;
			}
		}

		// Token: 0x0600DF5D RID: 57181 RVA: 0x002522E3 File Offset: 0x002504E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureUpdatePasterPosCsReq()
		{
		}

		// Token: 0x0600DF5E RID: 57182 RVA: 0x002522EC File Offset: 0x002504EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureUpdatePasterPosCsReq(TravelBrochureUpdatePasterPosCsReq other) : this()
		{
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this.uniqueId_ = other.uniqueId_;
			this.itemId_ = other.itemId_;
			this.iANMNDOBEOF_ = other.iANMNDOBEOF_;
			this.gEBIEMEFINN_ = other.gEBIEMEFINN_;
			this.cOHAKBPNCDG_ = other.cOHAKBPNCDG_;
			this.mIBHBOCHMCH_ = other.mIBHBOCHMCH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF5F RID: 57183 RVA: 0x00252364 File Offset: 0x00250564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureUpdatePasterPosCsReq Clone()
		{
			return new TravelBrochureUpdatePasterPosCsReq(this);
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x0600DF60 RID: 57184 RVA: 0x0025236C File Offset: 0x0025056C
		// (set) Token: 0x0600DF61 RID: 57185 RVA: 0x00252374 File Offset: 0x00250574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NMAKNJMFFJN
		{
			get
			{
				return this.nMAKNJMFFJN_;
			}
			set
			{
				this.nMAKNJMFFJN_ = value;
			}
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x0600DF62 RID: 57186 RVA: 0x0025237D File Offset: 0x0025057D
		// (set) Token: 0x0600DF63 RID: 57187 RVA: 0x00252385 File Offset: 0x00250585
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

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x0600DF64 RID: 57188 RVA: 0x0025238E File Offset: 0x0025058E
		// (set) Token: 0x0600DF65 RID: 57189 RVA: 0x00252396 File Offset: 0x00250596
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

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x0600DF66 RID: 57190 RVA: 0x0025239F File Offset: 0x0025059F
		// (set) Token: 0x0600DF67 RID: 57191 RVA: 0x002523A7 File Offset: 0x002505A7
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

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x0600DF68 RID: 57192 RVA: 0x002523B0 File Offset: 0x002505B0
		// (set) Token: 0x0600DF69 RID: 57193 RVA: 0x002523B8 File Offset: 0x002505B8
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

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x0600DF6A RID: 57194 RVA: 0x002523C1 File Offset: 0x002505C1
		// (set) Token: 0x0600DF6B RID: 57195 RVA: 0x002523C9 File Offset: 0x002505C9
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

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x0600DF6C RID: 57196 RVA: 0x002523D2 File Offset: 0x002505D2
		// (set) Token: 0x0600DF6D RID: 57197 RVA: 0x002523DA File Offset: 0x002505DA
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

		// Token: 0x0600DF6E RID: 57198 RVA: 0x002523E3 File Offset: 0x002505E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureUpdatePasterPosCsReq);
		}

		// Token: 0x0600DF6F RID: 57199 RVA: 0x002523F4 File Offset: 0x002505F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureUpdatePasterPosCsReq other)
		{
			return other != null && (other == this || (this.NMAKNJMFFJN == other.NMAKNJMFFJN && this.UniqueId == other.UniqueId && this.ItemId == other.ItemId && this.IANMNDOBEOF == other.IANMNDOBEOF && this.GEBIEMEFINN == other.GEBIEMEFINN && this.COHAKBPNCDG == other.COHAKBPNCDG && this.MIBHBOCHMCH == other.MIBHBOCHMCH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF70 RID: 57200 RVA: 0x00252490 File Offset: 0x00250690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NMAKNJMFFJN != 0U)
			{
				num ^= this.NMAKNJMFFJN.GetHashCode();
			}
			if (this.UniqueId != 0UL)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IANMNDOBEOF != 0)
			{
				num ^= this.IANMNDOBEOF.GetHashCode();
			}
			if (this.GEBIEMEFINN != 0)
			{
				num ^= this.GEBIEMEFINN.GetHashCode();
			}
			if (this.COHAKBPNCDG != 0U)
			{
				num ^= this.COHAKBPNCDG.GetHashCode();
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

		// Token: 0x0600DF71 RID: 57201 RVA: 0x00252565 File Offset: 0x00250765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DF72 RID: 57202 RVA: 0x0025256D File Offset: 0x0025076D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF73 RID: 57203 RVA: 0x00252578 File Offset: 0x00250778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ItemId);
			}
			if (this.IANMNDOBEOF != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IANMNDOBEOF);
			}
			if (this.COHAKBPNCDG != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.COHAKBPNCDG);
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MIBHBOCHMCH);
			}
			if (this.GEBIEMEFINN != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GEBIEMEFINN);
			}
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			if (this.UniqueId != 0UL)
			{
				output.WriteRawTag(120);
				output.WriteUInt64(this.UniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF74 RID: 57204 RVA: 0x0025265C File Offset: 0x0025085C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NMAKNJMFFJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMAKNJMFFJN);
			}
			if (this.UniqueId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.IANMNDOBEOF != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IANMNDOBEOF);
			}
			if (this.GEBIEMEFINN != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GEBIEMEFINN);
			}
			if (this.COHAKBPNCDG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COHAKBPNCDG);
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

		// Token: 0x0600DF75 RID: 57205 RVA: 0x0025272C File Offset: 0x0025092C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureUpdatePasterPosCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			if (other.UniqueId != 0UL)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IANMNDOBEOF != 0)
			{
				this.IANMNDOBEOF = other.IANMNDOBEOF;
			}
			if (other.GEBIEMEFINN != 0)
			{
				this.GEBIEMEFINN = other.GEBIEMEFINN;
			}
			if (other.COHAKBPNCDG != 0U)
			{
				this.COHAKBPNCDG = other.COHAKBPNCDG;
			}
			if (other.MIBHBOCHMCH != 0U)
			{
				this.MIBHBOCHMCH = other.MIBHBOCHMCH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF76 RID: 57206 RVA: 0x002527E0 File Offset: 0x002509E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF77 RID: 57207 RVA: 0x002527EC File Offset: 0x002509EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.ItemId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IANMNDOBEOF = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.COHAKBPNCDG = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.MIBHBOCHMCH = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.GEBIEMEFINN = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.NMAKNJMFFJN = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.UniqueId = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040058B8 RID: 22712
		private static readonly MessageParser<TravelBrochureUpdatePasterPosCsReq> _parser = new MessageParser<TravelBrochureUpdatePasterPosCsReq>(() => new TravelBrochureUpdatePasterPosCsReq());

		// Token: 0x040058B9 RID: 22713
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058BA RID: 22714
		public const int NMAKNJMFFJNFieldNumber = 13;

		// Token: 0x040058BB RID: 22715
		private uint nMAKNJMFFJN_;

		// Token: 0x040058BC RID: 22716
		public const int UniqueIdFieldNumber = 15;

		// Token: 0x040058BD RID: 22717
		private ulong uniqueId_;

		// Token: 0x040058BE RID: 22718
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040058BF RID: 22719
		private uint itemId_;

		// Token: 0x040058C0 RID: 22720
		public const int IANMNDOBEOFFieldNumber = 2;

		// Token: 0x040058C1 RID: 22721
		private int iANMNDOBEOF_;

		// Token: 0x040058C2 RID: 22722
		public const int GEBIEMEFINNFieldNumber = 11;

		// Token: 0x040058C3 RID: 22723
		private int gEBIEMEFINN_;

		// Token: 0x040058C4 RID: 22724
		public const int COHAKBPNCDGFieldNumber = 8;

		// Token: 0x040058C5 RID: 22725
		private uint cOHAKBPNCDG_;

		// Token: 0x040058C6 RID: 22726
		public const int MIBHBOCHMCHFieldNumber = 9;

		// Token: 0x040058C7 RID: 22727
		private uint mIBHBOCHMCH_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200136B RID: 4971
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureApplyPasterCsReq : IMessage<TravelBrochureApplyPasterCsReq>, IMessage, IEquatable<TravelBrochureApplyPasterCsReq>, IDeepCloneable<TravelBrochureApplyPasterCsReq>, IBufferMessage
	{
		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x0600DDBD RID: 56765 RVA: 0x0024E517 File Offset: 0x0024C717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureApplyPasterCsReq> Parser
		{
			get
			{
				return TravelBrochureApplyPasterCsReq._parser;
			}
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x0600DDBE RID: 56766 RVA: 0x0024E51E File Offset: 0x0024C71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureApplyPasterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x0600DDBF RID: 56767 RVA: 0x0024E530 File Offset: 0x0024C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureApplyPasterCsReq.Descriptor;
			}
		}

		// Token: 0x0600DDC0 RID: 56768 RVA: 0x0024E537 File Offset: 0x0024C737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterCsReq()
		{
		}

		// Token: 0x0600DDC1 RID: 56769 RVA: 0x0024E540 File Offset: 0x0024C740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterCsReq(TravelBrochureApplyPasterCsReq other) : this()
		{
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this.gEBIEMEFINN_ = other.gEBIEMEFINN_;
			this.itemId_ = other.itemId_;
			this.mIBHBOCHMCH_ = other.mIBHBOCHMCH_;
			this.cOHAKBPNCDG_ = other.cOHAKBPNCDG_;
			this.iANMNDOBEOF_ = other.iANMNDOBEOF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDC2 RID: 56770 RVA: 0x0024E5AC File Offset: 0x0024C7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterCsReq Clone()
		{
			return new TravelBrochureApplyPasterCsReq(this);
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x0600DDC3 RID: 56771 RVA: 0x0024E5B4 File Offset: 0x0024C7B4
		// (set) Token: 0x0600DDC4 RID: 56772 RVA: 0x0024E5BC File Offset: 0x0024C7BC
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

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x0600DDC5 RID: 56773 RVA: 0x0024E5C5 File Offset: 0x0024C7C5
		// (set) Token: 0x0600DDC6 RID: 56774 RVA: 0x0024E5CD File Offset: 0x0024C7CD
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

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x0600DDC7 RID: 56775 RVA: 0x0024E5D6 File Offset: 0x0024C7D6
		// (set) Token: 0x0600DDC8 RID: 56776 RVA: 0x0024E5DE File Offset: 0x0024C7DE
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

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0600DDC9 RID: 56777 RVA: 0x0024E5E7 File Offset: 0x0024C7E7
		// (set) Token: 0x0600DDCA RID: 56778 RVA: 0x0024E5EF File Offset: 0x0024C7EF
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

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0600DDCB RID: 56779 RVA: 0x0024E5F8 File Offset: 0x0024C7F8
		// (set) Token: 0x0600DDCC RID: 56780 RVA: 0x0024E600 File Offset: 0x0024C800
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

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0600DDCD RID: 56781 RVA: 0x0024E609 File Offset: 0x0024C809
		// (set) Token: 0x0600DDCE RID: 56782 RVA: 0x0024E611 File Offset: 0x0024C811
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

		// Token: 0x0600DDCF RID: 56783 RVA: 0x0024E61A File Offset: 0x0024C81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureApplyPasterCsReq);
		}

		// Token: 0x0600DDD0 RID: 56784 RVA: 0x0024E628 File Offset: 0x0024C828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureApplyPasterCsReq other)
		{
			return other != null && (other == this || (this.NMAKNJMFFJN == other.NMAKNJMFFJN && this.GEBIEMEFINN == other.GEBIEMEFINN && this.ItemId == other.ItemId && this.MIBHBOCHMCH == other.MIBHBOCHMCH && this.COHAKBPNCDG == other.COHAKBPNCDG && this.IANMNDOBEOF == other.IANMNDOBEOF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDD1 RID: 56785 RVA: 0x0024E6B4 File Offset: 0x0024C8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NMAKNJMFFJN != 0U)
			{
				num ^= this.NMAKNJMFFJN.GetHashCode();
			}
			if (this.GEBIEMEFINN != 0)
			{
				num ^= this.GEBIEMEFINN.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				num ^= this.MIBHBOCHMCH.GetHashCode();
			}
			if (this.COHAKBPNCDG != 0U)
			{
				num ^= this.COHAKBPNCDG.GetHashCode();
			}
			if (this.IANMNDOBEOF != 0)
			{
				num ^= this.IANMNDOBEOF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DDD2 RID: 56786 RVA: 0x0024E770 File Offset: 0x0024C970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DDD3 RID: 56787 RVA: 0x0024E778 File Offset: 0x0024C978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDD4 RID: 56788 RVA: 0x0024E784 File Offset: 0x0024C984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.COHAKBPNCDG != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.COHAKBPNCDG);
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MIBHBOCHMCH);
			}
			if (this.GEBIEMEFINN != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.GEBIEMEFINN);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ItemId);
			}
			if (this.IANMNDOBEOF != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IANMNDOBEOF);
			}
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DDD5 RID: 56789 RVA: 0x0024E850 File Offset: 0x0024CA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NMAKNJMFFJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMAKNJMFFJN);
			}
			if (this.GEBIEMEFINN != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GEBIEMEFINN);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MIBHBOCHMCH);
			}
			if (this.COHAKBPNCDG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COHAKBPNCDG);
			}
			if (this.IANMNDOBEOF != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IANMNDOBEOF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DDD6 RID: 56790 RVA: 0x0024E908 File Offset: 0x0024CB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureApplyPasterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			if (other.GEBIEMEFINN != 0)
			{
				this.GEBIEMEFINN = other.GEBIEMEFINN;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.MIBHBOCHMCH != 0U)
			{
				this.MIBHBOCHMCH = other.MIBHBOCHMCH;
			}
			if (other.COHAKBPNCDG != 0U)
			{
				this.COHAKBPNCDG = other.COHAKBPNCDG;
			}
			if (other.IANMNDOBEOF != 0)
			{
				this.IANMNDOBEOF = other.IANMNDOBEOF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DDD7 RID: 56791 RVA: 0x0024E9A8 File Offset: 0x0024CBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDD8 RID: 56792 RVA: 0x0024E9B4 File Offset: 0x0024CBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 48U)
					{
						this.COHAKBPNCDG = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.MIBHBOCHMCH = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.GEBIEMEFINN = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ItemId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.IANMNDOBEOF = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.NMAKNJMFFJN = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005835 RID: 22581
		private static readonly MessageParser<TravelBrochureApplyPasterCsReq> _parser = new MessageParser<TravelBrochureApplyPasterCsReq>(() => new TravelBrochureApplyPasterCsReq());

		// Token: 0x04005836 RID: 22582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005837 RID: 22583
		public const int NMAKNJMFFJNFieldNumber = 14;

		// Token: 0x04005838 RID: 22584
		private uint nMAKNJMFFJN_;

		// Token: 0x04005839 RID: 22585
		public const int GEBIEMEFINNFieldNumber = 10;

		// Token: 0x0400583A RID: 22586
		private int gEBIEMEFINN_;

		// Token: 0x0400583B RID: 22587
		public const int ItemIdFieldNumber = 11;

		// Token: 0x0400583C RID: 22588
		private uint itemId_;

		// Token: 0x0400583D RID: 22589
		public const int MIBHBOCHMCHFieldNumber = 7;

		// Token: 0x0400583E RID: 22590
		private uint mIBHBOCHMCH_;

		// Token: 0x0400583F RID: 22591
		public const int COHAKBPNCDGFieldNumber = 6;

		// Token: 0x04005840 RID: 22592
		private uint cOHAKBPNCDG_;

		// Token: 0x04005841 RID: 22593
		public const int IANMNDOBEOFFieldNumber = 13;

		// Token: 0x04005842 RID: 22594
		private int iANMNDOBEOF_;
	}
}

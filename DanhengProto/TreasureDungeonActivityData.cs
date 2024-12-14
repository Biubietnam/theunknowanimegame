using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001393 RID: 5011
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureDungeonActivityData : IMessage<TreasureDungeonActivityData>, IMessage, IEquatable<TreasureDungeonActivityData>, IDeepCloneable<TreasureDungeonActivityData>, IBufferMessage
	{
		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x0600DF92 RID: 57234 RVA: 0x00252D47 File Offset: 0x00250F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureDungeonActivityData> Parser
		{
			get
			{
				return TreasureDungeonActivityData._parser;
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x0600DF93 RID: 57235 RVA: 0x00252D4E File Offset: 0x00250F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TreasureDungeonActivityDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x0600DF94 RID: 57236 RVA: 0x00252D60 File Offset: 0x00250F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureDungeonActivityData.Descriptor;
			}
		}

		// Token: 0x0600DF95 RID: 57237 RVA: 0x00252D67 File Offset: 0x00250F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonActivityData()
		{
		}

		// Token: 0x0600DF96 RID: 57238 RVA: 0x00252D70 File Offset: 0x00250F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonActivityData(TreasureDungeonActivityData other) : this()
		{
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this.aCLJKNHDFFL_ = other.aCLJKNHDFFL_;
			this.oJJLBIPFMAP_ = other.oJJLBIPFMAP_;
			this.isFinished_ = other.isFinished_;
			this.dHLPHKJBMHB_ = other.dHLPHKJBMHB_;
			this.aFKFMBNFCGE_ = other.aFKFMBNFCGE_;
			this.cNIJGAPOPAH_ = other.cNIJGAPOPAH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF97 RID: 57239 RVA: 0x00252DE8 File Offset: 0x00250FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonActivityData Clone()
		{
			return new TreasureDungeonActivityData(this);
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x0600DF98 RID: 57240 RVA: 0x00252DF0 File Offset: 0x00250FF0
		// (set) Token: 0x0600DF99 RID: 57241 RVA: 0x00252DF8 File Offset: 0x00250FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCFAJPAMBGD
		{
			get
			{
				return this.nCFAJPAMBGD_;
			}
			set
			{
				this.nCFAJPAMBGD_ = value;
			}
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x0600DF9A RID: 57242 RVA: 0x00252E01 File Offset: 0x00251001
		// (set) Token: 0x0600DF9B RID: 57243 RVA: 0x00252E09 File Offset: 0x00251009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ACLJKNHDFFL
		{
			get
			{
				return this.aCLJKNHDFFL_;
			}
			set
			{
				this.aCLJKNHDFFL_ = value;
			}
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x0600DF9C RID: 57244 RVA: 0x00252E12 File Offset: 0x00251012
		// (set) Token: 0x0600DF9D RID: 57245 RVA: 0x00252E1A File Offset: 0x0025101A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OJJLBIPFMAP
		{
			get
			{
				return this.oJJLBIPFMAP_;
			}
			set
			{
				this.oJJLBIPFMAP_ = value;
			}
		}

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x0600DF9E RID: 57246 RVA: 0x00252E23 File Offset: 0x00251023
		// (set) Token: 0x0600DF9F RID: 57247 RVA: 0x00252E2B File Offset: 0x0025102B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x0600DFA0 RID: 57248 RVA: 0x00252E34 File Offset: 0x00251034
		// (set) Token: 0x0600DFA1 RID: 57249 RVA: 0x00252E3C File Offset: 0x0025103C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DHLPHKJBMHB
		{
			get
			{
				return this.dHLPHKJBMHB_;
			}
			set
			{
				this.dHLPHKJBMHB_ = value;
			}
		}

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x00252E45 File Offset: 0x00251045
		// (set) Token: 0x0600DFA3 RID: 57251 RVA: 0x00252E4D File Offset: 0x0025104D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AFKFMBNFCGE
		{
			get
			{
				return this.aFKFMBNFCGE_;
			}
			set
			{
				this.aFKFMBNFCGE_ = value;
			}
		}

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x0600DFA4 RID: 57252 RVA: 0x00252E56 File Offset: 0x00251056
		// (set) Token: 0x0600DFA5 RID: 57253 RVA: 0x00252E5E File Offset: 0x0025105E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CNIJGAPOPAH
		{
			get
			{
				return this.cNIJGAPOPAH_;
			}
			set
			{
				this.cNIJGAPOPAH_ = value;
			}
		}

		// Token: 0x0600DFA6 RID: 57254 RVA: 0x00252E67 File Offset: 0x00251067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureDungeonActivityData);
		}

		// Token: 0x0600DFA7 RID: 57255 RVA: 0x00252E78 File Offset: 0x00251078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureDungeonActivityData other)
		{
			return other != null && (other == this || (this.NCFAJPAMBGD == other.NCFAJPAMBGD && this.ACLJKNHDFFL == other.ACLJKNHDFFL && this.OJJLBIPFMAP == other.OJJLBIPFMAP && this.IsFinished == other.IsFinished && this.DHLPHKJBMHB == other.DHLPHKJBMHB && this.AFKFMBNFCGE == other.AFKFMBNFCGE && this.CNIJGAPOPAH == other.CNIJGAPOPAH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFA8 RID: 57256 RVA: 0x00252F14 File Offset: 0x00251114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			if (this.ACLJKNHDFFL != 0U)
			{
				num ^= this.ACLJKNHDFFL.GetHashCode();
			}
			if (this.OJJLBIPFMAP != 0U)
			{
				num ^= this.OJJLBIPFMAP.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this.DHLPHKJBMHB != 0U)
			{
				num ^= this.DHLPHKJBMHB.GetHashCode();
			}
			if (this.AFKFMBNFCGE)
			{
				num ^= this.AFKFMBNFCGE.GetHashCode();
			}
			if (this.CNIJGAPOPAH != 0U)
			{
				num ^= this.CNIJGAPOPAH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFA9 RID: 57257 RVA: 0x00252FE9 File Offset: 0x002511E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DFAA RID: 57258 RVA: 0x00252FF1 File Offset: 0x002511F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFAB RID: 57259 RVA: 0x00252FFC File Offset: 0x002511FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFinished)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinished);
			}
			if (this.CNIJGAPOPAH != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CNIJGAPOPAH);
			}
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			if (this.OJJLBIPFMAP != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.OJJLBIPFMAP);
			}
			if (this.DHLPHKJBMHB != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DHLPHKJBMHB);
			}
			if (this.ACLJKNHDFFL != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ACLJKNHDFFL);
			}
			if (this.AFKFMBNFCGE)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.AFKFMBNFCGE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFAC RID: 57260 RVA: 0x002530E4 File Offset: 0x002512E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			if (this.ACLJKNHDFFL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ACLJKNHDFFL);
			}
			if (this.OJJLBIPFMAP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OJJLBIPFMAP);
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this.DHLPHKJBMHB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DHLPHKJBMHB);
			}
			if (this.AFKFMBNFCGE)
			{
				num += 2;
			}
			if (this.CNIJGAPOPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CNIJGAPOPAH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFAD RID: 57261 RVA: 0x0025319C File Offset: 0x0025139C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureDungeonActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			if (other.ACLJKNHDFFL != 0U)
			{
				this.ACLJKNHDFFL = other.ACLJKNHDFFL;
			}
			if (other.OJJLBIPFMAP != 0U)
			{
				this.OJJLBIPFMAP = other.OJJLBIPFMAP;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			if (other.DHLPHKJBMHB != 0U)
			{
				this.DHLPHKJBMHB = other.DHLPHKJBMHB;
			}
			if (other.AFKFMBNFCGE)
			{
				this.AFKFMBNFCGE = other.AFKFMBNFCGE;
			}
			if (other.CNIJGAPOPAH != 0U)
			{
				this.CNIJGAPOPAH = other.CNIJGAPOPAH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFAE RID: 57262 RVA: 0x00253250 File Offset: 0x00251450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFAF RID: 57263 RVA: 0x0025325C File Offset: 0x0025145C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.IsFinished = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.CNIJGAPOPAH = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.NCFAJPAMBGD = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.OJJLBIPFMAP = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.DHLPHKJBMHB = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ACLJKNHDFFL = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.AFKFMBNFCGE = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040058D0 RID: 22736
		private static readonly MessageParser<TreasureDungeonActivityData> _parser = new MessageParser<TreasureDungeonActivityData>(() => new TreasureDungeonActivityData());

		// Token: 0x040058D1 RID: 22737
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058D2 RID: 22738
		public const int NCFAJPAMBGDFieldNumber = 6;

		// Token: 0x040058D3 RID: 22739
		private uint nCFAJPAMBGD_;

		// Token: 0x040058D4 RID: 22740
		public const int ACLJKNHDFFLFieldNumber = 11;

		// Token: 0x040058D5 RID: 22741
		private uint aCLJKNHDFFL_;

		// Token: 0x040058D6 RID: 22742
		public const int OJJLBIPFMAPFieldNumber = 8;

		// Token: 0x040058D7 RID: 22743
		private uint oJJLBIPFMAP_;

		// Token: 0x040058D8 RID: 22744
		public const int IsFinishedFieldNumber = 3;

		// Token: 0x040058D9 RID: 22745
		private bool isFinished_;

		// Token: 0x040058DA RID: 22746
		public const int DHLPHKJBMHBFieldNumber = 9;

		// Token: 0x040058DB RID: 22747
		private uint dHLPHKJBMHB_;

		// Token: 0x040058DC RID: 22748
		public const int AFKFMBNFCGEFieldNumber = 15;

		// Token: 0x040058DD RID: 22749
		private bool aFKFMBNFCGE_;

		// Token: 0x040058DE RID: 22750
		public const int CNIJGAPOPAHFieldNumber = 4;

		// Token: 0x040058DF RID: 22751
		private uint cNIJGAPOPAH_;
	}
}

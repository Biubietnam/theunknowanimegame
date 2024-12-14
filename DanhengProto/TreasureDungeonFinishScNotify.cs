using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001399 RID: 5017
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureDungeonFinishScNotify : IMessage<TreasureDungeonFinishScNotify>, IMessage, IEquatable<TreasureDungeonFinishScNotify>, IDeepCloneable<TreasureDungeonFinishScNotify>, IBufferMessage
	{
		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x0600DFDF RID: 57311 RVA: 0x00253A3B File Offset: 0x00251C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureDungeonFinishScNotify> Parser
		{
			get
			{
				return TreasureDungeonFinishScNotify._parser;
			}
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x0600DFE0 RID: 57312 RVA: 0x00253A42 File Offset: 0x00251C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TreasureDungeonFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x0600DFE1 RID: 57313 RVA: 0x00253A54 File Offset: 0x00251C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureDungeonFinishScNotify.Descriptor;
			}
		}

		// Token: 0x0600DFE2 RID: 57314 RVA: 0x00253A5B File Offset: 0x00251C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonFinishScNotify()
		{
		}

		// Token: 0x0600DFE3 RID: 57315 RVA: 0x00253A7C File Offset: 0x00251C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonFinishScNotify(TreasureDungeonFinishScNotify other) : this()
		{
			this.cNIJGAPOPAH_ = other.cNIJGAPOPAH_;
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this.eLKCGNGPPPJ_ = other.eLKCGNGPPPJ_;
			this.isWin_ = other.isWin_;
			this.jKACIGKBFAM_ = other.jKACIGKBFAM_;
			this.lKLJFGGPKHG_ = other.lKLJFGGPKHG_.Clone();
			this.oHKLMIEMNKN_ = other.oHKLMIEMNKN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x00253AFE File Offset: 0x00251CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonFinishScNotify Clone()
		{
			return new TreasureDungeonFinishScNotify(this);
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x0600DFE5 RID: 57317 RVA: 0x00253B06 File Offset: 0x00251D06
		// (set) Token: 0x0600DFE6 RID: 57318 RVA: 0x00253B0E File Offset: 0x00251D0E
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

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x0600DFE7 RID: 57319 RVA: 0x00253B17 File Offset: 0x00251D17
		// (set) Token: 0x0600DFE8 RID: 57320 RVA: 0x00253B1F File Offset: 0x00251D1F
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

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x0600DFE9 RID: 57321 RVA: 0x00253B28 File Offset: 0x00251D28
		// (set) Token: 0x0600DFEA RID: 57322 RVA: 0x00253B30 File Offset: 0x00251D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ELKCGNGPPPJ
		{
			get
			{
				return this.eLKCGNGPPPJ_;
			}
			set
			{
				this.eLKCGNGPPPJ_ = value;
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x0600DFEB RID: 57323 RVA: 0x00253B39 File Offset: 0x00251D39
		// (set) Token: 0x0600DFEC RID: 57324 RVA: 0x00253B41 File Offset: 0x00251D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x0600DFED RID: 57325 RVA: 0x00253B4A File Offset: 0x00251D4A
		// (set) Token: 0x0600DFEE RID: 57326 RVA: 0x00253B52 File Offset: 0x00251D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JKACIGKBFAM
		{
			get
			{
				return this.jKACIGKBFAM_;
			}
			set
			{
				this.jKACIGKBFAM_ = value;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x0600DFEF RID: 57327 RVA: 0x00253B5B File Offset: 0x00251D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> LKLJFGGPKHG
		{
			get
			{
				return this.lKLJFGGPKHG_;
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x0600DFF0 RID: 57328 RVA: 0x00253B63 File Offset: 0x00251D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> OHKLMIEMNKN
		{
			get
			{
				return this.oHKLMIEMNKN_;
			}
		}

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x00253B6B File Offset: 0x00251D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureDungeonFinishScNotify);
		}

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x00253B7C File Offset: 0x00251D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureDungeonFinishScNotify other)
		{
			return other != null && (other == this || (this.CNIJGAPOPAH == other.CNIJGAPOPAH && this.NCFAJPAMBGD == other.NCFAJPAMBGD && this.ELKCGNGPPPJ == other.ELKCGNGPPPJ && this.IsWin == other.IsWin && this.JKACIGKBFAM == other.JKACIGKBFAM && this.LKLJFGGPKHG.Equals(other.LKLJFGGPKHG) && this.OHKLMIEMNKN.Equals(other.OHKLMIEMNKN) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFF3 RID: 57331 RVA: 0x00253C20 File Offset: 0x00251E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CNIJGAPOPAH != 0U)
			{
				num ^= this.CNIJGAPOPAH.GetHashCode();
			}
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			if (this.ELKCGNGPPPJ != 0U)
			{
				num ^= this.ELKCGNGPPPJ.GetHashCode();
			}
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.JKACIGKBFAM != 0U)
			{
				num ^= this.JKACIGKBFAM.GetHashCode();
			}
			num ^= this.LKLJFGGPKHG.GetHashCode();
			num ^= this.OHKLMIEMNKN.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFF4 RID: 57332 RVA: 0x00253CDF File Offset: 0x00251EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x00253CE7 File Offset: 0x00251EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x00253CF0 File Offset: 0x00251EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			if (this.CNIJGAPOPAH != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CNIJGAPOPAH);
			}
			this.oHKLMIEMNKN_.WriteTo(ref output, TreasureDungeonFinishScNotify._map_oHKLMIEMNKN_codec);
			if (this.IsWin)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsWin);
			}
			if (this.ELKCGNGPPPJ != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ELKCGNGPPPJ);
			}
			this.lKLJFGGPKHG_.WriteTo(ref output, TreasureDungeonFinishScNotify._map_lKLJFGGPKHG_codec);
			if (this.JKACIGKBFAM != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.JKACIGKBFAM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFF7 RID: 57335 RVA: 0x00253DC0 File Offset: 0x00251FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CNIJGAPOPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CNIJGAPOPAH);
			}
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			if (this.ELKCGNGPPPJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ELKCGNGPPPJ);
			}
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.JKACIGKBFAM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKACIGKBFAM);
			}
			num += this.lKLJFGGPKHG_.CalculateSize(TreasureDungeonFinishScNotify._map_lKLJFGGPKHG_codec);
			num += this.oHKLMIEMNKN_.CalculateSize(TreasureDungeonFinishScNotify._map_oHKLMIEMNKN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFF8 RID: 57336 RVA: 0x00253E78 File Offset: 0x00252078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureDungeonFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CNIJGAPOPAH != 0U)
			{
				this.CNIJGAPOPAH = other.CNIJGAPOPAH;
			}
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			if (other.ELKCGNGPPPJ != 0U)
			{
				this.ELKCGNGPPPJ = other.ELKCGNGPPPJ;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.JKACIGKBFAM != 0U)
			{
				this.JKACIGKBFAM = other.JKACIGKBFAM;
			}
			this.lKLJFGGPKHG_.MergeFrom(other.lKLJFGGPKHG_);
			this.oHKLMIEMNKN_.MergeFrom(other.oHKLMIEMNKN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFF9 RID: 57337 RVA: 0x00253F26 File Offset: 0x00252126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFFA RID: 57338 RVA: 0x00253F30 File Offset: 0x00252130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 16U)
					{
						this.NCFAJPAMBGD = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.CNIJGAPOPAH = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.oHKLMIEMNKN_.AddEntriesFrom(ref input, TreasureDungeonFinishScNotify._map_oHKLMIEMNKN_codec);
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 56U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.ELKCGNGPPPJ = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.lKLJFGGPKHG_.AddEntriesFrom(ref input, TreasureDungeonFinishScNotify._map_lKLJFGGPKHG_codec);
						continue;
					}
					if (num == 120U)
					{
						this.JKACIGKBFAM = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040058ED RID: 22765
		private static readonly MessageParser<TreasureDungeonFinishScNotify> _parser = new MessageParser<TreasureDungeonFinishScNotify>(() => new TreasureDungeonFinishScNotify());

		// Token: 0x040058EE RID: 22766
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058EF RID: 22767
		public const int CNIJGAPOPAHFieldNumber = 3;

		// Token: 0x040058F0 RID: 22768
		private uint cNIJGAPOPAH_;

		// Token: 0x040058F1 RID: 22769
		public const int NCFAJPAMBGDFieldNumber = 2;

		// Token: 0x040058F2 RID: 22770
		private uint nCFAJPAMBGD_;

		// Token: 0x040058F3 RID: 22771
		public const int ELKCGNGPPPJFieldNumber = 10;

		// Token: 0x040058F4 RID: 22772
		private uint eLKCGNGPPPJ_;

		// Token: 0x040058F5 RID: 22773
		public const int IsWinFieldNumber = 7;

		// Token: 0x040058F6 RID: 22774
		private bool isWin_;

		// Token: 0x040058F7 RID: 22775
		public const int JKACIGKBFAMFieldNumber = 15;

		// Token: 0x040058F8 RID: 22776
		private uint jKACIGKBFAM_;

		// Token: 0x040058F9 RID: 22777
		public const int LKLJFGGPKHGFieldNumber = 12;

		// Token: 0x040058FA RID: 22778
		private static readonly MapField<uint, uint>.Codec _map_lKLJFGGPKHG_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 98U);

		// Token: 0x040058FB RID: 22779
		private readonly MapField<uint, uint> lKLJFGGPKHG_ = new MapField<uint, uint>();

		// Token: 0x040058FC RID: 22780
		public const int OHKLMIEMNKNFieldNumber = 4;

		// Token: 0x040058FD RID: 22781
		private static readonly MapField<uint, uint>.Codec _map_oHKLMIEMNKN_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 34U);

		// Token: 0x040058FE RID: 22782
		private readonly MapField<uint, uint> oHKLMIEMNKN_ = new MapField<uint, uint>();
	}
}

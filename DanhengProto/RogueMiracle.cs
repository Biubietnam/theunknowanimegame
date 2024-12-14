using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F3D RID: 3901
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMiracle : IMessage<RogueMiracle>, IMessage, IEquatable<RogueMiracle>, IDeepCloneable<RogueMiracle>, IBufferMessage
	{
		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0600AE11 RID: 44561 RVA: 0x001D4270 File Offset: 0x001D2470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMiracle> Parser
		{
			get
			{
				return RogueMiracle._parser;
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0600AE12 RID: 44562 RVA: 0x001D4277 File Offset: 0x001D2477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMiracleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x001D4289 File Offset: 0x001D2489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMiracle.Descriptor;
			}
		}

		// Token: 0x0600AE14 RID: 44564 RVA: 0x001D4290 File Offset: 0x001D2490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracle()
		{
		}

		// Token: 0x0600AE15 RID: 44565 RVA: 0x001D42A4 File Offset: 0x001D24A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracle(RogueMiracle other) : this()
		{
			this.maxTimes_ = other.maxTimes_;
			this.miracleId_ = other.miracleId_;
			this.curTimes_ = other.curTimes_;
			this.oEOIJBHAINB_ = other.oEOIJBHAINB_.Clone();
			this.durability_ = other.durability_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x001D4309 File Offset: 0x001D2509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracle Clone()
		{
			return new RogueMiracle(this);
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0600AE17 RID: 44567 RVA: 0x001D4311 File Offset: 0x001D2511
		// (set) Token: 0x0600AE18 RID: 44568 RVA: 0x001D4319 File Offset: 0x001D2519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0600AE19 RID: 44569 RVA: 0x001D4322 File Offset: 0x001D2522
		// (set) Token: 0x0600AE1A RID: 44570 RVA: 0x001D432A File Offset: 0x001D252A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleId
		{
			get
			{
				return this.miracleId_;
			}
			set
			{
				this.miracleId_ = value;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0600AE1B RID: 44571 RVA: 0x001D4333 File Offset: 0x001D2533
		// (set) Token: 0x0600AE1C RID: 44572 RVA: 0x001D433B File Offset: 0x001D253B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurTimes
		{
			get
			{
				return this.curTimes_;
			}
			set
			{
				this.curTimes_ = value;
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600AE1D RID: 44573 RVA: 0x001D4344 File Offset: 0x001D2544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> OEOIJBHAINB
		{
			get
			{
				return this.oEOIJBHAINB_;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600AE1E RID: 44574 RVA: 0x001D434C File Offset: 0x001D254C
		// (set) Token: 0x0600AE1F RID: 44575 RVA: 0x001D4354 File Offset: 0x001D2554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Durability
		{
			get
			{
				return this.durability_;
			}
			set
			{
				this.durability_ = value;
			}
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x001D435D File Offset: 0x001D255D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMiracle);
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x001D436C File Offset: 0x001D256C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMiracle other)
		{
			return other != null && (other == this || (this.MaxTimes == other.MaxTimes && this.MiracleId == other.MiracleId && this.CurTimes == other.CurTimes && this.OEOIJBHAINB.Equals(other.OEOIJBHAINB) && this.Durability == other.Durability && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x001D43EC File Offset: 0x001D25EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
			}
			if (this.MiracleId != 0U)
			{
				num ^= this.MiracleId.GetHashCode();
			}
			if (this.CurTimes != 0U)
			{
				num ^= this.CurTimes.GetHashCode();
			}
			num ^= this.OEOIJBHAINB.GetHashCode();
			if (this.Durability != 0U)
			{
				num ^= this.Durability.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE23 RID: 44579 RVA: 0x001D4484 File Offset: 0x001D2684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE24 RID: 44580 RVA: 0x001D448C File Offset: 0x001D268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE25 RID: 44581 RVA: 0x001D4498 File Offset: 0x001D2698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurTimes != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CurTimes);
			}
			if (this.MiracleId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MiracleId);
			}
			if (this.Durability != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Durability);
			}
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MaxTimes);
			}
			this.oEOIJBHAINB_.WriteTo(ref output, RogueMiracle._map_oEOIJBHAINB_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE26 RID: 44582 RVA: 0x001D453C File Offset: 0x001D273C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
			}
			if (this.MiracleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleId);
			}
			if (this.CurTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurTimes);
			}
			num += this.oEOIJBHAINB_.CalculateSize(RogueMiracle._map_oEOIJBHAINB_codec);
			if (this.Durability != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Durability);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE27 RID: 44583 RVA: 0x001D45D8 File Offset: 0x001D27D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMiracle other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			if (other.MiracleId != 0U)
			{
				this.MiracleId = other.MiracleId;
			}
			if (other.CurTimes != 0U)
			{
				this.CurTimes = other.CurTimes;
			}
			this.oEOIJBHAINB_.MergeFrom(other.oEOIJBHAINB_);
			if (other.Durability != 0U)
			{
				this.Durability = other.Durability;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE28 RID: 44584 RVA: 0x001D4661 File Offset: 0x001D2861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE29 RID: 44585 RVA: 0x001D466C File Offset: 0x001D286C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.CurTimes = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.MiracleId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Durability = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.MaxTimes = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.oEOIJBHAINB_.AddEntriesFrom(ref input, RogueMiracle._map_oEOIJBHAINB_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046DD RID: 18141
		private static readonly MessageParser<RogueMiracle> _parser = new MessageParser<RogueMiracle>(() => new RogueMiracle());

		// Token: 0x040046DE RID: 18142
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046DF RID: 18143
		public const int MaxTimesFieldNumber = 13;

		// Token: 0x040046E0 RID: 18144
		private uint maxTimes_;

		// Token: 0x040046E1 RID: 18145
		public const int MiracleIdFieldNumber = 6;

		// Token: 0x040046E2 RID: 18146
		private uint miracleId_;

		// Token: 0x040046E3 RID: 18147
		public const int CurTimesFieldNumber = 4;

		// Token: 0x040046E4 RID: 18148
		private uint curTimes_;

		// Token: 0x040046E5 RID: 18149
		public const int OEOIJBHAINBFieldNumber = 14;

		// Token: 0x040046E6 RID: 18150
		private static readonly MapField<uint, uint>.Codec _map_oEOIJBHAINB_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 114U);

		// Token: 0x040046E7 RID: 18151
		private readonly MapField<uint, uint> oEOIJBHAINB_ = new MapField<uint, uint>();

		// Token: 0x040046E8 RID: 18152
		public const int DurabilityFieldNumber = 7;

		// Token: 0x040046E9 RID: 18153
		private uint durability_;
	}
}

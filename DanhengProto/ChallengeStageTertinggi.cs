using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B7 RID: 439
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeStageTertinggi : IMessage<ChallengeStageTertinggi>, IMessage, IEquatable<ChallengeStageTertinggi>, IDeepCloneable<ChallengeStageTertinggi>, IBufferMessage
	{
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x000390DF File Offset: 0x000372DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeStageTertinggi> Parser
		{
			get
			{
				return ChallengeStageTertinggi._parser;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x000390E6 File Offset: 0x000372E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeStageTertinggiReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x000390F8 File Offset: 0x000372F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeStageTertinggi.Descriptor;
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x000390FF File Offset: 0x000372FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageTertinggi()
		{
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00039114 File Offset: 0x00037314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageTertinggi(ChallengeStageTertinggi other) : this()
		{
			this.pPMKDMINBNH_ = other.pPMKDMINBNH_;
			this.lineupList_ = other.lineupList_.Clone();
			this.level_ = other.level_;
			this.roundCount_ = other.roundCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0003916D File Offset: 0x0003736D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageTertinggi Clone()
		{
			return new ChallengeStageTertinggi(this);
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00039175 File Offset: 0x00037375
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0003917D File Offset: 0x0003737D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PPMKDMINBNH
		{
			get
			{
				return this.pPMKDMINBNH_;
			}
			set
			{
				this.pPMKDMINBNH_ = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00039186 File Offset: 0x00037386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeLineupList> LineupList
		{
			get
			{
				return this.lineupList_;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0003918E File Offset: 0x0003738E
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x00039196 File Offset: 0x00037396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0003919F File Offset: 0x0003739F
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x000391A7 File Offset: 0x000373A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoundCount
		{
			get
			{
				return this.roundCount_;
			}
			set
			{
				this.roundCount_ = value;
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x000391B0 File Offset: 0x000373B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeStageTertinggi);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x000391C0 File Offset: 0x000373C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeStageTertinggi other)
		{
			return other != null && (other == this || (this.PPMKDMINBNH == other.PPMKDMINBNH && this.lineupList_.Equals(other.lineupList_) && this.Level == other.Level && this.RoundCount == other.RoundCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00039230 File Offset: 0x00037430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PPMKDMINBNH != 0U)
			{
				num ^= this.PPMKDMINBNH.GetHashCode();
			}
			num ^= this.lineupList_.GetHashCode();
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.RoundCount != 0U)
			{
				num ^= this.RoundCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x000392AF File Offset: 0x000374AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x000392B7 File Offset: 0x000374B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000392C0 File Offset: 0x000374C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Level);
			}
			this.lineupList_.WriteTo(ref output, ChallengeStageTertinggi._repeated_lineupList_codec);
			if (this.RoundCount != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.RoundCount);
			}
			if (this.PPMKDMINBNH != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.PPMKDMINBNH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00039348 File Offset: 0x00037548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PPMKDMINBNH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPMKDMINBNH);
			}
			num += this.lineupList_.CalculateSize(ChallengeStageTertinggi._repeated_lineupList_codec);
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.RoundCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoundCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x000393CC File Offset: 0x000375CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeStageTertinggi other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PPMKDMINBNH != 0U)
			{
				this.PPMKDMINBNH = other.PPMKDMINBNH;
			}
			this.lineupList_.Add(other.lineupList_);
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.RoundCount != 0U)
			{
				this.RoundCount = other.RoundCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00039441 File Offset: 0x00037641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0003944C File Offset: 0x0003764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 90U)
				{
					if (num == 56U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						this.lineupList_.AddEntriesFrom(ref input, ChallengeStageTertinggi._repeated_lineupList_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.RoundCount = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.PPMKDMINBNH = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000852 RID: 2130
		private static readonly MessageParser<ChallengeStageTertinggi> _parser = new MessageParser<ChallengeStageTertinggi>(() => new ChallengeStageTertinggi());

		// Token: 0x04000853 RID: 2131
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000854 RID: 2132
		public const int PPMKDMINBNHFieldNumber = 14;

		// Token: 0x04000855 RID: 2133
		private uint pPMKDMINBNH_;

		// Token: 0x04000856 RID: 2134
		public const int LineupListFieldNumber = 11;

		// Token: 0x04000857 RID: 2135
		private static readonly FieldCodec<ChallengeLineupList> _repeated_lineupList_codec = FieldCodec.ForMessage<ChallengeLineupList>(90U, ChallengeLineupList.Parser);

		// Token: 0x04000858 RID: 2136
		private readonly RepeatedField<ChallengeLineupList> lineupList_ = new RepeatedField<ChallengeLineupList>();

		// Token: 0x04000859 RID: 2137
		public const int LevelFieldNumber = 7;

		// Token: 0x0400085A RID: 2138
		private uint level_;

		// Token: 0x0400085B RID: 2139
		public const int RoundCountFieldNumber = 12;

		// Token: 0x0400085C RID: 2140
		private uint roundCount_;
	}
}

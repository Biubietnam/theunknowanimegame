using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A1 RID: 417
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossStageTertinggi : IMessage<ChallengeBossStageTertinggi>, IMessage, IEquatable<ChallengeBossStageTertinggi>, IDeepCloneable<ChallengeBossStageTertinggi>, IBufferMessage
	{
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00036473 File Offset: 0x00034673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossStageTertinggi> Parser
		{
			get
			{
				return ChallengeBossStageTertinggi._parser;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x0003647A File Offset: 0x0003467A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossStageTertinggiReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x0003648C File Offset: 0x0003468C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossStageTertinggi.Descriptor;
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00036493 File Offset: 0x00034693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStageTertinggi()
		{
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000364A8 File Offset: 0x000346A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStageTertinggi(ChallengeBossStageTertinggi other) : this()
		{
			this.buffTwo_ = other.buffTwo_;
			this.scoreId_ = other.scoreId_;
			this.lineupList_ = other.lineupList_.Clone();
			this.buffOne_ = other.buffOne_;
			this.level_ = other.level_;
			this.pPMKDMINBNH_ = other.pPMKDMINBNH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00036519 File Offset: 0x00034719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStageTertinggi Clone()
		{
			return new ChallengeBossStageTertinggi(this);
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00036521 File Offset: 0x00034721
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00036529 File Offset: 0x00034729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffTwo
		{
			get
			{
				return this.buffTwo_;
			}
			set
			{
				this.buffTwo_ = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00036532 File Offset: 0x00034732
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0003653A File Offset: 0x0003473A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00036543 File Offset: 0x00034743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeLineupList> LineupList
		{
			get
			{
				return this.lineupList_;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x0003654B File Offset: 0x0003474B
		// (set) Token: 0x060012CB RID: 4811 RVA: 0x00036553 File Offset: 0x00034753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffOne
		{
			get
			{
				return this.buffOne_;
			}
			set
			{
				this.buffOne_ = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x0003655C File Offset: 0x0003475C
		// (set) Token: 0x060012CD RID: 4813 RVA: 0x00036564 File Offset: 0x00034764
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x0003656D File Offset: 0x0003476D
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x00036575 File Offset: 0x00034775
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

		// Token: 0x060012D0 RID: 4816 RVA: 0x0003657E File Offset: 0x0003477E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossStageTertinggi);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0003658C File Offset: 0x0003478C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossStageTertinggi other)
		{
			return other != null && (other == this || (this.BuffTwo == other.BuffTwo && this.ScoreId == other.ScoreId && this.lineupList_.Equals(other.lineupList_) && this.BuffOne == other.BuffOne && this.Level == other.Level && this.PPMKDMINBNH == other.PPMKDMINBNH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0003661C File Offset: 0x0003481C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffTwo != 0U)
			{
				num ^= this.BuffTwo.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			num ^= this.lineupList_.GetHashCode();
			if (this.BuffOne != 0U)
			{
				num ^= this.BuffOne.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.PPMKDMINBNH != 0U)
			{
				num ^= this.PPMKDMINBNH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000366CD File Offset: 0x000348CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000366D5 File Offset: 0x000348D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000366E0 File Offset: 0x000348E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffTwo != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BuffTwo);
			}
			this.lineupList_.WriteTo(ref output, ChallengeBossStageTertinggi._repeated_lineupList_codec);
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			if (this.BuffOne != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BuffOne);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.PPMKDMINBNH != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.PPMKDMINBNH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000367A0 File Offset: 0x000349A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffTwo);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			num += this.lineupList_.CalculateSize(ChallengeBossStageTertinggi._repeated_lineupList_codec);
			if (this.BuffOne != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffOne);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.PPMKDMINBNH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPMKDMINBNH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00036854 File Offset: 0x00034A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossStageTertinggi other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffTwo != 0U)
			{
				this.BuffTwo = other.BuffTwo;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			this.lineupList_.Add(other.lineupList_);
			if (other.BuffOne != 0U)
			{
				this.BuffOne = other.BuffOne;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.PPMKDMINBNH != 0U)
			{
				this.PPMKDMINBNH = other.PPMKDMINBNH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000368F1 File Offset: 0x00034AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000368FC File Offset: 0x00034AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 24U)
					{
						this.BuffTwo = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.lineupList_.AddEntriesFrom(ref input, ChallengeBossStageTertinggi._repeated_lineupList_codec);
						continue;
					}
					if (num == 80U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.BuffOne = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.PPMKDMINBNH = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040007F0 RID: 2032
		private static readonly MessageParser<ChallengeBossStageTertinggi> _parser = new MessageParser<ChallengeBossStageTertinggi>(() => new ChallengeBossStageTertinggi());

		// Token: 0x040007F1 RID: 2033
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007F2 RID: 2034
		public const int BuffTwoFieldNumber = 3;

		// Token: 0x040007F3 RID: 2035
		private uint buffTwo_;

		// Token: 0x040007F4 RID: 2036
		public const int ScoreIdFieldNumber = 12;

		// Token: 0x040007F5 RID: 2037
		private uint scoreId_;

		// Token: 0x040007F6 RID: 2038
		public const int LineupListFieldNumber = 4;

		// Token: 0x040007F7 RID: 2039
		private static readonly FieldCodec<ChallengeLineupList> _repeated_lineupList_codec = FieldCodec.ForMessage<ChallengeLineupList>(34U, ChallengeLineupList.Parser);

		// Token: 0x040007F8 RID: 2040
		private readonly RepeatedField<ChallengeLineupList> lineupList_ = new RepeatedField<ChallengeLineupList>();

		// Token: 0x040007F9 RID: 2041
		public const int BuffOneFieldNumber = 11;

		// Token: 0x040007FA RID: 2042
		private uint buffOne_;

		// Token: 0x040007FB RID: 2043
		public const int LevelFieldNumber = 10;

		// Token: 0x040007FC RID: 2044
		private uint level_;

		// Token: 0x040007FD RID: 2045
		public const int PPMKDMINBNHFieldNumber = 15;

		// Token: 0x040007FE RID: 2046
		private uint pPMKDMINBNH_;
	}
}

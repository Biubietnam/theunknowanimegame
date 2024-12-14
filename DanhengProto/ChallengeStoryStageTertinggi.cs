using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C3 RID: 451
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeStoryStageTertinggi : IMessage<ChallengeStoryStageTertinggi>, IMessage, IEquatable<ChallengeStoryStageTertinggi>, IDeepCloneable<ChallengeStoryStageTertinggi>, IBufferMessage
	{
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0003A373 File Offset: 0x00038573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeStoryStageTertinggi> Parser
		{
			get
			{
				return ChallengeStoryStageTertinggi._parser;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0003A37A File Offset: 0x0003857A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryStageTertinggiReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0003A38C File Offset: 0x0003858C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeStoryStageTertinggi.Descriptor;
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0003A393 File Offset: 0x00038593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStageTertinggi()
		{
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0003A3A8 File Offset: 0x000385A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStageTertinggi(ChallengeStoryStageTertinggi other) : this()
		{
			this.lineupList_ = other.lineupList_.Clone();
			this.pPMKDMINBNH_ = other.pPMKDMINBNH_;
			this.scoreId_ = other.scoreId_;
			this.buffTwo_ = other.buffTwo_;
			this.buffOne_ = other.buffOne_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0003A419 File Offset: 0x00038619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStageTertinggi Clone()
		{
			return new ChallengeStoryStageTertinggi(this);
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0003A421 File Offset: 0x00038621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeLineupList> LineupList
		{
			get
			{
				return this.lineupList_;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0003A429 File Offset: 0x00038629
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x0003A431 File Offset: 0x00038631
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

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0003A43A File Offset: 0x0003863A
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x0003A442 File Offset: 0x00038642
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

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0003A44B File Offset: 0x0003864B
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x0003A453 File Offset: 0x00038653
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0003A45C File Offset: 0x0003865C
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0003A464 File Offset: 0x00038664
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0003A46D File Offset: 0x0003866D
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0003A475 File Offset: 0x00038675
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

		// Token: 0x06001451 RID: 5201 RVA: 0x0003A47E File Offset: 0x0003867E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeStoryStageTertinggi);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0003A48C File Offset: 0x0003868C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeStoryStageTertinggi other)
		{
			return other != null && (other == this || (this.lineupList_.Equals(other.lineupList_) && this.PPMKDMINBNH == other.PPMKDMINBNH && this.ScoreId == other.ScoreId && this.BuffTwo == other.BuffTwo && this.BuffOne == other.BuffOne && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0003A51C File Offset: 0x0003871C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lineupList_.GetHashCode();
			if (this.PPMKDMINBNH != 0U)
			{
				num ^= this.PPMKDMINBNH.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.BuffTwo != 0U)
			{
				num ^= this.BuffTwo.GetHashCode();
			}
			if (this.BuffOne != 0U)
			{
				num ^= this.BuffOne.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0003A5CD File Offset: 0x000387CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0003A5D5 File Offset: 0x000387D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0003A5E0 File Offset: 0x000387E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffOne != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BuffOne);
			}
			this.lineupList_.WriteTo(ref output, ChallengeStoryStageTertinggi._repeated_lineupList_codec);
			if (this.PPMKDMINBNH != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.PPMKDMINBNH);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.BuffTwo != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BuffTwo);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0003A6A0 File Offset: 0x000388A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lineupList_.CalculateSize(ChallengeStoryStageTertinggi._repeated_lineupList_codec);
			if (this.PPMKDMINBNH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPMKDMINBNH);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.BuffTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffTwo);
			}
			if (this.BuffOne != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffOne);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0003A754 File Offset: 0x00038954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeStoryStageTertinggi other)
		{
			if (other == null)
			{
				return;
			}
			this.lineupList_.Add(other.lineupList_);
			if (other.PPMKDMINBNH != 0U)
			{
				this.PPMKDMINBNH = other.PPMKDMINBNH;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.BuffTwo != 0U)
			{
				this.BuffTwo = other.BuffTwo;
			}
			if (other.BuffOne != 0U)
			{
				this.BuffOne = other.BuffOne;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0003A7F1 File Offset: 0x000389F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0003A7FC File Offset: 0x000389FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.BuffOne = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.lineupList_.AddEntriesFrom(ref input, ChallengeStoryStageTertinggi._repeated_lineupList_codec);
						continue;
					}
					if (num == 56U)
					{
						this.PPMKDMINBNH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.BuffTwo = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400087F RID: 2175
		private static readonly MessageParser<ChallengeStoryStageTertinggi> _parser = new MessageParser<ChallengeStoryStageTertinggi>(() => new ChallengeStoryStageTertinggi());

		// Token: 0x04000880 RID: 2176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000881 RID: 2177
		public const int LineupListFieldNumber = 4;

		// Token: 0x04000882 RID: 2178
		private static readonly FieldCodec<ChallengeLineupList> _repeated_lineupList_codec = FieldCodec.ForMessage<ChallengeLineupList>(34U, ChallengeLineupList.Parser);

		// Token: 0x04000883 RID: 2179
		private readonly RepeatedField<ChallengeLineupList> lineupList_ = new RepeatedField<ChallengeLineupList>();

		// Token: 0x04000884 RID: 2180
		public const int PPMKDMINBNHFieldNumber = 7;

		// Token: 0x04000885 RID: 2181
		private uint pPMKDMINBNH_;

		// Token: 0x04000886 RID: 2182
		public const int ScoreIdFieldNumber = 9;

		// Token: 0x04000887 RID: 2183
		private uint scoreId_;

		// Token: 0x04000888 RID: 2184
		public const int BuffTwoFieldNumber = 13;

		// Token: 0x04000889 RID: 2185
		private uint buffTwo_;

		// Token: 0x0400088A RID: 2186
		public const int BuffOneFieldNumber = 1;

		// Token: 0x0400088B RID: 2187
		private uint buffOne_;

		// Token: 0x0400088C RID: 2188
		public const int LevelFieldNumber = 15;

		// Token: 0x0400088D RID: 2189
		private uint level_;
	}
}

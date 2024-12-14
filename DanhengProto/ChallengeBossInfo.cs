using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000199 RID: 409
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossInfo : IMessage<ChallengeBossInfo>, IMessage, IEquatable<ChallengeBossInfo>, IDeepCloneable<ChallengeBossInfo>, IBufferMessage
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x000349E1 File Offset: 0x00032BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossInfo> Parser
		{
			get
			{
				return ChallengeBossInfo._parser;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x000349E8 File Offset: 0x00032BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x000349FA File Offset: 0x00032BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossInfo.Descriptor;
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00034A01 File Offset: 0x00032C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossInfo()
		{
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00034A38 File Offset: 0x00032C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossInfo(ChallengeBossInfo other) : this()
		{
			this.secondNode_ = ((other.secondNode_ != null) ? other.secondNode_.Clone() : null);
			this.challengeAvatarEquipmentMap_ = other.challengeAvatarEquipmentMap_.Clone();
			this.firstLineup_ = other.firstLineup_.Clone();
			this.secondLineup_ = other.secondLineup_.Clone();
			this.cPNMHNAFDJM_ = other.cPNMHNAFDJM_;
			this.challengeAvatarRelicMap_ = other.challengeAvatarRelicMap_.Clone();
			this.firstNode_ = ((other.firstNode_ != null) ? other.firstNode_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00034AE4 File Offset: 0x00032CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossInfo Clone()
		{
			return new ChallengeBossInfo(this);
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00034AEC File Offset: 0x00032CEC
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x00034AF4 File Offset: 0x00032CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossSingleNodeInfo SecondNode
		{
			get
			{
				return this.secondNode_;
			}
			set
			{
				this.secondNode_ = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00034AFD File Offset: 0x00032CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, ChallengeBossEquipmentInfo> ChallengeAvatarEquipmentMap
		{
			get
			{
				return this.challengeAvatarEquipmentMap_;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00034B05 File Offset: 0x00032D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FirstLineup
		{
			get
			{
				return this.firstLineup_;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00034B0D File Offset: 0x00032D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SecondLineup
		{
			get
			{
				return this.secondLineup_;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00034B15 File Offset: 0x00032D15
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x00034B1D File Offset: 0x00032D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CPNMHNAFDJM
		{
			get
			{
				return this.cPNMHNAFDJM_;
			}
			set
			{
				this.cPNMHNAFDJM_ = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00034B26 File Offset: 0x00032D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, ChallengeBossAvatarRelicInfo> ChallengeAvatarRelicMap
		{
			get
			{
				return this.challengeAvatarRelicMap_;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00034B2E File Offset: 0x00032D2E
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x00034B36 File Offset: 0x00032D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossSingleNodeInfo FirstNode
		{
			get
			{
				return this.firstNode_;
			}
			set
			{
				this.firstNode_ = value;
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00034B3F File Offset: 0x00032D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossInfo);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00034B50 File Offset: 0x00032D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossInfo other)
		{
			return other != null && (other == this || (object.Equals(this.SecondNode, other.SecondNode) && this.ChallengeAvatarEquipmentMap.Equals(other.ChallengeAvatarEquipmentMap) && this.firstLineup_.Equals(other.firstLineup_) && this.secondLineup_.Equals(other.secondLineup_) && this.CPNMHNAFDJM == other.CPNMHNAFDJM && this.ChallengeAvatarRelicMap.Equals(other.ChallengeAvatarRelicMap) && object.Equals(this.FirstNode, other.FirstNode) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00034C08 File Offset: 0x00032E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.secondNode_ != null)
			{
				num ^= this.SecondNode.GetHashCode();
			}
			num ^= this.ChallengeAvatarEquipmentMap.GetHashCode();
			num ^= this.firstLineup_.GetHashCode();
			num ^= this.secondLineup_.GetHashCode();
			if (this.CPNMHNAFDJM)
			{
				num ^= this.CPNMHNAFDJM.GetHashCode();
			}
			num ^= this.ChallengeAvatarRelicMap.GetHashCode();
			if (this.firstNode_ != null)
			{
				num ^= this.FirstNode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00034CAB File Offset: 0x00032EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00034CB3 File Offset: 0x00032EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00034CBC File Offset: 0x00032EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeAvatarRelicMap_.WriteTo(ref output, ChallengeBossInfo._map_challengeAvatarRelicMap_codec);
			this.firstLineup_.WriteTo(ref output, ChallengeBossInfo._repeated_firstLineup_codec);
			this.challengeAvatarEquipmentMap_.WriteTo(ref output, ChallengeBossInfo._map_challengeAvatarEquipmentMap_codec);
			if (this.CPNMHNAFDJM)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.CPNMHNAFDJM);
			}
			if (this.firstNode_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.FirstNode);
			}
			this.secondLineup_.WriteTo(ref output, ChallengeBossInfo._repeated_secondLineup_codec);
			if (this.secondNode_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SecondNode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00034D78 File Offset: 0x00032F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.secondNode_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SecondNode);
			}
			num += this.challengeAvatarEquipmentMap_.CalculateSize(ChallengeBossInfo._map_challengeAvatarEquipmentMap_codec);
			num += this.firstLineup_.CalculateSize(ChallengeBossInfo._repeated_firstLineup_codec);
			num += this.secondLineup_.CalculateSize(ChallengeBossInfo._repeated_secondLineup_codec);
			if (this.CPNMHNAFDJM)
			{
				num += 2;
			}
			num += this.challengeAvatarRelicMap_.CalculateSize(ChallengeBossInfo._map_challengeAvatarRelicMap_codec);
			if (this.firstNode_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FirstNode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00034E28 File Offset: 0x00033028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.secondNode_ != null)
			{
				if (this.secondNode_ == null)
				{
					this.SecondNode = new ChallengeBossSingleNodeInfo();
				}
				this.SecondNode.MergeFrom(other.SecondNode);
			}
			this.challengeAvatarEquipmentMap_.MergeFrom(other.challengeAvatarEquipmentMap_);
			this.firstLineup_.Add(other.firstLineup_);
			this.secondLineup_.Add(other.secondLineup_);
			if (other.CPNMHNAFDJM)
			{
				this.CPNMHNAFDJM = other.CPNMHNAFDJM;
			}
			this.challengeAvatarRelicMap_.MergeFrom(other.challengeAvatarRelicMap_);
			if (other.firstNode_ != null)
			{
				if (this.firstNode_ == null)
				{
					this.FirstNode = new ChallengeBossSingleNodeInfo();
				}
				this.FirstNode.MergeFrom(other.FirstNode);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00034F00 File Offset: 0x00033100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00034F0C File Offset: 0x0003310C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 40U)
					{
						if (num == 10U)
						{
							this.challengeAvatarRelicMap_.AddEntriesFrom(ref input, ChallengeBossInfo._map_challengeAvatarRelicMap_codec);
							continue;
						}
						if (num != 40U)
						{
							goto IL_50;
						}
					}
					else if (num != 42U)
					{
						if (num != 50U)
						{
							goto IL_50;
						}
						this.challengeAvatarEquipmentMap_.AddEntriesFrom(ref input, ChallengeBossInfo._map_challengeAvatarEquipmentMap_codec);
						continue;
					}
					this.firstLineup_.AddEntriesFrom(ref input, ChallengeBossInfo._repeated_firstLineup_codec);
					continue;
				}
				if (num <= 66U)
				{
					if (num == 56U)
					{
						this.CPNMHNAFDJM = input.ReadBool();
						continue;
					}
					if (num == 66U)
					{
						if (this.firstNode_ == null)
						{
							this.FirstNode = new ChallengeBossSingleNodeInfo();
						}
						input.ReadMessage(this.FirstNode);
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.secondLineup_.AddEntriesFrom(ref input, ChallengeBossInfo._repeated_secondLineup_codec);
						continue;
					}
					if (num == 114U)
					{
						if (this.secondNode_ == null)
						{
							this.SecondNode = new ChallengeBossSingleNodeInfo();
						}
						input.ReadMessage(this.SecondNode);
						continue;
					}
				}
				IL_50:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040007AA RID: 1962
		private static readonly MessageParser<ChallengeBossInfo> _parser = new MessageParser<ChallengeBossInfo>(() => new ChallengeBossInfo());

		// Token: 0x040007AB RID: 1963
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007AC RID: 1964
		public const int SecondNodeFieldNumber = 14;

		// Token: 0x040007AD RID: 1965
		private ChallengeBossSingleNodeInfo secondNode_;

		// Token: 0x040007AE RID: 1966
		public const int ChallengeAvatarEquipmentMapFieldNumber = 6;

		// Token: 0x040007AF RID: 1967
		private static readonly MapField<uint, ChallengeBossEquipmentInfo>.Codec _map_challengeAvatarEquipmentMap_codec = new MapField<uint, ChallengeBossEquipmentInfo>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<ChallengeBossEquipmentInfo>(18U, ChallengeBossEquipmentInfo.Parser), 50U);

		// Token: 0x040007B0 RID: 1968
		private readonly MapField<uint, ChallengeBossEquipmentInfo> challengeAvatarEquipmentMap_ = new MapField<uint, ChallengeBossEquipmentInfo>();

		// Token: 0x040007B1 RID: 1969
		public const int FirstLineupFieldNumber = 5;

		// Token: 0x040007B2 RID: 1970
		private static readonly FieldCodec<uint> _repeated_firstLineup_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040007B3 RID: 1971
		private readonly RepeatedField<uint> firstLineup_ = new RepeatedField<uint>();

		// Token: 0x040007B4 RID: 1972
		public const int SecondLineupFieldNumber = 13;

		// Token: 0x040007B5 RID: 1973
		private static readonly FieldCodec<uint> _repeated_secondLineup_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x040007B6 RID: 1974
		private readonly RepeatedField<uint> secondLineup_ = new RepeatedField<uint>();

		// Token: 0x040007B7 RID: 1975
		public const int CPNMHNAFDJMFieldNumber = 7;

		// Token: 0x040007B8 RID: 1976
		private bool cPNMHNAFDJM_;

		// Token: 0x040007B9 RID: 1977
		public const int ChallengeAvatarRelicMapFieldNumber = 1;

		// Token: 0x040007BA RID: 1978
		private static readonly MapField<uint, ChallengeBossAvatarRelicInfo>.Codec _map_challengeAvatarRelicMap_codec = new MapField<uint, ChallengeBossAvatarRelicInfo>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<ChallengeBossAvatarRelicInfo>(18U, ChallengeBossAvatarRelicInfo.Parser), 10U);

		// Token: 0x040007BB RID: 1979
		private readonly MapField<uint, ChallengeBossAvatarRelicInfo> challengeAvatarRelicMap_ = new MapField<uint, ChallengeBossAvatarRelicInfo>();

		// Token: 0x040007BC RID: 1980
		public const int FirstNodeFieldNumber = 8;

		// Token: 0x040007BD RID: 1981
		private ChallengeBossSingleNodeInfo firstNode_;
	}
}

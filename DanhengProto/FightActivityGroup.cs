using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000525 RID: 1317
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightActivityGroup : IMessage<FightActivityGroup>, IMessage, IEquatable<FightActivityGroup>, IDeepCloneable<FightActivityGroup>, IBufferMessage
	{
		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x000A1C07 File Offset: 0x0009FE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightActivityGroup> Parser
		{
			get
			{
				return FightActivityGroup._parser;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x000A1C0E File Offset: 0x0009FE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightActivityGroupReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x000A1C20 File Offset: 0x0009FE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightActivityGroup.Descriptor;
			}
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x000A1C27 File Offset: 0x0009FE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightActivityGroup()
		{
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x000A1C3C File Offset: 0x0009FE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightActivityGroup(FightActivityGroup other) : this()
		{
			this.groupId_ = other.groupId_;
			this.endlessMaxWave_ = other.endlessMaxWave_;
			this.passedMaxDifficultyLevel_ = other.passedMaxDifficultyLevel_;
			this.takenDifficultyLevelRewardList_ = other.takenDifficultyLevelRewardList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x000A1C95 File Offset: 0x0009FE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightActivityGroup Clone()
		{
			return new FightActivityGroup(this);
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x000A1C9D File Offset: 0x0009FE9D
		// (set) Token: 0x06003AE1 RID: 15073 RVA: 0x000A1CA5 File Offset: 0x0009FEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x000A1CAE File Offset: 0x0009FEAE
		// (set) Token: 0x06003AE3 RID: 15075 RVA: 0x000A1CB6 File Offset: 0x0009FEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EndlessMaxWave
		{
			get
			{
				return this.endlessMaxWave_;
			}
			set
			{
				this.endlessMaxWave_ = value;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x000A1CBF File Offset: 0x0009FEBF
		// (set) Token: 0x06003AE5 RID: 15077 RVA: 0x000A1CC7 File Offset: 0x0009FEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PassedMaxDifficultyLevel
		{
			get
			{
				return this.passedMaxDifficultyLevel_;
			}
			set
			{
				this.passedMaxDifficultyLevel_ = value;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x000A1CD0 File Offset: 0x0009FED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TakenDifficultyLevelRewardList
		{
			get
			{
				return this.takenDifficultyLevelRewardList_;
			}
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x000A1CD8 File Offset: 0x0009FED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightActivityGroup);
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x000A1CE8 File Offset: 0x0009FEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightActivityGroup other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.EndlessMaxWave == other.EndlessMaxWave && this.PassedMaxDifficultyLevel == other.PassedMaxDifficultyLevel && this.takenDifficultyLevelRewardList_.Equals(other.takenDifficultyLevelRewardList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x000A1D58 File Offset: 0x0009FF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.EndlessMaxWave != 0U)
			{
				num ^= this.EndlessMaxWave.GetHashCode();
			}
			if (this.PassedMaxDifficultyLevel != 0U)
			{
				num ^= this.PassedMaxDifficultyLevel.GetHashCode();
			}
			num ^= this.takenDifficultyLevelRewardList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x000A1DD7 File Offset: 0x0009FFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x000A1DDF File Offset: 0x0009FFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x000A1DE8 File Offset: 0x0009FFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EndlessMaxWave != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EndlessMaxWave);
			}
			this.takenDifficultyLevelRewardList_.WriteTo(ref output, FightActivityGroup._repeated_takenDifficultyLevelRewardList_codec);
			if (this.PassedMaxDifficultyLevel != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PassedMaxDifficultyLevel);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x000A1E70 File Offset: 0x000A0070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.EndlessMaxWave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EndlessMaxWave);
			}
			if (this.PassedMaxDifficultyLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PassedMaxDifficultyLevel);
			}
			num += this.takenDifficultyLevelRewardList_.CalculateSize(FightActivityGroup._repeated_takenDifficultyLevelRewardList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x000A1EF4 File Offset: 0x000A00F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightActivityGroup other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.EndlessMaxWave != 0U)
			{
				this.EndlessMaxWave = other.EndlessMaxWave;
			}
			if (other.PassedMaxDifficultyLevel != 0U)
			{
				this.PassedMaxDifficultyLevel = other.PassedMaxDifficultyLevel;
			}
			this.takenDifficultyLevelRewardList_.Add(other.takenDifficultyLevelRewardList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x000A1F69 File Offset: 0x000A0169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x000A1F74 File Offset: 0x000A0174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.EndlessMaxWave = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						goto IL_44;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_44;
					}
					if (num == 72U)
					{
						this.PassedMaxDifficultyLevel = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_44:
				this.takenDifficultyLevelRewardList_.AddEntriesFrom(ref input, FightActivityGroup._repeated_takenDifficultyLevelRewardList_codec);
			}
		}

		// Token: 0x040017A5 RID: 6053
		private static readonly MessageParser<FightActivityGroup> _parser = new MessageParser<FightActivityGroup>(() => new FightActivityGroup());

		// Token: 0x040017A6 RID: 6054
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017A7 RID: 6055
		public const int GroupIdFieldNumber = 15;

		// Token: 0x040017A8 RID: 6056
		private uint groupId_;

		// Token: 0x040017A9 RID: 6057
		public const int EndlessMaxWaveFieldNumber = 3;

		// Token: 0x040017AA RID: 6058
		private uint endlessMaxWave_;

		// Token: 0x040017AB RID: 6059
		public const int PassedMaxDifficultyLevelFieldNumber = 9;

		// Token: 0x040017AC RID: 6060
		private uint passedMaxDifficultyLevel_;

		// Token: 0x040017AD RID: 6061
		public const int TakenDifficultyLevelRewardListFieldNumber = 4;

		// Token: 0x040017AE RID: 6062
		private static readonly FieldCodec<uint> _repeated_takenDifficultyLevelRewardList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040017AF RID: 6063
		private readonly RepeatedField<uint> takenDifficultyLevelRewardList_ = new RepeatedField<uint>();
	}
}

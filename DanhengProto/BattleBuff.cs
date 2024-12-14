using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000DB RID: 219
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleBuff : IMessage<BattleBuff>, IMessage, IEquatable<BattleBuff>, IDeepCloneable<BattleBuff>, IBufferMessage
	{
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0001D220 File Offset: 0x0001B420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleBuff> Parser
		{
			get
			{
				return BattleBuff._parser;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0001D227 File Offset: 0x0001B427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleBuffReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0001D239 File Offset: 0x0001B439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleBuff.Descriptor;
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001D240 File Offset: 0x0001B440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleBuff()
		{
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001D260 File Offset: 0x0001B460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleBuff(BattleBuff other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.ownerIndex_ = other.ownerIndex_;
			this.waveFlag_ = other.waveFlag_;
			this.targetIndexList_ = other.targetIndexList_.Clone();
			this.dynamicValues_ = other.dynamicValues_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001D2D6 File Offset: 0x0001B4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleBuff Clone()
		{
			return new BattleBuff(this);
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0001D2DE File Offset: 0x0001B4DE
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x0001D2E6 File Offset: 0x0001B4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0001D2EF File Offset: 0x0001B4EF
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x0001D2F7 File Offset: 0x0001B4F7
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

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0001D300 File Offset: 0x0001B500
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x0001D308 File Offset: 0x0001B508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OwnerIndex
		{
			get
			{
				return this.ownerIndex_;
			}
			set
			{
				this.ownerIndex_ = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0001D311 File Offset: 0x0001B511
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0001D319 File Offset: 0x0001B519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WaveFlag
		{
			get
			{
				return this.waveFlag_;
			}
			set
			{
				this.waveFlag_ = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0001D322 File Offset: 0x0001B522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TargetIndexList
		{
			get
			{
				return this.targetIndexList_;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0001D32A File Offset: 0x0001B52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, float> DynamicValues
		{
			get
			{
				return this.dynamicValues_;
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0001D332 File Offset: 0x0001B532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleBuff);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0001D340 File Offset: 0x0001B540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleBuff other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.OwnerIndex == other.OwnerIndex && this.WaveFlag == other.WaveFlag && this.targetIndexList_.Equals(other.targetIndexList_) && this.DynamicValues.Equals(other.DynamicValues) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0001D3D4 File Offset: 0x0001B5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.OwnerIndex != 0U)
			{
				num ^= this.OwnerIndex.GetHashCode();
			}
			if (this.WaveFlag != 0U)
			{
				num ^= this.WaveFlag.GetHashCode();
			}
			num ^= this.targetIndexList_.GetHashCode();
			num ^= this.DynamicValues.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0001D47A File Offset: 0x0001B67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0001D482 File Offset: 0x0001B682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0001D48C File Offset: 0x0001B68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.OwnerIndex != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OwnerIndex);
			}
			if (this.WaveFlag != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.WaveFlag);
			}
			this.targetIndexList_.WriteTo(ref output, BattleBuff._repeated_targetIndexList_codec);
			this.dynamicValues_.WriteTo(ref output, BattleBuff._map_dynamicValues_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0001D540 File Offset: 0x0001B740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.OwnerIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OwnerIndex);
			}
			if (this.WaveFlag != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WaveFlag);
			}
			num += this.targetIndexList_.CalculateSize(BattleBuff._repeated_targetIndexList_codec);
			num += this.dynamicValues_.CalculateSize(BattleBuff._map_dynamicValues_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.OwnerIndex != 0U)
			{
				this.OwnerIndex = other.OwnerIndex;
			}
			if (other.WaveFlag != 0U)
			{
				this.WaveFlag = other.WaveFlag;
			}
			this.targetIndexList_.Add(other.targetIndexList_);
			this.dynamicValues_.MergeFrom(other.dynamicValues_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0001D686 File Offset: 0x0001B886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0001D690 File Offset: 0x0001B890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 24U)
				{
					if (num <= 40U)
					{
						if (num == 32U)
						{
							this.WaveFlag = input.ReadUInt32();
							continue;
						}
						if (num != 40U)
						{
							goto IL_35;
						}
					}
					else if (num != 42U)
					{
						if (num != 50U)
						{
							goto IL_35;
						}
						this.dynamicValues_.AddEntriesFrom(ref input, BattleBuff._map_dynamicValues_codec);
						continue;
					}
					this.targetIndexList_.AddEntriesFrom(ref input, BattleBuff._repeated_targetIndexList_codec);
					continue;
				}
				if (num == 8U)
				{
					this.Id = input.ReadUInt32();
					continue;
				}
				if (num == 16U)
				{
					this.Level = input.ReadUInt32();
					continue;
				}
				if (num == 24U)
				{
					this.OwnerIndex = input.ReadUInt32();
					continue;
				}
				IL_35:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000410 RID: 1040
		private static readonly MessageParser<BattleBuff> _parser = new MessageParser<BattleBuff>(() => new BattleBuff());

		// Token: 0x04000411 RID: 1041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000412 RID: 1042
		public const int IdFieldNumber = 1;

		// Token: 0x04000413 RID: 1043
		private uint id_;

		// Token: 0x04000414 RID: 1044
		public const int LevelFieldNumber = 2;

		// Token: 0x04000415 RID: 1045
		private uint level_;

		// Token: 0x04000416 RID: 1046
		public const int OwnerIndexFieldNumber = 3;

		// Token: 0x04000417 RID: 1047
		private uint ownerIndex_;

		// Token: 0x04000418 RID: 1048
		public const int WaveFlagFieldNumber = 4;

		// Token: 0x04000419 RID: 1049
		private uint waveFlag_;

		// Token: 0x0400041A RID: 1050
		public const int TargetIndexListFieldNumber = 5;

		// Token: 0x0400041B RID: 1051
		private static readonly FieldCodec<uint> _repeated_targetIndexList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x0400041C RID: 1052
		private readonly RepeatedField<uint> targetIndexList_ = new RepeatedField<uint>();

		// Token: 0x0400041D RID: 1053
		public const int DynamicValuesFieldNumber = 6;

		// Token: 0x0400041E RID: 1054
		private static readonly MapField<string, float>.Codec _map_dynamicValues_codec = new MapField<string, float>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForFloat(21U, 0f), 50U);

		// Token: 0x0400041F RID: 1055
		private readonly MapField<string, float> dynamicValues_ = new MapField<string, float>();
	}
}

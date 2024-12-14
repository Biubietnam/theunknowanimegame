using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000145 RID: 325
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuffInfo : IMessage<BuffInfo>, IMessage, IEquatable<BuffInfo>, IDeepCloneable<BuffInfo>, IBufferMessage
	{
		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0002AE1C File Offset: 0x0002901C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuffInfo> Parser
		{
			get
			{
				return BuffInfo._parser;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0002AE23 File Offset: 0x00029023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuffInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0002AE35 File Offset: 0x00029035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffInfo.Descriptor;
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0002AE3C File Offset: 0x0002903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffInfo()
		{
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0002AE50 File Offset: 0x00029050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffInfo(BuffInfo other) : this()
		{
			this.dynamicValues_ = other.dynamicValues_.Clone();
			this.count_ = other.count_;
			this.level_ = other.level_;
			this.buffId_ = other.buffId_;
			this.buffSummonEntityId_ = other.buffSummonEntityId_;
			this.addTimeMs_ = other.addTimeMs_;
			this.lifeTime_ = other.lifeTime_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0002AED9 File Offset: 0x000290D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffInfo Clone()
		{
			return new BuffInfo(this);
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0002AEE1 File Offset: 0x000290E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, float> DynamicValues
		{
			get
			{
				return this.dynamicValues_;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0002AEE9 File Offset: 0x000290E9
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x0002AEF1 File Offset: 0x000290F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0002AEFA File Offset: 0x000290FA
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x0002AF02 File Offset: 0x00029102
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0002AF0B File Offset: 0x0002910B
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x0002AF13 File Offset: 0x00029113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x0002AF1C File Offset: 0x0002911C
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x0002AF24 File Offset: 0x00029124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffSummonEntityId
		{
			get
			{
				return this.buffSummonEntityId_;
			}
			set
			{
				this.buffSummonEntityId_ = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x0002AF2D File Offset: 0x0002912D
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x0002AF35 File Offset: 0x00029135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong AddTimeMs
		{
			get
			{
				return this.addTimeMs_;
			}
			set
			{
				this.addTimeMs_ = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x0002AF3E File Offset: 0x0002913E
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x0002AF46 File Offset: 0x00029146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LifeTime
		{
			get
			{
				return this.lifeTime_;
			}
			set
			{
				this.lifeTime_ = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0002AF4F File Offset: 0x0002914F
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x0002AF57 File Offset: 0x00029157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0002AF60 File Offset: 0x00029160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffInfo);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0002AF70 File Offset: 0x00029170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffInfo other)
		{
			return other != null && (other == this || (this.DynamicValues.Equals(other.DynamicValues) && this.Count == other.Count && this.Level == other.Level && this.BuffId == other.BuffId && this.BuffSummonEntityId == other.BuffSummonEntityId && this.AddTimeMs == other.AddTimeMs && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LifeTime, other.LifeTime) && this.BaseAvatarId == other.BaseAvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0002B028 File Offset: 0x00029228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.DynamicValues.GetHashCode();
			if (this.Count != 0U)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.BuffSummonEntityId != 0U)
			{
				num ^= this.BuffSummonEntityId.GetHashCode();
			}
			if (this.AddTimeMs != 0UL)
			{
				num ^= this.AddTimeMs.GetHashCode();
			}
			if (this.LifeTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LifeTime);
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0002B112 File Offset: 0x00029312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0002B11A File Offset: 0x0002931A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0002B124 File Offset: 0x00029324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LifeTime != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.LifeTime);
			}
			this.dynamicValues_.WriteTo(ref output, BuffInfo._map_dynamicValues_codec);
			if (this.Level != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Level);
			}
			if (this.BuffSummonEntityId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.BuffSummonEntityId);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BuffId);
			}
			if (this.AddTimeMs != 0UL)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.AddTimeMs);
			}
			if (this.Count != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Count);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0002B220 File Offset: 0x00029420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dynamicValues_.CalculateSize(BuffInfo._map_dynamicValues_codec);
			if (this.Count != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this.BuffSummonEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffSummonEntityId);
			}
			if (this.AddTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AddTimeMs);
			}
			if (this.LifeTime != 0f)
			{
				num += 5;
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0002B2FC File Offset: 0x000294FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.dynamicValues_.MergeFrom(other.dynamicValues_);
			if (other.Count != 0U)
			{
				this.Count = other.Count;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			if (other.BuffSummonEntityId != 0U)
			{
				this.BuffSummonEntityId = other.BuffSummonEntityId;
			}
			if (other.AddTimeMs != 0UL)
			{
				this.AddTimeMs = other.AddTimeMs;
			}
			if (other.LifeTime != 0f)
			{
				this.LifeTime = other.LifeTime;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0002B3C6 File Offset: 0x000295C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0002B3D0 File Offset: 0x000295D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 26U)
					{
						if (num == 13U)
						{
							this.LifeTime = input.ReadFloat();
							continue;
						}
						if (num == 26U)
						{
							this.dynamicValues_.AddEntriesFrom(ref input, BuffInfo._map_dynamicValues_codec);
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.BuffSummonEntityId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.BuffId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.AddTimeMs = input.ReadUInt64();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Count = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.BaseAvatarId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000642 RID: 1602
		private static readonly MessageParser<BuffInfo> _parser = new MessageParser<BuffInfo>(() => new BuffInfo());

		// Token: 0x04000643 RID: 1603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000644 RID: 1604
		public const int DynamicValuesFieldNumber = 3;

		// Token: 0x04000645 RID: 1605
		private static readonly MapField<string, float>.Codec _map_dynamicValues_codec = new MapField<string, float>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForFloat(21U, 0f), 26U);

		// Token: 0x04000646 RID: 1606
		private readonly MapField<string, float> dynamicValues_ = new MapField<string, float>();

		// Token: 0x04000647 RID: 1607
		public const int CountFieldNumber = 13;

		// Token: 0x04000648 RID: 1608
		private uint count_;

		// Token: 0x04000649 RID: 1609
		public const int LevelFieldNumber = 5;

		// Token: 0x0400064A RID: 1610
		private uint level_;

		// Token: 0x0400064B RID: 1611
		public const int BuffIdFieldNumber = 7;

		// Token: 0x0400064C RID: 1612
		private uint buffId_;

		// Token: 0x0400064D RID: 1613
		public const int BuffSummonEntityIdFieldNumber = 6;

		// Token: 0x0400064E RID: 1614
		private uint buffSummonEntityId_;

		// Token: 0x0400064F RID: 1615
		public const int AddTimeMsFieldNumber = 9;

		// Token: 0x04000650 RID: 1616
		private ulong addTimeMs_;

		// Token: 0x04000651 RID: 1617
		public const int LifeTimeFieldNumber = 1;

		// Token: 0x04000652 RID: 1618
		private float lifeTime_;

		// Token: 0x04000653 RID: 1619
		public const int BaseAvatarIdFieldNumber = 14;

		// Token: 0x04000654 RID: 1620
		private uint baseAvatarId_;
	}
}

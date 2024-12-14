using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B93 RID: 2963
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterProperty : IMessage<MonsterProperty>, IMessage, IEquatable<MonsterProperty>, IDeepCloneable<MonsterProperty>, IBufferMessage
	{
		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x06008348 RID: 33608 RVA: 0x0015A873 File Offset: 0x00158A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterProperty> Parser
		{
			get
			{
				return MonsterProperty._parser;
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x06008349 RID: 33609 RVA: 0x0015A87A File Offset: 0x00158A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonsterPropertyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x0600834A RID: 33610 RVA: 0x0015A88C File Offset: 0x00158A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterProperty.Descriptor;
			}
		}

		// Token: 0x0600834B RID: 33611 RVA: 0x0015A893 File Offset: 0x00158A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterProperty()
		{
		}

		// Token: 0x0600834C RID: 33612 RVA: 0x0015A89C File Offset: 0x00158A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterProperty(MonsterProperty other) : this()
		{
			this.maxHp_ = other.maxHp_;
			this.attack_ = other.attack_;
			this.defence_ = other.defence_;
			this.shield_ = other.shield_;
			this.speed_ = other.speed_;
			this.leftHp_ = other.leftHp_;
			this.enterBattleHp_ = other.enterBattleHp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600834D RID: 33613 RVA: 0x0015A914 File Offset: 0x00158B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterProperty Clone()
		{
			return new MonsterProperty(this);
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x0600834E RID: 33614 RVA: 0x0015A91C File Offset: 0x00158B1C
		// (set) Token: 0x0600834F RID: 33615 RVA: 0x0015A924 File Offset: 0x00158B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double MaxHp
		{
			get
			{
				return this.maxHp_;
			}
			set
			{
				this.maxHp_ = value;
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x06008350 RID: 33616 RVA: 0x0015A92D File Offset: 0x00158B2D
		// (set) Token: 0x06008351 RID: 33617 RVA: 0x0015A935 File Offset: 0x00158B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Attack
		{
			get
			{
				return this.attack_;
			}
			set
			{
				this.attack_ = value;
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x06008352 RID: 33618 RVA: 0x0015A93E File Offset: 0x00158B3E
		// (set) Token: 0x06008353 RID: 33619 RVA: 0x0015A946 File Offset: 0x00158B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Defence
		{
			get
			{
				return this.defence_;
			}
			set
			{
				this.defence_ = value;
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x06008354 RID: 33620 RVA: 0x0015A94F File Offset: 0x00158B4F
		// (set) Token: 0x06008355 RID: 33621 RVA: 0x0015A957 File Offset: 0x00158B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Shield
		{
			get
			{
				return this.shield_;
			}
			set
			{
				this.shield_ = value;
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x06008356 RID: 33622 RVA: 0x0015A960 File Offset: 0x00158B60
		// (set) Token: 0x06008357 RID: 33623 RVA: 0x0015A968 File Offset: 0x00158B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Speed
		{
			get
			{
				return this.speed_;
			}
			set
			{
				this.speed_ = value;
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x06008358 RID: 33624 RVA: 0x0015A971 File Offset: 0x00158B71
		// (set) Token: 0x06008359 RID: 33625 RVA: 0x0015A979 File Offset: 0x00158B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double LeftHp
		{
			get
			{
				return this.leftHp_;
			}
			set
			{
				this.leftHp_ = value;
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x0600835A RID: 33626 RVA: 0x0015A982 File Offset: 0x00158B82
		// (set) Token: 0x0600835B RID: 33627 RVA: 0x0015A98A File Offset: 0x00158B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double EnterBattleHp
		{
			get
			{
				return this.enterBattleHp_;
			}
			set
			{
				this.enterBattleHp_ = value;
			}
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0015A993 File Offset: 0x00158B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterProperty);
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x0015A9A4 File Offset: 0x00158BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterProperty other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxHp, other.MaxHp) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Attack, other.Attack) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Defence, other.Defence) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Shield, other.Shield) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Speed, other.Speed) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.LeftHp, other.LeftHp) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.EnterBattleHp, other.EnterBattleHp) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x0015AA84 File Offset: 0x00158C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxHp != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxHp);
			}
			if (this.Attack != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Attack);
			}
			if (this.Defence != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Defence);
			}
			if (this.Shield != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Shield);
			}
			if (this.Speed != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Speed);
			}
			if (this.LeftHp != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.LeftHp);
			}
			if (this.EnterBattleHp != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.EnterBattleHp);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x0015ABA6 File Offset: 0x00158DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x0015ABAE File Offset: 0x00158DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x0015ABB8 File Offset: 0x00158DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxHp != 0.0)
			{
				output.WriteRawTag(9);
				output.WriteDouble(this.MaxHp);
			}
			if (this.Attack != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.Attack);
			}
			if (this.Defence != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.Defence);
			}
			if (this.Shield != 0.0)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.Shield);
			}
			if (this.Speed != 0.0)
			{
				output.WriteRawTag(41);
				output.WriteDouble(this.Speed);
			}
			if (this.LeftHp != 0.0)
			{
				output.WriteRawTag(49);
				output.WriteDouble(this.LeftHp);
			}
			if (this.EnterBattleHp != 0.0)
			{
				output.WriteRawTag(57);
				output.WriteDouble(this.EnterBattleHp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x0015ACDC File Offset: 0x00158EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxHp != 0.0)
			{
				num += 9;
			}
			if (this.Attack != 0.0)
			{
				num += 9;
			}
			if (this.Defence != 0.0)
			{
				num += 9;
			}
			if (this.Shield != 0.0)
			{
				num += 9;
			}
			if (this.Speed != 0.0)
			{
				num += 9;
			}
			if (this.LeftHp != 0.0)
			{
				num += 9;
			}
			if (this.EnterBattleHp != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008363 RID: 33635 RVA: 0x0015AD9C File Offset: 0x00158F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterProperty other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxHp != 0.0)
			{
				this.MaxHp = other.MaxHp;
			}
			if (other.Attack != 0.0)
			{
				this.Attack = other.Attack;
			}
			if (other.Defence != 0.0)
			{
				this.Defence = other.Defence;
			}
			if (other.Shield != 0.0)
			{
				this.Shield = other.Shield;
			}
			if (other.Speed != 0.0)
			{
				this.Speed = other.Speed;
			}
			if (other.LeftHp != 0.0)
			{
				this.LeftHp = other.LeftHp;
			}
			if (other.EnterBattleHp != 0.0)
			{
				this.EnterBattleHp = other.EnterBattleHp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x0015AE8F File Offset: 0x0015908F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008365 RID: 33637 RVA: 0x0015AE98 File Offset: 0x00159098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 25U)
				{
					if (num == 9U)
					{
						this.MaxHp = input.ReadDouble();
						continue;
					}
					if (num == 17U)
					{
						this.Attack = input.ReadDouble();
						continue;
					}
					if (num == 25U)
					{
						this.Defence = input.ReadDouble();
						continue;
					}
				}
				else if (num <= 41U)
				{
					if (num == 33U)
					{
						this.Shield = input.ReadDouble();
						continue;
					}
					if (num == 41U)
					{
						this.Speed = input.ReadDouble();
						continue;
					}
				}
				else
				{
					if (num == 49U)
					{
						this.LeftHp = input.ReadDouble();
						continue;
					}
					if (num == 57U)
					{
						this.EnterBattleHp = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003236 RID: 12854
		private static readonly MessageParser<MonsterProperty> _parser = new MessageParser<MonsterProperty>(() => new MonsterProperty());

		// Token: 0x04003237 RID: 12855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003238 RID: 12856
		public const int MaxHpFieldNumber = 1;

		// Token: 0x04003239 RID: 12857
		private double maxHp_;

		// Token: 0x0400323A RID: 12858
		public const int AttackFieldNumber = 2;

		// Token: 0x0400323B RID: 12859
		private double attack_;

		// Token: 0x0400323C RID: 12860
		public const int DefenceFieldNumber = 3;

		// Token: 0x0400323D RID: 12861
		private double defence_;

		// Token: 0x0400323E RID: 12862
		public const int ShieldFieldNumber = 4;

		// Token: 0x0400323F RID: 12863
		private double shield_;

		// Token: 0x04003240 RID: 12864
		public const int SpeedFieldNumber = 5;

		// Token: 0x04003241 RID: 12865
		private double speed_;

		// Token: 0x04003242 RID: 12866
		public const int LeftHpFieldNumber = 6;

		// Token: 0x04003243 RID: 12867
		private double leftHp_;

		// Token: 0x04003244 RID: 12868
		public const int EnterBattleHpFieldNumber = 7;

		// Token: 0x04003245 RID: 12869
		private double enterBattleHp_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C7 RID: 199
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AvatarProperty : IMessage<AvatarProperty>, IMessage, IEquatable<AvatarProperty>, IDeepCloneable<AvatarProperty>, IBufferMessage
	{
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0001A7D3 File Offset: 0x000189D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarProperty> Parser
		{
			get
			{
				return AvatarProperty._parser;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x0001A7DA File Offset: 0x000189DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarPropertyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0001A7EC File Offset: 0x000189EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarProperty.Descriptor;
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0001A7F3 File Offset: 0x000189F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarProperty()
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0001A7FC File Offset: 0x000189FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarProperty(AvatarProperty other) : this()
		{
			this.maxHp_ = other.maxHp_;
			this.attack_ = other.attack_;
			this.defence_ = other.defence_;
			this.speed_ = other.speed_;
			this.leftHp_ = other.leftHp_;
			this.leftSp_ = other.leftSp_;
			this.maxSp_ = other.maxSp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0001A874 File Offset: 0x00018A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarProperty Clone()
		{
			return new AvatarProperty(this);
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0001A87C File Offset: 0x00018A7C
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x0001A884 File Offset: 0x00018A84
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

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0001A88D File Offset: 0x00018A8D
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0001A895 File Offset: 0x00018A95
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

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0001A89E File Offset: 0x00018A9E
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0001A8A6 File Offset: 0x00018AA6
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0001A8AF File Offset: 0x00018AAF
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0001A8B7 File Offset: 0x00018AB7
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0001A8C0 File Offset: 0x00018AC0
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0001A8C8 File Offset: 0x00018AC8
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0001A8D1 File Offset: 0x00018AD1
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0001A8D9 File Offset: 0x00018AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double LeftSp
		{
			get
			{
				return this.leftSp_;
			}
			set
			{
				this.leftSp_ = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0001A8E2 File Offset: 0x00018AE2
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0001A8EA File Offset: 0x00018AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double MaxSp
		{
			get
			{
				return this.maxSp_;
			}
			set
			{
				this.maxSp_ = value;
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0001A8F3 File Offset: 0x00018AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarProperty);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0001A904 File Offset: 0x00018B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarProperty other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxHp, other.MaxHp) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Attack, other.Attack) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Defence, other.Defence) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Speed, other.Speed) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.LeftHp, other.LeftHp) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.LeftSp, other.LeftSp) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxSp, other.MaxSp) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0001A9E4 File Offset: 0x00018BE4
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
			if (this.Speed != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Speed);
			}
			if (this.LeftHp != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.LeftHp);
			}
			if (this.LeftSp != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.LeftSp);
			}
			if (this.MaxSp != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxSp);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001AB06 File Offset: 0x00018D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0001AB0E File Offset: 0x00018D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0001AB18 File Offset: 0x00018D18
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
			if (this.Speed != 0.0)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.Speed);
			}
			if (this.LeftHp != 0.0)
			{
				output.WriteRawTag(41);
				output.WriteDouble(this.LeftHp);
			}
			if (this.LeftSp != 0.0)
			{
				output.WriteRawTag(49);
				output.WriteDouble(this.LeftSp);
			}
			if (this.MaxSp != 0.0)
			{
				output.WriteRawTag(57);
				output.WriteDouble(this.MaxSp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0001AC3C File Offset: 0x00018E3C
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
			if (this.Speed != 0.0)
			{
				num += 9;
			}
			if (this.LeftHp != 0.0)
			{
				num += 9;
			}
			if (this.LeftSp != 0.0)
			{
				num += 9;
			}
			if (this.MaxSp != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001ACFC File Offset: 0x00018EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarProperty other)
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
			if (other.Speed != 0.0)
			{
				this.Speed = other.Speed;
			}
			if (other.LeftHp != 0.0)
			{
				this.LeftHp = other.LeftHp;
			}
			if (other.LeftSp != 0.0)
			{
				this.LeftSp = other.LeftSp;
			}
			if (other.MaxSp != 0.0)
			{
				this.MaxSp = other.MaxSp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0001ADEF File Offset: 0x00018FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001ADF8 File Offset: 0x00018FF8
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
						this.Speed = input.ReadDouble();
						continue;
					}
					if (num == 41U)
					{
						this.LeftHp = input.ReadDouble();
						continue;
					}
				}
				else
				{
					if (num == 49U)
					{
						this.LeftSp = input.ReadDouble();
						continue;
					}
					if (num == 57U)
					{
						this.MaxSp = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040003A2 RID: 930
		private static readonly MessageParser<AvatarProperty> _parser = new MessageParser<AvatarProperty>(() => new AvatarProperty());

		// Token: 0x040003A3 RID: 931
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003A4 RID: 932
		public const int MaxHpFieldNumber = 1;

		// Token: 0x040003A5 RID: 933
		private double maxHp_;

		// Token: 0x040003A6 RID: 934
		public const int AttackFieldNumber = 2;

		// Token: 0x040003A7 RID: 935
		private double attack_;

		// Token: 0x040003A8 RID: 936
		public const int DefenceFieldNumber = 3;

		// Token: 0x040003A9 RID: 937
		private double defence_;

		// Token: 0x040003AA RID: 938
		public const int SpeedFieldNumber = 4;

		// Token: 0x040003AB RID: 939
		private double speed_;

		// Token: 0x040003AC RID: 940
		public const int LeftHpFieldNumber = 5;

		// Token: 0x040003AD RID: 941
		private double leftHp_;

		// Token: 0x040003AE RID: 942
		public const int LeftSpFieldNumber = 6;

		// Token: 0x040003AF RID: 943
		private double leftSp_;

		// Token: 0x040003B0 RID: 944
		public const int MaxSpFieldNumber = 7;

		// Token: 0x040003B1 RID: 945
		private double maxSp_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004A5 RID: 1189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildGearDamageInfo : IMessage<EvolveBuildGearDamageInfo>, IMessage, IEquatable<EvolveBuildGearDamageInfo>, IDeepCloneable<EvolveBuildGearDamageInfo>, IBufferMessage
	{
		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x00092969 File Offset: 0x00090B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildGearDamageInfo> Parser
		{
			get
			{
				return EvolveBuildGearDamageInfo._parser;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x00092970 File Offset: 0x00090B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildGearDamageInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x00092982 File Offset: 0x00090B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildGearDamageInfo.Descriptor;
			}
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00092989 File Offset: 0x00090B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGearDamageInfo()
		{
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00092991 File Offset: 0x00090B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGearDamageInfo(EvolveBuildGearDamageInfo other) : this()
		{
			this.gearId_ = other.gearId_;
			this.damage_ = other.damage_;
			this.hpDamage_ = other.hpDamage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x000929CE File Offset: 0x00090BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGearDamageInfo Clone()
		{
			return new EvolveBuildGearDamageInfo(this);
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x000929D6 File Offset: 0x00090BD6
		// (set) Token: 0x0600352F RID: 13615 RVA: 0x000929DE File Offset: 0x00090BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GearId
		{
			get
			{
				return this.gearId_;
			}
			set
			{
				this.gearId_ = value;
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x000929E7 File Offset: 0x00090BE7
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x000929EF File Offset: 0x00090BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x000929F8 File Offset: 0x00090BF8
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x00092A00 File Offset: 0x00090C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double HpDamage
		{
			get
			{
				return this.hpDamage_;
			}
			set
			{
				this.hpDamage_ = value;
			}
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x00092A09 File Offset: 0x00090C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildGearDamageInfo);
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00092A18 File Offset: 0x00090C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildGearDamageInfo other)
		{
			return other != null && (other == this || (this.GearId == other.GearId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Damage, other.Damage) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.HpDamage, other.HpDamage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x00092A88 File Offset: 0x00090C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GearId != 0U)
			{
				num ^= this.GearId.GetHashCode();
			}
			if (this.Damage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Damage);
			}
			if (this.HpDamage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.HpDamage);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00092B0F File Offset: 0x00090D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00092B17 File Offset: 0x00090D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00092B20 File Offset: 0x00090D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GearId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GearId);
			}
			if (this.Damage != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.Damage);
			}
			if (this.HpDamage != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.HpDamage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x00092BA8 File Offset: 0x00090DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GearId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GearId);
			}
			if (this.Damage != 0.0)
			{
				num += 9;
			}
			if (this.HpDamage != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x00092C14 File Offset: 0x00090E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildGearDamageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GearId != 0U)
			{
				this.GearId = other.GearId;
			}
			if (other.Damage != 0.0)
			{
				this.Damage = other.Damage;
			}
			if (other.HpDamage != 0.0)
			{
				this.HpDamage = other.HpDamage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x00092C8A File Offset: 0x00090E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00092C94 File Offset: 0x00090E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 17U)
					{
						if (num != 25U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HpDamage = input.ReadDouble();
						}
					}
					else
					{
						this.Damage = input.ReadDouble();
					}
				}
				else
				{
					this.GearId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400153D RID: 5437
		private static readonly MessageParser<EvolveBuildGearDamageInfo> _parser = new MessageParser<EvolveBuildGearDamageInfo>(() => new EvolveBuildGearDamageInfo());

		// Token: 0x0400153E RID: 5438
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400153F RID: 5439
		public const int GearIdFieldNumber = 1;

		// Token: 0x04001540 RID: 5440
		private uint gearId_;

		// Token: 0x04001541 RID: 5441
		public const int DamageFieldNumber = 2;

		// Token: 0x04001542 RID: 5442
		private double damage_;

		// Token: 0x04001543 RID: 5443
		public const int HpDamageFieldNumber = 3;

		// Token: 0x04001544 RID: 5444
		private double hpDamage_;
	}
}

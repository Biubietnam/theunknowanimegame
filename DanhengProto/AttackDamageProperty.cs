using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000B9 RID: 185
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AttackDamageProperty : IMessage<AttackDamageProperty>, IMessage, IEquatable<AttackDamageProperty>, IDeepCloneable<AttackDamageProperty>, IBufferMessage
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x000165FC File Offset: 0x000147FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AttackDamageProperty> Parser
		{
			get
			{
				return AttackDamageProperty._parser;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00016603 File Offset: 0x00014803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttackDamagePropertyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00016615 File Offset: 0x00014815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttackDamageProperty.Descriptor;
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0001661C File Offset: 0x0001481C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttackDamageProperty()
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0001662F File Offset: 0x0001482F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttackDamageProperty(AttackDamageProperty other) : this()
		{
			this.attackType_ = other.attackType_;
			this.damage_ = other.damage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00016660 File Offset: 0x00014860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttackDamageProperty Clone()
		{
			return new AttackDamageProperty(this);
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00016668 File Offset: 0x00014868
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00016670 File Offset: 0x00014870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AttackType
		{
			get
			{
				return this.attackType_;
			}
			set
			{
				this.attackType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00016683 File Offset: 0x00014883
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0001668B File Offset: 0x0001488B
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

		// Token: 0x060007F9 RID: 2041 RVA: 0x00016694 File Offset: 0x00014894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttackDamageProperty);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000166A4 File Offset: 0x000148A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttackDamageProperty other)
		{
			return other != null && (other == this || (!(this.AttackType != other.AttackType) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Damage, other.Damage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000166FC File Offset: 0x000148FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttackType.Length != 0)
			{
				num ^= this.AttackType.GetHashCode();
			}
			if (this.Damage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Damage);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00016761 File Offset: 0x00014961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00016769 File Offset: 0x00014969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00016774 File Offset: 0x00014974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttackType.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AttackType);
			}
			if (this.Damage != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.Damage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000167DC File Offset: 0x000149DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttackType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AttackType);
			}
			if (this.Damage != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00016838 File Offset: 0x00014A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttackDamageProperty other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttackType.Length != 0)
			{
				this.AttackType = other.AttackType;
			}
			if (other.Damage != 0.0)
			{
				this.Damage = other.Damage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00016896 File Offset: 0x00014A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000168A0 File Offset: 0x00014AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 17U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Damage = input.ReadDouble();
					}
				}
				else
				{
					this.AttackType = input.ReadString();
				}
			}
		}

		// Token: 0x040002FB RID: 763
		private static readonly MessageParser<AttackDamageProperty> _parser = new MessageParser<AttackDamageProperty>(() => new AttackDamageProperty());

		// Token: 0x040002FC RID: 764
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002FD RID: 765
		public const int AttackTypeFieldNumber = 1;

		// Token: 0x040002FE RID: 766
		private string attackType_ = "";

		// Token: 0x040002FF RID: 767
		public const int DamageFieldNumber = 2;

		// Token: 0x04000300 RID: 768
		private double damage_;
	}
}

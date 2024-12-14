using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200049D RID: 1181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildAvatar : IMessage<EvolveBuildAvatar>, IMessage, IEquatable<EvolveBuildAvatar>, IDeepCloneable<EvolveBuildAvatar>, IBufferMessage
	{
		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x0009069D File Offset: 0x0008E89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildAvatar> Parser
		{
			get
			{
				return EvolveBuildAvatar._parser;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x000906A4 File Offset: 0x0008E8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x000906B6 File Offset: 0x0008E8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildAvatar.Descriptor;
			}
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x000906BD File Offset: 0x0008E8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildAvatar()
		{
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000906C5 File Offset: 0x0008E8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildAvatar(EvolveBuildAvatar other) : this()
		{
			this.damage_ = other.damage_;
			this.avatarType_ = other.avatarType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00090702 File Offset: 0x0008E902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildAvatar Clone()
		{
			return new EvolveBuildAvatar(this);
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x0009070A File Offset: 0x0008E90A
		// (set) Token: 0x060034A3 RID: 13475 RVA: 0x00090712 File Offset: 0x0008E912
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

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x0009071B File Offset: 0x0008E91B
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x00090723 File Offset: 0x0008E923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x0009072C File Offset: 0x0008E92C
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x00090734 File Offset: 0x0008E934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x0009073D File Offset: 0x0008E93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildAvatar);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x0009074C File Offset: 0x0008E94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildAvatar other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Damage, other.Damage) && this.AvatarType == other.AvatarType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000907B0 File Offset: 0x0008E9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Damage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Damage);
			}
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00090832 File Offset: 0x0008EA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x0009083A File Offset: 0x0008EA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00090844 File Offset: 0x0008EA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.Damage != 0.0)
			{
				output.WriteRawTag(89);
				output.WriteDouble(this.Damage);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000908C4 File Offset: 0x0008EAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Damage != 0.0)
			{
				num += 9;
			}
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x00090930 File Offset: 0x0008EB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Damage != 0.0)
			{
				this.Damage = other.Damage;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x0009099D File Offset: 0x0008EB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x000909A8 File Offset: 0x0008EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 89U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AvatarType = (AvatarType)input.ReadEnum();
						}
					}
					else
					{
						this.Damage = input.ReadDouble();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040014E1 RID: 5345
		private static readonly MessageParser<EvolveBuildAvatar> _parser = new MessageParser<EvolveBuildAvatar>(() => new EvolveBuildAvatar());

		// Token: 0x040014E2 RID: 5346
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014E3 RID: 5347
		public const int DamageFieldNumber = 11;

		// Token: 0x040014E4 RID: 5348
		private double damage_;

		// Token: 0x040014E5 RID: 5349
		public const int AvatarTypeFieldNumber = 14;

		// Token: 0x040014E6 RID: 5350
		private AvatarType avatarType_;

		// Token: 0x040014E7 RID: 5351
		public const int AvatarIdFieldNumber = 8;

		// Token: 0x040014E8 RID: 5352
		private uint avatarId_;
	}
}

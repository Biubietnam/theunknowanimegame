using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C93 RID: 3219
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PHKMLOMCNMN : IMessage<PHKMLOMCNMN>, IMessage, IEquatable<PHKMLOMCNMN>, IDeepCloneable<PHKMLOMCNMN>, IBufferMessage
	{
		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x06008F24 RID: 36644 RVA: 0x0017A585 File Offset: 0x00178785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PHKMLOMCNMN> Parser
		{
			get
			{
				return PHKMLOMCNMN._parser;
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x06008F25 RID: 36645 RVA: 0x0017A58C File Offset: 0x0017878C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PHKMLOMCNMNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x06008F26 RID: 36646 RVA: 0x0017A59E File Offset: 0x0017879E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PHKMLOMCNMN.Descriptor;
			}
		}

		// Token: 0x06008F27 RID: 36647 RVA: 0x0017A5A5 File Offset: 0x001787A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PHKMLOMCNMN()
		{
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x0017A5B8 File Offset: 0x001787B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PHKMLOMCNMN(PHKMLOMCNMN other) : this()
		{
			this.skillId_ = other.skillId_;
			this.nLMOBJCCDEL_ = other.nLMOBJCCDEL_;
			this.battleTargetList_ = other.battleTargetList_.Clone();
			this.damage_ = other.damage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x0017A611 File Offset: 0x00178811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PHKMLOMCNMN Clone()
		{
			return new PHKMLOMCNMN(this);
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x06008F2A RID: 36650 RVA: 0x0017A619 File Offset: 0x00178819
		// (set) Token: 0x06008F2B RID: 36651 RVA: 0x0017A621 File Offset: 0x00178821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x06008F2C RID: 36652 RVA: 0x0017A62A File Offset: 0x0017882A
		// (set) Token: 0x06008F2D RID: 36653 RVA: 0x0017A632 File Offset: 0x00178832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double NLMOBJCCDEL
		{
			get
			{
				return this.nLMOBJCCDEL_;
			}
			set
			{
				this.nLMOBJCCDEL_ = value;
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x06008F2E RID: 36654 RVA: 0x0017A63B File Offset: 0x0017883B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BattleTargetList
		{
			get
			{
				return this.battleTargetList_;
			}
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x06008F2F RID: 36655 RVA: 0x0017A643 File Offset: 0x00178843
		// (set) Token: 0x06008F30 RID: 36656 RVA: 0x0017A64B File Offset: 0x0017884B
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

		// Token: 0x06008F31 RID: 36657 RVA: 0x0017A654 File Offset: 0x00178854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PHKMLOMCNMN);
		}

		// Token: 0x06008F32 RID: 36658 RVA: 0x0017A664 File Offset: 0x00178864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PHKMLOMCNMN other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.NLMOBJCCDEL, other.NLMOBJCCDEL) && this.battleTargetList_.Equals(other.battleTargetList_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Damage, other.Damage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F33 RID: 36659 RVA: 0x0017A6E8 File Offset: 0x001788E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.NLMOBJCCDEL != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.NLMOBJCCDEL);
			}
			num ^= this.battleTargetList_.GetHashCode();
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

		// Token: 0x06008F34 RID: 36660 RVA: 0x0017A77D File Offset: 0x0017897D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F35 RID: 36661 RVA: 0x0017A785 File Offset: 0x00178985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F36 RID: 36662 RVA: 0x0017A790 File Offset: 0x00178990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.SkillId);
			}
			if (this.NLMOBJCCDEL != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.NLMOBJCCDEL);
			}
			this.battleTargetList_.WriteTo(ref output, PHKMLOMCNMN._repeated_battleTargetList_codec);
			if (this.Damage != 0.0)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.Damage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x0017A828 File Offset: 0x00178A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this.NLMOBJCCDEL != 0.0)
			{
				num += 9;
			}
			num += this.battleTargetList_.CalculateSize(PHKMLOMCNMN._repeated_battleTargetList_codec);
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

		// Token: 0x06008F38 RID: 36664 RVA: 0x0017A8A8 File Offset: 0x00178AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PHKMLOMCNMN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			if (other.NLMOBJCCDEL != 0.0)
			{
				this.NLMOBJCCDEL = other.NLMOBJCCDEL;
			}
			this.battleTargetList_.Add(other.battleTargetList_);
			if (other.Damage != 0.0)
			{
				this.Damage = other.Damage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0017A92F File Offset: 0x00178B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x0017A938 File Offset: 0x00178B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 17U)
				{
					if (num == 8U)
					{
						this.SkillId = input.ReadUInt32();
						continue;
					}
					if (num == 17U)
					{
						this.NLMOBJCCDEL = input.ReadDouble();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.battleTargetList_.AddEntriesFrom(ref input, PHKMLOMCNMN._repeated_battleTargetList_codec);
						continue;
					}
					if (num == 33U)
					{
						this.Damage = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040036FC RID: 14076
		private static readonly MessageParser<PHKMLOMCNMN> _parser = new MessageParser<PHKMLOMCNMN>(() => new PHKMLOMCNMN());

		// Token: 0x040036FD RID: 14077
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036FE RID: 14078
		public const int SkillIdFieldNumber = 1;

		// Token: 0x040036FF RID: 14079
		private uint skillId_;

		// Token: 0x04003700 RID: 14080
		public const int NLMOBJCCDELFieldNumber = 2;

		// Token: 0x04003701 RID: 14081
		private double nLMOBJCCDEL_;

		// Token: 0x04003702 RID: 14082
		public const int BattleTargetListFieldNumber = 3;

		// Token: 0x04003703 RID: 14083
		private static readonly FieldCodec<uint> _repeated_battleTargetList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04003704 RID: 14084
		private readonly RepeatedField<uint> battleTargetList_ = new RepeatedField<uint>();

		// Token: 0x04003705 RID: 14085
		public const int DamageFieldNumber = 4;

		// Token: 0x04003706 RID: 14086
		private double damage_;
	}
}

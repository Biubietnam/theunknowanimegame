using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000065 RID: 101
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideSpiritInfo : IMessage<AetherDivideSpiritInfo>, IMessage, IEquatable<AetherDivideSpiritInfo>, IDeepCloneable<AetherDivideSpiritInfo>, IBufferMessage
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000C9D3 File Offset: 0x0000ABD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideSpiritInfo> Parser
		{
			get
			{
				return AetherDivideSpiritInfo._parser;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000C9DA File Offset: 0x0000ABDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideSpiritInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideSpiritInfo.Descriptor;
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000C9F3 File Offset: 0x0000ABF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfo()
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfo(AetherDivideSpiritInfo other) : this()
		{
			this.passiveSkill_ = other.passiveSkill_.Clone();
			this.exp_ = other.exp_;
			this.aetherAvatarId_ = other.aetherAvatarId_;
			this.promotion_ = other.promotion_;
			this.bBEJBOJFLLP_ = other.bBEJBOJFLLP_;
			this.spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000CA89 File Offset: 0x0000AC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfo Clone()
		{
			return new AetherDivideSpiritInfo(this);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000CA91 File Offset: 0x0000AC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PassiveSkillItem> PassiveSkill
		{
			get
			{
				return this.passiveSkill_;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0000CA99 File Offset: 0x0000AC99
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x0000CAA1 File Offset: 0x0000ACA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000CAAA File Offset: 0x0000ACAA
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0000CAB2 File Offset: 0x0000ACB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AetherAvatarId
		{
			get
			{
				return this.aetherAvatarId_;
			}
			set
			{
				this.aetherAvatarId_ = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0000CABB File Offset: 0x0000ACBB
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x0000CAC3 File Offset: 0x0000ACC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Promotion
		{
			get
			{
				return this.promotion_;
			}
			set
			{
				this.promotion_ = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0000CACC File Offset: 0x0000ACCC
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BBEJBOJFLLP
		{
			get
			{
				return this.bBEJBOJFLLP_;
			}
			set
			{
				this.bBEJBOJFLLP_ = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000CADD File Offset: 0x0000ACDD
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x0000CAE5 File Offset: 0x0000ACE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo SpBar
		{
			get
			{
				return this.spBar_;
			}
			set
			{
				this.spBar_ = value;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000CAEE File Offset: 0x0000ACEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideSpiritInfo);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000CAFC File Offset: 0x0000ACFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideSpiritInfo other)
		{
			return other != null && (other == this || (this.passiveSkill_.Equals(other.passiveSkill_) && this.Exp == other.Exp && this.AetherAvatarId == other.AetherAvatarId && this.Promotion == other.Promotion && this.BBEJBOJFLLP == other.BBEJBOJFLLP && object.Equals(this.SpBar, other.SpBar) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000CB90 File Offset: 0x0000AD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.passiveSkill_.GetHashCode();
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.AetherAvatarId != 0U)
			{
				num ^= this.AetherAvatarId.GetHashCode();
			}
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			if (this.BBEJBOJFLLP != 0U)
			{
				num ^= this.BBEJBOJFLLP.GetHashCode();
			}
			if (this.spBar_ != null)
			{
				num ^= this.SpBar.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000CC3E File Offset: 0x0000AE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000CC46 File Offset: 0x0000AE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000CC50 File Offset: 0x0000AE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.passiveSkill_.WriteTo(ref output, AetherDivideSpiritInfo._repeated_passiveSkill_codec);
			if (this.AetherAvatarId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AetherAvatarId);
			}
			if (this.BBEJBOJFLLP != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.BBEJBOJFLLP);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Promotion);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Exp);
			}
			if (this.spBar_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.SpBar);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000CD10 File Offset: 0x0000AF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.passiveSkill_.CalculateSize(AetherDivideSpiritInfo._repeated_passiveSkill_codec);
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.AetherAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AetherAvatarId);
			}
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			if (this.BBEJBOJFLLP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BBEJBOJFLLP);
			}
			if (this.spBar_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpBar);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideSpiritInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.passiveSkill_.Add(other.passiveSkill_);
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.AetherAvatarId != 0U)
			{
				this.AetherAvatarId = other.AetherAvatarId;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			if (other.BBEJBOJFLLP != 0U)
			{
				this.BBEJBOJFLLP = other.BBEJBOJFLLP;
			}
			if (other.spBar_ != null)
			{
				if (this.spBar_ == null)
				{
					this.SpBar = new SpBarInfo();
				}
				this.SpBar.MergeFrom(other.SpBar);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000CE79 File Offset: 0x0000B079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000CE84 File Offset: 0x0000B084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 10U)
					{
						this.passiveSkill_.AddEntriesFrom(ref input, AetherDivideSpiritInfo._repeated_passiveSkill_codec);
						continue;
					}
					if (num == 16U)
					{
						this.AetherAvatarId = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BBEJBOJFLLP = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.spBar_ == null)
						{
							this.SpBar = new SpBarInfo();
						}
						input.ReadMessage(this.SpBar);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400018C RID: 396
		private static readonly MessageParser<AetherDivideSpiritInfo> _parser = new MessageParser<AetherDivideSpiritInfo>(() => new AetherDivideSpiritInfo());

		// Token: 0x0400018D RID: 397
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400018E RID: 398
		public const int PassiveSkillFieldNumber = 1;

		// Token: 0x0400018F RID: 399
		private static readonly FieldCodec<PassiveSkillItem> _repeated_passiveSkill_codec = FieldCodec.ForMessage<PassiveSkillItem>(10U, PassiveSkillItem.Parser);

		// Token: 0x04000190 RID: 400
		private readonly RepeatedField<PassiveSkillItem> passiveSkill_ = new RepeatedField<PassiveSkillItem>();

		// Token: 0x04000191 RID: 401
		public const int ExpFieldNumber = 11;

		// Token: 0x04000192 RID: 402
		private uint exp_;

		// Token: 0x04000193 RID: 403
		public const int AetherAvatarIdFieldNumber = 2;

		// Token: 0x04000194 RID: 404
		private uint aetherAvatarId_;

		// Token: 0x04000195 RID: 405
		public const int PromotionFieldNumber = 6;

		// Token: 0x04000196 RID: 406
		private uint promotion_;

		// Token: 0x04000197 RID: 407
		public const int BBEJBOJFLLPFieldNumber = 4;

		// Token: 0x04000198 RID: 408
		private uint bBEJBOJFLLP_;

		// Token: 0x04000199 RID: 409
		public const int SpBarFieldNumber = 13;

		// Token: 0x0400019A RID: 410
		private SpBarInfo spBar_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001409 RID: 5129
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UseItemCsReq : IMessage<UseItemCsReq>, IMessage, IEquatable<UseItemCsReq>, IDeepCloneable<UseItemCsReq>, IBufferMessage
	{
		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x0026028F File Offset: 0x0025E48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UseItemCsReq> Parser
		{
			get
			{
				return UseItemCsReq._parser;
			}
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x0600E4BC RID: 58556 RVA: 0x00260296 File Offset: 0x0025E496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UseItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x0600E4BD RID: 58557 RVA: 0x002602A8 File Offset: 0x0025E4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseItemCsReq.Descriptor;
			}
		}

		// Token: 0x0600E4BE RID: 58558 RVA: 0x002602AF File Offset: 0x0025E4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemCsReq()
		{
		}

		// Token: 0x0600E4BF RID: 58559 RVA: 0x002602B8 File Offset: 0x0025E4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemCsReq(UseItemCsReq other) : this()
		{
			this.cPFGLIKKKGM_ = other.cPFGLIKKKGM_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this.optionalRewardId_ = other.optionalRewardId_;
			this.useItemId_ = other.useItemId_;
			this.useAvatarType_ = other.useAvatarType_;
			this.useItemCount_ = other.useItemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x00260324 File Offset: 0x0025E524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemCsReq Clone()
		{
			return new UseItemCsReq(this);
		}

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x0600E4C1 RID: 58561 RVA: 0x0026032C File Offset: 0x0025E52C
		// (set) Token: 0x0600E4C2 RID: 58562 RVA: 0x00260334 File Offset: 0x0025E534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CPFGLIKKKGM
		{
			get
			{
				return this.cPFGLIKKKGM_;
			}
			set
			{
				this.cPFGLIKKKGM_ = value;
			}
		}

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x0600E4C3 RID: 58563 RVA: 0x0026033D File Offset: 0x0025E53D
		// (set) Token: 0x0600E4C4 RID: 58564 RVA: 0x00260345 File Offset: 0x0025E545
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

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x0600E4C5 RID: 58565 RVA: 0x0026034E File Offset: 0x0025E54E
		// (set) Token: 0x0600E4C6 RID: 58566 RVA: 0x00260356 File Offset: 0x0025E556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionalRewardId
		{
			get
			{
				return this.optionalRewardId_;
			}
			set
			{
				this.optionalRewardId_ = value;
			}
		}

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x0600E4C7 RID: 58567 RVA: 0x0026035F File Offset: 0x0025E55F
		// (set) Token: 0x0600E4C8 RID: 58568 RVA: 0x00260367 File Offset: 0x0025E567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UseItemId
		{
			get
			{
				return this.useItemId_;
			}
			set
			{
				this.useItemId_ = value;
			}
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x0600E4C9 RID: 58569 RVA: 0x00260370 File Offset: 0x0025E570
		// (set) Token: 0x0600E4CA RID: 58570 RVA: 0x00260378 File Offset: 0x0025E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType UseAvatarType
		{
			get
			{
				return this.useAvatarType_;
			}
			set
			{
				this.useAvatarType_ = value;
			}
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x0600E4CB RID: 58571 RVA: 0x00260381 File Offset: 0x0025E581
		// (set) Token: 0x0600E4CC RID: 58572 RVA: 0x00260389 File Offset: 0x0025E589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UseItemCount
		{
			get
			{
				return this.useItemCount_;
			}
			set
			{
				this.useItemCount_ = value;
			}
		}

		// Token: 0x0600E4CD RID: 58573 RVA: 0x00260392 File Offset: 0x0025E592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseItemCsReq);
		}

		// Token: 0x0600E4CE RID: 58574 RVA: 0x002603A0 File Offset: 0x0025E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseItemCsReq other)
		{
			return other != null && (other == this || (this.CPFGLIKKKGM == other.CPFGLIKKKGM && this.BaseAvatarId == other.BaseAvatarId && this.OptionalRewardId == other.OptionalRewardId && this.UseItemId == other.UseItemId && this.UseAvatarType == other.UseAvatarType && this.UseItemCount == other.UseItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4CF RID: 58575 RVA: 0x0026042C File Offset: 0x0025E62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CPFGLIKKKGM)
			{
				num ^= this.CPFGLIKKKGM.GetHashCode();
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.OptionalRewardId != 0U)
			{
				num ^= this.OptionalRewardId.GetHashCode();
			}
			if (this.UseItemId != 0U)
			{
				num ^= this.UseItemId.GetHashCode();
			}
			if (this.UseAvatarType != AvatarType.None)
			{
				num ^= this.UseAvatarType.GetHashCode();
			}
			if (this.UseItemCount != 0U)
			{
				num ^= this.UseItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E4D0 RID: 58576 RVA: 0x002604EE File Offset: 0x0025E6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E4D1 RID: 58577 RVA: 0x002604F6 File Offset: 0x0025E6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4D2 RID: 58578 RVA: 0x00260500 File Offset: 0x0025E700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseAvatarType != AvatarType.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.UseAvatarType);
			}
			if (this.OptionalRewardId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OptionalRewardId);
			}
			if (this.UseItemCount != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.UseItemCount);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.CPFGLIKKKGM)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.CPFGLIKKKGM);
			}
			if (this.UseItemId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.UseItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E4D3 RID: 58579 RVA: 0x002605C8 File Offset: 0x0025E7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CPFGLIKKKGM)
			{
				num += 2;
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.OptionalRewardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionalRewardId);
			}
			if (this.UseItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UseItemId);
			}
			if (this.UseAvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.UseAvatarType);
			}
			if (this.UseItemCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UseItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E4D4 RID: 58580 RVA: 0x00260674 File Offset: 0x0025E874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CPFGLIKKKGM)
			{
				this.CPFGLIKKKGM = other.CPFGLIKKKGM;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.OptionalRewardId != 0U)
			{
				this.OptionalRewardId = other.OptionalRewardId;
			}
			if (other.UseItemId != 0U)
			{
				this.UseItemId = other.UseItemId;
			}
			if (other.UseAvatarType != AvatarType.None)
			{
				this.UseAvatarType = other.UseAvatarType;
			}
			if (other.UseItemCount != 0U)
			{
				this.UseItemCount = other.UseItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4D5 RID: 58581 RVA: 0x00260714 File Offset: 0x0025E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4D6 RID: 58582 RVA: 0x00260720 File Offset: 0x0025E920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.UseAvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.OptionalRewardId = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.UseItemCount = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.BaseAvatarId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.CPFGLIKKKGM = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.UseItemId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005AD9 RID: 23257
		private static readonly MessageParser<UseItemCsReq> _parser = new MessageParser<UseItemCsReq>(() => new UseItemCsReq());

		// Token: 0x04005ADA RID: 23258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ADB RID: 23259
		public const int CPFGLIKKKGMFieldNumber = 13;

		// Token: 0x04005ADC RID: 23260
		private bool cPFGLIKKKGM_;

		// Token: 0x04005ADD RID: 23261
		public const int BaseAvatarIdFieldNumber = 10;

		// Token: 0x04005ADE RID: 23262
		private uint baseAvatarId_;

		// Token: 0x04005ADF RID: 23263
		public const int OptionalRewardIdFieldNumber = 3;

		// Token: 0x04005AE0 RID: 23264
		private uint optionalRewardId_;

		// Token: 0x04005AE1 RID: 23265
		public const int UseItemIdFieldNumber = 14;

		// Token: 0x04005AE2 RID: 23266
		private uint useItemId_;

		// Token: 0x04005AE3 RID: 23267
		public const int UseAvatarTypeFieldNumber = 1;

		// Token: 0x04005AE4 RID: 23268
		private AvatarType useAvatarType_;

		// Token: 0x04005AE5 RID: 23269
		public const int UseItemCountFieldNumber = 7;

		// Token: 0x04005AE6 RID: 23270
		private uint useItemCount_;
	}
}

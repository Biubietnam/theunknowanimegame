using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200055B RID: 1371
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTreasureDungeonMonsterCsReq : IMessage<FightTreasureDungeonMonsterCsReq>, IMessage, IEquatable<FightTreasureDungeonMonsterCsReq>, IDeepCloneable<FightTreasureDungeonMonsterCsReq>, IBufferMessage
	{
		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x000A76BB File Offset: 0x000A58BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightTreasureDungeonMonsterCsReq> Parser
		{
			get
			{
				return FightTreasureDungeonMonsterCsReq._parser;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x000A76C2 File Offset: 0x000A58C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightTreasureDungeonMonsterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x000A76D4 File Offset: 0x000A58D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightTreasureDungeonMonsterCsReq.Descriptor;
			}
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x000A76DB File Offset: 0x000A58DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTreasureDungeonMonsterCsReq()
		{
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x000A76F0 File Offset: 0x000A58F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTreasureDungeonMonsterCsReq(FightTreasureDungeonMonsterCsReq other) : this()
		{
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this.avatarList_ = other.avatarList_.Clone();
			this.eEEABJCNKDO_ = other.eEEABJCNKDO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x000A773D File Offset: 0x000A593D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTreasureDungeonMonsterCsReq Clone()
		{
			return new FightTreasureDungeonMonsterCsReq(this);
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06003D23 RID: 15651 RVA: 0x000A7745 File Offset: 0x000A5945
		// (set) Token: 0x06003D24 RID: 15652 RVA: 0x000A774D File Offset: 0x000A594D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCFAJPAMBGD
		{
			get
			{
				return this.nCFAJPAMBGD_;
			}
			set
			{
				this.nCFAJPAMBGD_ = value;
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06003D25 RID: 15653 RVA: 0x000A7756 File Offset: 0x000A5956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureDungeonAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06003D26 RID: 15654 RVA: 0x000A775E File Offset: 0x000A595E
		// (set) Token: 0x06003D27 RID: 15655 RVA: 0x000A7766 File Offset: 0x000A5966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EEEABJCNKDO
		{
			get
			{
				return this.eEEABJCNKDO_;
			}
			set
			{
				this.eEEABJCNKDO_ = value;
			}
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x000A776F File Offset: 0x000A596F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightTreasureDungeonMonsterCsReq);
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x000A7780 File Offset: 0x000A5980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightTreasureDungeonMonsterCsReq other)
		{
			return other != null && (other == this || (this.NCFAJPAMBGD == other.NCFAJPAMBGD && this.avatarList_.Equals(other.avatarList_) && this.EEEABJCNKDO == other.EEEABJCNKDO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x000A77E0 File Offset: 0x000A59E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.EEEABJCNKDO != 0U)
			{
				num ^= this.EEEABJCNKDO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x000A7846 File Offset: 0x000A5A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x000A784E File Offset: 0x000A5A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x000A7858 File Offset: 0x000A5A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, FightTreasureDungeonMonsterCsReq._repeated_avatarList_codec);
			if (this.EEEABJCNKDO != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.EEEABJCNKDO);
			}
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x000A78C4 File Offset: 0x000A5AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			num += this.avatarList_.CalculateSize(FightTreasureDungeonMonsterCsReq._repeated_avatarList_codec);
			if (this.EEEABJCNKDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EEEABJCNKDO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x000A7930 File Offset: 0x000A5B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightTreasureDungeonMonsterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.EEEABJCNKDO != 0U)
			{
				this.EEEABJCNKDO = other.EEEABJCNKDO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x000A7991 File Offset: 0x000A5B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x000A799C File Offset: 0x000A5B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 56U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NCFAJPAMBGD = input.ReadUInt32();
						}
					}
					else
					{
						this.EEEABJCNKDO = input.ReadUInt32();
					}
				}
				else
				{
					this.avatarList_.AddEntriesFrom(ref input, FightTreasureDungeonMonsterCsReq._repeated_avatarList_codec);
				}
			}
		}

		// Token: 0x0400187A RID: 6266
		private static readonly MessageParser<FightTreasureDungeonMonsterCsReq> _parser = new MessageParser<FightTreasureDungeonMonsterCsReq>(() => new FightTreasureDungeonMonsterCsReq());

		// Token: 0x0400187B RID: 6267
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400187C RID: 6268
		public const int NCFAJPAMBGDFieldNumber = 9;

		// Token: 0x0400187D RID: 6269
		private uint nCFAJPAMBGD_;

		// Token: 0x0400187E RID: 6270
		public const int AvatarListFieldNumber = 2;

		// Token: 0x0400187F RID: 6271
		private static readonly FieldCodec<TreasureDungeonAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<TreasureDungeonAvatar>(18U, TreasureDungeonAvatar.Parser);

		// Token: 0x04001880 RID: 6272
		private readonly RepeatedField<TreasureDungeonAvatar> avatarList_ = new RepeatedField<TreasureDungeonAvatar>();

		// Token: 0x04001881 RID: 6273
		public const int EEEABJCNKDOFieldNumber = 7;

		// Token: 0x04001882 RID: 6274
		private uint eEEABJCNKDO_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000497 RID: 1175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Equipment : IMessage<Equipment>, IMessage, IEquatable<Equipment>, IDeepCloneable<Equipment>, IBufferMessage
	{
		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x0008F78F File Offset: 0x0008D98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Equipment> Parser
		{
			get
			{
				return Equipment._parser;
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x0008F796 File Offset: 0x0008D996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EquipmentReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x0008F7A8 File Offset: 0x0008D9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Equipment.Descriptor;
			}
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x0008F7AF File Offset: 0x0008D9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Equipment()
		{
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x0008F7B8 File Offset: 0x0008D9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Equipment(Equipment other) : this()
		{
			this.rank_ = other.rank_;
			this.promotion_ = other.promotion_;
			this.tid_ = other.tid_;
			this.dressAvatarId_ = other.dressAvatarId_;
			this.exp_ = other.exp_;
			this.uniqueId_ = other.uniqueId_;
			this.level_ = other.level_;
			this.isProtected_ = other.isProtected_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x0008F83C File Offset: 0x0008DA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Equipment Clone()
		{
			return new Equipment(this);
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x0008F844 File Offset: 0x0008DA44
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x0008F84C File Offset: 0x0008DA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x0008F855 File Offset: 0x0008DA55
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x0008F85D File Offset: 0x0008DA5D
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

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x0008F866 File Offset: 0x0008DA66
		// (set) Token: 0x06003452 RID: 13394 RVA: 0x0008F86E File Offset: 0x0008DA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tid
		{
			get
			{
				return this.tid_;
			}
			set
			{
				this.tid_ = value;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x0008F877 File Offset: 0x0008DA77
		// (set) Token: 0x06003454 RID: 13396 RVA: 0x0008F87F File Offset: 0x0008DA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DressAvatarId
		{
			get
			{
				return this.dressAvatarId_;
			}
			set
			{
				this.dressAvatarId_ = value;
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x0008F888 File Offset: 0x0008DA88
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x0008F890 File Offset: 0x0008DA90
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

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x0008F899 File Offset: 0x0008DA99
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x0008F8A1 File Offset: 0x0008DAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x0008F8AA File Offset: 0x0008DAAA
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x0008F8B2 File Offset: 0x0008DAB2
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

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x0008F8BB File Offset: 0x0008DABB
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x0008F8C3 File Offset: 0x0008DAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsProtected
		{
			get
			{
				return this.isProtected_;
			}
			set
			{
				this.isProtected_ = value;
			}
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x0008F8CC File Offset: 0x0008DACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Equipment);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x0008F8DC File Offset: 0x0008DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Equipment other)
		{
			return other != null && (other == this || (this.Rank == other.Rank && this.Promotion == other.Promotion && this.Tid == other.Tid && this.DressAvatarId == other.DressAvatarId && this.Exp == other.Exp && this.UniqueId == other.UniqueId && this.Level == other.Level && this.IsProtected == other.IsProtected && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x0008F988 File Offset: 0x0008DB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this.DressAvatarId != 0U)
			{
				num ^= this.DressAvatarId.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.IsProtected)
			{
				num ^= this.IsProtected.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x0008FA76 File Offset: 0x0008DC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x0008FA7E File Offset: 0x0008DC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x0008FA88 File Offset: 0x0008DC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Level);
			}
			if (this.IsProtected)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsProtected);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Rank);
			}
			if (this.DressAvatarId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DressAvatarId);
			}
			if (this.Tid != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Tid);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Exp);
			}
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.UniqueId);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Promotion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x0008FB88 File Offset: 0x0008DD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this.DressAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DressAvatarId);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.IsProtected)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x0008FC64 File Offset: 0x0008DE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Equipment other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			if (other.DressAvatarId != 0U)
			{
				this.DressAvatarId = other.DressAvatarId;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.IsProtected)
			{
				this.IsProtected = other.IsProtected;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x0008FD2C File Offset: 0x0008DF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x0008FD38 File Offset: 0x0008DF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
						if (num == 24U)
						{
							this.IsProtected = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Rank = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.DressAvatarId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.Tid = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.UniqueId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040014BC RID: 5308
		private static readonly MessageParser<Equipment> _parser = new MessageParser<Equipment>(() => new Equipment());

		// Token: 0x040014BD RID: 5309
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014BE RID: 5310
		public const int RankFieldNumber = 4;

		// Token: 0x040014BF RID: 5311
		private uint rank_;

		// Token: 0x040014C0 RID: 5312
		public const int PromotionFieldNumber = 12;

		// Token: 0x040014C1 RID: 5313
		private uint promotion_;

		// Token: 0x040014C2 RID: 5314
		public const int TidFieldNumber = 7;

		// Token: 0x040014C3 RID: 5315
		private uint tid_;

		// Token: 0x040014C4 RID: 5316
		public const int DressAvatarIdFieldNumber = 6;

		// Token: 0x040014C5 RID: 5317
		private uint dressAvatarId_;

		// Token: 0x040014C6 RID: 5318
		public const int ExpFieldNumber = 8;

		// Token: 0x040014C7 RID: 5319
		private uint exp_;

		// Token: 0x040014C8 RID: 5320
		public const int UniqueIdFieldNumber = 11;

		// Token: 0x040014C9 RID: 5321
		private uint uniqueId_;

		// Token: 0x040014CA RID: 5322
		public const int LevelFieldNumber = 1;

		// Token: 0x040014CB RID: 5323
		private uint level_;

		// Token: 0x040014CC RID: 5324
		public const int IsProtectedFieldNumber = 3;

		// Token: 0x040014CD RID: 5325
		private bool isProtected_;
	}
}

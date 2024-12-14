using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000499 RID: 1177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EquipmentProperty : IMessage<EquipmentProperty>, IMessage, IEquatable<EquipmentProperty>, IDeepCloneable<EquipmentProperty>, IBufferMessage
	{
		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x0008FEC1 File Offset: 0x0008E0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EquipmentProperty> Parser
		{
			get
			{
				return EquipmentProperty._parser;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x0008FEC8 File Offset: 0x0008E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EquipmentPropertyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x0008FEDA File Offset: 0x0008E0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipmentProperty.Descriptor;
			}
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x0008FEE1 File Offset: 0x0008E0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipmentProperty()
		{
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x0008FEEC File Offset: 0x0008E0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipmentProperty(EquipmentProperty other) : this()
		{
			this.id_ = other.id_;
			this.rank_ = other.rank_;
			this.promotion_ = other.promotion_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x0008FF40 File Offset: 0x0008E140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipmentProperty Clone()
		{
			return new EquipmentProperty(this);
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x0008FF48 File Offset: 0x0008E148
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x0008FF50 File Offset: 0x0008E150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06003472 RID: 13426 RVA: 0x0008FF59 File Offset: 0x0008E159
		// (set) Token: 0x06003473 RID: 13427 RVA: 0x0008FF61 File Offset: 0x0008E161
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

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x0008FF6A File Offset: 0x0008E16A
		// (set) Token: 0x06003475 RID: 13429 RVA: 0x0008FF72 File Offset: 0x0008E172
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

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x0008FF7B File Offset: 0x0008E17B
		// (set) Token: 0x06003477 RID: 13431 RVA: 0x0008FF83 File Offset: 0x0008E183
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

		// Token: 0x06003478 RID: 13432 RVA: 0x0008FF8C File Offset: 0x0008E18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipmentProperty);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x0008FF9C File Offset: 0x0008E19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipmentProperty other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Rank == other.Rank && this.Promotion == other.Promotion && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00090008 File Offset: 0x0008E208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00090092 File Offset: 0x0008E292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x0009009A File Offset: 0x0008E29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000900A4 File Offset: 0x0008E2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Rank);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Promotion);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00090134 File Offset: 0x0008E334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x000901BC File Offset: 0x0008E3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipmentProperty other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00090234 File Offset: 0x0008E434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00090240 File Offset: 0x0008E440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Rank = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040014CF RID: 5327
		private static readonly MessageParser<EquipmentProperty> _parser = new MessageParser<EquipmentProperty>(() => new EquipmentProperty());

		// Token: 0x040014D0 RID: 5328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014D1 RID: 5329
		public const int IdFieldNumber = 1;

		// Token: 0x040014D2 RID: 5330
		private uint id_;

		// Token: 0x040014D3 RID: 5331
		public const int RankFieldNumber = 2;

		// Token: 0x040014D4 RID: 5332
		private uint rank_;

		// Token: 0x040014D5 RID: 5333
		public const int PromotionFieldNumber = 3;

		// Token: 0x040014D6 RID: 5334
		private uint promotion_;

		// Token: 0x040014D7 RID: 5335
		public const int LevelFieldNumber = 4;

		// Token: 0x040014D8 RID: 5336
		private uint level_;
	}
}

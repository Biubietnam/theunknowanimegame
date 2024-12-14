using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003B1 RID: 945
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DisplayEquipmentInfo : IMessage<DisplayEquipmentInfo>, IMessage, IEquatable<DisplayEquipmentInfo>, IDeepCloneable<DisplayEquipmentInfo>, IBufferMessage
	{
		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x00074E65 File Offset: 0x00073065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DisplayEquipmentInfo> Parser
		{
			get
			{
				return DisplayEquipmentInfo._parser;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x00074E6C File Offset: 0x0007306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DisplayEquipmentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x00074E7E File Offset: 0x0007307E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisplayEquipmentInfo.Descriptor;
			}
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00074E85 File Offset: 0x00073085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayEquipmentInfo()
		{
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00074E90 File Offset: 0x00073090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayEquipmentInfo(DisplayEquipmentInfo other) : this()
		{
			this.tid_ = other.tid_;
			this.rank_ = other.rank_;
			this.exp_ = other.exp_;
			this.promotion_ = other.promotion_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00074EF0 File Offset: 0x000730F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayEquipmentInfo Clone()
		{
			return new DisplayEquipmentInfo(this);
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x00074EF8 File Offset: 0x000730F8
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x00074F00 File Offset: 0x00073100
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

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x00074F09 File Offset: 0x00073109
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x00074F11 File Offset: 0x00073111
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

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x00074F1A File Offset: 0x0007311A
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x00074F22 File Offset: 0x00073122
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

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x00074F2B File Offset: 0x0007312B
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x00074F33 File Offset: 0x00073133
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

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x00074F3C File Offset: 0x0007313C
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x00074F44 File Offset: 0x00073144
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

		// Token: 0x06002A15 RID: 10773 RVA: 0x00074F4D File Offset: 0x0007314D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DisplayEquipmentInfo);
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00074F5C File Offset: 0x0007315C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DisplayEquipmentInfo other)
		{
			return other != null && (other == this || (this.Tid == other.Tid && this.Rank == other.Rank && this.Exp == other.Exp && this.Promotion == other.Promotion && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x00074FD8 File Offset: 0x000731D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
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

		// Token: 0x06002A18 RID: 10776 RVA: 0x0007507B File Offset: 0x0007327B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00075083 File Offset: 0x00073283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0007508C File Offset: 0x0007328C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Exp);
			}
			if (this.Tid != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Tid);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Promotion);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Rank);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x0007513C File Offset: 0x0007333C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
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

		// Token: 0x06002A1C RID: 10780 RVA: 0x000751DC File Offset: 0x000733DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DisplayEquipmentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
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

		// Token: 0x06002A1D RID: 10781 RVA: 0x00075268 File Offset: 0x00073468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00075274 File Offset: 0x00073474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Tid = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Rank = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040010F9 RID: 4345
		private static readonly MessageParser<DisplayEquipmentInfo> _parser = new MessageParser<DisplayEquipmentInfo>(() => new DisplayEquipmentInfo());

		// Token: 0x040010FA RID: 4346
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010FB RID: 4347
		public const int TidFieldNumber = 7;

		// Token: 0x040010FC RID: 4348
		private uint tid_;

		// Token: 0x040010FD RID: 4349
		public const int RankFieldNumber = 12;

		// Token: 0x040010FE RID: 4350
		private uint rank_;

		// Token: 0x040010FF RID: 4351
		public const int ExpFieldNumber = 2;

		// Token: 0x04001100 RID: 4352
		private uint exp_;

		// Token: 0x04001101 RID: 4353
		public const int PromotionFieldNumber = 8;

		// Token: 0x04001102 RID: 4354
		private uint promotion_;

		// Token: 0x04001103 RID: 4355
		public const int LevelFieldNumber = 10;

		// Token: 0x04001104 RID: 4356
		private uint level_;
	}
}

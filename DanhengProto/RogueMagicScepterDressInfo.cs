using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F03 RID: 3843
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterDressInfo : IMessage<RogueMagicScepterDressInfo>, IMessage, IEquatable<RogueMagicScepterDressInfo>, IDeepCloneable<RogueMagicScepterDressInfo>, IBufferMessage
	{
		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0600AB92 RID: 43922 RVA: 0x001CE1C1 File Offset: 0x001CC3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterDressInfo> Parser
		{
			get
			{
				return RogueMagicScepterDressInfo._parser;
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0600AB93 RID: 43923 RVA: 0x001CE1C8 File Offset: 0x001CC3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterDressInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0600AB94 RID: 43924 RVA: 0x001CE1DA File Offset: 0x001CC3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterDressInfo.Descriptor;
			}
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x001CE1E1 File Offset: 0x001CC3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInfo()
		{
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x001CE1E9 File Offset: 0x001CC3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInfo(RogueMagicScepterDressInfo other) : this()
		{
			this.type_ = other.type_;
			this.slot_ = other.slot_;
			this.dressMagicUnitUniqueId_ = other.dressMagicUnitUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x001CE226 File Offset: 0x001CC426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInfo Clone()
		{
			return new RogueMagicScepterDressInfo(this);
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0600AB98 RID: 43928 RVA: 0x001CE22E File Offset: 0x001CC42E
		// (set) Token: 0x0600AB99 RID: 43929 RVA: 0x001CE236 File Offset: 0x001CC436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0600AB9A RID: 43930 RVA: 0x001CE23F File Offset: 0x001CC43F
		// (set) Token: 0x0600AB9B RID: 43931 RVA: 0x001CE247 File Offset: 0x001CC447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0600AB9C RID: 43932 RVA: 0x001CE250 File Offset: 0x001CC450
		// (set) Token: 0x0600AB9D RID: 43933 RVA: 0x001CE258 File Offset: 0x001CC458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DressMagicUnitUniqueId
		{
			get
			{
				return this.dressMagicUnitUniqueId_;
			}
			set
			{
				this.dressMagicUnitUniqueId_ = value;
			}
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x001CE261 File Offset: 0x001CC461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterDressInfo);
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x001CE270 File Offset: 0x001CC470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterDressInfo other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Slot == other.Slot && this.DressMagicUnitUniqueId == other.DressMagicUnitUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x001CE2CC File Offset: 0x001CC4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != 0U)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.DressMagicUnitUniqueId != 0U)
			{
				num ^= this.DressMagicUnitUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x001CE33D File Offset: 0x001CC53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ABA2 RID: 43938 RVA: 0x001CE345 File Offset: 0x001CC545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABA3 RID: 43939 RVA: 0x001CE350 File Offset: 0x001CC550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Type);
			}
			if (this.Slot != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Slot);
			}
			if (this.DressMagicUnitUniqueId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.DressMagicUnitUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x001CE3C8 File Offset: 0x001CC5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
			}
			if (this.DressMagicUnitUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DressMagicUnitUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABA5 RID: 43941 RVA: 0x001CE438 File Offset: 0x001CC638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterDressInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != 0U)
			{
				this.Type = other.Type;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			if (other.DressMagicUnitUniqueId != 0U)
			{
				this.DressMagicUnitUniqueId = other.DressMagicUnitUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x001CE49C File Offset: 0x001CC69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x001CE4A8 File Offset: 0x001CC6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 72U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DressMagicUnitUniqueId = input.ReadUInt32();
						}
					}
					else
					{
						this.Slot = input.ReadUInt32();
					}
				}
				else
				{
					this.Type = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004604 RID: 17924
		private static readonly MessageParser<RogueMagicScepterDressInfo> _parser = new MessageParser<RogueMagicScepterDressInfo>(() => new RogueMagicScepterDressInfo());

		// Token: 0x04004605 RID: 17925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004606 RID: 17926
		public const int TypeFieldNumber = 2;

		// Token: 0x04004607 RID: 17927
		private uint type_;

		// Token: 0x04004608 RID: 17928
		public const int SlotFieldNumber = 9;

		// Token: 0x04004609 RID: 17929
		private uint slot_;

		// Token: 0x0400460A RID: 17930
		public const int DressMagicUnitUniqueIdFieldNumber = 10;

		// Token: 0x0400460B RID: 17931
		private uint dressMagicUnitUniqueId_;
	}
}

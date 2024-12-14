using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000493 RID: 1171
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EquipAetherDividePassiveSkillCsReq : IMessage<EquipAetherDividePassiveSkillCsReq>, IMessage, IEquatable<EquipAetherDividePassiveSkillCsReq>, IDeepCloneable<EquipAetherDividePassiveSkillCsReq>, IBufferMessage
	{
		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06003415 RID: 13333 RVA: 0x0008EEAD File Offset: 0x0008D0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EquipAetherDividePassiveSkillCsReq> Parser
		{
			get
			{
				return EquipAetherDividePassiveSkillCsReq._parser;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x0008EEB4 File Offset: 0x0008D0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EquipAetherDividePassiveSkillCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x0008EEC6 File Offset: 0x0008D0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipAetherDividePassiveSkillCsReq.Descriptor;
			}
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x0008EECD File Offset: 0x0008D0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipAetherDividePassiveSkillCsReq()
		{
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x0008EED5 File Offset: 0x0008D0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipAetherDividePassiveSkillCsReq(EquipAetherDividePassiveSkillCsReq other) : this()
		{
			this.slot_ = other.slot_;
			this.aetherAvatarId_ = other.aetherAvatarId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x0008EF12 File Offset: 0x0008D112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipAetherDividePassiveSkillCsReq Clone()
		{
			return new EquipAetherDividePassiveSkillCsReq(this);
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x0008EF1A File Offset: 0x0008D11A
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x0008EF22 File Offset: 0x0008D122
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

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x0008EF2B File Offset: 0x0008D12B
		// (set) Token: 0x0600341E RID: 13342 RVA: 0x0008EF33 File Offset: 0x0008D133
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

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x0008EF3C File Offset: 0x0008D13C
		// (set) Token: 0x06003420 RID: 13344 RVA: 0x0008EF44 File Offset: 0x0008D144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x0008EF4D File Offset: 0x0008D14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipAetherDividePassiveSkillCsReq);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x0008EF5C File Offset: 0x0008D15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipAetherDividePassiveSkillCsReq other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && this.AetherAvatarId == other.AetherAvatarId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x0008EFB8 File Offset: 0x0008D1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.AetherAvatarId != 0U)
			{
				num ^= this.AetherAvatarId.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x0008F029 File Offset: 0x0008D229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x0008F031 File Offset: 0x0008D231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x0008F03C File Offset: 0x0008D23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Slot);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ItemId);
			}
			if (this.AetherAvatarId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.AetherAvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x0008F0B4 File Offset: 0x0008D2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
			}
			if (this.AetherAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AetherAvatarId);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x0008F124 File Offset: 0x0008D324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipAetherDividePassiveSkillCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			if (other.AetherAvatarId != 0U)
			{
				this.AetherAvatarId = other.AetherAvatarId;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x0008F188 File Offset: 0x0008D388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x0008F194 File Offset: 0x0008D394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AetherAvatarId = input.ReadUInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadUInt32();
					}
				}
				else
				{
					this.Slot = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040014AA RID: 5290
		private static readonly MessageParser<EquipAetherDividePassiveSkillCsReq> _parser = new MessageParser<EquipAetherDividePassiveSkillCsReq>(() => new EquipAetherDividePassiveSkillCsReq());

		// Token: 0x040014AB RID: 5291
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014AC RID: 5292
		public const int SlotFieldNumber = 6;

		// Token: 0x040014AD RID: 5293
		private uint slot_;

		// Token: 0x040014AE RID: 5294
		public const int AetherAvatarIdFieldNumber = 14;

		// Token: 0x040014AF RID: 5295
		private uint aetherAvatarId_;

		// Token: 0x040014B0 RID: 5296
		public const int ItemIdFieldNumber = 10;

		// Token: 0x040014B1 RID: 5297
		private uint itemId_;
	}
}

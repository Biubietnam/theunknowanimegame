using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C7F RID: 3199
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PassiveSkillItem : IMessage<PassiveSkillItem>, IMessage, IEquatable<PassiveSkillItem>, IDeepCloneable<PassiveSkillItem>, IBufferMessage
	{
		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x06008E2A RID: 36394 RVA: 0x001779B0 File Offset: 0x00175BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PassiveSkillItem> Parser
		{
			get
			{
				return PassiveSkillItem._parser;
			}
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x06008E2B RID: 36395 RVA: 0x001779B7 File Offset: 0x00175BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PassiveSkillItemReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x06008E2C RID: 36396 RVA: 0x001779C9 File Offset: 0x00175BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillItem.Descriptor;
			}
		}

		// Token: 0x06008E2D RID: 36397 RVA: 0x001779D0 File Offset: 0x00175BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItem()
		{
		}

		// Token: 0x06008E2E RID: 36398 RVA: 0x001779D8 File Offset: 0x00175BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItem(PassiveSkillItem other) : this()
		{
			this.slot_ = other.slot_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E2F RID: 36399 RVA: 0x00177A09 File Offset: 0x00175C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItem Clone()
		{
			return new PassiveSkillItem(this);
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x06008E30 RID: 36400 RVA: 0x00177A11 File Offset: 0x00175C11
		// (set) Token: 0x06008E31 RID: 36401 RVA: 0x00177A19 File Offset: 0x00175C19
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

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x06008E32 RID: 36402 RVA: 0x00177A22 File Offset: 0x00175C22
		// (set) Token: 0x06008E33 RID: 36403 RVA: 0x00177A2A File Offset: 0x00175C2A
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

		// Token: 0x06008E34 RID: 36404 RVA: 0x00177A33 File Offset: 0x00175C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillItem);
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x00177A41 File Offset: 0x00175C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillItem other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E36 RID: 36406 RVA: 0x00177A80 File Offset: 0x00175C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
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

		// Token: 0x06008E37 RID: 36407 RVA: 0x00177AD8 File Offset: 0x00175CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E38 RID: 36408 RVA: 0x00177AE0 File Offset: 0x00175CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E39 RID: 36409 RVA: 0x00177AEC File Offset: 0x00175CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Slot);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E3A RID: 36410 RVA: 0x00177B48 File Offset: 0x00175D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
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

		// Token: 0x06008E3B RID: 36411 RVA: 0x00177BA0 File Offset: 0x00175DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x00177BF0 File Offset: 0x00175DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x00177BFC File Offset: 0x00175DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04003692 RID: 13970
		private static readonly MessageParser<PassiveSkillItem> _parser = new MessageParser<PassiveSkillItem>(() => new PassiveSkillItem());

		// Token: 0x04003693 RID: 13971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003694 RID: 13972
		public const int SlotFieldNumber = 4;

		// Token: 0x04003695 RID: 13973
		private uint slot_;

		// Token: 0x04003696 RID: 13974
		public const int ItemIdFieldNumber = 10;

		// Token: 0x04003697 RID: 13975
		private uint itemId_;
	}
}

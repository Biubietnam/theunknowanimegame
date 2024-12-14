using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200049B RID: 1179
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EquipRelic : IMessage<EquipRelic>, IMessage, IEquatable<EquipRelic>, IDeepCloneable<EquipRelic>, IBufferMessage
	{
		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x00090354 File Offset: 0x0008E554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EquipRelic> Parser
		{
			get
			{
				return EquipRelic._parser;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x0009035B File Offset: 0x0008E55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EquipRelicReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06003487 RID: 13447 RVA: 0x0009036D File Offset: 0x0008E56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipRelic.Descriptor;
			}
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00090374 File Offset: 0x0008E574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipRelic()
		{
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x0009037C File Offset: 0x0008E57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipRelic(EquipRelic other) : this()
		{
			this.type_ = other.type_;
			this.relicUniqueId_ = other.relicUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x000903AD File Offset: 0x0008E5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipRelic Clone()
		{
			return new EquipRelic(this);
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x000903B5 File Offset: 0x0008E5B5
		// (set) Token: 0x0600348C RID: 13452 RVA: 0x000903BD File Offset: 0x0008E5BD
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

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x000903C6 File Offset: 0x0008E5C6
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x000903CE File Offset: 0x0008E5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RelicUniqueId
		{
			get
			{
				return this.relicUniqueId_;
			}
			set
			{
				this.relicUniqueId_ = value;
			}
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x000903D7 File Offset: 0x0008E5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipRelic);
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x000903E5 File Offset: 0x0008E5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipRelic other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.RelicUniqueId == other.RelicUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00090424 File Offset: 0x0008E624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != 0U)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.RelicUniqueId != 0U)
			{
				num ^= this.RelicUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x0009047C File Offset: 0x0008E67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00090484 File Offset: 0x0008E684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00090490 File Offset: 0x0008E690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Type);
			}
			if (this.RelicUniqueId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.RelicUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x000904EC File Offset: 0x0008E6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			if (this.RelicUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RelicUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00090544 File Offset: 0x0008E744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipRelic other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != 0U)
			{
				this.Type = other.Type;
			}
			if (other.RelicUniqueId != 0U)
			{
				this.RelicUniqueId = other.RelicUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00090594 File Offset: 0x0008E794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x000905A0 File Offset: 0x0008E7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RelicUniqueId = input.ReadUInt32();
					}
				}
				else
				{
					this.Type = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040014DA RID: 5338
		private static readonly MessageParser<EquipRelic> _parser = new MessageParser<EquipRelic>(() => new EquipRelic());

		// Token: 0x040014DB RID: 5339
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014DC RID: 5340
		public const int TypeFieldNumber = 2;

		// Token: 0x040014DD RID: 5341
		private uint type_;

		// Token: 0x040014DE RID: 5342
		public const int RelicUniqueIdFieldNumber = 6;

		// Token: 0x040014DF RID: 5343
		private uint relicUniqueId_;
	}
}

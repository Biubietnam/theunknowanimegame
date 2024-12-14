using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000583 RID: 1411
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishItemIdCsReq : IMessage<FinishItemIdCsReq>, IMessage, IEquatable<FinishItemIdCsReq>, IDeepCloneable<FinishItemIdCsReq>, IBufferMessage
	{
		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06003EF5 RID: 16117 RVA: 0x000ABF08 File Offset: 0x000AA108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishItemIdCsReq> Parser
		{
			get
			{
				return FinishItemIdCsReq._parser;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x000ABF0F File Offset: 0x000AA10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishItemIdCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x000ABF21 File Offset: 0x000AA121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishItemIdCsReq.Descriptor;
			}
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x000ABF28 File Offset: 0x000AA128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishItemIdCsReq()
		{
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x000ABF30 File Offset: 0x000AA130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishItemIdCsReq(FinishItemIdCsReq other) : this()
		{
			this.itemId_ = other.itemId_;
			this.textId_ = other.textId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x000ABF61 File Offset: 0x000AA161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishItemIdCsReq Clone()
		{
			return new FinishItemIdCsReq(this);
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06003EFB RID: 16123 RVA: 0x000ABF69 File Offset: 0x000AA169
		// (set) Token: 0x06003EFC RID: 16124 RVA: 0x000ABF71 File Offset: 0x000AA171
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

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x000ABF7A File Offset: 0x000AA17A
		// (set) Token: 0x06003EFE RID: 16126 RVA: 0x000ABF82 File Offset: 0x000AA182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextId
		{
			get
			{
				return this.textId_;
			}
			set
			{
				this.textId_ = value;
			}
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x000ABF8B File Offset: 0x000AA18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishItemIdCsReq);
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x000ABF99 File Offset: 0x000AA199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishItemIdCsReq other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.TextId == other.TextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x000ABFD8 File Offset: 0x000AA1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.TextId != 0U)
			{
				num ^= this.TextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x000AC030 File Offset: 0x000AA230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x000AC038 File Offset: 0x000AA238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x000AC044 File Offset: 0x000AA244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TextId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.TextId);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x000AC0A0 File Offset: 0x000AA2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.TextId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x000AC0F8 File Offset: 0x000AA2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishItemIdCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.TextId != 0U)
			{
				this.TextId = other.TextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x000AC148 File Offset: 0x000AA348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x000AC154 File Offset: 0x000AA354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 96U)
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
					this.TextId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001916 RID: 6422
		private static readonly MessageParser<FinishItemIdCsReq> _parser = new MessageParser<FinishItemIdCsReq>(() => new FinishItemIdCsReq());

		// Token: 0x04001917 RID: 6423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001918 RID: 6424
		public const int ItemIdFieldNumber = 12;

		// Token: 0x04001919 RID: 6425
		private uint itemId_;

		// Token: 0x0400191A RID: 6426
		public const int TextIdFieldNumber = 10;

		// Token: 0x0400191B RID: 6427
		private uint textId_;
	}
}

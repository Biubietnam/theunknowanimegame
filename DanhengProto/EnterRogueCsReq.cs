using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000453 RID: 1107
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterRogueCsReq : IMessage<EnterRogueCsReq>, IMessage, IEquatable<EnterRogueCsReq>, IDeepCloneable<EnterRogueCsReq>, IBufferMessage
	{
		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x000877D8 File Offset: 0x000859D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterRogueCsReq> Parser
		{
			get
			{
				return EnterRogueCsReq._parser;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x000877DF File Offset: 0x000859DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterRogueCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x000877F1 File Offset: 0x000859F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterRogueCsReq.Descriptor;
			}
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x000877F8 File Offset: 0x000859F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueCsReq()
		{
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x00087800 File Offset: 0x00085A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueCsReq(EnterRogueCsReq other) : this()
		{
			this.areaId_ = other.areaId_;
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x00087831 File Offset: 0x00085A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueCsReq Clone()
		{
			return new EnterRogueCsReq(this);
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x00087839 File Offset: 0x00085A39
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x00087841 File Offset: 0x00085A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x0008784A File Offset: 0x00085A4A
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x00087852 File Offset: 0x00085A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x0008785B File Offset: 0x00085A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterRogueCsReq);
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x00087869 File Offset: 0x00085A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterRogueCsReq other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000878A8 File Offset: 0x00085AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x00087900 File Offset: 0x00085B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x00087908 File Offset: 0x00085B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x00087914 File Offset: 0x00085B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.AreaId);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x00087970 File Offset: 0x00085B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000879C8 File Offset: 0x00085BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterRogueCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00087A18 File Offset: 0x00085C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x00087A24 File Offset: 0x00085C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractedPropEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040013A0 RID: 5024
		private static readonly MessageParser<EnterRogueCsReq> _parser = new MessageParser<EnterRogueCsReq>(() => new EnterRogueCsReq());

		// Token: 0x040013A1 RID: 5025
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013A2 RID: 5026
		public const int AreaIdFieldNumber = 12;

		// Token: 0x040013A3 RID: 5027
		private uint areaId_;

		// Token: 0x040013A4 RID: 5028
		public const int InteractedPropEntityIdFieldNumber = 15;

		// Token: 0x040013A5 RID: 5029
		private uint interactedPropEntityId_;
	}
}

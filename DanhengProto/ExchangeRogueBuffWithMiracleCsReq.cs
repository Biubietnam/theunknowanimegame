using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004DB RID: 1243
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeRogueBuffWithMiracleCsReq : IMessage<ExchangeRogueBuffWithMiracleCsReq>, IMessage, IEquatable<ExchangeRogueBuffWithMiracleCsReq>, IDeepCloneable<ExchangeRogueBuffWithMiracleCsReq>, IBufferMessage
	{
		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x000987DD File Offset: 0x000969DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeRogueBuffWithMiracleCsReq> Parser
		{
			get
			{
				return ExchangeRogueBuffWithMiracleCsReq._parser;
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06003797 RID: 14231 RVA: 0x000987E4 File Offset: 0x000969E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeRogueBuffWithMiracleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x000987F6 File Offset: 0x000969F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRogueBuffWithMiracleCsReq.Descriptor;
			}
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x000987FD File Offset: 0x000969FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueBuffWithMiracleCsReq()
		{
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00098805 File Offset: 0x00096A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueBuffWithMiracleCsReq(ExchangeRogueBuffWithMiracleCsReq other) : this()
		{
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this.miracleId_ = other.miracleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00098836 File Offset: 0x00096A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueBuffWithMiracleCsReq Clone()
		{
			return new ExchangeRogueBuffWithMiracleCsReq(this);
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x0009883E File Offset: 0x00096A3E
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x00098846 File Offset: 0x00096A46
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

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x0009884F File Offset: 0x00096A4F
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x00098857 File Offset: 0x00096A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleId
		{
			get
			{
				return this.miracleId_;
			}
			set
			{
				this.miracleId_ = value;
			}
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00098860 File Offset: 0x00096A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRogueBuffWithMiracleCsReq);
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0009886E File Offset: 0x00096A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRogueBuffWithMiracleCsReq other)
		{
			return other != null && (other == this || (this.InteractedPropEntityId == other.InteractedPropEntityId && this.MiracleId == other.MiracleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x000988AC File Offset: 0x00096AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this.MiracleId != 0U)
			{
				num ^= this.MiracleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00098904 File Offset: 0x00096B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x0009890C File Offset: 0x00096B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00098918 File Offset: 0x00096B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this.MiracleId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MiracleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00098970 File Offset: 0x00096B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this.MiracleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x000989C8 File Offset: 0x00096BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeRogueBuffWithMiracleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			if (other.MiracleId != 0U)
			{
				this.MiracleId = other.MiracleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00098A18 File Offset: 0x00096C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00098A24 File Offset: 0x00096C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MiracleId = input.ReadUInt32();
					}
				}
				else
				{
					this.InteractedPropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001605 RID: 5637
		private static readonly MessageParser<ExchangeRogueBuffWithMiracleCsReq> _parser = new MessageParser<ExchangeRogueBuffWithMiracleCsReq>(() => new ExchangeRogueBuffWithMiracleCsReq());

		// Token: 0x04001606 RID: 5638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001607 RID: 5639
		public const int InteractedPropEntityIdFieldNumber = 1;

		// Token: 0x04001608 RID: 5640
		private uint interactedPropEntityId_;

		// Token: 0x04001609 RID: 5641
		public const int MiracleIdFieldNumber = 14;

		// Token: 0x0400160A RID: 5642
		private uint miracleId_;
	}
}

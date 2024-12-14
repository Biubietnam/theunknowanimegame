using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F15 RID: 3861
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicSetAutoDressInMagicUnitCsReq : IMessage<RogueMagicSetAutoDressInMagicUnitCsReq>, IMessage, IEquatable<RogueMagicSetAutoDressInMagicUnitCsReq>, IDeepCloneable<RogueMagicSetAutoDressInMagicUnitCsReq>, IBufferMessage
	{
		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x0600AC59 RID: 44121 RVA: 0x001CFD61 File Offset: 0x001CDF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicSetAutoDressInMagicUnitCsReq> Parser
		{
			get
			{
				return RogueMagicSetAutoDressInMagicUnitCsReq._parser;
			}
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x001CFD68 File Offset: 0x001CDF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicSetAutoDressInMagicUnitCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0600AC5B RID: 44123 RVA: 0x001CFD7A File Offset: 0x001CDF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicSetAutoDressInMagicUnitCsReq.Descriptor;
			}
		}

		// Token: 0x0600AC5C RID: 44124 RVA: 0x001CFD81 File Offset: 0x001CDF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSetAutoDressInMagicUnitCsReq()
		{
		}

		// Token: 0x0600AC5D RID: 44125 RVA: 0x001CFD89 File Offset: 0x001CDF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSetAutoDressInMagicUnitCsReq(RogueMagicSetAutoDressInMagicUnitCsReq other) : this()
		{
			this.enableAutoDress_ = other.enableAutoDress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x001CFDAE File Offset: 0x001CDFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSetAutoDressInMagicUnitCsReq Clone()
		{
			return new RogueMagicSetAutoDressInMagicUnitCsReq(this);
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0600AC5F RID: 44127 RVA: 0x001CFDB6 File Offset: 0x001CDFB6
		// (set) Token: 0x0600AC60 RID: 44128 RVA: 0x001CFDBE File Offset: 0x001CDFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableAutoDress
		{
			get
			{
				return this.enableAutoDress_;
			}
			set
			{
				this.enableAutoDress_ = value;
			}
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x001CFDC7 File Offset: 0x001CDFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicSetAutoDressInMagicUnitCsReq);
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x001CFDD5 File Offset: 0x001CDFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicSetAutoDressInMagicUnitCsReq other)
		{
			return other != null && (other == this || (this.EnableAutoDress == other.EnableAutoDress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x001CFE04 File Offset: 0x001CE004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EnableAutoDress)
			{
				num ^= this.EnableAutoDress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x001CFE43 File Offset: 0x001CE043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x001CFE4B File Offset: 0x001CE04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC66 RID: 44134 RVA: 0x001CFE54 File Offset: 0x001CE054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnableAutoDress)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.EnableAutoDress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x001CFE88 File Offset: 0x001CE088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EnableAutoDress)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC68 RID: 44136 RVA: 0x001CFEBA File Offset: 0x001CE0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicSetAutoDressInMagicUnitCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnableAutoDress)
			{
				this.EnableAutoDress = other.EnableAutoDress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x001CFEEB File Offset: 0x001CE0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x001CFEF4 File Offset: 0x001CE0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EnableAutoDress = input.ReadBool();
				}
			}
		}

		// Token: 0x0400463F RID: 17983
		private static readonly MessageParser<RogueMagicSetAutoDressInMagicUnitCsReq> _parser = new MessageParser<RogueMagicSetAutoDressInMagicUnitCsReq>(() => new RogueMagicSetAutoDressInMagicUnitCsReq());

		// Token: 0x04004640 RID: 17984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004641 RID: 17985
		public const int EnableAutoDressFieldNumber = 2;

		// Token: 0x04004642 RID: 17986
		private bool enableAutoDress_;
	}
}

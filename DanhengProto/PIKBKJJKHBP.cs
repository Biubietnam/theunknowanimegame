using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C9B RID: 3227
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PIKBKJJKHBP : IMessage<PIKBKJJKHBP>, IMessage, IEquatable<PIKBKJJKHBP>, IDeepCloneable<PIKBKJJKHBP>, IBufferMessage
	{
		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x06008F7F RID: 36735 RVA: 0x0017B414 File Offset: 0x00179614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PIKBKJJKHBP> Parser
		{
			get
			{
				return PIKBKJJKHBP._parser;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x06008F80 RID: 36736 RVA: 0x0017B41B File Offset: 0x0017961B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PIKBKJJKHBPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x06008F81 RID: 36737 RVA: 0x0017B42D File Offset: 0x0017962D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PIKBKJJKHBP.Descriptor;
			}
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x0017B434 File Offset: 0x00179634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PIKBKJJKHBP()
		{
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x0017B43C File Offset: 0x0017963C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PIKBKJJKHBP(PIKBKJJKHBP other) : this()
		{
			this.eventUniqueId_ = other.eventUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x0017B461 File Offset: 0x00179661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PIKBKJJKHBP Clone()
		{
			return new PIKBKJJKHBP(this);
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x06008F85 RID: 36741 RVA: 0x0017B469 File Offset: 0x00179669
		// (set) Token: 0x06008F86 RID: 36742 RVA: 0x0017B471 File Offset: 0x00179671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventUniqueId
		{
			get
			{
				return this.eventUniqueId_;
			}
			set
			{
				this.eventUniqueId_ = value;
			}
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x0017B47A File Offset: 0x0017967A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PIKBKJJKHBP);
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x0017B488 File Offset: 0x00179688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PIKBKJJKHBP other)
		{
			return other != null && (other == this || (this.EventUniqueId == other.EventUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x0017B4B8 File Offset: 0x001796B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x0017B4F7 File Offset: 0x001796F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x0017B4FF File Offset: 0x001796FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x0017B508 File Offset: 0x00179708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x0017B53C File Offset: 0x0017973C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x0017B57A File Offset: 0x0017977A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PIKBKJJKHBP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x0017B5AB File Offset: 0x001797AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x0017B5B4 File Offset: 0x001797B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EventUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003721 RID: 14113
		private static readonly MessageParser<PIKBKJJKHBP> _parser = new MessageParser<PIKBKJJKHBP>(() => new PIKBKJJKHBP());

		// Token: 0x04003722 RID: 14114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003723 RID: 14115
		public const int EventUniqueIdFieldNumber = 11;

		// Token: 0x04003724 RID: 14116
		private uint eventUniqueId_;
	}
}

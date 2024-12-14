using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009E1 RID: 2529
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LastSpringRefreshTimeNotify : IMessage<LastSpringRefreshTimeNotify>, IMessage, IEquatable<LastSpringRefreshTimeNotify>, IDeepCloneable<LastSpringRefreshTimeNotify>, IBufferMessage
	{
		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06007062 RID: 28770 RVA: 0x0012BD14 File Offset: 0x00129F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LastSpringRefreshTimeNotify> Parser
		{
			get
			{
				return LastSpringRefreshTimeNotify._parser;
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06007063 RID: 28771 RVA: 0x0012BD1B File Offset: 0x00129F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LastSpringRefreshTimeNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06007064 RID: 28772 RVA: 0x0012BD2D File Offset: 0x00129F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LastSpringRefreshTimeNotify.Descriptor;
			}
		}

		// Token: 0x06007065 RID: 28773 RVA: 0x0012BD34 File Offset: 0x00129F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastSpringRefreshTimeNotify()
		{
		}

		// Token: 0x06007066 RID: 28774 RVA: 0x0012BD3C File Offset: 0x00129F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastSpringRefreshTimeNotify(LastSpringRefreshTimeNotify other) : this()
		{
			this.nEHONOOHKHP_ = other.nEHONOOHKHP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007067 RID: 28775 RVA: 0x0012BD61 File Offset: 0x00129F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastSpringRefreshTimeNotify Clone()
		{
			return new LastSpringRefreshTimeNotify(this);
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06007068 RID: 28776 RVA: 0x0012BD69 File Offset: 0x00129F69
		// (set) Token: 0x06007069 RID: 28777 RVA: 0x0012BD71 File Offset: 0x00129F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NEHONOOHKHP
		{
			get
			{
				return this.nEHONOOHKHP_;
			}
			set
			{
				this.nEHONOOHKHP_ = value;
			}
		}

		// Token: 0x0600706A RID: 28778 RVA: 0x0012BD7A File Offset: 0x00129F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LastSpringRefreshTimeNotify);
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x0012BD88 File Offset: 0x00129F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LastSpringRefreshTimeNotify other)
		{
			return other != null && (other == this || (this.NEHONOOHKHP == other.NEHONOOHKHP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x0012BDB8 File Offset: 0x00129FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NEHONOOHKHP != 0L)
			{
				num ^= this.NEHONOOHKHP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x0012BDF7 File Offset: 0x00129FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x0012BDFF File Offset: 0x00129FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x0012BE08 File Offset: 0x0012A008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NEHONOOHKHP != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.NEHONOOHKHP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x0012BE3C File Offset: 0x0012A03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NEHONOOHKHP != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NEHONOOHKHP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x0012BE7A File Offset: 0x0012A07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LastSpringRefreshTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NEHONOOHKHP != 0L)
			{
				this.NEHONOOHKHP = other.NEHONOOHKHP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x0012BEAB File Offset: 0x0012A0AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x0012BEB4 File Offset: 0x0012A0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NEHONOOHKHP = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002B59 RID: 11097
		private static readonly MessageParser<LastSpringRefreshTimeNotify> _parser = new MessageParser<LastSpringRefreshTimeNotify>(() => new LastSpringRefreshTimeNotify());

		// Token: 0x04002B5A RID: 11098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B5B RID: 11099
		public const int NEHONOOHKHPFieldNumber = 10;

		// Token: 0x04002B5C RID: 11100
		private long nEHONOOHKHP_;
	}
}

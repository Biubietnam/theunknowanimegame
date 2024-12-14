using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D99 RID: 3481
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RegionStopScNotify : IMessage<RegionStopScNotify>, IMessage, IEquatable<RegionStopScNotify>, IDeepCloneable<RegionStopScNotify>, IBufferMessage
	{
		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x06009B7B RID: 39803 RVA: 0x0019DCC9 File Offset: 0x0019BEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RegionStopScNotify> Parser
		{
			get
			{
				return RegionStopScNotify._parser;
			}
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06009B7C RID: 39804 RVA: 0x0019DCD0 File Offset: 0x0019BED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RegionStopScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x06009B7D RID: 39805 RVA: 0x0019DCE2 File Offset: 0x0019BEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegionStopScNotify.Descriptor;
			}
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x0019DCE9 File Offset: 0x0019BEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegionStopScNotify()
		{
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x0019DCF1 File Offset: 0x0019BEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegionStopScNotify(RegionStopScNotify other) : this()
		{
			this.regionStopEnd_ = other.regionStopEnd_;
			this.regionStopStart_ = other.regionStopStart_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x0019DD22 File Offset: 0x0019BF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegionStopScNotify Clone()
		{
			return new RegionStopScNotify(this);
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06009B81 RID: 39809 RVA: 0x0019DD2A File Offset: 0x0019BF2A
		// (set) Token: 0x06009B82 RID: 39810 RVA: 0x0019DD32 File Offset: 0x0019BF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RegionStopEnd
		{
			get
			{
				return this.regionStopEnd_;
			}
			set
			{
				this.regionStopEnd_ = value;
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x06009B83 RID: 39811 RVA: 0x0019DD3B File Offset: 0x0019BF3B
		// (set) Token: 0x06009B84 RID: 39812 RVA: 0x0019DD43 File Offset: 0x0019BF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RegionStopStart
		{
			get
			{
				return this.regionStopStart_;
			}
			set
			{
				this.regionStopStart_ = value;
			}
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x0019DD4C File Offset: 0x0019BF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegionStopScNotify);
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x0019DD5A File Offset: 0x0019BF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegionStopScNotify other)
		{
			return other != null && (other == this || (this.RegionStopEnd == other.RegionStopEnd && this.RegionStopStart == other.RegionStopStart && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B87 RID: 39815 RVA: 0x0019DD98 File Offset: 0x0019BF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RegionStopEnd != 0L)
			{
				num ^= this.RegionStopEnd.GetHashCode();
			}
			if (this.RegionStopStart != 0L)
			{
				num ^= this.RegionStopStart.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B88 RID: 39816 RVA: 0x0019DDF0 File Offset: 0x0019BFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x0019DDF8 File Offset: 0x0019BFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x0019DE04 File Offset: 0x0019C004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RegionStopStart != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.RegionStopStart);
			}
			if (this.RegionStopEnd != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.RegionStopEnd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x0019DE60 File Offset: 0x0019C060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RegionStopEnd != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RegionStopEnd);
			}
			if (this.RegionStopStart != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RegionStopStart);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x0019DEB8 File Offset: 0x0019C0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegionStopScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RegionStopEnd != 0L)
			{
				this.RegionStopEnd = other.RegionStopEnd;
			}
			if (other.RegionStopStart != 0L)
			{
				this.RegionStopStart = other.RegionStopStart;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x0019DF08 File Offset: 0x0019C108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x0019DF14 File Offset: 0x0019C114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RegionStopEnd = input.ReadInt64();
					}
				}
				else
				{
					this.RegionStopStart = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C57 RID: 15447
		private static readonly MessageParser<RegionStopScNotify> _parser = new MessageParser<RegionStopScNotify>(() => new RegionStopScNotify());

		// Token: 0x04003C58 RID: 15448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C59 RID: 15449
		public const int RegionStopEndFieldNumber = 14;

		// Token: 0x04003C5A RID: 15450
		private long regionStopEnd_;

		// Token: 0x04003C5B RID: 15451
		public const int RegionStopStartFieldNumber = 7;

		// Token: 0x04003C5C RID: 15452
		private long regionStopStart_;
	}
}

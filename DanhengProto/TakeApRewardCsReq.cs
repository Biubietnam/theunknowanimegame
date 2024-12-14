using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012B7 RID: 4791
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeApRewardCsReq : IMessage<TakeApRewardCsReq>, IMessage, IEquatable<TakeApRewardCsReq>, IDeepCloneable<TakeApRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0600D5B3 RID: 54707 RVA: 0x0023A440 File Offset: 0x00238640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeApRewardCsReq> Parser
		{
			get
			{
				return TakeApRewardCsReq._parser;
			}
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0600D5B4 RID: 54708 RVA: 0x0023A447 File Offset: 0x00238647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeApRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0600D5B5 RID: 54709 RVA: 0x0023A459 File Offset: 0x00238659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeApRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D5B6 RID: 54710 RVA: 0x0023A460 File Offset: 0x00238660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeApRewardCsReq()
		{
		}

		// Token: 0x0600D5B7 RID: 54711 RVA: 0x0023A468 File Offset: 0x00238668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeApRewardCsReq(TakeApRewardCsReq other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5B8 RID: 54712 RVA: 0x0023A48D File Offset: 0x0023868D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeApRewardCsReq Clone()
		{
			return new TakeApRewardCsReq(this);
		}

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0600D5B9 RID: 54713 RVA: 0x0023A495 File Offset: 0x00238695
		// (set) Token: 0x0600D5BA RID: 54714 RVA: 0x0023A49D File Offset: 0x0023869D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600D5BB RID: 54715 RVA: 0x0023A4A6 File Offset: 0x002386A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeApRewardCsReq);
		}

		// Token: 0x0600D5BC RID: 54716 RVA: 0x0023A4B4 File Offset: 0x002386B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeApRewardCsReq other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5BD RID: 54717 RVA: 0x0023A4E4 File Offset: 0x002386E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D5BE RID: 54718 RVA: 0x0023A523 File Offset: 0x00238723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D5BF RID: 54719 RVA: 0x0023A52B File Offset: 0x0023872B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5C0 RID: 54720 RVA: 0x0023A534 File Offset: 0x00238734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5C1 RID: 54721 RVA: 0x0023A568 File Offset: 0x00238768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5C2 RID: 54722 RVA: 0x0023A5A6 File Offset: 0x002387A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeApRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5C3 RID: 54723 RVA: 0x0023A5D7 File Offset: 0x002387D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5C4 RID: 54724 RVA: 0x0023A5E0 File Offset: 0x002387E0
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
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005567 RID: 21863
		private static readonly MessageParser<TakeApRewardCsReq> _parser = new MessageParser<TakeApRewardCsReq>(() => new TakeApRewardCsReq());

		// Token: 0x04005568 RID: 21864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005569 RID: 21865
		public const int LevelFieldNumber = 2;

		// Token: 0x0400556A RID: 21866
		private uint level_;
	}
}

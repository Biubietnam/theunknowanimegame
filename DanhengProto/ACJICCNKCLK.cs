using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200002B RID: 43
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ACJICCNKCLK : IMessage<ACJICCNKCLK>, IMessage, IEquatable<ACJICCNKCLK>, IDeepCloneable<ACJICCNKCLK>, IBufferMessage
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00005800 File Offset: 0x00003A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ACJICCNKCLK> Parser
		{
			get
			{
				return ACJICCNKCLK._parser;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00005807 File Offset: 0x00003A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ACJICCNKCLKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00005819 File Offset: 0x00003A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ACJICCNKCLK.Descriptor;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00005820 File Offset: 0x00003A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACJICCNKCLK()
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00005833 File Offset: 0x00003A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACJICCNKCLK(ACJICCNKCLK other) : this()
		{
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000585D File Offset: 0x00003A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACJICCNKCLK Clone()
		{
			return new ACJICCNKCLK(this);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00005865 File Offset: 0x00003A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000586D File Offset: 0x00003A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ACJICCNKCLK);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000587B File Offset: 0x00003A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ACJICCNKCLK other)
		{
			return other != null && (other == this || (this.avatarIdList_.Equals(other.avatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000058B0 File Offset: 0x00003AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000058E4 File Offset: 0x00003AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000058EC File Offset: 0x00003AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000058F5 File Offset: 0x00003AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarIdList_.WriteTo(ref output, ACJICCNKCLK._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000591C File Offset: 0x00003B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarIdList_.CalculateSize(ACJICCNKCLK._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005955 File Offset: 0x00003B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ACJICCNKCLK other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005983 File Offset: 0x00003B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000598C File Offset: 0x00003B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.avatarIdList_.AddEntriesFrom(ref input, ACJICCNKCLK._repeated_avatarIdList_codec);
				}
			}
		}

		// Token: 0x04000080 RID: 128
		private static readonly MessageParser<ACJICCNKCLK> _parser = new MessageParser<ACJICCNKCLK>(() => new ACJICCNKCLK());

		// Token: 0x04000081 RID: 129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000082 RID: 130
		public const int AvatarIdListFieldNumber = 11;

		// Token: 0x04000083 RID: 131
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04000084 RID: 132
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();
	}
}

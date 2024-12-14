using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DD7 RID: 3543
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RetcodeNotify : IMessage<RetcodeNotify>, IMessage, IEquatable<RetcodeNotify>, IDeepCloneable<RetcodeNotify>, IBufferMessage
	{
		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x06009E51 RID: 40529 RVA: 0x001A79AD File Offset: 0x001A5BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RetcodeNotify> Parser
		{
			get
			{
				return RetcodeNotify._parser;
			}
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x06009E52 RID: 40530 RVA: 0x001A79B4 File Offset: 0x001A5BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RetcodeNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x06009E53 RID: 40531 RVA: 0x001A79C6 File Offset: 0x001A5BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RetcodeNotify.Descriptor;
			}
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x001A79CD File Offset: 0x001A5BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RetcodeNotify()
		{
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x001A79E0 File Offset: 0x001A5BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RetcodeNotify(RetcodeNotify other) : this()
		{
			this.retcode_ = other.retcode_;
			this.dDDNPPAKINN_ = other.dDDNPPAKINN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x001A7A16 File Offset: 0x001A5C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RetcodeNotify Clone()
		{
			return new RetcodeNotify(this);
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x06009E57 RID: 40535 RVA: 0x001A7A1E File Offset: 0x001A5C1E
		// (set) Token: 0x06009E58 RID: 40536 RVA: 0x001A7A26 File Offset: 0x001A5C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Retcode Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x06009E59 RID: 40537 RVA: 0x001A7A2F File Offset: 0x001A5C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DDDNPPAKINN
		{
			get
			{
				return this.dDDNPPAKINN_;
			}
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x001A7A37 File Offset: 0x001A5C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RetcodeNotify);
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x001A7A48 File Offset: 0x001A5C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RetcodeNotify other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.dDDNPPAKINN_.Equals(other.dDDNPPAKINN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x001A7A98 File Offset: 0x001A5C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != Retcode.RetSucc)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.dDDNPPAKINN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E5D RID: 40541 RVA: 0x001A7AEB File Offset: 0x001A5CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x001A7AF3 File Offset: 0x001A5CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E5F RID: 40543 RVA: 0x001A7AFC File Offset: 0x001A5CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != Retcode.RetSucc)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Retcode);
			}
			this.dDDNPPAKINN_.WriteTo(ref output, RetcodeNotify._repeated_dDDNPPAKINN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x001A7B4C File Offset: 0x001A5D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != Retcode.RetSucc)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Retcode);
			}
			num += this.dDDNPPAKINN_.CalculateSize(RetcodeNotify._repeated_dDDNPPAKINN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x001A7BA0 File Offset: 0x001A5DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RetcodeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != Retcode.RetSucc)
			{
				this.Retcode = other.Retcode;
			}
			this.dDDNPPAKINN_.Add(other.dDDNPPAKINN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E62 RID: 40546 RVA: 0x001A7BED File Offset: 0x001A5DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x001A7BF8 File Offset: 0x001A5DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dDDNPPAKINN_.AddEntriesFrom(ref input, RetcodeNotify._repeated_dDDNPPAKINN_codec);
					}
				}
				else
				{
					this.Retcode = (Retcode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040040FA RID: 16634
		private static readonly MessageParser<RetcodeNotify> _parser = new MessageParser<RetcodeNotify>(() => new RetcodeNotify());

		// Token: 0x040040FB RID: 16635
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040FC RID: 16636
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040040FD RID: 16637
		private Retcode retcode_;

		// Token: 0x040040FE RID: 16638
		public const int DDDNPPAKINNFieldNumber = 13;

		// Token: 0x040040FF RID: 16639
		private static readonly FieldCodec<uint> _repeated_dDDNPPAKINN_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04004100 RID: 16640
		private readonly RepeatedField<uint> dDDNPPAKINN_ = new RepeatedField<uint>();
	}
}

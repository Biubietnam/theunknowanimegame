using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BB7 RID: 2999
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultipleDropInfoNotify : IMessage<MultipleDropInfoNotify>, IMessage, IEquatable<MultipleDropInfoNotify>, IDeepCloneable<MultipleDropInfoNotify>, IBufferMessage
	{
		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x060084B2 RID: 33970 RVA: 0x0015E3EB File Offset: 0x0015C5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultipleDropInfoNotify> Parser
		{
			get
			{
				return MultipleDropInfoNotify._parser;
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x060084B3 RID: 33971 RVA: 0x0015E3F2 File Offset: 0x0015C5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultipleDropInfoNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x060084B4 RID: 33972 RVA: 0x0015E404 File Offset: 0x0015C604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultipleDropInfoNotify.Descriptor;
			}
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x0015E40B File Offset: 0x0015C60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultipleDropInfoNotify()
		{
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x0015E434 File Offset: 0x0015C634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultipleDropInfoNotify(MultipleDropInfoNotify other) : this()
		{
			this.jOLFDMNLEDO_ = other.jOLFDMNLEDO_.Clone();
			this.aHMGFCCBCBN_ = other.aHMGFCCBCBN_.Clone();
			this.nEFAKDOLPED_ = other.nEFAKDOLPED_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x0015E48B File Offset: 0x0015C68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultipleDropInfoNotify Clone()
		{
			return new MultipleDropInfoNotify(this);
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x060084B8 RID: 33976 RVA: 0x0015E493 File Offset: 0x0015C693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BJKLPGEPCPO> JOLFDMNLEDO
		{
			get
			{
				return this.jOLFDMNLEDO_;
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x060084B9 RID: 33977 RVA: 0x0015E49B File Offset: 0x0015C69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HMDAGOFFLED> AHMGFCCBCBN
		{
			get
			{
				return this.aHMGFCCBCBN_;
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x060084BA RID: 33978 RVA: 0x0015E4A3 File Offset: 0x0015C6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KNOAKLPPLOM> NEFAKDOLPED
		{
			get
			{
				return this.nEFAKDOLPED_;
			}
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x0015E4AB File Offset: 0x0015C6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultipleDropInfoNotify);
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x0015E4BC File Offset: 0x0015C6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultipleDropInfoNotify other)
		{
			return other != null && (other == this || (this.jOLFDMNLEDO_.Equals(other.jOLFDMNLEDO_) && this.aHMGFCCBCBN_.Equals(other.aHMGFCCBCBN_) && this.nEFAKDOLPED_.Equals(other.nEFAKDOLPED_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x0015E524 File Offset: 0x0015C724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jOLFDMNLEDO_.GetHashCode();
			num ^= this.aHMGFCCBCBN_.GetHashCode();
			num ^= this.nEFAKDOLPED_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x0015E574 File Offset: 0x0015C774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x0015E57C File Offset: 0x0015C77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x0015E588 File Offset: 0x0015C788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jOLFDMNLEDO_.WriteTo(ref output, MultipleDropInfoNotify._repeated_jOLFDMNLEDO_codec);
			this.nEFAKDOLPED_.WriteTo(ref output, MultipleDropInfoNotify._repeated_nEFAKDOLPED_codec);
			this.aHMGFCCBCBN_.WriteTo(ref output, MultipleDropInfoNotify._repeated_aHMGFCCBCBN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x0015E5DC File Offset: 0x0015C7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jOLFDMNLEDO_.CalculateSize(MultipleDropInfoNotify._repeated_jOLFDMNLEDO_codec);
			num += this.aHMGFCCBCBN_.CalculateSize(MultipleDropInfoNotify._repeated_aHMGFCCBCBN_codec);
			num += this.nEFAKDOLPED_.CalculateSize(MultipleDropInfoNotify._repeated_nEFAKDOLPED_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x0015E63C File Offset: 0x0015C83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultipleDropInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.jOLFDMNLEDO_.Add(other.jOLFDMNLEDO_);
			this.aHMGFCCBCBN_.Add(other.aHMGFCCBCBN_);
			this.nEFAKDOLPED_.Add(other.nEFAKDOLPED_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x0015E697 File Offset: 0x0015C897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x0015E6A0 File Offset: 0x0015C8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 90U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.aHMGFCCBCBN_.AddEntriesFrom(ref input, MultipleDropInfoNotify._repeated_aHMGFCCBCBN_codec);
						}
					}
					else
					{
						this.nEFAKDOLPED_.AddEntriesFrom(ref input, MultipleDropInfoNotify._repeated_nEFAKDOLPED_codec);
					}
				}
				else
				{
					this.jOLFDMNLEDO_.AddEntriesFrom(ref input, MultipleDropInfoNotify._repeated_jOLFDMNLEDO_codec);
				}
			}
		}

		// Token: 0x040032CB RID: 13003
		private static readonly MessageParser<MultipleDropInfoNotify> _parser = new MessageParser<MultipleDropInfoNotify>(() => new MultipleDropInfoNotify());

		// Token: 0x040032CC RID: 13004
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032CD RID: 13005
		public const int JOLFDMNLEDOFieldNumber = 3;

		// Token: 0x040032CE RID: 13006
		private static readonly FieldCodec<BJKLPGEPCPO> _repeated_jOLFDMNLEDO_codec = FieldCodec.ForMessage<BJKLPGEPCPO>(26U, BJKLPGEPCPO.Parser);

		// Token: 0x040032CF RID: 13007
		private readonly RepeatedField<BJKLPGEPCPO> jOLFDMNLEDO_ = new RepeatedField<BJKLPGEPCPO>();

		// Token: 0x040032D0 RID: 13008
		public const int AHMGFCCBCBNFieldNumber = 14;

		// Token: 0x040032D1 RID: 13009
		private static readonly FieldCodec<HMDAGOFFLED> _repeated_aHMGFCCBCBN_codec = FieldCodec.ForMessage<HMDAGOFFLED>(114U, HMDAGOFFLED.Parser);

		// Token: 0x040032D2 RID: 13010
		private readonly RepeatedField<HMDAGOFFLED> aHMGFCCBCBN_ = new RepeatedField<HMDAGOFFLED>();

		// Token: 0x040032D3 RID: 13011
		public const int NEFAKDOLPEDFieldNumber = 11;

		// Token: 0x040032D4 RID: 13012
		private static readonly FieldCodec<KNOAKLPPLOM> _repeated_nEFAKDOLPED_codec = FieldCodec.ForMessage<KNOAKLPPLOM>(90U, KNOAKLPPLOM.Parser);

		// Token: 0x040032D5 RID: 13013
		private readonly RepeatedField<KNOAKLPPLOM> nEFAKDOLPED_ = new RepeatedField<KNOAKLPPLOM>();
	}
}

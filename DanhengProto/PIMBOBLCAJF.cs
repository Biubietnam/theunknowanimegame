using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C9F RID: 3231
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PIMBOBLCAJF : IMessage<PIMBOBLCAJF>, IMessage, IEquatable<PIMBOBLCAJF>, IDeepCloneable<PIMBOBLCAJF>, IBufferMessage
	{
		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x06008FAB RID: 36779 RVA: 0x0017B9C0 File Offset: 0x00179BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PIMBOBLCAJF> Parser
		{
			get
			{
				return PIMBOBLCAJF._parser;
			}
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x06008FAC RID: 36780 RVA: 0x0017B9C7 File Offset: 0x00179BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PIMBOBLCAJFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x06008FAD RID: 36781 RVA: 0x0017B9D9 File Offset: 0x00179BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PIMBOBLCAJF.Descriptor;
			}
		}

		// Token: 0x06008FAE RID: 36782 RVA: 0x0017B9E0 File Offset: 0x00179BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PIMBOBLCAJF()
		{
		}

		// Token: 0x06008FAF RID: 36783 RVA: 0x0017B9F3 File Offset: 0x00179BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PIMBOBLCAJF(PIMBOBLCAJF other) : this()
		{
			this.selectHintId_ = other.selectHintId_;
			this.iLDNKKACMPL_ = other.iLDNKKACMPL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FB0 RID: 36784 RVA: 0x0017BA29 File Offset: 0x00179C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PIMBOBLCAJF Clone()
		{
			return new PIMBOBLCAJF(this);
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x06008FB1 RID: 36785 RVA: 0x0017BA31 File Offset: 0x00179C31
		// (set) Token: 0x06008FB2 RID: 36786 RVA: 0x0017BA39 File Offset: 0x00179C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x06008FB3 RID: 36787 RVA: 0x0017BA42 File Offset: 0x00179C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ILDNKKACMPL
		{
			get
			{
				return this.iLDNKKACMPL_;
			}
		}

		// Token: 0x06008FB4 RID: 36788 RVA: 0x0017BA4A File Offset: 0x00179C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PIMBOBLCAJF);
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x0017BA58 File Offset: 0x00179C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PIMBOBLCAJF other)
		{
			return other != null && (other == this || (this.SelectHintId == other.SelectHintId && this.iLDNKKACMPL_.Equals(other.iLDNKKACMPL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x0017BAA8 File Offset: 0x00179CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			num ^= this.iLDNKKACMPL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FB7 RID: 36791 RVA: 0x0017BAF5 File Offset: 0x00179CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FB8 RID: 36792 RVA: 0x0017BAFD File Offset: 0x00179CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FB9 RID: 36793 RVA: 0x0017BB08 File Offset: 0x00179D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.iLDNKKACMPL_.WriteTo(ref output, PIMBOBLCAJF._repeated_iLDNKKACMPL_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FBA RID: 36794 RVA: 0x0017BB58 File Offset: 0x00179D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			num += this.iLDNKKACMPL_.CalculateSize(PIMBOBLCAJF._repeated_iLDNKKACMPL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FBB RID: 36795 RVA: 0x0017BBAC File Offset: 0x00179DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PIMBOBLCAJF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this.iLDNKKACMPL_.Add(other.iLDNKKACMPL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FBC RID: 36796 RVA: 0x0017BBF9 File Offset: 0x00179DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FBD RID: 36797 RVA: 0x0017BC04 File Offset: 0x00179E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U && num != 26U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectHintId = input.ReadUInt32();
					}
				}
				else
				{
					this.iLDNKKACMPL_.AddEntriesFrom(ref input, PIMBOBLCAJF._repeated_iLDNKKACMPL_codec);
				}
			}
		}

		// Token: 0x0400372D RID: 14125
		private static readonly MessageParser<PIMBOBLCAJF> _parser = new MessageParser<PIMBOBLCAJF>(() => new PIMBOBLCAJF());

		// Token: 0x0400372E RID: 14126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400372F RID: 14127
		public const int SelectHintIdFieldNumber = 4;

		// Token: 0x04003730 RID: 14128
		private uint selectHintId_;

		// Token: 0x04003731 RID: 14129
		public const int ILDNKKACMPLFieldNumber = 3;

		// Token: 0x04003732 RID: 14130
		private static readonly FieldCodec<uint> _repeated_iLDNKKACMPL_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04003733 RID: 14131
		private readonly RepeatedField<uint> iLDNKKACMPL_ = new RepeatedField<uint>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009A9 RID: 2473
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KIANELPLCMF : IMessage<KIANELPLCMF>, IMessage, IEquatable<KIANELPLCMF>, IDeepCloneable<KIANELPLCMF>, IBufferMessage
	{
		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06006E94 RID: 28308 RVA: 0x001276DD File Offset: 0x001258DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KIANELPLCMF> Parser
		{
			get
			{
				return KIANELPLCMF._parser;
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x06006E95 RID: 28309 RVA: 0x001276E4 File Offset: 0x001258E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KIANELPLCMFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x06006E96 RID: 28310 RVA: 0x001276F6 File Offset: 0x001258F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KIANELPLCMF.Descriptor;
			}
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x001276FD File Offset: 0x001258FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIANELPLCMF()
		{
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x00127710 File Offset: 0x00125910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIANELPLCMF(KIANELPLCMF other) : this()
		{
			this.nOADDEMHLPN_ = other.nOADDEMHLPN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x0012773A File Offset: 0x0012593A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIANELPLCMF Clone()
		{
			return new KIANELPLCMF(this);
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x00127742 File Offset: 0x00125942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueUnlockFunctionType> NOADDEMHLPN
		{
			get
			{
				return this.nOADDEMHLPN_;
			}
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x0012774A File Offset: 0x0012594A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KIANELPLCMF);
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x00127758 File Offset: 0x00125958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KIANELPLCMF other)
		{
			return other != null && (other == this || (this.nOADDEMHLPN_.Equals(other.nOADDEMHLPN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E9D RID: 28317 RVA: 0x0012778C File Offset: 0x0012598C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nOADDEMHLPN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E9E RID: 28318 RVA: 0x001277C0 File Offset: 0x001259C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x001277C8 File Offset: 0x001259C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x001277D1 File Offset: 0x001259D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nOADDEMHLPN_.WriteTo(ref output, KIANELPLCMF._repeated_nOADDEMHLPN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x001277F8 File Offset: 0x001259F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nOADDEMHLPN_.CalculateSize(KIANELPLCMF._repeated_nOADDEMHLPN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x00127831 File Offset: 0x00125A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KIANELPLCMF other)
		{
			if (other == null)
			{
				return;
			}
			this.nOADDEMHLPN_.Add(other.nOADDEMHLPN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006EA3 RID: 28323 RVA: 0x0012785F File Offset: 0x00125A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EA4 RID: 28324 RVA: 0x00127868 File Offset: 0x00125A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.nOADDEMHLPN_.AddEntriesFrom(ref input, KIANELPLCMF._repeated_nOADDEMHLPN_codec);
				}
			}
		}

		// Token: 0x04002A77 RID: 10871
		private static readonly MessageParser<KIANELPLCMF> _parser = new MessageParser<KIANELPLCMF>(() => new KIANELPLCMF());

		// Token: 0x04002A78 RID: 10872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A79 RID: 10873
		public const int NOADDEMHLPNFieldNumber = 8;

		// Token: 0x04002A7A RID: 10874
		private static readonly FieldCodec<RogueUnlockFunctionType> _repeated_nOADDEMHLPN_codec = FieldCodec.ForEnum<RogueUnlockFunctionType>(66U, (RogueUnlockFunctionType x) => (int)x, (int x) => (RogueUnlockFunctionType)x);

		// Token: 0x04002A7B RID: 10875
		private readonly RepeatedField<RogueUnlockFunctionType> nOADDEMHLPN_ = new RepeatedField<RogueUnlockFunctionType>();
	}
}

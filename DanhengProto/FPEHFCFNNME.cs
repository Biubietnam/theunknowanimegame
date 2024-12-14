using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005BB RID: 1467
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FPEHFCFNNME : IMessage<FPEHFCFNNME>, IMessage, IEquatable<FPEHFCFNNME>, IDeepCloneable<FPEHFCFNNME>, IBufferMessage
	{
		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x000B2A20 File Offset: 0x000B0C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FPEHFCFNNME> Parser
		{
			get
			{
				return FPEHFCFNNME._parser;
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x000B2A27 File Offset: 0x000B0C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FPEHFCFNNMEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x000B2A39 File Offset: 0x000B0C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FPEHFCFNNME.Descriptor;
			}
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x000B2A40 File Offset: 0x000B0C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPEHFCFNNME()
		{
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x000B2A53 File Offset: 0x000B0C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPEHFCFNNME(FPEHFCFNNME other) : this()
		{
			this.fDJFKKJANCN_ = other.fDJFKKJANCN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x000B2A7D File Offset: 0x000B0C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPEHFCFNNME Clone()
		{
			return new FPEHFCFNNME(this);
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x0600419A RID: 16794 RVA: 0x000B2A85 File Offset: 0x000B0C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DAGLHMKLOGO> FDJFKKJANCN
		{
			get
			{
				return this.fDJFKKJANCN_;
			}
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x000B2A8D File Offset: 0x000B0C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FPEHFCFNNME);
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x000B2A9B File Offset: 0x000B0C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FPEHFCFNNME other)
		{
			return other != null && (other == this || (this.fDJFKKJANCN_.Equals(other.fDJFKKJANCN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x000B2AD0 File Offset: 0x000B0CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fDJFKKJANCN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x000B2B04 File Offset: 0x000B0D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x000B2B0C File Offset: 0x000B0D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x000B2B15 File Offset: 0x000B0D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fDJFKKJANCN_.WriteTo(ref output, FPEHFCFNNME._repeated_fDJFKKJANCN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x000B2B3C File Offset: 0x000B0D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fDJFKKJANCN_.CalculateSize(FPEHFCFNNME._repeated_fDJFKKJANCN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x000B2B75 File Offset: 0x000B0D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FPEHFCFNNME other)
		{
			if (other == null)
			{
				return;
			}
			this.fDJFKKJANCN_.Add(other.fDJFKKJANCN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x000B2BA3 File Offset: 0x000B0DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x000B2BAC File Offset: 0x000B0DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fDJFKKJANCN_.AddEntriesFrom(ref input, FPEHFCFNNME._repeated_fDJFKKJANCN_codec);
				}
			}
		}

		// Token: 0x04001A07 RID: 6663
		private static readonly MessageParser<FPEHFCFNNME> _parser = new MessageParser<FPEHFCFNNME>(() => new FPEHFCFNNME());

		// Token: 0x04001A08 RID: 6664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A09 RID: 6665
		public const int FDJFKKJANCNFieldNumber = 13;

		// Token: 0x04001A0A RID: 6666
		private static readonly FieldCodec<DAGLHMKLOGO> _repeated_fDJFKKJANCN_codec = FieldCodec.ForMessage<DAGLHMKLOGO>(106U, DAGLHMKLOGO.Parser);

		// Token: 0x04001A0B RID: 6667
		private readonly RepeatedField<DAGLHMKLOGO> fDJFKKJANCN_ = new RepeatedField<DAGLHMKLOGO>();
	}
}

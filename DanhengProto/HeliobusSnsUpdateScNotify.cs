using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008D7 RID: 2263
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsUpdateScNotify : IMessage<HeliobusSnsUpdateScNotify>, IMessage, IEquatable<HeliobusSnsUpdateScNotify>, IDeepCloneable<HeliobusSnsUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x060064E7 RID: 25831 RVA: 0x0010DF3D File Offset: 0x0010C13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsUpdateScNotify> Parser
		{
			get
			{
				return HeliobusSnsUpdateScNotify._parser;
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x060064E8 RID: 25832 RVA: 0x0010DF44 File Offset: 0x0010C144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x060064E9 RID: 25833 RVA: 0x0010DF56 File Offset: 0x0010C156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x0010DF5D File Offset: 0x0010C15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsUpdateScNotify()
		{
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x0010DF70 File Offset: 0x0010C170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsUpdateScNotify(HeliobusSnsUpdateScNotify other) : this()
		{
			this.jNOIBBBGPKK_ = other.jNOIBBBGPKK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x0010DF9A File Offset: 0x0010C19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsUpdateScNotify Clone()
		{
			return new HeliobusSnsUpdateScNotify(this);
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x060064ED RID: 25837 RVA: 0x0010DFA2 File Offset: 0x0010C1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PCMDGDLANFF> JNOIBBBGPKK
		{
			get
			{
				return this.jNOIBBBGPKK_;
			}
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x0010DFAA File Offset: 0x0010C1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsUpdateScNotify);
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x0010DFB8 File Offset: 0x0010C1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsUpdateScNotify other)
		{
			return other != null && (other == this || (this.jNOIBBBGPKK_.Equals(other.jNOIBBBGPKK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x0010DFEC File Offset: 0x0010C1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jNOIBBBGPKK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x0010E020 File Offset: 0x0010C220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x0010E028 File Offset: 0x0010C228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x0010E031 File Offset: 0x0010C231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jNOIBBBGPKK_.WriteTo(ref output, HeliobusSnsUpdateScNotify._repeated_jNOIBBBGPKK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x0010E058 File Offset: 0x0010C258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jNOIBBBGPKK_.CalculateSize(HeliobusSnsUpdateScNotify._repeated_jNOIBBBGPKK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x0010E091 File Offset: 0x0010C291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.jNOIBBBGPKK_.Add(other.jNOIBBBGPKK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x0010E0BF File Offset: 0x0010C2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x0010E0C8 File Offset: 0x0010C2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.jNOIBBBGPKK_.AddEntriesFrom(ref input, HeliobusSnsUpdateScNotify._repeated_jNOIBBBGPKK_codec);
				}
			}
		}

		// Token: 0x040026D4 RID: 9940
		private static readonly MessageParser<HeliobusSnsUpdateScNotify> _parser = new MessageParser<HeliobusSnsUpdateScNotify>(() => new HeliobusSnsUpdateScNotify());

		// Token: 0x040026D5 RID: 9941
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026D6 RID: 9942
		public const int JNOIBBBGPKKFieldNumber = 14;

		// Token: 0x040026D7 RID: 9943
		private static readonly FieldCodec<PCMDGDLANFF> _repeated_jNOIBBBGPKK_codec = FieldCodec.ForMessage<PCMDGDLANFF>(114U, PCMDGDLANFF.Parser);

		// Token: 0x040026D8 RID: 9944
		private readonly RepeatedField<PCMDGDLANFF> jNOIBBBGPKK_ = new RepeatedField<PCMDGDLANFF>();
	}
}

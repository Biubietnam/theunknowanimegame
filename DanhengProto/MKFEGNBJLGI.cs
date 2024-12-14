using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AF3 RID: 2803
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MKFEGNBJLGI : IMessage<MKFEGNBJLGI>, IMessage, IEquatable<MKFEGNBJLGI>, IDeepCloneable<MKFEGNBJLGI>, IBufferMessage
	{
		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x06007C03 RID: 31747 RVA: 0x0014878C File Offset: 0x0014698C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MKFEGNBJLGI> Parser
		{
			get
			{
				return MKFEGNBJLGI._parser;
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x06007C04 RID: 31748 RVA: 0x00148793 File Offset: 0x00146993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MKFEGNBJLGIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x06007C05 RID: 31749 RVA: 0x001487A5 File Offset: 0x001469A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MKFEGNBJLGI.Descriptor;
			}
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x001487AC File Offset: 0x001469AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKFEGNBJLGI()
		{
		}

		// Token: 0x06007C07 RID: 31751 RVA: 0x001487BF File Offset: 0x001469BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKFEGNBJLGI(MKFEGNBJLGI other) : this()
		{
			this.gJGJFDEKEPC_ = other.gJGJFDEKEPC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x001487E9 File Offset: 0x001469E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKFEGNBJLGI Clone()
		{
			return new MKFEGNBJLGI(this);
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06007C09 RID: 31753 RVA: 0x001487F1 File Offset: 0x001469F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LBBFGIHHLGN> GJGJFDEKEPC
		{
			get
			{
				return this.gJGJFDEKEPC_;
			}
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x001487F9 File Offset: 0x001469F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MKFEGNBJLGI);
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x00148807 File Offset: 0x00146A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MKFEGNBJLGI other)
		{
			return other != null && (other == this || (this.gJGJFDEKEPC_.Equals(other.gJGJFDEKEPC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x0014883C File Offset: 0x00146A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gJGJFDEKEPC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x00148870 File Offset: 0x00146A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x00148878 File Offset: 0x00146A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C0F RID: 31759 RVA: 0x00148881 File Offset: 0x00146A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gJGJFDEKEPC_.WriteTo(ref output, MKFEGNBJLGI._repeated_gJGJFDEKEPC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x001488A8 File Offset: 0x00146AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gJGJFDEKEPC_.CalculateSize(MKFEGNBJLGI._repeated_gJGJFDEKEPC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x001488E1 File Offset: 0x00146AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MKFEGNBJLGI other)
		{
			if (other == null)
			{
				return;
			}
			this.gJGJFDEKEPC_.Add(other.gJGJFDEKEPC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x0014890F File Offset: 0x00146B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x00148918 File Offset: 0x00146B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gJGJFDEKEPC_.AddEntriesFrom(ref input, MKFEGNBJLGI._repeated_gJGJFDEKEPC_codec);
				}
			}
		}

		// Token: 0x04002FB4 RID: 12212
		private static readonly MessageParser<MKFEGNBJLGI> _parser = new MessageParser<MKFEGNBJLGI>(() => new MKFEGNBJLGI());

		// Token: 0x04002FB5 RID: 12213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FB6 RID: 12214
		public const int GJGJFDEKEPCFieldNumber = 1;

		// Token: 0x04002FB7 RID: 12215
		private static readonly FieldCodec<LBBFGIHHLGN> _repeated_gJGJFDEKEPC_codec = FieldCodec.ForMessage<LBBFGIHHLGN>(10U, LBBFGIHHLGN.Parser);

		// Token: 0x04002FB8 RID: 12216
		private readonly RepeatedField<LBBFGIHHLGN> gJGJFDEKEPC_ = new RepeatedField<LBBFGIHHLGN>();
	}
}

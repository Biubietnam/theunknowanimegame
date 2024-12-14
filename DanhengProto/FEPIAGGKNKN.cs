using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000515 RID: 1301
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FEPIAGGKNKN : IMessage<FEPIAGGKNKN>, IMessage, IEquatable<FEPIAGGKNKN>, IDeepCloneable<FEPIAGGKNKN>, IBufferMessage
	{
		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06003A39 RID: 14905 RVA: 0x000A0320 File Offset: 0x0009E520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FEPIAGGKNKN> Parser
		{
			get
			{
				return FEPIAGGKNKN._parser;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x000A0327 File Offset: 0x0009E527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FEPIAGGKNKNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x000A0339 File Offset: 0x0009E539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FEPIAGGKNKN.Descriptor;
			}
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x000A0340 File Offset: 0x0009E540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FEPIAGGKNKN()
		{
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x000A0353 File Offset: 0x0009E553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FEPIAGGKNKN(FEPIAGGKNKN other) : this()
		{
			this.hGFJCCNJPPC_ = other.hGFJCCNJPPC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x000A037D File Offset: 0x0009E57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FEPIAGGKNKN Clone()
		{
			return new FEPIAGGKNKN(this);
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x000A0385 File Offset: 0x0009E585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HGFJCCNJPPC
		{
			get
			{
				return this.hGFJCCNJPPC_;
			}
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x000A038D File Offset: 0x0009E58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FEPIAGGKNKN);
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x000A039B File Offset: 0x0009E59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FEPIAGGKNKN other)
		{
			return other != null && (other == this || (this.hGFJCCNJPPC_.Equals(other.hGFJCCNJPPC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x000A03D0 File Offset: 0x0009E5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hGFJCCNJPPC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x000A0404 File Offset: 0x0009E604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x000A040C File Offset: 0x0009E60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x000A0415 File Offset: 0x0009E615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hGFJCCNJPPC_.WriteTo(ref output, FEPIAGGKNKN._repeated_hGFJCCNJPPC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x000A043C File Offset: 0x0009E63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hGFJCCNJPPC_.CalculateSize(FEPIAGGKNKN._repeated_hGFJCCNJPPC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x000A0475 File Offset: 0x0009E675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FEPIAGGKNKN other)
		{
			if (other == null)
			{
				return;
			}
			this.hGFJCCNJPPC_.Add(other.hGFJCCNJPPC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x000A04A3 File Offset: 0x0009E6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x000A04AC File Offset: 0x0009E6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hGFJCCNJPPC_.AddEntriesFrom(ref input, FEPIAGGKNKN._repeated_hGFJCCNJPPC_codec);
				}
			}
		}

		// Token: 0x04001767 RID: 5991
		private static readonly MessageParser<FEPIAGGKNKN> _parser = new MessageParser<FEPIAGGKNKN>(() => new FEPIAGGKNKN());

		// Token: 0x04001768 RID: 5992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001769 RID: 5993
		public const int HGFJCCNJPPCFieldNumber = 1;

		// Token: 0x0400176A RID: 5994
		private static readonly FieldCodec<uint> _repeated_hGFJCCNJPPC_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400176B RID: 5995
		private readonly RepeatedField<uint> hGFJCCNJPPC_ = new RepeatedField<uint>();
	}
}

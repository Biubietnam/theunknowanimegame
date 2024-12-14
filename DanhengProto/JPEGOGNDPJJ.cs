using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000981 RID: 2433
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JPEGOGNDPJJ : IMessage<JPEGOGNDPJJ>, IMessage, IEquatable<JPEGOGNDPJJ>, IDeepCloneable<JPEGOGNDPJJ>, IBufferMessage
	{
		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x06006CD3 RID: 27859 RVA: 0x001229B8 File Offset: 0x00120BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JPEGOGNDPJJ> Parser
		{
			get
			{
				return JPEGOGNDPJJ._parser;
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06006CD4 RID: 27860 RVA: 0x001229BF File Offset: 0x00120BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JPEGOGNDPJJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06006CD5 RID: 27861 RVA: 0x001229D1 File Offset: 0x00120BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JPEGOGNDPJJ.Descriptor;
			}
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x001229D8 File Offset: 0x00120BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPEGOGNDPJJ()
		{
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x001229EB File Offset: 0x00120BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPEGOGNDPJJ(JPEGOGNDPJJ other) : this()
		{
			this.lANJFBKHEDK_ = other.lANJFBKHEDK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x00122A15 File Offset: 0x00120C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPEGOGNDPJJ Clone()
		{
			return new JPEGOGNDPJJ(this);
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06006CD9 RID: 27865 RVA: 0x00122A1D File Offset: 0x00120C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueModifier> LANJFBKHEDK
		{
			get
			{
				return this.lANJFBKHEDK_;
			}
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x00122A25 File Offset: 0x00120C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JPEGOGNDPJJ);
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x00122A33 File Offset: 0x00120C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JPEGOGNDPJJ other)
		{
			return other != null && (other == this || (this.lANJFBKHEDK_.Equals(other.lANJFBKHEDK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x00122A68 File Offset: 0x00120C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lANJFBKHEDK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x00122A9C File Offset: 0x00120C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x00122AA4 File Offset: 0x00120CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x00122AAD File Offset: 0x00120CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lANJFBKHEDK_.WriteTo(ref output, JPEGOGNDPJJ._repeated_lANJFBKHEDK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x00122AD4 File Offset: 0x00120CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lANJFBKHEDK_.CalculateSize(JPEGOGNDPJJ._repeated_lANJFBKHEDK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x00122B0D File Offset: 0x00120D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JPEGOGNDPJJ other)
		{
			if (other == null)
			{
				return;
			}
			this.lANJFBKHEDK_.Add(other.lANJFBKHEDK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x00122B3B File Offset: 0x00120D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x00122B44 File Offset: 0x00120D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lANJFBKHEDK_.AddEntriesFrom(ref input, JPEGOGNDPJJ._repeated_lANJFBKHEDK_codec);
				}
			}
		}

		// Token: 0x040029B7 RID: 10679
		private static readonly MessageParser<JPEGOGNDPJJ> _parser = new MessageParser<JPEGOGNDPJJ>(() => new JPEGOGNDPJJ());

		// Token: 0x040029B8 RID: 10680
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029B9 RID: 10681
		public const int LANJFBKHEDKFieldNumber = 11;

		// Token: 0x040029BA RID: 10682
		private static readonly FieldCodec<RogueModifier> _repeated_lANJFBKHEDK_codec = FieldCodec.ForMessage<RogueModifier>(90U, RogueModifier.Parser);

		// Token: 0x040029BB RID: 10683
		private readonly RepeatedField<RogueModifier> lANJFBKHEDK_ = new RepeatedField<RogueModifier>();
	}
}

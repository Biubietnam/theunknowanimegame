using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003E9 RID: 1001
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EACINHCCCMI : IMessage<EACINHCCCMI>, IMessage, IEquatable<EACINHCCCMI>, IDeepCloneable<EACINHCCCMI>, IBufferMessage
	{
		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x0007B86D File Offset: 0x00079A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EACINHCCCMI> Parser
		{
			get
			{
				return EACINHCCCMI._parser;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x0007B874 File Offset: 0x00079A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EACINHCCCMIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x0007B886 File Offset: 0x00079A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EACINHCCCMI.Descriptor;
			}
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x0007B88D File Offset: 0x00079A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EACINHCCCMI()
		{
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x0007B8AC File Offset: 0x00079AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EACINHCCCMI(EACINHCCCMI other) : this()
		{
			this.secondLineup_ = other.secondLineup_.Clone();
			this.mJGILMHGAOL_ = other.mJGILMHGAOL_;
			this.firstLineup_ = other.firstLineup_.Clone();
			this.jLJEOFMOBAE_ = other.jLJEOFMOBAE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x0007B90A File Offset: 0x00079B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EACINHCCCMI Clone()
		{
			return new EACINHCCCMI(this);
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x0007B912 File Offset: 0x00079B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SecondLineup
		{
			get
			{
				return this.secondLineup_;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x0007B91A File Offset: 0x00079B1A
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x0007B922 File Offset: 0x00079B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MJGILMHGAOL
		{
			get
			{
				return this.mJGILMHGAOL_;
			}
			set
			{
				this.mJGILMHGAOL_ = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x0007B92B File Offset: 0x00079B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FirstLineup
		{
			get
			{
				return this.firstLineup_;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x0007B933 File Offset: 0x00079B33
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x0007B93B File Offset: 0x00079B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JLJEOFMOBAE
		{
			get
			{
				return this.jLJEOFMOBAE_;
			}
			set
			{
				this.jLJEOFMOBAE_ = value;
			}
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x0007B944 File Offset: 0x00079B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EACINHCCCMI);
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x0007B954 File Offset: 0x00079B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EACINHCCCMI other)
		{
			return other != null && (other == this || (this.secondLineup_.Equals(other.secondLineup_) && this.MJGILMHGAOL == other.MJGILMHGAOL && this.firstLineup_.Equals(other.firstLineup_) && this.JLJEOFMOBAE == other.JLJEOFMOBAE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x0007B9C8 File Offset: 0x00079BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.secondLineup_.GetHashCode();
			if (this.MJGILMHGAOL != 0U)
			{
				num ^= this.MJGILMHGAOL.GetHashCode();
			}
			num ^= this.firstLineup_.GetHashCode();
			if (this.JLJEOFMOBAE != 0U)
			{
				num ^= this.JLJEOFMOBAE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x0007BA3C File Offset: 0x00079C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x0007BA44 File Offset: 0x00079C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x0007BA50 File Offset: 0x00079C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.firstLineup_.WriteTo(ref output, EACINHCCCMI._repeated_firstLineup_codec);
			if (this.MJGILMHGAOL != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MJGILMHGAOL);
			}
			if (this.JLJEOFMOBAE != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.JLJEOFMOBAE);
			}
			this.secondLineup_.WriteTo(ref output, EACINHCCCMI._repeated_secondLineup_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x0007BACC File Offset: 0x00079CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.secondLineup_.CalculateSize(EACINHCCCMI._repeated_secondLineup_codec);
			if (this.MJGILMHGAOL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MJGILMHGAOL);
			}
			num += this.firstLineup_.CalculateSize(EACINHCCCMI._repeated_firstLineup_codec);
			if (this.JLJEOFMOBAE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JLJEOFMOBAE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0007BB48 File Offset: 0x00079D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EACINHCCCMI other)
		{
			if (other == null)
			{
				return;
			}
			this.secondLineup_.Add(other.secondLineup_);
			if (other.MJGILMHGAOL != 0U)
			{
				this.MJGILMHGAOL = other.MJGILMHGAOL;
			}
			this.firstLineup_.Add(other.firstLineup_);
			if (other.JLJEOFMOBAE != 0U)
			{
				this.JLJEOFMOBAE = other.JLJEOFMOBAE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x0007BBBA File Offset: 0x00079DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0007BBC4 File Offset: 0x00079DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 24U || num == 26U)
					{
						this.firstLineup_.AddEntriesFrom(ref input, EACINHCCCMI._repeated_firstLineup_codec);
						continue;
					}
					if (num == 48U)
					{
						this.MJGILMHGAOL = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.JLJEOFMOBAE = input.ReadUInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.secondLineup_.AddEntriesFrom(ref input, EACINHCCCMI._repeated_secondLineup_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040011F7 RID: 4599
		private static readonly MessageParser<EACINHCCCMI> _parser = new MessageParser<EACINHCCCMI>(() => new EACINHCCCMI());

		// Token: 0x040011F8 RID: 4600
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011F9 RID: 4601
		public const int SecondLineupFieldNumber = 15;

		// Token: 0x040011FA RID: 4602
		private static readonly FieldCodec<uint> _repeated_secondLineup_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x040011FB RID: 4603
		private readonly RepeatedField<uint> secondLineup_ = new RepeatedField<uint>();

		// Token: 0x040011FC RID: 4604
		public const int MJGILMHGAOLFieldNumber = 6;

		// Token: 0x040011FD RID: 4605
		private uint mJGILMHGAOL_;

		// Token: 0x040011FE RID: 4606
		public const int FirstLineupFieldNumber = 3;

		// Token: 0x040011FF RID: 4607
		private static readonly FieldCodec<uint> _repeated_firstLineup_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04001200 RID: 4608
		private readonly RepeatedField<uint> firstLineup_ = new RepeatedField<uint>();

		// Token: 0x04001201 RID: 4609
		public const int JLJEOFMOBAEFieldNumber = 11;

		// Token: 0x04001202 RID: 4610
		private uint jLJEOFMOBAE_;
	}
}

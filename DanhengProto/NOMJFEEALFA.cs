using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C2B RID: 3115
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NOMJFEEALFA : IMessage<NOMJFEEALFA>, IMessage, IEquatable<NOMJFEEALFA>, IDeepCloneable<NOMJFEEALFA>, IBufferMessage
	{
		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x06008A08 RID: 35336 RVA: 0x0016C841 File Offset: 0x0016AA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NOMJFEEALFA> Parser
		{
			get
			{
				return NOMJFEEALFA._parser;
			}
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x06008A09 RID: 35337 RVA: 0x0016C848 File Offset: 0x0016AA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NOMJFEEALFAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x06008A0A RID: 35338 RVA: 0x0016C85A File Offset: 0x0016AA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NOMJFEEALFA.Descriptor;
			}
		}

		// Token: 0x06008A0B RID: 35339 RVA: 0x0016C861 File Offset: 0x0016AA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NOMJFEEALFA()
		{
		}

		// Token: 0x06008A0C RID: 35340 RVA: 0x0016C87F File Offset: 0x0016AA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NOMJFEEALFA(NOMJFEEALFA other) : this()
		{
			this.jKOFJPMDELK_ = other.jKOFJPMDELK_.Clone();
			this.nFIBKMMKNEE_ = other.nFIBKMMKNEE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x0016C8BA File Offset: 0x0016AABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NOMJFEEALFA Clone()
		{
			return new NOMJFEEALFA(this);
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x06008A0E RID: 35342 RVA: 0x0016C8C2 File Offset: 0x0016AAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HCMJAJFPCKO> JKOFJPMDELK
		{
			get
			{
				return this.jKOFJPMDELK_;
			}
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x06008A0F RID: 35343 RVA: 0x0016C8CA File Offset: 0x0016AACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NFIBKMMKNEE
		{
			get
			{
				return this.nFIBKMMKNEE_;
			}
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x0016C8D2 File Offset: 0x0016AAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NOMJFEEALFA);
		}

		// Token: 0x06008A11 RID: 35345 RVA: 0x0016C8E0 File Offset: 0x0016AAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NOMJFEEALFA other)
		{
			return other != null && (other == this || (this.jKOFJPMDELK_.Equals(other.jKOFJPMDELK_) && this.nFIBKMMKNEE_.Equals(other.nFIBKMMKNEE_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A12 RID: 35346 RVA: 0x0016C934 File Offset: 0x0016AB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jKOFJPMDELK_.GetHashCode();
			num ^= this.nFIBKMMKNEE_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x0016C976 File Offset: 0x0016AB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x0016C97E File Offset: 0x0016AB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A15 RID: 35349 RVA: 0x0016C987 File Offset: 0x0016AB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jKOFJPMDELK_.WriteTo(ref output, NOMJFEEALFA._repeated_jKOFJPMDELK_codec);
			this.nFIBKMMKNEE_.WriteTo(ref output, NOMJFEEALFA._repeated_nFIBKMMKNEE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x0016C9C0 File Offset: 0x0016ABC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jKOFJPMDELK_.CalculateSize(NOMJFEEALFA._repeated_jKOFJPMDELK_codec);
			num += this.nFIBKMMKNEE_.CalculateSize(NOMJFEEALFA._repeated_nFIBKMMKNEE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x0016CA0C File Offset: 0x0016AC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NOMJFEEALFA other)
		{
			if (other == null)
			{
				return;
			}
			this.jKOFJPMDELK_.Add(other.jKOFJPMDELK_);
			this.nFIBKMMKNEE_.Add(other.nFIBKMMKNEE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x0016CA4B File Offset: 0x0016AC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A19 RID: 35353 RVA: 0x0016CA54 File Offset: 0x0016AC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.nFIBKMMKNEE_.AddEntriesFrom(ref input, NOMJFEEALFA._repeated_nFIBKMMKNEE_codec);
					}
				}
				else
				{
					this.jKOFJPMDELK_.AddEntriesFrom(ref input, NOMJFEEALFA._repeated_jKOFJPMDELK_codec);
				}
			}
		}

		// Token: 0x040034F0 RID: 13552
		private static readonly MessageParser<NOMJFEEALFA> _parser = new MessageParser<NOMJFEEALFA>(() => new NOMJFEEALFA());

		// Token: 0x040034F1 RID: 13553
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034F2 RID: 13554
		public const int JKOFJPMDELKFieldNumber = 3;

		// Token: 0x040034F3 RID: 13555
		private static readonly FieldCodec<HCMJAJFPCKO> _repeated_jKOFJPMDELK_codec = FieldCodec.ForMessage<HCMJAJFPCKO>(26U, HCMJAJFPCKO.Parser);

		// Token: 0x040034F4 RID: 13556
		private readonly RepeatedField<HCMJAJFPCKO> jKOFJPMDELK_ = new RepeatedField<HCMJAJFPCKO>();

		// Token: 0x040034F5 RID: 13557
		public const int NFIBKMMKNEEFieldNumber = 7;

		// Token: 0x040034F6 RID: 13558
		private static readonly FieldCodec<uint> _repeated_nFIBKMMKNEE_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x040034F7 RID: 13559
		private readonly RepeatedField<uint> nFIBKMMKNEE_ = new RepeatedField<uint>();
	}
}

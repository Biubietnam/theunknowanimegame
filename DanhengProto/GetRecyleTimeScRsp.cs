using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000793 RID: 1939
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRecyleTimeScRsp : IMessage<GetRecyleTimeScRsp>, IMessage, IEquatable<GetRecyleTimeScRsp>, IDeepCloneable<GetRecyleTimeScRsp>, IBufferMessage
	{
		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06005695 RID: 22165 RVA: 0x000E82D5 File Offset: 0x000E64D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRecyleTimeScRsp> Parser
		{
			get
			{
				return GetRecyleTimeScRsp._parser;
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x000E82DC File Offset: 0x000E64DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRecyleTimeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06005697 RID: 22167 RVA: 0x000E82EE File Offset: 0x000E64EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRecyleTimeScRsp.Descriptor;
			}
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x000E82F5 File Offset: 0x000E64F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRecyleTimeScRsp()
		{
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x000E8308 File Offset: 0x000E6508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRecyleTimeScRsp(GetRecyleTimeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.hNBHLCAKAJG_ = other.hNBHLCAKAJG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x000E833E File Offset: 0x000E653E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRecyleTimeScRsp Clone()
		{
			return new GetRecyleTimeScRsp(this);
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x0600569B RID: 22171 RVA: 0x000E8346 File Offset: 0x000E6546
		// (set) Token: 0x0600569C RID: 22172 RVA: 0x000E834E File Offset: 0x000E654E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x0600569D RID: 22173 RVA: 0x000E8357 File Offset: 0x000E6557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Material0> HNBHLCAKAJG
		{
			get
			{
				return this.hNBHLCAKAJG_;
			}
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x000E835F File Offset: 0x000E655F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRecyleTimeScRsp);
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x000E8370 File Offset: 0x000E6570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRecyleTimeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.hNBHLCAKAJG_.Equals(other.hNBHLCAKAJG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x000E83C0 File Offset: 0x000E65C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.hNBHLCAKAJG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x000E840D File Offset: 0x000E660D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x000E8415 File Offset: 0x000E6615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x000E8420 File Offset: 0x000E6620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.hNBHLCAKAJG_.WriteTo(ref output, GetRecyleTimeScRsp._repeated_hNBHLCAKAJG_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x000E8470 File Offset: 0x000E6670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.hNBHLCAKAJG_.CalculateSize(GetRecyleTimeScRsp._repeated_hNBHLCAKAJG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x000E84C4 File Offset: 0x000E66C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRecyleTimeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.hNBHLCAKAJG_.Add(other.hNBHLCAKAJG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x000E8511 File Offset: 0x000E6711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x000E851C File Offset: 0x000E671C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.hNBHLCAKAJG_.AddEntriesFrom(ref input, GetRecyleTimeScRsp._repeated_hNBHLCAKAJG_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040021E3 RID: 8675
		private static readonly MessageParser<GetRecyleTimeScRsp> _parser = new MessageParser<GetRecyleTimeScRsp>(() => new GetRecyleTimeScRsp());

		// Token: 0x040021E4 RID: 8676
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021E5 RID: 8677
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040021E6 RID: 8678
		private uint retcode_;

		// Token: 0x040021E7 RID: 8679
		public const int HNBHLCAKAJGFieldNumber = 10;

		// Token: 0x040021E8 RID: 8680
		private static readonly FieldCodec<Material0> _repeated_hNBHLCAKAJG_codec = FieldCodec.ForMessage<Material0>(82U, Material0.Parser);

		// Token: 0x040021E9 RID: 8681
		private readonly RepeatedField<Material0> hNBHLCAKAJG_ = new RepeatedField<Material0>();
	}
}

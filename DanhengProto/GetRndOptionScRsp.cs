using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200079F RID: 1951
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRndOptionScRsp : IMessage<GetRndOptionScRsp>, IMessage, IEquatable<GetRndOptionScRsp>, IDeepCloneable<GetRndOptionScRsp>, IBufferMessage
	{
		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06005725 RID: 22309 RVA: 0x000E99FC File Offset: 0x000E7BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRndOptionScRsp> Parser
		{
			get
			{
				return GetRndOptionScRsp._parser;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06005726 RID: 22310 RVA: 0x000E9A03 File Offset: 0x000E7C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRndOptionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06005727 RID: 22311 RVA: 0x000E9A15 File Offset: 0x000E7C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRndOptionScRsp.Descriptor;
			}
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x000E9A1C File Offset: 0x000E7C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRndOptionScRsp()
		{
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x000E9A2F File Offset: 0x000E7C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRndOptionScRsp(GetRndOptionScRsp other) : this()
		{
			this.pDCOBMFKKEI_ = other.pDCOBMFKKEI_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x000E9A65 File Offset: 0x000E7C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRndOptionScRsp Clone()
		{
			return new GetRndOptionScRsp(this);
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600572B RID: 22315 RVA: 0x000E9A6D File Offset: 0x000E7C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PDCOBMFKKEI
		{
			get
			{
				return this.pDCOBMFKKEI_;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600572C RID: 22316 RVA: 0x000E9A75 File Offset: 0x000E7C75
		// (set) Token: 0x0600572D RID: 22317 RVA: 0x000E9A7D File Offset: 0x000E7C7D
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

		// Token: 0x0600572E RID: 22318 RVA: 0x000E9A86 File Offset: 0x000E7C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRndOptionScRsp);
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x000E9A94 File Offset: 0x000E7C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRndOptionScRsp other)
		{
			return other != null && (other == this || (this.pDCOBMFKKEI_.Equals(other.pDCOBMFKKEI_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x000E9AE4 File Offset: 0x000E7CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pDCOBMFKKEI_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x000E9B31 File Offset: 0x000E7D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x000E9B39 File Offset: 0x000E7D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x000E9B44 File Offset: 0x000E7D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pDCOBMFKKEI_.WriteTo(ref output, GetRndOptionScRsp._repeated_pDCOBMFKKEI_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x000E9B94 File Offset: 0x000E7D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pDCOBMFKKEI_.CalculateSize(GetRndOptionScRsp._repeated_pDCOBMFKKEI_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x000E9BE8 File Offset: 0x000E7DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRndOptionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.pDCOBMFKKEI_.Add(other.pDCOBMFKKEI_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x000E9C35 File Offset: 0x000E7E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x000E9C40 File Offset: 0x000E7E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U && num != 98U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.pDCOBMFKKEI_.AddEntriesFrom(ref input, GetRndOptionScRsp._repeated_pDCOBMFKKEI_codec);
				}
			}
		}

		// Token: 0x04002217 RID: 8727
		private static readonly MessageParser<GetRndOptionScRsp> _parser = new MessageParser<GetRndOptionScRsp>(() => new GetRndOptionScRsp());

		// Token: 0x04002218 RID: 8728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002219 RID: 8729
		public const int PDCOBMFKKEIFieldNumber = 12;

		// Token: 0x0400221A RID: 8730
		private static readonly FieldCodec<uint> _repeated_pDCOBMFKKEI_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x0400221B RID: 8731
		private readonly RepeatedField<uint> pDCOBMFKKEI_ = new RepeatedField<uint>();

		// Token: 0x0400221C RID: 8732
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400221D RID: 8733
		private uint retcode_;
	}
}

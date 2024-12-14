using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007FF RID: 2047
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSocialEventServerCacheScRsp : IMessage<GetSocialEventServerCacheScRsp>, IMessage, IEquatable<GetSocialEventServerCacheScRsp>, IDeepCloneable<GetSocialEventServerCacheScRsp>, IBufferMessage
	{
		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06005B4E RID: 23374 RVA: 0x000F329F File Offset: 0x000F149F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSocialEventServerCacheScRsp> Parser
		{
			get
			{
				return GetSocialEventServerCacheScRsp._parser;
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x000F32A6 File Offset: 0x000F14A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSocialEventServerCacheScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x000F32B8 File Offset: 0x000F14B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSocialEventServerCacheScRsp.Descriptor;
			}
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x000F32BF File Offset: 0x000F14BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSocialEventServerCacheScRsp()
		{
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x000F32D2 File Offset: 0x000F14D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSocialEventServerCacheScRsp(GetSocialEventServerCacheScRsp other) : this()
		{
			this.pPFLDEOKIFI_ = other.pPFLDEOKIFI_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x000F3308 File Offset: 0x000F1508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSocialEventServerCacheScRsp Clone()
		{
			return new GetSocialEventServerCacheScRsp(this);
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06005B54 RID: 23380 RVA: 0x000F3310 File Offset: 0x000F1510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SocialEventServerCache> PPFLDEOKIFI
		{
			get
			{
				return this.pPFLDEOKIFI_;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06005B55 RID: 23381 RVA: 0x000F3318 File Offset: 0x000F1518
		// (set) Token: 0x06005B56 RID: 23382 RVA: 0x000F3320 File Offset: 0x000F1520
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

		// Token: 0x06005B57 RID: 23383 RVA: 0x000F3329 File Offset: 0x000F1529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSocialEventServerCacheScRsp);
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x000F3338 File Offset: 0x000F1538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSocialEventServerCacheScRsp other)
		{
			return other != null && (other == this || (this.pPFLDEOKIFI_.Equals(other.pPFLDEOKIFI_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x000F3388 File Offset: 0x000F1588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pPFLDEOKIFI_.GetHashCode();
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

		// Token: 0x06005B5A RID: 23386 RVA: 0x000F33D5 File Offset: 0x000F15D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x000F33DD File Offset: 0x000F15DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x000F33E8 File Offset: 0x000F15E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.pPFLDEOKIFI_.WriteTo(ref output, GetSocialEventServerCacheScRsp._repeated_pPFLDEOKIFI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x000F3438 File Offset: 0x000F1638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pPFLDEOKIFI_.CalculateSize(GetSocialEventServerCacheScRsp._repeated_pPFLDEOKIFI_codec);
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

		// Token: 0x06005B5E RID: 23390 RVA: 0x000F348C File Offset: 0x000F168C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSocialEventServerCacheScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.pPFLDEOKIFI_.Add(other.pPFLDEOKIFI_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x000F34D9 File Offset: 0x000F16D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x000F34E4 File Offset: 0x000F16E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.pPFLDEOKIFI_.AddEntriesFrom(ref input, GetSocialEventServerCacheScRsp._repeated_pPFLDEOKIFI_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002362 RID: 9058
		private static readonly MessageParser<GetSocialEventServerCacheScRsp> _parser = new MessageParser<GetSocialEventServerCacheScRsp>(() => new GetSocialEventServerCacheScRsp());

		// Token: 0x04002363 RID: 9059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002364 RID: 9060
		public const int PPFLDEOKIFIFieldNumber = 13;

		// Token: 0x04002365 RID: 9061
		private static readonly FieldCodec<SocialEventServerCache> _repeated_pPFLDEOKIFI_codec = FieldCodec.ForMessage<SocialEventServerCache>(106U, SocialEventServerCache.Parser);

		// Token: 0x04002366 RID: 9062
		private readonly RepeatedField<SocialEventServerCache> pPFLDEOKIFI_ = new RepeatedField<SocialEventServerCache>();

		// Token: 0x04002367 RID: 9063
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04002368 RID: 9064
		private uint retcode_;
	}
}

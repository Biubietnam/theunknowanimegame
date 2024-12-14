using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200064D RID: 1613
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChapterScRsp : IMessage<GetChapterScRsp>, IMessage, IEquatable<GetChapterScRsp>, IDeepCloneable<GetChapterScRsp>, IBufferMessage
	{
		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x000C6039 File Offset: 0x000C4239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChapterScRsp> Parser
		{
			get
			{
				return GetChapterScRsp._parser;
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06004861 RID: 18529 RVA: 0x000C6040 File Offset: 0x000C4240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChapterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06004862 RID: 18530 RVA: 0x000C6052 File Offset: 0x000C4252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChapterScRsp.Descriptor;
			}
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x000C6059 File Offset: 0x000C4259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterScRsp()
		{
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x000C606C File Offset: 0x000C426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterScRsp(GetChapterScRsp other) : this()
		{
			this.mBIICLDDNFF_ = other.mBIICLDDNFF_.Clone();
			this.retcode_ = other.retcode_;
			this.fALDHGHICGI_ = other.fALDHGHICGI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x000C60B9 File Offset: 0x000C42B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterScRsp Clone()
		{
			return new GetChapterScRsp(this);
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x000C60C1 File Offset: 0x000C42C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChapterBrief> MBIICLDDNFF
		{
			get
			{
				return this.mBIICLDDNFF_;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x000C60C9 File Offset: 0x000C42C9
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x000C60D1 File Offset: 0x000C42D1
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

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x000C60DA File Offset: 0x000C42DA
		// (set) Token: 0x0600486A RID: 18538 RVA: 0x000C60E2 File Offset: 0x000C42E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FALDHGHICGI
		{
			get
			{
				return this.fALDHGHICGI_;
			}
			set
			{
				this.fALDHGHICGI_ = value;
			}
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x000C60EB File Offset: 0x000C42EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChapterScRsp);
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x000C60FC File Offset: 0x000C42FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChapterScRsp other)
		{
			return other != null && (other == this || (this.mBIICLDDNFF_.Equals(other.mBIICLDDNFF_) && this.Retcode == other.Retcode && this.FALDHGHICGI == other.FALDHGHICGI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x000C615C File Offset: 0x000C435C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mBIICLDDNFF_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.FALDHGHICGI != 0U)
			{
				num ^= this.FALDHGHICGI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x000C61C2 File Offset: 0x000C43C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x000C61CA File Offset: 0x000C43CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x000C61D4 File Offset: 0x000C43D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.FALDHGHICGI != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.FALDHGHICGI);
			}
			this.mBIICLDDNFF_.WriteTo(ref output, GetChapterScRsp._repeated_mBIICLDDNFF_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x000C6240 File Offset: 0x000C4440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mBIICLDDNFF_.CalculateSize(GetChapterScRsp._repeated_mBIICLDDNFF_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.FALDHGHICGI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FALDHGHICGI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x000C62AC File Offset: 0x000C44AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChapterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.mBIICLDDNFF_.Add(other.mBIICLDDNFF_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.FALDHGHICGI != 0U)
			{
				this.FALDHGHICGI = other.FALDHGHICGI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x000C630D File Offset: 0x000C450D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x000C6318 File Offset: 0x000C4518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.mBIICLDDNFF_.AddEntriesFrom(ref input, GetChapterScRsp._repeated_mBIICLDDNFF_codec);
						}
					}
					else
					{
						this.FALDHGHICGI = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CEE RID: 7406
		private static readonly MessageParser<GetChapterScRsp> _parser = new MessageParser<GetChapterScRsp>(() => new GetChapterScRsp());

		// Token: 0x04001CEF RID: 7407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CF0 RID: 7408
		public const int MBIICLDDNFFFieldNumber = 13;

		// Token: 0x04001CF1 RID: 7409
		private static readonly FieldCodec<ChapterBrief> _repeated_mBIICLDDNFF_codec = FieldCodec.ForMessage<ChapterBrief>(106U, ChapterBrief.Parser);

		// Token: 0x04001CF2 RID: 7410
		private readonly RepeatedField<ChapterBrief> mBIICLDDNFF_ = new RepeatedField<ChapterBrief>();

		// Token: 0x04001CF3 RID: 7411
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001CF4 RID: 7412
		private uint retcode_;

		// Token: 0x04001CF5 RID: 7413
		public const int FALDHGHICGIFieldNumber = 6;

		// Token: 0x04001CF6 RID: 7414
		private uint fALDHGHICGI_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200076F RID: 1903
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlayerReplayInfoScRsp : IMessage<GetPlayerReplayInfoScRsp>, IMessage, IEquatable<GetPlayerReplayInfoScRsp>, IDeepCloneable<GetPlayerReplayInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06005504 RID: 21764 RVA: 0x000E4739 File Offset: 0x000E2939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlayerReplayInfoScRsp> Parser
		{
			get
			{
				return GetPlayerReplayInfoScRsp._parser;
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x000E4740 File Offset: 0x000E2940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlayerReplayInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x000E4752 File Offset: 0x000E2952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerReplayInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x000E4759 File Offset: 0x000E2959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReplayInfoScRsp()
		{
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x000E476C File Offset: 0x000E296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReplayInfoScRsp(GetPlayerReplayInfoScRsp other) : this()
		{
			this.cHIFEGNPPJP_ = other.cHIFEGNPPJP_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x000E47A2 File Offset: 0x000E29A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReplayInfoScRsp Clone()
		{
			return new GetPlayerReplayInfoScRsp(this);
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x000E47AA File Offset: 0x000E29AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ReplayInfo> CHIFEGNPPJP
		{
			get
			{
				return this.cHIFEGNPPJP_;
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x0600550B RID: 21771 RVA: 0x000E47B2 File Offset: 0x000E29B2
		// (set) Token: 0x0600550C RID: 21772 RVA: 0x000E47BA File Offset: 0x000E29BA
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

		// Token: 0x0600550D RID: 21773 RVA: 0x000E47C3 File Offset: 0x000E29C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerReplayInfoScRsp);
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x000E47D4 File Offset: 0x000E29D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlayerReplayInfoScRsp other)
		{
			return other != null && (other == this || (this.cHIFEGNPPJP_.Equals(other.cHIFEGNPPJP_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x000E4824 File Offset: 0x000E2A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cHIFEGNPPJP_.GetHashCode();
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

		// Token: 0x06005510 RID: 21776 RVA: 0x000E4871 File Offset: 0x000E2A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x000E4879 File Offset: 0x000E2A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x000E4884 File Offset: 0x000E2A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cHIFEGNPPJP_.WriteTo(ref output, GetPlayerReplayInfoScRsp._repeated_cHIFEGNPPJP_codec);
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

		// Token: 0x06005513 RID: 21779 RVA: 0x000E48D4 File Offset: 0x000E2AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cHIFEGNPPJP_.CalculateSize(GetPlayerReplayInfoScRsp._repeated_cHIFEGNPPJP_codec);
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

		// Token: 0x06005514 RID: 21780 RVA: 0x000E4928 File Offset: 0x000E2B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlayerReplayInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.cHIFEGNPPJP_.Add(other.cHIFEGNPPJP_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x000E4975 File Offset: 0x000E2B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x000E4980 File Offset: 0x000E2B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
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
					this.cHIFEGNPPJP_.AddEntriesFrom(ref input, GetPlayerReplayInfoScRsp._repeated_cHIFEGNPPJP_codec);
				}
			}
		}

		// Token: 0x04002158 RID: 8536
		private static readonly MessageParser<GetPlayerReplayInfoScRsp> _parser = new MessageParser<GetPlayerReplayInfoScRsp>(() => new GetPlayerReplayInfoScRsp());

		// Token: 0x04002159 RID: 8537
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400215A RID: 8538
		public const int CHIFEGNPPJPFieldNumber = 2;

		// Token: 0x0400215B RID: 8539
		private static readonly FieldCodec<ReplayInfo> _repeated_cHIFEGNPPJP_codec = FieldCodec.ForMessage<ReplayInfo>(18U, ReplayInfo.Parser);

		// Token: 0x0400215C RID: 8540
		private readonly RepeatedField<ReplayInfo> cHIFEGNPPJP_ = new RepeatedField<ReplayInfo>();

		// Token: 0x0400215D RID: 8541
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400215E RID: 8542
		private uint retcode_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200084B RID: 2123
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetVideoVersionKeyScRsp : IMessage<GetVideoVersionKeyScRsp>, IMessage, IEquatable<GetVideoVersionKeyScRsp>, IDeepCloneable<GetVideoVersionKeyScRsp>, IBufferMessage
	{
		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06005E62 RID: 24162 RVA: 0x000F9D87 File Offset: 0x000F7F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetVideoVersionKeyScRsp> Parser
		{
			get
			{
				return GetVideoVersionKeyScRsp._parser;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06005E63 RID: 24163 RVA: 0x000F9D8E File Offset: 0x000F7F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetVideoVersionKeyScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06005E64 RID: 24164 RVA: 0x000F9DA0 File Offset: 0x000F7FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetVideoVersionKeyScRsp.Descriptor;
			}
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x000F9DA7 File Offset: 0x000F7FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetVideoVersionKeyScRsp()
		{
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x000F9DC8 File Offset: 0x000F7FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetVideoVersionKeyScRsp(GetVideoVersionKeyScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.videoKeyInfoList_ = other.videoKeyInfoList_.Clone();
			this.activityVideoKeyInfoList_ = other.activityVideoKeyInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x000F9E1A File Offset: 0x000F801A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetVideoVersionKeyScRsp Clone()
		{
			return new GetVideoVersionKeyScRsp(this);
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06005E68 RID: 24168 RVA: 0x000F9E22 File Offset: 0x000F8022
		// (set) Token: 0x06005E69 RID: 24169 RVA: 0x000F9E2A File Offset: 0x000F802A
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

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06005E6A RID: 24170 RVA: 0x000F9E33 File Offset: 0x000F8033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VideoKeyInfo> VideoKeyInfoList
		{
			get
			{
				return this.videoKeyInfoList_;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x000F9E3B File Offset: 0x000F803B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VideoKeyInfo> ActivityVideoKeyInfoList
		{
			get
			{
				return this.activityVideoKeyInfoList_;
			}
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x000F9E43 File Offset: 0x000F8043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetVideoVersionKeyScRsp);
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x000F9E54 File Offset: 0x000F8054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetVideoVersionKeyScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.videoKeyInfoList_.Equals(other.videoKeyInfoList_) && this.activityVideoKeyInfoList_.Equals(other.activityVideoKeyInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x000F9EB8 File Offset: 0x000F80B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.videoKeyInfoList_.GetHashCode();
			num ^= this.activityVideoKeyInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x000F9F13 File Offset: 0x000F8113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x000F9F1B File Offset: 0x000F811B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x000F9F24 File Offset: 0x000F8124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityVideoKeyInfoList_.WriteTo(ref output, GetVideoVersionKeyScRsp._repeated_activityVideoKeyInfoList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			this.videoKeyInfoList_.WriteTo(ref output, GetVideoVersionKeyScRsp._repeated_videoKeyInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x000F9F84 File Offset: 0x000F8184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.videoKeyInfoList_.CalculateSize(GetVideoVersionKeyScRsp._repeated_videoKeyInfoList_codec);
			num += this.activityVideoKeyInfoList_.CalculateSize(GetVideoVersionKeyScRsp._repeated_activityVideoKeyInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x000F9FE8 File Offset: 0x000F81E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetVideoVersionKeyScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.videoKeyInfoList_.Add(other.videoKeyInfoList_);
			this.activityVideoKeyInfoList_.Add(other.activityVideoKeyInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x000FA046 File Offset: 0x000F8246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x000FA050 File Offset: 0x000F8250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 72U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.videoKeyInfoList_.AddEntriesFrom(ref input, GetVideoVersionKeyScRsp._repeated_videoKeyInfoList_codec);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.activityVideoKeyInfoList_.AddEntriesFrom(ref input, GetVideoVersionKeyScRsp._repeated_activityVideoKeyInfoList_codec);
				}
			}
		}

		// Token: 0x04002457 RID: 9303
		private static readonly MessageParser<GetVideoVersionKeyScRsp> _parser = new MessageParser<GetVideoVersionKeyScRsp>(() => new GetVideoVersionKeyScRsp());

		// Token: 0x04002458 RID: 9304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002459 RID: 9305
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400245A RID: 9306
		private uint retcode_;

		// Token: 0x0400245B RID: 9307
		public const int VideoKeyInfoListFieldNumber = 14;

		// Token: 0x0400245C RID: 9308
		private static readonly FieldCodec<VideoKeyInfo> _repeated_videoKeyInfoList_codec = FieldCodec.ForMessage<VideoKeyInfo>(114U, VideoKeyInfo.Parser);

		// Token: 0x0400245D RID: 9309
		private readonly RepeatedField<VideoKeyInfo> videoKeyInfoList_ = new RepeatedField<VideoKeyInfo>();

		// Token: 0x0400245E RID: 9310
		public const int ActivityVideoKeyInfoListFieldNumber = 5;

		// Token: 0x0400245F RID: 9311
		private static readonly FieldCodec<VideoKeyInfo> _repeated_activityVideoKeyInfoList_codec = FieldCodec.ForMessage<VideoKeyInfo>(42U, VideoKeyInfo.Parser);

		// Token: 0x04002460 RID: 9312
		private readonly RepeatedField<VideoKeyInfo> activityVideoKeyInfoList_ = new RepeatedField<VideoKeyInfo>();
	}
}

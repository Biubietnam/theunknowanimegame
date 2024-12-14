using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000689 RID: 1673
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetEnhanceCommonRogueBuffInfoScRsp : IMessage<GetEnhanceCommonRogueBuffInfoScRsp>, IMessage, IEquatable<GetEnhanceCommonRogueBuffInfoScRsp>, IDeepCloneable<GetEnhanceCommonRogueBuffInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x000CBEB1 File Offset: 0x000CA0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetEnhanceCommonRogueBuffInfoScRsp> Parser
		{
			get
			{
				return GetEnhanceCommonRogueBuffInfoScRsp._parser;
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x000CBEB8 File Offset: 0x000CA0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetEnhanceCommonRogueBuffInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06004AF7 RID: 19191 RVA: 0x000CBECA File Offset: 0x000CA0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetEnhanceCommonRogueBuffInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x000CBED1 File Offset: 0x000CA0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnhanceCommonRogueBuffInfoScRsp()
		{
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x000CBEE4 File Offset: 0x000CA0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnhanceCommonRogueBuffInfoScRsp(GetEnhanceCommonRogueBuffInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.enhancedBuffIdList_ = other.enhancedBuffIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x000CBF1A File Offset: 0x000CA11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnhanceCommonRogueBuffInfoScRsp Clone()
		{
			return new GetEnhanceCommonRogueBuffInfoScRsp(this);
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x000CBF22 File Offset: 0x000CA122
		// (set) Token: 0x06004AFC RID: 19196 RVA: 0x000CBF2A File Offset: 0x000CA12A
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

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06004AFD RID: 19197 RVA: 0x000CBF33 File Offset: 0x000CA133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EnhancedBuffIdList
		{
			get
			{
				return this.enhancedBuffIdList_;
			}
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x000CBF3B File Offset: 0x000CA13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetEnhanceCommonRogueBuffInfoScRsp);
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x000CBF4C File Offset: 0x000CA14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetEnhanceCommonRogueBuffInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.enhancedBuffIdList_.Equals(other.enhancedBuffIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x000CBF9C File Offset: 0x000CA19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.enhancedBuffIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x000CBFE9 File Offset: 0x000CA1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x000CBFF1 File Offset: 0x000CA1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x000CBFFC File Offset: 0x000CA1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			this.enhancedBuffIdList_.WriteTo(ref output, GetEnhanceCommonRogueBuffInfoScRsp._repeated_enhancedBuffIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x000CC04C File Offset: 0x000CA24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.enhancedBuffIdList_.CalculateSize(GetEnhanceCommonRogueBuffInfoScRsp._repeated_enhancedBuffIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x000CC0A0 File Offset: 0x000CA2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetEnhanceCommonRogueBuffInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.enhancedBuffIdList_.Add(other.enhancedBuffIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x000CC0ED File Offset: 0x000CA2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x000CC0F8 File Offset: 0x000CA2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.enhancedBuffIdList_.AddEntriesFrom(ref input, GetEnhanceCommonRogueBuffInfoScRsp._repeated_enhancedBuffIdList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001DBD RID: 7613
		private static readonly MessageParser<GetEnhanceCommonRogueBuffInfoScRsp> _parser = new MessageParser<GetEnhanceCommonRogueBuffInfoScRsp>(() => new GetEnhanceCommonRogueBuffInfoScRsp());

		// Token: 0x04001DBE RID: 7614
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DBF RID: 7615
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001DC0 RID: 7616
		private uint retcode_;

		// Token: 0x04001DC1 RID: 7617
		public const int EnhancedBuffIdListFieldNumber = 8;

		// Token: 0x04001DC2 RID: 7618
		private static readonly FieldCodec<uint> _repeated_enhancedBuffIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04001DC3 RID: 7619
		private readonly RepeatedField<uint> enhancedBuffIdList_ = new RepeatedField<uint>();
	}
}

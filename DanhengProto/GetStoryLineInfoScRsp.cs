using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200080F RID: 2063
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStoryLineInfoScRsp : IMessage<GetStoryLineInfoScRsp>, IMessage, IEquatable<GetStoryLineInfoScRsp>, IDeepCloneable<GetStoryLineInfoScRsp>, IBufferMessage
	{
		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06005BF5 RID: 23541 RVA: 0x000F482F File Offset: 0x000F2A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStoryLineInfoScRsp> Parser
		{
			get
			{
				return GetStoryLineInfoScRsp._parser;
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06005BF6 RID: 23542 RVA: 0x000F4836 File Offset: 0x000F2A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStoryLineInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06005BF7 RID: 23543 RVA: 0x000F4848 File Offset: 0x000F2A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStoryLineInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x000F484F File Offset: 0x000F2A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStoryLineInfoScRsp()
		{
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x000F4870 File Offset: 0x000F2A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStoryLineInfoScRsp(GetStoryLineInfoScRsp other) : this()
		{
			this.curStoryLineId_ = other.curStoryLineId_;
			this.retcode_ = other.retcode_;
			this.unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x000F48CE File Offset: 0x000F2ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStoryLineInfoScRsp Clone()
		{
			return new GetStoryLineInfoScRsp(this);
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06005BFB RID: 23547 RVA: 0x000F48D6 File Offset: 0x000F2AD6
		// (set) Token: 0x06005BFC RID: 23548 RVA: 0x000F48DE File Offset: 0x000F2ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurStoryLineId
		{
			get
			{
				return this.curStoryLineId_;
			}
			set
			{
				this.curStoryLineId_ = value;
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06005BFD RID: 23549 RVA: 0x000F48E7 File Offset: 0x000F2AE7
		// (set) Token: 0x06005BFE RID: 23550 RVA: 0x000F48EF File Offset: 0x000F2AEF
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

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06005BFF RID: 23551 RVA: 0x000F48F8 File Offset: 0x000F2AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnfinishedStoryLineIdList
		{
			get
			{
				return this.unfinishedStoryLineIdList_;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06005C00 RID: 23552 RVA: 0x000F4900 File Offset: 0x000F2B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x000F4908 File Offset: 0x000F2B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStoryLineInfoScRsp);
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x000F4918 File Offset: 0x000F2B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStoryLineInfoScRsp other)
		{
			return other != null && (other == this || (this.CurStoryLineId == other.CurStoryLineId && this.Retcode == other.Retcode && this.unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_) && this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x000F498C File Offset: 0x000F2B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurStoryLineId != 0U)
			{
				num ^= this.CurStoryLineId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.unfinishedStoryLineIdList_.GetHashCode();
			num ^= this.trialAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x000F4A00 File Offset: 0x000F2C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x000F4A08 File Offset: 0x000F2C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x000F4A14 File Offset: 0x000F2C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurStoryLineId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CurStoryLineId);
			}
			this.unfinishedStoryLineIdList_.WriteTo(ref output, GetStoryLineInfoScRsp._repeated_unfinishedStoryLineIdList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.trialAvatarIdList_.WriteTo(ref output, GetStoryLineInfoScRsp._repeated_trialAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x000F4A90 File Offset: 0x000F2C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurStoryLineId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.unfinishedStoryLineIdList_.CalculateSize(GetStoryLineInfoScRsp._repeated_unfinishedStoryLineIdList_codec);
			num += this.trialAvatarIdList_.CalculateSize(GetStoryLineInfoScRsp._repeated_trialAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x000F4B0C File Offset: 0x000F2D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStoryLineInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurStoryLineId != 0U)
			{
				this.CurStoryLineId = other.CurStoryLineId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x000F4B7E File Offset: 0x000F2D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x000F4B88 File Offset: 0x000F2D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 16U)
					{
						this.CurStoryLineId = input.ReadUInt32();
						continue;
					}
					if (num == 24U || num == 26U)
					{
						this.unfinishedStoryLineIdList_.AddEntriesFrom(ref input, GetStoryLineInfoScRsp._repeated_unfinishedStoryLineIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U || num == 106U)
					{
						this.trialAvatarIdList_.AddEntriesFrom(ref input, GetStoryLineInfoScRsp._repeated_trialAvatarIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400238F RID: 9103
		private static readonly MessageParser<GetStoryLineInfoScRsp> _parser = new MessageParser<GetStoryLineInfoScRsp>(() => new GetStoryLineInfoScRsp());

		// Token: 0x04002390 RID: 9104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002391 RID: 9105
		public const int CurStoryLineIdFieldNumber = 2;

		// Token: 0x04002392 RID: 9106
		private uint curStoryLineId_;

		// Token: 0x04002393 RID: 9107
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002394 RID: 9108
		private uint retcode_;

		// Token: 0x04002395 RID: 9109
		public const int UnfinishedStoryLineIdListFieldNumber = 3;

		// Token: 0x04002396 RID: 9110
		private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002397 RID: 9111
		private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

		// Token: 0x04002398 RID: 9112
		public const int TrialAvatarIdListFieldNumber = 13;

		// Token: 0x04002399 RID: 9113
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x0400239A RID: 9114
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();
	}
}

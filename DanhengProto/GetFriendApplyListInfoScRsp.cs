using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006B3 RID: 1715
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendApplyListInfoScRsp : IMessage<GetFriendApplyListInfoScRsp>, IMessage, IEquatable<GetFriendApplyListInfoScRsp>, IDeepCloneable<GetFriendApplyListInfoScRsp>, IBufferMessage
	{
		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06004CBA RID: 19642 RVA: 0x000CFFBF File Offset: 0x000CE1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendApplyListInfoScRsp> Parser
		{
			get
			{
				return GetFriendApplyListInfoScRsp._parser;
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06004CBB RID: 19643 RVA: 0x000CFFC6 File Offset: 0x000CE1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendApplyListInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x000CFFD8 File Offset: 0x000CE1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendApplyListInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x000CFFDF File Offset: 0x000CE1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendApplyListInfoScRsp()
		{
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x000D0000 File Offset: 0x000CE200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendApplyListInfoScRsp(GetFriendApplyListInfoScRsp other) : this()
		{
			this.receiveApplyList_ = other.receiveApplyList_.Clone();
			this.sendApplyList_ = other.sendApplyList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x000D0052 File Offset: 0x000CE252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendApplyListInfoScRsp Clone()
		{
			return new GetFriendApplyListInfoScRsp(this);
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x000D005A File Offset: 0x000CE25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendApplyInfo> ReceiveApplyList
		{
			get
			{
				return this.receiveApplyList_;
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x000D0062 File Offset: 0x000CE262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SendApplyList
		{
			get
			{
				return this.sendApplyList_;
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x000D006A File Offset: 0x000CE26A
		// (set) Token: 0x06004CC3 RID: 19651 RVA: 0x000D0072 File Offset: 0x000CE272
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

		// Token: 0x06004CC4 RID: 19652 RVA: 0x000D007B File Offset: 0x000CE27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendApplyListInfoScRsp);
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x000D008C File Offset: 0x000CE28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendApplyListInfoScRsp other)
		{
			return other != null && (other == this || (this.receiveApplyList_.Equals(other.receiveApplyList_) && this.sendApplyList_.Equals(other.sendApplyList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x000D00F0 File Offset: 0x000CE2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.receiveApplyList_.GetHashCode();
			num ^= this.sendApplyList_.GetHashCode();
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

		// Token: 0x06004CC7 RID: 19655 RVA: 0x000D014B File Offset: 0x000CE34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x000D0153 File Offset: 0x000CE353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x000D015C File Offset: 0x000CE35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sendApplyList_.WriteTo(ref output, GetFriendApplyListInfoScRsp._repeated_sendApplyList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			this.receiveApplyList_.WriteTo(ref output, GetFriendApplyListInfoScRsp._repeated_receiveApplyList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x000D01BC File Offset: 0x000CE3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.receiveApplyList_.CalculateSize(GetFriendApplyListInfoScRsp._repeated_receiveApplyList_codec);
			num += this.sendApplyList_.CalculateSize(GetFriendApplyListInfoScRsp._repeated_sendApplyList_codec);
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

		// Token: 0x06004CCB RID: 19659 RVA: 0x000D0220 File Offset: 0x000CE420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendApplyListInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.receiveApplyList_.Add(other.receiveApplyList_);
			this.sendApplyList_.Add(other.sendApplyList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x000D027E File Offset: 0x000CE47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x000D0288 File Offset: 0x000CE488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.sendApplyList_.AddEntriesFrom(ref input, GetFriendApplyListInfoScRsp._repeated_sendApplyList_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.receiveApplyList_.AddEntriesFrom(ref input, GetFriendApplyListInfoScRsp._repeated_receiveApplyList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E56 RID: 7766
		private static readonly MessageParser<GetFriendApplyListInfoScRsp> _parser = new MessageParser<GetFriendApplyListInfoScRsp>(() => new GetFriendApplyListInfoScRsp());

		// Token: 0x04001E57 RID: 7767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E58 RID: 7768
		public const int ReceiveApplyListFieldNumber = 14;

		// Token: 0x04001E59 RID: 7769
		private static readonly FieldCodec<FriendApplyInfo> _repeated_receiveApplyList_codec = FieldCodec.ForMessage<FriendApplyInfo>(114U, FriendApplyInfo.Parser);

		// Token: 0x04001E5A RID: 7770
		private readonly RepeatedField<FriendApplyInfo> receiveApplyList_ = new RepeatedField<FriendApplyInfo>();

		// Token: 0x04001E5B RID: 7771
		public const int SendApplyListFieldNumber = 2;

		// Token: 0x04001E5C RID: 7772
		private static readonly FieldCodec<uint> _repeated_sendApplyList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04001E5D RID: 7773
		private readonly RepeatedField<uint> sendApplyList_ = new RepeatedField<uint>();

		// Token: 0x04001E5E RID: 7774
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04001E5F RID: 7775
		private uint retcode_;
	}
}

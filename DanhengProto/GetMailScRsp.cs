using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000707 RID: 1799
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMailScRsp : IMessage<GetMailScRsp>, IMessage, IEquatable<GetMailScRsp>, IDeepCloneable<GetMailScRsp>, IBufferMessage
	{
		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06005061 RID: 20577 RVA: 0x000D898F File Offset: 0x000D6B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMailScRsp> Parser
		{
			get
			{
				return GetMailScRsp._parser;
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x000D8996 File Offset: 0x000D6B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMailScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06005063 RID: 20579 RVA: 0x000D89A8 File Offset: 0x000D6BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMailScRsp.Descriptor;
			}
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x000D89AF File Offset: 0x000D6BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMailScRsp()
		{
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x000D89D0 File Offset: 0x000D6BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMailScRsp(GetMailScRsp other) : this()
		{
			this.noticeMailList_ = other.noticeMailList_.Clone();
			this.totalNum_ = other.totalNum_;
			this.isEnd_ = other.isEnd_;
			this.start_ = other.start_;
			this.retcode_ = other.retcode_;
			this.mailList_ = other.mailList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x000D8A46 File Offset: 0x000D6C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMailScRsp Clone()
		{
			return new GetMailScRsp(this);
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06005067 RID: 20583 RVA: 0x000D8A4E File Offset: 0x000D6C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientMail> NoticeMailList
		{
			get
			{
				return this.noticeMailList_;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x000D8A56 File Offset: 0x000D6C56
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x000D8A5E File Offset: 0x000D6C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalNum
		{
			get
			{
				return this.totalNum_;
			}
			set
			{
				this.totalNum_ = value;
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x000D8A67 File Offset: 0x000D6C67
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x000D8A6F File Offset: 0x000D6C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnd
		{
			get
			{
				return this.isEnd_;
			}
			set
			{
				this.isEnd_ = value;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x000D8A78 File Offset: 0x000D6C78
		// (set) Token: 0x0600506D RID: 20589 RVA: 0x000D8A80 File Offset: 0x000D6C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Start
		{
			get
			{
				return this.start_;
			}
			set
			{
				this.start_ = value;
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x000D8A89 File Offset: 0x000D6C89
		// (set) Token: 0x0600506F RID: 20591 RVA: 0x000D8A91 File Offset: 0x000D6C91
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

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06005070 RID: 20592 RVA: 0x000D8A9A File Offset: 0x000D6C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientMail> MailList
		{
			get
			{
				return this.mailList_;
			}
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x000D8AA2 File Offset: 0x000D6CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMailScRsp);
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x000D8AB0 File Offset: 0x000D6CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMailScRsp other)
		{
			return other != null && (other == this || (this.noticeMailList_.Equals(other.noticeMailList_) && this.TotalNum == other.TotalNum && this.IsEnd == other.IsEnd && this.Start == other.Start && this.Retcode == other.Retcode && this.mailList_.Equals(other.mailList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x000D8B44 File Offset: 0x000D6D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.noticeMailList_.GetHashCode();
			if (this.TotalNum != 0U)
			{
				num ^= this.TotalNum.GetHashCode();
			}
			if (this.IsEnd)
			{
				num ^= this.IsEnd.GetHashCode();
			}
			if (this.Start != 0U)
			{
				num ^= this.Start.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.mailList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x000D8BEA File Offset: 0x000D6DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x000D8BF2 File Offset: 0x000D6DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x000D8BFC File Offset: 0x000D6DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Start != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Start);
			}
			this.mailList_.WriteTo(ref output, GetMailScRsp._repeated_mailList_codec);
			if (this.IsEnd)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsEnd);
			}
			this.noticeMailList_.WriteTo(ref output, GetMailScRsp._repeated_noticeMailList_codec);
			if (this.TotalNum != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.TotalNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x000D8CB0 File Offset: 0x000D6EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.noticeMailList_.CalculateSize(GetMailScRsp._repeated_noticeMailList_codec);
			if (this.TotalNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TotalNum);
			}
			if (this.IsEnd)
			{
				num += 2;
			}
			if (this.Start != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Start);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.mailList_.CalculateSize(GetMailScRsp._repeated_mailList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x000D8D50 File Offset: 0x000D6F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMailScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.noticeMailList_.Add(other.noticeMailList_);
			if (other.TotalNum != 0U)
			{
				this.TotalNum = other.TotalNum;
			}
			if (other.IsEnd)
			{
				this.IsEnd = other.IsEnd;
			}
			if (other.Start != 0U)
			{
				this.Start = other.Start;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.mailList_.Add(other.mailList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x000D8DEA File Offset: 0x000D6FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x000D8DF4 File Offset: 0x000D6FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Start = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						this.mailList_.AddEntriesFrom(ref input, GetMailScRsp._repeated_mailList_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.IsEnd = input.ReadBool();
						continue;
					}
					if (num == 114U)
					{
						this.noticeMailList_.AddEntriesFrom(ref input, GetMailScRsp._repeated_noticeMailList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.TotalNum = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F97 RID: 8087
		private static readonly MessageParser<GetMailScRsp> _parser = new MessageParser<GetMailScRsp>(() => new GetMailScRsp());

		// Token: 0x04001F98 RID: 8088
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F99 RID: 8089
		public const int NoticeMailListFieldNumber = 14;

		// Token: 0x04001F9A RID: 8090
		private static readonly FieldCodec<ClientMail> _repeated_noticeMailList_codec = FieldCodec.ForMessage<ClientMail>(114U, ClientMail.Parser);

		// Token: 0x04001F9B RID: 8091
		private readonly RepeatedField<ClientMail> noticeMailList_ = new RepeatedField<ClientMail>();

		// Token: 0x04001F9C RID: 8092
		public const int TotalNumFieldNumber = 15;

		// Token: 0x04001F9D RID: 8093
		private uint totalNum_;

		// Token: 0x04001F9E RID: 8094
		public const int IsEndFieldNumber = 8;

		// Token: 0x04001F9F RID: 8095
		private bool isEnd_;

		// Token: 0x04001FA0 RID: 8096
		public const int StartFieldNumber = 6;

		// Token: 0x04001FA1 RID: 8097
		private uint start_;

		// Token: 0x04001FA2 RID: 8098
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001FA3 RID: 8099
		private uint retcode_;

		// Token: 0x04001FA4 RID: 8100
		public const int MailListFieldNumber = 7;

		// Token: 0x04001FA5 RID: 8101
		private static readonly FieldCodec<ClientMail> _repeated_mailList_codec = FieldCodec.ForMessage<ClientMail>(58U, ClientMail.Parser);

		// Token: 0x04001FA6 RID: 8102
		private readonly RepeatedField<ClientMail> mailList_ = new RepeatedField<ClientMail>();
	}
}

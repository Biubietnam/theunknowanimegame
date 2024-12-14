using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006CB RID: 1739
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendListInfoScRsp : IMessage<GetFriendListInfoScRsp>, IMessage, IEquatable<GetFriendListInfoScRsp>, IDeepCloneable<GetFriendListInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x000D2C13 File Offset: 0x000D0E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendListInfoScRsp> Parser
		{
			get
			{
				return GetFriendListInfoScRsp._parser;
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06004DD2 RID: 19922 RVA: 0x000D2C1A File Offset: 0x000D0E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendListInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x000D2C2C File Offset: 0x000D0E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendListInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x000D2C33 File Offset: 0x000D0E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendListInfoScRsp()
		{
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x000D2C54 File Offset: 0x000D0E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendListInfoScRsp(GetFriendListInfoScRsp other) : this()
		{
			this.blackList_ = other.blackList_.Clone();
			this.friendList_ = other.friendList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x000D2CA6 File Offset: 0x000D0EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendListInfoScRsp Clone()
		{
			return new GetFriendListInfoScRsp(this);
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06004DD7 RID: 19927 RVA: 0x000D2CAE File Offset: 0x000D0EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSimpleInfo> BlackList
		{
			get
			{
				return this.blackList_;
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x000D2CB6 File Offset: 0x000D0EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendSimpleInfo> FriendList
		{
			get
			{
				return this.friendList_;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06004DD9 RID: 19929 RVA: 0x000D2CBE File Offset: 0x000D0EBE
		// (set) Token: 0x06004DDA RID: 19930 RVA: 0x000D2CC6 File Offset: 0x000D0EC6
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

		// Token: 0x06004DDB RID: 19931 RVA: 0x000D2CCF File Offset: 0x000D0ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendListInfoScRsp);
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x000D2CE0 File Offset: 0x000D0EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendListInfoScRsp other)
		{
			return other != null && (other == this || (this.blackList_.Equals(other.blackList_) && this.friendList_.Equals(other.friendList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x000D2D44 File Offset: 0x000D0F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.blackList_.GetHashCode();
			num ^= this.friendList_.GetHashCode();
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

		// Token: 0x06004DDE RID: 19934 RVA: 0x000D2D9F File Offset: 0x000D0F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x000D2DA7 File Offset: 0x000D0FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x000D2DB0 File Offset: 0x000D0FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friendList_.WriteTo(ref output, GetFriendListInfoScRsp._repeated_friendList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.blackList_.WriteTo(ref output, GetFriendListInfoScRsp._repeated_blackList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x000D2E10 File Offset: 0x000D1010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.blackList_.CalculateSize(GetFriendListInfoScRsp._repeated_blackList_codec);
			num += this.friendList_.CalculateSize(GetFriendListInfoScRsp._repeated_friendList_codec);
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

		// Token: 0x06004DE2 RID: 19938 RVA: 0x000D2E74 File Offset: 0x000D1074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendListInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.blackList_.Add(other.blackList_);
			this.friendList_.Add(other.friendList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x000D2ED2 File Offset: 0x000D10D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x000D2EDC File Offset: 0x000D10DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 24U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.blackList_.AddEntriesFrom(ref input, GetFriendListInfoScRsp._repeated_blackList_codec);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.friendList_.AddEntriesFrom(ref input, GetFriendListInfoScRsp._repeated_friendList_codec);
				}
			}
		}

		// Token: 0x04001EBF RID: 7871
		private static readonly MessageParser<GetFriendListInfoScRsp> _parser = new MessageParser<GetFriendListInfoScRsp>(() => new GetFriendListInfoScRsp());

		// Token: 0x04001EC0 RID: 7872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EC1 RID: 7873
		public const int BlackListFieldNumber = 11;

		// Token: 0x04001EC2 RID: 7874
		private static readonly FieldCodec<PlayerSimpleInfo> _repeated_blackList_codec = FieldCodec.ForMessage<PlayerSimpleInfo>(90U, PlayerSimpleInfo.Parser);

		// Token: 0x04001EC3 RID: 7875
		private readonly RepeatedField<PlayerSimpleInfo> blackList_ = new RepeatedField<PlayerSimpleInfo>();

		// Token: 0x04001EC4 RID: 7876
		public const int FriendListFieldNumber = 2;

		// Token: 0x04001EC5 RID: 7877
		private static readonly FieldCodec<FriendSimpleInfo> _repeated_friendList_codec = FieldCodec.ForMessage<FriendSimpleInfo>(18U, FriendSimpleInfo.Parser);

		// Token: 0x04001EC6 RID: 7878
		private readonly RepeatedField<FriendSimpleInfo> friendList_ = new RepeatedField<FriendSimpleInfo>();

		// Token: 0x04001EC7 RID: 7879
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04001EC8 RID: 7880
		private uint retcode_;
	}
}

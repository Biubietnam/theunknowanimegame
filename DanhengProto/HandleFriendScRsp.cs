using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200088B RID: 2187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HandleFriendScRsp : IMessage<HandleFriendScRsp>, IMessage, IEquatable<HandleFriendScRsp>, IDeepCloneable<HandleFriendScRsp>, IBufferMessage
	{
		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06006143 RID: 24899 RVA: 0x0010103F File Offset: 0x000FF23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HandleFriendScRsp> Parser
		{
			get
			{
				return HandleFriendScRsp._parser;
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06006144 RID: 24900 RVA: 0x00101046 File Offset: 0x000FF246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HandleFriendScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06006145 RID: 24901 RVA: 0x00101058 File Offset: 0x000FF258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandleFriendScRsp.Descriptor;
			}
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x0010105F File Offset: 0x000FF25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleFriendScRsp()
		{
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x00101068 File Offset: 0x000FF268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleFriendScRsp(HandleFriendScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.friendInfo_ = ((other.friendInfo_ != null) ? other.friendInfo_.Clone() : null);
			this.uid_ = other.uid_;
			this.isAccept_ = other.isAccept_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x001010CC File Offset: 0x000FF2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleFriendScRsp Clone()
		{
			return new HandleFriendScRsp(this);
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06006149 RID: 24905 RVA: 0x001010D4 File Offset: 0x000FF2D4
		// (set) Token: 0x0600614A RID: 24906 RVA: 0x001010DC File Offset: 0x000FF2DC
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

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x0600614B RID: 24907 RVA: 0x001010E5 File Offset: 0x000FF2E5
		// (set) Token: 0x0600614C RID: 24908 RVA: 0x001010ED File Offset: 0x000FF2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendSimpleInfo FriendInfo
		{
			get
			{
				return this.friendInfo_;
			}
			set
			{
				this.friendInfo_ = value;
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x0600614D RID: 24909 RVA: 0x001010F6 File Offset: 0x000FF2F6
		// (set) Token: 0x0600614E RID: 24910 RVA: 0x001010FE File Offset: 0x000FF2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x0600614F RID: 24911 RVA: 0x00101107 File Offset: 0x000FF307
		// (set) Token: 0x06006150 RID: 24912 RVA: 0x0010110F File Offset: 0x000FF30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAccept
		{
			get
			{
				return this.isAccept_;
			}
			set
			{
				this.isAccept_ = value;
			}
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x00101118 File Offset: 0x000FF318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandleFriendScRsp);
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x00101128 File Offset: 0x000FF328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandleFriendScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.FriendInfo, other.FriendInfo) && this.Uid == other.Uid && this.IsAccept == other.IsAccept && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x00101198 File Offset: 0x000FF398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.friendInfo_ != null)
			{
				num ^= this.FriendInfo.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.IsAccept)
			{
				num ^= this.IsAccept.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x0010121F File Offset: 0x000FF41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x00101227 File Offset: 0x000FF427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x00101230 File Offset: 0x000FF430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Uid);
			}
			if (this.IsAccept)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsAccept);
			}
			if (this.friendInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.FriendInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x001012C0 File Offset: 0x000FF4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.friendInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FriendInfo);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.IsAccept)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x0010133C File Offset: 0x000FF53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandleFriendScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.friendInfo_ != null)
			{
				if (this.friendInfo_ == null)
				{
					this.FriendInfo = new FriendSimpleInfo();
				}
				this.FriendInfo.MergeFrom(other.FriendInfo);
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.IsAccept)
			{
				this.IsAccept = other.IsAccept;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x001013CC File Offset: 0x000FF5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x001013D8 File Offset: 0x000FF5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.IsAccept = input.ReadBool();
						continue;
					}
					if (num == 114U)
					{
						if (this.friendInfo_ == null)
						{
							this.FriendInfo = new FriendSimpleInfo();
						}
						input.ReadMessage(this.FriendInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400255B RID: 9563
		private static readonly MessageParser<HandleFriendScRsp> _parser = new MessageParser<HandleFriendScRsp>(() => new HandleFriendScRsp());

		// Token: 0x0400255C RID: 9564
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400255D RID: 9565
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400255E RID: 9566
		private uint retcode_;

		// Token: 0x0400255F RID: 9567
		public const int FriendInfoFieldNumber = 14;

		// Token: 0x04002560 RID: 9568
		private FriendSimpleInfo friendInfo_;

		// Token: 0x04002561 RID: 9569
		public const int UidFieldNumber = 3;

		// Token: 0x04002562 RID: 9570
		private uint uid_;

		// Token: 0x04002563 RID: 9571
		public const int IsAcceptFieldNumber = 5;

		// Token: 0x04002564 RID: 9572
		private bool isAccept_;
	}
}

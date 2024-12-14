using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000655 RID: 1621
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChatFriendHistoryScRsp : IMessage<GetChatFriendHistoryScRsp>, IMessage, IEquatable<GetChatFriendHistoryScRsp>, IDeepCloneable<GetChatFriendHistoryScRsp>, IBufferMessage
	{
		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x000C6B07 File Offset: 0x000C4D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChatFriendHistoryScRsp> Parser
		{
			get
			{
				return GetChatFriendHistoryScRsp._parser;
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x060048B5 RID: 18613 RVA: 0x000C6B0E File Offset: 0x000C4D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChatFriendHistoryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x000C6B20 File Offset: 0x000C4D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChatFriendHistoryScRsp.Descriptor;
			}
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x000C6B27 File Offset: 0x000C4D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatFriendHistoryScRsp()
		{
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x000C6B3A File Offset: 0x000C4D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatFriendHistoryScRsp(GetChatFriendHistoryScRsp other) : this()
		{
			this.friendHistoryInfo_ = other.friendHistoryInfo_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x000C6B70 File Offset: 0x000C4D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatFriendHistoryScRsp Clone()
		{
			return new GetChatFriendHistoryScRsp(this);
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x060048BA RID: 18618 RVA: 0x000C6B78 File Offset: 0x000C4D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendHistoryInfo> FriendHistoryInfo
		{
			get
			{
				return this.friendHistoryInfo_;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x060048BB RID: 18619 RVA: 0x000C6B80 File Offset: 0x000C4D80
		// (set) Token: 0x060048BC RID: 18620 RVA: 0x000C6B88 File Offset: 0x000C4D88
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

		// Token: 0x060048BD RID: 18621 RVA: 0x000C6B91 File Offset: 0x000C4D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChatFriendHistoryScRsp);
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x000C6BA0 File Offset: 0x000C4DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChatFriendHistoryScRsp other)
		{
			return other != null && (other == this || (this.friendHistoryInfo_.Equals(other.friendHistoryInfo_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x000C6BF0 File Offset: 0x000C4DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.friendHistoryInfo_.GetHashCode();
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

		// Token: 0x060048C0 RID: 18624 RVA: 0x000C6C3D File Offset: 0x000C4E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x000C6C45 File Offset: 0x000C4E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x000C6C50 File Offset: 0x000C4E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.friendHistoryInfo_.WriteTo(ref output, GetChatFriendHistoryScRsp._repeated_friendHistoryInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x000C6CA0 File Offset: 0x000C4EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.friendHistoryInfo_.CalculateSize(GetChatFriendHistoryScRsp._repeated_friendHistoryInfo_codec);
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

		// Token: 0x060048C4 RID: 18628 RVA: 0x000C6CF4 File Offset: 0x000C4EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChatFriendHistoryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.friendHistoryInfo_.Add(other.friendHistoryInfo_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x000C6D41 File Offset: 0x000C4F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x000C6D4C File Offset: 0x000C4F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.friendHistoryInfo_.AddEntriesFrom(ref input, GetChatFriendHistoryScRsp._repeated_friendHistoryInfo_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D06 RID: 7430
		private static readonly MessageParser<GetChatFriendHistoryScRsp> _parser = new MessageParser<GetChatFriendHistoryScRsp>(() => new GetChatFriendHistoryScRsp());

		// Token: 0x04001D07 RID: 7431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D08 RID: 7432
		public const int FriendHistoryInfoFieldNumber = 10;

		// Token: 0x04001D09 RID: 7433
		private static readonly FieldCodec<FriendHistoryInfo> _repeated_friendHistoryInfo_codec = FieldCodec.ForMessage<FriendHistoryInfo>(82U, EggLink.DanhengServer.Proto.FriendHistoryInfo.Parser);

		// Token: 0x04001D0A RID: 7434
		private readonly RepeatedField<FriendHistoryInfo> friendHistoryInfo_ = new RepeatedField<FriendHistoryInfo>();

		// Token: 0x04001D0B RID: 7435
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04001D0C RID: 7436
		private uint retcode_;
	}
}

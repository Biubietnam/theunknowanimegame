using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006D3 RID: 1747
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendRecommendListInfoScRsp : IMessage<GetFriendRecommendListInfoScRsp>, IMessage, IEquatable<GetFriendRecommendListInfoScRsp>, IDeepCloneable<GetFriendRecommendListInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06004E2B RID: 20011 RVA: 0x000D39AB File Offset: 0x000D1BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendRecommendListInfoScRsp> Parser
		{
			get
			{
				return GetFriendRecommendListInfoScRsp._parser;
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x000D39B2 File Offset: 0x000D1BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendRecommendListInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06004E2D RID: 20013 RVA: 0x000D39C4 File Offset: 0x000D1BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendRecommendListInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x000D39CB File Offset: 0x000D1BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendRecommendListInfoScRsp()
		{
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x000D39DE File Offset: 0x000D1BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendRecommendListInfoScRsp(GetFriendRecommendListInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.playerInfoList_ = other.playerInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x000D3A14 File Offset: 0x000D1C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendRecommendListInfoScRsp Clone()
		{
			return new GetFriendRecommendListInfoScRsp(this);
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06004E31 RID: 20017 RVA: 0x000D3A1C File Offset: 0x000D1C1C
		// (set) Token: 0x06004E32 RID: 20018 RVA: 0x000D3A24 File Offset: 0x000D1C24
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

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06004E33 RID: 20019 RVA: 0x000D3A2D File Offset: 0x000D1C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendRecommendInfo> PlayerInfoList
		{
			get
			{
				return this.playerInfoList_;
			}
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x000D3A35 File Offset: 0x000D1C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendRecommendListInfoScRsp);
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x000D3A44 File Offset: 0x000D1C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendRecommendListInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.playerInfoList_.Equals(other.playerInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x000D3A94 File Offset: 0x000D1C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.playerInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x000D3AE1 File Offset: 0x000D1CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x000D3AE9 File Offset: 0x000D1CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x000D3AF4 File Offset: 0x000D1CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.playerInfoList_.WriteTo(ref output, GetFriendRecommendListInfoScRsp._repeated_playerInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x000D3B44 File Offset: 0x000D1D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.playerInfoList_.CalculateSize(GetFriendRecommendListInfoScRsp._repeated_playerInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x000D3B98 File Offset: 0x000D1D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendRecommendListInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.playerInfoList_.Add(other.playerInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x000D3BE5 File Offset: 0x000D1DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x000D3BF0 File Offset: 0x000D1DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.playerInfoList_.AddEntriesFrom(ref input, GetFriendRecommendListInfoScRsp._repeated_playerInfoList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001EE1 RID: 7905
		private static readonly MessageParser<GetFriendRecommendListInfoScRsp> _parser = new MessageParser<GetFriendRecommendListInfoScRsp>(() => new GetFriendRecommendListInfoScRsp());

		// Token: 0x04001EE2 RID: 7906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EE3 RID: 7907
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04001EE4 RID: 7908
		private uint retcode_;

		// Token: 0x04001EE5 RID: 7909
		public const int PlayerInfoListFieldNumber = 15;

		// Token: 0x04001EE6 RID: 7910
		private static readonly FieldCodec<FriendRecommendInfo> _repeated_playerInfoList_codec = FieldCodec.ForMessage<FriendRecommendInfo>(122U, FriendRecommendInfo.Parser);

		// Token: 0x04001EE7 RID: 7911
		private readonly RepeatedField<FriendRecommendInfo> playerInfoList_ = new RepeatedField<FriendRecommendInfo>();
	}
}

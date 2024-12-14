using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006BD RID: 1725
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendChallengeDetailCsReq : IMessage<GetFriendChallengeDetailCsReq>, IMessage, IEquatable<GetFriendChallengeDetailCsReq>, IDeepCloneable<GetFriendChallengeDetailCsReq>, IBufferMessage
	{
		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06004D33 RID: 19763 RVA: 0x000D14FD File Offset: 0x000CF6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendChallengeDetailCsReq> Parser
		{
			get
			{
				return GetFriendChallengeDetailCsReq._parser;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x000D1504 File Offset: 0x000CF704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendChallengeDetailCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06004D35 RID: 19765 RVA: 0x000D1516 File Offset: 0x000CF716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendChallengeDetailCsReq.Descriptor;
			}
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x000D151D File Offset: 0x000CF71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeDetailCsReq()
		{
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x000D1525 File Offset: 0x000CF725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeDetailCsReq(GetFriendChallengeDetailCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x000D1556 File Offset: 0x000CF756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeDetailCsReq Clone()
		{
			return new GetFriendChallengeDetailCsReq(this);
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x000D155E File Offset: 0x000CF75E
		// (set) Token: 0x06004D3A RID: 19770 RVA: 0x000D1566 File Offset: 0x000CF766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06004D3B RID: 19771 RVA: 0x000D156F File Offset: 0x000CF76F
		// (set) Token: 0x06004D3C RID: 19772 RVA: 0x000D1577 File Offset: 0x000CF777
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

		// Token: 0x06004D3D RID: 19773 RVA: 0x000D1580 File Offset: 0x000CF780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendChallengeDetailCsReq);
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x000D158E File Offset: 0x000CF78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendChallengeDetailCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x000D15CC File Offset: 0x000CF7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x000D1624 File Offset: 0x000CF824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x000D162C File Offset: 0x000CF82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x000D1638 File Offset: 0x000CF838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x000D1690 File Offset: 0x000CF890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x000D16E8 File Offset: 0x000CF8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendChallengeDetailCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x000D1738 File Offset: 0x000CF938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x000D1744 File Offset: 0x000CF944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Uid = input.ReadUInt32();
					}
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001E8B RID: 7819
		private static readonly MessageParser<GetFriendChallengeDetailCsReq> _parser = new MessageParser<GetFriendChallengeDetailCsReq>(() => new GetFriendChallengeDetailCsReq());

		// Token: 0x04001E8C RID: 7820
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E8D RID: 7821
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04001E8E RID: 7822
		private uint challengeId_;

		// Token: 0x04001E8F RID: 7823
		public const int UidFieldNumber = 2;

		// Token: 0x04001E90 RID: 7824
		private uint uid_;
	}
}

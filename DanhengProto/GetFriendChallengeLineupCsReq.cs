using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006C1 RID: 1729
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendChallengeLineupCsReq : IMessage<GetFriendChallengeLineupCsReq>, IMessage, IEquatable<GetFriendChallengeLineupCsReq>, IDeepCloneable<GetFriendChallengeLineupCsReq>, IBufferMessage
	{
		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x000D1CFC File Offset: 0x000CFEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendChallengeLineupCsReq> Parser
		{
			get
			{
				return GetFriendChallengeLineupCsReq._parser;
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x000D1D03 File Offset: 0x000CFF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendChallengeLineupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x000D1D15 File Offset: 0x000CFF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendChallengeLineupCsReq.Descriptor;
			}
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x000D1D1C File Offset: 0x000CFF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeLineupCsReq()
		{
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x000D1D24 File Offset: 0x000CFF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeLineupCsReq(GetFriendChallengeLineupCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x000D1D49 File Offset: 0x000CFF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeLineupCsReq Clone()
		{
			return new GetFriendChallengeLineupCsReq(this);
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x000D1D51 File Offset: 0x000CFF51
		// (set) Token: 0x06004D6B RID: 19819 RVA: 0x000D1D59 File Offset: 0x000CFF59
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

		// Token: 0x06004D6C RID: 19820 RVA: 0x000D1D62 File Offset: 0x000CFF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendChallengeLineupCsReq);
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x000D1D70 File Offset: 0x000CFF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendChallengeLineupCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x000D1DA0 File Offset: 0x000CFFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x000D1DDF File Offset: 0x000CFFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x000D1DE7 File Offset: 0x000CFFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x000D1DF0 File Offset: 0x000CFFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x000D1E24 File Offset: 0x000D0024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x000D1E62 File Offset: 0x000D0062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendChallengeLineupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x000D1E93 File Offset: 0x000D0093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x000D1E9C File Offset: 0x000D009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001E9E RID: 7838
		private static readonly MessageParser<GetFriendChallengeLineupCsReq> _parser = new MessageParser<GetFriendChallengeLineupCsReq>(() => new GetFriendChallengeLineupCsReq());

		// Token: 0x04001E9F RID: 7839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EA0 RID: 7840
		public const int ChallengeIdFieldNumber = 12;

		// Token: 0x04001EA1 RID: 7841
		private uint challengeId_;
	}
}

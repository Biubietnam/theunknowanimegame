using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006BF RID: 1727
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendChallengeDetailScRsp : IMessage<GetFriendChallengeDetailScRsp>, IMessage, IEquatable<GetFriendChallengeDetailScRsp>, IDeepCloneable<GetFriendChallengeDetailScRsp>, IBufferMessage
	{
		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x000D186B File Offset: 0x000CFA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendChallengeDetailScRsp> Parser
		{
			get
			{
				return GetFriendChallengeDetailScRsp._parser;
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x000D1872 File Offset: 0x000CFA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendChallengeDetailScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x000D1884 File Offset: 0x000CFA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendChallengeDetailScRsp.Descriptor;
			}
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x000D188B File Offset: 0x000CFA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeDetailScRsp()
		{
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x000D18A0 File Offset: 0x000CFAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeDetailScRsp(GetFriendChallengeDetailScRsp other) : this()
		{
			this.uid_ = other.uid_;
			this.retcode_ = other.retcode_;
			this.dMDAFIBFJHP_ = other.dMDAFIBFJHP_.Clone();
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x000D18F9 File Offset: 0x000CFAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeDetailScRsp Clone()
		{
			return new GetFriendChallengeDetailScRsp(this);
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x000D1901 File Offset: 0x000CFB01
		// (set) Token: 0x06004D51 RID: 19793 RVA: 0x000D1909 File Offset: 0x000CFB09
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

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06004D52 RID: 19794 RVA: 0x000D1912 File Offset: 0x000CFB12
		// (set) Token: 0x06004D53 RID: 19795 RVA: 0x000D191A File Offset: 0x000CFB1A
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

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06004D54 RID: 19796 RVA: 0x000D1923 File Offset: 0x000CFB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DisplayAvatarDetailInfo> DMDAFIBFJHP
		{
			get
			{
				return this.dMDAFIBFJHP_;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x000D192B File Offset: 0x000CFB2B
		// (set) Token: 0x06004D56 RID: 19798 RVA: 0x000D1933 File Offset: 0x000CFB33
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

		// Token: 0x06004D57 RID: 19799 RVA: 0x000D193C File Offset: 0x000CFB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendChallengeDetailScRsp);
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x000D194C File Offset: 0x000CFB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendChallengeDetailScRsp other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.Retcode == other.Retcode && this.dMDAFIBFJHP_.Equals(other.dMDAFIBFJHP_) && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x000D19BC File Offset: 0x000CFBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.dMDAFIBFJHP_.GetHashCode();
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

		// Token: 0x06004D5A RID: 19802 RVA: 0x000D1A3B File Offset: 0x000CFC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x000D1A43 File Offset: 0x000CFC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x000D1A4C File Offset: 0x000CFC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ChallengeId);
			}
			this.dMDAFIBFJHP_.WriteTo(ref output, GetFriendChallengeDetailScRsp._repeated_dMDAFIBFJHP_codec);
			if (this.Uid != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Uid);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x000D1AD4 File Offset: 0x000CFCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.dMDAFIBFJHP_.CalculateSize(GetFriendChallengeDetailScRsp._repeated_dMDAFIBFJHP_codec);
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

		// Token: 0x06004D5E RID: 19806 RVA: 0x000D1B58 File Offset: 0x000CFD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendChallengeDetailScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.dMDAFIBFJHP_.Add(other.dMDAFIBFJHP_);
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x000D1BCD File Offset: 0x000CFDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x000D1BD8 File Offset: 0x000CFDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 32U)
					{
						this.ChallengeId = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						this.dMDAFIBFJHP_.AddEntriesFrom(ref input, GetFriendChallengeDetailScRsp._repeated_dMDAFIBFJHP_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E92 RID: 7826
		private static readonly MessageParser<GetFriendChallengeDetailScRsp> _parser = new MessageParser<GetFriendChallengeDetailScRsp>(() => new GetFriendChallengeDetailScRsp());

		// Token: 0x04001E93 RID: 7827
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E94 RID: 7828
		public const int UidFieldNumber = 7;

		// Token: 0x04001E95 RID: 7829
		private uint uid_;

		// Token: 0x04001E96 RID: 7830
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04001E97 RID: 7831
		private uint retcode_;

		// Token: 0x04001E98 RID: 7832
		public const int DMDAFIBFJHPFieldNumber = 5;

		// Token: 0x04001E99 RID: 7833
		private static readonly FieldCodec<DisplayAvatarDetailInfo> _repeated_dMDAFIBFJHP_codec = FieldCodec.ForMessage<DisplayAvatarDetailInfo>(42U, DisplayAvatarDetailInfo.Parser);

		// Token: 0x04001E9A RID: 7834
		private readonly RepeatedField<DisplayAvatarDetailInfo> dMDAFIBFJHP_ = new RepeatedField<DisplayAvatarDetailInfo>();

		// Token: 0x04001E9B RID: 7835
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x04001E9C RID: 7836
		private uint challengeId_;
	}
}

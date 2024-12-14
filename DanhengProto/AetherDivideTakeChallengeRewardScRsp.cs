using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200006F RID: 111
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideTakeChallengeRewardScRsp : IMessage<AetherDivideTakeChallengeRewardScRsp>, IMessage, IEquatable<AetherDivideTakeChallengeRewardScRsp>, IDeepCloneable<AetherDivideTakeChallengeRewardScRsp>, IBufferMessage
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0000D9DF File Offset: 0x0000BBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideTakeChallengeRewardScRsp> Parser
		{
			get
			{
				return AetherDivideTakeChallengeRewardScRsp._parser;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000D9E6 File Offset: 0x0000BBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideTakeChallengeRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideTakeChallengeRewardScRsp.Descriptor;
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000D9FF File Offset: 0x0000BBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTakeChallengeRewardScRsp()
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000DA08 File Offset: 0x0000BC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTakeChallengeRewardScRsp(AetherDivideTakeChallengeRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000DA60 File Offset: 0x0000BC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTakeChallengeRewardScRsp Clone()
		{
			return new AetherDivideTakeChallengeRewardScRsp(this);
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0000DA68 File Offset: 0x0000BC68
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x0000DA70 File Offset: 0x0000BC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0000DA79 File Offset: 0x0000BC79
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x0000DA81 File Offset: 0x0000BC81
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0000DA8A File Offset: 0x0000BC8A
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x0000DA92 File Offset: 0x0000BC92
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

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000DA9B File Offset: 0x0000BC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideTakeChallengeRewardScRsp);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideTakeChallengeRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000DB0C File Offset: 0x0000BD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
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

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000DB7A File Offset: 0x0000BD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000DB82 File Offset: 0x0000BD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000DB8C File Offset: 0x0000BD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000DC04 File Offset: 0x0000BE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
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

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000DC74 File Offset: 0x0000BE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideTakeChallengeRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 88U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChallengeId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
				}
			}
		}

		// Token: 0x040001B5 RID: 437
		private static readonly MessageParser<AetherDivideTakeChallengeRewardScRsp> _parser = new MessageParser<AetherDivideTakeChallengeRewardScRsp>(() => new AetherDivideTakeChallengeRewardScRsp());

		// Token: 0x040001B6 RID: 438
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001B7 RID: 439
		public const int RewardFieldNumber = 10;

		// Token: 0x040001B8 RID: 440
		private ItemList reward_;

		// Token: 0x040001B9 RID: 441
		public const int RetcodeFieldNumber = 11;

		// Token: 0x040001BA RID: 442
		private uint retcode_;

		// Token: 0x040001BB RID: 443
		public const int ChallengeIdFieldNumber = 13;

		// Token: 0x040001BC RID: 444
		private uint challengeId_;
	}
}

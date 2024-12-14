using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003E1 RID: 993
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DrinkMakerChallengeScRsp : IMessage<DrinkMakerChallengeScRsp>, IMessage, IEquatable<DrinkMakerChallengeScRsp>, IDeepCloneable<DrinkMakerChallengeScRsp>, IBufferMessage
	{
		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x0007AAAF File Offset: 0x00078CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DrinkMakerChallengeScRsp> Parser
		{
			get
			{
				return DrinkMakerChallengeScRsp._parser;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x0007AAB6 File Offset: 0x00078CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DrinkMakerChallengeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x0007AAC8 File Offset: 0x00078CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMakerChallengeScRsp.Descriptor;
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0007AACF File Offset: 0x00078CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerChallengeScRsp()
		{
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x0007AAD8 File Offset: 0x00078CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerChallengeScRsp(DrinkMakerChallengeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.isSuccess_ = other.isSuccess_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x0007AB3C File Offset: 0x00078D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerChallengeScRsp Clone()
		{
			return new DrinkMakerChallengeScRsp(this);
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x0007AB44 File Offset: 0x00078D44
		// (set) Token: 0x06002C37 RID: 11319 RVA: 0x0007AB4C File Offset: 0x00078D4C
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

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x0007AB55 File Offset: 0x00078D55
		// (set) Token: 0x06002C39 RID: 11321 RVA: 0x0007AB5D File Offset: 0x00078D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x0007AB66 File Offset: 0x00078D66
		// (set) Token: 0x06002C3B RID: 11323 RVA: 0x0007AB6E File Offset: 0x00078D6E
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

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x0007AB77 File Offset: 0x00078D77
		// (set) Token: 0x06002C3D RID: 11325 RVA: 0x0007AB7F File Offset: 0x00078D7F
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

		// Token: 0x06002C3E RID: 11326 RVA: 0x0007AB88 File Offset: 0x00078D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMakerChallengeScRsp);
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x0007AB98 File Offset: 0x00078D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMakerChallengeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.IsSuccess == other.IsSuccess && object.Equals(this.Reward, other.Reward) && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x0007AC08 File Offset: 0x00078E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
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

		// Token: 0x06002C41 RID: 11329 RVA: 0x0007AC8F File Offset: 0x00078E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x0007AC97 File Offset: 0x00078E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x0007ACA0 File Offset: 0x00078EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Reward);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsSuccess);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
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

		// Token: 0x06002C44 RID: 11332 RVA: 0x0007AD34 File Offset: 0x00078F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
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

		// Token: 0x06002C45 RID: 11333 RVA: 0x0007ADB0 File Offset: 0x00078FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrinkMakerChallengeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x0007AE40 File Offset: 0x00079040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x0007AE4C File Offset: 0x0007904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 18U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 48U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ChallengeId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040011D8 RID: 4568
		private static readonly MessageParser<DrinkMakerChallengeScRsp> _parser = new MessageParser<DrinkMakerChallengeScRsp>(() => new DrinkMakerChallengeScRsp());

		// Token: 0x040011D9 RID: 4569
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011DA RID: 4570
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040011DB RID: 4571
		private uint retcode_;

		// Token: 0x040011DC RID: 4572
		public const int IsSuccessFieldNumber = 6;

		// Token: 0x040011DD RID: 4573
		private bool isSuccess_;

		// Token: 0x040011DE RID: 4574
		public const int RewardFieldNumber = 2;

		// Token: 0x040011DF RID: 4575
		private ItemList reward_;

		// Token: 0x040011E0 RID: 4576
		public const int ChallengeIdFieldNumber = 13;

		// Token: 0x040011E1 RID: 4577
		private uint challengeId_;
	}
}

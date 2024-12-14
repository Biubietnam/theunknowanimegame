using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200013F RID: 319
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BoxingClubRewardScNotify : IMessage<BoxingClubRewardScNotify>, IMessage, IEquatable<BoxingClubRewardScNotify>, IDeepCloneable<BoxingClubRewardScNotify>, IBufferMessage
	{
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0002A80F File Offset: 0x00028A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BoxingClubRewardScNotify> Parser
		{
			get
			{
				return BoxingClubRewardScNotify._parser;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0002A816 File Offset: 0x00028A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BoxingClubRewardScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0002A828 File Offset: 0x00028A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoxingClubRewardScNotify.Descriptor;
			}
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0002A82F File Offset: 0x00028A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoxingClubRewardScNotify()
		{
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0002A838 File Offset: 0x00028A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoxingClubRewardScNotify(BoxingClubRewardScNotify other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.dJMKFKNCPJP_ = other.dJMKFKNCPJP_;
			this.challengeId_ = other.challengeId_;
			this.isWin_ = other.isWin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0002A89C File Offset: 0x00028A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoxingClubRewardScNotify Clone()
		{
			return new BoxingClubRewardScNotify(this);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0002A8A4 File Offset: 0x00028AA4
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x0002A8AC File Offset: 0x00028AAC
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

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0002A8B5 File Offset: 0x00028AB5
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x0002A8BD File Offset: 0x00028ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJMKFKNCPJP
		{
			get
			{
				return this.dJMKFKNCPJP_;
			}
			set
			{
				this.dJMKFKNCPJP_ = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0002A8C6 File Offset: 0x00028AC6
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x0002A8CE File Offset: 0x00028ACE
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

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0002A8D7 File Offset: 0x00028AD7
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x0002A8DF File Offset: 0x00028ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0002A8E8 File Offset: 0x00028AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoxingClubRewardScNotify);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0002A8F8 File Offset: 0x00028AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoxingClubRewardScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.DJMKFKNCPJP == other.DJMKFKNCPJP && this.ChallengeId == other.ChallengeId && this.IsWin == other.IsWin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0002A968 File Offset: 0x00028B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.DJMKFKNCPJP != 0U)
			{
				num ^= this.DJMKFKNCPJP.GetHashCode();
			}
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0002A9EF File Offset: 0x00028BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0002A9F7 File Offset: 0x00028BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0002AA00 File Offset: 0x00028C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DJMKFKNCPJP != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.DJMKFKNCPJP);
			}
			if (this.IsWin)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsWin);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0002AA90 File Offset: 0x00028C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.DJMKFKNCPJP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJMKFKNCPJP);
			}
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.IsWin)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0002AB0C File Offset: 0x00028D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoxingClubRewardScNotify other)
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
			if (other.DJMKFKNCPJP != 0U)
			{
				this.DJMKFKNCPJP = other.DJMKFKNCPJP;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0002AB9C File Offset: 0x00028D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0002ABA8 File Offset: 0x00028DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.DJMKFKNCPJP = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ChallengeId = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400062A RID: 1578
		private static readonly MessageParser<BoxingClubRewardScNotify> _parser = new MessageParser<BoxingClubRewardScNotify>(() => new BoxingClubRewardScNotify());

		// Token: 0x0400062B RID: 1579
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400062C RID: 1580
		public const int RewardFieldNumber = 13;

		// Token: 0x0400062D RID: 1581
		private ItemList reward_;

		// Token: 0x0400062E RID: 1582
		public const int DJMKFKNCPJPFieldNumber = 1;

		// Token: 0x0400062F RID: 1583
		private uint dJMKFKNCPJP_;

		// Token: 0x04000630 RID: 1584
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x04000631 RID: 1585
		private uint challengeId_;

		// Token: 0x04000632 RID: 1586
		public const int IsWinFieldNumber = 2;

		// Token: 0x04000633 RID: 1587
		private bool isWin_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012F3 RID: 4851
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakenChallengeRewardInfo : IMessage<TakenChallengeRewardInfo>, IMessage, IEquatable<TakenChallengeRewardInfo>, IDeepCloneable<TakenChallengeRewardInfo>, IBufferMessage
	{
		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x0600D875 RID: 55413 RVA: 0x00241495 File Offset: 0x0023F695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakenChallengeRewardInfo> Parser
		{
			get
			{
				return TakenChallengeRewardInfo._parser;
			}
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x0600D876 RID: 55414 RVA: 0x0024149C File Offset: 0x0023F69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakenChallengeRewardInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x0600D877 RID: 55415 RVA: 0x002414AE File Offset: 0x0023F6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakenChallengeRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600D878 RID: 55416 RVA: 0x002414B5 File Offset: 0x0023F6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakenChallengeRewardInfo()
		{
		}

		// Token: 0x0600D879 RID: 55417 RVA: 0x002414C0 File Offset: 0x0023F6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakenChallengeRewardInfo(TakenChallengeRewardInfo other) : this()
		{
			this.starCount_ = other.starCount_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D87A RID: 55418 RVA: 0x0024150C File Offset: 0x0023F70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakenChallengeRewardInfo Clone()
		{
			return new TakenChallengeRewardInfo(this);
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x0600D87B RID: 55419 RVA: 0x00241514 File Offset: 0x0023F714
		// (set) Token: 0x0600D87C RID: 55420 RVA: 0x0024151C File Offset: 0x0023F71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StarCount
		{
			get
			{
				return this.starCount_;
			}
			set
			{
				this.starCount_ = value;
			}
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x0600D87D RID: 55421 RVA: 0x00241525 File Offset: 0x0023F725
		// (set) Token: 0x0600D87E RID: 55422 RVA: 0x0024152D File Offset: 0x0023F72D
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

		// Token: 0x0600D87F RID: 55423 RVA: 0x00241536 File Offset: 0x0023F736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakenChallengeRewardInfo);
		}

		// Token: 0x0600D880 RID: 55424 RVA: 0x00241544 File Offset: 0x0023F744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakenChallengeRewardInfo other)
		{
			return other != null && (other == this || (this.StarCount == other.StarCount && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D881 RID: 55425 RVA: 0x00241594 File Offset: 0x0023F794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StarCount != 0U)
			{
				num ^= this.StarCount.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D882 RID: 55426 RVA: 0x002415E9 File Offset: 0x0023F7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D883 RID: 55427 RVA: 0x002415F1 File Offset: 0x0023F7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D884 RID: 55428 RVA: 0x002415FC File Offset: 0x0023F7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StarCount != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.StarCount);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D885 RID: 55429 RVA: 0x00241658 File Offset: 0x0023F858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StarCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StarCount);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D886 RID: 55430 RVA: 0x002416B0 File Offset: 0x0023F8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakenChallengeRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StarCount != 0U)
			{
				this.StarCount = other.StarCount;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D887 RID: 55431 RVA: 0x00241718 File Offset: 0x0023F918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D888 RID: 55432 RVA: 0x00241724 File Offset: 0x0023F924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.StarCount = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005661 RID: 22113
		private static readonly MessageParser<TakenChallengeRewardInfo> _parser = new MessageParser<TakenChallengeRewardInfo>(() => new TakenChallengeRewardInfo());

		// Token: 0x04005662 RID: 22114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005663 RID: 22115
		public const int StarCountFieldNumber = 5;

		// Token: 0x04005664 RID: 22116
		private uint starCount_;

		// Token: 0x04005665 RID: 22117
		public const int RewardFieldNumber = 11;

		// Token: 0x04005666 RID: 22118
		private ItemList reward_;
	}
}

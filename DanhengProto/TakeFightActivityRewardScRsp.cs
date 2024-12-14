using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012D9 RID: 4825
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeFightActivityRewardScRsp : IMessage<TakeFightActivityRewardScRsp>, IMessage, IEquatable<TakeFightActivityRewardScRsp>, IDeepCloneable<TakeFightActivityRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0600D740 RID: 55104 RVA: 0x0023E097 File Offset: 0x0023C297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeFightActivityRewardScRsp> Parser
		{
			get
			{
				return TakeFightActivityRewardScRsp._parser;
			}
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0600D741 RID: 55105 RVA: 0x0023E09E File Offset: 0x0023C29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeFightActivityRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x0600D742 RID: 55106 RVA: 0x0023E0B0 File Offset: 0x0023C2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeFightActivityRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D743 RID: 55107 RVA: 0x0023E0B7 File Offset: 0x0023C2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeFightActivityRewardScRsp()
		{
		}

		// Token: 0x0600D744 RID: 55108 RVA: 0x0023E0C0 File Offset: 0x0023C2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeFightActivityRewardScRsp(TakeFightActivityRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.groupId_ = other.groupId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D745 RID: 55109 RVA: 0x0023E124 File Offset: 0x0023C324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeFightActivityRewardScRsp Clone()
		{
			return new TakeFightActivityRewardScRsp(this);
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0600D746 RID: 55110 RVA: 0x0023E12C File Offset: 0x0023C32C
		// (set) Token: 0x0600D747 RID: 55111 RVA: 0x0023E134 File Offset: 0x0023C334
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

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x0600D748 RID: 55112 RVA: 0x0023E13D File Offset: 0x0023C33D
		// (set) Token: 0x0600D749 RID: 55113 RVA: 0x0023E145 File Offset: 0x0023C345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x0600D74A RID: 55114 RVA: 0x0023E14E File Offset: 0x0023C34E
		// (set) Token: 0x0600D74B RID: 55115 RVA: 0x0023E156 File Offset: 0x0023C356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x0600D74C RID: 55116 RVA: 0x0023E15F File Offset: 0x0023C35F
		// (set) Token: 0x0600D74D RID: 55117 RVA: 0x0023E167 File Offset: 0x0023C367
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

		// Token: 0x0600D74E RID: 55118 RVA: 0x0023E170 File Offset: 0x0023C370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeFightActivityRewardScRsp);
		}

		// Token: 0x0600D74F RID: 55119 RVA: 0x0023E180 File Offset: 0x0023C380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeFightActivityRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.AHFNGPLDAII == other.AHFNGPLDAII && this.GroupId == other.GroupId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D750 RID: 55120 RVA: 0x0023E1F0 File Offset: 0x0023C3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
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

		// Token: 0x0600D751 RID: 55121 RVA: 0x0023E277 File Offset: 0x0023C477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D752 RID: 55122 RVA: 0x0023E27F File Offset: 0x0023C47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D753 RID: 55123 RVA: 0x0023E288 File Offset: 0x0023C488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D754 RID: 55124 RVA: 0x0023E31C File Offset: 0x0023C51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
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

		// Token: 0x0600D755 RID: 55125 RVA: 0x0023E3A4 File Offset: 0x0023C5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeFightActivityRewardScRsp other)
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
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D756 RID: 55126 RVA: 0x0023E434 File Offset: 0x0023C634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D757 RID: 55127 RVA: 0x0023E440 File Offset: 0x0023C640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 34U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 64U)
					{
						this.AHFNGPLDAII = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055E8 RID: 21992
		private static readonly MessageParser<TakeFightActivityRewardScRsp> _parser = new MessageParser<TakeFightActivityRewardScRsp>(() => new TakeFightActivityRewardScRsp());

		// Token: 0x040055E9 RID: 21993
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055EA RID: 21994
		public const int RewardFieldNumber = 4;

		// Token: 0x040055EB RID: 21995
		private ItemList reward_;

		// Token: 0x040055EC RID: 21996
		public const int AHFNGPLDAIIFieldNumber = 8;

		// Token: 0x040055ED RID: 21997
		private uint aHFNGPLDAII_;

		// Token: 0x040055EE RID: 21998
		public const int GroupIdFieldNumber = 13;

		// Token: 0x040055EF RID: 21999
		private uint groupId_;

		// Token: 0x040055F0 RID: 22000
		public const int RetcodeFieldNumber = 11;

		// Token: 0x040055F1 RID: 22001
		private uint retcode_;
	}
}

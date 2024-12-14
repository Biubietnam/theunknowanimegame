using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AE5 RID: 2789
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionRewardScNotify : IMessage<MissionRewardScNotify>, IMessage, IEquatable<MissionRewardScNotify>, IDeepCloneable<MissionRewardScNotify>, IBufferMessage
	{
		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x06007B87 RID: 31623 RVA: 0x00146E1B File Offset: 0x0014501B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionRewardScNotify> Parser
		{
			get
			{
				return MissionRewardScNotify._parser;
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06007B88 RID: 31624 RVA: 0x00146E22 File Offset: 0x00145022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionRewardScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06007B89 RID: 31625 RVA: 0x00146E34 File Offset: 0x00145034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionRewardScNotify.Descriptor;
			}
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x00146E3B File Offset: 0x0014503B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionRewardScNotify()
		{
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x00146E44 File Offset: 0x00145044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionRewardScNotify(MissionRewardScNotify other) : this()
		{
			this.subMissionId_ = other.subMissionId_;
			this.mainMissionId_ = other.mainMissionId_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x00146E9C File Offset: 0x0014509C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionRewardScNotify Clone()
		{
			return new MissionRewardScNotify(this);
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06007B8D RID: 31629 RVA: 0x00146EA4 File Offset: 0x001450A4
		// (set) Token: 0x06007B8E RID: 31630 RVA: 0x00146EAC File Offset: 0x001450AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubMissionId
		{
			get
			{
				return this.subMissionId_;
			}
			set
			{
				this.subMissionId_ = value;
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06007B8F RID: 31631 RVA: 0x00146EB5 File Offset: 0x001450B5
		// (set) Token: 0x06007B90 RID: 31632 RVA: 0x00146EBD File Offset: 0x001450BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainMissionId
		{
			get
			{
				return this.mainMissionId_;
			}
			set
			{
				this.mainMissionId_ = value;
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x06007B91 RID: 31633 RVA: 0x00146EC6 File Offset: 0x001450C6
		// (set) Token: 0x06007B92 RID: 31634 RVA: 0x00146ECE File Offset: 0x001450CE
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

		// Token: 0x06007B93 RID: 31635 RVA: 0x00146ED7 File Offset: 0x001450D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionRewardScNotify);
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x00146EE8 File Offset: 0x001450E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionRewardScNotify other)
		{
			return other != null && (other == this || (this.SubMissionId == other.SubMissionId && this.MainMissionId == other.MainMissionId && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B95 RID: 31637 RVA: 0x00146F48 File Offset: 0x00145148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubMissionId != 0U)
			{
				num ^= this.SubMissionId.GetHashCode();
			}
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
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

		// Token: 0x06007B96 RID: 31638 RVA: 0x00146FB6 File Offset: 0x001451B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x00146FBE File Offset: 0x001451BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x00146FC8 File Offset: 0x001451C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Reward);
			}
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this.SubMissionId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x00147040 File Offset: 0x00145240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubMissionId);
			}
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
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

		// Token: 0x06007B9A RID: 31642 RVA: 0x001470B0 File Offset: 0x001452B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionRewardScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubMissionId != 0U)
			{
				this.SubMissionId = other.SubMissionId;
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
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

		// Token: 0x06007B9B RID: 31643 RVA: 0x0014712C File Offset: 0x0014532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x00147138 File Offset: 0x00145338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 64U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SubMissionId = input.ReadUInt32();
						}
					}
					else
					{
						this.MainMissionId = input.ReadUInt32();
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

		// Token: 0x04002F60 RID: 12128
		private static readonly MessageParser<MissionRewardScNotify> _parser = new MessageParser<MissionRewardScNotify>(() => new MissionRewardScNotify());

		// Token: 0x04002F61 RID: 12129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F62 RID: 12130
		public const int SubMissionIdFieldNumber = 13;

		// Token: 0x04002F63 RID: 12131
		private uint subMissionId_;

		// Token: 0x04002F64 RID: 12132
		public const int MainMissionIdFieldNumber = 8;

		// Token: 0x04002F65 RID: 12133
		private uint mainMissionId_;

		// Token: 0x04002F66 RID: 12134
		public const int RewardFieldNumber = 3;

		// Token: 0x04002F67 RID: 12135
		private ItemList reward_;
	}
}

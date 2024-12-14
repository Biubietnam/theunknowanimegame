using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F5 RID: 4597
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubMissionRewardScNotify : IMessage<SubMissionRewardScNotify>, IMessage, IEquatable<SubMissionRewardScNotify>, IDeepCloneable<SubMissionRewardScNotify>, IBufferMessage
	{
		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x00227791 File Offset: 0x00225991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubMissionRewardScNotify> Parser
		{
			get
			{
				return SubMissionRewardScNotify._parser;
			}
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0600CD77 RID: 52599 RVA: 0x00227798 File Offset: 0x00225998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubMissionRewardScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0600CD78 RID: 52600 RVA: 0x002277AA File Offset: 0x002259AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubMissionRewardScNotify.Descriptor;
			}
		}

		// Token: 0x0600CD79 RID: 52601 RVA: 0x002277B1 File Offset: 0x002259B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubMissionRewardScNotify()
		{
		}

		// Token: 0x0600CD7A RID: 52602 RVA: 0x002277BC File Offset: 0x002259BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubMissionRewardScNotify(SubMissionRewardScNotify other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.subMissionId_ = other.subMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD7B RID: 52603 RVA: 0x00227808 File Offset: 0x00225A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubMissionRewardScNotify Clone()
		{
			return new SubMissionRewardScNotify(this);
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0600CD7C RID: 52604 RVA: 0x00227810 File Offset: 0x00225A10
		// (set) Token: 0x0600CD7D RID: 52605 RVA: 0x00227818 File Offset: 0x00225A18
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

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x0600CD7E RID: 52606 RVA: 0x00227821 File Offset: 0x00225A21
		// (set) Token: 0x0600CD7F RID: 52607 RVA: 0x00227829 File Offset: 0x00225A29
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

		// Token: 0x0600CD80 RID: 52608 RVA: 0x00227832 File Offset: 0x00225A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubMissionRewardScNotify);
		}

		// Token: 0x0600CD81 RID: 52609 RVA: 0x00227840 File Offset: 0x00225A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubMissionRewardScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.SubMissionId == other.SubMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD82 RID: 52610 RVA: 0x00227890 File Offset: 0x00225A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.SubMissionId != 0U)
			{
				num ^= this.SubMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD83 RID: 52611 RVA: 0x002278E5 File Offset: 0x00225AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CD84 RID: 52612 RVA: 0x002278ED File Offset: 0x00225AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD85 RID: 52613 RVA: 0x002278F8 File Offset: 0x00225AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Reward);
			}
			if (this.SubMissionId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD86 RID: 52614 RVA: 0x00227954 File Offset: 0x00225B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.SubMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD87 RID: 52615 RVA: 0x002279AC File Offset: 0x00225BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubMissionRewardScNotify other)
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
			if (other.SubMissionId != 0U)
			{
				this.SubMissionId = other.SubMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD88 RID: 52616 RVA: 0x00227A14 File Offset: 0x00225C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD89 RID: 52617 RVA: 0x00227A20 File Offset: 0x00225C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 96U)
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
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
				}
			}
		}

		// Token: 0x040052DC RID: 21212
		private static readonly MessageParser<SubMissionRewardScNotify> _parser = new MessageParser<SubMissionRewardScNotify>(() => new SubMissionRewardScNotify());

		// Token: 0x040052DD RID: 21213
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052DE RID: 21214
		public const int RewardFieldNumber = 5;

		// Token: 0x040052DF RID: 21215
		private ItemList reward_;

		// Token: 0x040052E0 RID: 21216
		public const int SubMissionIdFieldNumber = 12;

		// Token: 0x040052E1 RID: 21217
		private uint subMissionId_;
	}
}

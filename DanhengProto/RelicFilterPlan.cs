using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA3 RID: 3491
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicFilterPlan : IMessage<RelicFilterPlan>, IMessage, IEquatable<RelicFilterPlan>, IDeepCloneable<RelicFilterPlan>, IBufferMessage
	{
		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06009BFE RID: 39934 RVA: 0x0019F3AF File Offset: 0x0019D5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicFilterPlan> Parser
		{
			get
			{
				return RelicFilterPlan._parser;
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x06009BFF RID: 39935 RVA: 0x0019F3B6 File Offset: 0x0019D5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicFilterPlanReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x06009C00 RID: 39936 RVA: 0x0019F3C8 File Offset: 0x0019D5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicFilterPlan.Descriptor;
			}
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x0019F3CF File Offset: 0x0019D5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlan()
		{
		}

		// Token: 0x06009C02 RID: 39938 RVA: 0x0019F3E4 File Offset: 0x0019D5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlan(RelicFilterPlan other) : this()
		{
			this.avatarIdOnCreate_ = other.avatarIdOnCreate_;
			this.isMarked_ = other.isMarked_;
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this.updateTimestamp_ = other.updateTimestamp_;
			this.name_ = other.name_;
			this.slotIndex_ = other.slotIndex_;
			this.icon_ = ((other.icon_ != null) ? other.icon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C03 RID: 39939 RVA: 0x0019F47C File Offset: 0x0019D67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlan Clone()
		{
			return new RelicFilterPlan(this);
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x06009C04 RID: 39940 RVA: 0x0019F484 File Offset: 0x0019D684
		// (set) Token: 0x06009C05 RID: 39941 RVA: 0x0019F48C File Offset: 0x0019D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarIdOnCreate
		{
			get
			{
				return this.avatarIdOnCreate_;
			}
			set
			{
				this.avatarIdOnCreate_ = value;
			}
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x06009C06 RID: 39942 RVA: 0x0019F495 File Offset: 0x0019D695
		// (set) Token: 0x06009C07 RID: 39943 RVA: 0x0019F49D File Offset: 0x0019D69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMarked
		{
			get
			{
				return this.isMarked_;
			}
			set
			{
				this.isMarked_ = value;
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x06009C08 RID: 39944 RVA: 0x0019F4A6 File Offset: 0x0019D6A6
		// (set) Token: 0x06009C09 RID: 39945 RVA: 0x0019F4AE File Offset: 0x0019D6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanSettings Settings
		{
			get
			{
				return this.settings_;
			}
			set
			{
				this.settings_ = value;
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x06009C0A RID: 39946 RVA: 0x0019F4B7 File Offset: 0x0019D6B7
		// (set) Token: 0x06009C0B RID: 39947 RVA: 0x0019F4BF File Offset: 0x0019D6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpdateTimestamp
		{
			get
			{
				return this.updateTimestamp_;
			}
			set
			{
				this.updateTimestamp_ = value;
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x06009C0C RID: 39948 RVA: 0x0019F4C8 File Offset: 0x0019D6C8
		// (set) Token: 0x06009C0D RID: 39949 RVA: 0x0019F4D0 File Offset: 0x0019D6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x06009C0E RID: 39950 RVA: 0x0019F4E3 File Offset: 0x0019D6E3
		// (set) Token: 0x06009C0F RID: 39951 RVA: 0x0019F4EB File Offset: 0x0019D6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x06009C10 RID: 39952 RVA: 0x0019F4F4 File Offset: 0x0019D6F4
		// (set) Token: 0x06009C11 RID: 39953 RVA: 0x0019F4FC File Offset: 0x0019D6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanIcon Icon
		{
			get
			{
				return this.icon_;
			}
			set
			{
				this.icon_ = value;
			}
		}

		// Token: 0x06009C12 RID: 39954 RVA: 0x0019F505 File Offset: 0x0019D705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicFilterPlan);
		}

		// Token: 0x06009C13 RID: 39955 RVA: 0x0019F514 File Offset: 0x0019D714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicFilterPlan other)
		{
			return other != null && (other == this || (this.AvatarIdOnCreate == other.AvatarIdOnCreate && this.IsMarked == other.IsMarked && object.Equals(this.Settings, other.Settings) && this.UpdateTimestamp == other.UpdateTimestamp && !(this.Name != other.Name) && this.SlotIndex == other.SlotIndex && object.Equals(this.Icon, other.Icon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C14 RID: 39956 RVA: 0x0019F5BC File Offset: 0x0019D7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarIdOnCreate != 0U)
			{
				num ^= this.AvatarIdOnCreate.GetHashCode();
			}
			if (this.IsMarked)
			{
				num ^= this.IsMarked.GetHashCode();
			}
			if (this.settings_ != null)
			{
				num ^= this.Settings.GetHashCode();
			}
			if (this.UpdateTimestamp != 0L)
			{
				num ^= this.UpdateTimestamp.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.SlotIndex != 0U)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			if (this.icon_ != null)
			{
				num ^= this.Icon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C15 RID: 39957 RVA: 0x0019F68D File Offset: 0x0019D88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C16 RID: 39958 RVA: 0x0019F695 File Offset: 0x0019D895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x0019F6A0 File Offset: 0x0019D8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarIdOnCreate != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AvatarIdOnCreate);
			}
			if (this.settings_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Settings);
			}
			if (this.SlotIndex != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.SlotIndex);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Name);
			}
			if (this.icon_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Icon);
			}
			if (this.UpdateTimestamp != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.UpdateTimestamp);
			}
			if (this.IsMarked)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsMarked);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C18 RID: 39960 RVA: 0x0019F78C File Offset: 0x0019D98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarIdOnCreate != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarIdOnCreate);
			}
			if (this.IsMarked)
			{
				num += 2;
			}
			if (this.settings_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			if (this.UpdateTimestamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpdateTimestamp);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.SlotIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SlotIndex);
			}
			if (this.icon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Icon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x0019F854 File Offset: 0x0019DA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicFilterPlan other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarIdOnCreate != 0U)
			{
				this.AvatarIdOnCreate = other.AvatarIdOnCreate;
			}
			if (other.IsMarked)
			{
				this.IsMarked = other.IsMarked;
			}
			if (other.settings_ != null)
			{
				if (this.settings_ == null)
				{
					this.Settings = new RelicFilterPlanSettings();
				}
				this.Settings.MergeFrom(other.Settings);
			}
			if (other.UpdateTimestamp != 0L)
			{
				this.UpdateTimestamp = other.UpdateTimestamp;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.SlotIndex != 0U)
			{
				this.SlotIndex = other.SlotIndex;
			}
			if (other.icon_ != null)
			{
				if (this.icon_ == null)
				{
					this.Icon = new RelicFilterPlanIcon();
				}
				this.Icon.MergeFrom(other.Icon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x0019F93D File Offset: 0x0019DB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C1B RID: 39963 RVA: 0x0019F948 File Offset: 0x0019DB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.AvatarIdOnCreate = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.settings_ == null)
						{
							this.Settings = new RelicFilterPlanSettings();
						}
						input.ReadMessage(this.Settings);
						continue;
					}
					if (num == 48U)
					{
						this.SlotIndex = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num == 66U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 90U)
					{
						if (this.icon_ == null)
						{
							this.Icon = new RelicFilterPlanIcon();
						}
						input.ReadMessage(this.Icon);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.UpdateTimestamp = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.IsMarked = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C8E RID: 15502
		private static readonly MessageParser<RelicFilterPlan> _parser = new MessageParser<RelicFilterPlan>(() => new RelicFilterPlan());

		// Token: 0x04003C8F RID: 15503
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C90 RID: 15504
		public const int AvatarIdOnCreateFieldNumber = 3;

		// Token: 0x04003C91 RID: 15505
		private uint avatarIdOnCreate_;

		// Token: 0x04003C92 RID: 15506
		public const int IsMarkedFieldNumber = 15;

		// Token: 0x04003C93 RID: 15507
		private bool isMarked_;

		// Token: 0x04003C94 RID: 15508
		public const int SettingsFieldNumber = 5;

		// Token: 0x04003C95 RID: 15509
		private RelicFilterPlanSettings settings_;

		// Token: 0x04003C96 RID: 15510
		public const int UpdateTimestampFieldNumber = 14;

		// Token: 0x04003C97 RID: 15511
		private long updateTimestamp_;

		// Token: 0x04003C98 RID: 15512
		public const int NameFieldNumber = 8;

		// Token: 0x04003C99 RID: 15513
		private string name_ = "";

		// Token: 0x04003C9A RID: 15514
		public const int SlotIndexFieldNumber = 6;

		// Token: 0x04003C9B RID: 15515
		private uint slotIndex_;

		// Token: 0x04003C9C RID: 15516
		public const int IconFieldNumber = 11;

		// Token: 0x04003C9D RID: 15517
		private RelicFilterPlanIcon icon_;
	}
}

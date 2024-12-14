using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000883 RID: 2179
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupStatus : IMessage<GroupStatus>, IMessage, IEquatable<GroupStatus>, IDeepCloneable<GroupStatus>, IBufferMessage
	{
		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x060060E6 RID: 24806 RVA: 0x00100283 File Offset: 0x000FE483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupStatus> Parser
		{
			get
			{
				return GroupStatus._parser;
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x060060E7 RID: 24807 RVA: 0x0010028A File Offset: 0x000FE48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GroupStatusReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x060060E8 RID: 24808 RVA: 0x0010029C File Offset: 0x000FE49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupStatus.Descriptor;
			}
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x001002A3 File Offset: 0x000FE4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStatus()
		{
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x001002AB File Offset: 0x000FE4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStatus(GroupStatus other) : this()
		{
			this.refreshTime_ = other.refreshTime_;
			this.groupId_ = other.groupId_;
			this.groupStatus_ = other.groupStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x001002E8 File Offset: 0x000FE4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStatus Clone()
		{
			return new GroupStatus(this);
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x060060EC RID: 24812 RVA: 0x001002F0 File Offset: 0x000FE4F0
		// (set) Token: 0x060060ED RID: 24813 RVA: 0x001002F8 File Offset: 0x000FE4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RefreshTime
		{
			get
			{
				return this.refreshTime_;
			}
			set
			{
				this.refreshTime_ = value;
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x060060EE RID: 24814 RVA: 0x00100301 File Offset: 0x000FE501
		// (set) Token: 0x060060EF RID: 24815 RVA: 0x00100309 File Offset: 0x000FE509
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

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x060060F0 RID: 24816 RVA: 0x00100312 File Offset: 0x000FE512
		// (set) Token: 0x060060F1 RID: 24817 RVA: 0x0010031A File Offset: 0x000FE51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageGroupStatus GroupStatus_
		{
			get
			{
				return this.groupStatus_;
			}
			set
			{
				this.groupStatus_ = value;
			}
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x00100323 File Offset: 0x000FE523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupStatus);
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x00100334 File Offset: 0x000FE534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupStatus other)
		{
			return other != null && (other == this || (this.RefreshTime == other.RefreshTime && this.GroupId == other.GroupId && this.GroupStatus_ == other.GroupStatus_ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00100390 File Offset: 0x000FE590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RefreshTime != 0L)
			{
				num ^= this.RefreshTime.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.GroupStatus_ != MessageGroupStatus.MessageGroupNone)
			{
				num ^= this.GroupStatus_.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x00100407 File Offset: 0x000FE607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x0010040F File Offset: 0x000FE60F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x00100418 File Offset: 0x000FE618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupStatus_ != MessageGroupStatus.MessageGroupNone)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.GroupStatus_);
			}
			if (this.RefreshTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.RefreshTime);
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

		// Token: 0x060060F8 RID: 24824 RVA: 0x00100490 File Offset: 0x000FE690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RefreshTime);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.GroupStatus_ != MessageGroupStatus.MessageGroupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GroupStatus_);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x00100500 File Offset: 0x000FE700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupStatus other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RefreshTime != 0L)
			{
				this.RefreshTime = other.RefreshTime;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.GroupStatus_ != MessageGroupStatus.MessageGroupNone)
			{
				this.GroupStatus_ = other.GroupStatus_;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x00100564 File Offset: 0x000FE764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x00100570 File Offset: 0x000FE770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 88U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadUInt32();
						}
					}
					else
					{
						this.RefreshTime = input.ReadInt64();
					}
				}
				else
				{
					this.GroupStatus_ = (MessageGroupStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400253C RID: 9532
		private static readonly MessageParser<GroupStatus> _parser = new MessageParser<GroupStatus>(() => new GroupStatus());

		// Token: 0x0400253D RID: 9533
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400253E RID: 9534
		public const int RefreshTimeFieldNumber = 11;

		// Token: 0x0400253F RID: 9535
		private long refreshTime_;

		// Token: 0x04002540 RID: 9536
		public const int GroupIdFieldNumber = 13;

		// Token: 0x04002541 RID: 9537
		private uint groupId_;

		// Token: 0x04002542 RID: 9538
		public const int GroupStatus_FieldNumber = 9;

		// Token: 0x04002543 RID: 9539
		private MessageGroupStatus groupStatus_;
	}
}

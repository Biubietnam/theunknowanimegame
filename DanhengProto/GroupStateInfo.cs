using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000881 RID: 2177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupStateInfo : IMessage<GroupStateInfo>, IMessage, IEquatable<GroupStateInfo>, IDeepCloneable<GroupStateInfo>, IBufferMessage
	{
		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x060060CB RID: 24779 RVA: 0x000FFDC1 File Offset: 0x000FDFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupStateInfo> Parser
		{
			get
			{
				return GroupStateInfo._parser;
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x060060CC RID: 24780 RVA: 0x000FFDC8 File Offset: 0x000FDFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GroupStateInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x000FFDDA File Offset: 0x000FDFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupStateInfo.Descriptor;
			}
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x000FFDE1 File Offset: 0x000FDFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateInfo()
		{
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x000FFDEC File Offset: 0x000FDFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateInfo(GroupStateInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.bKGMCGJIHGO_ = other.bKGMCGJIHGO_;
			this.groupState_ = other.groupState_;
			this.entryId_ = other.entryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x000FFE40 File Offset: 0x000FE040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateInfo Clone()
		{
			return new GroupStateInfo(this);
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x000FFE48 File Offset: 0x000FE048
		// (set) Token: 0x060060D2 RID: 24786 RVA: 0x000FFE50 File Offset: 0x000FE050
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

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x060060D3 RID: 24787 RVA: 0x000FFE59 File Offset: 0x000FE059
		// (set) Token: 0x060060D4 RID: 24788 RVA: 0x000FFE61 File Offset: 0x000FE061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BKGMCGJIHGO
		{
			get
			{
				return this.bKGMCGJIHGO_;
			}
			set
			{
				this.bKGMCGJIHGO_ = value;
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x060060D5 RID: 24789 RVA: 0x000FFE6A File Offset: 0x000FE06A
		// (set) Token: 0x060060D6 RID: 24790 RVA: 0x000FFE72 File Offset: 0x000FE072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupState
		{
			get
			{
				return this.groupState_;
			}
			set
			{
				this.groupState_ = value;
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x060060D7 RID: 24791 RVA: 0x000FFE7B File Offset: 0x000FE07B
		// (set) Token: 0x060060D8 RID: 24792 RVA: 0x000FFE83 File Offset: 0x000FE083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x000FFE8C File Offset: 0x000FE08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupStateInfo);
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x000FFE9C File Offset: 0x000FE09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupStateInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.BKGMCGJIHGO == other.BKGMCGJIHGO && this.GroupState == other.GroupState && this.EntryId == other.EntryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x000FFF08 File Offset: 0x000FE108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.BKGMCGJIHGO != 0U)
			{
				num ^= this.BKGMCGJIHGO.GetHashCode();
			}
			if (this.GroupState != 0U)
			{
				num ^= this.GroupState.GetHashCode();
			}
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x000FFF92 File Offset: 0x000FE192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x000FFF9A File Offset: 0x000FE19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x000FFFA4 File Offset: 0x000FE1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BKGMCGJIHGO != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BKGMCGJIHGO);
			}
			if (this.GroupState != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GroupState);
			}
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EntryId);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x00100034 File Offset: 0x000FE234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.BKGMCGJIHGO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BKGMCGJIHGO);
			}
			if (this.GroupState != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupState);
			}
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x001000BC File Offset: 0x000FE2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupStateInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.BKGMCGJIHGO != 0U)
			{
				this.BKGMCGJIHGO = other.BKGMCGJIHGO;
			}
			if (other.GroupState != 0U)
			{
				this.GroupState = other.GroupState;
			}
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x00100134 File Offset: 0x000FE334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x00100140 File Offset: 0x000FE340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 8U)
					{
						this.BKGMCGJIHGO = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.GroupState = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.EntryId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002531 RID: 9521
		private static readonly MessageParser<GroupStateInfo> _parser = new MessageParser<GroupStateInfo>(() => new GroupStateInfo());

		// Token: 0x04002532 RID: 9522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002533 RID: 9523
		public const int GroupIdFieldNumber = 15;

		// Token: 0x04002534 RID: 9524
		private uint groupId_;

		// Token: 0x04002535 RID: 9525
		public const int BKGMCGJIHGOFieldNumber = 1;

		// Token: 0x04002536 RID: 9526
		private uint bKGMCGJIHGO_;

		// Token: 0x04002537 RID: 9527
		public const int GroupStateFieldNumber = 11;

		// Token: 0x04002538 RID: 9528
		private uint groupState_;

		// Token: 0x04002539 RID: 9529
		public const int EntryIdFieldNumber = 14;

		// Token: 0x0400253A RID: 9530
		private uint entryId_;
	}
}

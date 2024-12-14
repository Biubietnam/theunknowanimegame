using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000879 RID: 2169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupRefreshInfo : IMessage<GroupRefreshInfo>, IMessage, IEquatable<GroupRefreshInfo>, IDeepCloneable<GroupRefreshInfo>, IBufferMessage
	{
		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x000FEFEB File Offset: 0x000FD1EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupRefreshInfo> Parser
		{
			get
			{
				return GroupRefreshInfo._parser;
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x000FEFF2 File Offset: 0x000FD1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GroupRefreshInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x000FF004 File Offset: 0x000FD204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupRefreshInfo.Descriptor;
			}
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x000FF00B File Offset: 0x000FD20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupRefreshInfo()
		{
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x000FF020 File Offset: 0x000FD220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupRefreshInfo(GroupRefreshInfo other) : this()
		{
			this.refreshType_ = other.refreshType_;
			this.state_ = other.state_;
			this.groupId_ = other.groupId_;
			this.refreshEntity_ = other.refreshEntity_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x000FF079 File Offset: 0x000FD279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupRefreshInfo Clone()
		{
			return new GroupRefreshInfo(this);
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06006076 RID: 24694 RVA: 0x000FF081 File Offset: 0x000FD281
		// (set) Token: 0x06006077 RID: 24695 RVA: 0x000FF089 File Offset: 0x000FD289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupRefreshType RefreshType
		{
			get
			{
				return this.refreshType_;
			}
			set
			{
				this.refreshType_ = value;
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06006078 RID: 24696 RVA: 0x000FF092 File Offset: 0x000FD292
		// (set) Token: 0x06006079 RID: 24697 RVA: 0x000FF09A File Offset: 0x000FD29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x0600607A RID: 24698 RVA: 0x000FF0A3 File Offset: 0x000FD2A3
		// (set) Token: 0x0600607B RID: 24699 RVA: 0x000FF0AB File Offset: 0x000FD2AB
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

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x000FF0B4 File Offset: 0x000FD2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneEntityRefreshInfo> RefreshEntity
		{
			get
			{
				return this.refreshEntity_;
			}
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x000FF0BC File Offset: 0x000FD2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupRefreshInfo);
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x000FF0CC File Offset: 0x000FD2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupRefreshInfo other)
		{
			return other != null && (other == this || (this.RefreshType == other.RefreshType && this.State == other.State && this.GroupId == other.GroupId && this.refreshEntity_.Equals(other.refreshEntity_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x000FF13C File Offset: 0x000FD33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RefreshType != SceneGroupRefreshType.None)
			{
				num ^= this.RefreshType.GetHashCode();
			}
			if (this.State != 0U)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			num ^= this.refreshEntity_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x000FF1C1 File Offset: 0x000FD3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x000FF1C9 File Offset: 0x000FD3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006082 RID: 24706 RVA: 0x000FF1D4 File Offset: 0x000FD3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GroupId);
			}
			this.refreshEntity_.WriteTo(ref output, GroupRefreshInfo._repeated_refreshEntity_codec);
			if (this.State != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.State);
			}
			if (this.RefreshType != SceneGroupRefreshType.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.RefreshType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x000FF25C File Offset: 0x000FD45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RefreshType != SceneGroupRefreshType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RefreshType);
			}
			if (this.State != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.State);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			num += this.refreshEntity_.CalculateSize(GroupRefreshInfo._repeated_refreshEntity_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x000FF2E0 File Offset: 0x000FD4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupRefreshInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RefreshType != SceneGroupRefreshType.None)
			{
				this.RefreshType = other.RefreshType;
			}
			if (other.State != 0U)
			{
				this.State = other.State;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this.refreshEntity_.Add(other.refreshEntity_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x000FF355 File Offset: 0x000FD555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x000FF360 File Offset: 0x000FD560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 40U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						this.refreshEntity_.AddEntriesFrom(ref input, GroupRefreshInfo._repeated_refreshEntity_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.State = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.RefreshType = (SceneGroupRefreshType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002514 RID: 9492
		private static readonly MessageParser<GroupRefreshInfo> _parser = new MessageParser<GroupRefreshInfo>(() => new GroupRefreshInfo());

		// Token: 0x04002515 RID: 9493
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002516 RID: 9494
		public const int RefreshTypeFieldNumber = 11;

		// Token: 0x04002517 RID: 9495
		private SceneGroupRefreshType refreshType_;

		// Token: 0x04002518 RID: 9496
		public const int StateFieldNumber = 10;

		// Token: 0x04002519 RID: 9497
		private uint state_;

		// Token: 0x0400251A RID: 9498
		public const int GroupIdFieldNumber = 5;

		// Token: 0x0400251B RID: 9499
		private uint groupId_;

		// Token: 0x0400251C RID: 9500
		public const int RefreshEntityFieldNumber = 6;

		// Token: 0x0400251D RID: 9501
		private static readonly FieldCodec<SceneEntityRefreshInfo> _repeated_refreshEntity_codec = FieldCodec.ForMessage<SceneEntityRefreshInfo>(50U, SceneEntityRefreshInfo.Parser);

		// Token: 0x0400251E RID: 9502
		private readonly RepeatedField<SceneEntityRefreshInfo> refreshEntity_ = new RepeatedField<SceneEntityRefreshInfo>();
	}
}

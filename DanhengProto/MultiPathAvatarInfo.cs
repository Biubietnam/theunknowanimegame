using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BA1 RID: 2977
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiPathAvatarInfo : IMessage<MultiPathAvatarInfo>, IMessage, IEquatable<MultiPathAvatarInfo>, IDeepCloneable<MultiPathAvatarInfo>, IBufferMessage
	{
		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x060083C8 RID: 33736 RVA: 0x0015BEF7 File Offset: 0x0015A0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiPathAvatarInfo> Parser
		{
			get
			{
				return MultiPathAvatarInfo._parser;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x060083C9 RID: 33737 RVA: 0x0015BEFE File Offset: 0x0015A0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiPathAvatarInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x060083CA RID: 33738 RVA: 0x0015BF10 File Offset: 0x0015A110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiPathAvatarInfo.Descriptor;
			}
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x0015BF17 File Offset: 0x0015A117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarInfo()
		{
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x0015BF38 File Offset: 0x0015A138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarInfo(MultiPathAvatarInfo other) : this()
		{
			this.equipRelicList_ = other.equipRelicList_.Clone();
			this.multiPathSkillTree_ = other.multiPathSkillTree_.Clone();
			this.rank_ = other.rank_;
			this.avatarId_ = other.avatarId_;
			this.pathEquipmentId_ = other.pathEquipmentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x0015BFA2 File Offset: 0x0015A1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarInfo Clone()
		{
			return new MultiPathAvatarInfo(this);
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x060083CE RID: 33742 RVA: 0x0015BFAA File Offset: 0x0015A1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipRelic> EquipRelicList
		{
			get
			{
				return this.equipRelicList_;
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x060083CF RID: 33743 RVA: 0x0015BFB2 File Offset: 0x0015A1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AvatarSkillTree> MultiPathSkillTree
		{
			get
			{
				return this.multiPathSkillTree_;
			}
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x060083D0 RID: 33744 RVA: 0x0015BFBA File Offset: 0x0015A1BA
		// (set) Token: 0x060083D1 RID: 33745 RVA: 0x0015BFC2 File Offset: 0x0015A1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x060083D2 RID: 33746 RVA: 0x0015BFCB File Offset: 0x0015A1CB
		// (set) Token: 0x060083D3 RID: 33747 RVA: 0x0015BFD3 File Offset: 0x0015A1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarType AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x060083D4 RID: 33748 RVA: 0x0015BFDC File Offset: 0x0015A1DC
		// (set) Token: 0x060083D5 RID: 33749 RVA: 0x0015BFE4 File Offset: 0x0015A1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PathEquipmentId
		{
			get
			{
				return this.pathEquipmentId_;
			}
			set
			{
				this.pathEquipmentId_ = value;
			}
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x0015BFED File Offset: 0x0015A1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiPathAvatarInfo);
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x0015BFFC File Offset: 0x0015A1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiPathAvatarInfo other)
		{
			return other != null && (other == this || (this.equipRelicList_.Equals(other.equipRelicList_) && this.multiPathSkillTree_.Equals(other.multiPathSkillTree_) && this.Rank == other.Rank && this.AvatarId == other.AvatarId && this.PathEquipmentId == other.PathEquipmentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x0015C080 File Offset: 0x0015A280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.equipRelicList_.GetHashCode();
			num ^= this.multiPathSkillTree_.GetHashCode();
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.PathEquipmentId != 0U)
			{
				num ^= this.PathEquipmentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x0015C113 File Offset: 0x0015A313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x0015C11B File Offset: 0x0015A31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x0015C124 File Offset: 0x0015A324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Rank != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Rank);
			}
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.AvatarId);
			}
			this.equipRelicList_.WriteTo(ref output, MultiPathAvatarInfo._repeated_equipRelicList_codec);
			this.multiPathSkillTree_.WriteTo(ref output, MultiPathAvatarInfo._repeated_multiPathSkillTree_codec);
			if (this.PathEquipmentId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.PathEquipmentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083DC RID: 33756 RVA: 0x0015C1BC File Offset: 0x0015A3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.equipRelicList_.CalculateSize(MultiPathAvatarInfo._repeated_equipRelicList_codec);
			num += this.multiPathSkillTree_.CalculateSize(MultiPathAvatarInfo._repeated_multiPathSkillTree_codec);
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarId);
			}
			if (this.PathEquipmentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PathEquipmentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x0015C250 File Offset: 0x0015A450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiPathAvatarInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.equipRelicList_.Add(other.equipRelicList_);
			this.multiPathSkillTree_.Add(other.multiPathSkillTree_);
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.AvatarId != MultiPathAvatarType.None)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.PathEquipmentId != 0U)
			{
				this.PathEquipmentId = other.PathEquipmentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x0015C2D6 File Offset: 0x0015A4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x0015C2E0 File Offset: 0x0015A4E0
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
						this.Rank = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.AvatarId = (MultiPathAvatarType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.equipRelicList_.AddEntriesFrom(ref input, MultiPathAvatarInfo._repeated_equipRelicList_codec);
						continue;
					}
					if (num == 98U)
					{
						this.multiPathSkillTree_.AddEntriesFrom(ref input, MultiPathAvatarInfo._repeated_multiPathSkillTree_codec);
						continue;
					}
					if (num == 112U)
					{
						this.PathEquipmentId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003270 RID: 12912
		private static readonly MessageParser<MultiPathAvatarInfo> _parser = new MessageParser<MultiPathAvatarInfo>(() => new MultiPathAvatarInfo());

		// Token: 0x04003271 RID: 12913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003272 RID: 12914
		public const int EquipRelicListFieldNumber = 9;

		// Token: 0x04003273 RID: 12915
		private static readonly FieldCodec<EquipRelic> _repeated_equipRelicList_codec = FieldCodec.ForMessage<EquipRelic>(74U, EquipRelic.Parser);

		// Token: 0x04003274 RID: 12916
		private readonly RepeatedField<EquipRelic> equipRelicList_ = new RepeatedField<EquipRelic>();

		// Token: 0x04003275 RID: 12917
		public const int MultiPathSkillTreeFieldNumber = 12;

		// Token: 0x04003276 RID: 12918
		private static readonly FieldCodec<AvatarSkillTree> _repeated_multiPathSkillTree_codec = FieldCodec.ForMessage<AvatarSkillTree>(98U, AvatarSkillTree.Parser);

		// Token: 0x04003277 RID: 12919
		private readonly RepeatedField<AvatarSkillTree> multiPathSkillTree_ = new RepeatedField<AvatarSkillTree>();

		// Token: 0x04003278 RID: 12920
		public const int RankFieldNumber = 1;

		// Token: 0x04003279 RID: 12921
		private uint rank_;

		// Token: 0x0400327A RID: 12922
		public const int AvatarIdFieldNumber = 2;

		// Token: 0x0400327B RID: 12923
		private MultiPathAvatarType avatarId_;

		// Token: 0x0400327C RID: 12924
		public const int PathEquipmentIdFieldNumber = 14;

		// Token: 0x0400327D RID: 12925
		private uint pathEquipmentId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008D9 RID: 2265
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusStartRaidCsReq : IMessage<HeliobusStartRaidCsReq>, IMessage, IEquatable<HeliobusStartRaidCsReq>, IDeepCloneable<HeliobusStartRaidCsReq>, IBufferMessage
	{
		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x060064FB RID: 25851 RVA: 0x0010E1F3 File Offset: 0x0010C3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusStartRaidCsReq> Parser
		{
			get
			{
				return HeliobusStartRaidCsReq._parser;
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x060064FC RID: 25852 RVA: 0x0010E1FA File Offset: 0x0010C3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusStartRaidCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x060064FD RID: 25853 RVA: 0x0010E20C File Offset: 0x0010C40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusStartRaidCsReq.Descriptor;
			}
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x0010E213 File Offset: 0x0010C413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusStartRaidCsReq()
		{
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x0010E228 File Offset: 0x0010C428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusStartRaidCsReq(HeliobusStartRaidCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this.skillId_ = other.skillId_;
			this.isSaveData_ = other.isSaveData_;
			this.raidId_ = other.raidId_;
			this.avatarList_ = other.avatarList_.Clone();
			this.jFPOBLGOPCP_ = other.jFPOBLGOPCP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x0010E299 File Offset: 0x0010C499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusStartRaidCsReq Clone()
		{
			return new HeliobusStartRaidCsReq(this);
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06006501 RID: 25857 RVA: 0x0010E2A1 File Offset: 0x0010C4A1
		// (set) Token: 0x06006502 RID: 25858 RVA: 0x0010E2A9 File Offset: 0x0010C4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06006503 RID: 25859 RVA: 0x0010E2B2 File Offset: 0x0010C4B2
		// (set) Token: 0x06006504 RID: 25860 RVA: 0x0010E2BA File Offset: 0x0010C4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06006505 RID: 25861 RVA: 0x0010E2C3 File Offset: 0x0010C4C3
		// (set) Token: 0x06006506 RID: 25862 RVA: 0x0010E2CB File Offset: 0x0010C4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSaveData
		{
			get
			{
				return this.isSaveData_;
			}
			set
			{
				this.isSaveData_ = value;
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06006507 RID: 25863 RVA: 0x0010E2D4 File Offset: 0x0010C4D4
		// (set) Token: 0x06006508 RID: 25864 RVA: 0x0010E2DC File Offset: 0x0010C4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RaidId
		{
			get
			{
				return this.raidId_;
			}
			set
			{
				this.raidId_ = value;
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06006509 RID: 25865 RVA: 0x0010E2E5 File Offset: 0x0010C4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x0010E2ED File Offset: 0x0010C4ED
		// (set) Token: 0x0600650B RID: 25867 RVA: 0x0010E2F5 File Offset: 0x0010C4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JFPOBLGOPCP
		{
			get
			{
				return this.jFPOBLGOPCP_;
			}
			set
			{
				this.jFPOBLGOPCP_ = value;
			}
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x0010E2FE File Offset: 0x0010C4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusStartRaidCsReq);
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x0010E30C File Offset: 0x0010C50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusStartRaidCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && this.SkillId == other.SkillId && this.IsSaveData == other.IsSaveData && this.RaidId == other.RaidId && this.avatarList_.Equals(other.avatarList_) && this.JFPOBLGOPCP == other.JFPOBLGOPCP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x0010E39C File Offset: 0x0010C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.IsSaveData)
			{
				num ^= this.IsSaveData.GetHashCode();
			}
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.JFPOBLGOPCP != 0U)
			{
				num ^= this.JFPOBLGOPCP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x0010E44D File Offset: 0x0010C64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x0010E455 File Offset: 0x0010C655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x0010E460 File Offset: 0x0010C660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.RaidId);
			}
			if (this.JFPOBLGOPCP != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.JFPOBLGOPCP);
			}
			if (this.IsSaveData)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsSaveData);
			}
			this.avatarList_.WriteTo(ref output, HeliobusStartRaidCsReq._repeated_avatarList_codec);
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x0010E520 File Offset: 0x0010C720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this.IsSaveData)
			{
				num += 2;
			}
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			num += this.avatarList_.CalculateSize(HeliobusStartRaidCsReq._repeated_avatarList_codec);
			if (this.JFPOBLGOPCP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JFPOBLGOPCP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x0010E5C8 File Offset: 0x0010C7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusStartRaidCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			if (other.IsSaveData)
			{
				this.IsSaveData = other.IsSaveData;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.JFPOBLGOPCP != 0U)
			{
				this.JFPOBLGOPCP = other.JFPOBLGOPCP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x0010E665 File Offset: 0x0010C865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x0010E670 File Offset: 0x0010C870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 40U)
				{
					if (num <= 80U)
					{
						if (num == 48U)
						{
							this.IsSaveData = input.ReadBool();
							continue;
						}
						if (num != 80U)
						{
							goto IL_36;
						}
					}
					else if (num != 82U)
					{
						if (num != 120U)
						{
							goto IL_36;
						}
						this.SkillId = input.ReadUInt32();
						continue;
					}
					this.avatarList_.AddEntriesFrom(ref input, HeliobusStartRaidCsReq._repeated_avatarList_codec);
					continue;
				}
				if (num == 16U)
				{
					this.PropEntityId = input.ReadUInt32();
					continue;
				}
				if (num == 24U)
				{
					this.RaidId = input.ReadUInt32();
					continue;
				}
				if (num == 40U)
				{
					this.JFPOBLGOPCP = input.ReadUInt32();
					continue;
				}
				IL_36:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026DA RID: 9946
		private static readonly MessageParser<HeliobusStartRaidCsReq> _parser = new MessageParser<HeliobusStartRaidCsReq>(() => new HeliobusStartRaidCsReq());

		// Token: 0x040026DB RID: 9947
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026DC RID: 9948
		public const int PropEntityIdFieldNumber = 2;

		// Token: 0x040026DD RID: 9949
		private uint propEntityId_;

		// Token: 0x040026DE RID: 9950
		public const int SkillIdFieldNumber = 15;

		// Token: 0x040026DF RID: 9951
		private uint skillId_;

		// Token: 0x040026E0 RID: 9952
		public const int IsSaveDataFieldNumber = 6;

		// Token: 0x040026E1 RID: 9953
		private bool isSaveData_;

		// Token: 0x040026E2 RID: 9954
		public const int RaidIdFieldNumber = 3;

		// Token: 0x040026E3 RID: 9955
		private uint raidId_;

		// Token: 0x040026E4 RID: 9956
		public const int AvatarListFieldNumber = 10;

		// Token: 0x040026E5 RID: 9957
		private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x040026E6 RID: 9958
		private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

		// Token: 0x040026E7 RID: 9959
		public const int JFPOBLGOPCPFieldNumber = 5;

		// Token: 0x040026E8 RID: 9960
		private uint jFPOBLGOPCP_;
	}
}

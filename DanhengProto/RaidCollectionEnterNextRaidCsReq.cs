using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D67 RID: 3431
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidCollectionEnterNextRaidCsReq : IMessage<RaidCollectionEnterNextRaidCsReq>, IMessage, IEquatable<RaidCollectionEnterNextRaidCsReq>, IDeepCloneable<RaidCollectionEnterNextRaidCsReq>, IBufferMessage
	{
		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x06009949 RID: 39241 RVA: 0x00197FEB File Offset: 0x001961EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidCollectionEnterNextRaidCsReq> Parser
		{
			get
			{
				return RaidCollectionEnterNextRaidCsReq._parser;
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600994A RID: 39242 RVA: 0x00197FF2 File Offset: 0x001961F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidCollectionEnterNextRaidCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600994B RID: 39243 RVA: 0x00198004 File Offset: 0x00196204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidCollectionEnterNextRaidCsReq.Descriptor;
			}
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x0019800B File Offset: 0x0019620B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionEnterNextRaidCsReq()
		{
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x00198020 File Offset: 0x00196220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionEnterNextRaidCsReq(RaidCollectionEnterNextRaidCsReq other) : this()
		{
			this.isSaveData_ = other.isSaveData_;
			this.raidId_ = other.raidId_;
			this.avatarList_ = other.avatarList_.Clone();
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x00198079 File Offset: 0x00196279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionEnterNextRaidCsReq Clone()
		{
			return new RaidCollectionEnterNextRaidCsReq(this);
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x0600994F RID: 39247 RVA: 0x00198081 File Offset: 0x00196281
		// (set) Token: 0x06009950 RID: 39248 RVA: 0x00198089 File Offset: 0x00196289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IsSaveData
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

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x06009951 RID: 39249 RVA: 0x00198092 File Offset: 0x00196292
		// (set) Token: 0x06009952 RID: 39250 RVA: 0x0019809A File Offset: 0x0019629A
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

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x06009953 RID: 39251 RVA: 0x001980A3 File Offset: 0x001962A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x06009954 RID: 39252 RVA: 0x001980AB File Offset: 0x001962AB
		// (set) Token: 0x06009955 RID: 39253 RVA: 0x001980B3 File Offset: 0x001962B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x001980BC File Offset: 0x001962BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidCollectionEnterNextRaidCsReq);
		}

		// Token: 0x06009957 RID: 39255 RVA: 0x001980CC File Offset: 0x001962CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidCollectionEnterNextRaidCsReq other)
		{
			return other != null && (other == this || (this.IsSaveData == other.IsSaveData && this.RaidId == other.RaidId && this.avatarList_.Equals(other.avatarList_) && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x0019813C File Offset: 0x0019633C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSaveData != 0U)
			{
				num ^= this.IsSaveData.GetHashCode();
			}
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009959 RID: 39257 RVA: 0x001981BB File Offset: 0x001963BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600995A RID: 39258 RVA: 0x001981C3 File Offset: 0x001963C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x001981CC File Offset: 0x001963CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.WorldLevel);
			}
			this.avatarList_.WriteTo(ref output, RaidCollectionEnterNextRaidCsReq._repeated_avatarList_codec);
			if (this.IsSaveData != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.IsSaveData);
			}
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.RaidId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600995C RID: 39260 RVA: 0x00198254 File Offset: 0x00196454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSaveData != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IsSaveData);
			}
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			num += this.avatarList_.CalculateSize(RaidCollectionEnterNextRaidCsReq._repeated_avatarList_codec);
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600995D RID: 39261 RVA: 0x001982D8 File Offset: 0x001964D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidCollectionEnterNextRaidCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSaveData != 0U)
			{
				this.IsSaveData = other.IsSaveData;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600995E RID: 39262 RVA: 0x0019834D File Offset: 0x0019654D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600995F RID: 39263 RVA: 0x00198358 File Offset: 0x00196558
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
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_43;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_43;
					}
					if (num == 88U)
					{
						this.IsSaveData = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.RaidId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_43:
				this.avatarList_.AddEntriesFrom(ref input, RaidCollectionEnterNextRaidCsReq._repeated_avatarList_codec);
			}
		}

		// Token: 0x04003B80 RID: 15232
		private static readonly MessageParser<RaidCollectionEnterNextRaidCsReq> _parser = new MessageParser<RaidCollectionEnterNextRaidCsReq>(() => new RaidCollectionEnterNextRaidCsReq());

		// Token: 0x04003B81 RID: 15233
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B82 RID: 15234
		public const int IsSaveDataFieldNumber = 11;

		// Token: 0x04003B83 RID: 15235
		private uint isSaveData_;

		// Token: 0x04003B84 RID: 15236
		public const int RaidIdFieldNumber = 14;

		// Token: 0x04003B85 RID: 15237
		private uint raidId_;

		// Token: 0x04003B86 RID: 15238
		public const int AvatarListFieldNumber = 2;

		// Token: 0x04003B87 RID: 15239
		private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04003B88 RID: 15240
		private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

		// Token: 0x04003B89 RID: 15241
		public const int WorldLevelFieldNumber = 1;

		// Token: 0x04003B8A RID: 15242
		private uint worldLevel_;
	}
}

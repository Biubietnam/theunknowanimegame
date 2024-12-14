using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C1 RID: 4545
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartRaidCsReq : IMessage<StartRaidCsReq>, IMessage, IEquatable<StartRaidCsReq>, IDeepCloneable<StartRaidCsReq>, IBufferMessage
	{
		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0600CB0A RID: 51978 RVA: 0x00220D13 File Offset: 0x0021EF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartRaidCsReq> Parser
		{
			get
			{
				return StartRaidCsReq._parser;
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x0600CB0B RID: 51979 RVA: 0x00220D1A File Offset: 0x0021EF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartRaidCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0600CB0C RID: 51980 RVA: 0x00220D2C File Offset: 0x0021EF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartRaidCsReq.Descriptor;
			}
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x00220D33 File Offset: 0x0021EF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRaidCsReq()
		{
		}

		// Token: 0x0600CB0E RID: 51982 RVA: 0x00220D48 File Offset: 0x0021EF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRaidCsReq(StartRaidCsReq other) : this()
		{
			this.isSaveData_ = other.isSaveData_;
			this.propEntityId_ = other.propEntityId_;
			this.worldLevel_ = other.worldLevel_;
			this.raidId_ = other.raidId_;
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB0F RID: 51983 RVA: 0x00220DAD File Offset: 0x0021EFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRaidCsReq Clone()
		{
			return new StartRaidCsReq(this);
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0600CB10 RID: 51984 RVA: 0x00220DB5 File Offset: 0x0021EFB5
		// (set) Token: 0x0600CB11 RID: 51985 RVA: 0x00220DBD File Offset: 0x0021EFBD
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

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600CB12 RID: 51986 RVA: 0x00220DC6 File Offset: 0x0021EFC6
		// (set) Token: 0x0600CB13 RID: 51987 RVA: 0x00220DCE File Offset: 0x0021EFCE
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

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600CB14 RID: 51988 RVA: 0x00220DD7 File Offset: 0x0021EFD7
		// (set) Token: 0x0600CB15 RID: 51989 RVA: 0x00220DDF File Offset: 0x0021EFDF
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

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600CB16 RID: 51990 RVA: 0x00220DE8 File Offset: 0x0021EFE8
		// (set) Token: 0x0600CB17 RID: 51991 RVA: 0x00220DF0 File Offset: 0x0021EFF0
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

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600CB18 RID: 51992 RVA: 0x00220DF9 File Offset: 0x0021EFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x00220E01 File Offset: 0x0021F001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartRaidCsReq);
		}

		// Token: 0x0600CB1A RID: 51994 RVA: 0x00220E10 File Offset: 0x0021F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartRaidCsReq other)
		{
			return other != null && (other == this || (this.IsSaveData == other.IsSaveData && this.PropEntityId == other.PropEntityId && this.WorldLevel == other.WorldLevel && this.RaidId == other.RaidId && this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x00220E90 File Offset: 0x0021F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSaveData != 0U)
			{
				num ^= this.IsSaveData.GetHashCode();
			}
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB1C RID: 51996 RVA: 0x00220F28 File Offset: 0x0021F128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CB1D RID: 51997 RVA: 0x00220F30 File Offset: 0x0021F130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB1E RID: 51998 RVA: 0x00220F3C File Offset: 0x0021F13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RaidId);
			}
			this.avatarList_.WriteTo(ref output, StartRaidCsReq._repeated_avatarList_codec);
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.IsSaveData != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.IsSaveData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB1F RID: 51999 RVA: 0x00220FE0 File Offset: 0x0021F1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSaveData != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IsSaveData);
			}
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			num += this.avatarList_.CalculateSize(StartRaidCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB20 RID: 52000 RVA: 0x0022107C File Offset: 0x0021F27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartRaidCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSaveData != 0U)
			{
				this.IsSaveData = other.IsSaveData;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB21 RID: 52001 RVA: 0x00221105 File Offset: 0x0021F305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB22 RID: 52002 RVA: 0x00221110 File Offset: 0x0021F310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 32U)
					{
						this.RaidId = input.ReadUInt32();
						continue;
					}
					if (num == 48U || num == 50U)
					{
						this.avatarList_.AddEntriesFrom(ref input, StartRaidCsReq._repeated_avatarList_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.PropEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsSaveData = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051E2 RID: 20962
		private static readonly MessageParser<StartRaidCsReq> _parser = new MessageParser<StartRaidCsReq>(() => new StartRaidCsReq());

		// Token: 0x040051E3 RID: 20963
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051E4 RID: 20964
		public const int IsSaveDataFieldNumber = 15;

		// Token: 0x040051E5 RID: 20965
		private uint isSaveData_;

		// Token: 0x040051E6 RID: 20966
		public const int PropEntityIdFieldNumber = 11;

		// Token: 0x040051E7 RID: 20967
		private uint propEntityId_;

		// Token: 0x040051E8 RID: 20968
		public const int WorldLevelFieldNumber = 14;

		// Token: 0x040051E9 RID: 20969
		private uint worldLevel_;

		// Token: 0x040051EA RID: 20970
		public const int RaidIdFieldNumber = 4;

		// Token: 0x040051EB RID: 20971
		private uint raidId_;

		// Token: 0x040051EC RID: 20972
		public const int AvatarListFieldNumber = 6;

		// Token: 0x040051ED RID: 20973
		private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x040051EE RID: 20974
		private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E3 RID: 2019
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSaveRaidScRsp : IMessage<GetSaveRaidScRsp>, IMessage, IEquatable<GetSaveRaidScRsp>, IDeepCloneable<GetSaveRaidScRsp>, IBufferMessage
	{
		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06005A08 RID: 23048 RVA: 0x000F009F File Offset: 0x000EE29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSaveRaidScRsp> Parser
		{
			get
			{
				return GetSaveRaidScRsp._parser;
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06005A09 RID: 23049 RVA: 0x000F00A6 File Offset: 0x000EE2A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSaveRaidScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06005A0A RID: 23050 RVA: 0x000F00B8 File Offset: 0x000EE2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSaveRaidScRsp.Descriptor;
			}
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x000F00BF File Offset: 0x000EE2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveRaidScRsp()
		{
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x000F00D4 File Offset: 0x000EE2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveRaidScRsp(GetSaveRaidScRsp other) : this()
		{
			this.raidId_ = other.raidId_;
			this.worldLevel_ = other.worldLevel_;
			this.isSaveData_ = other.isSaveData_;
			this.retcode_ = other.retcode_;
			this.raidTargetInfo_ = other.raidTargetInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x000F0139 File Offset: 0x000EE339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveRaidScRsp Clone()
		{
			return new GetSaveRaidScRsp(this);
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06005A0E RID: 23054 RVA: 0x000F0141 File Offset: 0x000EE341
		// (set) Token: 0x06005A0F RID: 23055 RVA: 0x000F0149 File Offset: 0x000EE349
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

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06005A10 RID: 23056 RVA: 0x000F0152 File Offset: 0x000EE352
		// (set) Token: 0x06005A11 RID: 23057 RVA: 0x000F015A File Offset: 0x000EE35A
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

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06005A12 RID: 23058 RVA: 0x000F0163 File Offset: 0x000EE363
		// (set) Token: 0x06005A13 RID: 23059 RVA: 0x000F016B File Offset: 0x000EE36B
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

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06005A14 RID: 23060 RVA: 0x000F0174 File Offset: 0x000EE374
		// (set) Token: 0x06005A15 RID: 23061 RVA: 0x000F017C File Offset: 0x000EE37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06005A16 RID: 23062 RVA: 0x000F0185 File Offset: 0x000EE385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RaidTargetInfo> RaidTargetInfo
		{
			get
			{
				return this.raidTargetInfo_;
			}
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x000F018D File Offset: 0x000EE38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSaveRaidScRsp);
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x000F019C File Offset: 0x000EE39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSaveRaidScRsp other)
		{
			return other != null && (other == this || (this.RaidId == other.RaidId && this.WorldLevel == other.WorldLevel && this.IsSaveData == other.IsSaveData && this.Retcode == other.Retcode && this.raidTargetInfo_.Equals(other.raidTargetInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x000F021C File Offset: 0x000EE41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.IsSaveData)
			{
				num ^= this.IsSaveData.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.raidTargetInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x000F02B4 File Offset: 0x000EE4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x000F02BC File Offset: 0x000EE4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x000F02C8 File Offset: 0x000EE4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RaidId);
			}
			if (this.IsSaveData)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSaveData);
			}
			this.raidTargetInfo_.WriteTo(ref output, GetSaveRaidScRsp._repeated_raidTargetInfo_codec);
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x000F036C File Offset: 0x000EE56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.IsSaveData)
			{
				num += 2;
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.raidTargetInfo_.CalculateSize(GetSaveRaidScRsp._repeated_raidTargetInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x000F03FC File Offset: 0x000EE5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSaveRaidScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.IsSaveData)
			{
				this.IsSaveData = other.IsSaveData;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.raidTargetInfo_.Add(other.raidTargetInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x000F0485 File Offset: 0x000EE685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x000F0490 File Offset: 0x000EE690
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
						this.RaidId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsSaveData = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.raidTargetInfo_.AddEntriesFrom(ref input, GetSaveRaidScRsp._repeated_raidTargetInfo_codec);
						continue;
					}
					if (num == 48U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022F0 RID: 8944
		private static readonly MessageParser<GetSaveRaidScRsp> _parser = new MessageParser<GetSaveRaidScRsp>(() => new GetSaveRaidScRsp());

		// Token: 0x040022F1 RID: 8945
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022F2 RID: 8946
		public const int RaidIdFieldNumber = 1;

		// Token: 0x040022F3 RID: 8947
		private uint raidId_;

		// Token: 0x040022F4 RID: 8948
		public const int WorldLevelFieldNumber = 6;

		// Token: 0x040022F5 RID: 8949
		private uint worldLevel_;

		// Token: 0x040022F6 RID: 8950
		public const int IsSaveDataFieldNumber = 2;

		// Token: 0x040022F7 RID: 8951
		private bool isSaveData_;

		// Token: 0x040022F8 RID: 8952
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040022F9 RID: 8953
		private uint retcode_;

		// Token: 0x040022FA RID: 8954
		public const int RaidTargetInfoFieldNumber = 4;

		// Token: 0x040022FB RID: 8955
		private static readonly FieldCodec<RaidTargetInfo> _repeated_raidTargetInfo_codec = FieldCodec.ForMessage<RaidTargetInfo>(34U, EggLink.DanhengServer.Proto.RaidTargetInfo.Parser);

		// Token: 0x040022FC RID: 8956
		private readonly RepeatedField<RaidTargetInfo> raidTargetInfo_ = new RepeatedField<RaidTargetInfo>();
	}
}

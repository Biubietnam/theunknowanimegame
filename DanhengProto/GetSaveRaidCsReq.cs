using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E1 RID: 2017
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSaveRaidCsReq : IMessage<GetSaveRaidCsReq>, IMessage, IEquatable<GetSaveRaidCsReq>, IDeepCloneable<GetSaveRaidCsReq>, IBufferMessage
	{
		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x000EFD24 File Offset: 0x000EDF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSaveRaidCsReq> Parser
		{
			get
			{
				return GetSaveRaidCsReq._parser;
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x060059F2 RID: 23026 RVA: 0x000EFD2B File Offset: 0x000EDF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSaveRaidCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x000EFD3D File Offset: 0x000EDF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSaveRaidCsReq.Descriptor;
			}
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x000EFD44 File Offset: 0x000EDF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveRaidCsReq()
		{
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x000EFD4C File Offset: 0x000EDF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveRaidCsReq(GetSaveRaidCsReq other) : this()
		{
			this.raidId_ = other.raidId_;
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x000EFD7D File Offset: 0x000EDF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveRaidCsReq Clone()
		{
			return new GetSaveRaidCsReq(this);
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x060059F7 RID: 23031 RVA: 0x000EFD85 File Offset: 0x000EDF85
		// (set) Token: 0x060059F8 RID: 23032 RVA: 0x000EFD8D File Offset: 0x000EDF8D
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

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x000EFD96 File Offset: 0x000EDF96
		// (set) Token: 0x060059FA RID: 23034 RVA: 0x000EFD9E File Offset: 0x000EDF9E
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

		// Token: 0x060059FB RID: 23035 RVA: 0x000EFDA7 File Offset: 0x000EDFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSaveRaidCsReq);
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x000EFDB5 File Offset: 0x000EDFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSaveRaidCsReq other)
		{
			return other != null && (other == this || (this.RaidId == other.RaidId && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x000EFDF4 File Offset: 0x000EDFF4
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x000EFE4C File Offset: 0x000EE04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x000EFE54 File Offset: 0x000EE054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A00 RID: 23040 RVA: 0x000EFE60 File Offset: 0x000EE060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.RaidId);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x000EFEBC File Offset: 0x000EE0BC
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x000EFF14 File Offset: 0x000EE114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSaveRaidCsReq other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A03 RID: 23043 RVA: 0x000EFF64 File Offset: 0x000EE164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x000EFF70 File Offset: 0x000EE170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WorldLevel = input.ReadUInt32();
					}
				}
				else
				{
					this.RaidId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040022E9 RID: 8937
		private static readonly MessageParser<GetSaveRaidCsReq> _parser = new MessageParser<GetSaveRaidCsReq>(() => new GetSaveRaidCsReq());

		// Token: 0x040022EA RID: 8938
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022EB RID: 8939
		public const int RaidIdFieldNumber = 10;

		// Token: 0x040022EC RID: 8940
		private uint raidId_;

		// Token: 0x040022ED RID: 8941
		public const int WorldLevelFieldNumber = 11;

		// Token: 0x040022EE RID: 8942
		private uint worldLevel_;
	}
}

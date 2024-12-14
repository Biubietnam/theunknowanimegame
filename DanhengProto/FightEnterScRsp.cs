using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000529 RID: 1321
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightEnterScRsp : IMessage<FightEnterScRsp>, IMessage, IEquatable<FightEnterScRsp>, IDeepCloneable<FightEnterScRsp>, IBufferMessage
	{
		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06003B17 RID: 15127 RVA: 0x000A2887 File Offset: 0x000A0A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightEnterScRsp> Parser
		{
			get
			{
				return FightEnterScRsp._parser;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x000A288E File Offset: 0x000A0A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightEnterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06003B19 RID: 15129 RVA: 0x000A28A0 File Offset: 0x000A0AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightEnterScRsp.Descriptor;
			}
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x000A28A7 File Offset: 0x000A0AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightEnterScRsp()
		{
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x000A28B0 File Offset: 0x000A0AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightEnterScRsp(FightEnterScRsp other) : this()
		{
			this.kMANPJCMAOB_ = other.kMANPJCMAOB_;
			this.lJMFOHLOBCI_ = other.lJMFOHLOBCI_;
			this.secretKeySeed_ = other.secretKeySeed_;
			this.serverTimestampMs_ = other.serverTimestampMs_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x000A2910 File Offset: 0x000A0B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightEnterScRsp Clone()
		{
			return new FightEnterScRsp(this);
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06003B1D RID: 15133 RVA: 0x000A2918 File Offset: 0x000A0B18
		// (set) Token: 0x06003B1E RID: 15134 RVA: 0x000A2920 File Offset: 0x000A0B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KMANPJCMAOB
		{
			get
			{
				return this.kMANPJCMAOB_;
			}
			set
			{
				this.kMANPJCMAOB_ = value;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06003B1F RID: 15135 RVA: 0x000A2929 File Offset: 0x000A0B29
		// (set) Token: 0x06003B20 RID: 15136 RVA: 0x000A2931 File Offset: 0x000A0B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LJMFOHLOBCI
		{
			get
			{
				return this.lJMFOHLOBCI_;
			}
			set
			{
				this.lJMFOHLOBCI_ = value;
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06003B21 RID: 15137 RVA: 0x000A293A File Offset: 0x000A0B3A
		// (set) Token: 0x06003B22 RID: 15138 RVA: 0x000A2942 File Offset: 0x000A0B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong SecretKeySeed
		{
			get
			{
				return this.secretKeySeed_;
			}
			set
			{
				this.secretKeySeed_ = value;
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06003B23 RID: 15139 RVA: 0x000A294B File Offset: 0x000A0B4B
		// (set) Token: 0x06003B24 RID: 15140 RVA: 0x000A2953 File Offset: 0x000A0B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ServerTimestampMs
		{
			get
			{
				return this.serverTimestampMs_;
			}
			set
			{
				this.serverTimestampMs_ = value;
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06003B25 RID: 15141 RVA: 0x000A295C File Offset: 0x000A0B5C
		// (set) Token: 0x06003B26 RID: 15142 RVA: 0x000A2964 File Offset: 0x000A0B64
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

		// Token: 0x06003B27 RID: 15143 RVA: 0x000A296D File Offset: 0x000A0B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightEnterScRsp);
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x000A297C File Offset: 0x000A0B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightEnterScRsp other)
		{
			return other != null && (other == this || (this.KMANPJCMAOB == other.KMANPJCMAOB && this.LJMFOHLOBCI == other.LJMFOHLOBCI && this.SecretKeySeed == other.SecretKeySeed && this.ServerTimestampMs == other.ServerTimestampMs && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x000A29F8 File Offset: 0x000A0BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KMANPJCMAOB != 0U)
			{
				num ^= this.KMANPJCMAOB.GetHashCode();
			}
			if (this.LJMFOHLOBCI)
			{
				num ^= this.LJMFOHLOBCI.GetHashCode();
			}
			if (this.SecretKeySeed != 0UL)
			{
				num ^= this.SecretKeySeed.GetHashCode();
			}
			if (this.ServerTimestampMs != 0UL)
			{
				num ^= this.ServerTimestampMs.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x000A2A9B File Offset: 0x000A0C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x000A2AA3 File Offset: 0x000A0CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x000A2AAC File Offset: 0x000A0CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.KMANPJCMAOB != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.KMANPJCMAOB);
			}
			if (this.LJMFOHLOBCI)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.LJMFOHLOBCI);
			}
			if (this.ServerTimestampMs != 0UL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.ServerTimestampMs);
			}
			if (this.SecretKeySeed != 0UL)
			{
				output.WriteRawTag(120);
				output.WriteUInt64(this.SecretKeySeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x000A2B58 File Offset: 0x000A0D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KMANPJCMAOB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KMANPJCMAOB);
			}
			if (this.LJMFOHLOBCI)
			{
				num += 2;
			}
			if (this.SecretKeySeed != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SecretKeySeed);
			}
			if (this.ServerTimestampMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ServerTimestampMs);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x000A2BEC File Offset: 0x000A0DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightEnterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KMANPJCMAOB != 0U)
			{
				this.KMANPJCMAOB = other.KMANPJCMAOB;
			}
			if (other.LJMFOHLOBCI)
			{
				this.LJMFOHLOBCI = other.LJMFOHLOBCI;
			}
			if (other.SecretKeySeed != 0UL)
			{
				this.SecretKeySeed = other.SecretKeySeed;
			}
			if (other.ServerTimestampMs != 0UL)
			{
				this.ServerTimestampMs = other.ServerTimestampMs;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x000A2C78 File Offset: 0x000A0E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x000A2C84 File Offset: 0x000A0E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.KMANPJCMAOB = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.LJMFOHLOBCI = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.ServerTimestampMs = input.ReadUInt64();
						continue;
					}
					if (num == 120U)
					{
						this.SecretKeySeed = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040017C4 RID: 6084
		private static readonly MessageParser<FightEnterScRsp> _parser = new MessageParser<FightEnterScRsp>(() => new FightEnterScRsp());

		// Token: 0x040017C5 RID: 6085
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017C6 RID: 6086
		public const int KMANPJCMAOBFieldNumber = 4;

		// Token: 0x040017C7 RID: 6087
		private uint kMANPJCMAOB_;

		// Token: 0x040017C8 RID: 6088
		public const int LJMFOHLOBCIFieldNumber = 5;

		// Token: 0x040017C9 RID: 6089
		private bool lJMFOHLOBCI_;

		// Token: 0x040017CA RID: 6090
		public const int SecretKeySeedFieldNumber = 15;

		// Token: 0x040017CB RID: 6091
		private ulong secretKeySeed_;

		// Token: 0x040017CC RID: 6092
		public const int ServerTimestampMsFieldNumber = 13;

		// Token: 0x040017CD RID: 6093
		private ulong serverTimestampMs_;

		// Token: 0x040017CE RID: 6094
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040017CF RID: 6095
		private uint retcode_;
	}
}

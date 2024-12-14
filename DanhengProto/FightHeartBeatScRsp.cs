using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000539 RID: 1337
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightHeartBeatScRsp : IMessage<FightHeartBeatScRsp>, IMessage, IEquatable<FightHeartBeatScRsp>, IDeepCloneable<FightHeartBeatScRsp>, IBufferMessage
	{
		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06003BAB RID: 15275 RVA: 0x000A3EA9 File Offset: 0x000A20A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightHeartBeatScRsp> Parser
		{
			get
			{
				return FightHeartBeatScRsp._parser;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x000A3EB0 File Offset: 0x000A20B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightHeartBeatScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x000A3EC2 File Offset: 0x000A20C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightHeartBeatScRsp.Descriptor;
			}
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x000A3EC9 File Offset: 0x000A20C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightHeartBeatScRsp()
		{
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x000A3ED1 File Offset: 0x000A20D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightHeartBeatScRsp(FightHeartBeatScRsp other) : this()
		{
			this.clientTimeMs_ = other.clientTimeMs_;
			this.retcode_ = other.retcode_;
			this.serverTimeMs_ = other.serverTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x000A3F0E File Offset: 0x000A210E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightHeartBeatScRsp Clone()
		{
			return new FightHeartBeatScRsp(this);
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x000A3F16 File Offset: 0x000A2116
		// (set) Token: 0x06003BB2 RID: 15282 RVA: 0x000A3F1E File Offset: 0x000A211E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ClientTimeMs
		{
			get
			{
				return this.clientTimeMs_;
			}
			set
			{
				this.clientTimeMs_ = value;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x000A3F27 File Offset: 0x000A2127
		// (set) Token: 0x06003BB4 RID: 15284 RVA: 0x000A3F2F File Offset: 0x000A212F
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

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x000A3F38 File Offset: 0x000A2138
		// (set) Token: 0x06003BB6 RID: 15286 RVA: 0x000A3F40 File Offset: 0x000A2140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ServerTimeMs
		{
			get
			{
				return this.serverTimeMs_;
			}
			set
			{
				this.serverTimeMs_ = value;
			}
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x000A3F49 File Offset: 0x000A2149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightHeartBeatScRsp);
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x000A3F58 File Offset: 0x000A2158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightHeartBeatScRsp other)
		{
			return other != null && (other == this || (this.ClientTimeMs == other.ClientTimeMs && this.Retcode == other.Retcode && this.ServerTimeMs == other.ServerTimeMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x000A3FB4 File Offset: 0x000A21B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientTimeMs != 0UL)
			{
				num ^= this.ClientTimeMs.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ServerTimeMs != 0UL)
			{
				num ^= this.ServerTimeMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x000A4025 File Offset: 0x000A2225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x000A402D File Offset: 0x000A222D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x000A4038 File Offset: 0x000A2238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ServerTimeMs != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ServerTimeMs);
			}
			if (this.ClientTimeMs != 0UL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ClientTimeMs);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x000A40B0 File Offset: 0x000A22B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClientTimeMs);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ServerTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ServerTimeMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x000A4120 File Offset: 0x000A2320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightHeartBeatScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientTimeMs != 0UL)
			{
				this.ClientTimeMs = other.ClientTimeMs;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ServerTimeMs != 0UL)
			{
				this.ServerTimeMs = other.ServerTimeMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x000A4184 File Offset: 0x000A2384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x000A4190 File Offset: 0x000A2390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.ClientTimeMs = input.ReadUInt64();
					}
				}
				else
				{
					this.ServerTimeMs = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040017FF RID: 6143
		private static readonly MessageParser<FightHeartBeatScRsp> _parser = new MessageParser<FightHeartBeatScRsp>(() => new FightHeartBeatScRsp());

		// Token: 0x04001800 RID: 6144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001801 RID: 6145
		public const int ClientTimeMsFieldNumber = 3;

		// Token: 0x04001802 RID: 6146
		private ulong clientTimeMs_;

		// Token: 0x04001803 RID: 6147
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04001804 RID: 6148
		private uint retcode_;

		// Token: 0x04001805 RID: 6149
		public const int ServerTimeMsFieldNumber = 2;

		// Token: 0x04001806 RID: 6150
		private ulong serverTimeMs_;
	}
}

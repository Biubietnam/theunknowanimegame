using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B75 RID: 2933
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyScrachRaffleTicketScRsp : IMessage<MonopolyScrachRaffleTicketScRsp>, IMessage, IEquatable<MonopolyScrachRaffleTicketScRsp>, IDeepCloneable<MonopolyScrachRaffleTicketScRsp>, IBufferMessage
	{
		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x060081C8 RID: 33224 RVA: 0x00155DFD File Offset: 0x00153FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyScrachRaffleTicketScRsp> Parser
		{
			get
			{
				return MonopolyScrachRaffleTicketScRsp._parser;
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x060081C9 RID: 33225 RVA: 0x00155E04 File Offset: 0x00154004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyScrachRaffleTicketScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x060081CA RID: 33226 RVA: 0x00155E16 File Offset: 0x00154016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyScrachRaffleTicketScRsp.Descriptor;
			}
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x00155E1D File Offset: 0x0015401D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyScrachRaffleTicketScRsp()
		{
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x00155E25 File Offset: 0x00154025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyScrachRaffleTicketScRsp(MonopolyScrachRaffleTicketScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.cFAABCLGKGB_ = other.cFAABCLGKGB_;
			this.poolId_ = other.poolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x00155E62 File Offset: 0x00154062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyScrachRaffleTicketScRsp Clone()
		{
			return new MonopolyScrachRaffleTicketScRsp(this);
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x060081CE RID: 33230 RVA: 0x00155E6A File Offset: 0x0015406A
		// (set) Token: 0x060081CF RID: 33231 RVA: 0x00155E72 File Offset: 0x00154072
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

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x060081D0 RID: 33232 RVA: 0x00155E7B File Offset: 0x0015407B
		// (set) Token: 0x060081D1 RID: 33233 RVA: 0x00155E83 File Offset: 0x00154083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong CFAABCLGKGB
		{
			get
			{
				return this.cFAABCLGKGB_;
			}
			set
			{
				this.cFAABCLGKGB_ = value;
			}
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x060081D2 RID: 33234 RVA: 0x00155E8C File Offset: 0x0015408C
		// (set) Token: 0x060081D3 RID: 33235 RVA: 0x00155E94 File Offset: 0x00154094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x060081D4 RID: 33236 RVA: 0x00155E9D File Offset: 0x0015409D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyScrachRaffleTicketScRsp);
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x00155EAC File Offset: 0x001540AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyScrachRaffleTicketScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.CFAABCLGKGB == other.CFAABCLGKGB && this.PoolId == other.PoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x00155F08 File Offset: 0x00154108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CFAABCLGKGB != 0UL)
			{
				num ^= this.CFAABCLGKGB.GetHashCode();
			}
			if (this.PoolId != 0U)
			{
				num ^= this.PoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x00155F79 File Offset: 0x00154179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x00155F81 File Offset: 0x00154181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x00155F8C File Offset: 0x0015418C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PoolId);
			}
			if (this.CFAABCLGKGB != 0UL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CFAABCLGKGB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081DA RID: 33242 RVA: 0x00156000 File Offset: 0x00154200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CFAABCLGKGB != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CFAABCLGKGB);
			}
			if (this.PoolId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081DB RID: 33243 RVA: 0x00156070 File Offset: 0x00154270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyScrachRaffleTicketScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CFAABCLGKGB != 0UL)
			{
				this.CFAABCLGKGB = other.CFAABCLGKGB;
			}
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x001560D4 File Offset: 0x001542D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x001560E0 File Offset: 0x001542E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CFAABCLGKGB = input.ReadUInt64();
						}
					}
					else
					{
						this.PoolId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003181 RID: 12673
		private static readonly MessageParser<MonopolyScrachRaffleTicketScRsp> _parser = new MessageParser<MonopolyScrachRaffleTicketScRsp>(() => new MonopolyScrachRaffleTicketScRsp());

		// Token: 0x04003182 RID: 12674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003183 RID: 12675
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04003184 RID: 12676
		private uint retcode_;

		// Token: 0x04003185 RID: 12677
		public const int CFAABCLGKGBFieldNumber = 5;

		// Token: 0x04003186 RID: 12678
		private ulong cFAABCLGKGB_;

		// Token: 0x04003187 RID: 12679
		public const int PoolIdFieldNumber = 3;

		// Token: 0x04003188 RID: 12680
		private uint poolId_;
	}
}

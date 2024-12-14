using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B47 RID: 2887
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGetRaffleTicketScRsp : IMessage<MonopolyGetRaffleTicketScRsp>, IMessage, IEquatable<MonopolyGetRaffleTicketScRsp>, IDeepCloneable<MonopolyGetRaffleTicketScRsp>, IBufferMessage
	{
		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x06007FCC RID: 32716 RVA: 0x001518AB File Offset: 0x0014FAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGetRaffleTicketScRsp> Parser
		{
			get
			{
				return MonopolyGetRaffleTicketScRsp._parser;
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x06007FCD RID: 32717 RVA: 0x001518B2 File Offset: 0x0014FAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGetRaffleTicketScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x06007FCE RID: 32718 RVA: 0x001518C4 File Offset: 0x0014FAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGetRaffleTicketScRsp.Descriptor;
			}
		}

		// Token: 0x06007FCF RID: 32719 RVA: 0x001518CB File Offset: 0x0014FACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRaffleTicketScRsp()
		{
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x001518E0 File Offset: 0x0014FAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRaffleTicketScRsp(MonopolyGetRaffleTicketScRsp other) : this()
		{
			this.pCIHJDLICGK_ = other.pCIHJDLICGK_.Clone();
			this.poolId_ = other.poolId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x0015192D File Offset: 0x0014FB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRaffleTicketScRsp Clone()
		{
			return new MonopolyGetRaffleTicketScRsp(this);
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x06007FD2 RID: 32722 RVA: 0x00151935 File Offset: 0x0014FB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KHBAFNOEJOE> PCIHJDLICGK
		{
			get
			{
				return this.pCIHJDLICGK_;
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x06007FD3 RID: 32723 RVA: 0x0015193D File Offset: 0x0014FB3D
		// (set) Token: 0x06007FD4 RID: 32724 RVA: 0x00151945 File Offset: 0x0014FB45
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

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x0015194E File Offset: 0x0014FB4E
		// (set) Token: 0x06007FD6 RID: 32726 RVA: 0x00151956 File Offset: 0x0014FB56
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

		// Token: 0x06007FD7 RID: 32727 RVA: 0x0015195F File Offset: 0x0014FB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGetRaffleTicketScRsp);
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x00151970 File Offset: 0x0014FB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGetRaffleTicketScRsp other)
		{
			return other != null && (other == this || (this.pCIHJDLICGK_.Equals(other.pCIHJDLICGK_) && this.PoolId == other.PoolId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FD9 RID: 32729 RVA: 0x001519D0 File Offset: 0x0014FBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pCIHJDLICGK_.GetHashCode();
			if (this.PoolId != 0U)
			{
				num ^= this.PoolId.GetHashCode();
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

		// Token: 0x06007FDA RID: 32730 RVA: 0x00151A36 File Offset: 0x0014FC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x00151A3E File Offset: 0x0014FC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x00151A48 File Offset: 0x0014FC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pCIHJDLICGK_.WriteTo(ref output, MonopolyGetRaffleTicketScRsp._repeated_pCIHJDLICGK_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x00151AB4 File Offset: 0x0014FCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pCIHJDLICGK_.CalculateSize(MonopolyGetRaffleTicketScRsp._repeated_pCIHJDLICGK_codec);
			if (this.PoolId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PoolId);
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

		// Token: 0x06007FDE RID: 32734 RVA: 0x00151B20 File Offset: 0x0014FD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGetRaffleTicketScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.pCIHJDLICGK_.Add(other.pCIHJDLICGK_);
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x00151B81 File Offset: 0x0014FD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x00151B8C File Offset: 0x0014FD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 32U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.pCIHJDLICGK_.AddEntriesFrom(ref input, MonopolyGetRaffleTicketScRsp._repeated_pCIHJDLICGK_codec);
				}
			}
		}

		// Token: 0x040030EB RID: 12523
		private static readonly MessageParser<MonopolyGetRaffleTicketScRsp> _parser = new MessageParser<MonopolyGetRaffleTicketScRsp>(() => new MonopolyGetRaffleTicketScRsp());

		// Token: 0x040030EC RID: 12524
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030ED RID: 12525
		public const int PCIHJDLICGKFieldNumber = 1;

		// Token: 0x040030EE RID: 12526
		private static readonly FieldCodec<KHBAFNOEJOE> _repeated_pCIHJDLICGK_codec = FieldCodec.ForMessage<KHBAFNOEJOE>(10U, KHBAFNOEJOE.Parser);

		// Token: 0x040030EF RID: 12527
		private readonly RepeatedField<KHBAFNOEJOE> pCIHJDLICGK_ = new RepeatedField<KHBAFNOEJOE>();

		// Token: 0x040030F0 RID: 12528
		public const int PoolIdFieldNumber = 11;

		// Token: 0x040030F1 RID: 12529
		private uint poolId_;

		// Token: 0x040030F2 RID: 12530
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040030F3 RID: 12531
		private uint retcode_;
	}
}

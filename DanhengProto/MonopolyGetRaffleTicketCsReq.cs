using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B45 RID: 2885
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGetRaffleTicketCsReq : IMessage<MonopolyGetRaffleTicketCsReq>, IMessage, IEquatable<MonopolyGetRaffleTicketCsReq>, IDeepCloneable<MonopolyGetRaffleTicketCsReq>, IBufferMessage
	{
		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x06007FB7 RID: 32695 RVA: 0x00151604 File Offset: 0x0014F804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGetRaffleTicketCsReq> Parser
		{
			get
			{
				return MonopolyGetRaffleTicketCsReq._parser;
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x0015160B File Offset: 0x0014F80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGetRaffleTicketCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x06007FB9 RID: 32697 RVA: 0x0015161D File Offset: 0x0014F81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGetRaffleTicketCsReq.Descriptor;
			}
		}

		// Token: 0x06007FBA RID: 32698 RVA: 0x00151624 File Offset: 0x0014F824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRaffleTicketCsReq()
		{
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x0015162C File Offset: 0x0014F82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRaffleTicketCsReq(MonopolyGetRaffleTicketCsReq other) : this()
		{
			this.poolId_ = other.poolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x00151651 File Offset: 0x0014F851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRaffleTicketCsReq Clone()
		{
			return new MonopolyGetRaffleTicketCsReq(this);
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x06007FBD RID: 32701 RVA: 0x00151659 File Offset: 0x0014F859
		// (set) Token: 0x06007FBE RID: 32702 RVA: 0x00151661 File Offset: 0x0014F861
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

		// Token: 0x06007FBF RID: 32703 RVA: 0x0015166A File Offset: 0x0014F86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGetRaffleTicketCsReq);
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x00151678 File Offset: 0x0014F878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGetRaffleTicketCsReq other)
		{
			return other != null && (other == this || (this.PoolId == other.PoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x001516A8 File Offset: 0x0014F8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06007FC2 RID: 32706 RVA: 0x001516E7 File Offset: 0x0014F8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x001516EF File Offset: 0x0014F8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FC4 RID: 32708 RVA: 0x001516F8 File Offset: 0x0014F8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FC5 RID: 32709 RVA: 0x0015172C File Offset: 0x0014F92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06007FC6 RID: 32710 RVA: 0x0015176A File Offset: 0x0014F96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGetRaffleTicketCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FC7 RID: 32711 RVA: 0x0015179B File Offset: 0x0014F99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x001517A4 File Offset: 0x0014F9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PoolId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040030E6 RID: 12518
		private static readonly MessageParser<MonopolyGetRaffleTicketCsReq> _parser = new MessageParser<MonopolyGetRaffleTicketCsReq>(() => new MonopolyGetRaffleTicketCsReq());

		// Token: 0x040030E7 RID: 12519
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030E8 RID: 12520
		public const int PoolIdFieldNumber = 12;

		// Token: 0x040030E9 RID: 12521
		private uint poolId_;
	}
}

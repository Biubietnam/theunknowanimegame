using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B83 RID: 2947
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyTakeRaffleTicketRewardCsReq : IMessage<MonopolyTakeRaffleTicketRewardCsReq>, IMessage, IEquatable<MonopolyTakeRaffleTicketRewardCsReq>, IDeepCloneable<MonopolyTakeRaffleTicketRewardCsReq>, IBufferMessage
	{
		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x06008269 RID: 33385 RVA: 0x00157715 File Offset: 0x00155915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyTakeRaffleTicketRewardCsReq> Parser
		{
			get
			{
				return MonopolyTakeRaffleTicketRewardCsReq._parser;
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600826A RID: 33386 RVA: 0x0015771C File Offset: 0x0015591C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyTakeRaffleTicketRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600826B RID: 33387 RVA: 0x0015772E File Offset: 0x0015592E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyTakeRaffleTicketRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600826C RID: 33388 RVA: 0x00157735 File Offset: 0x00155935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakeRaffleTicketRewardCsReq()
		{
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x0015773D File Offset: 0x0015593D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakeRaffleTicketRewardCsReq(MonopolyTakeRaffleTicketRewardCsReq other) : this()
		{
			this.cFAABCLGKGB_ = other.cFAABCLGKGB_;
			this.poolId_ = other.poolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x0015776E File Offset: 0x0015596E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakeRaffleTicketRewardCsReq Clone()
		{
			return new MonopolyTakeRaffleTicketRewardCsReq(this);
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x0600826F RID: 33391 RVA: 0x00157776 File Offset: 0x00155976
		// (set) Token: 0x06008270 RID: 33392 RVA: 0x0015777E File Offset: 0x0015597E
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

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x06008271 RID: 33393 RVA: 0x00157787 File Offset: 0x00155987
		// (set) Token: 0x06008272 RID: 33394 RVA: 0x0015778F File Offset: 0x0015598F
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

		// Token: 0x06008273 RID: 33395 RVA: 0x00157798 File Offset: 0x00155998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyTakeRaffleTicketRewardCsReq);
		}

		// Token: 0x06008274 RID: 33396 RVA: 0x001577A6 File Offset: 0x001559A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyTakeRaffleTicketRewardCsReq other)
		{
			return other != null && (other == this || (this.CFAABCLGKGB == other.CFAABCLGKGB && this.PoolId == other.PoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008275 RID: 33397 RVA: 0x001577E4 File Offset: 0x001559E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06008276 RID: 33398 RVA: 0x0015783C File Offset: 0x00155A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008277 RID: 33399 RVA: 0x00157844 File Offset: 0x00155A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x00157850 File Offset: 0x00155A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PoolId);
			}
			if (this.CFAABCLGKGB != 0UL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.CFAABCLGKGB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x001578AC File Offset: 0x00155AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600827A RID: 33402 RVA: 0x00157904 File Offset: 0x00155B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyTakeRaffleTicketRewardCsReq other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600827B RID: 33403 RVA: 0x00157954 File Offset: 0x00155B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x00157960 File Offset: 0x00155B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 96U)
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
		}

		// Token: 0x040031BA RID: 12730
		private static readonly MessageParser<MonopolyTakeRaffleTicketRewardCsReq> _parser = new MessageParser<MonopolyTakeRaffleTicketRewardCsReq>(() => new MonopolyTakeRaffleTicketRewardCsReq());

		// Token: 0x040031BB RID: 12731
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031BC RID: 12732
		public const int CFAABCLGKGBFieldNumber = 12;

		// Token: 0x040031BD RID: 12733
		private ulong cFAABCLGKGB_;

		// Token: 0x040031BE RID: 12734
		public const int PoolIdFieldNumber = 2;

		// Token: 0x040031BF RID: 12735
		private uint poolId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B73 RID: 2931
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyScrachRaffleTicketCsReq : IMessage<MonopolyScrachRaffleTicketCsReq>, IMessage, IEquatable<MonopolyScrachRaffleTicketCsReq>, IDeepCloneable<MonopolyScrachRaffleTicketCsReq>, IBufferMessage
	{
		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x060081B1 RID: 33201 RVA: 0x00155ABD File Offset: 0x00153CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyScrachRaffleTicketCsReq> Parser
		{
			get
			{
				return MonopolyScrachRaffleTicketCsReq._parser;
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x060081B2 RID: 33202 RVA: 0x00155AC4 File Offset: 0x00153CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyScrachRaffleTicketCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x060081B3 RID: 33203 RVA: 0x00155AD6 File Offset: 0x00153CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyScrachRaffleTicketCsReq.Descriptor;
			}
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x00155ADD File Offset: 0x00153CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyScrachRaffleTicketCsReq()
		{
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x00155AE5 File Offset: 0x00153CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyScrachRaffleTicketCsReq(MonopolyScrachRaffleTicketCsReq other) : this()
		{
			this.poolId_ = other.poolId_;
			this.cFAABCLGKGB_ = other.cFAABCLGKGB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x00155B16 File Offset: 0x00153D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyScrachRaffleTicketCsReq Clone()
		{
			return new MonopolyScrachRaffleTicketCsReq(this);
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x060081B7 RID: 33207 RVA: 0x00155B1E File Offset: 0x00153D1E
		// (set) Token: 0x060081B8 RID: 33208 RVA: 0x00155B26 File Offset: 0x00153D26
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

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x060081B9 RID: 33209 RVA: 0x00155B2F File Offset: 0x00153D2F
		// (set) Token: 0x060081BA RID: 33210 RVA: 0x00155B37 File Offset: 0x00153D37
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

		// Token: 0x060081BB RID: 33211 RVA: 0x00155B40 File Offset: 0x00153D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyScrachRaffleTicketCsReq);
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x00155B4E File Offset: 0x00153D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyScrachRaffleTicketCsReq other)
		{
			return other != null && (other == this || (this.PoolId == other.PoolId && this.CFAABCLGKGB == other.CFAABCLGKGB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x00155B8C File Offset: 0x00153D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PoolId != 0U)
			{
				num ^= this.PoolId.GetHashCode();
			}
			if (this.CFAABCLGKGB != 0UL)
			{
				num ^= this.CFAABCLGKGB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x00155BE4 File Offset: 0x00153DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x00155BEC File Offset: 0x00153DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x00155BF8 File Offset: 0x00153DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CFAABCLGKGB != 0UL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CFAABCLGKGB);
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

		// Token: 0x060081C1 RID: 33217 RVA: 0x00155C54 File Offset: 0x00153E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PoolId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PoolId);
			}
			if (this.CFAABCLGKGB != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CFAABCLGKGB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x00155CAC File Offset: 0x00153EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyScrachRaffleTicketCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			if (other.CFAABCLGKGB != 0UL)
			{
				this.CFAABCLGKGB = other.CFAABCLGKGB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x00155CFC File Offset: 0x00153EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x00155D08 File Offset: 0x00153F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
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
					this.CFAABCLGKGB = input.ReadUInt64();
				}
			}
		}

		// Token: 0x0400317A RID: 12666
		private static readonly MessageParser<MonopolyScrachRaffleTicketCsReq> _parser = new MessageParser<MonopolyScrachRaffleTicketCsReq>(() => new MonopolyScrachRaffleTicketCsReq());

		// Token: 0x0400317B RID: 12667
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400317C RID: 12668
		public const int PoolIdFieldNumber = 11;

		// Token: 0x0400317D RID: 12669
		private uint poolId_;

		// Token: 0x0400317E RID: 12670
		public const int CFAABCLGKGBFieldNumber = 5;

		// Token: 0x0400317F RID: 12671
		private ulong cFAABCLGKGB_;
	}
}

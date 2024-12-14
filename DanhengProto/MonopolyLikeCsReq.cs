using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B5B RID: 2907
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyLikeCsReq : IMessage<MonopolyLikeCsReq>, IMessage, IEquatable<MonopolyLikeCsReq>, IDeepCloneable<MonopolyLikeCsReq>, IBufferMessage
	{
		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x060080A4 RID: 32932 RVA: 0x00153428 File Offset: 0x00151628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyLikeCsReq> Parser
		{
			get
			{
				return MonopolyLikeCsReq._parser;
			}
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x060080A5 RID: 32933 RVA: 0x0015342F File Offset: 0x0015162F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyLikeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x060080A6 RID: 32934 RVA: 0x00153441 File Offset: 0x00151641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyLikeCsReq.Descriptor;
			}
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x00153448 File Offset: 0x00151648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeCsReq()
		{
		}

		// Token: 0x060080A8 RID: 32936 RVA: 0x00153450 File Offset: 0x00151650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeCsReq(MonopolyLikeCsReq other) : this()
		{
			this.bEJLJKLPFHI_ = other.bEJLJKLPFHI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080A9 RID: 32937 RVA: 0x00153475 File Offset: 0x00151675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeCsReq Clone()
		{
			return new MonopolyLikeCsReq(this);
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x060080AA RID: 32938 RVA: 0x0015347D File Offset: 0x0015167D
		// (set) Token: 0x060080AB RID: 32939 RVA: 0x00153485 File Offset: 0x00151685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BEJLJKLPFHI
		{
			get
			{
				return this.bEJLJKLPFHI_;
			}
			set
			{
				this.bEJLJKLPFHI_ = value;
			}
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x0015348E File Offset: 0x0015168E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyLikeCsReq);
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x0015349C File Offset: 0x0015169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyLikeCsReq other)
		{
			return other != null && (other == this || (this.BEJLJKLPFHI == other.BEJLJKLPFHI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x001534CC File Offset: 0x001516CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BEJLJKLPFHI != 0U)
			{
				num ^= this.BEJLJKLPFHI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x0015350B File Offset: 0x0015170B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x00153513 File Offset: 0x00151713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x0015351C File Offset: 0x0015171C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BEJLJKLPFHI != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.BEJLJKLPFHI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x00153550 File Offset: 0x00151750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BEJLJKLPFHI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BEJLJKLPFHI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x0015358E File Offset: 0x0015178E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyLikeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BEJLJKLPFHI != 0U)
			{
				this.BEJLJKLPFHI = other.BEJLJKLPFHI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x001535BF File Offset: 0x001517BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x001535C8 File Offset: 0x001517C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BEJLJKLPFHI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003127 RID: 12583
		private static readonly MessageParser<MonopolyLikeCsReq> _parser = new MessageParser<MonopolyLikeCsReq>(() => new MonopolyLikeCsReq());

		// Token: 0x04003128 RID: 12584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003129 RID: 12585
		public const int BEJLJKLPFHIFieldNumber = 8;

		// Token: 0x0400312A RID: 12586
		private uint bEJLJKLPFHI_;
	}
}

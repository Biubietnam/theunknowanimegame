using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DC5 RID: 3525
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReserveStaminaExchangeCsReq : IMessage<ReserveStaminaExchangeCsReq>, IMessage, IEquatable<ReserveStaminaExchangeCsReq>, IDeepCloneable<ReserveStaminaExchangeCsReq>, IBufferMessage
	{
		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x06009D9D RID: 40349 RVA: 0x001A3F70 File Offset: 0x001A2170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReserveStaminaExchangeCsReq> Parser
		{
			get
			{
				return ReserveStaminaExchangeCsReq._parser;
			}
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x06009D9E RID: 40350 RVA: 0x001A3F77 File Offset: 0x001A2177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReserveStaminaExchangeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x06009D9F RID: 40351 RVA: 0x001A3F89 File Offset: 0x001A2189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReserveStaminaExchangeCsReq.Descriptor;
			}
		}

		// Token: 0x06009DA0 RID: 40352 RVA: 0x001A3F90 File Offset: 0x001A2190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReserveStaminaExchangeCsReq()
		{
		}

		// Token: 0x06009DA1 RID: 40353 RVA: 0x001A3F98 File Offset: 0x001A2198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReserveStaminaExchangeCsReq(ReserveStaminaExchangeCsReq other) : this()
		{
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x001A3FBD File Offset: 0x001A21BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReserveStaminaExchangeCsReq Clone()
		{
			return new ReserveStaminaExchangeCsReq(this);
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x06009DA3 RID: 40355 RVA: 0x001A3FC5 File Offset: 0x001A21C5
		// (set) Token: 0x06009DA4 RID: 40356 RVA: 0x001A3FCD File Offset: 0x001A21CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x001A3FD6 File Offset: 0x001A21D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReserveStaminaExchangeCsReq);
		}

		// Token: 0x06009DA6 RID: 40358 RVA: 0x001A3FE4 File Offset: 0x001A21E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReserveStaminaExchangeCsReq other)
		{
			return other != null && (other == this || (this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DA7 RID: 40359 RVA: 0x001A4014 File Offset: 0x001A2214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DA8 RID: 40360 RVA: 0x001A4053 File Offset: 0x001A2253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x001A405B File Offset: 0x001A225B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x001A4064 File Offset: 0x001A2264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Num != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x001A4098 File Offset: 0x001A2298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x001A40D6 File Offset: 0x001A22D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReserveStaminaExchangeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x001A4107 File Offset: 0x001A2307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DAE RID: 40366 RVA: 0x001A4110 File Offset: 0x001A2310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Num = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D4D RID: 15693
		private static readonly MessageParser<ReserveStaminaExchangeCsReq> _parser = new MessageParser<ReserveStaminaExchangeCsReq>(() => new ReserveStaminaExchangeCsReq());

		// Token: 0x04003D4E RID: 15694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D4F RID: 15695
		public const int NumFieldNumber = 6;

		// Token: 0x04003D50 RID: 15696
		private uint num_;
	}
}

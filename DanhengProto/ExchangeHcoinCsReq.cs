using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004D7 RID: 1239
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeHcoinCsReq : IMessage<ExchangeHcoinCsReq>, IMessage, IEquatable<ExchangeHcoinCsReq>, IDeepCloneable<ExchangeHcoinCsReq>, IBufferMessage
	{
		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x0600376A RID: 14186 RVA: 0x0009822C File Offset: 0x0009642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeHcoinCsReq> Parser
		{
			get
			{
				return ExchangeHcoinCsReq._parser;
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x00098233 File Offset: 0x00096433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeHcoinCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x0600376C RID: 14188 RVA: 0x00098245 File Offset: 0x00096445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeHcoinCsReq.Descriptor;
			}
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x0009824C File Offset: 0x0009644C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeHcoinCsReq()
		{
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x00098254 File Offset: 0x00096454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeHcoinCsReq(ExchangeHcoinCsReq other) : this()
		{
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00098279 File Offset: 0x00096479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeHcoinCsReq Clone()
		{
			return new ExchangeHcoinCsReq(this);
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x00098281 File Offset: 0x00096481
		// (set) Token: 0x06003771 RID: 14193 RVA: 0x00098289 File Offset: 0x00096489
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

		// Token: 0x06003772 RID: 14194 RVA: 0x00098292 File Offset: 0x00096492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeHcoinCsReq);
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x000982A0 File Offset: 0x000964A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeHcoinCsReq other)
		{
			return other != null && (other == this || (this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x000982D0 File Offset: 0x000964D0
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

		// Token: 0x06003775 RID: 14197 RVA: 0x0009830F File Offset: 0x0009650F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00098317 File Offset: 0x00096517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00098320 File Offset: 0x00096520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Num != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00098354 File Offset: 0x00096554
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

		// Token: 0x06003779 RID: 14201 RVA: 0x00098392 File Offset: 0x00096592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeHcoinCsReq other)
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

		// Token: 0x0600377A RID: 14202 RVA: 0x000983C3 File Offset: 0x000965C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x000983CC File Offset: 0x000965CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Num = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015F9 RID: 5625
		private static readonly MessageParser<ExchangeHcoinCsReq> _parser = new MessageParser<ExchangeHcoinCsReq>(() => new ExchangeHcoinCsReq());

		// Token: 0x040015FA RID: 5626
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015FB RID: 5627
		public const int NumFieldNumber = 3;

		// Token: 0x040015FC RID: 5628
		private uint num_;
	}
}

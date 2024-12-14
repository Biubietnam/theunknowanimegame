using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A65 RID: 2661
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LogisticsGameCsReq : IMessage<LogisticsGameCsReq>, IMessage, IEquatable<LogisticsGameCsReq>, IDeepCloneable<LogisticsGameCsReq>, IBufferMessage
	{
		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x060075F5 RID: 30197 RVA: 0x00139089 File Offset: 0x00137289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogisticsGameCsReq> Parser
		{
			get
			{
				return LogisticsGameCsReq._parser;
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x060075F6 RID: 30198 RVA: 0x00139090 File Offset: 0x00137290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LogisticsGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x060075F7 RID: 30199 RVA: 0x001390A2 File Offset: 0x001372A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogisticsGameCsReq.Descriptor;
			}
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x001390A9 File Offset: 0x001372A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsGameCsReq()
		{
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x001390BC File Offset: 0x001372BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsGameCsReq(LogisticsGameCsReq other) : this()
		{
			this.lPLCDELGJDI_ = other.lPLCDELGJDI_;
			this.aACPHJGMNDF_ = other.aACPHJGMNDF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x001390F2 File Offset: 0x001372F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsGameCsReq Clone()
		{
			return new LogisticsGameCsReq(this);
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x060075FB RID: 30203 RVA: 0x001390FA File Offset: 0x001372FA
		// (set) Token: 0x060075FC RID: 30204 RVA: 0x00139102 File Offset: 0x00137302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LPLCDELGJDI
		{
			get
			{
				return this.lPLCDELGJDI_;
			}
			set
			{
				this.lPLCDELGJDI_ = value;
			}
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x060075FD RID: 30205 RVA: 0x0013910B File Offset: 0x0013730B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HGGCNNJOEPH> AACPHJGMNDF
		{
			get
			{
				return this.aACPHJGMNDF_;
			}
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x00139113 File Offset: 0x00137313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogisticsGameCsReq);
		}

		// Token: 0x060075FF RID: 30207 RVA: 0x00139124 File Offset: 0x00137324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogisticsGameCsReq other)
		{
			return other != null && (other == this || (this.LPLCDELGJDI == other.LPLCDELGJDI && this.aACPHJGMNDF_.Equals(other.aACPHJGMNDF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007600 RID: 30208 RVA: 0x00139174 File Offset: 0x00137374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LPLCDELGJDI)
			{
				num ^= this.LPLCDELGJDI.GetHashCode();
			}
			num ^= this.aACPHJGMNDF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x001391C1 File Offset: 0x001373C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x001391C9 File Offset: 0x001373C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x001391D4 File Offset: 0x001373D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LPLCDELGJDI)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.LPLCDELGJDI);
			}
			this.aACPHJGMNDF_.WriteTo(ref output, LogisticsGameCsReq._repeated_aACPHJGMNDF_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x00139224 File Offset: 0x00137424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LPLCDELGJDI)
			{
				num += 2;
			}
			num += this.aACPHJGMNDF_.CalculateSize(LogisticsGameCsReq._repeated_aACPHJGMNDF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x0013926C File Offset: 0x0013746C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogisticsGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LPLCDELGJDI)
			{
				this.LPLCDELGJDI = other.LPLCDELGJDI;
			}
			this.aACPHJGMNDF_.Add(other.aACPHJGMNDF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x001392B9 File Offset: 0x001374B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x001392C4 File Offset: 0x001374C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.aACPHJGMNDF_.AddEntriesFrom(ref input, LogisticsGameCsReq._repeated_aACPHJGMNDF_codec);
					}
				}
				else
				{
					this.LPLCDELGJDI = input.ReadBool();
				}
			}
		}

		// Token: 0x04002D53 RID: 11603
		private static readonly MessageParser<LogisticsGameCsReq> _parser = new MessageParser<LogisticsGameCsReq>(() => new LogisticsGameCsReq());

		// Token: 0x04002D54 RID: 11604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D55 RID: 11605
		public const int LPLCDELGJDIFieldNumber = 1;

		// Token: 0x04002D56 RID: 11606
		private bool lPLCDELGJDI_;

		// Token: 0x04002D57 RID: 11607
		public const int AACPHJGMNDFFieldNumber = 9;

		// Token: 0x04002D58 RID: 11608
		private static readonly FieldCodec<HGGCNNJOEPH> _repeated_aACPHJGMNDF_codec = FieldCodec.ForMessage<HGGCNNJOEPH>(74U, HGGCNNJOEPH.Parser);

		// Token: 0x04002D59 RID: 11609
		private readonly RepeatedField<HGGCNNJOEPH> aACPHJGMNDF_ = new RepeatedField<HGGCNNJOEPH>();
	}
}

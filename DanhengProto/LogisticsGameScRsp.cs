using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A67 RID: 2663
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LogisticsGameScRsp : IMessage<LogisticsGameScRsp>, IMessage, IEquatable<LogisticsGameScRsp>, IDeepCloneable<LogisticsGameScRsp>, IBufferMessage
	{
		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x0600760B RID: 30219 RVA: 0x001393FB File Offset: 0x001375FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogisticsGameScRsp> Parser
		{
			get
			{
				return LogisticsGameScRsp._parser;
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x0600760C RID: 30220 RVA: 0x00139402 File Offset: 0x00137602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LogisticsGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x0600760D RID: 30221 RVA: 0x00139414 File Offset: 0x00137614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogisticsGameScRsp.Descriptor;
			}
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x0013941B File Offset: 0x0013761B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsGameScRsp()
		{
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00139430 File Offset: 0x00137630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsGameScRsp(LogisticsGameScRsp other) : this()
		{
			this.eventId_ = other.eventId_;
			this.retcode_ = other.retcode_;
			this.pDBOKHNHPNA_ = other.pDBOKHNHPNA_.Clone();
			this.lPLCDELGJDI_ = other.lPLCDELGJDI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00139489 File Offset: 0x00137689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsGameScRsp Clone()
		{
			return new LogisticsGameScRsp(this);
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06007611 RID: 30225 RVA: 0x00139491 File Offset: 0x00137691
		// (set) Token: 0x06007612 RID: 30226 RVA: 0x00139499 File Offset: 0x00137699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06007613 RID: 30227 RVA: 0x001394A2 File Offset: 0x001376A2
		// (set) Token: 0x06007614 RID: 30228 RVA: 0x001394AA File Offset: 0x001376AA
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

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06007615 RID: 30229 RVA: 0x001394B3 File Offset: 0x001376B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogisticsScore> PDBOKHNHPNA
		{
			get
			{
				return this.pDBOKHNHPNA_;
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06007616 RID: 30230 RVA: 0x001394BB File Offset: 0x001376BB
		// (set) Token: 0x06007617 RID: 30231 RVA: 0x001394C3 File Offset: 0x001376C3
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

		// Token: 0x06007618 RID: 30232 RVA: 0x001394CC File Offset: 0x001376CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogisticsGameScRsp);
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x001394DC File Offset: 0x001376DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogisticsGameScRsp other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && this.Retcode == other.Retcode && this.pDBOKHNHPNA_.Equals(other.pDBOKHNHPNA_) && this.LPLCDELGJDI == other.LPLCDELGJDI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x0013954C File Offset: 0x0013774C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.pDBOKHNHPNA_.GetHashCode();
			if (this.LPLCDELGJDI)
			{
				num ^= this.LPLCDELGJDI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x001395CB File Offset: 0x001377CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x001395D3 File Offset: 0x001377D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x001395DC File Offset: 0x001377DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EventId);
			}
			this.pDBOKHNHPNA_.WriteTo(ref output, LogisticsGameScRsp._repeated_pDBOKHNHPNA_codec);
			if (this.LPLCDELGJDI)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.LPLCDELGJDI);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00139664 File Offset: 0x00137864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.pDBOKHNHPNA_.CalculateSize(LogisticsGameScRsp._repeated_pDBOKHNHPNA_codec);
			if (this.LPLCDELGJDI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x001396DC File Offset: 0x001378DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogisticsGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.pDBOKHNHPNA_.Add(other.pDBOKHNHPNA_);
			if (other.LPLCDELGJDI)
			{
				this.LPLCDELGJDI = other.LPLCDELGJDI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00139751 File Offset: 0x00137951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x0013975C File Offset: 0x0013795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.pDBOKHNHPNA_.AddEntriesFrom(ref input, LogisticsGameScRsp._repeated_pDBOKHNHPNA_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.LPLCDELGJDI = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D5B RID: 11611
		private static readonly MessageParser<LogisticsGameScRsp> _parser = new MessageParser<LogisticsGameScRsp>(() => new LogisticsGameScRsp());

		// Token: 0x04002D5C RID: 11612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D5D RID: 11613
		public const int EventIdFieldNumber = 1;

		// Token: 0x04002D5E RID: 11614
		private uint eventId_;

		// Token: 0x04002D5F RID: 11615
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04002D60 RID: 11616
		private uint retcode_;

		// Token: 0x04002D61 RID: 11617
		public const int PDBOKHNHPNAFieldNumber = 4;

		// Token: 0x04002D62 RID: 11618
		private static readonly FieldCodec<LogisticsScore> _repeated_pDBOKHNHPNA_codec = FieldCodec.ForMessage<LogisticsScore>(34U, LogisticsScore.Parser);

		// Token: 0x04002D63 RID: 11619
		private readonly RepeatedField<LogisticsScore> pDBOKHNHPNA_ = new RepeatedField<LogisticsScore>();

		// Token: 0x04002D64 RID: 11620
		public const int LPLCDELGJDIFieldNumber = 11;

		// Token: 0x04002D65 RID: 11621
		private bool lPLCDELGJDI_;
	}
}

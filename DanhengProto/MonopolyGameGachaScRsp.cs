using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B35 RID: 2869
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGameGachaScRsp : IMessage<MonopolyGameGachaScRsp>, IMessage, IEquatable<MonopolyGameGachaScRsp>, IDeepCloneable<MonopolyGameGachaScRsp>, IBufferMessage
	{
		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x06007EFC RID: 32508 RVA: 0x0014F994 File Offset: 0x0014DB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGameGachaScRsp> Parser
		{
			get
			{
				return MonopolyGameGachaScRsp._parser;
			}
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x06007EFD RID: 32509 RVA: 0x0014F99B File Offset: 0x0014DB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGameGachaScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x06007EFE RID: 32510 RVA: 0x0014F9AD File Offset: 0x0014DBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGameGachaScRsp.Descriptor;
			}
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x0014F9B4 File Offset: 0x0014DBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameGachaScRsp()
		{
		}

		// Token: 0x06007F00 RID: 32512 RVA: 0x0014F9C7 File Offset: 0x0014DBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameGachaScRsp(MonopolyGameGachaScRsp other) : this()
		{
			this.resultList_ = other.resultList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x0014F9FD File Offset: 0x0014DBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameGachaScRsp Clone()
		{
			return new MonopolyGameGachaScRsp(this);
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x06007F02 RID: 32514 RVA: 0x0014FA05 File Offset: 0x0014DC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ResultList
		{
			get
			{
				return this.resultList_;
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x06007F03 RID: 32515 RVA: 0x0014FA0D File Offset: 0x0014DC0D
		// (set) Token: 0x06007F04 RID: 32516 RVA: 0x0014FA15 File Offset: 0x0014DC15
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

		// Token: 0x06007F05 RID: 32517 RVA: 0x0014FA1E File Offset: 0x0014DC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGameGachaScRsp);
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0014FA2C File Offset: 0x0014DC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGameGachaScRsp other)
		{
			return other != null && (other == this || (this.resultList_.Equals(other.resultList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x0014FA7C File Offset: 0x0014DC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.resultList_.GetHashCode();
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

		// Token: 0x06007F08 RID: 32520 RVA: 0x0014FAC9 File Offset: 0x0014DCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F09 RID: 32521 RVA: 0x0014FAD1 File Offset: 0x0014DCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x0014FADC File Offset: 0x0014DCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.resultList_.WriteTo(ref output, MonopolyGameGachaScRsp._repeated_resultList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F0B RID: 32523 RVA: 0x0014FB2C File Offset: 0x0014DD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.resultList_.CalculateSize(MonopolyGameGachaScRsp._repeated_resultList_codec);
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

		// Token: 0x06007F0C RID: 32524 RVA: 0x0014FB80 File Offset: 0x0014DD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGameGachaScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.resultList_.Add(other.resultList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F0D RID: 32525 RVA: 0x0014FBCD File Offset: 0x0014DDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x0014FBD8 File Offset: 0x0014DDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.resultList_.AddEntriesFrom(ref input, MonopolyGameGachaScRsp._repeated_resultList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040030A9 RID: 12457
		private static readonly MessageParser<MonopolyGameGachaScRsp> _parser = new MessageParser<MonopolyGameGachaScRsp>(() => new MonopolyGameGachaScRsp());

		// Token: 0x040030AA RID: 12458
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030AB RID: 12459
		public const int ResultListFieldNumber = 12;

		// Token: 0x040030AC RID: 12460
		private static readonly FieldCodec<uint> _repeated_resultList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x040030AD RID: 12461
		private readonly RepeatedField<uint> resultList_ = new RepeatedField<uint>();

		// Token: 0x040030AE RID: 12462
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040030AF RID: 12463
		private uint retcode_;
	}
}

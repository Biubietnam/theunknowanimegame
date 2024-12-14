using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B21 RID: 2849
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyConfirmRandomScRsp : IMessage<MonopolyConfirmRandomScRsp>, IMessage, IEquatable<MonopolyConfirmRandomScRsp>, IDeepCloneable<MonopolyConfirmRandomScRsp>, IBufferMessage
	{
		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x06007E17 RID: 32279 RVA: 0x0014D693 File Offset: 0x0014B893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyConfirmRandomScRsp> Parser
		{
			get
			{
				return MonopolyConfirmRandomScRsp._parser;
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x06007E18 RID: 32280 RVA: 0x0014D69A File Offset: 0x0014B89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyConfirmRandomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x06007E19 RID: 32281 RVA: 0x0014D6AC File Offset: 0x0014B8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyConfirmRandomScRsp.Descriptor;
			}
		}

		// Token: 0x06007E1A RID: 32282 RVA: 0x0014D6B3 File Offset: 0x0014B8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConfirmRandomScRsp()
		{
		}

		// Token: 0x06007E1B RID: 32283 RVA: 0x0014D6BC File Offset: 0x0014B8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConfirmRandomScRsp(MonopolyConfirmRandomScRsp other) : this()
		{
			this.eventId_ = other.eventId_;
			this.kLNPKPIMKHJ_ = ((other.kLNPKPIMKHJ_ != null) ? other.kLNPKPIMKHJ_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E1C RID: 32284 RVA: 0x0014D714 File Offset: 0x0014B914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConfirmRandomScRsp Clone()
		{
			return new MonopolyConfirmRandomScRsp(this);
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x06007E1D RID: 32285 RVA: 0x0014D71C File Offset: 0x0014B91C
		// (set) Token: 0x06007E1E RID: 32286 RVA: 0x0014D724 File Offset: 0x0014B924
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

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x06007E1F RID: 32287 RVA: 0x0014D72D File Offset: 0x0014B92D
		// (set) Token: 0x06007E20 RID: 32288 RVA: 0x0014D735 File Offset: 0x0014B935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFOGHDHIDNH KLNPKPIMKHJ
		{
			get
			{
				return this.kLNPKPIMKHJ_;
			}
			set
			{
				this.kLNPKPIMKHJ_ = value;
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x06007E21 RID: 32289 RVA: 0x0014D73E File Offset: 0x0014B93E
		// (set) Token: 0x06007E22 RID: 32290 RVA: 0x0014D746 File Offset: 0x0014B946
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

		// Token: 0x06007E23 RID: 32291 RVA: 0x0014D74F File Offset: 0x0014B94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyConfirmRandomScRsp);
		}

		// Token: 0x06007E24 RID: 32292 RVA: 0x0014D760 File Offset: 0x0014B960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyConfirmRandomScRsp other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this.KLNPKPIMKHJ, other.KLNPKPIMKHJ) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E25 RID: 32293 RVA: 0x0014D7C0 File Offset: 0x0014B9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				num ^= this.KLNPKPIMKHJ.GetHashCode();
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

		// Token: 0x06007E26 RID: 32294 RVA: 0x0014D82E File Offset: 0x0014BA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x0014D836 File Offset: 0x0014BA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E28 RID: 32296 RVA: 0x0014D840 File Offset: 0x0014BA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EventId);
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.KLNPKPIMKHJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x0014D8B8 File Offset: 0x0014BAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KLNPKPIMKHJ);
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

		// Token: 0x06007E2A RID: 32298 RVA: 0x0014D928 File Offset: 0x0014BB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyConfirmRandomScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.kLNPKPIMKHJ_ != null)
			{
				if (this.kLNPKPIMKHJ_ == null)
				{
					this.KLNPKPIMKHJ = new NFOGHDHIDNH();
				}
				this.KLNPKPIMKHJ.MergeFrom(other.KLNPKPIMKHJ);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E2B RID: 32299 RVA: 0x0014D9A4 File Offset: 0x0014BBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x0014D9B0 File Offset: 0x0014BBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 104U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.kLNPKPIMKHJ_ == null)
							{
								this.KLNPKPIMKHJ = new NFOGHDHIDNH();
							}
							input.ReadMessage(this.KLNPKPIMKHJ);
						}
					}
					else
					{
						this.EventId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400305E RID: 12382
		private static readonly MessageParser<MonopolyConfirmRandomScRsp> _parser = new MessageParser<MonopolyConfirmRandomScRsp>(() => new MonopolyConfirmRandomScRsp());

		// Token: 0x0400305F RID: 12383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003060 RID: 12384
		public const int EventIdFieldNumber = 13;

		// Token: 0x04003061 RID: 12385
		private uint eventId_;

		// Token: 0x04003062 RID: 12386
		public const int KLNPKPIMKHJFieldNumber = 15;

		// Token: 0x04003063 RID: 12387
		private NFOGHDHIDNH kLNPKPIMKHJ_;

		// Token: 0x04003064 RID: 12388
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04003065 RID: 12389
		private uint retcode_;
	}
}

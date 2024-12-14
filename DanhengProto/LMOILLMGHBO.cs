using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A25 RID: 2597
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LMOILLMGHBO : IMessage<LMOILLMGHBO>, IMessage, IEquatable<LMOILLMGHBO>, IDeepCloneable<LMOILLMGHBO>, IBufferMessage
	{
		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06007366 RID: 29542 RVA: 0x0013321C File Offset: 0x0013141C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LMOILLMGHBO> Parser
		{
			get
			{
				return LMOILLMGHBO._parser;
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06007367 RID: 29543 RVA: 0x00133223 File Offset: 0x00131423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LMOILLMGHBOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06007368 RID: 29544 RVA: 0x00133235 File Offset: 0x00131435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LMOILLMGHBO.Descriptor;
			}
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x0013323C File Offset: 0x0013143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMOILLMGHBO()
		{
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x00133244 File Offset: 0x00131444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMOILLMGHBO(LMOILLMGHBO other) : this()
		{
			this.kOPOGFMPPHJ_ = other.kOPOGFMPPHJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x00133269 File Offset: 0x00131469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMOILLMGHBO Clone()
		{
			return new LMOILLMGHBO(this);
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x0600736C RID: 29548 RVA: 0x00133271 File Offset: 0x00131471
		// (set) Token: 0x0600736D RID: 29549 RVA: 0x00133279 File Offset: 0x00131479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KOPOGFMPPHJ
		{
			get
			{
				return this.kOPOGFMPPHJ_;
			}
			set
			{
				this.kOPOGFMPPHJ_ = value;
			}
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x00133282 File Offset: 0x00131482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LMOILLMGHBO);
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x00133290 File Offset: 0x00131490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LMOILLMGHBO other)
		{
			return other != null && (other == this || (this.KOPOGFMPPHJ == other.KOPOGFMPPHJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x001332C0 File Offset: 0x001314C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KOPOGFMPPHJ != 0U)
			{
				num ^= this.KOPOGFMPPHJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x001332FF File Offset: 0x001314FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x00133307 File Offset: 0x00131507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x00133310 File Offset: 0x00131510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KOPOGFMPPHJ != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.KOPOGFMPPHJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x00133344 File Offset: 0x00131544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KOPOGFMPPHJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KOPOGFMPPHJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x00133382 File Offset: 0x00131582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LMOILLMGHBO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KOPOGFMPPHJ != 0U)
			{
				this.KOPOGFMPPHJ = other.KOPOGFMPPHJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x001333B3 File Offset: 0x001315B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x001333BC File Offset: 0x001315BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.KOPOGFMPPHJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002C65 RID: 11365
		private static readonly MessageParser<LMOILLMGHBO> _parser = new MessageParser<LMOILLMGHBO>(() => new LMOILLMGHBO());

		// Token: 0x04002C66 RID: 11366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C67 RID: 11367
		public const int KOPOGFMPPHJFieldNumber = 9;

		// Token: 0x04002C68 RID: 11368
		private uint kOPOGFMPPHJ_;
	}
}

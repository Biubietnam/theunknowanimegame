using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C3D RID: 3133
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NPEHHMFPLCA : IMessage<NPEHHMFPLCA>, IMessage, IEquatable<NPEHHMFPLCA>, IDeepCloneable<NPEHHMFPLCA>, IBufferMessage
	{
		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x06008AEA RID: 35562 RVA: 0x0016EF9F File Offset: 0x0016D19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NPEHHMFPLCA> Parser
		{
			get
			{
				return NPEHHMFPLCA._parser;
			}
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x06008AEB RID: 35563 RVA: 0x0016EFA6 File Offset: 0x0016D1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NPEHHMFPLCAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x06008AEC RID: 35564 RVA: 0x0016EFB8 File Offset: 0x0016D1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NPEHHMFPLCA.Descriptor;
			}
		}

		// Token: 0x06008AED RID: 35565 RVA: 0x0016EFBF File Offset: 0x0016D1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPEHHMFPLCA()
		{
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x0016EFE0 File Offset: 0x0016D1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPEHHMFPLCA(NPEHHMFPLCA other) : this()
		{
			this.aeonId_ = other.aeonId_;
			this.pNGGIPHOMLH_ = other.pNGGIPHOMLH_.Clone();
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.kGDHEAICOJB_ = other.kGDHEAICOJB_.Clone();
			this.eHMEAGKBIID_ = other.eHMEAGKBIID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x0016F056 File Offset: 0x0016D256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPEHHMFPLCA Clone()
		{
			return new NPEHHMFPLCA(this);
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x06008AF0 RID: 35568 RVA: 0x0016F05E File Offset: 0x0016D25E
		// (set) Token: 0x06008AF1 RID: 35569 RVA: 0x0016F066 File Offset: 0x0016D266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x06008AF2 RID: 35570 RVA: 0x0016F06F File Offset: 0x0016D26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PNGGIPHOMLH
		{
			get
			{
				return this.pNGGIPHOMLH_;
			}
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x06008AF3 RID: 35571 RVA: 0x0016F077 File Offset: 0x0016D277
		// (set) Token: 0x06008AF4 RID: 35572 RVA: 0x0016F07F File Offset: 0x0016D27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x06008AF5 RID: 35573 RVA: 0x0016F088 File Offset: 0x0016D288
		// (set) Token: 0x06008AF6 RID: 35574 RVA: 0x0016F090 File Offset: 0x0016D290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x06008AF7 RID: 35575 RVA: 0x0016F099 File Offset: 0x0016D299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KGDHEAICOJB
		{
			get
			{
				return this.kGDHEAICOJB_;
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x06008AF8 RID: 35576 RVA: 0x0016F0A1 File Offset: 0x0016D2A1
		// (set) Token: 0x06008AF9 RID: 35577 RVA: 0x0016F0A9 File Offset: 0x0016D2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EHMEAGKBIID
		{
			get
			{
				return this.eHMEAGKBIID_;
			}
			set
			{
				this.eHMEAGKBIID_ = value;
			}
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x0016F0B2 File Offset: 0x0016D2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPEHHMFPLCA);
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x0016F0C0 File Offset: 0x0016D2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NPEHHMFPLCA other)
		{
			return other != null && (other == this || (this.AeonId == other.AeonId && this.pNGGIPHOMLH_.Equals(other.pNGGIPHOMLH_) && this.Level == other.Level && this.Exp == other.Exp && this.kGDHEAICOJB_.Equals(other.kGDHEAICOJB_) && this.EHMEAGKBIID == other.EHMEAGKBIID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AFC RID: 35580 RVA: 0x0016F154 File Offset: 0x0016D354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			num ^= this.pNGGIPHOMLH_.GetHashCode();
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.kGDHEAICOJB_.GetHashCode();
			if (this.EHMEAGKBIID != 0U)
			{
				num ^= this.EHMEAGKBIID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AFD RID: 35581 RVA: 0x0016F1FA File Offset: 0x0016D3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x0016F202 File Offset: 0x0016D402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AFF RID: 35583 RVA: 0x0016F20C File Offset: 0x0016D40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Exp);
			}
			this.kGDHEAICOJB_.WriteTo(ref output, NPEHHMFPLCA._repeated_kGDHEAICOJB_codec);
			if (this.Level != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Level);
			}
			this.pNGGIPHOMLH_.WriteTo(ref output, NPEHHMFPLCA._repeated_pNGGIPHOMLH_codec);
			if (this.EHMEAGKBIID != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EHMEAGKBIID);
			}
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B00 RID: 35584 RVA: 0x0016F2C0 File Offset: 0x0016D4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			num += this.pNGGIPHOMLH_.CalculateSize(NPEHHMFPLCA._repeated_pNGGIPHOMLH_codec);
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			num += this.kGDHEAICOJB_.CalculateSize(NPEHHMFPLCA._repeated_kGDHEAICOJB_codec);
			if (this.EHMEAGKBIID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHMEAGKBIID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B01 RID: 35585 RVA: 0x0016F36C File Offset: 0x0016D56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NPEHHMFPLCA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			this.pNGGIPHOMLH_.Add(other.pNGGIPHOMLH_);
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			this.kGDHEAICOJB_.Add(other.kGDHEAICOJB_);
			if (other.EHMEAGKBIID != 0U)
			{
				this.EHMEAGKBIID = other.EHMEAGKBIID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B02 RID: 35586 RVA: 0x0016F406 File Offset: 0x0016D606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x0016F410 File Offset: 0x0016D610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.Exp = input.ReadUInt32();
							continue;
						}
						if (num != 24U)
						{
							goto IL_41;
						}
					}
					else if (num != 26U)
					{
						if (num != 32U)
						{
							goto IL_41;
						}
						this.Level = input.ReadUInt32();
						continue;
					}
					this.kGDHEAICOJB_.AddEntriesFrom(ref input, NPEHHMFPLCA._repeated_kGDHEAICOJB_codec);
					continue;
				}
				if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.pNGGIPHOMLH_.AddEntriesFrom(ref input, NPEHHMFPLCA._repeated_pNGGIPHOMLH_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EHMEAGKBIID = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.AeonId = input.ReadUInt32();
						continue;
					}
				}
				IL_41:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400354C RID: 13644
		private static readonly MessageParser<NPEHHMFPLCA> _parser = new MessageParser<NPEHHMFPLCA>(() => new NPEHHMFPLCA());

		// Token: 0x0400354D RID: 13645
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400354E RID: 13646
		public const int AeonIdFieldNumber = 14;

		// Token: 0x0400354F RID: 13647
		private uint aeonId_;

		// Token: 0x04003550 RID: 13648
		public const int PNGGIPHOMLHFieldNumber = 5;

		// Token: 0x04003551 RID: 13649
		private static readonly FieldCodec<uint> _repeated_pNGGIPHOMLH_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04003552 RID: 13650
		private readonly RepeatedField<uint> pNGGIPHOMLH_ = new RepeatedField<uint>();

		// Token: 0x04003553 RID: 13651
		public const int LevelFieldNumber = 4;

		// Token: 0x04003554 RID: 13652
		private uint level_;

		// Token: 0x04003555 RID: 13653
		public const int ExpFieldNumber = 1;

		// Token: 0x04003556 RID: 13654
		private uint exp_;

		// Token: 0x04003557 RID: 13655
		public const int KGDHEAICOJBFieldNumber = 3;

		// Token: 0x04003558 RID: 13656
		private static readonly FieldCodec<uint> _repeated_kGDHEAICOJB_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04003559 RID: 13657
		private readonly RepeatedField<uint> kGDHEAICOJB_ = new RepeatedField<uint>();

		// Token: 0x0400355A RID: 13658
		public const int EHMEAGKBIIDFieldNumber = 10;

		// Token: 0x0400355B RID: 13659
		private uint eHMEAGKBIID_;
	}
}

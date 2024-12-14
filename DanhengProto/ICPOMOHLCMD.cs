using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000913 RID: 2323
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ICPOMOHLCMD : IMessage<ICPOMOHLCMD>, IMessage, IEquatable<ICPOMOHLCMD>, IDeepCloneable<ICPOMOHLCMD>, IBufferMessage
	{
		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x060067A1 RID: 26529 RVA: 0x001150DD File Offset: 0x001132DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ICPOMOHLCMD> Parser
		{
			get
			{
				return ICPOMOHLCMD._parser;
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x001150E4 File Offset: 0x001132E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ICPOMOHLCMDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x060067A3 RID: 26531 RVA: 0x001150F6 File Offset: 0x001132F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICPOMOHLCMD.Descriptor;
			}
		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x001150FD File Offset: 0x001132FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICPOMOHLCMD()
		{
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x00115110 File Offset: 0x00113310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICPOMOHLCMD(ICPOMOHLCMD other) : this()
		{
			this.gONNIAFLAAO_ = ((other.gONNIAFLAAO_ != null) ? other.gONNIAFLAAO_.Clone() : null);
			this.nMPOMDLNJON_ = other.nMPOMDLNJON_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x00115161 File Offset: 0x00113361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICPOMOHLCMD Clone()
		{
			return new ICPOMOHLCMD(this);
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x060067A7 RID: 26535 RVA: 0x00115169 File Offset: 0x00113369
		// (set) Token: 0x060067A8 RID: 26536 RVA: 0x00115171 File Offset: 0x00113371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnitInfo GONNIAFLAAO
		{
			get
			{
				return this.gONNIAFLAAO_;
			}
			set
			{
				this.gONNIAFLAAO_ = value;
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x060067A9 RID: 26537 RVA: 0x0011517A File Offset: 0x0011337A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NMPOMDLNJON
		{
			get
			{
				return this.nMPOMDLNJON_;
			}
		}

		// Token: 0x060067AA RID: 26538 RVA: 0x00115182 File Offset: 0x00113382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICPOMOHLCMD);
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x00115190 File Offset: 0x00113390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICPOMOHLCMD other)
		{
			return other != null && (other == this || (object.Equals(this.GONNIAFLAAO, other.GONNIAFLAAO) && this.nMPOMDLNJON_.Equals(other.nMPOMDLNJON_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x001151E4 File Offset: 0x001133E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gONNIAFLAAO_ != null)
			{
				num ^= this.GONNIAFLAAO.GetHashCode();
			}
			num ^= this.nMPOMDLNJON_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x0011522E File Offset: 0x0011342E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x00115236 File Offset: 0x00113436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x00115240 File Offset: 0x00113440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gONNIAFLAAO_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GONNIAFLAAO);
			}
			this.nMPOMDLNJON_.WriteTo(ref output, ICPOMOHLCMD._repeated_nMPOMDLNJON_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x00115290 File Offset: 0x00113490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gONNIAFLAAO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GONNIAFLAAO);
			}
			num += this.nMPOMDLNJON_.CalculateSize(ICPOMOHLCMD._repeated_nMPOMDLNJON_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x001152E4 File Offset: 0x001134E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICPOMOHLCMD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gONNIAFLAAO_ != null)
			{
				if (this.gONNIAFLAAO_ == null)
				{
					this.GONNIAFLAAO = new RogueMagicGameUnitInfo();
				}
				this.GONNIAFLAAO.MergeFrom(other.GONNIAFLAAO);
			}
			this.nMPOMDLNJON_.Add(other.nMPOMDLNJON_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x00115349 File Offset: 0x00113549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x00115354 File Offset: 0x00113554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.nMPOMDLNJON_.AddEntriesFrom(ref input, ICPOMOHLCMD._repeated_nMPOMDLNJON_codec);
					}
				}
				else
				{
					if (this.gONNIAFLAAO_ == null)
					{
						this.GONNIAFLAAO = new RogueMagicGameUnitInfo();
					}
					input.ReadMessage(this.GONNIAFLAAO);
				}
			}
		}

		// Token: 0x040027D3 RID: 10195
		private static readonly MessageParser<ICPOMOHLCMD> _parser = new MessageParser<ICPOMOHLCMD>(() => new ICPOMOHLCMD());

		// Token: 0x040027D4 RID: 10196
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027D5 RID: 10197
		public const int GONNIAFLAAOFieldNumber = 2;

		// Token: 0x040027D6 RID: 10198
		private RogueMagicGameUnitInfo gONNIAFLAAO_;

		// Token: 0x040027D7 RID: 10199
		public const int NMPOMDLNJONFieldNumber = 7;

		// Token: 0x040027D8 RID: 10200
		private static readonly FieldCodec<uint> _repeated_nMPOMDLNJON_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x040027D9 RID: 10201
		private readonly RepeatedField<uint> nMPOMDLNJON_ = new RepeatedField<uint>();
	}
}

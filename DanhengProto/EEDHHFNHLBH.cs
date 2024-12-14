using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003F5 RID: 1013
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EEDHHFNHLBH : IMessage<EEDHHFNHLBH>, IMessage, IEquatable<EEDHHFNHLBH>, IDeepCloneable<EEDHHFNHLBH>, IBufferMessage
	{
		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x0007CBA4 File Offset: 0x0007ADA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EEDHHFNHLBH> Parser
		{
			get
			{
				return EEDHHFNHLBH._parser;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x0007CBAB File Offset: 0x0007ADAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EEDHHFNHLBHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x0007CBBD File Offset: 0x0007ADBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EEDHHFNHLBH.Descriptor;
			}
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0007CBC4 File Offset: 0x0007ADC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EEDHHFNHLBH()
		{
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x0007CBD7 File Offset: 0x0007ADD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EEDHHFNHLBH(EEDHHFNHLBH other) : this()
		{
			this.selectHintId_ = other.selectHintId_;
			this.cLBNHOGKFKH_ = other.cLBNHOGKFKH_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x0007CC0D File Offset: 0x0007AE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EEDHHFNHLBH Clone()
		{
			return new EEDHHFNHLBH(this);
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x0007CC15 File Offset: 0x0007AE15
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x0007CC1D File Offset: 0x0007AE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x0007CC26 File Offset: 0x0007AE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> CLBNHOGKFKH
		{
			get
			{
				return this.cLBNHOGKFKH_;
			}
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x0007CC2E File Offset: 0x0007AE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EEDHHFNHLBH);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x0007CC3C File Offset: 0x0007AE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EEDHHFNHLBH other)
		{
			return other != null && (other == this || (this.SelectHintId == other.SelectHintId && this.cLBNHOGKFKH_.Equals(other.cLBNHOGKFKH_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x0007CC8C File Offset: 0x0007AE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			num ^= this.cLBNHOGKFKH_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x0007CCD9 File Offset: 0x0007AED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0007CCE1 File Offset: 0x0007AEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x0007CCEC File Offset: 0x0007AEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cLBNHOGKFKH_.WriteTo(ref output, EEDHHFNHLBH._repeated_cLBNHOGKFKH_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x0007CD3C File Offset: 0x0007AF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			num += this.cLBNHOGKFKH_.CalculateSize(EEDHHFNHLBH._repeated_cLBNHOGKFKH_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x0007CD90 File Offset: 0x0007AF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EEDHHFNHLBH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this.cLBNHOGKFKH_.Add(other.cLBNHOGKFKH_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x0007CDDD File Offset: 0x0007AFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x0007CDE8 File Offset: 0x0007AFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectHintId = input.ReadUInt32();
					}
				}
				else
				{
					this.cLBNHOGKFKH_.AddEntriesFrom(ref input, EEDHHFNHLBH._repeated_cLBNHOGKFKH_codec);
				}
			}
		}

		// Token: 0x04001224 RID: 4644
		private static readonly MessageParser<EEDHHFNHLBH> _parser = new MessageParser<EEDHHFNHLBH>(() => new EEDHHFNHLBH());

		// Token: 0x04001225 RID: 4645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001226 RID: 4646
		public const int SelectHintIdFieldNumber = 6;

		// Token: 0x04001227 RID: 4647
		private uint selectHintId_;

		// Token: 0x04001228 RID: 4648
		public const int CLBNHOGKFKHFieldNumber = 1;

		// Token: 0x04001229 RID: 4649
		private static readonly FieldCodec<uint> _repeated_cLBNHOGKFKH_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400122A RID: 4650
		private readonly RepeatedField<uint> cLBNHOGKFKH_ = new RepeatedField<uint>();
	}
}

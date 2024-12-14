using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C7D RID: 3197
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PAPEPLFDCON : IMessage<PAPEPLFDCON>, IMessage, IEquatable<PAPEPLFDCON>, IDeepCloneable<PAPEPLFDCON>, IBufferMessage
	{
		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x06008E15 RID: 36373 RVA: 0x00177680 File Offset: 0x00175880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PAPEPLFDCON> Parser
		{
			get
			{
				return PAPEPLFDCON._parser;
			}
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x00177687 File Offset: 0x00175887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PAPEPLFDCONReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x06008E17 RID: 36375 RVA: 0x00177699 File Offset: 0x00175899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PAPEPLFDCON.Descriptor;
			}
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x001776A0 File Offset: 0x001758A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAPEPLFDCON()
		{
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x001776BE File Offset: 0x001758BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAPEPLFDCON(PAPEPLFDCON other) : this()
		{
			this.jBIKPLADENB_ = other.jBIKPLADENB_.Clone();
			this.lEBIECBEONE_ = other.lEBIECBEONE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E1A RID: 36378 RVA: 0x001776F9 File Offset: 0x001758F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAPEPLFDCON Clone()
		{
			return new PAPEPLFDCON(this);
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x00177701 File Offset: 0x00175901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JBIKPLADENB
		{
			get
			{
				return this.jBIKPLADENB_;
			}
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x06008E1C RID: 36380 RVA: 0x00177709 File Offset: 0x00175909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LEBIECBEONE
		{
			get
			{
				return this.lEBIECBEONE_;
			}
		}

		// Token: 0x06008E1D RID: 36381 RVA: 0x00177711 File Offset: 0x00175911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PAPEPLFDCON);
		}

		// Token: 0x06008E1E RID: 36382 RVA: 0x00177720 File Offset: 0x00175920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PAPEPLFDCON other)
		{
			return other != null && (other == this || (this.jBIKPLADENB_.Equals(other.jBIKPLADENB_) && this.lEBIECBEONE_.Equals(other.lEBIECBEONE_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E1F RID: 36383 RVA: 0x00177774 File Offset: 0x00175974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jBIKPLADENB_.GetHashCode();
			num ^= this.lEBIECBEONE_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E20 RID: 36384 RVA: 0x001777B6 File Offset: 0x001759B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x001777BE File Offset: 0x001759BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x001777C7 File Offset: 0x001759C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jBIKPLADENB_.WriteTo(ref output, PAPEPLFDCON._repeated_jBIKPLADENB_codec);
			this.lEBIECBEONE_.WriteTo(ref output, PAPEPLFDCON._repeated_lEBIECBEONE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x00177800 File Offset: 0x00175A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jBIKPLADENB_.CalculateSize(PAPEPLFDCON._repeated_jBIKPLADENB_codec);
			num += this.lEBIECBEONE_.CalculateSize(PAPEPLFDCON._repeated_lEBIECBEONE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E24 RID: 36388 RVA: 0x0017784C File Offset: 0x00175A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PAPEPLFDCON other)
		{
			if (other == null)
			{
				return;
			}
			this.jBIKPLADENB_.Add(other.jBIKPLADENB_);
			this.lEBIECBEONE_.Add(other.lEBIECBEONE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E25 RID: 36389 RVA: 0x0017788B File Offset: 0x00175A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E26 RID: 36390 RVA: 0x00177894 File Offset: 0x00175A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.jBIKPLADENB_.AddEntriesFrom(ref input, PAPEPLFDCON._repeated_jBIKPLADENB_codec);
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.lEBIECBEONE_.AddEntriesFrom(ref input, PAPEPLFDCON._repeated_lEBIECBEONE_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003689 RID: 13961
		private static readonly MessageParser<PAPEPLFDCON> _parser = new MessageParser<PAPEPLFDCON>(() => new PAPEPLFDCON());

		// Token: 0x0400368A RID: 13962
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400368B RID: 13963
		public const int JBIKPLADENBFieldNumber = 10;

		// Token: 0x0400368C RID: 13964
		private static readonly FieldCodec<uint> _repeated_jBIKPLADENB_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x0400368D RID: 13965
		private readonly RepeatedField<uint> jBIKPLADENB_ = new RepeatedField<uint>();

		// Token: 0x0400368E RID: 13966
		public const int LEBIECBEONEFieldNumber = 11;

		// Token: 0x0400368F RID: 13967
		private static readonly FieldCodec<uint> _repeated_lEBIECBEONE_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04003690 RID: 13968
		private readonly RepeatedField<uint> lEBIECBEONE_ = new RepeatedField<uint>();
	}
}

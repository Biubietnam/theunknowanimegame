using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000369 RID: 873
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DEAJGOPAMNB : IMessage<DEAJGOPAMNB>, IMessage, IEquatable<DEAJGOPAMNB>, IDeepCloneable<DEAJGOPAMNB>, IBufferMessage
	{
		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x0006CFC0 File Offset: 0x0006B1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DEAJGOPAMNB> Parser
		{
			get
			{
				return DEAJGOPAMNB._parser;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x0006CFC7 File Offset: 0x0006B1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DEAJGOPAMNBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x0006CFD9 File Offset: 0x0006B1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DEAJGOPAMNB.Descriptor;
			}
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x0006CFE0 File Offset: 0x0006B1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DEAJGOPAMNB()
		{
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0006CFFE File Offset: 0x0006B1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DEAJGOPAMNB(DEAJGOPAMNB other) : this()
		{
			this.oGPPLEFOFLL_ = other.oGPPLEFOFLL_.Clone();
			this.jJOEPELABKL_ = other.jJOEPELABKL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0006D039 File Offset: 0x0006B239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DEAJGOPAMNB Clone()
		{
			return new DEAJGOPAMNB(this);
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x0006D041 File Offset: 0x0006B241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OGPPLEFOFLL
		{
			get
			{
				return this.oGPPLEFOFLL_;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x0006D049 File Offset: 0x0006B249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JJOEPELABKL
		{
			get
			{
				return this.jJOEPELABKL_;
			}
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0006D051 File Offset: 0x0006B251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DEAJGOPAMNB);
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x0006D060 File Offset: 0x0006B260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DEAJGOPAMNB other)
		{
			return other != null && (other == this || (this.oGPPLEFOFLL_.Equals(other.oGPPLEFOFLL_) && this.jJOEPELABKL_.Equals(other.jJOEPELABKL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x0006D0B4 File Offset: 0x0006B2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.oGPPLEFOFLL_.GetHashCode();
			num ^= this.jJOEPELABKL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x0006D0F6 File Offset: 0x0006B2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x0006D0FE File Offset: 0x0006B2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x0006D107 File Offset: 0x0006B307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.oGPPLEFOFLL_.WriteTo(ref output, DEAJGOPAMNB._repeated_oGPPLEFOFLL_codec);
			this.jJOEPELABKL_.WriteTo(ref output, DEAJGOPAMNB._repeated_jJOEPELABKL_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x0006D140 File Offset: 0x0006B340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.oGPPLEFOFLL_.CalculateSize(DEAJGOPAMNB._repeated_oGPPLEFOFLL_codec);
			num += this.jJOEPELABKL_.CalculateSize(DEAJGOPAMNB._repeated_jJOEPELABKL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x0006D18C File Offset: 0x0006B38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DEAJGOPAMNB other)
		{
			if (other == null)
			{
				return;
			}
			this.oGPPLEFOFLL_.Add(other.oGPPLEFOFLL_);
			this.jJOEPELABKL_.Add(other.jJOEPELABKL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x0006D1CB File Offset: 0x0006B3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x0006D1D4 File Offset: 0x0006B3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.oGPPLEFOFLL_.AddEntriesFrom(ref input, DEAJGOPAMNB._repeated_oGPPLEFOFLL_codec);
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.jJOEPELABKL_.AddEntriesFrom(ref input, DEAJGOPAMNB._repeated_jJOEPELABKL_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000FB8 RID: 4024
		private static readonly MessageParser<DEAJGOPAMNB> _parser = new MessageParser<DEAJGOPAMNB>(() => new DEAJGOPAMNB());

		// Token: 0x04000FB9 RID: 4025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FBA RID: 4026
		public const int OGPPLEFOFLLFieldNumber = 7;

		// Token: 0x04000FBB RID: 4027
		private static readonly FieldCodec<uint> _repeated_oGPPLEFOFLL_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04000FBC RID: 4028
		private readonly RepeatedField<uint> oGPPLEFOFLL_ = new RepeatedField<uint>();

		// Token: 0x04000FBD RID: 4029
		public const int JJOEPELABKLFieldNumber = 14;

		// Token: 0x04000FBE RID: 4030
		private static readonly FieldCodec<uint> _repeated_jJOEPELABKL_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04000FBF RID: 4031
		private readonly RepeatedField<uint> jJOEPELABKL_ = new RepeatedField<uint>();
	}
}

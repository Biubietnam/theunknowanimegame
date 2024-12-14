using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000391 RID: 913
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DFFKMEPPCFE : IMessage<DFFKMEPPCFE>, IMessage, IEquatable<DFFKMEPPCFE>, IDeepCloneable<DFFKMEPPCFE>, IBufferMessage
	{
		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x00070A6F File Offset: 0x0006EC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DFFKMEPPCFE> Parser
		{
			get
			{
				return DFFKMEPPCFE._parser;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x00070A76 File Offset: 0x0006EC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DFFKMEPPCFEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x00070A88 File Offset: 0x0006EC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DFFKMEPPCFE.Descriptor;
			}
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00070A8F File Offset: 0x0006EC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFFKMEPPCFE()
		{
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00070AB8 File Offset: 0x0006ECB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFFKMEPPCFE(DFFKMEPPCFE other) : this()
		{
			this.eAAGGEHJEIE_ = other.eAAGGEHJEIE_;
			this.gLCOLBNICLD_ = other.gLCOLBNICLD_;
			this.oNGNEABOOLP_ = other.oNGNEABOOLP_.Clone();
			this.dGPEOODOJMA_ = other.dGPEOODOJMA_.Clone();
			this.shopId_ = other.shopId_;
			this.lGEMOGHNKJI_ = other.lGEMOGHNKJI_;
			this.iDLIBJIILNG_ = other.iDLIBJIILNG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00070B3F File Offset: 0x0006ED3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFFKMEPPCFE Clone()
		{
			return new DFFKMEPPCFE(this);
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x00070B47 File Offset: 0x0006ED47
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x00070B4F File Offset: 0x0006ED4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EAAGGEHJEIE
		{
			get
			{
				return this.eAAGGEHJEIE_;
			}
			set
			{
				this.eAAGGEHJEIE_ = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x00070B58 File Offset: 0x0006ED58
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x00070B60 File Offset: 0x0006ED60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GLCOLBNICLD
		{
			get
			{
				return this.gLCOLBNICLD_;
			}
			set
			{
				this.gLCOLBNICLD_ = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x00070B69 File Offset: 0x0006ED69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ONGNEABOOLP
		{
			get
			{
				return this.oNGNEABOOLP_;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x00070B71 File Offset: 0x0006ED71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DGPEOODOJMA
		{
			get
			{
				return this.dGPEOODOJMA_;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x00070B79 File Offset: 0x0006ED79
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x00070B81 File Offset: 0x0006ED81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x00070B8A File Offset: 0x0006ED8A
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x00070B92 File Offset: 0x0006ED92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LGEMOGHNKJI
		{
			get
			{
				return this.lGEMOGHNKJI_;
			}
			set
			{
				this.lGEMOGHNKJI_ = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x00070B9B File Offset: 0x0006ED9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IDLIBJIILNG
		{
			get
			{
				return this.iDLIBJIILNG_;
			}
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x00070BA3 File Offset: 0x0006EDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DFFKMEPPCFE);
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x00070BB4 File Offset: 0x0006EDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DFFKMEPPCFE other)
		{
			return other != null && (other == this || (this.EAAGGEHJEIE == other.EAAGGEHJEIE && this.GLCOLBNICLD == other.GLCOLBNICLD && this.oNGNEABOOLP_.Equals(other.oNGNEABOOLP_) && this.dGPEOODOJMA_.Equals(other.dGPEOODOJMA_) && this.ShopId == other.ShopId && this.LGEMOGHNKJI == other.LGEMOGHNKJI && this.iDLIBJIILNG_.Equals(other.iDLIBJIILNG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00070C5C File Offset: 0x0006EE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EAAGGEHJEIE != 0U)
			{
				num ^= this.EAAGGEHJEIE.GetHashCode();
			}
			if (this.GLCOLBNICLD != 0U)
			{
				num ^= this.GLCOLBNICLD.GetHashCode();
			}
			num ^= this.oNGNEABOOLP_.GetHashCode();
			num ^= this.dGPEOODOJMA_.GetHashCode();
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.LGEMOGHNKJI != 0U)
			{
				num ^= this.LGEMOGHNKJI.GetHashCode();
			}
			num ^= this.iDLIBJIILNG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00070D10 File Offset: 0x0006EF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00070D18 File Offset: 0x0006EF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00070D24 File Offset: 0x0006EF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ShopId);
			}
			if (this.LGEMOGHNKJI != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.LGEMOGHNKJI);
			}
			this.dGPEOODOJMA_.WriteTo(ref output, DFFKMEPPCFE._repeated_dGPEOODOJMA_codec);
			if (this.GLCOLBNICLD != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GLCOLBNICLD);
			}
			this.iDLIBJIILNG_.WriteTo(ref output, DFFKMEPPCFE._repeated_iDLIBJIILNG_codec);
			if (this.EAAGGEHJEIE != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EAAGGEHJEIE);
			}
			this.oNGNEABOOLP_.WriteTo(ref output, DFFKMEPPCFE._repeated_oNGNEABOOLP_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00070DE8 File Offset: 0x0006EFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EAAGGEHJEIE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EAAGGEHJEIE);
			}
			if (this.GLCOLBNICLD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GLCOLBNICLD);
			}
			num += this.oNGNEABOOLP_.CalculateSize(DFFKMEPPCFE._repeated_oNGNEABOOLP_codec);
			num += this.dGPEOODOJMA_.CalculateSize(DFFKMEPPCFE._repeated_dGPEOODOJMA_codec);
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
			}
			if (this.LGEMOGHNKJI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LGEMOGHNKJI);
			}
			num += this.iDLIBJIILNG_.CalculateSize(DFFKMEPPCFE._repeated_iDLIBJIILNG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00070EA8 File Offset: 0x0006F0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DFFKMEPPCFE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EAAGGEHJEIE != 0U)
			{
				this.EAAGGEHJEIE = other.EAAGGEHJEIE;
			}
			if (other.GLCOLBNICLD != 0U)
			{
				this.GLCOLBNICLD = other.GLCOLBNICLD;
			}
			this.oNGNEABOOLP_.Add(other.oNGNEABOOLP_);
			this.dGPEOODOJMA_.Add(other.dGPEOODOJMA_);
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			if (other.LGEMOGHNKJI != 0U)
			{
				this.LGEMOGHNKJI = other.LGEMOGHNKJI;
			}
			this.iDLIBJIILNG_.Add(other.iDLIBJIILNG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x00070F53 File Offset: 0x0006F153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00070F5C File Offset: 0x0006F15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ShopId = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.LGEMOGHNKJI = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U || num == 34U)
						{
							this.dGPEOODOJMA_.AddEntriesFrom(ref input, DFFKMEPPCFE._repeated_dGPEOODOJMA_codec);
							continue;
						}
						if (num == 40U)
						{
							this.GLCOLBNICLD = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.iDLIBJIILNG_.AddEntriesFrom(ref input, DFFKMEPPCFE._repeated_iDLIBJIILNG_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.EAAGGEHJEIE = input.ReadUInt32();
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.oNGNEABOOLP_.AddEntriesFrom(ref input, DFFKMEPPCFE._repeated_oNGNEABOOLP_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001052 RID: 4178
		private static readonly MessageParser<DFFKMEPPCFE> _parser = new MessageParser<DFFKMEPPCFE>(() => new DFFKMEPPCFE());

		// Token: 0x04001053 RID: 4179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001054 RID: 4180
		public const int EAAGGEHJEIEFieldNumber = 9;

		// Token: 0x04001055 RID: 4181
		private uint eAAGGEHJEIE_;

		// Token: 0x04001056 RID: 4182
		public const int GLCOLBNICLDFieldNumber = 5;

		// Token: 0x04001057 RID: 4183
		private uint gLCOLBNICLD_;

		// Token: 0x04001058 RID: 4184
		public const int ONGNEABOOLPFieldNumber = 14;

		// Token: 0x04001059 RID: 4185
		private static readonly FieldCodec<uint> _repeated_oNGNEABOOLP_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x0400105A RID: 4186
		private readonly RepeatedField<uint> oNGNEABOOLP_ = new RepeatedField<uint>();

		// Token: 0x0400105B RID: 4187
		public const int DGPEOODOJMAFieldNumber = 4;

		// Token: 0x0400105C RID: 4188
		private static readonly FieldCodec<uint> _repeated_dGPEOODOJMA_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400105D RID: 4189
		private readonly RepeatedField<uint> dGPEOODOJMA_ = new RepeatedField<uint>();

		// Token: 0x0400105E RID: 4190
		public const int ShopIdFieldNumber = 1;

		// Token: 0x0400105F RID: 4191
		private uint shopId_;

		// Token: 0x04001060 RID: 4192
		public const int LGEMOGHNKJIFieldNumber = 2;

		// Token: 0x04001061 RID: 4193
		private uint lGEMOGHNKJI_;

		// Token: 0x04001062 RID: 4194
		public const int IDLIBJIILNGFieldNumber = 6;

		// Token: 0x04001063 RID: 4195
		private static readonly FieldCodec<uint> _repeated_iDLIBJIILNG_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04001064 RID: 4196
		private readonly RepeatedField<uint> iDLIBJIILNG_ = new RepeatedField<uint>();
	}
}

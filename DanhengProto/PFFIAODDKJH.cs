using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C8B RID: 3211
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PFFIAODDKJH : IMessage<PFFIAODDKJH>, IMessage, IEquatable<PFFIAODDKJH>, IDeepCloneable<PFFIAODDKJH>, IBufferMessage
	{
		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x06008EC0 RID: 36544 RVA: 0x001794BC File Offset: 0x001776BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PFFIAODDKJH> Parser
		{
			get
			{
				return PFFIAODDKJH._parser;
			}
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x06008EC1 RID: 36545 RVA: 0x001794C3 File Offset: 0x001776C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PFFIAODDKJHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x06008EC2 RID: 36546 RVA: 0x001794D5 File Offset: 0x001776D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PFFIAODDKJH.Descriptor;
			}
		}

		// Token: 0x06008EC3 RID: 36547 RVA: 0x001794DC File Offset: 0x001776DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PFFIAODDKJH()
		{
		}

		// Token: 0x06008EC4 RID: 36548 RVA: 0x001794F0 File Offset: 0x001776F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PFFIAODDKJH(PFFIAODDKJH other) : this()
		{
			this.fOOAONCJCNO_ = other.fOOAONCJCNO_;
			this.pIHAPFCIAPO_ = other.pIHAPFCIAPO_.Clone();
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EC5 RID: 36549 RVA: 0x0017953D File Offset: 0x0017773D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PFFIAODDKJH Clone()
		{
			return new PFFIAODDKJH(this);
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x06008EC6 RID: 36550 RVA: 0x00179545 File Offset: 0x00177745
		// (set) Token: 0x06008EC7 RID: 36551 RVA: 0x0017954D File Offset: 0x0017774D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FOOAONCJCNO
		{
			get
			{
				return this.fOOAONCJCNO_;
			}
			set
			{
				this.fOOAONCJCNO_ = value;
			}
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x06008EC8 RID: 36552 RVA: 0x00179556 File Offset: 0x00177756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PIHAPFCIAPO
		{
			get
			{
				return this.pIHAPFCIAPO_;
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x06008EC9 RID: 36553 RVA: 0x0017955E File Offset: 0x0017775E
		// (set) Token: 0x06008ECA RID: 36554 RVA: 0x00179566 File Offset: 0x00177766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x0017956F File Offset: 0x0017776F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PFFIAODDKJH);
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x00179580 File Offset: 0x00177780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PFFIAODDKJH other)
		{
			return other != null && (other == this || (this.FOOAONCJCNO == other.FOOAONCJCNO && this.pIHAPFCIAPO_.Equals(other.pIHAPFCIAPO_) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x001795E0 File Offset: 0x001777E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FOOAONCJCNO != 0U)
			{
				num ^= this.FOOAONCJCNO.GetHashCode();
			}
			num ^= this.pIHAPFCIAPO_.GetHashCode();
			if (this.Type != 0U)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008ECE RID: 36558 RVA: 0x00179646 File Offset: 0x00177846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x0017964E File Offset: 0x0017784E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x00179658 File Offset: 0x00177858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Type);
			}
			this.pIHAPFCIAPO_.WriteTo(ref output, PFFIAODDKJH._repeated_pIHAPFCIAPO_codec);
			if (this.FOOAONCJCNO != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.FOOAONCJCNO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x001796C4 File Offset: 0x001778C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FOOAONCJCNO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FOOAONCJCNO);
			}
			num += this.pIHAPFCIAPO_.CalculateSize(PFFIAODDKJH._repeated_pIHAPFCIAPO_codec);
			if (this.Type != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x00179730 File Offset: 0x00177930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PFFIAODDKJH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FOOAONCJCNO != 0U)
			{
				this.FOOAONCJCNO = other.FOOAONCJCNO;
			}
			this.pIHAPFCIAPO_.Add(other.pIHAPFCIAPO_);
			if (other.Type != 0U)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x00179791 File Offset: 0x00177991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x0017979C File Offset: 0x0017799C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 8U)
					{
						this.Type = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						goto IL_3E;
					}
				}
				else
				{
					if (num == 90U)
					{
						goto IL_3E;
					}
					if (num == 112U)
					{
						this.FOOAONCJCNO = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3E:
				this.pIHAPFCIAPO_.AddEntriesFrom(ref input, PFFIAODDKJH._repeated_pIHAPFCIAPO_codec);
			}
		}

		// Token: 0x040036D4 RID: 14036
		private static readonly MessageParser<PFFIAODDKJH> _parser = new MessageParser<PFFIAODDKJH>(() => new PFFIAODDKJH());

		// Token: 0x040036D5 RID: 14037
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036D6 RID: 14038
		public const int FOOAONCJCNOFieldNumber = 14;

		// Token: 0x040036D7 RID: 14039
		private uint fOOAONCJCNO_;

		// Token: 0x040036D8 RID: 14040
		public const int PIHAPFCIAPOFieldNumber = 11;

		// Token: 0x040036D9 RID: 14041
		private static readonly FieldCodec<uint> _repeated_pIHAPFCIAPO_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x040036DA RID: 14042
		private readonly RepeatedField<uint> pIHAPFCIAPO_ = new RepeatedField<uint>();

		// Token: 0x040036DB RID: 14043
		public const int TypeFieldNumber = 1;

		// Token: 0x040036DC RID: 14044
		private uint type_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000505 RID: 1285
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FBGCMFJANMH : IMessage<FBGCMFJANMH>, IMessage, IEquatable<FBGCMFJANMH>, IDeepCloneable<FBGCMFJANMH>, IBufferMessage
	{
		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x0009E6F4 File Offset: 0x0009C8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FBGCMFJANMH> Parser
		{
			get
			{
				return FBGCMFJANMH._parser;
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x0009E6FB File Offset: 0x0009C8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FBGCMFJANMHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x0009E70D File Offset: 0x0009C90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FBGCMFJANMH.Descriptor;
			}
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x0009E714 File Offset: 0x0009C914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FBGCMFJANMH()
		{
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0009E727 File Offset: 0x0009C927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FBGCMFJANMH(FBGCMFJANMH other) : this()
		{
			this.bCBBBFHFOEI_ = other.bCBBBFHFOEI_.Clone();
			this.selectHintId_ = other.selectHintId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x0009E75D File Offset: 0x0009C95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FBGCMFJANMH Clone()
		{
			return new FBGCMFJANMH(this);
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x0009E765 File Offset: 0x0009C965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BCBBBFHFOEI
		{
			get
			{
				return this.bCBBBFHFOEI_;
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x0009E76D File Offset: 0x0009C96D
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x0009E775 File Offset: 0x0009C975
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

		// Token: 0x0600399E RID: 14750 RVA: 0x0009E77E File Offset: 0x0009C97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FBGCMFJANMH);
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x0009E78C File Offset: 0x0009C98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FBGCMFJANMH other)
		{
			return other != null && (other == this || (this.bCBBBFHFOEI_.Equals(other.bCBBBFHFOEI_) && this.SelectHintId == other.SelectHintId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x0009E7DC File Offset: 0x0009C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bCBBBFHFOEI_.GetHashCode();
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x0009E829 File Offset: 0x0009CA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0009E831 File Offset: 0x0009CA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0009E83C File Offset: 0x0009CA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SelectHintId);
			}
			this.bCBBBFHFOEI_.WriteTo(ref output, FBGCMFJANMH._repeated_bCBBBFHFOEI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0009E88C File Offset: 0x0009CA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bCBBBFHFOEI_.CalculateSize(FBGCMFJANMH._repeated_bCBBBFHFOEI_codec);
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x0009E8E0 File Offset: 0x0009CAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FBGCMFJANMH other)
		{
			if (other == null)
			{
				return;
			}
			this.bCBBBFHFOEI_.Add(other.bCBBBFHFOEI_);
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x0009E92D File Offset: 0x0009CB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x0009E938 File Offset: 0x0009CB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bCBBBFHFOEI_.AddEntriesFrom(ref input, FBGCMFJANMH._repeated_bCBBBFHFOEI_codec);
					}
				}
				else
				{
					this.SelectHintId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040016EF RID: 5871
		private static readonly MessageParser<FBGCMFJANMH> _parser = new MessageParser<FBGCMFJANMH>(() => new FBGCMFJANMH());

		// Token: 0x040016F0 RID: 5872
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016F1 RID: 5873
		public const int BCBBBFHFOEIFieldNumber = 14;

		// Token: 0x040016F2 RID: 5874
		private static readonly FieldCodec<uint> _repeated_bCBBBFHFOEI_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x040016F3 RID: 5875
		private readonly RepeatedField<uint> bCBBBFHFOEI_ = new RepeatedField<uint>();

		// Token: 0x040016F4 RID: 5876
		public const int SelectHintIdFieldNumber = 12;

		// Token: 0x040016F5 RID: 5877
		private uint selectHintId_;
	}
}

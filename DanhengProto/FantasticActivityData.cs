using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004FF RID: 1279
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FantasticActivityData : IMessage<FantasticActivityData>, IMessage, IEquatable<FantasticActivityData>, IDeepCloneable<FantasticActivityData>, IBufferMessage
	{
		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0009D81F File Offset: 0x0009BA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FantasticActivityData> Parser
		{
			get
			{
				return FantasticActivityData._parser;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0009D826 File Offset: 0x0009BA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FantasticActivityDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x0009D838 File Offset: 0x0009BA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FantasticActivityData.Descriptor;
			}
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x0009D840 File Offset: 0x0009BA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FantasticActivityData()
		{
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x0009D898 File Offset: 0x0009BA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FantasticActivityData(FantasticActivityData other) : this()
		{
			this.cAICDAFAGNI_ = other.cAICDAFAGNI_.Clone();
			this.gJLEJEEADMP_ = other.gJLEJEEADMP_.Clone();
			this.jPLKEIAKGCB_ = other.jPLKEIAKGCB_.Clone();
			this.mDEABAJNLBJ_ = other.mDEABAJNLBJ_.Clone();
			this.gLEJEAKFBPC_ = other.gLEJEAKFBPC_.Clone();
			this.kLANEABKELD_ = other.kLANEABKELD_;
			this.hAIMFAMAIHG_ = other.hAIMFAMAIHG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x0009D92E File Offset: 0x0009BB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FantasticActivityData Clone()
		{
			return new FantasticActivityData(this);
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x0009D936 File Offset: 0x0009BB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> CAICDAFAGNI
		{
			get
			{
				return this.cAICDAFAGNI_;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x0009D93E File Offset: 0x0009BB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GJLEJEEADMP
		{
			get
			{
				return this.gJLEJEEADMP_;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x0009D946 File Offset: 0x0009BB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> JPLKEIAKGCB
		{
			get
			{
				return this.jPLKEIAKGCB_;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x0009D94E File Offset: 0x0009BB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MDEABAJNLBJ
		{
			get
			{
				return this.mDEABAJNLBJ_;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x0009D956 File Offset: 0x0009BB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GLEJEAKFBPC
		{
			get
			{
				return this.gLEJEAKFBPC_;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06003953 RID: 14675 RVA: 0x0009D95E File Offset: 0x0009BB5E
		// (set) Token: 0x06003954 RID: 14676 RVA: 0x0009D966 File Offset: 0x0009BB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KLANEABKELD
		{
			get
			{
				return this.kLANEABKELD_;
			}
			set
			{
				this.kLANEABKELD_ = value;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x0009D96F File Offset: 0x0009BB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, KGEDKKAJKCL> HAIMFAMAIHG
		{
			get
			{
				return this.hAIMFAMAIHG_;
			}
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x0009D977 File Offset: 0x0009BB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FantasticActivityData);
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x0009D988 File Offset: 0x0009BB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FantasticActivityData other)
		{
			return other != null && (other == this || (this.cAICDAFAGNI_.Equals(other.cAICDAFAGNI_) && this.gJLEJEEADMP_.Equals(other.gJLEJEEADMP_) && this.JPLKEIAKGCB.Equals(other.JPLKEIAKGCB) && this.mDEABAJNLBJ_.Equals(other.mDEABAJNLBJ_) && this.gLEJEAKFBPC_.Equals(other.gLEJEAKFBPC_) && this.KLANEABKELD == other.KLANEABKELD && this.HAIMFAMAIHG.Equals(other.HAIMFAMAIHG) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x0009DA40 File Offset: 0x0009BC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cAICDAFAGNI_.GetHashCode();
			num ^= this.gJLEJEEADMP_.GetHashCode();
			num ^= this.JPLKEIAKGCB.GetHashCode();
			num ^= this.mDEABAJNLBJ_.GetHashCode();
			num ^= this.gLEJEAKFBPC_.GetHashCode();
			if (this.KLANEABKELD != 0U)
			{
				num ^= this.KLANEABKELD.GetHashCode();
			}
			num ^= this.HAIMFAMAIHG.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0009DAD3 File Offset: 0x0009BCD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0009DADB File Offset: 0x0009BCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x0009DAE4 File Offset: 0x0009BCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hAIMFAMAIHG_.WriteTo(ref output, FantasticActivityData._map_hAIMFAMAIHG_codec);
			this.jPLKEIAKGCB_.WriteTo(ref output, FantasticActivityData._map_jPLKEIAKGCB_codec);
			if (this.KLANEABKELD != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.KLANEABKELD);
			}
			this.gLEJEAKFBPC_.WriteTo(ref output, FantasticActivityData._repeated_gLEJEAKFBPC_codec);
			this.gJLEJEEADMP_.WriteTo(ref output, FantasticActivityData._repeated_gJLEJEEADMP_codec);
			this.cAICDAFAGNI_.WriteTo(ref output, FantasticActivityData._repeated_cAICDAFAGNI_codec);
			this.mDEABAJNLBJ_.WriteTo(ref output, FantasticActivityData._repeated_mDEABAJNLBJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x0009DB88 File Offset: 0x0009BD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cAICDAFAGNI_.CalculateSize(FantasticActivityData._repeated_cAICDAFAGNI_codec);
			num += this.gJLEJEEADMP_.CalculateSize(FantasticActivityData._repeated_gJLEJEEADMP_codec);
			num += this.jPLKEIAKGCB_.CalculateSize(FantasticActivityData._map_jPLKEIAKGCB_codec);
			num += this.mDEABAJNLBJ_.CalculateSize(FantasticActivityData._repeated_mDEABAJNLBJ_codec);
			num += this.gLEJEAKFBPC_.CalculateSize(FantasticActivityData._repeated_gLEJEAKFBPC_codec);
			if (this.KLANEABKELD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KLANEABKELD);
			}
			num += this.hAIMFAMAIHG_.CalculateSize(FantasticActivityData._map_hAIMFAMAIHG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x0009DC38 File Offset: 0x0009BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FantasticActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.cAICDAFAGNI_.Add(other.cAICDAFAGNI_);
			this.gJLEJEEADMP_.Add(other.gJLEJEEADMP_);
			this.jPLKEIAKGCB_.MergeFrom(other.jPLKEIAKGCB_);
			this.mDEABAJNLBJ_.Add(other.mDEABAJNLBJ_);
			this.gLEJEAKFBPC_.Add(other.gLEJEAKFBPC_);
			if (other.KLANEABKELD != 0U)
			{
				this.KLANEABKELD = other.KLANEABKELD;
			}
			this.hAIMFAMAIHG_.MergeFrom(other.hAIMFAMAIHG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x0009DCDA File Offset: 0x0009BEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x0009DCE4 File Offset: 0x0009BEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 50U)
				{
					if (num <= 112U)
					{
						if (num == 64U || num == 66U)
						{
							this.gJLEJEEADMP_.AddEntriesFrom(ref input, FantasticActivityData._repeated_gJLEJEEADMP_codec);
							continue;
						}
						if (num != 112U)
						{
							goto IL_5A;
						}
					}
					else if (num != 114U)
					{
						if (num != 120U && num != 122U)
						{
							goto IL_5A;
						}
						this.mDEABAJNLBJ_.AddEntriesFrom(ref input, FantasticActivityData._repeated_mDEABAJNLBJ_codec);
						continue;
					}
					this.cAICDAFAGNI_.AddEntriesFrom(ref input, FantasticActivityData._repeated_cAICDAFAGNI_codec);
					continue;
				}
				if (num <= 26U)
				{
					if (num == 18U)
					{
						this.hAIMFAMAIHG_.AddEntriesFrom(ref input, FantasticActivityData._map_hAIMFAMAIHG_codec);
						continue;
					}
					if (num == 26U)
					{
						this.jPLKEIAKGCB_.AddEntriesFrom(ref input, FantasticActivityData._map_jPLKEIAKGCB_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.KLANEABKELD = input.ReadUInt32();
						continue;
					}
					if (num == 48U || num == 50U)
					{
						this.gLEJEAKFBPC_.AddEntriesFrom(ref input, FantasticActivityData._repeated_gLEJEAKFBPC_codec);
						continue;
					}
				}
				IL_5A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040016C6 RID: 5830
		private static readonly MessageParser<FantasticActivityData> _parser = new MessageParser<FantasticActivityData>(() => new FantasticActivityData());

		// Token: 0x040016C7 RID: 5831
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016C8 RID: 5832
		public const int CAICDAFAGNIFieldNumber = 14;

		// Token: 0x040016C9 RID: 5833
		private static readonly FieldCodec<uint> _repeated_cAICDAFAGNI_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x040016CA RID: 5834
		private readonly RepeatedField<uint> cAICDAFAGNI_ = new RepeatedField<uint>();

		// Token: 0x040016CB RID: 5835
		public const int GJLEJEEADMPFieldNumber = 8;

		// Token: 0x040016CC RID: 5836
		private static readonly FieldCodec<uint> _repeated_gJLEJEEADMP_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x040016CD RID: 5837
		private readonly RepeatedField<uint> gJLEJEEADMP_ = new RepeatedField<uint>();

		// Token: 0x040016CE RID: 5838
		public const int JPLKEIAKGCBFieldNumber = 3;

		// Token: 0x040016CF RID: 5839
		private static readonly MapField<uint, uint>.Codec _map_jPLKEIAKGCB_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 26U);

		// Token: 0x040016D0 RID: 5840
		private readonly MapField<uint, uint> jPLKEIAKGCB_ = new MapField<uint, uint>();

		// Token: 0x040016D1 RID: 5841
		public const int MDEABAJNLBJFieldNumber = 15;

		// Token: 0x040016D2 RID: 5842
		private static readonly FieldCodec<uint> _repeated_mDEABAJNLBJ_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x040016D3 RID: 5843
		private readonly RepeatedField<uint> mDEABAJNLBJ_ = new RepeatedField<uint>();

		// Token: 0x040016D4 RID: 5844
		public const int GLEJEAKFBPCFieldNumber = 6;

		// Token: 0x040016D5 RID: 5845
		private static readonly FieldCodec<uint> _repeated_gLEJEAKFBPC_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x040016D6 RID: 5846
		private readonly RepeatedField<uint> gLEJEAKFBPC_ = new RepeatedField<uint>();

		// Token: 0x040016D7 RID: 5847
		public const int KLANEABKELDFieldNumber = 4;

		// Token: 0x040016D8 RID: 5848
		private uint kLANEABKELD_;

		// Token: 0x040016D9 RID: 5849
		public const int HAIMFAMAIHGFieldNumber = 2;

		// Token: 0x040016DA RID: 5850
		private static readonly MapField<uint, KGEDKKAJKCL>.Codec _map_hAIMFAMAIHG_codec = new MapField<uint, KGEDKKAJKCL>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<KGEDKKAJKCL>(18U, KGEDKKAJKCL.Parser), 18U);

		// Token: 0x040016DB RID: 5851
		private readonly MapField<uint, KGEDKKAJKCL> hAIMFAMAIHG_ = new MapField<uint, KGEDKKAJKCL>();
	}
}

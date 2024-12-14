using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FD9 RID: 4057
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournHandbookInfo : IMessage<RogueTournHandbookInfo>, IMessage, IEquatable<RogueTournHandbookInfo>, IDeepCloneable<RogueTournHandbookInfo>, IBufferMessage
	{
		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600B4B6 RID: 46262 RVA: 0x001E4D9B File Offset: 0x001E2F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournHandbookInfo> Parser
		{
			get
			{
				return RogueTournHandbookInfo._parser;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600B4B7 RID: 46263 RVA: 0x001E4DA2 File Offset: 0x001E2FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournHandbookInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600B4B8 RID: 46264 RVA: 0x001E4DB4 File Offset: 0x001E2FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournHandbookInfo.Descriptor;
			}
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x001E4DBB File Offset: 0x001E2FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournHandbookInfo()
		{
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x001E4DFC File Offset: 0x001E2FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournHandbookInfo(RogueTournHandbookInfo other) : this()
		{
			this.nDGHLIFGHKK_ = other.nDGHLIFGHKK_.Clone();
			this.handbookBuffList_ = other.handbookBuffList_.Clone();
			this.lMIJCPOICHI_ = other.lMIJCPOICHI_;
			this.dGFPMKGGFAG_ = other.dGFPMKGGFAG_.Clone();
			this.aKLCENCMMLF_ = other.aKLCENCMMLF_.Clone();
			this.pEHIDLKDCCJ_ = other.pEHIDLKDCCJ_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x001E4E81 File Offset: 0x001E3081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournHandbookInfo Clone()
		{
			return new RogueTournHandbookInfo(this);
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x001E4E89 File Offset: 0x001E3089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NDGHLIFGHKK
		{
			get
			{
				return this.nDGHLIFGHKK_;
			}
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600B4BD RID: 46269 RVA: 0x001E4E91 File Offset: 0x001E3091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HandbookBuffList
		{
			get
			{
				return this.handbookBuffList_;
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600B4BE RID: 46270 RVA: 0x001E4E99 File Offset: 0x001E3099
		// (set) Token: 0x0600B4BF RID: 46271 RVA: 0x001E4EA1 File Offset: 0x001E30A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LMIJCPOICHI
		{
			get
			{
				return this.lMIJCPOICHI_;
			}
			set
			{
				this.lMIJCPOICHI_ = value;
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600B4C0 RID: 46272 RVA: 0x001E4EAA File Offset: 0x001E30AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DGFPMKGGFAG
		{
			get
			{
				return this.dGFPMKGGFAG_;
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600B4C1 RID: 46273 RVA: 0x001E4EB2 File Offset: 0x001E30B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AKLCENCMMLF
		{
			get
			{
				return this.aKLCENCMMLF_;
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600B4C2 RID: 46274 RVA: 0x001E4EBA File Offset: 0x001E30BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PEHIDLKDCCJ
		{
			get
			{
				return this.pEHIDLKDCCJ_;
			}
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x001E4EC2 File Offset: 0x001E30C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournHandbookInfo);
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x001E4ED0 File Offset: 0x001E30D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournHandbookInfo other)
		{
			return other != null && (other == this || (this.nDGHLIFGHKK_.Equals(other.nDGHLIFGHKK_) && this.handbookBuffList_.Equals(other.handbookBuffList_) && this.LMIJCPOICHI == other.LMIJCPOICHI && this.dGFPMKGGFAG_.Equals(other.dGFPMKGGFAG_) && this.aKLCENCMMLF_.Equals(other.aKLCENCMMLF_) && this.pEHIDLKDCCJ_.Equals(other.pEHIDLKDCCJ_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x001E4F74 File Offset: 0x001E3174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nDGHLIFGHKK_.GetHashCode();
			num ^= this.handbookBuffList_.GetHashCode();
			if (this.LMIJCPOICHI != 0U)
			{
				num ^= this.LMIJCPOICHI.GetHashCode();
			}
			num ^= this.dGFPMKGGFAG_.GetHashCode();
			num ^= this.aKLCENCMMLF_.GetHashCode();
			num ^= this.pEHIDLKDCCJ_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x001E4FF9 File Offset: 0x001E31F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x001E5001 File Offset: 0x001E3201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x001E500C File Offset: 0x001E320C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nDGHLIFGHKK_.WriteTo(ref output, RogueTournHandbookInfo._repeated_nDGHLIFGHKK_codec);
			this.aKLCENCMMLF_.WriteTo(ref output, RogueTournHandbookInfo._repeated_aKLCENCMMLF_codec);
			this.handbookBuffList_.WriteTo(ref output, RogueTournHandbookInfo._repeated_handbookBuffList_codec);
			this.dGFPMKGGFAG_.WriteTo(ref output, RogueTournHandbookInfo._repeated_dGFPMKGGFAG_codec);
			this.pEHIDLKDCCJ_.WriteTo(ref output, RogueTournHandbookInfo._repeated_pEHIDLKDCCJ_codec);
			if (this.LMIJCPOICHI != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LMIJCPOICHI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x001E50A0 File Offset: 0x001E32A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nDGHLIFGHKK_.CalculateSize(RogueTournHandbookInfo._repeated_nDGHLIFGHKK_codec);
			num += this.handbookBuffList_.CalculateSize(RogueTournHandbookInfo._repeated_handbookBuffList_codec);
			if (this.LMIJCPOICHI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LMIJCPOICHI);
			}
			num += this.dGFPMKGGFAG_.CalculateSize(RogueTournHandbookInfo._repeated_dGFPMKGGFAG_codec);
			num += this.aKLCENCMMLF_.CalculateSize(RogueTournHandbookInfo._repeated_aKLCENCMMLF_codec);
			num += this.pEHIDLKDCCJ_.CalculateSize(RogueTournHandbookInfo._repeated_pEHIDLKDCCJ_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x001E5140 File Offset: 0x001E3340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournHandbookInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.nDGHLIFGHKK_.Add(other.nDGHLIFGHKK_);
			this.handbookBuffList_.Add(other.handbookBuffList_);
			if (other.LMIJCPOICHI != 0U)
			{
				this.LMIJCPOICHI = other.LMIJCPOICHI;
			}
			this.dGFPMKGGFAG_.Add(other.dGFPMKGGFAG_);
			this.aKLCENCMMLF_.Add(other.aKLCENCMMLF_);
			this.pEHIDLKDCCJ_.Add(other.pEHIDLKDCCJ_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B4CB RID: 46283 RVA: 0x001E51D1 File Offset: 0x001E33D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4CC RID: 46284 RVA: 0x001E51DC File Offset: 0x001E33DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 26U)
					{
						if (num == 24U || num == 26U)
						{
							this.nDGHLIFGHKK_.AddEntriesFrom(ref input, RogueTournHandbookInfo._repeated_nDGHLIFGHKK_codec);
							continue;
						}
					}
					else
					{
						if (num == 40U || num == 42U)
						{
							this.aKLCENCMMLF_.AddEntriesFrom(ref input, RogueTournHandbookInfo._repeated_aKLCENCMMLF_codec);
							continue;
						}
						if (num == 56U)
						{
							goto IL_8B;
						}
					}
				}
				else if (num <= 66U)
				{
					if (num == 58U)
					{
						goto IL_8B;
					}
					if (num == 64U || num == 66U)
					{
						this.dGFPMKGGFAG_.AddEntriesFrom(ref input, RogueTournHandbookInfo._repeated_dGFPMKGGFAG_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U || num == 82U)
					{
						this.pEHIDLKDCCJ_.AddEntriesFrom(ref input, RogueTournHandbookInfo._repeated_pEHIDLKDCCJ_codec);
						continue;
					}
					if (num == 112U)
					{
						this.LMIJCPOICHI = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_8B:
				this.handbookBuffList_.AddEntriesFrom(ref input, RogueTournHandbookInfo._repeated_handbookBuffList_codec);
			}
		}

		// Token: 0x04004937 RID: 18743
		private static readonly MessageParser<RogueTournHandbookInfo> _parser = new MessageParser<RogueTournHandbookInfo>(() => new RogueTournHandbookInfo());

		// Token: 0x04004938 RID: 18744
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004939 RID: 18745
		public const int NDGHLIFGHKKFieldNumber = 3;

		// Token: 0x0400493A RID: 18746
		private static readonly FieldCodec<uint> _repeated_nDGHLIFGHKK_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x0400493B RID: 18747
		private readonly RepeatedField<uint> nDGHLIFGHKK_ = new RepeatedField<uint>();

		// Token: 0x0400493C RID: 18748
		public const int HandbookBuffListFieldNumber = 7;

		// Token: 0x0400493D RID: 18749
		private static readonly FieldCodec<uint> _repeated_handbookBuffList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x0400493E RID: 18750
		private readonly RepeatedField<uint> handbookBuffList_ = new RepeatedField<uint>();

		// Token: 0x0400493F RID: 18751
		public const int LMIJCPOICHIFieldNumber = 14;

		// Token: 0x04004940 RID: 18752
		private uint lMIJCPOICHI_;

		// Token: 0x04004941 RID: 18753
		public const int DGFPMKGGFAGFieldNumber = 8;

		// Token: 0x04004942 RID: 18754
		private static readonly FieldCodec<uint> _repeated_dGFPMKGGFAG_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04004943 RID: 18755
		private readonly RepeatedField<uint> dGFPMKGGFAG_ = new RepeatedField<uint>();

		// Token: 0x04004944 RID: 18756
		public const int AKLCENCMMLFFieldNumber = 5;

		// Token: 0x04004945 RID: 18757
		private static readonly FieldCodec<uint> _repeated_aKLCENCMMLF_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04004946 RID: 18758
		private readonly RepeatedField<uint> aKLCENCMMLF_ = new RepeatedField<uint>();

		// Token: 0x04004947 RID: 18759
		public const int PEHIDLKDCCJFieldNumber = 10;

		// Token: 0x04004948 RID: 18760
		private static readonly FieldCodec<uint> _repeated_pEHIDLKDCCJ_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04004949 RID: 18761
		private readonly RepeatedField<uint> pEHIDLKDCCJ_ = new RepeatedField<uint>();
	}
}

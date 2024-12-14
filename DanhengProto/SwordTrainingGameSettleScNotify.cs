using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200122D RID: 4653
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingGameSettleScNotify : IMessage<SwordTrainingGameSettleScNotify>, IMessage, IEquatable<SwordTrainingGameSettleScNotify>, IDeepCloneable<SwordTrainingGameSettleScNotify>, IBufferMessage
	{
		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x0600CFD8 RID: 53208 RVA: 0x0022CCE7 File Offset: 0x0022AEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingGameSettleScNotify> Parser
		{
			get
			{
				return SwordTrainingGameSettleScNotify._parser;
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x0600CFD9 RID: 53209 RVA: 0x0022CCEE File Offset: 0x0022AEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingGameSettleScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x0600CFDA RID: 53210 RVA: 0x0022CD00 File Offset: 0x0022AF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingGameSettleScNotify.Descriptor;
			}
		}

		// Token: 0x0600CFDB RID: 53211 RVA: 0x0022CD07 File Offset: 0x0022AF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGameSettleScNotify()
		{
		}

		// Token: 0x0600CFDC RID: 53212 RVA: 0x0022CD28 File Offset: 0x0022AF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGameSettleScNotify(SwordTrainingGameSettleScNotify other) : this()
		{
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this.nGFDCFAPCAN_ = other.nGFDCFAPCAN_.Clone();
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.reason_ = other.reason_;
			this.pOHANHABPIG_ = other.pOHANHABPIG_;
			this.eMOALFBGGAI_ = other.eMOALFBGGAI_;
			this.nLJEKIIODGF_ = other.nLJEKIIODGF_.Clone();
			this.lICHPGLDEJM_ = other.lICHPGLDEJM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFDD RID: 53213 RVA: 0x0022CDC6 File Offset: 0x0022AFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGameSettleScNotify Clone()
		{
			return new SwordTrainingGameSettleScNotify(this);
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0600CFDE RID: 53214 RVA: 0x0022CDCE File Offset: 0x0022AFCE
		// (set) Token: 0x0600CFDF RID: 53215 RVA: 0x0022CDD6 File Offset: 0x0022AFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStoryLineId
		{
			get
			{
				return this.gameStoryLineId_;
			}
			set
			{
				this.gameStoryLineId_ = value;
			}
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x0600CFE0 RID: 53216 RVA: 0x0022CDDF File Offset: 0x0022AFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NGFDCFAPCAN
		{
			get
			{
				return this.nGFDCFAPCAN_;
			}
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0600CFE1 RID: 53217 RVA: 0x0022CDE7 File Offset: 0x0022AFE7
		// (set) Token: 0x0600CFE2 RID: 53218 RVA: 0x0022CDEF File Offset: 0x0022AFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0600CFE3 RID: 53219 RVA: 0x0022CDF8 File Offset: 0x0022AFF8
		// (set) Token: 0x0600CFE4 RID: 53220 RVA: 0x0022CE00 File Offset: 0x0022B000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KPJJEKIDJBC Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0600CFE5 RID: 53221 RVA: 0x0022CE09 File Offset: 0x0022B009
		// (set) Token: 0x0600CFE6 RID: 53222 RVA: 0x0022CE11 File Offset: 0x0022B011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POHANHABPIG
		{
			get
			{
				return this.pOHANHABPIG_;
			}
			set
			{
				this.pOHANHABPIG_ = value;
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0600CFE7 RID: 53223 RVA: 0x0022CE1A File Offset: 0x0022B01A
		// (set) Token: 0x0600CFE8 RID: 53224 RVA: 0x0022CE22 File Offset: 0x0022B022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EMOALFBGGAI
		{
			get
			{
				return this.eMOALFBGGAI_;
			}
			set
			{
				this.eMOALFBGGAI_ = value;
			}
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0600CFE9 RID: 53225 RVA: 0x0022CE2B File Offset: 0x0022B02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NLJEKIIODGF
		{
			get
			{
				return this.nLJEKIIODGF_;
			}
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0600CFEA RID: 53226 RVA: 0x0022CE33 File Offset: 0x0022B033
		// (set) Token: 0x0600CFEB RID: 53227 RVA: 0x0022CE3B File Offset: 0x0022B03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LICHPGLDEJM
		{
			get
			{
				return this.lICHPGLDEJM_;
			}
			set
			{
				this.lICHPGLDEJM_ = value;
			}
		}

		// Token: 0x0600CFEC RID: 53228 RVA: 0x0022CE44 File Offset: 0x0022B044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingGameSettleScNotify);
		}

		// Token: 0x0600CFED RID: 53229 RVA: 0x0022CE54 File Offset: 0x0022B054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingGameSettleScNotify other)
		{
			return other != null && (other == this || (this.GameStoryLineId == other.GameStoryLineId && this.nGFDCFAPCAN_.Equals(other.nGFDCFAPCAN_) && object.Equals(this.Reward, other.Reward) && this.Reason == other.Reason && this.POHANHABPIG == other.POHANHABPIG && this.EMOALFBGGAI == other.EMOALFBGGAI && this.nLJEKIIODGF_.Equals(other.nLJEKIIODGF_) && this.LICHPGLDEJM == other.LICHPGLDEJM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFEE RID: 53230 RVA: 0x0022CF0C File Offset: 0x0022B10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameStoryLineId != 0U)
			{
				num ^= this.GameStoryLineId.GetHashCode();
			}
			num ^= this.nGFDCFAPCAN_.GetHashCode();
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Reason != KPJJEKIDJBC.SwordTrainingGameSettleNone)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.POHANHABPIG != 0U)
			{
				num ^= this.POHANHABPIG.GetHashCode();
			}
			if (this.EMOALFBGGAI != 0U)
			{
				num ^= this.EMOALFBGGAI.GetHashCode();
			}
			num ^= this.nLJEKIIODGF_.GetHashCode();
			if (this.LICHPGLDEJM != 0U)
			{
				num ^= this.LICHPGLDEJM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CFEF RID: 53231 RVA: 0x0022CFE7 File Offset: 0x0022B1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CFF0 RID: 53232 RVA: 0x0022CFEF File Offset: 0x0022B1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFF1 RID: 53233 RVA: 0x0022CFF8 File Offset: 0x0022B1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameStoryLineId);
			}
			if (this.LICHPGLDEJM != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.LICHPGLDEJM);
			}
			if (this.EMOALFBGGAI != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EMOALFBGGAI);
			}
			this.nGFDCFAPCAN_.WriteTo(ref output, SwordTrainingGameSettleScNotify._repeated_nGFDCFAPCAN_codec);
			if (this.POHANHABPIG != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.POHANHABPIG);
			}
			if (this.Reason != KPJJEKIDJBC.SwordTrainingGameSettleNone)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Reason);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Reward);
			}
			this.nLJEKIIODGF_.WriteTo(ref output, SwordTrainingGameSettleScNotify._repeated_nLJEKIIODGF_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFF2 RID: 53234 RVA: 0x0022D0E4 File Offset: 0x0022B2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GameStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStoryLineId);
			}
			num += this.nGFDCFAPCAN_.CalculateSize(SwordTrainingGameSettleScNotify._repeated_nGFDCFAPCAN_codec);
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Reason != KPJJEKIDJBC.SwordTrainingGameSettleNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.POHANHABPIG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POHANHABPIG);
			}
			if (this.EMOALFBGGAI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EMOALFBGGAI);
			}
			num += this.nLJEKIIODGF_.CalculateSize(SwordTrainingGameSettleScNotify._repeated_nLJEKIIODGF_codec);
			if (this.LICHPGLDEJM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LICHPGLDEJM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CFF3 RID: 53235 RVA: 0x0022D1C0 File Offset: 0x0022B3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingGameSettleScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GameStoryLineId != 0U)
			{
				this.GameStoryLineId = other.GameStoryLineId;
			}
			this.nGFDCFAPCAN_.Add(other.nGFDCFAPCAN_);
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Reason != KPJJEKIDJBC.SwordTrainingGameSettleNone)
			{
				this.Reason = other.Reason;
			}
			if (other.POHANHABPIG != 0U)
			{
				this.POHANHABPIG = other.POHANHABPIG;
			}
			if (other.EMOALFBGGAI != 0U)
			{
				this.EMOALFBGGAI = other.EMOALFBGGAI;
			}
			this.nLJEKIIODGF_.Add(other.nLJEKIIODGF_);
			if (other.LICHPGLDEJM != 0U)
			{
				this.LICHPGLDEJM = other.LICHPGLDEJM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFF4 RID: 53236 RVA: 0x0022D29A File Offset: 0x0022B49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFF5 RID: 53237 RVA: 0x0022D2A4 File Offset: 0x0022B4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.GameStoryLineId = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.LICHPGLDEJM = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.EMOALFBGGAI = input.ReadUInt32();
							continue;
						}
						if (num == 32U || num == 34U)
						{
							this.nGFDCFAPCAN_.AddEntriesFrom(ref input, SwordTrainingGameSettleScNotify._repeated_nGFDCFAPCAN_codec);
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 40U)
					{
						this.POHANHABPIG = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Reason = (KPJJEKIDJBC)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 104U || num == 106U)
					{
						this.nLJEKIIODGF_.AddEntriesFrom(ref input, SwordTrainingGameSettleScNotify._repeated_nLJEKIIODGF_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005395 RID: 21397
		private static readonly MessageParser<SwordTrainingGameSettleScNotify> _parser = new MessageParser<SwordTrainingGameSettleScNotify>(() => new SwordTrainingGameSettleScNotify());

		// Token: 0x04005396 RID: 21398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005397 RID: 21399
		public const int GameStoryLineIdFieldNumber = 1;

		// Token: 0x04005398 RID: 21400
		private uint gameStoryLineId_;

		// Token: 0x04005399 RID: 21401
		public const int NGFDCFAPCANFieldNumber = 4;

		// Token: 0x0400539A RID: 21402
		private static readonly FieldCodec<uint> _repeated_nGFDCFAPCAN_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400539B RID: 21403
		private readonly RepeatedField<uint> nGFDCFAPCAN_ = new RepeatedField<uint>();

		// Token: 0x0400539C RID: 21404
		public const int RewardFieldNumber = 10;

		// Token: 0x0400539D RID: 21405
		private ItemList reward_;

		// Token: 0x0400539E RID: 21406
		public const int ReasonFieldNumber = 8;

		// Token: 0x0400539F RID: 21407
		private KPJJEKIDJBC reason_;

		// Token: 0x040053A0 RID: 21408
		public const int POHANHABPIGFieldNumber = 5;

		// Token: 0x040053A1 RID: 21409
		private uint pOHANHABPIG_;

		// Token: 0x040053A2 RID: 21410
		public const int EMOALFBGGAIFieldNumber = 3;

		// Token: 0x040053A3 RID: 21411
		private uint eMOALFBGGAI_;

		// Token: 0x040053A4 RID: 21412
		public const int NLJEKIIODGFFieldNumber = 13;

		// Token: 0x040053A5 RID: 21413
		private static readonly FieldCodec<uint> _repeated_nLJEKIIODGF_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x040053A6 RID: 21414
		private readonly RepeatedField<uint> nLJEKIIODGF_ = new RepeatedField<uint>();

		// Token: 0x040053A7 RID: 21415
		public const int LICHPGLDEJMFieldNumber = 2;

		// Token: 0x040053A8 RID: 21416
		private uint lICHPGLDEJM_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200115B RID: 4443
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooBornScRsp : IMessage<SpaceZooBornScRsp>, IMessage, IEquatable<SpaceZooBornScRsp>, IDeepCloneable<SpaceZooBornScRsp>, IBufferMessage
	{
		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600C635 RID: 50741 RVA: 0x0021404B File Offset: 0x0021224B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooBornScRsp> Parser
		{
			get
			{
				return SpaceZooBornScRsp._parser;
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600C636 RID: 50742 RVA: 0x00214052 File Offset: 0x00212252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooBornScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600C637 RID: 50743 RVA: 0x00214064 File Offset: 0x00212264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooBornScRsp.Descriptor;
			}
		}

		// Token: 0x0600C638 RID: 50744 RVA: 0x0021406B File Offset: 0x0021226B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooBornScRsp()
		{
		}

		// Token: 0x0600C639 RID: 50745 RVA: 0x00214080 File Offset: 0x00212280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooBornScRsp(SpaceZooBornScRsp other) : this()
		{
			this.gACJCIAKJEN_ = ((other.gACJCIAKJEN_ != null) ? other.gACJCIAKJEN_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.dFJCDDIHOGM_ = other.dFJCDDIHOGM_.Clone();
			this.iFCOOAAPLDF_ = other.iFCOOAAPLDF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C63A RID: 50746 RVA: 0x002140E9 File Offset: 0x002122E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooBornScRsp Clone()
		{
			return new SpaceZooBornScRsp(this);
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600C63B RID: 50747 RVA: 0x002140F1 File Offset: 0x002122F1
		// (set) Token: 0x0600C63C RID: 50748 RVA: 0x002140F9 File Offset: 0x002122F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CHBBGEIDOGB GACJCIAKJEN
		{
			get
			{
				return this.gACJCIAKJEN_;
			}
			set
			{
				this.gACJCIAKJEN_ = value;
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600C63D RID: 50749 RVA: 0x00214102 File Offset: 0x00212302
		// (set) Token: 0x0600C63E RID: 50750 RVA: 0x0021410A File Offset: 0x0021230A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600C63F RID: 50751 RVA: 0x00214113 File Offset: 0x00212313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MPPOJKLLOHA> DFJCDDIHOGM
		{
			get
			{
				return this.dFJCDDIHOGM_;
			}
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0600C640 RID: 50752 RVA: 0x0021411B File Offset: 0x0021231B
		// (set) Token: 0x0600C641 RID: 50753 RVA: 0x00214123 File Offset: 0x00212323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IFCOOAAPLDF
		{
			get
			{
				return this.iFCOOAAPLDF_;
			}
			set
			{
				this.iFCOOAAPLDF_ = value;
			}
		}

		// Token: 0x0600C642 RID: 50754 RVA: 0x0021412C File Offset: 0x0021232C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooBornScRsp);
		}

		// Token: 0x0600C643 RID: 50755 RVA: 0x0021413C File Offset: 0x0021233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooBornScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GACJCIAKJEN, other.GACJCIAKJEN) && this.Retcode == other.Retcode && this.dFJCDDIHOGM_.Equals(other.dFJCDDIHOGM_) && this.IFCOOAAPLDF == other.IFCOOAAPLDF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C644 RID: 50756 RVA: 0x002141B0 File Offset: 0x002123B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gACJCIAKJEN_ != null)
			{
				num ^= this.GACJCIAKJEN.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.dFJCDDIHOGM_.GetHashCode();
			if (this.IFCOOAAPLDF)
			{
				num ^= this.IFCOOAAPLDF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C645 RID: 50757 RVA: 0x0021422C File Offset: 0x0021242C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C646 RID: 50758 RVA: 0x00214234 File Offset: 0x00212434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C647 RID: 50759 RVA: 0x00214240 File Offset: 0x00212440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gACJCIAKJEN_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GACJCIAKJEN);
			}
			if (this.IFCOOAAPLDF)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IFCOOAAPLDF);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.dFJCDDIHOGM_.WriteTo(ref output, SpaceZooBornScRsp._repeated_dFJCDDIHOGM_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C648 RID: 50760 RVA: 0x002142C8 File Offset: 0x002124C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gACJCIAKJEN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GACJCIAKJEN);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.dFJCDDIHOGM_.CalculateSize(SpaceZooBornScRsp._repeated_dFJCDDIHOGM_codec);
			if (this.IFCOOAAPLDF)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C649 RID: 50761 RVA: 0x00214340 File Offset: 0x00212540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooBornScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gACJCIAKJEN_ != null)
			{
				if (this.gACJCIAKJEN_ == null)
				{
					this.GACJCIAKJEN = new CHBBGEIDOGB();
				}
				this.GACJCIAKJEN.MergeFrom(other.GACJCIAKJEN);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.dFJCDDIHOGM_.Add(other.dFJCDDIHOGM_);
			if (other.IFCOOAAPLDF)
			{
				this.IFCOOAAPLDF = other.IFCOOAAPLDF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C64A RID: 50762 RVA: 0x002143CD File Offset: 0x002125CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x002143D8 File Offset: 0x002125D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 26U)
					{
						if (this.gACJCIAKJEN_ == null)
						{
							this.GACJCIAKJEN = new CHBBGEIDOGB();
						}
						input.ReadMessage(this.GACJCIAKJEN);
						continue;
					}
					if (num == 56U)
					{
						this.IFCOOAAPLDF = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.dFJCDDIHOGM_.AddEntriesFrom(ref input, SpaceZooBornScRsp._repeated_dFJCDDIHOGM_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005011 RID: 20497
		private static readonly MessageParser<SpaceZooBornScRsp> _parser = new MessageParser<SpaceZooBornScRsp>(() => new SpaceZooBornScRsp());

		// Token: 0x04005012 RID: 20498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005013 RID: 20499
		public const int GACJCIAKJENFieldNumber = 3;

		// Token: 0x04005014 RID: 20500
		private CHBBGEIDOGB gACJCIAKJEN_;

		// Token: 0x04005015 RID: 20501
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04005016 RID: 20502
		private uint retcode_;

		// Token: 0x04005017 RID: 20503
		public const int DFJCDDIHOGMFieldNumber = 14;

		// Token: 0x04005018 RID: 20504
		private static readonly FieldCodec<MPPOJKLLOHA> _repeated_dFJCDDIHOGM_codec = FieldCodec.ForMessage<MPPOJKLLOHA>(114U, MPPOJKLLOHA.Parser);

		// Token: 0x04005019 RID: 20505
		private readonly RepeatedField<MPPOJKLLOHA> dFJCDDIHOGM_ = new RepeatedField<MPPOJKLLOHA>();

		// Token: 0x0400501A RID: 20506
		public const int IFCOOAAPLDFFieldNumber = 7;

		// Token: 0x0400501B RID: 20507
		private bool iFCOOAAPLDF_;
	}
}

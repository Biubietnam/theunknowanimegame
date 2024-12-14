using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E7D RID: 3709
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueEndlessLayerInfo : IMessage<RogueEndlessLayerInfo>, IMessage, IEquatable<RogueEndlessLayerInfo>, IDeepCloneable<RogueEndlessLayerInfo>, IBufferMessage
	{
		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x0600A57A RID: 42362 RVA: 0x001BCBEF File Offset: 0x001BADEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueEndlessLayerInfo> Parser
		{
			get
			{
				return RogueEndlessLayerInfo._parser;
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0600A57B RID: 42363 RVA: 0x001BCBF6 File Offset: 0x001BADF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueEndlessLayerInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0600A57C RID: 42364 RVA: 0x001BCC08 File Offset: 0x001BAE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueEndlessLayerInfo.Descriptor;
			}
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x001BCC0F File Offset: 0x001BAE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessLayerInfo()
		{
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x001BCC18 File Offset: 0x001BAE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessLayerInfo(RogueEndlessLayerInfo other) : this()
		{
			this.isRotate_ = other.isRotate_;
			this.kHGJLJHPLPM_ = other.kHGJLJHPLPM_;
			this.aLBIGNGFBFO_ = other.aLBIGNGFBFO_;
			this.pKEJEOEBBJG_ = other.pKEJEOEBBJG_;
			this.pKIMFMOGBBI_ = other.pKIMFMOGBBI_;
			this.turnLeftCount_ = other.turnLeftCount_;
			this.kODGNCJFGEL_ = other.kODGNCJFGEL_;
			this.battleId_ = other.battleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x001BCC9C File Offset: 0x001BAE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessLayerInfo Clone()
		{
			return new RogueEndlessLayerInfo(this);
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x0600A580 RID: 42368 RVA: 0x001BCCA4 File Offset: 0x001BAEA4
		// (set) Token: 0x0600A581 RID: 42369 RVA: 0x001BCCAC File Offset: 0x001BAEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRotate
		{
			get
			{
				return this.isRotate_;
			}
			set
			{
				this.isRotate_ = value;
			}
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x0600A582 RID: 42370 RVA: 0x001BCCB5 File Offset: 0x001BAEB5
		// (set) Token: 0x0600A583 RID: 42371 RVA: 0x001BCCBD File Offset: 0x001BAEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KHGJLJHPLPM
		{
			get
			{
				return this.kHGJLJHPLPM_;
			}
			set
			{
				this.kHGJLJHPLPM_ = value;
			}
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0600A584 RID: 42372 RVA: 0x001BCCC6 File Offset: 0x001BAEC6
		// (set) Token: 0x0600A585 RID: 42373 RVA: 0x001BCCCE File Offset: 0x001BAECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ALBIGNGFBFO
		{
			get
			{
				return this.aLBIGNGFBFO_;
			}
			set
			{
				this.aLBIGNGFBFO_ = value;
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x0600A586 RID: 42374 RVA: 0x001BCCD7 File Offset: 0x001BAED7
		// (set) Token: 0x0600A587 RID: 42375 RVA: 0x001BCCDF File Offset: 0x001BAEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PKEJEOEBBJG
		{
			get
			{
				return this.pKEJEOEBBJG_;
			}
			set
			{
				this.pKEJEOEBBJG_ = value;
			}
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0600A588 RID: 42376 RVA: 0x001BCCE8 File Offset: 0x001BAEE8
		// (set) Token: 0x0600A589 RID: 42377 RVA: 0x001BCCF0 File Offset: 0x001BAEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PKIMFMOGBBI
		{
			get
			{
				return this.pKIMFMOGBBI_;
			}
			set
			{
				this.pKIMFMOGBBI_ = value;
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0600A58A RID: 42378 RVA: 0x001BCCF9 File Offset: 0x001BAEF9
		// (set) Token: 0x0600A58B RID: 42379 RVA: 0x001BCD01 File Offset: 0x001BAF01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TurnLeftCount
		{
			get
			{
				return this.turnLeftCount_;
			}
			set
			{
				this.turnLeftCount_ = value;
			}
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0600A58C RID: 42380 RVA: 0x001BCD0A File Offset: 0x001BAF0A
		// (set) Token: 0x0600A58D RID: 42381 RVA: 0x001BCD12 File Offset: 0x001BAF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KODGNCJFGEL
		{
			get
			{
				return this.kODGNCJFGEL_;
			}
			set
			{
				this.kODGNCJFGEL_ = value;
			}
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x0600A58E RID: 42382 RVA: 0x001BCD1B File Offset: 0x001BAF1B
		// (set) Token: 0x0600A58F RID: 42383 RVA: 0x001BCD23 File Offset: 0x001BAF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleId
		{
			get
			{
				return this.battleId_;
			}
			set
			{
				this.battleId_ = value;
			}
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x001BCD2C File Offset: 0x001BAF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueEndlessLayerInfo);
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x001BCD3C File Offset: 0x001BAF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueEndlessLayerInfo other)
		{
			return other != null && (other == this || (this.IsRotate == other.IsRotate && this.KHGJLJHPLPM == other.KHGJLJHPLPM && this.ALBIGNGFBFO == other.ALBIGNGFBFO && this.PKEJEOEBBJG == other.PKEJEOEBBJG && this.PKIMFMOGBBI == other.PKIMFMOGBBI && this.TurnLeftCount == other.TurnLeftCount && this.KODGNCJFGEL == other.KODGNCJFGEL && this.BattleId == other.BattleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x001BCDE8 File Offset: 0x001BAFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsRotate)
			{
				num ^= this.IsRotate.GetHashCode();
			}
			if (this.KHGJLJHPLPM != 0U)
			{
				num ^= this.KHGJLJHPLPM.GetHashCode();
			}
			if (this.ALBIGNGFBFO != 0U)
			{
				num ^= this.ALBIGNGFBFO.GetHashCode();
			}
			if (this.PKEJEOEBBJG != 0U)
			{
				num ^= this.PKEJEOEBBJG.GetHashCode();
			}
			if (this.PKIMFMOGBBI != 0U)
			{
				num ^= this.PKIMFMOGBBI.GetHashCode();
			}
			if (this.TurnLeftCount != 0U)
			{
				num ^= this.TurnLeftCount.GetHashCode();
			}
			if (this.KODGNCJFGEL != 0U)
			{
				num ^= this.KODGNCJFGEL.GetHashCode();
			}
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x001BCED6 File Offset: 0x001BB0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x001BCEDE File Offset: 0x001BB0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x001BCEE8 File Offset: 0x001BB0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KHGJLJHPLPM != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.KHGJLJHPLPM);
			}
			if (this.ALBIGNGFBFO != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ALBIGNGFBFO);
			}
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BattleId);
			}
			if (this.TurnLeftCount != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TurnLeftCount);
			}
			if (this.PKIMFMOGBBI != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PKIMFMOGBBI);
			}
			if (this.PKEJEOEBBJG != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.PKEJEOEBBJG);
			}
			if (this.KODGNCJFGEL != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.KODGNCJFGEL);
			}
			if (this.IsRotate)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsRotate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x001BCFEC File Offset: 0x001BB1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsRotate)
			{
				num += 2;
			}
			if (this.KHGJLJHPLPM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KHGJLJHPLPM);
			}
			if (this.ALBIGNGFBFO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ALBIGNGFBFO);
			}
			if (this.PKEJEOEBBJG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PKEJEOEBBJG);
			}
			if (this.PKIMFMOGBBI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PKIMFMOGBBI);
			}
			if (this.TurnLeftCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TurnLeftCount);
			}
			if (this.KODGNCJFGEL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KODGNCJFGEL);
			}
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x001BD0C8 File Offset: 0x001BB2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueEndlessLayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsRotate)
			{
				this.IsRotate = other.IsRotate;
			}
			if (other.KHGJLJHPLPM != 0U)
			{
				this.KHGJLJHPLPM = other.KHGJLJHPLPM;
			}
			if (other.ALBIGNGFBFO != 0U)
			{
				this.ALBIGNGFBFO = other.ALBIGNGFBFO;
			}
			if (other.PKEJEOEBBJG != 0U)
			{
				this.PKEJEOEBBJG = other.PKEJEOEBBJG;
			}
			if (other.PKIMFMOGBBI != 0U)
			{
				this.PKIMFMOGBBI = other.PKIMFMOGBBI;
			}
			if (other.TurnLeftCount != 0U)
			{
				this.TurnLeftCount = other.TurnLeftCount;
			}
			if (other.KODGNCJFGEL != 0U)
			{
				this.KODGNCJFGEL = other.KODGNCJFGEL;
			}
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x001BD190 File Offset: 0x001BB390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A599 RID: 42393 RVA: 0x001BD19C File Offset: 0x001BB39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.KHGJLJHPLPM = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.ALBIGNGFBFO = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.BattleId = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.TurnLeftCount = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 64U)
					{
						this.PKIMFMOGBBI = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.PKEJEOEBBJG = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.KODGNCJFGEL = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsRotate = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004390 RID: 17296
		private static readonly MessageParser<RogueEndlessLayerInfo> _parser = new MessageParser<RogueEndlessLayerInfo>(() => new RogueEndlessLayerInfo());

		// Token: 0x04004391 RID: 17297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004392 RID: 17298
		public const int IsRotateFieldNumber = 15;

		// Token: 0x04004393 RID: 17299
		private bool isRotate_;

		// Token: 0x04004394 RID: 17300
		public const int KHGJLJHPLPMFieldNumber = 2;

		// Token: 0x04004395 RID: 17301
		private uint kHGJLJHPLPM_;

		// Token: 0x04004396 RID: 17302
		public const int ALBIGNGFBFOFieldNumber = 4;

		// Token: 0x04004397 RID: 17303
		private uint aLBIGNGFBFO_;

		// Token: 0x04004398 RID: 17304
		public const int PKEJEOEBBJGFieldNumber = 11;

		// Token: 0x04004399 RID: 17305
		private uint pKEJEOEBBJG_;

		// Token: 0x0400439A RID: 17306
		public const int PKIMFMOGBBIFieldNumber = 8;

		// Token: 0x0400439B RID: 17307
		private uint pKIMFMOGBBI_;

		// Token: 0x0400439C RID: 17308
		public const int TurnLeftCountFieldNumber = 6;

		// Token: 0x0400439D RID: 17309
		private uint turnLeftCount_;

		// Token: 0x0400439E RID: 17310
		public const int KODGNCJFGELFieldNumber = 12;

		// Token: 0x0400439F RID: 17311
		private uint kODGNCJFGEL_;

		// Token: 0x040043A0 RID: 17312
		public const int BattleIdFieldNumber = 5;

		// Token: 0x040043A1 RID: 17313
		private uint battleId_;
	}
}

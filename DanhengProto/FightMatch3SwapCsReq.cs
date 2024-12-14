using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000551 RID: 1361
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3SwapCsReq : IMessage<FightMatch3SwapCsReq>, IMessage, IEquatable<FightMatch3SwapCsReq>, IDeepCloneable<FightMatch3SwapCsReq>, IBufferMessage
	{
		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x000A62F7 File Offset: 0x000A44F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3SwapCsReq> Parser
		{
			get
			{
				return FightMatch3SwapCsReq._parser;
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06003CA8 RID: 15528 RVA: 0x000A62FE File Offset: 0x000A44FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3SwapCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x000A6310 File Offset: 0x000A4510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3SwapCsReq.Descriptor;
			}
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x000A6317 File Offset: 0x000A4517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3SwapCsReq()
		{
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x000A632C File Offset: 0x000A452C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3SwapCsReq(FightMatch3SwapCsReq other) : this()
		{
			this.gMMHLEKIJHP_ = other.gMMHLEKIJHP_.Clone();
			this.nGGOBIKLHLC_ = ((other.nGGOBIKLHLC_ != null) ? other.nGGOBIKLHLC_.Clone() : null);
			this.jJHAOGEHFEN_ = ((other.jJHAOGEHFEN_ != null) ? other.jJHAOGEHFEN_.Clone() : null);
			this.pPBIIDKNIDA_ = other.pPBIIDKNIDA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x000A63A5 File Offset: 0x000A45A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3SwapCsReq Clone()
		{
			return new FightMatch3SwapCsReq(this);
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x000A63AD File Offset: 0x000A45AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KEKABJPICIP> GMMHLEKIJHP
		{
			get
			{
				return this.gMMHLEKIJHP_;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06003CAE RID: 15534 RVA: 0x000A63B5 File Offset: 0x000A45B5
		// (set) Token: 0x06003CAF RID: 15535 RVA: 0x000A63BD File Offset: 0x000A45BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MDLLCLADJCP NGGOBIKLHLC
		{
			get
			{
				return this.nGGOBIKLHLC_;
			}
			set
			{
				this.nGGOBIKLHLC_ = value;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x000A63C6 File Offset: 0x000A45C6
		// (set) Token: 0x06003CB1 RID: 15537 RVA: 0x000A63CE File Offset: 0x000A45CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MDLLCLADJCP JJHAOGEHFEN
		{
			get
			{
				return this.jJHAOGEHFEN_;
			}
			set
			{
				this.jJHAOGEHFEN_ = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x000A63D7 File Offset: 0x000A45D7
		// (set) Token: 0x06003CB3 RID: 15539 RVA: 0x000A63DF File Offset: 0x000A45DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PPBIIDKNIDA
		{
			get
			{
				return this.pPBIIDKNIDA_;
			}
			set
			{
				this.pPBIIDKNIDA_ = value;
			}
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x000A63E8 File Offset: 0x000A45E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3SwapCsReq);
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x000A63F8 File Offset: 0x000A45F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3SwapCsReq other)
		{
			return other != null && (other == this || (this.gMMHLEKIJHP_.Equals(other.gMMHLEKIJHP_) && object.Equals(this.NGGOBIKLHLC, other.NGGOBIKLHLC) && object.Equals(this.JJHAOGEHFEN, other.JJHAOGEHFEN) && this.PPBIIDKNIDA == other.PPBIIDKNIDA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x000A6470 File Offset: 0x000A4670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gMMHLEKIJHP_.GetHashCode();
			if (this.nGGOBIKLHLC_ != null)
			{
				num ^= this.NGGOBIKLHLC.GetHashCode();
			}
			if (this.jJHAOGEHFEN_ != null)
			{
				num ^= this.JJHAOGEHFEN.GetHashCode();
			}
			if (this.PPBIIDKNIDA != 0U)
			{
				num ^= this.PPBIIDKNIDA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x000A64E9 File Offset: 0x000A46E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x000A64F1 File Offset: 0x000A46F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x000A64FC File Offset: 0x000A46FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.jJHAOGEHFEN_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.JJHAOGEHFEN);
			}
			this.gMMHLEKIJHP_.WriteTo(ref output, FightMatch3SwapCsReq._repeated_gMMHLEKIJHP_codec);
			if (this.PPBIIDKNIDA != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.PPBIIDKNIDA);
			}
			if (this.nGGOBIKLHLC_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.NGGOBIKLHLC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x000A6584 File Offset: 0x000A4784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gMMHLEKIJHP_.CalculateSize(FightMatch3SwapCsReq._repeated_gMMHLEKIJHP_codec);
			if (this.nGGOBIKLHLC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NGGOBIKLHLC);
			}
			if (this.jJHAOGEHFEN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JJHAOGEHFEN);
			}
			if (this.PPBIIDKNIDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPBIIDKNIDA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x000A6608 File Offset: 0x000A4808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3SwapCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.gMMHLEKIJHP_.Add(other.gMMHLEKIJHP_);
			if (other.nGGOBIKLHLC_ != null)
			{
				if (this.nGGOBIKLHLC_ == null)
				{
					this.NGGOBIKLHLC = new MDLLCLADJCP();
				}
				this.NGGOBIKLHLC.MergeFrom(other.NGGOBIKLHLC);
			}
			if (other.jJHAOGEHFEN_ != null)
			{
				if (this.jJHAOGEHFEN_ == null)
				{
					this.JJHAOGEHFEN = new MDLLCLADJCP();
				}
				this.JJHAOGEHFEN.MergeFrom(other.JJHAOGEHFEN);
			}
			if (other.PPBIIDKNIDA != 0U)
			{
				this.PPBIIDKNIDA = other.PPBIIDKNIDA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x000A66AD File Offset: 0x000A48AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x000A66B8 File Offset: 0x000A48B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 66U)
					{
						if (this.jJHAOGEHFEN_ == null)
						{
							this.JJHAOGEHFEN = new MDLLCLADJCP();
						}
						input.ReadMessage(this.JJHAOGEHFEN);
						continue;
					}
					if (num == 82U)
					{
						this.gMMHLEKIJHP_.AddEntriesFrom(ref input, FightMatch3SwapCsReq._repeated_gMMHLEKIJHP_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.PPBIIDKNIDA = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.nGGOBIKLHLC_ == null)
						{
							this.NGGOBIKLHLC = new MDLLCLADJCP();
						}
						input.ReadMessage(this.NGGOBIKLHLC);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001852 RID: 6226
		private static readonly MessageParser<FightMatch3SwapCsReq> _parser = new MessageParser<FightMatch3SwapCsReq>(() => new FightMatch3SwapCsReq());

		// Token: 0x04001853 RID: 6227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001854 RID: 6228
		public const int GMMHLEKIJHPFieldNumber = 10;

		// Token: 0x04001855 RID: 6229
		private static readonly FieldCodec<KEKABJPICIP> _repeated_gMMHLEKIJHP_codec = FieldCodec.ForMessage<KEKABJPICIP>(82U, KEKABJPICIP.Parser);

		// Token: 0x04001856 RID: 6230
		private readonly RepeatedField<KEKABJPICIP> gMMHLEKIJHP_ = new RepeatedField<KEKABJPICIP>();

		// Token: 0x04001857 RID: 6231
		public const int NGGOBIKLHLCFieldNumber = 15;

		// Token: 0x04001858 RID: 6232
		private MDLLCLADJCP nGGOBIKLHLC_;

		// Token: 0x04001859 RID: 6233
		public const int JJHAOGEHFENFieldNumber = 8;

		// Token: 0x0400185A RID: 6234
		private MDLLCLADJCP jJHAOGEHFEN_;

		// Token: 0x0400185B RID: 6235
		public const int PPBIIDKNIDAFieldNumber = 11;

		// Token: 0x0400185C RID: 6236
		private uint pPBIIDKNIDA_;
	}
}

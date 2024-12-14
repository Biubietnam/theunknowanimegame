using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000235 RID: 565
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueLayerInitialEventInfo : IMessage<ChessRogueLayerInitialEventInfo>, IMessage, IEquatable<ChessRogueLayerInitialEventInfo>, IDeepCloneable<ChessRogueLayerInitialEventInfo>, IBufferMessage
	{
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0004A1A3 File Offset: 0x000483A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueLayerInitialEventInfo> Parser
		{
			get
			{
				return ChessRogueLayerInitialEventInfo._parser;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x0004A1AA File Offset: 0x000483AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueLayerInitialEventInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x0004A1BC File Offset: 0x000483BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueLayerInitialEventInfo.Descriptor;
			}
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0004A1C3 File Offset: 0x000483C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLayerInitialEventInfo()
		{
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0004A1D6 File Offset: 0x000483D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLayerInitialEventInfo(ChessRogueLayerInitialEventInfo other) : this()
		{
			this.lOOBFDDNOKK_ = other.lOOBFDDNOKK_;
			this.cellList_ = other.cellList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0004A20C File Offset: 0x0004840C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLayerInitialEventInfo Clone()
		{
			return new ChessRogueLayerInitialEventInfo(this);
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0004A214 File Offset: 0x00048414
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x0004A21C File Offset: 0x0004841C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LOOBFDDNOKK
		{
			get
			{
				return this.lOOBFDDNOKK_;
			}
			set
			{
				this.lOOBFDDNOKK_ = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x0004A225 File Offset: 0x00048425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueCell> CellList
		{
			get
			{
				return this.cellList_;
			}
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0004A22D File Offset: 0x0004842D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueLayerInitialEventInfo);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0004A23C File Offset: 0x0004843C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueLayerInitialEventInfo other)
		{
			return other != null && (other == this || (this.LOOBFDDNOKK == other.LOOBFDDNOKK && this.cellList_.Equals(other.cellList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0004A28C File Offset: 0x0004848C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LOOBFDDNOKK != 0U)
			{
				num ^= this.LOOBFDDNOKK.GetHashCode();
			}
			num ^= this.cellList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0004A2D9 File Offset: 0x000484D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0004A2E1 File Offset: 0x000484E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0004A2EC File Offset: 0x000484EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LOOBFDDNOKK != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.LOOBFDDNOKK);
			}
			this.cellList_.WriteTo(ref output, ChessRogueLayerInitialEventInfo._repeated_cellList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0004A33C File Offset: 0x0004853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LOOBFDDNOKK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LOOBFDDNOKK);
			}
			num += this.cellList_.CalculateSize(ChessRogueLayerInitialEventInfo._repeated_cellList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0004A390 File Offset: 0x00048590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueLayerInitialEventInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LOOBFDDNOKK != 0U)
			{
				this.LOOBFDDNOKK = other.LOOBFDDNOKK;
			}
			this.cellList_.Add(other.cellList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0004A3DD File Offset: 0x000485DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0004A3E8 File Offset: 0x000485E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.cellList_.AddEntriesFrom(ref input, ChessRogueLayerInitialEventInfo._repeated_cellList_codec);
					}
				}
				else
				{
					this.LOOBFDDNOKK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000AD5 RID: 2773
		private static readonly MessageParser<ChessRogueLayerInitialEventInfo> _parser = new MessageParser<ChessRogueLayerInitialEventInfo>(() => new ChessRogueLayerInitialEventInfo());

		// Token: 0x04000AD6 RID: 2774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AD7 RID: 2775
		public const int LOOBFDDNOKKFieldNumber = 8;

		// Token: 0x04000AD8 RID: 2776
		private uint lOOBFDDNOKK_;

		// Token: 0x04000AD9 RID: 2777
		public const int CellListFieldNumber = 13;

		// Token: 0x04000ADA RID: 2778
		private static readonly FieldCodec<ChessRogueCell> _repeated_cellList_codec = FieldCodec.ForMessage<ChessRogueCell>(106U, ChessRogueCell.Parser);

		// Token: 0x04000ADB RID: 2779
		private readonly RepeatedField<ChessRogueCell> cellList_ = new RepeatedField<ChessRogueCell>();
	}
}

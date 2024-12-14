using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200020D RID: 525
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueEnterCellCsReq : IMessage<ChessRogueEnterCellCsReq>, IMessage, IEquatable<ChessRogueEnterCellCsReq>, IDeepCloneable<ChessRogueEnterCellCsReq>, IBufferMessage
	{
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x00043299 File Offset: 0x00041499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueEnterCellCsReq> Parser
		{
			get
			{
				return ChessRogueEnterCellCsReq._parser;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x000432A0 File Offset: 0x000414A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterCellCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x000432B2 File Offset: 0x000414B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueEnterCellCsReq.Descriptor;
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000432B9 File Offset: 0x000414B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCellCsReq()
		{
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000432C1 File Offset: 0x000414C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCellCsReq(ChessRogueEnterCellCsReq other) : this()
		{
			this.selectMonsterId_ = other.selectMonsterId_;
			this.cellId_ = other.cellId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000432F2 File Offset: 0x000414F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCellCsReq Clone()
		{
			return new ChessRogueEnterCellCsReq(this);
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x000432FA File Offset: 0x000414FA
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x00043302 File Offset: 0x00041502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectMonsterId
		{
			get
			{
				return this.selectMonsterId_;
			}
			set
			{
				this.selectMonsterId_ = value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0004330B File Offset: 0x0004150B
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x00043313 File Offset: 0x00041513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0004331C File Offset: 0x0004151C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueEnterCellCsReq);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0004332A File Offset: 0x0004152A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueEnterCellCsReq other)
		{
			return other != null && (other == this || (this.SelectMonsterId == other.SelectMonsterId && this.CellId == other.CellId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00043368 File Offset: 0x00041568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectMonsterId != 0U)
			{
				num ^= this.SelectMonsterId.GetHashCode();
			}
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000433C0 File Offset: 0x000415C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000433C8 File Offset: 0x000415C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000433D4 File Offset: 0x000415D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectMonsterId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.SelectMonsterId);
			}
			if (this.CellId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CellId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0004342C File Offset: 0x0004162C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectMonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectMonsterId);
			}
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00043484 File Offset: 0x00041684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueEnterCellCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectMonsterId != 0U)
			{
				this.SelectMonsterId = other.SelectMonsterId;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000434D4 File Offset: 0x000416D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000434E0 File Offset: 0x000416E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CellId = input.ReadUInt32();
					}
				}
				else
				{
					this.SelectMonsterId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040009EC RID: 2540
		private static readonly MessageParser<ChessRogueEnterCellCsReq> _parser = new MessageParser<ChessRogueEnterCellCsReq>(() => new ChessRogueEnterCellCsReq());

		// Token: 0x040009ED RID: 2541
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009EE RID: 2542
		public const int SelectMonsterIdFieldNumber = 1;

		// Token: 0x040009EF RID: 2543
		private uint selectMonsterId_;

		// Token: 0x040009F0 RID: 2544
		public const int CellIdFieldNumber = 12;

		// Token: 0x040009F1 RID: 2545
		private uint cellId_;
	}
}

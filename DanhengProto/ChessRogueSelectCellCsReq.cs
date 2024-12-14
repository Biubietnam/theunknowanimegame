using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000297 RID: 663
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueSelectCellCsReq : IMessage<ChessRogueSelectCellCsReq>, IMessage, IEquatable<ChessRogueSelectCellCsReq>, IDeepCloneable<ChessRogueSelectCellCsReq>, IBufferMessage
	{
		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x00054A31 File Offset: 0x00052C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueSelectCellCsReq> Parser
		{
			get
			{
				return ChessRogueSelectCellCsReq._parser;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00054A38 File Offset: 0x00052C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueSelectCellCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00054A4A File Offset: 0x00052C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueSelectCellCsReq.Descriptor;
			}
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00054A51 File Offset: 0x00052C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectCellCsReq()
		{
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00054A59 File Offset: 0x00052C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectCellCsReq(ChessRogueSelectCellCsReq other) : this()
		{
			this.cellId_ = other.cellId_;
			this.selectMonsterId_ = other.selectMonsterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00054A8A File Offset: 0x00052C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectCellCsReq Clone()
		{
			return new ChessRogueSelectCellCsReq(this);
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00054A92 File Offset: 0x00052C92
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00054A9A File Offset: 0x00052C9A
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

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00054AA3 File Offset: 0x00052CA3
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00054AAB File Offset: 0x00052CAB
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

		// Token: 0x06001D95 RID: 7573 RVA: 0x00054AB4 File Offset: 0x00052CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueSelectCellCsReq);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00054AC2 File Offset: 0x00052CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueSelectCellCsReq other)
		{
			return other != null && (other == this || (this.CellId == other.CellId && this.SelectMonsterId == other.SelectMonsterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00054B00 File Offset: 0x00052D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this.SelectMonsterId != 0U)
			{
				num ^= this.SelectMonsterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00054B58 File Offset: 0x00052D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00054B60 File Offset: 0x00052D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00054B6C File Offset: 0x00052D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CellId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CellId);
			}
			if (this.SelectMonsterId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.SelectMonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00054BC8 File Offset: 0x00052DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this.SelectMonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectMonsterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00054C20 File Offset: 0x00052E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueSelectCellCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			if (other.SelectMonsterId != 0U)
			{
				this.SelectMonsterId = other.SelectMonsterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00054C70 File Offset: 0x00052E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00054C7C File Offset: 0x00052E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectMonsterId = input.ReadUInt32();
					}
				}
				else
				{
					this.CellId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C52 RID: 3154
		private static readonly MessageParser<ChessRogueSelectCellCsReq> _parser = new MessageParser<ChessRogueSelectCellCsReq>(() => new ChessRogueSelectCellCsReq());

		// Token: 0x04000C53 RID: 3155
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C54 RID: 3156
		public const int CellIdFieldNumber = 10;

		// Token: 0x04000C55 RID: 3157
		private uint cellId_;

		// Token: 0x04000C56 RID: 3158
		public const int SelectMonsterIdFieldNumber = 14;

		// Token: 0x04000C57 RID: 3159
		private uint selectMonsterId_;
	}
}

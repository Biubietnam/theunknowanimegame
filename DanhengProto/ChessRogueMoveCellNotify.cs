using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000249 RID: 585
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueMoveCellNotify : IMessage<ChessRogueMoveCellNotify>, IMessage, IEquatable<ChessRogueMoveCellNotify>, IDeepCloneable<ChessRogueMoveCellNotify>, IBufferMessage
	{
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0004C6CF File Offset: 0x0004A8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueMoveCellNotify> Parser
		{
			get
			{
				return ChessRogueMoveCellNotify._parser;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x0004C6D6 File Offset: 0x0004A8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueMoveCellNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0004C6E8 File Offset: 0x0004A8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueMoveCellNotify.Descriptor;
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0004C6EF File Offset: 0x0004A8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMoveCellNotify()
		{
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0004C6F8 File Offset: 0x0004A8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMoveCellNotify(ChessRogueMoveCellNotify other) : this()
		{
			this.bPJOLPLHEEP_ = other.bPJOLPLHEEP_;
			this.nIAHBHIGEIL_ = other.nIAHBHIGEIL_;
			this.cell_ = ((other.cell_ != null) ? other.cell_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0004C750 File Offset: 0x0004A950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMoveCellNotify Clone()
		{
			return new ChessRogueMoveCellNotify(this);
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0004C758 File Offset: 0x0004A958
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0004C760 File Offset: 0x0004A960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BPJOLPLHEEP
		{
			get
			{
				return this.bPJOLPLHEEP_;
			}
			set
			{
				this.bPJOLPLHEEP_ = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0004C769 File Offset: 0x0004A969
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0004C771 File Offset: 0x0004A971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NIAHBHIGEIL
		{
			get
			{
				return this.nIAHBHIGEIL_;
			}
			set
			{
				this.nIAHBHIGEIL_ = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0004C77A File Offset: 0x0004A97A
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0004C782 File Offset: 0x0004A982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellInfo Cell
		{
			get
			{
				return this.cell_;
			}
			set
			{
				this.cell_ = value;
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0004C78B File Offset: 0x0004A98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueMoveCellNotify);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0004C79C File Offset: 0x0004A99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueMoveCellNotify other)
		{
			return other != null && (other == this || (this.BPJOLPLHEEP == other.BPJOLPLHEEP && this.NIAHBHIGEIL == other.NIAHBHIGEIL && object.Equals(this.Cell, other.Cell) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0004C7FC File Offset: 0x0004A9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BPJOLPLHEEP != 0U)
			{
				num ^= this.BPJOLPLHEEP.GetHashCode();
			}
			if (this.NIAHBHIGEIL != 0U)
			{
				num ^= this.NIAHBHIGEIL.GetHashCode();
			}
			if (this.cell_ != null)
			{
				num ^= this.Cell.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0004C86A File Offset: 0x0004AA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0004C872 File Offset: 0x0004AA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0004C87C File Offset: 0x0004AA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cell_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Cell);
			}
			if (this.BPJOLPLHEEP != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BPJOLPLHEEP);
			}
			if (this.NIAHBHIGEIL != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.NIAHBHIGEIL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0004C8F4 File Offset: 0x0004AAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BPJOLPLHEEP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BPJOLPLHEEP);
			}
			if (this.NIAHBHIGEIL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NIAHBHIGEIL);
			}
			if (this.cell_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Cell);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0004C964 File Offset: 0x0004AB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueMoveCellNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BPJOLPLHEEP != 0U)
			{
				this.BPJOLPLHEEP = other.BPJOLPLHEEP;
			}
			if (other.NIAHBHIGEIL != 0U)
			{
				this.NIAHBHIGEIL = other.NIAHBHIGEIL;
			}
			if (other.cell_ != null)
			{
				if (this.cell_ == null)
				{
					this.Cell = new CellInfo();
				}
				this.Cell.MergeFrom(other.Cell);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0004C9E0 File Offset: 0x0004ABE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0004C9EC File Offset: 0x0004ABEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 88U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NIAHBHIGEIL = input.ReadUInt32();
						}
					}
					else
					{
						this.BPJOLPLHEEP = input.ReadUInt32();
					}
				}
				else
				{
					if (this.cell_ == null)
					{
						this.Cell = new CellInfo();
					}
					input.ReadMessage(this.Cell);
				}
			}
		}

		// Token: 0x04000B30 RID: 2864
		private static readonly MessageParser<ChessRogueMoveCellNotify> _parser = new MessageParser<ChessRogueMoveCellNotify>(() => new ChessRogueMoveCellNotify());

		// Token: 0x04000B31 RID: 2865
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B32 RID: 2866
		public const int BPJOLPLHEEPFieldNumber = 11;

		// Token: 0x04000B33 RID: 2867
		private uint bPJOLPLHEEP_;

		// Token: 0x04000B34 RID: 2868
		public const int NIAHBHIGEILFieldNumber = 13;

		// Token: 0x04000B35 RID: 2869
		private uint nIAHBHIGEIL_;

		// Token: 0x04000B36 RID: 2870
		public const int CellFieldNumber = 3;

		// Token: 0x04000B37 RID: 2871
		private CellInfo cell_;
	}
}

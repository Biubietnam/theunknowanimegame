using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F51 RID: 3921
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModifierSelectCellCsReq : IMessage<RogueModifierSelectCellCsReq>, IMessage, IEquatable<RogueModifierSelectCellCsReq>, IDeepCloneable<RogueModifierSelectCellCsReq>, IBufferMessage
	{
		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600AEE4 RID: 44772 RVA: 0x001D6328 File Offset: 0x001D4528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModifierSelectCellCsReq> Parser
		{
			get
			{
				return RogueModifierSelectCellCsReq._parser;
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600AEE5 RID: 44773 RVA: 0x001D632F File Offset: 0x001D452F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModifierSelectCellCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600AEE6 RID: 44774 RVA: 0x001D6341 File Offset: 0x001D4541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModifierSelectCellCsReq.Descriptor;
			}
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x001D6348 File Offset: 0x001D4548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierSelectCellCsReq()
		{
		}

		// Token: 0x0600AEE8 RID: 44776 RVA: 0x001D6350 File Offset: 0x001D4550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierSelectCellCsReq(RogueModifierSelectCellCsReq other) : this()
		{
			this.cellId_ = other.cellId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEE9 RID: 44777 RVA: 0x001D6375 File Offset: 0x001D4575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierSelectCellCsReq Clone()
		{
			return new RogueModifierSelectCellCsReq(this);
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600AEEA RID: 44778 RVA: 0x001D637D File Offset: 0x001D457D
		// (set) Token: 0x0600AEEB RID: 44779 RVA: 0x001D6385 File Offset: 0x001D4585
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

		// Token: 0x0600AEEC RID: 44780 RVA: 0x001D638E File Offset: 0x001D458E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModifierSelectCellCsReq);
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x001D639C File Offset: 0x001D459C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModifierSelectCellCsReq other)
		{
			return other != null && (other == this || (this.CellId == other.CellId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x001D63CC File Offset: 0x001D45CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600AEEF RID: 44783 RVA: 0x001D640B File Offset: 0x001D460B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AEF0 RID: 44784 RVA: 0x001D6413 File Offset: 0x001D4613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x001D641C File Offset: 0x001D461C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CellId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CellId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x001D6450 File Offset: 0x001D4650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x001D648E File Offset: 0x001D468E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModifierSelectCellCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x001D64BF File Offset: 0x001D46BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x001D64C8 File Offset: 0x001D46C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CellId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400472A RID: 18218
		private static readonly MessageParser<RogueModifierSelectCellCsReq> _parser = new MessageParser<RogueModifierSelectCellCsReq>(() => new RogueModifierSelectCellCsReq());

		// Token: 0x0400472B RID: 18219
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400472C RID: 18220
		public const int CellIdFieldNumber = 3;

		// Token: 0x0400472D RID: 18221
		private uint cellId_;
	}
}

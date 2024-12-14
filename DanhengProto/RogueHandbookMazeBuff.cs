using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E9F RID: 3743
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueHandbookMazeBuff : IMessage<RogueHandbookMazeBuff>, IMessage, IEquatable<RogueHandbookMazeBuff>, IDeepCloneable<RogueHandbookMazeBuff>, IBufferMessage
	{
		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0600A73E RID: 42814 RVA: 0x001C2A20 File Offset: 0x001C0C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueHandbookMazeBuff> Parser
		{
			get
			{
				return RogueHandbookMazeBuff._parser;
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0600A73F RID: 42815 RVA: 0x001C2A27 File Offset: 0x001C0C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueHandbookMazeBuffReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0600A740 RID: 42816 RVA: 0x001C2A39 File Offset: 0x001C0C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueHandbookMazeBuff.Descriptor;
			}
		}

		// Token: 0x0600A741 RID: 42817 RVA: 0x001C2A40 File Offset: 0x001C0C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHandbookMazeBuff()
		{
		}

		// Token: 0x0600A742 RID: 42818 RVA: 0x001C2A48 File Offset: 0x001C0C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHandbookMazeBuff(RogueHandbookMazeBuff other) : this()
		{
			this.mazeBuffId_ = other.mazeBuffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A743 RID: 42819 RVA: 0x001C2A6D File Offset: 0x001C0C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHandbookMazeBuff Clone()
		{
			return new RogueHandbookMazeBuff(this);
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0600A744 RID: 42820 RVA: 0x001C2A75 File Offset: 0x001C0C75
		// (set) Token: 0x0600A745 RID: 42821 RVA: 0x001C2A7D File Offset: 0x001C0C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MazeBuffId
		{
			get
			{
				return this.mazeBuffId_;
			}
			set
			{
				this.mazeBuffId_ = value;
			}
		}

		// Token: 0x0600A746 RID: 42822 RVA: 0x001C2A86 File Offset: 0x001C0C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueHandbookMazeBuff);
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x001C2A94 File Offset: 0x001C0C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueHandbookMazeBuff other)
		{
			return other != null && (other == this || (this.MazeBuffId == other.MazeBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A748 RID: 42824 RVA: 0x001C2AC4 File Offset: 0x001C0CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MazeBuffId != 0U)
			{
				num ^= this.MazeBuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x001C2B03 File Offset: 0x001C0D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x001C2B0B File Offset: 0x001C0D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x001C2B14 File Offset: 0x001C0D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MazeBuffId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MazeBuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x001C2B48 File Offset: 0x001C0D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MazeBuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MazeBuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x001C2B86 File Offset: 0x001C0D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueHandbookMazeBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MazeBuffId != 0U)
			{
				this.MazeBuffId = other.MazeBuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x001C2BB7 File Offset: 0x001C0DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A74F RID: 42831 RVA: 0x001C2BC0 File Offset: 0x001C0DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MazeBuffId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400446B RID: 17515
		private static readonly MessageParser<RogueHandbookMazeBuff> _parser = new MessageParser<RogueHandbookMazeBuff>(() => new RogueHandbookMazeBuff());

		// Token: 0x0400446C RID: 17516
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400446D RID: 17517
		public const int MazeBuffIdFieldNumber = 10;

		// Token: 0x0400446E RID: 17518
		private uint mazeBuffId_;
	}
}

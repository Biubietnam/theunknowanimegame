using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002A7 RID: 679
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateActionPointScNotify : IMessage<ChessRogueUpdateActionPointScNotify>, IMessage, IEquatable<ChessRogueUpdateActionPointScNotify>, IDeepCloneable<ChessRogueUpdateActionPointScNotify>, IBufferMessage
	{
		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x000572B5 File Offset: 0x000554B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateActionPointScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateActionPointScNotify._parser;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x000572BC File Offset: 0x000554BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateActionPointScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x000572CE File Offset: 0x000554CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateActionPointScNotify.Descriptor;
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000572D5 File Offset: 0x000554D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateActionPointScNotify()
		{
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000572DD File Offset: 0x000554DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateActionPointScNotify(ChessRogueUpdateActionPointScNotify other) : this()
		{
			this.actionPoint_ = other.actionPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00057302 File Offset: 0x00055502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateActionPointScNotify Clone()
		{
			return new ChessRogueUpdateActionPointScNotify(this);
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0005730A File Offset: 0x0005550A
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x00057312 File Offset: 0x00055512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionPoint
		{
			get
			{
				return this.actionPoint_;
			}
			set
			{
				this.actionPoint_ = value;
			}
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0005731B File Offset: 0x0005551B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateActionPointScNotify);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00057329 File Offset: 0x00055529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateActionPointScNotify other)
		{
			return other != null && (other == this || (this.ActionPoint == other.ActionPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00057358 File Offset: 0x00055558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionPoint != 0)
			{
				num ^= this.ActionPoint.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00057397 File Offset: 0x00055597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0005739F File Offset: 0x0005559F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000573A8 File Offset: 0x000555A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionPoint != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActionPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000573DC File Offset: 0x000555DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionPoint);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0005741A File Offset: 0x0005561A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateActionPointScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionPoint != 0)
			{
				this.ActionPoint = other.ActionPoint;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0005744B File Offset: 0x0005564B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00057454 File Offset: 0x00055654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActionPoint = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000CB1 RID: 3249
		private static readonly MessageParser<ChessRogueUpdateActionPointScNotify> _parser = new MessageParser<ChessRogueUpdateActionPointScNotify>(() => new ChessRogueUpdateActionPointScNotify());

		// Token: 0x04000CB2 RID: 3250
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CB3 RID: 3251
		public const int ActionPointFieldNumber = 15;

		// Token: 0x04000CB4 RID: 3252
		private int actionPoint_;
	}
}

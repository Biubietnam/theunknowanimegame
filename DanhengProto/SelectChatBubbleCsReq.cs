using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200109F RID: 4255
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectChatBubbleCsReq : IMessage<SelectChatBubbleCsReq>, IMessage, IEquatable<SelectChatBubbleCsReq>, IDeepCloneable<SelectChatBubbleCsReq>, IBufferMessage
	{
		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600BDA5 RID: 48549 RVA: 0x001FEF88 File Offset: 0x001FD188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectChatBubbleCsReq> Parser
		{
			get
			{
				return SelectChatBubbleCsReq._parser;
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600BDA6 RID: 48550 RVA: 0x001FEF8F File Offset: 0x001FD18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectChatBubbleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600BDA7 RID: 48551 RVA: 0x001FEFA1 File Offset: 0x001FD1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectChatBubbleCsReq.Descriptor;
			}
		}

		// Token: 0x0600BDA8 RID: 48552 RVA: 0x001FEFA8 File Offset: 0x001FD1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChatBubbleCsReq()
		{
		}

		// Token: 0x0600BDA9 RID: 48553 RVA: 0x001FEFB0 File Offset: 0x001FD1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChatBubbleCsReq(SelectChatBubbleCsReq other) : this()
		{
			this.bubbleId_ = other.bubbleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x001FEFD5 File Offset: 0x001FD1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChatBubbleCsReq Clone()
		{
			return new SelectChatBubbleCsReq(this);
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600BDAB RID: 48555 RVA: 0x001FEFDD File Offset: 0x001FD1DD
		// (set) Token: 0x0600BDAC RID: 48556 RVA: 0x001FEFE5 File Offset: 0x001FD1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BubbleId
		{
			get
			{
				return this.bubbleId_;
			}
			set
			{
				this.bubbleId_ = value;
			}
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x001FEFEE File Offset: 0x001FD1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectChatBubbleCsReq);
		}

		// Token: 0x0600BDAE RID: 48558 RVA: 0x001FEFFC File Offset: 0x001FD1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectChatBubbleCsReq other)
		{
			return other != null && (other == this || (this.BubbleId == other.BubbleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDAF RID: 48559 RVA: 0x001FF02C File Offset: 0x001FD22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BubbleId != 0U)
			{
				num ^= this.BubbleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x001FF06B File Offset: 0x001FD26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x001FF073 File Offset: 0x001FD273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDB2 RID: 48562 RVA: 0x001FF07C File Offset: 0x001FD27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BubbleId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.BubbleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDB3 RID: 48563 RVA: 0x001FF0B0 File Offset: 0x001FD2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BubbleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BubbleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x001FF0EE File Offset: 0x001FD2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectChatBubbleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BubbleId != 0U)
			{
				this.BubbleId = other.BubbleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x001FF11F File Offset: 0x001FD31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDB6 RID: 48566 RVA: 0x001FF128 File Offset: 0x001FD328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BubbleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D18 RID: 19736
		private static readonly MessageParser<SelectChatBubbleCsReq> _parser = new MessageParser<SelectChatBubbleCsReq>(() => new SelectChatBubbleCsReq());

		// Token: 0x04004D19 RID: 19737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D1A RID: 19738
		public const int BubbleIdFieldNumber = 6;

		// Token: 0x04004D1B RID: 19739
		private uint bubbleId_;
	}
}

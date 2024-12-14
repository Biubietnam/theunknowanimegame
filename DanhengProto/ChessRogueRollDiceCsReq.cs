using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200028F RID: 655
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueRollDiceCsReq : IMessage<ChessRogueRollDiceCsReq>, IMessage, IEquatable<ChessRogueRollDiceCsReq>, IDeepCloneable<ChessRogueRollDiceCsReq>, IBufferMessage
	{
		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00053C94 File Offset: 0x00051E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueRollDiceCsReq> Parser
		{
			get
			{
				return ChessRogueRollDiceCsReq._parser;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00053C9B File Offset: 0x00051E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueRollDiceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00053CAD File Offset: 0x00051EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueRollDiceCsReq.Descriptor;
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00053CB4 File Offset: 0x00051EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueRollDiceCsReq()
		{
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00053CBC File Offset: 0x00051EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueRollDiceCsReq(ChessRogueRollDiceCsReq other) : this()
		{
			this.oKCOHJJEEAA_ = other.oKCOHJJEEAA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00053CE1 File Offset: 0x00051EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueRollDiceCsReq Clone()
		{
			return new ChessRogueRollDiceCsReq(this);
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00053CE9 File Offset: 0x00051EE9
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x00053CF1 File Offset: 0x00051EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKCOHJJEEAA
		{
			get
			{
				return this.oKCOHJJEEAA_;
			}
			set
			{
				this.oKCOHJJEEAA_ = value;
			}
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x00053CFA File Offset: 0x00051EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueRollDiceCsReq);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x00053D08 File Offset: 0x00051F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueRollDiceCsReq other)
		{
			return other != null && (other == this || (this.OKCOHJJEEAA == other.OKCOHJJEEAA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00053D38 File Offset: 0x00051F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OKCOHJJEEAA != 0U)
			{
				num ^= this.OKCOHJJEEAA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00053D77 File Offset: 0x00051F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00053D7F File Offset: 0x00051F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00053D88 File Offset: 0x00051F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OKCOHJJEEAA != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.OKCOHJJEEAA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00053DBC File Offset: 0x00051FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OKCOHJJEEAA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKCOHJJEEAA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00053DFA File Offset: 0x00051FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueRollDiceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OKCOHJJEEAA != 0U)
			{
				this.OKCOHJJEEAA = other.OKCOHJJEEAA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00053E2B File Offset: 0x0005202B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00053E34 File Offset: 0x00052034
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
					this.OKCOHJJEEAA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C36 RID: 3126
		private static readonly MessageParser<ChessRogueRollDiceCsReq> _parser = new MessageParser<ChessRogueRollDiceCsReq>(() => new ChessRogueRollDiceCsReq());

		// Token: 0x04000C37 RID: 3127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C38 RID: 3128
		public const int OKCOHJJEEAAFieldNumber = 15;

		// Token: 0x04000C39 RID: 3129
		private uint oKCOHJJEEAA_;
	}
}

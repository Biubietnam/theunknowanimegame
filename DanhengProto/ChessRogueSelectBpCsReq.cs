using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000293 RID: 659
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueSelectBpCsReq : IMessage<ChessRogueSelectBpCsReq>, IMessage, IEquatable<ChessRogueSelectBpCsReq>, IDeepCloneable<ChessRogueSelectBpCsReq>, IBufferMessage
	{
		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0005435C File Offset: 0x0005255C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueSelectBpCsReq> Parser
		{
			get
			{
				return ChessRogueSelectBpCsReq._parser;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00054363 File Offset: 0x00052563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueSelectBpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00054375 File Offset: 0x00052575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueSelectBpCsReq.Descriptor;
			}
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x0005437C File Offset: 0x0005257C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectBpCsReq()
		{
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00054384 File Offset: 0x00052584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectBpCsReq(ChessRogueSelectBpCsReq other) : this()
		{
			this.cBKFEHGFCGJ_ = other.cBKFEHGFCGJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000543A9 File Offset: 0x000525A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectBpCsReq Clone()
		{
			return new ChessRogueSelectBpCsReq(this);
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x000543B1 File Offset: 0x000525B1
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x000543B9 File Offset: 0x000525B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CBKFEHGFCGJ
		{
			get
			{
				return this.cBKFEHGFCGJ_;
			}
			set
			{
				this.cBKFEHGFCGJ_ = value;
			}
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000543C2 File Offset: 0x000525C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueSelectBpCsReq);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000543D0 File Offset: 0x000525D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueSelectBpCsReq other)
		{
			return other != null && (other == this || (this.CBKFEHGFCGJ == other.CBKFEHGFCGJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00054400 File Offset: 0x00052600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CBKFEHGFCGJ != 0U)
			{
				num ^= this.CBKFEHGFCGJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0005443F File Offset: 0x0005263F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00054447 File Offset: 0x00052647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00054450 File Offset: 0x00052650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CBKFEHGFCGJ != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CBKFEHGFCGJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00054484 File Offset: 0x00052684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CBKFEHGFCGJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CBKFEHGFCGJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x000544C2 File Offset: 0x000526C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueSelectBpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CBKFEHGFCGJ != 0U)
			{
				this.CBKFEHGFCGJ = other.CBKFEHGFCGJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x000544F3 File Offset: 0x000526F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x000544FC File Offset: 0x000526FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CBKFEHGFCGJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C44 RID: 3140
		private static readonly MessageParser<ChessRogueSelectBpCsReq> _parser = new MessageParser<ChessRogueSelectBpCsReq>(() => new ChessRogueSelectBpCsReq());

		// Token: 0x04000C45 RID: 3141
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C46 RID: 3142
		public const int CBKFEHGFCGJFieldNumber = 11;

		// Token: 0x04000C47 RID: 3143
		private uint cBKFEHGFCGJ_;
	}
}

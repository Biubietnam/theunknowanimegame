using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000237 RID: 567
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueLeaveCsReq : IMessage<ChessRogueLeaveCsReq>, IMessage, IEquatable<ChessRogueLeaveCsReq>, IDeepCloneable<ChessRogueLeaveCsReq>, IBufferMessage
	{
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x0004A4D3 File Offset: 0x000486D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueLeaveCsReq> Parser
		{
			get
			{
				return ChessRogueLeaveCsReq._parser;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x0004A4DA File Offset: 0x000486DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueLeaveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x0004A4EC File Offset: 0x000486EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueLeaveCsReq.Descriptor;
			}
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0004A4F3 File Offset: 0x000486F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLeaveCsReq()
		{
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0004A4FB File Offset: 0x000486FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLeaveCsReq(ChessRogueLeaveCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0004A514 File Offset: 0x00048714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLeaveCsReq Clone()
		{
			return new ChessRogueLeaveCsReq(this);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0004A51C File Offset: 0x0004871C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueLeaveCsReq);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0004A52A File Offset: 0x0004872A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueLeaveCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0004A548 File Offset: 0x00048748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0004A56E File Offset: 0x0004876E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0004A576 File Offset: 0x00048776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0004A57F File Offset: 0x0004877F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0004A598 File Offset: 0x00048798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0004A5BE File Offset: 0x000487BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueLeaveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0004A5DB File Offset: 0x000487DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0004A5E4 File Offset: 0x000487E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000ADD RID: 2781
		private static readonly MessageParser<ChessRogueLeaveCsReq> _parser = new MessageParser<ChessRogueLeaveCsReq>(() => new ChessRogueLeaveCsReq());

		// Token: 0x04000ADE RID: 2782
		private UnknownFieldSet _unknownFields;
	}
}

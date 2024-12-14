using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CF9 RID: 3321
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrepareRogueAdventureRoomCsReq : IMessage<PrepareRogueAdventureRoomCsReq>, IMessage, IEquatable<PrepareRogueAdventureRoomCsReq>, IDeepCloneable<PrepareRogueAdventureRoomCsReq>, IBufferMessage
	{
		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x0600945E RID: 37982 RVA: 0x0018A9CB File Offset: 0x00188BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrepareRogueAdventureRoomCsReq> Parser
		{
			get
			{
				return PrepareRogueAdventureRoomCsReq._parser;
			}
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x0600945F RID: 37983 RVA: 0x0018A9D2 File Offset: 0x00188BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PrepareRogueAdventureRoomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x06009460 RID: 37984 RVA: 0x0018A9E4 File Offset: 0x00188BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrepareRogueAdventureRoomCsReq.Descriptor;
			}
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x0018A9EB File Offset: 0x00188BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrepareRogueAdventureRoomCsReq()
		{
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x0018A9F3 File Offset: 0x00188BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrepareRogueAdventureRoomCsReq(PrepareRogueAdventureRoomCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x0018AA0C File Offset: 0x00188C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrepareRogueAdventureRoomCsReq Clone()
		{
			return new PrepareRogueAdventureRoomCsReq(this);
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x0018AA14 File Offset: 0x00188C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrepareRogueAdventureRoomCsReq);
		}

		// Token: 0x06009465 RID: 37989 RVA: 0x0018AA22 File Offset: 0x00188C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrepareRogueAdventureRoomCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009466 RID: 37990 RVA: 0x0018AA40 File Offset: 0x00188C40
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

		// Token: 0x06009467 RID: 37991 RVA: 0x0018AA66 File Offset: 0x00188C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x0018AA6E File Offset: 0x00188C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x0018AA77 File Offset: 0x00188C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600946A RID: 37994 RVA: 0x0018AA90 File Offset: 0x00188C90
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

		// Token: 0x0600946B RID: 37995 RVA: 0x0018AAB6 File Offset: 0x00188CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrepareRogueAdventureRoomCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x0018AAD3 File Offset: 0x00188CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x0018AADC File Offset: 0x00188CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003981 RID: 14721
		private static readonly MessageParser<PrepareRogueAdventureRoomCsReq> _parser = new MessageParser<PrepareRogueAdventureRoomCsReq>(() => new PrepareRogueAdventureRoomCsReq());

		// Token: 0x04003982 RID: 14722
		private UnknownFieldSet _unknownFields;
	}
}

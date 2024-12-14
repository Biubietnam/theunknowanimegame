using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007A1 RID: 1953
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueAdventureRoomInfoCsReq : IMessage<GetRogueAdventureRoomInfoCsReq>, IMessage, IEquatable<GetRogueAdventureRoomInfoCsReq>, IDeepCloneable<GetRogueAdventureRoomInfoCsReq>, IBufferMessage
	{
		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x0600573B RID: 22331 RVA: 0x000E9D2B File Offset: 0x000E7F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueAdventureRoomInfoCsReq> Parser
		{
			get
			{
				return GetRogueAdventureRoomInfoCsReq._parser;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x0600573C RID: 22332 RVA: 0x000E9D32 File Offset: 0x000E7F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueAdventureRoomInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x000E9D44 File Offset: 0x000E7F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueAdventureRoomInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600573E RID: 22334 RVA: 0x000E9D4B File Offset: 0x000E7F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAdventureRoomInfoCsReq()
		{
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x000E9D53 File Offset: 0x000E7F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAdventureRoomInfoCsReq(GetRogueAdventureRoomInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x000E9D6C File Offset: 0x000E7F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAdventureRoomInfoCsReq Clone()
		{
			return new GetRogueAdventureRoomInfoCsReq(this);
		}

		// Token: 0x06005741 RID: 22337 RVA: 0x000E9D74 File Offset: 0x000E7F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueAdventureRoomInfoCsReq);
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x000E9D82 File Offset: 0x000E7F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueAdventureRoomInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x000E9DA0 File Offset: 0x000E7FA0
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

		// Token: 0x06005744 RID: 22340 RVA: 0x000E9DC6 File Offset: 0x000E7FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x000E9DCE File Offset: 0x000E7FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x000E9DD7 File Offset: 0x000E7FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x000E9DF0 File Offset: 0x000E7FF0
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

		// Token: 0x06005748 RID: 22344 RVA: 0x000E9E16 File Offset: 0x000E8016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueAdventureRoomInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x000E9E33 File Offset: 0x000E8033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x000E9E3C File Offset: 0x000E803C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400221F RID: 8735
		private static readonly MessageParser<GetRogueAdventureRoomInfoCsReq> _parser = new MessageParser<GetRogueAdventureRoomInfoCsReq>(() => new GetRogueAdventureRoomInfoCsReq());

		// Token: 0x04002220 RID: 8736
		private UnknownFieldSet _unknownFields;
	}
}

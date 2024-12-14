using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200043B RID: 1083
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterChessRogueAeonRoomCsReq : IMessage<EnterChessRogueAeonRoomCsReq>, IMessage, IEquatable<EnterChessRogueAeonRoomCsReq>, IDeepCloneable<EnterChessRogueAeonRoomCsReq>, IBufferMessage
	{
		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x000843D3 File Offset: 0x000825D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterChessRogueAeonRoomCsReq> Parser
		{
			get
			{
				return EnterChessRogueAeonRoomCsReq._parser;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x000843DA File Offset: 0x000825DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterChessRogueAeonRoomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000843EC File Offset: 0x000825EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterChessRogueAeonRoomCsReq.Descriptor;
			}
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x000843F3 File Offset: 0x000825F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChessRogueAeonRoomCsReq()
		{
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x000843FB File Offset: 0x000825FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChessRogueAeonRoomCsReq(EnterChessRogueAeonRoomCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00084414 File Offset: 0x00082614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChessRogueAeonRoomCsReq Clone()
		{
			return new EnterChessRogueAeonRoomCsReq(this);
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0008441C File Offset: 0x0008261C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterChessRogueAeonRoomCsReq);
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x0008442A File Offset: 0x0008262A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterChessRogueAeonRoomCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00084448 File Offset: 0x00082648
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

		// Token: 0x06003023 RID: 12323 RVA: 0x0008446E File Offset: 0x0008266E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x00084476 File Offset: 0x00082676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x0008447F File Offset: 0x0008267F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x00084498 File Offset: 0x00082698
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

		// Token: 0x06003027 RID: 12327 RVA: 0x000844BE File Offset: 0x000826BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterChessRogueAeonRoomCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x000844DB File Offset: 0x000826DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x000844E4 File Offset: 0x000826E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001329 RID: 4905
		private static readonly MessageParser<EnterChessRogueAeonRoomCsReq> _parser = new MessageParser<EnterChessRogueAeonRoomCsReq>(() => new EnterChessRogueAeonRoomCsReq());

		// Token: 0x0400132A RID: 4906
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000653 RID: 1619
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChatFriendHistoryCsReq : IMessage<GetChatFriendHistoryCsReq>, IMessage, IEquatable<GetChatFriendHistoryCsReq>, IDeepCloneable<GetChatFriendHistoryCsReq>, IBufferMessage
	{
		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x000C6917 File Offset: 0x000C4B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChatFriendHistoryCsReq> Parser
		{
			get
			{
				return GetChatFriendHistoryCsReq._parser;
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x000C691E File Offset: 0x000C4B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChatFriendHistoryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x000C6930 File Offset: 0x000C4B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChatFriendHistoryCsReq.Descriptor;
			}
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x000C6937 File Offset: 0x000C4B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatFriendHistoryCsReq()
		{
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x000C693F File Offset: 0x000C4B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatFriendHistoryCsReq(GetChatFriendHistoryCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x000C6958 File Offset: 0x000C4B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatFriendHistoryCsReq Clone()
		{
			return new GetChatFriendHistoryCsReq(this);
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x000C6960 File Offset: 0x000C4B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChatFriendHistoryCsReq);
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x000C696E File Offset: 0x000C4B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChatFriendHistoryCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x000C698C File Offset: 0x000C4B8C
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

		// Token: 0x060048AA RID: 18602 RVA: 0x000C69B2 File Offset: 0x000C4BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x000C69BA File Offset: 0x000C4BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x000C69C3 File Offset: 0x000C4BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x000C69DC File Offset: 0x000C4BDC
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

		// Token: 0x060048AE RID: 18606 RVA: 0x000C6A02 File Offset: 0x000C4C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChatFriendHistoryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x000C6A1F File Offset: 0x000C4C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x000C6A28 File Offset: 0x000C4C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D03 RID: 7427
		private static readonly MessageParser<GetChatFriendHistoryCsReq> _parser = new MessageParser<GetChatFriendHistoryCsReq>(() => new GetChatFriendHistoryCsReq());

		// Token: 0x04001D04 RID: 7428
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200072D RID: 1837
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMonopolyFriendRankingListCsReq : IMessage<GetMonopolyFriendRankingListCsReq>, IMessage, IEquatable<GetMonopolyFriendRankingListCsReq>, IDeepCloneable<GetMonopolyFriendRankingListCsReq>, IBufferMessage
	{
		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06005216 RID: 21014 RVA: 0x000DD037 File Offset: 0x000DB237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMonopolyFriendRankingListCsReq> Parser
		{
			get
			{
				return GetMonopolyFriendRankingListCsReq._parser;
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06005217 RID: 21015 RVA: 0x000DD03E File Offset: 0x000DB23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMonopolyFriendRankingListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x000DD050 File Offset: 0x000DB250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMonopolyFriendRankingListCsReq.Descriptor;
			}
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x000DD057 File Offset: 0x000DB257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyFriendRankingListCsReq()
		{
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x000DD05F File Offset: 0x000DB25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyFriendRankingListCsReq(GetMonopolyFriendRankingListCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x000DD078 File Offset: 0x000DB278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyFriendRankingListCsReq Clone()
		{
			return new GetMonopolyFriendRankingListCsReq(this);
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x000DD080 File Offset: 0x000DB280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMonopolyFriendRankingListCsReq);
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x000DD08E File Offset: 0x000DB28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMonopolyFriendRankingListCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x000DD0AC File Offset: 0x000DB2AC
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

		// Token: 0x0600521F RID: 21023 RVA: 0x000DD0D2 File Offset: 0x000DB2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x000DD0DA File Offset: 0x000DB2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x000DD0E3 File Offset: 0x000DB2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x000DD0FC File Offset: 0x000DB2FC
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

		// Token: 0x06005223 RID: 21027 RVA: 0x000DD122 File Offset: 0x000DB322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMonopolyFriendRankingListCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x000DD13F File Offset: 0x000DB33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x000DD148 File Offset: 0x000DB348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002048 RID: 8264
		private static readonly MessageParser<GetMonopolyFriendRankingListCsReq> _parser = new MessageParser<GetMonopolyFriendRankingListCsReq>(() => new GetMonopolyFriendRankingListCsReq());

		// Token: 0x04002049 RID: 8265
		private UnknownFieldSet _unknownFields;
	}
}

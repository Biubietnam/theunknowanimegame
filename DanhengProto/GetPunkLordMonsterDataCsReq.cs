using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000781 RID: 1921
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPunkLordMonsterDataCsReq : IMessage<GetPunkLordMonsterDataCsReq>, IMessage, IEquatable<GetPunkLordMonsterDataCsReq>, IDeepCloneable<GetPunkLordMonsterDataCsReq>, IBufferMessage
	{
		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x060055D9 RID: 21977 RVA: 0x000E69D7 File Offset: 0x000E4BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPunkLordMonsterDataCsReq> Parser
		{
			get
			{
				return GetPunkLordMonsterDataCsReq._parser;
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x060055DA RID: 21978 RVA: 0x000E69DE File Offset: 0x000E4BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPunkLordMonsterDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x060055DB RID: 21979 RVA: 0x000E69F0 File Offset: 0x000E4BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPunkLordMonsterDataCsReq.Descriptor;
			}
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x000E69F7 File Offset: 0x000E4BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordMonsterDataCsReq()
		{
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x000E69FF File Offset: 0x000E4BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordMonsterDataCsReq(GetPunkLordMonsterDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x000E6A18 File Offset: 0x000E4C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordMonsterDataCsReq Clone()
		{
			return new GetPunkLordMonsterDataCsReq(this);
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x000E6A20 File Offset: 0x000E4C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPunkLordMonsterDataCsReq);
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x000E6A2E File Offset: 0x000E4C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPunkLordMonsterDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x000E6A4C File Offset: 0x000E4C4C
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

		// Token: 0x060055E2 RID: 21986 RVA: 0x000E6A72 File Offset: 0x000E4C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x000E6A7A File Offset: 0x000E4C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x000E6A83 File Offset: 0x000E4C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x000E6A9C File Offset: 0x000E4C9C
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

		// Token: 0x060055E6 RID: 21990 RVA: 0x000E6AC2 File Offset: 0x000E4CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPunkLordMonsterDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x000E6ADF File Offset: 0x000E4CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x000E6AE8 File Offset: 0x000E4CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021A9 RID: 8617
		private static readonly MessageParser<GetPunkLordMonsterDataCsReq> _parser = new MessageParser<GetPunkLordMonsterDataCsReq>(() => new GetPunkLordMonsterDataCsReq());

		// Token: 0x040021AA RID: 8618
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200066F RID: 1647
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurBattleInfoCsReq : IMessage<GetCurBattleInfoCsReq>, IMessage, IEquatable<GetCurBattleInfoCsReq>, IDeepCloneable<GetCurBattleInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x060049CD RID: 18893 RVA: 0x000C9203 File Offset: 0x000C7403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurBattleInfoCsReq> Parser
		{
			get
			{
				return GetCurBattleInfoCsReq._parser;
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060049CE RID: 18894 RVA: 0x000C920A File Offset: 0x000C740A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurBattleInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x000C921C File Offset: 0x000C741C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurBattleInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x000C9223 File Offset: 0x000C7423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurBattleInfoCsReq()
		{
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x000C922B File Offset: 0x000C742B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurBattleInfoCsReq(GetCurBattleInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x000C9244 File Offset: 0x000C7444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurBattleInfoCsReq Clone()
		{
			return new GetCurBattleInfoCsReq(this);
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x000C924C File Offset: 0x000C744C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurBattleInfoCsReq);
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x000C925A File Offset: 0x000C745A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurBattleInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x000C9278 File Offset: 0x000C7478
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

		// Token: 0x060049D6 RID: 18902 RVA: 0x000C929E File Offset: 0x000C749E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x000C92A6 File Offset: 0x000C74A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x000C92AF File Offset: 0x000C74AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x000C92C8 File Offset: 0x000C74C8
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

		// Token: 0x060049DA RID: 18906 RVA: 0x000C92EE File Offset: 0x000C74EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurBattleInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x000C930B File Offset: 0x000C750B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x000C9314 File Offset: 0x000C7514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D5B RID: 7515
		private static readonly MessageParser<GetCurBattleInfoCsReq> _parser = new MessageParser<GetCurBattleInfoCsReq>(() => new GetCurBattleInfoCsReq());

		// Token: 0x04001D5C RID: 7516
		private UnknownFieldSet _unknownFields;
	}
}

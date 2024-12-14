using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200064B RID: 1611
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChapterCsReq : IMessage<GetChapterCsReq>, IMessage, IEquatable<GetChapterCsReq>, IDeepCloneable<GetChapterCsReq>, IBufferMessage
	{
		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x000C5E5A File Offset: 0x000C405A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChapterCsReq> Parser
		{
			get
			{
				return GetChapterCsReq._parser;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600484E RID: 18510 RVA: 0x000C5E61 File Offset: 0x000C4061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChapterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x000C5E73 File Offset: 0x000C4073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChapterCsReq.Descriptor;
			}
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x000C5E7A File Offset: 0x000C407A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterCsReq()
		{
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x000C5E82 File Offset: 0x000C4082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterCsReq(GetChapterCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x000C5E9B File Offset: 0x000C409B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterCsReq Clone()
		{
			return new GetChapterCsReq(this);
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x000C5EA3 File Offset: 0x000C40A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChapterCsReq);
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x000C5EB1 File Offset: 0x000C40B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChapterCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x000C5ED0 File Offset: 0x000C40D0
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

		// Token: 0x06004856 RID: 18518 RVA: 0x000C5EF6 File Offset: 0x000C40F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x000C5EFE File Offset: 0x000C40FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x000C5F07 File Offset: 0x000C4107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x000C5F20 File Offset: 0x000C4120
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

		// Token: 0x0600485A RID: 18522 RVA: 0x000C5F46 File Offset: 0x000C4146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChapterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x000C5F63 File Offset: 0x000C4163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x000C5F6C File Offset: 0x000C416C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CEB RID: 7403
		private static readonly MessageParser<GetChapterCsReq> _parser = new MessageParser<GetChapterCsReq>(() => new GetChapterCsReq());

		// Token: 0x04001CEC RID: 7404
		private UnknownFieldSet _unknownFields;
	}
}

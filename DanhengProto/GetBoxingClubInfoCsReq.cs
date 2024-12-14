using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000637 RID: 1591
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetBoxingClubInfoCsReq : IMessage<GetBoxingClubInfoCsReq>, IMessage, IEquatable<GetBoxingClubInfoCsReq>, IDeepCloneable<GetBoxingClubInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x000C3BE3 File Offset: 0x000C1DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetBoxingClubInfoCsReq> Parser
		{
			get
			{
				return GetBoxingClubInfoCsReq._parser;
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x0600476D RID: 18285 RVA: 0x000C3BEA File Offset: 0x000C1DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetBoxingClubInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x000C3BFC File Offset: 0x000C1DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBoxingClubInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x000C3C03 File Offset: 0x000C1E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBoxingClubInfoCsReq()
		{
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x000C3C0B File Offset: 0x000C1E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBoxingClubInfoCsReq(GetBoxingClubInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x000C3C24 File Offset: 0x000C1E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBoxingClubInfoCsReq Clone()
		{
			return new GetBoxingClubInfoCsReq(this);
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x000C3C2C File Offset: 0x000C1E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBoxingClubInfoCsReq);
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x000C3C3A File Offset: 0x000C1E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetBoxingClubInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x000C3C58 File Offset: 0x000C1E58
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

		// Token: 0x06004775 RID: 18293 RVA: 0x000C3C7E File Offset: 0x000C1E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x000C3C86 File Offset: 0x000C1E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x000C3C8F File Offset: 0x000C1E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x000C3CA8 File Offset: 0x000C1EA8
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

		// Token: 0x06004779 RID: 18297 RVA: 0x000C3CCE File Offset: 0x000C1ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetBoxingClubInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x000C3CEB File Offset: 0x000C1EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x000C3CF4 File Offset: 0x000C1EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C9F RID: 7327
		private static readonly MessageParser<GetBoxingClubInfoCsReq> _parser = new MessageParser<GetBoxingClubInfoCsReq>(() => new GetBoxingClubInfoCsReq());

		// Token: 0x04001CA0 RID: 7328
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005FF RID: 1535
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAetherDivideInfoCsReq : IMessage<GetAetherDivideInfoCsReq>, IMessage, IEquatable<GetAetherDivideInfoCsReq>, IDeepCloneable<GetAetherDivideInfoCsReq>, IBufferMessage
	{
		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x000BCB37 File Offset: 0x000BAD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAetherDivideInfoCsReq> Parser
		{
			get
			{
				return GetAetherDivideInfoCsReq._parser;
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x000BCB3E File Offset: 0x000BAD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAetherDivideInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x000BCB50 File Offset: 0x000BAD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAetherDivideInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x000BCB57 File Offset: 0x000BAD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideInfoCsReq()
		{
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x000BCB5F File Offset: 0x000BAD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideInfoCsReq(GetAetherDivideInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x000BCB78 File Offset: 0x000BAD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideInfoCsReq Clone()
		{
			return new GetAetherDivideInfoCsReq(this);
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x000BCB80 File Offset: 0x000BAD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAetherDivideInfoCsReq);
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x000BCB8E File Offset: 0x000BAD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAetherDivideInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x000BCBAC File Offset: 0x000BADAC
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

		// Token: 0x060044DB RID: 17627 RVA: 0x000BCBD2 File Offset: 0x000BADD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x000BCBDA File Offset: 0x000BADDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x000BCBE3 File Offset: 0x000BADE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x000BCBFC File Offset: 0x000BADFC
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

		// Token: 0x060044DF RID: 17631 RVA: 0x000BCC22 File Offset: 0x000BAE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAetherDivideInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x000BCC3F File Offset: 0x000BAE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x000BCC48 File Offset: 0x000BAE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B89 RID: 7049
		private static readonly MessageParser<GetAetherDivideInfoCsReq> _parser = new MessageParser<GetAetherDivideInfoCsReq>(() => new GetAetherDivideInfoCsReq());

		// Token: 0x04001B8A RID: 7050
		private UnknownFieldSet _unknownFields;
	}
}

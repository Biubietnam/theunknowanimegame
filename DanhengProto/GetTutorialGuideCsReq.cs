using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200083B RID: 2107
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTutorialGuideCsReq : IMessage<GetTutorialGuideCsReq>, IMessage, IEquatable<GetTutorialGuideCsReq>, IDeepCloneable<GetTutorialGuideCsReq>, IBufferMessage
	{
		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x000F8823 File Offset: 0x000F6A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTutorialGuideCsReq> Parser
		{
			get
			{
				return GetTutorialGuideCsReq._parser;
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06005DBD RID: 23997 RVA: 0x000F882A File Offset: 0x000F6A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTutorialGuideCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x000F883C File Offset: 0x000F6A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTutorialGuideCsReq.Descriptor;
			}
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x000F8843 File Offset: 0x000F6A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialGuideCsReq()
		{
		}

		// Token: 0x06005DC0 RID: 24000 RVA: 0x000F884B File Offset: 0x000F6A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialGuideCsReq(GetTutorialGuideCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x000F8864 File Offset: 0x000F6A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialGuideCsReq Clone()
		{
			return new GetTutorialGuideCsReq(this);
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x000F886C File Offset: 0x000F6A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTutorialGuideCsReq);
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x000F887A File Offset: 0x000F6A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTutorialGuideCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x000F8898 File Offset: 0x000F6A98
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

		// Token: 0x06005DC5 RID: 24005 RVA: 0x000F88BE File Offset: 0x000F6ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x000F88C6 File Offset: 0x000F6AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x000F88CF File Offset: 0x000F6ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x000F88E8 File Offset: 0x000F6AE8
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

		// Token: 0x06005DC9 RID: 24009 RVA: 0x000F890E File Offset: 0x000F6B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTutorialGuideCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x000F892B File Offset: 0x000F6B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x000F8934 File Offset: 0x000F6B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002429 RID: 9257
		private static readonly MessageParser<GetTutorialGuideCsReq> _parser = new MessageParser<GetTutorialGuideCsReq>(() => new GetTutorialGuideCsReq());

		// Token: 0x0400242A RID: 9258
		private UnknownFieldSet _unknownFields;
	}
}

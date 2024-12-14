using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000327 RID: 807
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContentPackageGetDataCsReq : IMessage<ContentPackageGetDataCsReq>, IMessage, IEquatable<ContentPackageGetDataCsReq>, IDeepCloneable<ContentPackageGetDataCsReq>, IBufferMessage
	{
		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x00066B03 File Offset: 0x00064D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContentPackageGetDataCsReq> Parser
		{
			get
			{
				return ContentPackageGetDataCsReq._parser;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002432 RID: 9266 RVA: 0x00066B0A File Offset: 0x00064D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentPackageGetDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x00066B1C File Offset: 0x00064D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentPackageGetDataCsReq.Descriptor;
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00066B23 File Offset: 0x00064D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageGetDataCsReq()
		{
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00066B2B File Offset: 0x00064D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageGetDataCsReq(ContentPackageGetDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00066B44 File Offset: 0x00064D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageGetDataCsReq Clone()
		{
			return new ContentPackageGetDataCsReq(this);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00066B4C File Offset: 0x00064D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentPackageGetDataCsReq);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00066B5A File Offset: 0x00064D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContentPackageGetDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00066B78 File Offset: 0x00064D78
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

		// Token: 0x0600243A RID: 9274 RVA: 0x00066B9E File Offset: 0x00064D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00066BA6 File Offset: 0x00064DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00066BAF File Offset: 0x00064DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00066BC8 File Offset: 0x00064DC8
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

		// Token: 0x0600243E RID: 9278 RVA: 0x00066BEE File Offset: 0x00064DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContentPackageGetDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00066C0B File Offset: 0x00064E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00066C14 File Offset: 0x00064E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000ED4 RID: 3796
		private static readonly MessageParser<ContentPackageGetDataCsReq> _parser = new MessageParser<ContentPackageGetDataCsReq>(() => new ContentPackageGetDataCsReq());

		// Token: 0x04000ED5 RID: 3797
		private UnknownFieldSet _unknownFields;
	}
}

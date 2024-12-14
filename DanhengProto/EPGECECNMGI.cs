using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000491 RID: 1169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EPGECECNMGI : IMessage<EPGECECNMGI>, IMessage, IEquatable<EPGECECNMGI>, IDeepCloneable<EPGECECNMGI>, IBufferMessage
	{
		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06003402 RID: 13314 RVA: 0x0008ECD6 File Offset: 0x0008CED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EPGECECNMGI> Parser
		{
			get
			{
				return EPGECECNMGI._parser;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x0008ECDD File Offset: 0x0008CEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EPGECECNMGIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x0008ECEF File Offset: 0x0008CEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EPGECECNMGI.Descriptor;
			}
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x0008ECF6 File Offset: 0x0008CEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EPGECECNMGI()
		{
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x0008ECFE File Offset: 0x0008CEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EPGECECNMGI(EPGECECNMGI other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x0008ED17 File Offset: 0x0008CF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EPGECECNMGI Clone()
		{
			return new EPGECECNMGI(this);
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x0008ED1F File Offset: 0x0008CF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EPGECECNMGI);
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x0008ED2D File Offset: 0x0008CF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EPGECECNMGI other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x0008ED4C File Offset: 0x0008CF4C
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

		// Token: 0x0600340B RID: 13323 RVA: 0x0008ED72 File Offset: 0x0008CF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x0008ED7A File Offset: 0x0008CF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x0008ED83 File Offset: 0x0008CF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x0008ED9C File Offset: 0x0008CF9C
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

		// Token: 0x0600340F RID: 13327 RVA: 0x0008EDC2 File Offset: 0x0008CFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EPGECECNMGI other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x0008EDDF File Offset: 0x0008CFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x0008EDE8 File Offset: 0x0008CFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040014A7 RID: 5287
		private static readonly MessageParser<EPGECECNMGI> _parser = new MessageParser<EPGECECNMGI>(() => new EPGECECNMGI());

		// Token: 0x040014A8 RID: 5288
		private UnknownFieldSet _unknownFields;
	}
}

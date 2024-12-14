using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007FD RID: 2045
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSocialEventServerCacheCsReq : IMessage<GetSocialEventServerCacheCsReq>, IMessage, IEquatable<GetSocialEventServerCacheCsReq>, IDeepCloneable<GetSocialEventServerCacheCsReq>, IBufferMessage
	{
		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06005B3B RID: 23355 RVA: 0x000F30AF File Offset: 0x000F12AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSocialEventServerCacheCsReq> Parser
		{
			get
			{
				return GetSocialEventServerCacheCsReq._parser;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06005B3C RID: 23356 RVA: 0x000F30B6 File Offset: 0x000F12B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSocialEventServerCacheCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06005B3D RID: 23357 RVA: 0x000F30C8 File Offset: 0x000F12C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSocialEventServerCacheCsReq.Descriptor;
			}
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x000F30CF File Offset: 0x000F12CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSocialEventServerCacheCsReq()
		{
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x000F30D7 File Offset: 0x000F12D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSocialEventServerCacheCsReq(GetSocialEventServerCacheCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B40 RID: 23360 RVA: 0x000F30F0 File Offset: 0x000F12F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSocialEventServerCacheCsReq Clone()
		{
			return new GetSocialEventServerCacheCsReq(this);
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x000F30F8 File Offset: 0x000F12F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSocialEventServerCacheCsReq);
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x000F3106 File Offset: 0x000F1306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSocialEventServerCacheCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x000F3124 File Offset: 0x000F1324
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

		// Token: 0x06005B44 RID: 23364 RVA: 0x000F314A File Offset: 0x000F134A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x000F3152 File Offset: 0x000F1352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x000F315B File Offset: 0x000F135B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x000F3174 File Offset: 0x000F1374
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

		// Token: 0x06005B48 RID: 23368 RVA: 0x000F319A File Offset: 0x000F139A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSocialEventServerCacheCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x000F31B7 File Offset: 0x000F13B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x000F31C0 File Offset: 0x000F13C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400235F RID: 9055
		private static readonly MessageParser<GetSocialEventServerCacheCsReq> _parser = new MessageParser<GetSocialEventServerCacheCsReq>(() => new GetSocialEventServerCacheCsReq());

		// Token: 0x04002360 RID: 9056
		private UnknownFieldSet _unknownFields;
	}
}

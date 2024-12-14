using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000849 RID: 2121
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetVideoVersionKeyCsReq : IMessage<GetVideoVersionKeyCsReq>, IMessage, IEquatable<GetVideoVersionKeyCsReq>, IDeepCloneable<GetVideoVersionKeyCsReq>, IBufferMessage
	{
		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06005E4F RID: 24143 RVA: 0x000F9B87 File Offset: 0x000F7D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetVideoVersionKeyCsReq> Parser
		{
			get
			{
				return GetVideoVersionKeyCsReq._parser;
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06005E50 RID: 24144 RVA: 0x000F9B8E File Offset: 0x000F7D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetVideoVersionKeyCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06005E51 RID: 24145 RVA: 0x000F9BA0 File Offset: 0x000F7DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetVideoVersionKeyCsReq.Descriptor;
			}
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x000F9BA7 File Offset: 0x000F7DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetVideoVersionKeyCsReq()
		{
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x000F9BAF File Offset: 0x000F7DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetVideoVersionKeyCsReq(GetVideoVersionKeyCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x000F9BC8 File Offset: 0x000F7DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetVideoVersionKeyCsReq Clone()
		{
			return new GetVideoVersionKeyCsReq(this);
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x000F9BD0 File Offset: 0x000F7DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetVideoVersionKeyCsReq);
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x000F9BDE File Offset: 0x000F7DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetVideoVersionKeyCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x000F9BFC File Offset: 0x000F7DFC
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

		// Token: 0x06005E58 RID: 24152 RVA: 0x000F9C22 File Offset: 0x000F7E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x000F9C2A File Offset: 0x000F7E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x000F9C33 File Offset: 0x000F7E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x000F9C4C File Offset: 0x000F7E4C
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

		// Token: 0x06005E5C RID: 24156 RVA: 0x000F9C72 File Offset: 0x000F7E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetVideoVersionKeyCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x000F9C8F File Offset: 0x000F7E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x000F9C98 File Offset: 0x000F7E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002454 RID: 9300
		private static readonly MessageParser<GetVideoVersionKeyCsReq> _parser = new MessageParser<GetVideoVersionKeyCsReq>(() => new GetVideoVersionKeyCsReq());

		// Token: 0x04002455 RID: 9301
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000731 RID: 1841
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMonopolyInfoCsReq : IMessage<GetMonopolyInfoCsReq>, IMessage, IEquatable<GetMonopolyInfoCsReq>, IDeepCloneable<GetMonopolyInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06005241 RID: 21057 RVA: 0x000DD647 File Offset: 0x000DB847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMonopolyInfoCsReq> Parser
		{
			get
			{
				return GetMonopolyInfoCsReq._parser;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x000DD64E File Offset: 0x000DB84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMonopolyInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06005243 RID: 21059 RVA: 0x000DD660 File Offset: 0x000DB860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMonopolyInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x000DD667 File Offset: 0x000DB867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyInfoCsReq()
		{
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x000DD66F File Offset: 0x000DB86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyInfoCsReq(GetMonopolyInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x000DD688 File Offset: 0x000DB888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyInfoCsReq Clone()
		{
			return new GetMonopolyInfoCsReq(this);
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x000DD690 File Offset: 0x000DB890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMonopolyInfoCsReq);
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x000DD69E File Offset: 0x000DB89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMonopolyInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x000DD6BC File Offset: 0x000DB8BC
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

		// Token: 0x0600524A RID: 21066 RVA: 0x000DD6E2 File Offset: 0x000DB8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x000DD6EA File Offset: 0x000DB8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x000DD6F3 File Offset: 0x000DB8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x000DD70C File Offset: 0x000DB90C
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

		// Token: 0x0600524E RID: 21070 RVA: 0x000DD732 File Offset: 0x000DB932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMonopolyInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x000DD74F File Offset: 0x000DB94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x000DD758 File Offset: 0x000DB958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002055 RID: 8277
		private static readonly MessageParser<GetMonopolyInfoCsReq> _parser = new MessageParser<GetMonopolyInfoCsReq>(() => new GetMonopolyInfoCsReq());

		// Token: 0x04002056 RID: 8278
		private UnknownFieldSet _unknownFields;
	}
}

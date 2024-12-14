using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000745 RID: 1861
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMuseumInfoCsReq : IMessage<GetMuseumInfoCsReq>, IMessage, IEquatable<GetMuseumInfoCsReq>, IDeepCloneable<GetMuseumInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x000DFDB6 File Offset: 0x000DDFB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMuseumInfoCsReq> Parser
		{
			get
			{
				return GetMuseumInfoCsReq._parser;
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06005329 RID: 21289 RVA: 0x000DFDBD File Offset: 0x000DDFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMuseumInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x000DFDCF File Offset: 0x000DDFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMuseumInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x000DFDD6 File Offset: 0x000DDFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMuseumInfoCsReq()
		{
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x000DFDDE File Offset: 0x000DDFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMuseumInfoCsReq(GetMuseumInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x000DFDF7 File Offset: 0x000DDFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMuseumInfoCsReq Clone()
		{
			return new GetMuseumInfoCsReq(this);
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x000DFDFF File Offset: 0x000DDFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMuseumInfoCsReq);
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x000DFE0D File Offset: 0x000DE00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMuseumInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x000DFE2C File Offset: 0x000DE02C
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

		// Token: 0x06005331 RID: 21297 RVA: 0x000DFE52 File Offset: 0x000DE052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x000DFE5A File Offset: 0x000DE05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x000DFE63 File Offset: 0x000DE063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x000DFE7C File Offset: 0x000DE07C
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

		// Token: 0x06005335 RID: 21301 RVA: 0x000DFEA2 File Offset: 0x000DE0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMuseumInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x000DFEBF File Offset: 0x000DE0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x000DFEC8 File Offset: 0x000DE0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020AA RID: 8362
		private static readonly MessageParser<GetMuseumInfoCsReq> _parser = new MessageParser<GetMuseumInfoCsReq>(() => new GetMuseumInfoCsReq());

		// Token: 0x040020AB RID: 8363
		private UnknownFieldSet _unknownFields;
	}
}

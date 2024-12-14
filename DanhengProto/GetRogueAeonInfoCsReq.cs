using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007A5 RID: 1957
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueAeonInfoCsReq : IMessage<GetRogueAeonInfoCsReq>, IMessage, IEquatable<GetRogueAeonInfoCsReq>, IDeepCloneable<GetRogueAeonInfoCsReq>, IBufferMessage
	{
		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x000EA28F File Offset: 0x000E848F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueAeonInfoCsReq> Parser
		{
			get
			{
				return GetRogueAeonInfoCsReq._parser;
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x000EA296 File Offset: 0x000E8496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueAeonInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06005767 RID: 22375 RVA: 0x000EA2A8 File Offset: 0x000E84A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueAeonInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x000EA2AF File Offset: 0x000E84AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAeonInfoCsReq()
		{
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x000EA2B7 File Offset: 0x000E84B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAeonInfoCsReq(GetRogueAeonInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x000EA2D0 File Offset: 0x000E84D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAeonInfoCsReq Clone()
		{
			return new GetRogueAeonInfoCsReq(this);
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x000EA2D8 File Offset: 0x000E84D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueAeonInfoCsReq);
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x000EA2E6 File Offset: 0x000E84E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueAeonInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x000EA304 File Offset: 0x000E8504
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

		// Token: 0x0600576E RID: 22382 RVA: 0x000EA32A File Offset: 0x000E852A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x000EA332 File Offset: 0x000E8532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x000EA33B File Offset: 0x000E853B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x000EA354 File Offset: 0x000E8554
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

		// Token: 0x06005772 RID: 22386 RVA: 0x000EA37A File Offset: 0x000E857A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueAeonInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x000EA397 File Offset: 0x000E8597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x000EA3A0 File Offset: 0x000E85A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002229 RID: 8745
		private static readonly MessageParser<GetRogueAeonInfoCsReq> _parser = new MessageParser<GetRogueAeonInfoCsReq>(() => new GetRogueAeonInfoCsReq());

		// Token: 0x0400222A RID: 8746
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000805 RID: 2053
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStageLineupCsReq : IMessage<GetStageLineupCsReq>, IMessage, IEquatable<GetStageLineupCsReq>, IDeepCloneable<GetStageLineupCsReq>, IBufferMessage
	{
		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06005B90 RID: 23440 RVA: 0x000F3C26 File Offset: 0x000F1E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStageLineupCsReq> Parser
		{
			get
			{
				return GetStageLineupCsReq._parser;
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06005B91 RID: 23441 RVA: 0x000F3C2D File Offset: 0x000F1E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStageLineupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06005B92 RID: 23442 RVA: 0x000F3C3F File Offset: 0x000F1E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStageLineupCsReq.Descriptor;
			}
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x000F3C46 File Offset: 0x000F1E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStageLineupCsReq()
		{
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x000F3C4E File Offset: 0x000F1E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStageLineupCsReq(GetStageLineupCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x000F3C67 File Offset: 0x000F1E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStageLineupCsReq Clone()
		{
			return new GetStageLineupCsReq(this);
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x000F3C6F File Offset: 0x000F1E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStageLineupCsReq);
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x000F3C7D File Offset: 0x000F1E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStageLineupCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x000F3C9C File Offset: 0x000F1E9C
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

		// Token: 0x06005B99 RID: 23449 RVA: 0x000F3CC2 File Offset: 0x000F1EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x000F3CCA File Offset: 0x000F1ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x000F3CD3 File Offset: 0x000F1ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x000F3CEC File Offset: 0x000F1EEC
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

		// Token: 0x06005B9D RID: 23453 RVA: 0x000F3D12 File Offset: 0x000F1F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStageLineupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x000F3D2F File Offset: 0x000F1F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x000F3D38 File Offset: 0x000F1F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002376 RID: 9078
		private static readonly MessageParser<GetStageLineupCsReq> _parser = new MessageParser<GetStageLineupCsReq>(() => new GetStageLineupCsReq());

		// Token: 0x04002377 RID: 9079
		private UnknownFieldSet _unknownFields;
	}
}

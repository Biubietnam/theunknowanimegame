using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200081D RID: 2077
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSwordTrainingDataCsReq : IMessage<GetSwordTrainingDataCsReq>, IMessage, IEquatable<GetSwordTrainingDataCsReq>, IDeepCloneable<GetSwordTrainingDataCsReq>, IBufferMessage
	{
		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06005C7A RID: 23674 RVA: 0x000F5ADF File Offset: 0x000F3CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSwordTrainingDataCsReq> Parser
		{
			get
			{
				return GetSwordTrainingDataCsReq._parser;
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06005C7B RID: 23675 RVA: 0x000F5AE6 File Offset: 0x000F3CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSwordTrainingDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06005C7C RID: 23676 RVA: 0x000F5AF8 File Offset: 0x000F3CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSwordTrainingDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x000F5AFF File Offset: 0x000F3CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSwordTrainingDataCsReq()
		{
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x000F5B07 File Offset: 0x000F3D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSwordTrainingDataCsReq(GetSwordTrainingDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x000F5B20 File Offset: 0x000F3D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSwordTrainingDataCsReq Clone()
		{
			return new GetSwordTrainingDataCsReq(this);
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x000F5B28 File Offset: 0x000F3D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSwordTrainingDataCsReq);
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x000F5B36 File Offset: 0x000F3D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSwordTrainingDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x000F5B54 File Offset: 0x000F3D54
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

		// Token: 0x06005C83 RID: 23683 RVA: 0x000F5B7A File Offset: 0x000F3D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x000F5B82 File Offset: 0x000F3D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x000F5B8B File Offset: 0x000F3D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x000F5BA4 File Offset: 0x000F3DA4
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

		// Token: 0x06005C87 RID: 23687 RVA: 0x000F5BCA File Offset: 0x000F3DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSwordTrainingDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x000F5BE7 File Offset: 0x000F3DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x000F5BF0 File Offset: 0x000F3DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023C1 RID: 9153
		private static readonly MessageParser<GetSwordTrainingDataCsReq> _parser = new MessageParser<GetSwordTrainingDataCsReq>(() => new GetSwordTrainingDataCsReq());

		// Token: 0x040023C2 RID: 9154
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000789 RID: 1929
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetQuestRecordCsReq : IMessage<GetQuestRecordCsReq>, IMessage, IEquatable<GetQuestRecordCsReq>, IDeepCloneable<GetQuestRecordCsReq>, IBufferMessage
	{
		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x0600562D RID: 22061 RVA: 0x000E7492 File Offset: 0x000E5692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetQuestRecordCsReq> Parser
		{
			get
			{
				return GetQuestRecordCsReq._parser;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x0600562E RID: 22062 RVA: 0x000E7499 File Offset: 0x000E5699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetQuestRecordCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x0600562F RID: 22063 RVA: 0x000E74AB File Offset: 0x000E56AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetQuestRecordCsReq.Descriptor;
			}
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x000E74B2 File Offset: 0x000E56B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestRecordCsReq()
		{
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x000E74BA File Offset: 0x000E56BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestRecordCsReq(GetQuestRecordCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x000E74D3 File Offset: 0x000E56D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestRecordCsReq Clone()
		{
			return new GetQuestRecordCsReq(this);
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x000E74DB File Offset: 0x000E56DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetQuestRecordCsReq);
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x000E74E9 File Offset: 0x000E56E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetQuestRecordCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x000E7508 File Offset: 0x000E5708
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

		// Token: 0x06005636 RID: 22070 RVA: 0x000E752E File Offset: 0x000E572E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x000E7536 File Offset: 0x000E5736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x000E753F File Offset: 0x000E573F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x000E7558 File Offset: 0x000E5758
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

		// Token: 0x0600563A RID: 22074 RVA: 0x000E757E File Offset: 0x000E577E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetQuestRecordCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x000E759B File Offset: 0x000E579B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x000E75A4 File Offset: 0x000E57A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021C1 RID: 8641
		private static readonly MessageParser<GetQuestRecordCsReq> _parser = new MessageParser<GetQuestRecordCsReq>(() => new GetQuestRecordCsReq());

		// Token: 0x040021C2 RID: 8642
		private UnknownFieldSet _unknownFields;
	}
}

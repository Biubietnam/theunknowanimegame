using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000845 RID: 2117
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetUpdatedArchiveDataCsReq : IMessage<GetUpdatedArchiveDataCsReq>, IMessage, IEquatable<GetUpdatedArchiveDataCsReq>, IDeepCloneable<GetUpdatedArchiveDataCsReq>, IBufferMessage
	{
		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06005E25 RID: 24101 RVA: 0x000F963B File Offset: 0x000F783B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetUpdatedArchiveDataCsReq> Parser
		{
			get
			{
				return GetUpdatedArchiveDataCsReq._parser;
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06005E26 RID: 24102 RVA: 0x000F9642 File Offset: 0x000F7842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetUpdatedArchiveDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06005E27 RID: 24103 RVA: 0x000F9654 File Offset: 0x000F7854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetUpdatedArchiveDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x000F965B File Offset: 0x000F785B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUpdatedArchiveDataCsReq()
		{
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x000F9663 File Offset: 0x000F7863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUpdatedArchiveDataCsReq(GetUpdatedArchiveDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x000F967C File Offset: 0x000F787C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUpdatedArchiveDataCsReq Clone()
		{
			return new GetUpdatedArchiveDataCsReq(this);
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x000F9684 File Offset: 0x000F7884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetUpdatedArchiveDataCsReq);
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x000F9692 File Offset: 0x000F7892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetUpdatedArchiveDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x000F96B0 File Offset: 0x000F78B0
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

		// Token: 0x06005E2E RID: 24110 RVA: 0x000F96D6 File Offset: 0x000F78D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x000F96DE File Offset: 0x000F78DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x000F96E7 File Offset: 0x000F78E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x000F9700 File Offset: 0x000F7900
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

		// Token: 0x06005E32 RID: 24114 RVA: 0x000F9726 File Offset: 0x000F7926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetUpdatedArchiveDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x000F9743 File Offset: 0x000F7943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x000F974C File Offset: 0x000F794C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400244A RID: 9290
		private static readonly MessageParser<GetUpdatedArchiveDataCsReq> _parser = new MessageParser<GetUpdatedArchiveDataCsReq>(() => new GetUpdatedArchiveDataCsReq());

		// Token: 0x0400244B RID: 9291
		private UnknownFieldSet _unknownFields;
	}
}

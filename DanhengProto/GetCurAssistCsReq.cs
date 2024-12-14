using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200066B RID: 1643
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurAssistCsReq : IMessage<GetCurAssistCsReq>, IMessage, IEquatable<GetCurAssistCsReq>, IDeepCloneable<GetCurAssistCsReq>, IBufferMessage
	{
		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x000C8CA2 File Offset: 0x000C6EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurAssistCsReq> Parser
		{
			get
			{
				return GetCurAssistCsReq._parser;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x000C8CA9 File Offset: 0x000C6EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurAssistCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x000C8CBB File Offset: 0x000C6EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurAssistCsReq.Descriptor;
			}
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x000C8CC2 File Offset: 0x000C6EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurAssistCsReq()
		{
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x000C8CCA File Offset: 0x000C6ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurAssistCsReq(GetCurAssistCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x000C8CE3 File Offset: 0x000C6EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurAssistCsReq Clone()
		{
			return new GetCurAssistCsReq(this);
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x000C8CEB File Offset: 0x000C6EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurAssistCsReq);
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x000C8CF9 File Offset: 0x000C6EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurAssistCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x000C8D18 File Offset: 0x000C6F18
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

		// Token: 0x060049AC RID: 18860 RVA: 0x000C8D3E File Offset: 0x000C6F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x000C8D46 File Offset: 0x000C6F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x000C8D4F File Offset: 0x000C6F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x000C8D68 File Offset: 0x000C6F68
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

		// Token: 0x060049B0 RID: 18864 RVA: 0x000C8D8E File Offset: 0x000C6F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurAssistCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x000C8DAB File Offset: 0x000C6FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x000C8DB4 File Offset: 0x000C6FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D51 RID: 7505
		private static readonly MessageParser<GetCurAssistCsReq> _parser = new MessageParser<GetCurAssistCsReq>(() => new GetCurAssistCsReq());

		// Token: 0x04001D52 RID: 7506
		private UnknownFieldSet _unknownFields;
	}
}

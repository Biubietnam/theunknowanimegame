using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000667 RID: 1639
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCrossInfoCsReq : IMessage<GetCrossInfoCsReq>, IMessage, IEquatable<GetCrossInfoCsReq>, IDeepCloneable<GetCrossInfoCsReq>, IBufferMessage
	{
		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06004975 RID: 18805 RVA: 0x000C861A File Offset: 0x000C681A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCrossInfoCsReq> Parser
		{
			get
			{
				return GetCrossInfoCsReq._parser;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x000C8621 File Offset: 0x000C6821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCrossInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x000C8633 File Offset: 0x000C6833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCrossInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x000C863A File Offset: 0x000C683A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCrossInfoCsReq()
		{
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x000C8642 File Offset: 0x000C6842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCrossInfoCsReq(GetCrossInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x000C865B File Offset: 0x000C685B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCrossInfoCsReq Clone()
		{
			return new GetCrossInfoCsReq(this);
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x000C8663 File Offset: 0x000C6863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCrossInfoCsReq);
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x000C8671 File Offset: 0x000C6871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCrossInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x000C8690 File Offset: 0x000C6890
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

		// Token: 0x0600497E RID: 18814 RVA: 0x000C86B6 File Offset: 0x000C68B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x000C86BE File Offset: 0x000C68BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x000C86C7 File Offset: 0x000C68C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x000C86E0 File Offset: 0x000C68E0
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

		// Token: 0x06004982 RID: 18818 RVA: 0x000C8706 File Offset: 0x000C6906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCrossInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x000C8723 File Offset: 0x000C6923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x000C872C File Offset: 0x000C692C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D43 RID: 7491
		private static readonly MessageParser<GetCrossInfoCsReq> _parser = new MessageParser<GetCrossInfoCsReq>(() => new GetCrossInfoCsReq());

		// Token: 0x04001D44 RID: 7492
		private UnknownFieldSet _unknownFields;
	}
}

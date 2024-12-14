using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006E5 RID: 1765
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetHeartDialInfoCsReq : IMessage<GetHeartDialInfoCsReq>, IMessage, IEquatable<GetHeartDialInfoCsReq>, IDeepCloneable<GetHeartDialInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x000D56F7 File Offset: 0x000D38F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetHeartDialInfoCsReq> Parser
		{
			get
			{
				return GetHeartDialInfoCsReq._parser;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06004EF5 RID: 20213 RVA: 0x000D56FE File Offset: 0x000D38FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetHeartDialInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x000D5710 File Offset: 0x000D3910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetHeartDialInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x000D5717 File Offset: 0x000D3917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetHeartDialInfoCsReq()
		{
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x000D571F File Offset: 0x000D391F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetHeartDialInfoCsReq(GetHeartDialInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x000D5738 File Offset: 0x000D3938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetHeartDialInfoCsReq Clone()
		{
			return new GetHeartDialInfoCsReq(this);
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x000D5740 File Offset: 0x000D3940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetHeartDialInfoCsReq);
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x000D574E File Offset: 0x000D394E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetHeartDialInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x000D576C File Offset: 0x000D396C
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

		// Token: 0x06004EFD RID: 20221 RVA: 0x000D5792 File Offset: 0x000D3992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x000D579A File Offset: 0x000D399A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x000D57A3 File Offset: 0x000D39A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x000D57BC File Offset: 0x000D39BC
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

		// Token: 0x06004F01 RID: 20225 RVA: 0x000D57E2 File Offset: 0x000D39E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetHeartDialInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x000D57FF File Offset: 0x000D39FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x000D5808 File Offset: 0x000D3A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F26 RID: 7974
		private static readonly MessageParser<GetHeartDialInfoCsReq> _parser = new MessageParser<GetHeartDialInfoCsReq>(() => new GetHeartDialInfoCsReq());

		// Token: 0x04001F27 RID: 7975
		private UnknownFieldSet _unknownFields;
	}
}

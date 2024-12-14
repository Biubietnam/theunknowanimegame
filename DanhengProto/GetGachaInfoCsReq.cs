using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006D9 RID: 1753
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetGachaInfoCsReq : IMessage<GetGachaInfoCsReq>, IMessage, IEquatable<GetGachaInfoCsReq>, IDeepCloneable<GetGachaInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06004E6F RID: 20079 RVA: 0x000D43A2 File Offset: 0x000D25A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetGachaInfoCsReq> Parser
		{
			get
			{
				return GetGachaInfoCsReq._parser;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06004E70 RID: 20080 RVA: 0x000D43A9 File Offset: 0x000D25A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetGachaInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06004E71 RID: 20081 RVA: 0x000D43BB File Offset: 0x000D25BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGachaInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x000D43C2 File Offset: 0x000D25C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaInfoCsReq()
		{
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x000D43CA File Offset: 0x000D25CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaInfoCsReq(GetGachaInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x000D43E3 File Offset: 0x000D25E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaInfoCsReq Clone()
		{
			return new GetGachaInfoCsReq(this);
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x000D43EB File Offset: 0x000D25EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGachaInfoCsReq);
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x000D43F9 File Offset: 0x000D25F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetGachaInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x000D4418 File Offset: 0x000D2618
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

		// Token: 0x06004E78 RID: 20088 RVA: 0x000D443E File Offset: 0x000D263E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x000D4446 File Offset: 0x000D2646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x000D444F File Offset: 0x000D264F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x000D4468 File Offset: 0x000D2668
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

		// Token: 0x06004E7C RID: 20092 RVA: 0x000D448E File Offset: 0x000D268E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetGachaInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x000D44AB File Offset: 0x000D26AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x000D44B4 File Offset: 0x000D26B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001EF7 RID: 7927
		private static readonly MessageParser<GetGachaInfoCsReq> _parser = new MessageParser<GetGachaInfoCsReq>(() => new GetGachaInfoCsReq());

		// Token: 0x04001EF8 RID: 7928
		private UnknownFieldSet _unknownFields;
	}
}

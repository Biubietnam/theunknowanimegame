using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200068B RID: 1675
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetEnteredSceneCsReq : IMessage<GetEnteredSceneCsReq>, IMessage, IEquatable<GetEnteredSceneCsReq>, IDeepCloneable<GetEnteredSceneCsReq>, IBufferMessage
	{
		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x000CC1E3 File Offset: 0x000CA3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetEnteredSceneCsReq> Parser
		{
			get
			{
				return GetEnteredSceneCsReq._parser;
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x000CC1EA File Offset: 0x000CA3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetEnteredSceneCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x000CC1FC File Offset: 0x000CA3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetEnteredSceneCsReq.Descriptor;
			}
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x000CC203 File Offset: 0x000CA403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnteredSceneCsReq()
		{
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x000CC20B File Offset: 0x000CA40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnteredSceneCsReq(GetEnteredSceneCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x000CC224 File Offset: 0x000CA424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnteredSceneCsReq Clone()
		{
			return new GetEnteredSceneCsReq(this);
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x000CC22C File Offset: 0x000CA42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetEnteredSceneCsReq);
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x000CC23A File Offset: 0x000CA43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetEnteredSceneCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x000CC258 File Offset: 0x000CA458
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

		// Token: 0x06004B14 RID: 19220 RVA: 0x000CC27E File Offset: 0x000CA47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x000CC286 File Offset: 0x000CA486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x000CC28F File Offset: 0x000CA48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x000CC2A8 File Offset: 0x000CA4A8
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

		// Token: 0x06004B18 RID: 19224 RVA: 0x000CC2CE File Offset: 0x000CA4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetEnteredSceneCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x000CC2EB File Offset: 0x000CA4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x000CC2F4 File Offset: 0x000CA4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001DC5 RID: 7621
		private static readonly MessageParser<GetEnteredSceneCsReq> _parser = new MessageParser<GetEnteredSceneCsReq>(() => new GetEnteredSceneCsReq());

		// Token: 0x04001DC6 RID: 7622
		private UnknownFieldSet _unknownFields;
	}
}

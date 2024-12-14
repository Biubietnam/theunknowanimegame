using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000313 RID: 787
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CommonRogueQueryCsReq : IMessage<CommonRogueQueryCsReq>, IMessage, IEquatable<CommonRogueQueryCsReq>, IDeepCloneable<CommonRogueQueryCsReq>, IBufferMessage
	{
		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x000644CF File Offset: 0x000626CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CommonRogueQueryCsReq> Parser
		{
			get
			{
				return CommonRogueQueryCsReq._parser;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x000644D6 File Offset: 0x000626D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonRogueQueryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000644E8 File Offset: 0x000626E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonRogueQueryCsReq.Descriptor;
			}
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x000644EF File Offset: 0x000626EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueQueryCsReq()
		{
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x000644F7 File Offset: 0x000626F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueQueryCsReq(CommonRogueQueryCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00064510 File Offset: 0x00062710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueQueryCsReq Clone()
		{
			return new CommonRogueQueryCsReq(this);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00064518 File Offset: 0x00062718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonRogueQueryCsReq);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00064526 File Offset: 0x00062726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonRogueQueryCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00064544 File Offset: 0x00062744
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

		// Token: 0x0600234E RID: 9038 RVA: 0x0006456A File Offset: 0x0006276A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00064572 File Offset: 0x00062772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x0006457B File Offset: 0x0006277B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00064594 File Offset: 0x00062794
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

		// Token: 0x06002352 RID: 9042 RVA: 0x000645BA File Offset: 0x000627BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonRogueQueryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x000645D7 File Offset: 0x000627D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x000645E0 File Offset: 0x000627E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000E84 RID: 3716
		private static readonly MessageParser<CommonRogueQueryCsReq> _parser = new MessageParser<CommonRogueQueryCsReq>(() => new CommonRogueQueryCsReq());

		// Token: 0x04000E85 RID: 3717
		private UnknownFieldSet _unknownFields;
	}
}

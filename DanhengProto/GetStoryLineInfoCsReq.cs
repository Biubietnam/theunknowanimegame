using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200080D RID: 2061
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStoryLineInfoCsReq : IMessage<GetStoryLineInfoCsReq>, IMessage, IEquatable<GetStoryLineInfoCsReq>, IDeepCloneable<GetStoryLineInfoCsReq>, IBufferMessage
	{
		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x000F4637 File Offset: 0x000F2837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStoryLineInfoCsReq> Parser
		{
			get
			{
				return GetStoryLineInfoCsReq._parser;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06005BE3 RID: 23523 RVA: 0x000F463E File Offset: 0x000F283E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStoryLineInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x000F4650 File Offset: 0x000F2850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStoryLineInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x000F4657 File Offset: 0x000F2857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStoryLineInfoCsReq()
		{
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x000F465F File Offset: 0x000F285F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStoryLineInfoCsReq(GetStoryLineInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x000F4678 File Offset: 0x000F2878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStoryLineInfoCsReq Clone()
		{
			return new GetStoryLineInfoCsReq(this);
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x000F4680 File Offset: 0x000F2880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStoryLineInfoCsReq);
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x000F468E File Offset: 0x000F288E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStoryLineInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x000F46AC File Offset: 0x000F28AC
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

		// Token: 0x06005BEB RID: 23531 RVA: 0x000F46D2 File Offset: 0x000F28D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x000F46DA File Offset: 0x000F28DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BED RID: 23533 RVA: 0x000F46E3 File Offset: 0x000F28E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x000F46FC File Offset: 0x000F28FC
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

		// Token: 0x06005BEF RID: 23535 RVA: 0x000F4722 File Offset: 0x000F2922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStoryLineInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x000F473F File Offset: 0x000F293F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x000F4748 File Offset: 0x000F2948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400238C RID: 9100
		private static readonly MessageParser<GetStoryLineInfoCsReq> _parser = new MessageParser<GetStoryLineInfoCsReq>(() => new GetStoryLineInfoCsReq());

		// Token: 0x0400238D RID: 9101
		private UnknownFieldSet _unknownFields;
	}
}

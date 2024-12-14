using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000607 RID: 1543
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAllLineupDataCsReq : IMessage<GetAllLineupDataCsReq>, IMessage, IEquatable<GetAllLineupDataCsReq>, IDeepCloneable<GetAllLineupDataCsReq>, IBufferMessage
	{
		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06004540 RID: 17728 RVA: 0x000BE2EB File Offset: 0x000BC4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAllLineupDataCsReq> Parser
		{
			get
			{
				return GetAllLineupDataCsReq._parser;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x000BE2F2 File Offset: 0x000BC4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAllLineupDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06004542 RID: 17730 RVA: 0x000BE304 File Offset: 0x000BC504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllLineupDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x000BE30B File Offset: 0x000BC50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllLineupDataCsReq()
		{
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x000BE313 File Offset: 0x000BC513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllLineupDataCsReq(GetAllLineupDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x000BE32C File Offset: 0x000BC52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllLineupDataCsReq Clone()
		{
			return new GetAllLineupDataCsReq(this);
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x000BE334 File Offset: 0x000BC534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllLineupDataCsReq);
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x000BE342 File Offset: 0x000BC542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAllLineupDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x000BE360 File Offset: 0x000BC560
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

		// Token: 0x06004549 RID: 17737 RVA: 0x000BE386 File Offset: 0x000BC586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x000BE38E File Offset: 0x000BC58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x000BE397 File Offset: 0x000BC597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x000BE3B0 File Offset: 0x000BC5B0
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

		// Token: 0x0600454D RID: 17741 RVA: 0x000BE3D6 File Offset: 0x000BC5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAllLineupDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x000BE3F3 File Offset: 0x000BC5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x000BE3FC File Offset: 0x000BC5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BC7 RID: 7111
		private static readonly MessageParser<GetAllLineupDataCsReq> _parser = new MessageParser<GetAllLineupDataCsReq>(() => new GetAllLineupDataCsReq());

		// Token: 0x04001BC8 RID: 7112
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000801 RID: 2049
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSpringRecoverDataCsReq : IMessage<GetSpringRecoverDataCsReq>, IMessage, IEquatable<GetSpringRecoverDataCsReq>, IDeepCloneable<GetSpringRecoverDataCsReq>, IBufferMessage
	{
		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06005B64 RID: 23396 RVA: 0x000F35CF File Offset: 0x000F17CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSpringRecoverDataCsReq> Parser
		{
			get
			{
				return GetSpringRecoverDataCsReq._parser;
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06005B65 RID: 23397 RVA: 0x000F35D6 File Offset: 0x000F17D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSpringRecoverDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x000F35E8 File Offset: 0x000F17E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSpringRecoverDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x000F35EF File Offset: 0x000F17EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSpringRecoverDataCsReq()
		{
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x000F35F7 File Offset: 0x000F17F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSpringRecoverDataCsReq(GetSpringRecoverDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x000F3610 File Offset: 0x000F1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSpringRecoverDataCsReq Clone()
		{
			return new GetSpringRecoverDataCsReq(this);
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x000F3618 File Offset: 0x000F1818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSpringRecoverDataCsReq);
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x000F3626 File Offset: 0x000F1826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSpringRecoverDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x000F3644 File Offset: 0x000F1844
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

		// Token: 0x06005B6D RID: 23405 RVA: 0x000F366A File Offset: 0x000F186A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x000F3672 File Offset: 0x000F1872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x000F367B File Offset: 0x000F187B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x000F3694 File Offset: 0x000F1894
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

		// Token: 0x06005B71 RID: 23409 RVA: 0x000F36BA File Offset: 0x000F18BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSpringRecoverDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x000F36D7 File Offset: 0x000F18D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x000F36E0 File Offset: 0x000F18E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400236A RID: 9066
		private static readonly MessageParser<GetSpringRecoverDataCsReq> _parser = new MessageParser<GetSpringRecoverDataCsReq>(() => new GetSpringRecoverDataCsReq());

		// Token: 0x0400236B RID: 9067
		private UnknownFieldSet _unknownFields;
	}
}

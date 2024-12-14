using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000795 RID: 1941
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRelicFilterPlanCsReq : IMessage<GetRelicFilterPlanCsReq>, IMessage, IEquatable<GetRelicFilterPlanCsReq>, IDeepCloneable<GetRelicFilterPlanCsReq>, IBufferMessage
	{
		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x060056AB RID: 22187 RVA: 0x000E8607 File Offset: 0x000E6807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRelicFilterPlanCsReq> Parser
		{
			get
			{
				return GetRelicFilterPlanCsReq._parser;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x060056AC RID: 22188 RVA: 0x000E860E File Offset: 0x000E680E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x060056AD RID: 22189 RVA: 0x000E8620 File Offset: 0x000E6820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRelicFilterPlanCsReq.Descriptor;
			}
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x000E8627 File Offset: 0x000E6827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRelicFilterPlanCsReq()
		{
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x000E862F File Offset: 0x000E682F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRelicFilterPlanCsReq(GetRelicFilterPlanCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x000E8648 File Offset: 0x000E6848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRelicFilterPlanCsReq Clone()
		{
			return new GetRelicFilterPlanCsReq(this);
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x000E8650 File Offset: 0x000E6850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRelicFilterPlanCsReq);
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x000E865E File Offset: 0x000E685E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRelicFilterPlanCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x000E867C File Offset: 0x000E687C
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

		// Token: 0x060056B4 RID: 22196 RVA: 0x000E86A2 File Offset: 0x000E68A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x000E86AA File Offset: 0x000E68AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x000E86B3 File Offset: 0x000E68B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x000E86CC File Offset: 0x000E68CC
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

		// Token: 0x060056B8 RID: 22200 RVA: 0x000E86F2 File Offset: 0x000E68F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRelicFilterPlanCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x000E870F File Offset: 0x000E690F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x000E8718 File Offset: 0x000E6918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021EB RID: 8683
		private static readonly MessageParser<GetRelicFilterPlanCsReq> _parser = new MessageParser<GetRelicFilterPlanCsReq>(() => new GetRelicFilterPlanCsReq());

		// Token: 0x040021EC RID: 8684
		private UnknownFieldSet _unknownFields;
	}
}

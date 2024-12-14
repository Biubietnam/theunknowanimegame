using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000785 RID: 1925
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetQuestDataCsReq : IMessage<GetQuestDataCsReq>, IMessage, IEquatable<GetQuestDataCsReq>, IDeepCloneable<GetQuestDataCsReq>, IBufferMessage
	{
		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x000E6EDA File Offset: 0x000E50DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetQuestDataCsReq> Parser
		{
			get
			{
				return GetQuestDataCsReq._parser;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06005603 RID: 22019 RVA: 0x000E6EE1 File Offset: 0x000E50E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetQuestDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06005604 RID: 22020 RVA: 0x000E6EF3 File Offset: 0x000E50F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetQuestDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x000E6EFA File Offset: 0x000E50FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestDataCsReq()
		{
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x000E6F02 File Offset: 0x000E5102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestDataCsReq(GetQuestDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x000E6F1B File Offset: 0x000E511B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestDataCsReq Clone()
		{
			return new GetQuestDataCsReq(this);
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x000E6F23 File Offset: 0x000E5123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetQuestDataCsReq);
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x000E6F31 File Offset: 0x000E5131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetQuestDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x000E6F50 File Offset: 0x000E5150
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

		// Token: 0x0600560B RID: 22027 RVA: 0x000E6F76 File Offset: 0x000E5176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x000E6F7E File Offset: 0x000E517E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x000E6F87 File Offset: 0x000E5187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x000E6FA0 File Offset: 0x000E51A0
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

		// Token: 0x0600560F RID: 22031 RVA: 0x000E6FC6 File Offset: 0x000E51C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetQuestDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x000E6FE3 File Offset: 0x000E51E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x000E6FEC File Offset: 0x000E51EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021B4 RID: 8628
		private static readonly MessageParser<GetQuestDataCsReq> _parser = new MessageParser<GetQuestDataCsReq>(() => new GetQuestDataCsReq());

		// Token: 0x040021B5 RID: 8629
		private UnknownFieldSet _unknownFields;
	}
}

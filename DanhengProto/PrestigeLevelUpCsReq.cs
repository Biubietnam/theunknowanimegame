using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CFD RID: 3325
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrestigeLevelUpCsReq : IMessage<PrestigeLevelUpCsReq>, IMessage, IEquatable<PrestigeLevelUpCsReq>, IDeepCloneable<PrestigeLevelUpCsReq>, IBufferMessage
	{
		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x06009488 RID: 38024 RVA: 0x0018AF2F File Offset: 0x0018912F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrestigeLevelUpCsReq> Parser
		{
			get
			{
				return PrestigeLevelUpCsReq._parser;
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x06009489 RID: 38025 RVA: 0x0018AF36 File Offset: 0x00189136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PrestigeLevelUpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600948A RID: 38026 RVA: 0x0018AF48 File Offset: 0x00189148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrestigeLevelUpCsReq.Descriptor;
			}
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x0018AF4F File Offset: 0x0018914F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrestigeLevelUpCsReq()
		{
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x0018AF57 File Offset: 0x00189157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrestigeLevelUpCsReq(PrestigeLevelUpCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x0018AF70 File Offset: 0x00189170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrestigeLevelUpCsReq Clone()
		{
			return new PrestigeLevelUpCsReq(this);
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x0018AF78 File Offset: 0x00189178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrestigeLevelUpCsReq);
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x0018AF86 File Offset: 0x00189186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrestigeLevelUpCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x0018AFA4 File Offset: 0x001891A4
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

		// Token: 0x06009491 RID: 38033 RVA: 0x0018AFCA File Offset: 0x001891CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x0018AFD2 File Offset: 0x001891D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x0018AFDB File Offset: 0x001891DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x0018AFF4 File Offset: 0x001891F4
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

		// Token: 0x06009495 RID: 38037 RVA: 0x0018B01A File Offset: 0x0018921A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrestigeLevelUpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x0018B037 File Offset: 0x00189237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x0018B040 File Offset: 0x00189240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400398B RID: 14731
		private static readonly MessageParser<PrestigeLevelUpCsReq> _parser = new MessageParser<PrestigeLevelUpCsReq>(() => new PrestigeLevelUpCsReq());

		// Token: 0x0400398C RID: 14732
		private UnknownFieldSet _unknownFields;
	}
}

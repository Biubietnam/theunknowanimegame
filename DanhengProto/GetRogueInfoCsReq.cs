using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007C1 RID: 1985
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueInfoCsReq : IMessage<GetRogueInfoCsReq>, IMessage, IEquatable<GetRogueInfoCsReq>, IDeepCloneable<GetRogueInfoCsReq>, IBufferMessage
	{
		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x0600588D RID: 22669 RVA: 0x000ECA56 File Offset: 0x000EAC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueInfoCsReq> Parser
		{
			get
			{
				return GetRogueInfoCsReq._parser;
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x0600588E RID: 22670 RVA: 0x000ECA5D File Offset: 0x000EAC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x0600588F RID: 22671 RVA: 0x000ECA6F File Offset: 0x000EAC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x000ECA76 File Offset: 0x000EAC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInfoCsReq()
		{
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x000ECA7E File Offset: 0x000EAC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInfoCsReq(GetRogueInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x000ECA97 File Offset: 0x000EAC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInfoCsReq Clone()
		{
			return new GetRogueInfoCsReq(this);
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x000ECA9F File Offset: 0x000EAC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueInfoCsReq);
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x000ECAAD File Offset: 0x000EACAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x000ECACC File Offset: 0x000EACCC
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

		// Token: 0x06005896 RID: 22678 RVA: 0x000ECAF2 File Offset: 0x000EACF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x000ECAFA File Offset: 0x000EACFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x000ECB03 File Offset: 0x000EAD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x000ECB1C File Offset: 0x000EAD1C
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

		// Token: 0x0600589A RID: 22682 RVA: 0x000ECB42 File Offset: 0x000EAD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x000ECB5F File Offset: 0x000EAD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x000ECB68 File Offset: 0x000EAD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002281 RID: 8833
		private static readonly MessageParser<GetRogueInfoCsReq> _parser = new MessageParser<GetRogueInfoCsReq>(() => new GetRogueInfoCsReq());

		// Token: 0x04002282 RID: 8834
		private UnknownFieldSet _unknownFields;
	}
}

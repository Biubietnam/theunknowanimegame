using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000663 RID: 1635
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChessRogueStoryInfoCsReq : IMessage<GetChessRogueStoryInfoCsReq>, IMessage, IEquatable<GetChessRogueStoryInfoCsReq>, IDeepCloneable<GetChessRogueStoryInfoCsReq>, IBufferMessage
	{
		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x000C803B File Offset: 0x000C623B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChessRogueStoryInfoCsReq> Parser
		{
			get
			{
				return GetChessRogueStoryInfoCsReq._parser;
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x000C8042 File Offset: 0x000C6242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChessRogueStoryInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x000C8054 File Offset: 0x000C6254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChessRogueStoryInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x000C805B File Offset: 0x000C625B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryInfoCsReq()
		{
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x000C8063 File Offset: 0x000C6263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryInfoCsReq(GetChessRogueStoryInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x000C807C File Offset: 0x000C627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryInfoCsReq Clone()
		{
			return new GetChessRogueStoryInfoCsReq(this);
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x000C8084 File Offset: 0x000C6284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChessRogueStoryInfoCsReq);
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x000C8092 File Offset: 0x000C6292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChessRogueStoryInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x000C80B0 File Offset: 0x000C62B0
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

		// Token: 0x06004954 RID: 18772 RVA: 0x000C80D6 File Offset: 0x000C62D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x000C80DE File Offset: 0x000C62DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x000C80E7 File Offset: 0x000C62E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x000C8100 File Offset: 0x000C6300
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

		// Token: 0x06004958 RID: 18776 RVA: 0x000C8126 File Offset: 0x000C6326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChessRogueStoryInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x000C8143 File Offset: 0x000C6343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x000C814C File Offset: 0x000C634C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D35 RID: 7477
		private static readonly MessageParser<GetChessRogueStoryInfoCsReq> _parser = new MessageParser<GetChessRogueStoryInfoCsReq>(() => new GetChessRogueStoryInfoCsReq());

		// Token: 0x04001D36 RID: 7478
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000831 RID: 2097
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTreasureDungeonActivityDataCsReq : IMessage<GetTreasureDungeonActivityDataCsReq>, IMessage, IEquatable<GetTreasureDungeonActivityDataCsReq>, IDeepCloneable<GetTreasureDungeonActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06005D55 RID: 23893 RVA: 0x000F7B7B File Offset: 0x000F5D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTreasureDungeonActivityDataCsReq> Parser
		{
			get
			{
				return GetTreasureDungeonActivityDataCsReq._parser;
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06005D56 RID: 23894 RVA: 0x000F7B82 File Offset: 0x000F5D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTreasureDungeonActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06005D57 RID: 23895 RVA: 0x000F7B94 File Offset: 0x000F5D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTreasureDungeonActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x000F7B9B File Offset: 0x000F5D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTreasureDungeonActivityDataCsReq()
		{
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x000F7BA3 File Offset: 0x000F5DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTreasureDungeonActivityDataCsReq(GetTreasureDungeonActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x000F7BBC File Offset: 0x000F5DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTreasureDungeonActivityDataCsReq Clone()
		{
			return new GetTreasureDungeonActivityDataCsReq(this);
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x000F7BC4 File Offset: 0x000F5DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTreasureDungeonActivityDataCsReq);
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x000F7BD2 File Offset: 0x000F5DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTreasureDungeonActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x000F7BF0 File Offset: 0x000F5DF0
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

		// Token: 0x06005D5E RID: 23902 RVA: 0x000F7C16 File Offset: 0x000F5E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x000F7C1E File Offset: 0x000F5E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x000F7C27 File Offset: 0x000F5E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x000F7C40 File Offset: 0x000F5E40
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

		// Token: 0x06005D62 RID: 23906 RVA: 0x000F7C66 File Offset: 0x000F5E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTreasureDungeonActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x000F7C83 File Offset: 0x000F5E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x000F7C8C File Offset: 0x000F5E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400240E RID: 9230
		private static readonly MessageParser<GetTreasureDungeonActivityDataCsReq> _parser = new MessageParser<GetTreasureDungeonActivityDataCsReq>(() => new GetTreasureDungeonActivityDataCsReq());

		// Token: 0x0400240F RID: 9231
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000059 RID: 89
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideRefreshEndlessCsReq : IMessage<AetherDivideRefreshEndlessCsReq>, IMessage, IEquatable<AetherDivideRefreshEndlessCsReq>, IDeepCloneable<AetherDivideRefreshEndlessCsReq>, IBufferMessage
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000B67B File Offset: 0x0000987B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideRefreshEndlessCsReq> Parser
		{
			get
			{
				return AetherDivideRefreshEndlessCsReq._parser;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000B682 File Offset: 0x00009882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideRefreshEndlessCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000B694 File Offset: 0x00009894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideRefreshEndlessCsReq.Descriptor;
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000B69B File Offset: 0x0000989B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessCsReq()
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000B6A3 File Offset: 0x000098A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessCsReq(AetherDivideRefreshEndlessCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000B6BC File Offset: 0x000098BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessCsReq Clone()
		{
			return new AetherDivideRefreshEndlessCsReq(this);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000B6C4 File Offset: 0x000098C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideRefreshEndlessCsReq);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000B6D2 File Offset: 0x000098D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideRefreshEndlessCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000B6F0 File Offset: 0x000098F0
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

		// Token: 0x060003B3 RID: 947 RVA: 0x0000B716 File Offset: 0x00009916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000B71E File Offset: 0x0000991E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000B727 File Offset: 0x00009927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000B740 File Offset: 0x00009940
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

		// Token: 0x060003B7 RID: 951 RVA: 0x0000B766 File Offset: 0x00009966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideRefreshEndlessCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000B783 File Offset: 0x00009983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000B78C File Offset: 0x0000998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000164 RID: 356
		private static readonly MessageParser<AetherDivideRefreshEndlessCsReq> _parser = new MessageParser<AetherDivideRefreshEndlessCsReq>(() => new AetherDivideRefreshEndlessCsReq());

		// Token: 0x04000165 RID: 357
		private UnknownFieldSet _unknownFields;
	}
}

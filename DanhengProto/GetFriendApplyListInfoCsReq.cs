using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006B1 RID: 1713
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendApplyListInfoCsReq : IMessage<GetFriendApplyListInfoCsReq>, IMessage, IEquatable<GetFriendApplyListInfoCsReq>, IDeepCloneable<GetFriendApplyListInfoCsReq>, IBufferMessage
	{
		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06004CA7 RID: 19623 RVA: 0x000CFDC7 File Offset: 0x000CDFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendApplyListInfoCsReq> Parser
		{
			get
			{
				return GetFriendApplyListInfoCsReq._parser;
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x000CFDCE File Offset: 0x000CDFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendApplyListInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06004CA9 RID: 19625 RVA: 0x000CFDE0 File Offset: 0x000CDFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendApplyListInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x000CFDE7 File Offset: 0x000CDFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendApplyListInfoCsReq()
		{
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x000CFDEF File Offset: 0x000CDFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendApplyListInfoCsReq(GetFriendApplyListInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x000CFE08 File Offset: 0x000CE008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendApplyListInfoCsReq Clone()
		{
			return new GetFriendApplyListInfoCsReq(this);
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x000CFE10 File Offset: 0x000CE010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendApplyListInfoCsReq);
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x000CFE1E File Offset: 0x000CE01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendApplyListInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x000CFE3C File Offset: 0x000CE03C
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

		// Token: 0x06004CB0 RID: 19632 RVA: 0x000CFE62 File Offset: 0x000CE062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x000CFE6A File Offset: 0x000CE06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x000CFE73 File Offset: 0x000CE073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x000CFE8C File Offset: 0x000CE08C
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

		// Token: 0x06004CB4 RID: 19636 RVA: 0x000CFEB2 File Offset: 0x000CE0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendApplyListInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x000CFECF File Offset: 0x000CE0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x000CFED8 File Offset: 0x000CE0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E53 RID: 7763
		private static readonly MessageParser<GetFriendApplyListInfoCsReq> _parser = new MessageParser<GetFriendApplyListInfoCsReq>(() => new GetFriendApplyListInfoCsReq());

		// Token: 0x04001E54 RID: 7764
		private UnknownFieldSet _unknownFields;
	}
}

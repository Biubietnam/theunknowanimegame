using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200060F RID: 1551
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAllSaveRaidCsReq : IMessage<GetAllSaveRaidCsReq>, IMessage, IEquatable<GetAllSaveRaidCsReq>, IDeepCloneable<GetAllSaveRaidCsReq>, IBufferMessage
	{
		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x000BEDC6 File Offset: 0x000BCFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAllSaveRaidCsReq> Parser
		{
			get
			{
				return GetAllSaveRaidCsReq._parser;
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x000BEDCD File Offset: 0x000BCFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAllSaveRaidCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x000BEDDF File Offset: 0x000BCFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllSaveRaidCsReq.Descriptor;
			}
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x000BEDE6 File Offset: 0x000BCFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllSaveRaidCsReq()
		{
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x000BEDEE File Offset: 0x000BCFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllSaveRaidCsReq(GetAllSaveRaidCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x000BEE07 File Offset: 0x000BD007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllSaveRaidCsReq Clone()
		{
			return new GetAllSaveRaidCsReq(this);
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x000BEE0F File Offset: 0x000BD00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllSaveRaidCsReq);
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x000BEE1D File Offset: 0x000BD01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAllSaveRaidCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x000BEE3C File Offset: 0x000BD03C
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

		// Token: 0x0600459D RID: 17821 RVA: 0x000BEE62 File Offset: 0x000BD062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x000BEE6A File Offset: 0x000BD06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x000BEE73 File Offset: 0x000BD073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x000BEE8C File Offset: 0x000BD08C
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

		// Token: 0x060045A1 RID: 17825 RVA: 0x000BEEB2 File Offset: 0x000BD0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAllSaveRaidCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x000BEECF File Offset: 0x000BD0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x000BEED8 File Offset: 0x000BD0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BDF RID: 7135
		private static readonly MessageParser<GetAllSaveRaidCsReq> _parser = new MessageParser<GetAllSaveRaidCsReq>(() => new GetAllSaveRaidCsReq());

		// Token: 0x04001BE0 RID: 7136
		private UnknownFieldSet _unknownFields;
	}
}

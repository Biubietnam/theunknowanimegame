using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000735 RID: 1845
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMonopolyMbtiReportRewardCsReq : IMessage<GetMonopolyMbtiReportRewardCsReq>, IMessage, IEquatable<GetMonopolyMbtiReportRewardCsReq>, IDeepCloneable<GetMonopolyMbtiReportRewardCsReq>, IBufferMessage
	{
		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x000DE67B File Offset: 0x000DC87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMonopolyMbtiReportRewardCsReq> Parser
		{
			get
			{
				return GetMonopolyMbtiReportRewardCsReq._parser;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06005281 RID: 21121 RVA: 0x000DE682 File Offset: 0x000DC882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMonopolyMbtiReportRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06005282 RID: 21122 RVA: 0x000DE694 File Offset: 0x000DC894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMonopolyMbtiReportRewardCsReq.Descriptor;
			}
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x000DE69B File Offset: 0x000DC89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyMbtiReportRewardCsReq()
		{
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x000DE6A3 File Offset: 0x000DC8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyMbtiReportRewardCsReq(GetMonopolyMbtiReportRewardCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x000DE6BC File Offset: 0x000DC8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyMbtiReportRewardCsReq Clone()
		{
			return new GetMonopolyMbtiReportRewardCsReq(this);
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x000DE6C4 File Offset: 0x000DC8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMonopolyMbtiReportRewardCsReq);
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x000DE6D2 File Offset: 0x000DC8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMonopolyMbtiReportRewardCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x000DE6F0 File Offset: 0x000DC8F0
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

		// Token: 0x06005289 RID: 21129 RVA: 0x000DE716 File Offset: 0x000DC916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x000DE71E File Offset: 0x000DC91E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x000DE727 File Offset: 0x000DC927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x000DE740 File Offset: 0x000DC940
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

		// Token: 0x0600528D RID: 21133 RVA: 0x000DE766 File Offset: 0x000DC966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMonopolyMbtiReportRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x000DE783 File Offset: 0x000DC983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x000DE78C File Offset: 0x000DC98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002076 RID: 8310
		private static readonly MessageParser<GetMonopolyMbtiReportRewardCsReq> _parser = new MessageParser<GetMonopolyMbtiReportRewardCsReq>(() => new GetMonopolyMbtiReportRewardCsReq());

		// Token: 0x04002077 RID: 8311
		private UnknownFieldSet _unknownFields;
	}
}

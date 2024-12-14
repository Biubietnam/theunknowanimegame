using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006F5 RID: 1781
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLevelRewardTakenListCsReq : IMessage<GetLevelRewardTakenListCsReq>, IMessage, IEquatable<GetLevelRewardTakenListCsReq>, IDeepCloneable<GetLevelRewardTakenListCsReq>, IBufferMessage
	{
		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x000D71B7 File Offset: 0x000D53B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLevelRewardTakenListCsReq> Parser
		{
			get
			{
				return GetLevelRewardTakenListCsReq._parser;
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x000D71BE File Offset: 0x000D53BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLevelRewardTakenListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x000D71D0 File Offset: 0x000D53D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLevelRewardTakenListCsReq.Descriptor;
			}
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x000D71D7 File Offset: 0x000D53D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardTakenListCsReq()
		{
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x000D71DF File Offset: 0x000D53DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardTakenListCsReq(GetLevelRewardTakenListCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x000D71F8 File Offset: 0x000D53F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardTakenListCsReq Clone()
		{
			return new GetLevelRewardTakenListCsReq(this);
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x000D7200 File Offset: 0x000D5400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLevelRewardTakenListCsReq);
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x000D720E File Offset: 0x000D540E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLevelRewardTakenListCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x000D722C File Offset: 0x000D542C
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

		// Token: 0x06004FAF RID: 20399 RVA: 0x000D7252 File Offset: 0x000D5452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x000D725A File Offset: 0x000D545A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x000D7263 File Offset: 0x000D5463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x000D727C File Offset: 0x000D547C
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

		// Token: 0x06004FB3 RID: 20403 RVA: 0x000D72A2 File Offset: 0x000D54A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLevelRewardTakenListCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x000D72BF File Offset: 0x000D54BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x000D72C8 File Offset: 0x000D54C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F64 RID: 8036
		private static readonly MessageParser<GetLevelRewardTakenListCsReq> _parser = new MessageParser<GetLevelRewardTakenListCsReq>(() => new GetLevelRewardTakenListCsReq());

		// Token: 0x04001F65 RID: 8037
		private UnknownFieldSet _unknownFields;
	}
}

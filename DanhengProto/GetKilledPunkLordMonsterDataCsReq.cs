using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006ED RID: 1773
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetKilledPunkLordMonsterDataCsReq : IMessage<GetKilledPunkLordMonsterDataCsReq>, IMessage, IEquatable<GetKilledPunkLordMonsterDataCsReq>, IDeepCloneable<GetKilledPunkLordMonsterDataCsReq>, IBufferMessage
	{
		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06004F4C RID: 20300 RVA: 0x000D644F File Offset: 0x000D464F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetKilledPunkLordMonsterDataCsReq> Parser
		{
			get
			{
				return GetKilledPunkLordMonsterDataCsReq._parser;
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06004F4D RID: 20301 RVA: 0x000D6456 File Offset: 0x000D4656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetKilledPunkLordMonsterDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06004F4E RID: 20302 RVA: 0x000D6468 File Offset: 0x000D4668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetKilledPunkLordMonsterDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x000D646F File Offset: 0x000D466F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetKilledPunkLordMonsterDataCsReq()
		{
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x000D6477 File Offset: 0x000D4677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetKilledPunkLordMonsterDataCsReq(GetKilledPunkLordMonsterDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x000D6490 File Offset: 0x000D4690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetKilledPunkLordMonsterDataCsReq Clone()
		{
			return new GetKilledPunkLordMonsterDataCsReq(this);
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x000D6498 File Offset: 0x000D4698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetKilledPunkLordMonsterDataCsReq);
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x000D64A6 File Offset: 0x000D46A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetKilledPunkLordMonsterDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x000D64C4 File Offset: 0x000D46C4
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

		// Token: 0x06004F55 RID: 20309 RVA: 0x000D64EA File Offset: 0x000D46EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x000D64F2 File Offset: 0x000D46F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x000D64FB File Offset: 0x000D46FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x000D6514 File Offset: 0x000D4714
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

		// Token: 0x06004F59 RID: 20313 RVA: 0x000D653A File Offset: 0x000D473A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetKilledPunkLordMonsterDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x000D6557 File Offset: 0x000D4757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x000D6560 File Offset: 0x000D4760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F46 RID: 8006
		private static readonly MessageParser<GetKilledPunkLordMonsterDataCsReq> _parser = new MessageParser<GetKilledPunkLordMonsterDataCsReq>(() => new GetKilledPunkLordMonsterDataCsReq());

		// Token: 0x04001F47 RID: 8007
		private UnknownFieldSet _unknownFields;
	}
}

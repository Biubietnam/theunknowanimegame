using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006A1 RID: 1697
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFightActivityDataCsReq : IMessage<GetFightActivityDataCsReq>, IMessage, IEquatable<GetFightActivityDataCsReq>, IDeepCloneable<GetFightActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x000CE36B File Offset: 0x000CC56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFightActivityDataCsReq> Parser
		{
			get
			{
				return GetFightActivityDataCsReq._parser;
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x000CE372 File Offset: 0x000CC572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFightActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x000CE384 File Offset: 0x000CC584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFightActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x000CE38B File Offset: 0x000CC58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightActivityDataCsReq()
		{
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x000CE393 File Offset: 0x000CC593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightActivityDataCsReq(GetFightActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x000CE3AC File Offset: 0x000CC5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightActivityDataCsReq Clone()
		{
			return new GetFightActivityDataCsReq(this);
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x000CE3B4 File Offset: 0x000CC5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFightActivityDataCsReq);
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x000CE3C2 File Offset: 0x000CC5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFightActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x000CE3E0 File Offset: 0x000CC5E0
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

		// Token: 0x06004C00 RID: 19456 RVA: 0x000CE406 File Offset: 0x000CC606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x000CE40E File Offset: 0x000CC60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x000CE417 File Offset: 0x000CC617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x000CE430 File Offset: 0x000CC630
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

		// Token: 0x06004C04 RID: 19460 RVA: 0x000CE456 File Offset: 0x000CC656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFightActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x000CE473 File Offset: 0x000CC673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x000CE47C File Offset: 0x000CC67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E13 RID: 7699
		private static readonly MessageParser<GetFightActivityDataCsReq> _parser = new MessageParser<GetFightActivityDataCsReq>(() => new GetFightActivityDataCsReq());

		// Token: 0x04001E14 RID: 7700
		private UnknownFieldSet _unknownFields;
	}
}

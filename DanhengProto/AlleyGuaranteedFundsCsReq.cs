using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000087 RID: 135
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyGuaranteedFundsCsReq : IMessage<AlleyGuaranteedFundsCsReq>, IMessage, IEquatable<AlleyGuaranteedFundsCsReq>, IDeepCloneable<AlleyGuaranteedFundsCsReq>, IBufferMessage
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001055F File Offset: 0x0000E75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyGuaranteedFundsCsReq> Parser
		{
			get
			{
				return AlleyGuaranteedFundsCsReq._parser;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00010566 File Offset: 0x0000E766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyGuaranteedFundsCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00010578 File Offset: 0x0000E778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyGuaranteedFundsCsReq.Descriptor;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0001057F File Offset: 0x0000E77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyGuaranteedFundsCsReq()
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00010587 File Offset: 0x0000E787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyGuaranteedFundsCsReq(AlleyGuaranteedFundsCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000105A0 File Offset: 0x0000E7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyGuaranteedFundsCsReq Clone()
		{
			return new AlleyGuaranteedFundsCsReq(this);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000105A8 File Offset: 0x0000E7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyGuaranteedFundsCsReq);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000105B6 File Offset: 0x0000E7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyGuaranteedFundsCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000105D4 File Offset: 0x0000E7D4
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

		// Token: 0x060005AC RID: 1452 RVA: 0x000105FA File Offset: 0x0000E7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00010602 File Offset: 0x0000E802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001060B File Offset: 0x0000E80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00010624 File Offset: 0x0000E824
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

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001064A File Offset: 0x0000E84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyGuaranteedFundsCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00010667 File Offset: 0x0000E867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00010670 File Offset: 0x0000E870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400021C RID: 540
		private static readonly MessageParser<AlleyGuaranteedFundsCsReq> _parser = new MessageParser<AlleyGuaranteedFundsCsReq>(() => new AlleyGuaranteedFundsCsReq());

		// Token: 0x0400021D RID: 541
		private UnknownFieldSet _unknownFields;
	}
}

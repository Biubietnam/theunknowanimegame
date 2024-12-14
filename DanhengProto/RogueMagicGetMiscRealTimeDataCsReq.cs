using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EDF RID: 3807
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGetMiscRealTimeDataCsReq : IMessage<RogueMagicGetMiscRealTimeDataCsReq>, IMessage, IEquatable<RogueMagicGetMiscRealTimeDataCsReq>, IDeepCloneable<RogueMagicGetMiscRealTimeDataCsReq>, IBufferMessage
	{
		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0600AA32 RID: 43570 RVA: 0x001CAAC3 File Offset: 0x001C8CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGetMiscRealTimeDataCsReq> Parser
		{
			get
			{
				return RogueMagicGetMiscRealTimeDataCsReq._parser;
			}
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0600AA33 RID: 43571 RVA: 0x001CAACA File Offset: 0x001C8CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGetMiscRealTimeDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x0600AA34 RID: 43572 RVA: 0x001CAADC File Offset: 0x001C8CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGetMiscRealTimeDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600AA35 RID: 43573 RVA: 0x001CAAE3 File Offset: 0x001C8CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetMiscRealTimeDataCsReq()
		{
		}

		// Token: 0x0600AA36 RID: 43574 RVA: 0x001CAAEB File Offset: 0x001C8CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetMiscRealTimeDataCsReq(RogueMagicGetMiscRealTimeDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA37 RID: 43575 RVA: 0x001CAB04 File Offset: 0x001C8D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetMiscRealTimeDataCsReq Clone()
		{
			return new RogueMagicGetMiscRealTimeDataCsReq(this);
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x001CAB0C File Offset: 0x001C8D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGetMiscRealTimeDataCsReq);
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x001CAB1A File Offset: 0x001C8D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGetMiscRealTimeDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x001CAB38 File Offset: 0x001C8D38
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

		// Token: 0x0600AA3B RID: 43579 RVA: 0x001CAB5E File Offset: 0x001C8D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x001CAB66 File Offset: 0x001C8D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x001CAB6F File Offset: 0x001C8D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA3E RID: 43582 RVA: 0x001CAB88 File Offset: 0x001C8D88
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

		// Token: 0x0600AA3F RID: 43583 RVA: 0x001CABAE File Offset: 0x001C8DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGetMiscRealTimeDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x001CABCB File Offset: 0x001C8DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA41 RID: 43585 RVA: 0x001CABD4 File Offset: 0x001C8DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004583 RID: 17795
		private static readonly MessageParser<RogueMagicGetMiscRealTimeDataCsReq> _parser = new MessageParser<RogueMagicGetMiscRealTimeDataCsReq>(() => new RogueMagicGetMiscRealTimeDataCsReq());

		// Token: 0x04004584 RID: 17796
		private UnknownFieldSet _unknownFields;
	}
}

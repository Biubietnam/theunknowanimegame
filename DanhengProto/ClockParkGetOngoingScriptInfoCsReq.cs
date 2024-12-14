using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002EF RID: 751
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkGetOngoingScriptInfoCsReq : IMessage<ClockParkGetOngoingScriptInfoCsReq>, IMessage, IEquatable<ClockParkGetOngoingScriptInfoCsReq>, IDeepCloneable<ClockParkGetOngoingScriptInfoCsReq>, IBufferMessage
	{
		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0005F0F7 File Offset: 0x0005D2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkGetOngoingScriptInfoCsReq> Parser
		{
			get
			{
				return ClockParkGetOngoingScriptInfoCsReq._parser;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x0005F0FE File Offset: 0x0005D2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkGetOngoingScriptInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0005F110 File Offset: 0x0005D310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkGetOngoingScriptInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x0005F117 File Offset: 0x0005D317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetOngoingScriptInfoCsReq()
		{
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x0005F11F File Offset: 0x0005D31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetOngoingScriptInfoCsReq(ClockParkGetOngoingScriptInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x0005F138 File Offset: 0x0005D338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetOngoingScriptInfoCsReq Clone()
		{
			return new ClockParkGetOngoingScriptInfoCsReq(this);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0005F140 File Offset: 0x0005D340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkGetOngoingScriptInfoCsReq);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x0005F14E File Offset: 0x0005D34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkGetOngoingScriptInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0005F16C File Offset: 0x0005D36C
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

		// Token: 0x0600218B RID: 8587 RVA: 0x0005F192 File Offset: 0x0005D392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x0005F19A File Offset: 0x0005D39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x0005F1A3 File Offset: 0x0005D3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0005F1BC File Offset: 0x0005D3BC
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

		// Token: 0x0600218F RID: 8591 RVA: 0x0005F1E2 File Offset: 0x0005D3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkGetOngoingScriptInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x0005F1FF File Offset: 0x0005D3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0005F208 File Offset: 0x0005D408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DC9 RID: 3529
		private static readonly MessageParser<ClockParkGetOngoingScriptInfoCsReq> _parser = new MessageParser<ClockParkGetOngoingScriptInfoCsReq>(() => new ClockParkGetOngoingScriptInfoCsReq());

		// Token: 0x04000DCA RID: 3530
		private UnknownFieldSet _unknownFields;
	}
}

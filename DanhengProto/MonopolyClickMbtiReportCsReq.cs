using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B19 RID: 2841
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyClickMbtiReportCsReq : IMessage<MonopolyClickMbtiReportCsReq>, IMessage, IEquatable<MonopolyClickMbtiReportCsReq>, IDeepCloneable<MonopolyClickMbtiReportCsReq>, IBufferMessage
	{
		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06007DC5 RID: 32197 RVA: 0x0014CCF7 File Offset: 0x0014AEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyClickMbtiReportCsReq> Parser
		{
			get
			{
				return MonopolyClickMbtiReportCsReq._parser;
			}
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x06007DC6 RID: 32198 RVA: 0x0014CCFE File Offset: 0x0014AEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyClickMbtiReportCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x06007DC7 RID: 32199 RVA: 0x0014CD10 File Offset: 0x0014AF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyClickMbtiReportCsReq.Descriptor;
			}
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x0014CD17 File Offset: 0x0014AF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickMbtiReportCsReq()
		{
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x0014CD1F File Offset: 0x0014AF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickMbtiReportCsReq(MonopolyClickMbtiReportCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x0014CD38 File Offset: 0x0014AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickMbtiReportCsReq Clone()
		{
			return new MonopolyClickMbtiReportCsReq(this);
		}

		// Token: 0x06007DCB RID: 32203 RVA: 0x0014CD40 File Offset: 0x0014AF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyClickMbtiReportCsReq);
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x0014CD4E File Offset: 0x0014AF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyClickMbtiReportCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x0014CD6C File Offset: 0x0014AF6C
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

		// Token: 0x06007DCE RID: 32206 RVA: 0x0014CD92 File Offset: 0x0014AF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DCF RID: 32207 RVA: 0x0014CD9A File Offset: 0x0014AF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x0014CDA3 File Offset: 0x0014AFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x0014CDBC File Offset: 0x0014AFBC
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

		// Token: 0x06007DD2 RID: 32210 RVA: 0x0014CDE2 File Offset: 0x0014AFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyClickMbtiReportCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007DD3 RID: 32211 RVA: 0x0014CDFF File Offset: 0x0014AFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DD4 RID: 32212 RVA: 0x0014CE08 File Offset: 0x0014B008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400304C RID: 12364
		private static readonly MessageParser<MonopolyClickMbtiReportCsReq> _parser = new MessageParser<MonopolyClickMbtiReportCsReq>(() => new MonopolyClickMbtiReportCsReq());

		// Token: 0x0400304D RID: 12365
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000351 RID: 849
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyFirstMeetPamCsReq : IMessage<DailyFirstMeetPamCsReq>, IMessage, IEquatable<DailyFirstMeetPamCsReq>, IDeepCloneable<DailyFirstMeetPamCsReq>, IBufferMessage
	{
		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x0006AD07 File Offset: 0x00068F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyFirstMeetPamCsReq> Parser
		{
			get
			{
				return DailyFirstMeetPamCsReq._parser;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x0006AD0E File Offset: 0x00068F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyFirstMeetPamCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x0006AD20 File Offset: 0x00068F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyFirstMeetPamCsReq.Descriptor;
			}
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x0006AD27 File Offset: 0x00068F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstMeetPamCsReq()
		{
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x0006AD2F File Offset: 0x00068F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstMeetPamCsReq(DailyFirstMeetPamCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x0006AD48 File Offset: 0x00068F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstMeetPamCsReq Clone()
		{
			return new DailyFirstMeetPamCsReq(this);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x0006AD50 File Offset: 0x00068F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyFirstMeetPamCsReq);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x0006AD5E File Offset: 0x00068F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyFirstMeetPamCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x0006AD7C File Offset: 0x00068F7C
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

		// Token: 0x060025F2 RID: 9714 RVA: 0x0006ADA2 File Offset: 0x00068FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0006ADAA File Offset: 0x00068FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0006ADB3 File Offset: 0x00068FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x0006ADCC File Offset: 0x00068FCC
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

		// Token: 0x060025F6 RID: 9718 RVA: 0x0006ADF2 File Offset: 0x00068FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyFirstMeetPamCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x0006AE0F File Offset: 0x0006900F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x0006AE18 File Offset: 0x00069018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F6F RID: 3951
		private static readonly MessageParser<DailyFirstMeetPamCsReq> _parser = new MessageParser<DailyFirstMeetPamCsReq>(() => new DailyFirstMeetPamCsReq());

		// Token: 0x04000F70 RID: 3952
		private UnknownFieldSet _unknownFields;
	}
}

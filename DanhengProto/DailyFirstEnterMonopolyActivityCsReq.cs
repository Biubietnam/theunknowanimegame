using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200034D RID: 845
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyFirstEnterMonopolyActivityCsReq : IMessage<DailyFirstEnterMonopolyActivityCsReq>, IMessage, IEquatable<DailyFirstEnterMonopolyActivityCsReq>, IDeepCloneable<DailyFirstEnterMonopolyActivityCsReq>, IBufferMessage
	{
		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0006A59B File Offset: 0x0006879B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyFirstEnterMonopolyActivityCsReq> Parser
		{
			get
			{
				return DailyFirstEnterMonopolyActivityCsReq._parser;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x0006A5A2 File Offset: 0x000687A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyFirstEnterMonopolyActivityCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0006A5B4 File Offset: 0x000687B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyFirstEnterMonopolyActivityCsReq.Descriptor;
			}
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x0006A5BB File Offset: 0x000687BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstEnterMonopolyActivityCsReq()
		{
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x0006A5C3 File Offset: 0x000687C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstEnterMonopolyActivityCsReq(DailyFirstEnterMonopolyActivityCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0006A5DC File Offset: 0x000687DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstEnterMonopolyActivityCsReq Clone()
		{
			return new DailyFirstEnterMonopolyActivityCsReq(this);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0006A5E4 File Offset: 0x000687E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyFirstEnterMonopolyActivityCsReq);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0006A5F2 File Offset: 0x000687F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyFirstEnterMonopolyActivityCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0006A610 File Offset: 0x00068810
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

		// Token: 0x060025C2 RID: 9666 RVA: 0x0006A636 File Offset: 0x00068836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0006A63E File Offset: 0x0006883E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0006A647 File Offset: 0x00068847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0006A660 File Offset: 0x00068860
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

		// Token: 0x060025C6 RID: 9670 RVA: 0x0006A686 File Offset: 0x00068886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyFirstEnterMonopolyActivityCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0006A6A3 File Offset: 0x000688A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x0006A6AC File Offset: 0x000688AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F5F RID: 3935
		private static readonly MessageParser<DailyFirstEnterMonopolyActivityCsReq> _parser = new MessageParser<DailyFirstEnterMonopolyActivityCsReq>(() => new DailyFirstEnterMonopolyActivityCsReq());

		// Token: 0x04000F60 RID: 3936
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BC1 RID: 3009
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumRandomEventQueryCsReq : IMessage<MuseumRandomEventQueryCsReq>, IMessage, IEquatable<MuseumRandomEventQueryCsReq>, IDeepCloneable<MuseumRandomEventQueryCsReq>, IBufferMessage
	{
		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x06008535 RID: 34101 RVA: 0x0015FDA0 File Offset: 0x0015DFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumRandomEventQueryCsReq> Parser
		{
			get
			{
				return MuseumRandomEventQueryCsReq._parser;
			}
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x06008536 RID: 34102 RVA: 0x0015FDA7 File Offset: 0x0015DFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumRandomEventQueryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x06008537 RID: 34103 RVA: 0x0015FDB9 File Offset: 0x0015DFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumRandomEventQueryCsReq.Descriptor;
			}
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x0015FDC0 File Offset: 0x0015DFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventQueryCsReq()
		{
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x0015FDC8 File Offset: 0x0015DFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventQueryCsReq(MuseumRandomEventQueryCsReq other) : this()
		{
			this.gJDIBELBCCJ_ = other.gJDIBELBCCJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600853A RID: 34106 RVA: 0x0015FDED File Offset: 0x0015DFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventQueryCsReq Clone()
		{
			return new MuseumRandomEventQueryCsReq(this);
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x0600853B RID: 34107 RVA: 0x0015FDF5 File Offset: 0x0015DFF5
		// (set) Token: 0x0600853C RID: 34108 RVA: 0x0015FDFD File Offset: 0x0015DFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GJDIBELBCCJ
		{
			get
			{
				return this.gJDIBELBCCJ_;
			}
			set
			{
				this.gJDIBELBCCJ_ = value;
			}
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x0015FE06 File Offset: 0x0015E006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumRandomEventQueryCsReq);
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x0015FE14 File Offset: 0x0015E014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumRandomEventQueryCsReq other)
		{
			return other != null && (other == this || (this.GJDIBELBCCJ == other.GJDIBELBCCJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x0015FE44 File Offset: 0x0015E044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GJDIBELBCCJ != 0)
			{
				num ^= this.GJDIBELBCCJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x0015FE83 File Offset: 0x0015E083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x0015FE8B File Offset: 0x0015E08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x0015FE94 File Offset: 0x0015E094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GJDIBELBCCJ != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.GJDIBELBCCJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x0015FEC8 File Offset: 0x0015E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GJDIBELBCCJ != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GJDIBELBCCJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x0015FF06 File Offset: 0x0015E106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumRandomEventQueryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GJDIBELBCCJ != 0)
			{
				this.GJDIBELBCCJ = other.GJDIBELBCCJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x0015FF37 File Offset: 0x0015E137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x0015FF40 File Offset: 0x0015E140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GJDIBELBCCJ = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400330E RID: 13070
		private static readonly MessageParser<MuseumRandomEventQueryCsReq> _parser = new MessageParser<MuseumRandomEventQueryCsReq>(() => new MuseumRandomEventQueryCsReq());

		// Token: 0x0400330F RID: 13071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003310 RID: 13072
		public const int GJDIBELBCCJFieldNumber = 15;

		// Token: 0x04003311 RID: 13073
		private int gJDIBELBCCJ_;
	}
}

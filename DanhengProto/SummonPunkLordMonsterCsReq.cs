using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200120D RID: 4621
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SummonPunkLordMonsterCsReq : IMessage<SummonPunkLordMonsterCsReq>, IMessage, IEquatable<SummonPunkLordMonsterCsReq>, IDeepCloneable<SummonPunkLordMonsterCsReq>, IBufferMessage
	{
		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0600CE8C RID: 52876 RVA: 0x0022A057 File Offset: 0x00228257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SummonPunkLordMonsterCsReq> Parser
		{
			get
			{
				return SummonPunkLordMonsterCsReq._parser;
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0600CE8D RID: 52877 RVA: 0x0022A05E File Offset: 0x0022825E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SummonPunkLordMonsterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0600CE8E RID: 52878 RVA: 0x0022A070 File Offset: 0x00228270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonPunkLordMonsterCsReq.Descriptor;
			}
		}

		// Token: 0x0600CE8F RID: 52879 RVA: 0x0022A077 File Offset: 0x00228277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPunkLordMonsterCsReq()
		{
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x0022A07F File Offset: 0x0022827F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPunkLordMonsterCsReq(SummonPunkLordMonsterCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE91 RID: 52881 RVA: 0x0022A098 File Offset: 0x00228298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPunkLordMonsterCsReq Clone()
		{
			return new SummonPunkLordMonsterCsReq(this);
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x0022A0A0 File Offset: 0x002282A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonPunkLordMonsterCsReq);
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x0022A0AE File Offset: 0x002282AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonPunkLordMonsterCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CE94 RID: 52884 RVA: 0x0022A0CC File Offset: 0x002282CC
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

		// Token: 0x0600CE95 RID: 52885 RVA: 0x0022A0F2 File Offset: 0x002282F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CE96 RID: 52886 RVA: 0x0022A0FA File Offset: 0x002282FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE97 RID: 52887 RVA: 0x0022A103 File Offset: 0x00228303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE98 RID: 52888 RVA: 0x0022A11C File Offset: 0x0022831C
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

		// Token: 0x0600CE99 RID: 52889 RVA: 0x0022A142 File Offset: 0x00228342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonPunkLordMonsterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE9A RID: 52890 RVA: 0x0022A15F File Offset: 0x0022835F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE9B RID: 52891 RVA: 0x0022A168 File Offset: 0x00228368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005332 RID: 21298
		private static readonly MessageParser<SummonPunkLordMonsterCsReq> _parser = new MessageParser<SummonPunkLordMonsterCsReq>(() => new SummonPunkLordMonsterCsReq());

		// Token: 0x04005333 RID: 21299
		private UnknownFieldSet _unknownFields;
	}
}

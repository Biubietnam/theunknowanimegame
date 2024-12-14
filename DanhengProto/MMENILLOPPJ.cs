using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AF7 RID: 2807
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MMENILLOPPJ : IMessage<MMENILLOPPJ>, IMessage, IEquatable<MMENILLOPPJ>, IDeepCloneable<MMENILLOPPJ>, IBufferMessage
	{
		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x06007C34 RID: 31796 RVA: 0x00148F8A File Offset: 0x0014718A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MMENILLOPPJ> Parser
		{
			get
			{
				return MMENILLOPPJ._parser;
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x06007C35 RID: 31797 RVA: 0x00148F91 File Offset: 0x00147191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MMENILLOPPJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x06007C36 RID: 31798 RVA: 0x00148FA3 File Offset: 0x001471A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MMENILLOPPJ.Descriptor;
			}
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x00148FAA File Offset: 0x001471AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MMENILLOPPJ()
		{
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x00148FB2 File Offset: 0x001471B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MMENILLOPPJ(MMENILLOPPJ other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x00148FCB File Offset: 0x001471CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MMENILLOPPJ Clone()
		{
			return new MMENILLOPPJ(this);
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x00148FD3 File Offset: 0x001471D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MMENILLOPPJ);
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x00148FE1 File Offset: 0x001471E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MMENILLOPPJ other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x00149000 File Offset: 0x00147200
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

		// Token: 0x06007C3D RID: 31805 RVA: 0x00149026 File Offset: 0x00147226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x0014902E File Offset: 0x0014722E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x00149037 File Offset: 0x00147237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x00149050 File Offset: 0x00147250
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

		// Token: 0x06007C41 RID: 31809 RVA: 0x00149076 File Offset: 0x00147276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MMENILLOPPJ other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x00149093 File Offset: 0x00147293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x0014909C File Offset: 0x0014729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FC7 RID: 12231
		private static readonly MessageParser<MMENILLOPPJ> _parser = new MessageParser<MMENILLOPPJ>(() => new MMENILLOPPJ());

		// Token: 0x04002FC8 RID: 12232
		private UnknownFieldSet _unknownFields;
	}
}
